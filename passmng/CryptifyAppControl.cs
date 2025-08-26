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
    public partial class CryptifyAppControl : UserControl
    {
        private readonly SecureString masterPassword;
        public CryptifyAppControl(SecureString password)
        {
            InitializeComponent();
            masterPassword = password;
        }

        
        

        private void CryptifyAppControl_Load(object sender, EventArgs e)
        {

        }
    }
}
