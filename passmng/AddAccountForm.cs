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
    public partial class AddAccountForm : Form
    {
        public string AccountName {get { return textBox1.Text; }}
        public string Username { get { return textBox2.Text; }}

        public string Password { get { return textBox3.Text; } }
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void AddAccountForm_Load(object sender, EventArgs e)
        {

        }
    }
}
