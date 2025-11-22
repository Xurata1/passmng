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
        public string AccountName { get { return textBox1.Text; } }
        public string Username { get { return textBox2.Text; } }

        public string Password { get { return textBox3.Text; } }

        public string Tags { get { return comboBoxTags.SelectedItem?.ToString() ?? ""; } }
        public AddAccountForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.AddAccountForm_Load);
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

        }

        private Random rng = new Random();

        private string GeneratePassword(int length, bool useUpper, bool useNumbers, bool useSymbols)
        {
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";
            const string symbols = "!£$%^&*()_-+=#~{}/";

            string charPool = lower;
            if (useUpper) { charPool += upper; }
            if (useNumbers) { charPool += numbers; }
            if (useSymbols) { charPool += symbols; }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(charPool[rng.Next(charPool.Length)]);
            }
            return sb.ToString();

        }

        private void trackLength_Scroll(object sender, EventArgs e)
        {
            labelLengthValue.Text = trackLength.Value.ToString();
        }


        private void AddAccountForm_Load(object sender, EventArgs e)
        {


        }

        private void labelService_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTags_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int length = trackLength.Value;
            bool upper = checkUpper.Checked;
            bool numbers = checkNumbers.Checked;
            bool symbols = checkSymbols.Checked;

            string generated = GeneratePassword(length, upper, numbers, symbols);

            if (!string.IsNullOrEmpty(generated))
            {
                textBox3.Text = generated;
            }

            Clipboard.SetText(generated);

            labelCopied.Visible = true;
            Task.Delay(1500).ContinueWith(_ =>
            {
                if (labelCopied.InvokeRequired)
                {
                    labelCopied.Invoke(new Action(() => labelCopied.Visible = false));
                }
                else
                {
                    labelCopied.Visible = false;
                }
            }
            ); 
        }

        private void checkUpper_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkSymbols_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkNumbers_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
