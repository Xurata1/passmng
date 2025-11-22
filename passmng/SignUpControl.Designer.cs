namespace passmng
{
    partial class SignUpControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpControl));
            pictureBoxCryptify = new PictureBox();
            textUsername = new TextBox();
            textPassword = new NoBalloonPasswordTextBox();
            textConfirmPassword = new NoBalloonPasswordTextBox();
            buttonCreateAccount = new Button();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCryptify).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCryptify
            // 
            pictureBoxCryptify.Image = (Image)resources.GetObject("pictureBoxCryptify.Image");
            pictureBoxCryptify.Location = new Point(323, 0);
            pictureBoxCryptify.Name = "pictureBoxCryptify";
            pictureBoxCryptify.Size = new Size(500, 241);
            pictureBoxCryptify.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCryptify.TabIndex = 1;
            pictureBoxCryptify.TabStop = false;
            // 
            // textUsername
            // 
            textUsername.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.ForeColor = SystemColors.ControlDarkDark;
            textUsername.Location = new Point(323, 270);
            textUsername.Name = "textUsername";
            textUsername.PlaceholderText = "Email Address";
            textUsername.Size = new Size(500, 27);
            textUsername.TabIndex = 2;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.ForeColor = SystemColors.ControlDarkDark;
            textPassword.Location = new Point(323, 327);
            textPassword.Name = "textPassword";
            textPassword.PlaceholderText = "Password";
            textPassword.Size = new Size(500, 27);
            textPassword.TabIndex = 3;
            // 
            // textConfirmPassword
            // 
            textConfirmPassword.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textConfirmPassword.ForeColor = SystemColors.ControlDarkDark;
            textConfirmPassword.Location = new Point(323, 391);
            textConfirmPassword.Name = "textConfirmPassword";
            textConfirmPassword.PlaceholderText = "Confirm Password";
            textConfirmPassword.Size = new Size(500, 27);
            textConfirmPassword.TabIndex = 4;
            // 
            // buttonCreateAccount
            // 
            buttonCreateAccount.BackColor = Color.White;
            buttonCreateAccount.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCreateAccount.ForeColor = Color.Black;
            buttonCreateAccount.Location = new Point(411, 451);
            buttonCreateAccount.Name = "buttonCreateAccount";
            buttonCreateAccount.Size = new Size(112, 59);
            buttonCreateAccount.TabIndex = 5;
            buttonCreateAccount.Text = "Create Account";
            buttonCreateAccount.UseVisualStyleBackColor = false;
            buttonCreateAccount.Click += buttonCreateAccount_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.White;
            buttonBack.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = Color.Black;
            buttonBack.Location = new Point(607, 451);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(112, 59);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // SignUpControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 26);
            Controls.Add(buttonBack);
            Controls.Add(buttonCreateAccount);
            Controls.Add(textConfirmPassword);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(pictureBoxCryptify);
            Name = "SignUpControl";
            Size = new Size(1207, 632);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCryptify).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCryptify;
        private TextBox textUsername;
        private NoBalloonPasswordTextBox textPassword;
        private NoBalloonPasswordTextBox textConfirmPassword;
        private Button buttonCreateAccount;
        private Button buttonBack;
    }
}
