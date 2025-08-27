using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security;
using System.Security.Cryptography;

namespace passmng
{
    public partial class LoginPageControl : UserControl
    {
        public LoginPageControl()
        {
            InitializeComponent();

            labelCapsLock.Visible = false;
            textBox2.UseSystemPasswordChar = false;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.CapsLockChanged += CheckCapsLock;
        }
        private void InitialiseDatabase()
        {
            string dbFile = "users.db";
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);

            }
            using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conn.Open();
                string tableCmd = @"
                CREATE TABLE IF NOT EXISTS Users (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                username TEXT NOT NULL UNIQUE,
                passHashed TEXT NOT NULL
                );";

                string tableCmdAccounts = @"
                CREATE TABLE IF NOT EXISTS Accounts (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                userId INTEGER NOT NULL,
                accountName TEXT NOT NULL,
                username TEXT NOT NULL,
                password TEXT NOT NULL,
                FOREIGN KEY(userId) REFERENCES Users(id) ON DELETE CASCADE
                );";


                using (var cmd = new SQLiteCommand(tableCmd, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new SQLiteCommand(tableCmdAccounts, conn))
                {
                    cmd.ExecuteNonQuery();
                }

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
                        MessageBox.Show("User registered successfully!");
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

        private int? GetUserId(string username, string password)
        {
            string passHashed = HashPassword(password);
            string dbFile = "users.db";

            using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conn.Open();
                string selectCmd = "SELECT id FROM Users WHERE username = @username AND passHashed = @passHashed;";

                using (var cmd = new SQLiteCommand(selectCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@passHashed", passHashed);
                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            InitialiseDatabase();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            var userId = GetUserId(username, password);
            if (userId.HasValue)
            {
                MessageBox.Show("Login successful!");
                Session.CurrentUserId = userId.Value;
                Session.masterPassword = GetSecurePassword();
                LoginSucceeded?.Invoke(GetSecurePassword());
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            MessageBox.Show($"Username: '{textBox1.Text}', Password: '{textBox2.Text}'");
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both a username and password.");
                return;
            }

            else
            {
                string hashedPassword = HashPassword(password);
                AddUserToDatabase(username, hashedPassword);
                password = string.Empty;
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

        public void CheckCapsLock()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                labelCapsLock.Visible = true;
            }

            else
            {
                labelCapsLock.Visible = false;
            }
        }

        private SecureString GetSecurePassword()
        {
            SecureString securePassword = new SecureString();
            foreach (char c in textBox2.Text)
            {
                securePassword.AppendChar(c);
            }

            securePassword.MakeReadOnly();
            textBox2.Text = string.Empty;
            return securePassword;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        public event Action<SecureString> LoginSucceeded;



    }
}
