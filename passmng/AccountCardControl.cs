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
    public partial class AccountCardControl : UserControl
    {
        private string accountName;
        private string AccountName
        {
            get { return accountName; }
        }

        public event Action<AccountCardControl> AccountClicked;


        public AccountCardControl(string accountname)
        {
            InitializeComponent();
            RenameAccount(accountname);
        }

        private void RenameAccount(string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                throw new ArgumentNullException();
                MessageBox.Show("Name cannot be empty");
            }

            accountName = newName;
        }

        private void buttonAccountClick(object sender, EventArgs e)
        {
            AccountClicked?.Invoke(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
