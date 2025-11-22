using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passmng
{
    public partial class SignUpControl : UserControl
    {
        public event Action AccountCreated;
        public event Action BackRequested;
        public SignUpControl()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text.Trim();
            string password = textPassword.Text;
            string confirm = textConfirmPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is required.");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty.");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            string hashed = HashPassword(password);

            try
            {
                AddUserToDatabase(username, hashed);
                password = string.Empty;
                AccountCreated?.Invoke();
            }
            catch
            {
                MessageBox.Show("Username already exists.");
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void AddUserToDatabase(string username, string passHashed)
        {
            string dbFile = "users.db";

            using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conn.Open();
                string insertCmd = "INSERT INTO Users (username, passHashed) VALUES (@username, @passHashed);";
                using (var cmd = new SQLiteCommand(insertCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@passHashed", passHashed);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account Created");
                    }
                    catch (SQLiteException ex)
                    {
                        if (ex.ResultCode == SQLiteErrorCode.Constraint)
                            MessageBox.Show("Username already exists!");
                        else
                            MessageBox.Show("Database error: " + ex.Message);
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            BackRequested?.Invoke();
        }
    }
}
