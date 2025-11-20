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

        public AccountDetailsForm(int accountId, string accountName, string username, string password, string masterPassword)
        {
            InitializeComponent();
            this.accountId = accountId;
            this.masterPassword = masterPassword;


            txtAccountName.Text = accountName;
            txtUsername.Text = username;
            txtPassword.Text = password;
            txtPassword.UseSystemPasswordChar = true;
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
            string newPassword = txtPassword.Text;

            DatabaseHelper.UpdateAccount(accountId, newAccountName, newUsername, newPassword, masterPassword);

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
    }
}
