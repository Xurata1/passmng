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
        private int accountId;

        public string AccountName { get { return accountName; } }
        public string Username { get { return username; } }
        public string Password { get { return password; } }

        public int AccountId { get { return accountId; } }

        private bool isPasswordVisible = false;

        public event EventHandler AccountClicked;

        public AccountCardControl(int accountId, string accountName, string username, string password)
        {
            InitializeComponent();

            this.accountId = accountId;
            this.accountName = accountName;
            this.username = username;
            this.password = password;

            labelaccountName.Text = accountName;
            labelUsername.Text = username;
            labelPassword.Text = new string('•', password.Length);

            MakeCardClickable();
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

        private void AccountCardControl_Clicked(object sender, EventArgs e)
        {
            AccountClicked?.Invoke(this, e);
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

        private void MakeCardClickable()
        {
            AttachMouseClickRecursively(this);
        }

        private void AttachMouseClickRecursively(Control parent)
        {
            parent.MouseClick += Card_MouseClick;

            foreach (Control c in parent.Controls)
            {
                AttachMouseClickRecursively(c);
                c.Cursor = Cursors.Hand;  // show it's clickable
            }
        }

        private void Card_MouseClick(object sender, MouseEventArgs e)
        {
            AccountClicked?.Invoke(this, EventArgs.Empty);
        }


    }
}
