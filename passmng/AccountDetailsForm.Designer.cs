namespace passmng
{
    partial class AccountDetailsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDetailsForm));
            labelDetailsService = new Label();
            txtAccountName = new TextBox();
            labelDetailsUsername = new Label();
            txtUsername = new TextBox();
            labelDetailsPassword = new Label();
            txtPassword = new TextBox();
            buttonTogglePassword = new Button();
            buttonDetailsSave = new Button();
            SuspendLayout();
            // 
            // labelDetailsService
            // 
            labelDetailsService.AutoSize = true;
            labelDetailsService.Font = new Font("Roboto SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDetailsService.ForeColor = SystemColors.Control;
            labelDetailsService.Location = new Point(63, 94);
            labelDetailsService.Name = "labelDetailsService";
            labelDetailsService.Size = new Size(94, 29);
            labelDetailsService.TabIndex = 0;
            labelDetailsService.Text = "Service";
            labelDetailsService.Click += labelDetailsService_Click;
            // 
            // txtAccountName
            // 
            txtAccountName.BackColor = SystemColors.HighlightText;
            txtAccountName.Location = new Point(192, 94);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(312, 23);
            txtAccountName.TabIndex = 1;
            // 
            // labelDetailsUsername
            // 
            labelDetailsUsername.AutoSize = true;
            labelDetailsUsername.Font = new Font("Roboto SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDetailsUsername.ForeColor = SystemColors.Control;
            labelDetailsUsername.Location = new Point(63, 161);
            labelDetailsUsername.Name = "labelDetailsUsername";
            labelDetailsUsername.Size = new Size(123, 29);
            labelDetailsUsername.TabIndex = 2;
            labelDetailsUsername.Text = "Username";
            labelDetailsUsername.Click += labelDetailsUsername_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(192, 169);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(312, 23);
            txtUsername.TabIndex = 3;
            // 
            // labelDetailsPassword
            // 
            labelDetailsPassword.AutoSize = true;
            labelDetailsPassword.Font = new Font("Roboto SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDetailsPassword.ForeColor = SystemColors.Control;
            labelDetailsPassword.Location = new Point(63, 242);
            labelDetailsPassword.Name = "labelDetailsPassword";
            labelDetailsPassword.Size = new Size(120, 29);
            labelDetailsPassword.TabIndex = 4;
            labelDetailsPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(192, 248);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(312, 23);
            txtPassword.TabIndex = 5;
            // 
            // buttonTogglePassword
            // 
            buttonTogglePassword.BackColor = Color.FromArgb(31, 31, 31);
            buttonTogglePassword.FlatStyle = FlatStyle.Flat;
            buttonTogglePassword.ForeColor = Color.FromArgb(31, 31, 31);
            buttonTogglePassword.Image = (Image)resources.GetObject("buttonTogglePassword.Image");
            buttonTogglePassword.Location = new Point(524, 238);
            buttonTogglePassword.Name = "buttonTogglePassword";
            buttonTogglePassword.Size = new Size(72, 40);
            buttonTogglePassword.TabIndex = 6;
            buttonTogglePassword.UseVisualStyleBackColor = false;
            buttonTogglePassword.Click += buttonTogglePassword_Click;
            // 
            // buttonDetailsSave
            // 
            buttonDetailsSave.FlatStyle = FlatStyle.Flat;
            buttonDetailsSave.ForeColor = Color.FromArgb(19, 22, 26);
            buttonDetailsSave.Image = (Image)resources.GetObject("buttonDetailsSave.Image");
            buttonDetailsSave.Location = new Point(258, 302);
            buttonDetailsSave.Name = "buttonDetailsSave";
            buttonDetailsSave.Size = new Size(166, 68);
            buttonDetailsSave.TabIndex = 7;
            buttonDetailsSave.UseVisualStyleBackColor = true;
            buttonDetailsSave.Click += buttonDetailsSave_Click;
            // 
            // AccountDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 26);
            ClientSize = new Size(656, 382);
            Controls.Add(buttonDetailsSave);
            Controls.Add(buttonTogglePassword);
            Controls.Add(txtPassword);
            Controls.Add(labelDetailsPassword);
            Controls.Add(txtUsername);
            Controls.Add(labelDetailsUsername);
            Controls.Add(txtAccountName);
            Controls.Add(labelDetailsService);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AccountDetailsForm";
            Text = "Account Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDetailsService;
        private TextBox txtAccountName;
        private Label labelDetailsUsername;
        private TextBox txtUsername;
        private Label labelDetailsPassword;
        private TextBox txtPassword;
        private Button buttonTogglePassword;
        private Button buttonDetailsSave;
    }
}