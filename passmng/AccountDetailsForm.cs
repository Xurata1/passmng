using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passmng
{
    public partial class AccountDetailsForm : Form
    {
        private int accountId;
        private string masterPassword;
        private bool showPassword = false;
        public event EventHandler AccountUpdated;

        public AccountDetailsForm(int accountId, string accountName, string username, string password, string tags, string masterPassword)
        {
            InitializeComponent();
            this.accountId = accountId;
            this.masterPassword = masterPassword;

            comboBoxTags.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxTags.Items.AddRange
            (
                new string[]
                {
                    "Email",
                    "Social",
                    "Banking",
                    "Shopping",
                    "Gaming",
                    "Work",
                    "School",
                    "Finance",
                    "Utilities",
                    "Other"
                }
            );

            txtAccountName.Text = accountName;
            txtUsername.Text = username;
            txtPassword.Text = password;
            txtPassword.UseSystemPasswordChar = true;
            comboBoxTags.SelectedItem = tags;
            
        }

        private void buttonTogglePassword_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;

            if (showPassword)
            {
                txtPassword.UseSystemPasswordChar = false;
                buttonTogglePassword.Image = Properties.Resources.eye_open;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                buttonTogglePassword.Image = Properties.Resources.eye_closed;
            }
        }

        private void buttonDetailsSave_Click(object sender, EventArgs e)
        {
            string newAccountName = txtAccountName.Text;
            string newUsername = txtUsername.Text;
            string newTags = comboBoxTags.SelectedItem?.ToString() ?? "Other";
            string newPassword = txtPassword.Text;
            

            DatabaseHelper.UpdateAccount(accountId, newAccountName, newUsername, newPassword, newTags, masterPassword);

            AccountUpdated?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Account updated!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void labelDetailsService_Click(object sender, EventArgs e)
        {

        }

        private void labelDetailsUsername_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
            "Are you sure you want to delete this account?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            ) ;

            if (confirm == DialogResult.Yes)
            {
                DatabaseHelper.DeleteAccount(accountId);
                AccountUpdated?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Account deleted.");
                this.Close();
            }
        }
    }
}
