using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Security.Cryptography;


namespace passmng
{
    public partial class PwnedCheckControl : UserControl
    {
        public PwnedCheckControl()
        {
            InitializeComponent();
        }

        private void PwnedCheckControl_Load(object sender, EventArgs e)
        {

        }


        public void LoadAccounts(List<(int Id, string AccountName, string Username, string Password)> accounts)
        {
            comboBoxAccounts.Items.Clear();

            foreach (var acc in accounts)
            {
                comboBoxAccounts.Items.Add(new AccountItem { AccountId = acc.Id, AccountName = acc.AccountName, Username = acc.Username, Password = acc.Password });
            }
        }

        private class AccountItem
        {
            public int AccountId { get; set; }
            public string AccountName { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

            public override string ToString()
            {
                return $"{AccountName} ({Username})";
            }

        }

        private async Task<int> CheckPasswordPwnedAsync(string password)
        {
            using (var sha1 = System.Security.Cryptography.SHA1.Create())
            {
                var hashBytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
                var hash = BitConverter.ToString(hashBytes).Replace("-", "").ToUpper();

                string prefix = hash.Substring(0, 5);
                string suffix = hash.Substring(5);

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "PassMngApp");
                    var response = await client.GetStringAsync($"https://api.pwnedpasswords.com/range/{prefix}");

                    var lines = response.Split('\n');
                    foreach (var line in lines)
                    {
                        var parts = line.Split(':');
                        if (parts[0].Trim() == suffix)
                        {
                            return int.Parse(parts[1].Trim());
                        }
                    }
                }
            }

            return 0;
        }

        private async void buttonCheck_Click(object sender, EventArgs e)
        {
            if (comboBoxAccounts.SelectedItem is AccountItem selected)
            {
                int breachCount = await CheckPasswordPwnedAsync(selected.Password);

                if (breachCount > 0)
                {
                    labelResult.Text = $"This password has been seen {breachCount} times in breaches! Change your password now.";
                }
                else
                {
                    labelResult.Text = "This password has not been found in any known breaches.";
                }
            }
        }

        private void comboBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as MainForm;
            if (mainForm != null)
            {

                if (Session.masterPassword != null)
                {
                    var cryptifyApp = new CryptifyAppControl(Session.masterPassword);
                    cryptifyApp.Dock = DockStyle.Fill;
                    mainForm.LoadScreen(cryptifyApp);
                }
            }
        }
    }
}



