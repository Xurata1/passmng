using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passmng
{
    public partial class CryptifyAppControl : UserControl
    {
        private readonly SecureString masterPassword;
        public CryptifyAppControl(SecureString password)
        {
            InitializeComponent();
            masterPassword = password;
        }



        public void LoadAccounts(List<(string accountName, string username, string password)> accounts)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var acc in accounts)
            {
                var card = new AccountCardControl(acc.accountName, acc.username, acc.password);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void CryptifyAppControl_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUserId.HasValue)
            {
                LoadUserAccounts();
            }
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddAccountForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    string accountName = addForm.AccountName;
                    string username = addForm.Username;
                    string password = addForm.Password;

                    string master = Cryptography.SecureStringToString(Session.masterPassword);
                    DatabaseHelper.AddAccount(Session.CurrentUserId.Value, accountName, username, password, master);

                    AccountCardControl newCard = new AccountCardControl(accountName, username, password);
                    LoadUserAccounts();
                }
            }
        }

        public void LoadUserAccounts()
        {
            flowLayoutPanel1.Controls.Clear();

            if (!Session.CurrentUserId.HasValue)
                return;

            string master = Cryptography.SecureStringToString(Session.masterPassword);
            var accounts = DatabaseHelper.LoadAccounts(Session.CurrentUserId.Value, master);

            foreach (var account in accounts)
            {
                AccountCardControl card = new AccountCardControl(account.AccountName, account.Username, account.Password);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

    }
}

