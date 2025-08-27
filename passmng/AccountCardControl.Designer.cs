namespace passmng
{
    partial class AccountCardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountCardControl));
            pictureBox1 = new PictureBox();
            labelaccountName = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelaccountName
            // 
            labelaccountName.AutoSize = true;
            labelaccountName.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelaccountName.ForeColor = SystemColors.Control;
            labelaccountName.Location = new Point(88, 0);
            labelaccountName.Name = "labelaccountName";
            labelaccountName.Size = new Size(78, 25);
            labelaccountName.TabIndex = 1;
            labelaccountName.Text = "label1";
            labelaccountName.Click += labelaccountName_Click;
            // 
            // labelUsername
            // 
            labelUsername.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = SystemColors.Control;
            labelUsername.Location = new Point(88, 25);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(364, 37);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "label1";
            labelUsername.TextAlign = ContentAlignment.MiddleLeft;
            labelUsername.Click += labelUsername_Click_3;
            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = SystemColors.Control;
            labelPassword.Location = new Point(88, 62);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(364, 37);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "label1";
            // 
            // AccountCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelaccountName);
            Controls.Add(pictureBox1);
            Name = "AccountCardControl";
            Size = new Size(476, 91);
            Load += AccountCardControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelaccountName;
        private Label labelUsername;
        private Label labelPassword;
    }
}
