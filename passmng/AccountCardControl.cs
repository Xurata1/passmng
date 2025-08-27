using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passmng
{
    public partial class AccountCardControl : UserControl
    {
        private string accountName;
        private string username;
        private string password;

        public string AccountName { get { return accountName; } }
        public string Username { get { return username; } }
        public string Password { get { return password; } }

        private bool isPasswordVisible = false;

        public event Action<AccountCardControl> AccountClicked;

        public AccountCardControl(string accountName, string username, string password)
        {
            InitializeComponent();

            this.accountName = accountName;
            this.username = username;
            this.password = password;

            labelaccountName.Text = accountName;
            labelUsername.Text = username;
            labelPassword.Text = new string('•', password.Length);
        }

        private void RenameAccount(string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Name cannot be empty");
                throw new ArgumentNullException(nameof(newName));
            }

            accountName = newName;
            labelaccountName.Text = newName;
        }

        private void buttonAccountClick(object sender, EventArgs e)
        {
            AccountClicked?.Invoke(this);
        }

        
        private void buttonTogglePassword_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                labelPassword.Text = new string('•', password.Length); 
                isPasswordVisible = false;
            }
            else
            {
                labelPassword.Text = password; 
                isPasswordVisible = true;
            }
        }

        private void labelaccountName_Click(object sender, EventArgs e)
        {
           
        }

        private void labelUsername_Click_3(object sender, EventArgs e)
        {
            
        }

        private void AccountCardControl_Load(object sender, EventArgs e)
        {
            
        }

    }
}
