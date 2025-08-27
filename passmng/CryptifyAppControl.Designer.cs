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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(221, 81);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(982, 613);
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
            pictureBox2.Location = new Point(-11, -52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(226, 198);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // CryptifyAppControl
            // 
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(pictureBox2);
            Controls.Add(buttonAddAccount);
            Controls.Add(flowLayoutPanel1);
            Name = "CryptifyAppControl";
            Size = new Size(1207, 691);
            Load += CryptifyAppControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

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
    }
}
