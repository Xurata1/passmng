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

        public static List<(int Id, string AccountName, string Username, string Password, string Tags)> LoadAccounts(int userId, string masterPassword) 
        {
            var accounts = new List<(int, string, string, string, string)>();
            string dbFile = "users.db";

            using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conn.Open();
                string selectCmd = @"
                SELECT id, accountName, username, password, tags
                FROM Accounts
                WHERE userId = @userId;";

                using (var cmd = new SQLiteCommand(selectCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string accountName = reader.GetString(1);
                            string username = reader.GetString(2);
                            string encrypted = reader.GetString(3);
                            string tags = reader.IsDBNull(4) ? "" : reader.GetString(4);

                            string decrypted = Cryptography.DecryptString(encrypted, masterPassword);
                            accounts.Add((id, accountName, username, decrypted, tags));
                        }
                    }
                }
            }

            return accounts;
        }

        public static void AddAccount(int userId, string accountName, string username, string password, string tags, string masterPassword)
        {
            string encrypted = Cryptography.EncryptString(password, masterPassword);
            string dbFile = "users.db";
            using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conn.Open();
                string insertCmd = @"
                INSERT INTO Accounts (userId, accountName, username, password, tags)
                VALUES (@userId, @accountName, @username, @password, @tags);";

                using (var cmd = new SQLiteCommand(insertCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@accountName", accountName);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", encrypted);
                    cmd.Parameters.AddWithValue("@tags", tags);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public static void UpdateAccount(int accountId, string accountName, string username, string password, string tags, string masterPassword)
        {
            string encrypted = Cryptography.EncryptString(password, masterPassword);
            string dbFile = "users.db";

            using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conn.Open();
                string updateCmd = @"
                UPDATE Accounts 
                SET accountName = @accountName, username = @username, password = @password, tags = @tags
                WHERE id = @id;";

                using (var cmd = new SQLiteCommand(updateCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@accountName", accountName);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", encrypted);
                    cmd.Parameters.AddWithValue("@tags", tags);
                    cmd.Parameters.AddWithValue("@id", accountId);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteAccount(int accountId)
        {
            string dbFile = "users.db";

            using (var conn = new SQLiteConnection($"Data source={dbFile}; Version=3"))
            {
                conn.Open(); 

                string deleteCmd = "DELETE FROM Accounts WHERE id = @id";

                using (var cmd = new SQLiteCommand(deleteCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@id", accountId);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}

