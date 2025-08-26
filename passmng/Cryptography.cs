using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace passmng
{
    public static class Cryptography
    {
        private const int SaltSize = 16;            // 128-bit salt
        private const int IvSize = 16;              // 128-bit IV for AES-CBC
        private const int Pbkdf2Iterations = 100000;
        private const int KeySizeBytes = 32;        // 256-bit AES key
        private const int HmacKeySizeBytes = 32;    // 256-bit HMAC key

        // Encrypts plaintext with a password. Returns Base64(salt|iv|cipher|hmac)
        public static string EncryptString(string plaintext, string password)
        {
            if (plaintext == null) throw new ArgumentNullException(nameof(plaintext));
            if (password == null) throw new ArgumentNullException(nameof(password));

            byte[] salt = RandomBytes(SaltSize);
            DeriveKeys(password, salt, out byte[] encKey, out byte[] macKey);

            using var aes = Aes.Create();
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            aes.Key = encKey;
            aes.IV = RandomBytes(IvSize);

            byte[] cipherBytes;
            using (var ms = new MemoryStream())
            using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
            using (var sw = new StreamWriter(cs, Encoding.UTF8))
            {
                sw.Write(plaintext);
                sw.Flush();
                cs.FlushFinalBlock();
                cipherBytes = ms.ToArray();
            }

            // HMAC over (IV || ciphertext)
            byte[] ivPlusCipher = Concat(aes.IV, cipherBytes);
            byte[] hmac = ComputeHmac(macKey, ivPlusCipher);

            // Pack: salt | iv | cipher | hmac
            byte[] blob = Concat(Concat(salt, aes.IV), Concat(cipherBytes, hmac));
            return Convert.ToBase64String(blob);
        }

        // Decrypts Base64(salt|iv|cipher|hmac) with password
        public static string DecryptString(string protectedBase64, string password)
        {
            if (protectedBase64 == null) throw new ArgumentNullException(nameof(protectedBase64));
            if (password == null) throw new ArgumentNullException(nameof(password));

            byte[] blob = Convert.FromBase64String(protectedBase64);

            // Parse blob
            if (blob.Length < SaltSize + IvSize + 1 + 32) // very rough sanity check
                throw new CryptographicException("Invalid ciphertext.");

            int offset = 0;
            byte[] salt = SubArray(blob, offset, SaltSize); offset += SaltSize;
            byte[] iv = SubArray(blob, offset, IvSize); offset += IvSize;

            // Remaining: cipher | hmac
            int remaining = blob.Length - offset;
            if (remaining <= 32) throw new CryptographicException("Invalid ciphertext.");
            int cipherLen = remaining - 32;
            byte[] cipher = SubArray(blob, offset, cipherLen); offset += cipherLen;
            byte[] hmac = SubArray(blob, offset, 32);

            // Re-derive keys
            DeriveKeys(password, salt, out byte[] encKey, out byte[] macKey);

            // Verify HMAC first
            byte[] ivPlusCipher = Concat(iv, cipher);
            byte[] expected = ComputeHmac(macKey, ivPlusCipher);
            if (!ConstantTimeEquals(hmac, expected))
                throw new CryptographicException("HMAC validation failed.");

            using var aes = Aes.Create();
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            aes.Key = encKey;
            aes.IV = iv;

            using var ms = new MemoryStream(cipher);
            using var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read);
            using var sr = new StreamReader(cs, Encoding.UTF8);
            return sr.ReadToEnd();
        }

        // ---- helpers ----
        private static void DeriveKeys(string password, byte[] salt, out byte[] encKey, out byte[] macKey)
        {
            using var kdf = new Rfc2898DeriveBytes(password, salt, Pbkdf2Iterations, HashAlgorithmName.SHA256);
            byte[] full = kdf.GetBytes(KeySizeBytes + HmacKeySizeBytes);
            encKey = SubArray(full, 0, KeySizeBytes);
            macKey = SubArray(full, KeySizeBytes, HmacKeySizeBytes);
        }

        private static byte[] RandomBytes(int len)
        {
            var b = new byte[len];
            RandomNumberGenerator.Fill(b);
            return b;
        }

        private static byte[] ComputeHmac(byte[] key, byte[] data)
        {
            using var h = new HMACSHA256(key);
            return h.ComputeHash(data);
        }

        private static byte[] Concat(byte[] a, byte[] b)
        {
            var r = new byte[a.Length + b.Length];
            Buffer.BlockCopy(a, 0, r, 0, a.Length);
            Buffer.BlockCopy(b, 0, r, a.Length, b.Length);
            return r;
        }

        private static byte[] SubArray(byte[] a, int start, int len)
        {
            var r = new byte[len];
            Buffer.BlockCopy(a, start, r, 0, len);
            return r;
        }

        private static bool ConstantTimeEquals(byte[] x, byte[] y)
        {
            if (x.Length != y.Length) return false;
            int diff = 0;
            for (int i = 0; i < x.Length; i++)
                diff |= x[i] ^ y[i];
            return diff == 0;
        }
    }
}
