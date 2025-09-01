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



        public void LoadAccounts(List<(int accountId, string accountName, string username, string password)> accounts)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var account in accounts)
            {
                AccountCardControl card = new AccountCardControl(account.accountId, account.accountName, account.username, account.password);
                card.AccountClicked += OnAccountCardClicked;

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

                    AccountCardControl newCard = new AccountCardControl(Session.CurrentUserId.Value, accountName, username, password);
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
                AccountCardControl card = new AccountCardControl(account.Id, account.AccountName, account.Username, account.Password);
                card.AccountClicked += OnAccountCardClicked;
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void OnAccountCardClicked(object sender, EventArgs e)
        {
            var card = sender as AccountCardControl;
            if (card == null) return;

            string master = Cryptography.SecureStringToString(Session.masterPassword);

            using (var detailsForm = new AccountDetailsForm(card.AccountId, card.AccountName, card.Username, card.Password, master))
            {
                detailsForm.AccountUpdated += DetailsForm_AccountUpdated;
                detailsForm.ShowDialog();
                detailsForm.AccountUpdated -= DetailsForm_AccountUpdated;
            }
        }


        private void DetailsForm_AccountUpdated(object sender, EventArgs e)
        {
            LoadUserAccounts();
        }

        private void buttonHIBP_Click(object sender, EventArgs e)
        {
            var hibpScreen = new PwnedCheckControl();
            string master = Cryptography.SecureStringToString(Session.masterPassword);
            var accounts = DatabaseHelper.LoadAccounts(Session.CurrentUserId.Value, master);
            var accountsWithIds = accounts
                .Select((acc, index) => (index, acc.AccountName, acc.Username, acc.Password))
                .ToList();

            hibpScreen.LoadAccounts(accountsWithIds);

            var mainForm = this.FindForm() as MainForm;
            mainForm?.LoadScreen(hibpScreen);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Session.CurrentUserId = null;

            if (Session.masterPassword != null)
            {
                try { Session.masterPassword.Dispose();} catch {}
                Session.masterPassword = null;
            }

          
            flowLayoutPanel1.Controls.Clear();

            
            var main = this.FindForm() as MainForm;
            if (main != null)
            {
                main.ShowLoginPage();
            }
            else
            {
                
                this.Parent?.Controls.Remove(this);
            }
        }
    }
}

