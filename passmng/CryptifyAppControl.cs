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
using FuzzySharp;

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

        private string tags;
        public string Tags { get { return tags; } }

        private List<(int Id, string AccountName, string Username, string Password, string Tags)> allAccounts = new List<(int, string, string, string, string)>();


        public void DisplayAccounts(List<(int Id, string AccountName, string Username, string Password, string Tags)> accounts)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var account in accounts)
            {
                var card = new AccountCardControl(account.Id, account.AccountName, account.Username, account.Password, account.Tags);
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
            comboSort.Items.AddRange(new string[]
            {
                "Default",
                "Alphabetical (A → Z)",
                "Reverse alphabetical (Z → A)",
                "Newest first"
             });
            comboSort.SelectedIndex = 0;
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
                    string tags = addForm.Tags;

                    string master = Cryptography.SecureStringToString(Session.masterPassword);
                    DatabaseHelper.AddAccount(Session.CurrentUserId.Value, accountName, username, password, tags, master);

                    AccountCardControl newCard = new AccountCardControl(Session.CurrentUserId.Value, accountName, username, password, tags);
                    LoadUserAccounts();
                }
            }
        }

        public void LoadUserAccounts()
        {
            if (!Session.CurrentUserId.HasValue)
                return;

            string master = Cryptography.SecureStringToString(Session.masterPassword);
            allAccounts = DatabaseHelper.LoadAccounts(Session.CurrentUserId.Value, master);

            
            ApplySorting();
        }

        private void OnAccountCardClicked(object sender, EventArgs e)
        {
            var card = sender as AccountCardControl;
            if (card == null) return;

            string master = Cryptography.SecureStringToString(Session.masterPassword);

            using (var detailsForm = new AccountDetailsForm(card.AccountId, card.AccountName, card.Username, card.Password, card.Tags, master))
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
                try { Session.masterPassword.Dispose(); } catch { }
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

        private void searchAccounts()
        {
            if (allAccounts == null || allAccounts.Count == 0)
            {
                return;
            }
            string search = textBoxSearch.Text.Trim();
            if (string.IsNullOrEmpty(search))
            {
                ApplySorting();
                return;
            }

            var filtered = allAccounts
                .Select(acc => new
                {
                    Account = acc,
                    Score = Math.Max
                    (
                        Fuzz.PartialRatio(search, acc.AccountName),
                        Math.Max
                            (
                            Fuzz.PartialRatio(search, acc.Username),
                            Fuzz.PartialRatio(search, acc.Tags)
                            )
                    )
                })
                .Where(x => x.Score > 60)
                .OrderByDescending(x => x.Score)
                .Select(x => x.Account)
                .ToList();
            ApplySortingToList(filtered);
        }

        private void ApplySorting()
        {
            if (allAccounts == null || allAccounts.Count == 0)
                return;

            List<(int Id, string AccountName, string Username, string Password, string Tags)> sorted;

            switch (comboSort.SelectedItem?.ToString())
            {
                case "Alphabetical (A → Z)":
                    sorted = allAccounts
                        .OrderBy(a => a.AccountName.ToLower())
                        .ToList();
                    break;

                case "Reverse alphabetical (Z → A)":
                    sorted = allAccounts
                        .OrderByDescending(a => a.AccountName.ToLower())
                        .ToList();
                    break;

                case "Newest first":
                    sorted = allAccounts
                        .OrderByDescending(a => a.Id)
                        .ToList();
                    break;

                case "Default":
                default:
                    sorted = allAccounts;
                    break;
            }

            DisplayAccounts(sorted);   
        }

        private void ApplySortingToList(List<(int Id, string AccountName, string Username, string Password, string Tags)> list)
        {
            if (list == null || list.Count == 0)
            {
                DisplayAccounts(list);
                return;
            }

      
            var sorted = list.ToList();

            switch (comboSort.SelectedItem?.ToString())
            {
                case "Alphabetical (A → Z)":
                    sorted = sorted
                        .OrderBy(a => a.AccountName.ToLower())
                        .ToList();
                    break;

                case "Reverse Alphabetical (Z→A)":
                    sorted = sorted
                        .OrderByDescending(a => a.AccountName.ToLower())
                        .ToList();
                    break;

                case "Newest first":
                    sorted = sorted
                        .OrderByDescending(a => a.Id)
                        .ToList();
                    break;

                case "Default":
                default:
                    break;
            }

            DisplayAccounts(sorted);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            searchAccounts();

        }

        private void comboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySorting();
        }
    }
}

