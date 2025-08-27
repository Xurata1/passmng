using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace passmng
{
    public static class DatabaseHelper
    {

        public static List<(string AccountName, string Username, string Password)> LoadAccounts(int userId, string masterPassword)
        {
            var accounts = new List<(string, string, string)>();
            string dbFile = "users.db";

            using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conn.Open();
                string selectCmd = @"
                SELECT accountName, username, password
                FROM Accounts
                WHERE userId = @userId;";

                using (var cmd = new SQLiteCommand(selectCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId); 
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string accountName = reader.GetString(0);
                            string username = reader.GetString(1);
                            string encrypted = reader.GetString(2);

                            string decrypted = Cryptography.DecryptString(encrypted, masterPassword);
                            accounts.Add((accountName, username, decrypted));
                        }
                    }
                }
            }

            return accounts;
        }

        public static void AddAccount(int userId, string accountName, string username, string password, string masterPassword)
        {
            string encrypted = Cryptography.EncryptString(password, masterPassword);
            string dbFile = "users.db";
            using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conn.Open();
                string insertCmd = @"
                INSERT INTO Accounts (userId, accountName, username, password)
                VALUES (@userId, @accountName, @username, @password);";

                using (var cmd = new SQLiteCommand(insertCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@accountName", accountName);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", encrypted);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

