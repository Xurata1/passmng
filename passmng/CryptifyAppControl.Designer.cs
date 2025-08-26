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
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(279, 96);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(406, 239);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // CryptifyAppControl
            // 
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(pictureBox2);
            Name = "CryptifyAppControl";
            Size = new Size(1079, 691);
            Load += CryptifyAppControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label labelCapsLock;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
    }
}
