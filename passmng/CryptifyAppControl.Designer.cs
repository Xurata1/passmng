namespace passmng
{
    partial class CryptifyAppControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptifyAppControl));
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonAddAccount = new Button();
            pictureBox2 = new PictureBox();
            buttonHIBP = new Button();
            buttonLogout = new Button();
            textBoxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(251, 81);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(952, 548);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // buttonAddAccount
            // 
            buttonAddAccount.BackColor = Color.FromArgb(31, 31, 31);
            buttonAddAccount.BackgroundImageLayout = ImageLayout.None;
            buttonAddAccount.FlatStyle = FlatStyle.Flat;
            buttonAddAccount.ForeColor = Color.FromArgb(31, 31, 31);
            buttonAddAccount.Image = (Image)resources.GetObject("buttonAddAccount.Image");
            buttonAddAccount.Location = new Point(1138, 3);
            buttonAddAccount.Name = "buttonAddAccount";
            buttonAddAccount.Size = new Size(65, 58);
            buttonAddAccount.TabIndex = 1;
            buttonAddAccount.UseVisualStyleBackColor = false;
            buttonAddAccount.Click += buttonAddAccount_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-23, -41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(268, 246);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // buttonHIBP
            // 
            buttonHIBP.FlatStyle = FlatStyle.Flat;
            buttonHIBP.ForeColor = Color.FromArgb(31, 31, 31);
            buttonHIBP.Image = (Image)resources.GetObject("buttonHIBP.Image");
            buttonHIBP.Location = new Point(0, 233);
            buttonHIBP.Name = "buttonHIBP";
            buttonHIBP.Size = new Size(245, 125);
            buttonHIBP.TabIndex = 0;
            buttonHIBP.UseVisualStyleBackColor = true;
            buttonHIBP.Click += buttonHIBP_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.ForeColor = Color.FromArgb(31, 31, 31);
            buttonLogout.Image = (Image)resources.GetObject("buttonLogout.Image");
            buttonLogout.Location = new Point(3, 443);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(215, 186);
            buttonLogout.TabIndex = 2;
            buttonLogout.TabStop = false;
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(807, 22);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "🔎 Search ";
            textBoxSearch.Size = new Size(292, 23);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // CryptifyAppControl
            // 
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonLogout);
            Controls.Add(buttonHIBP);
            Controls.Add(pictureBox2);
            Controls.Add(buttonAddAccount);
            Controls.Add(flowLayoutPanel1);
            Name = "CryptifyAppControl";
            Size = new Size(1207, 632);
            Load += CryptifyAppControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label labelCapsLock;
        private TextBox textBox2;
        private Button buttonAddAccount;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
        private Button buttonHIBP;
        private Button buttonLogout;
        private TextBox textBoxSearch;
    }
}
