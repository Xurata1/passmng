using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace passmng
{
    partial class LoginPageControl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPageControl));
            labelCapsLock = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox2 = new NoBalloonPasswordTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelCapsLock
            // 
            labelCapsLock.AutoSize = true;
            labelCapsLock.Font = new System.Drawing.Font("Candara", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCapsLock.ForeColor = Color.White;
            labelCapsLock.Location = new Point(362, 369);
            labelCapsLock.Name = "labelCapsLock";
            labelCapsLock.Size = new Size(209, 19);
            labelCapsLock.TabIndex = 3;
            labelCapsLock.Text = "Warning - Caps Lock is enabled";
            labelCapsLock.UseMnemonic = false;
            labelCapsLock.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new System.Drawing.Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(533, 440);
            button1.Name = "button1";
            button1.Size = new Size(104, 40);
            button1.TabIndex = 4;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(533, 508);
            button2.Name = "button2";
            button2.Size = new Size(104, 40);
            button2.TabIndex = 5;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ControlDarkDark;
            textBox1.Location = new Point(362, 266);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Email Address";
            textBox1.Size = new Size(500, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(362, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ControlDarkDark;
            textBox2.Location = new Point(362, 315);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(500, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // LoginPageControl
            // 
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelCapsLock);
            Font = new System.Drawing.Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LoginPageControl";
            Size = new Size(1207, 632);
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Button loginButton;
        private Button signUpbutton;
        private Label labelCapsLock;
        private NoBalloonPasswordTextBox textBox2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}
