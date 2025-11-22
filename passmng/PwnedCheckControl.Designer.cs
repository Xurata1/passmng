namespace passmng
{
    partial class PwnedCheckControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PwnedCheckControl));
            comboBoxAccounts = new ComboBox();
            labelResult = new Label();
            buttonCheck = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxAccounts
            // 
            comboBoxAccounts.BackColor = Color.FromArgb(54, 63, 73);
            comboBoxAccounts.FlatStyle = FlatStyle.Flat;
            comboBoxAccounts.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAccounts.ForeColor = Color.White;
            comboBoxAccounts.FormattingEnabled = true;
            comboBoxAccounts.Location = new Point(107, 427);
            comboBoxAccounts.Name = "comboBoxAccounts";
            comboBoxAccounts.Size = new Size(293, 26);
            comboBoxAccounts.TabIndex = 0;
            comboBoxAccounts.Text = "Accounts";
            comboBoxAccounts.SelectedIndexChanged += comboBoxAccounts_SelectedIndexChanged;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResult.ForeColor = SystemColors.Control;
            labelResult.Location = new Point(107, 298);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(456, 28);
            labelResult.TabIndex = 1;
            labelResult.Text = "Check your account breach status here";
            labelResult.Click += labelResult_Click;
            // 
            // buttonCheck
            // 
            buttonCheck.FlatStyle = FlatStyle.Flat;
            buttonCheck.ForeColor = Color.FromArgb(19, 22, 26);
            buttonCheck.Image = (Image)resources.GetObject("buttonCheck.Image");
            buttonCheck.Location = new Point(775, 379);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(160, 120);
            buttonCheck.TabIndex = 2;
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(107, -101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(582, 346);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(625, -88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(310, 212);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // buttonBack
            // 
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.ForeColor = Color.FromArgb(19, 22, 26);
            buttonBack.Image = (Image)resources.GetObject("buttonBack.Image");
            buttonBack.Location = new Point(1034, 3);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(150, 89);
            buttonBack.TabIndex = 5;
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // PwnedCheckControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 26);
            Controls.Add(buttonBack);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCheck);
            Controls.Add(labelResult);
            Controls.Add(comboBoxAccounts);
            Name = "PwnedCheckControl";
            Size = new Size(1207, 632);
            Load += PwnedCheckControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAccounts;
        private Label labelResult;
        private Button buttonCheck;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonBack;
    }
}
