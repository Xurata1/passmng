namespace passmng
{
    partial class AddAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccountForm));
            labelService = new Label();
            textBox1 = new TextBox();
            labelUsername = new Label();
            textBox2 = new TextBox();
            labelPassword = new Label();
            textBox3 = new TextBox();
            buttonOk = new Button();
            buttonCancel = new Button();
            comboBoxTags = new ComboBox();
            trackLength = new TrackBar();
            labelLengthValue = new Label();
            checkUpper = new CheckBox();
            checkNumbers = new CheckBox();
            checkSymbols = new CheckBox();
            buttonGenerate = new Button();
            labelCopied = new Label();
            ((System.ComponentModel.ISupportInitialize)trackLength).BeginInit();
            SuspendLayout();
            // 
            // labelService
            // 
            labelService.AutoSize = true;
            labelService.Font = new Font("Roboto SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelService.ForeColor = Color.White;
            labelService.Location = new Point(29, 72);
            labelService.Name = "labelService";
            labelService.Size = new Size(94, 29);
            labelService.TabIndex = 0;
            labelService.Text = "Service";
            labelService.Click += labelService_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 23);
            textBox1.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Roboto SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(29, 155);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(123, 29);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(344, 23);
            textBox2.TabIndex = 3;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Roboto SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(29, 241);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(120, 29);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(174, 247);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(344, 23);
            textBox3.TabIndex = 5;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonOk.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonOk.ForeColor = Color.FromArgb(19, 22, 26);
            buttonOk.Image = (Image)resources.GetObject("buttonOk.Image");
            buttonOk.Location = new Point(206, 402);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(142, 78);
            buttonOk.TabIndex = 6;
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.FromArgb(19, 22, 26);
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.Location = new Point(394, 414);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(124, 66);
            buttonCancel.TabIndex = 7;
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboBoxTags
            // 
            comboBoxTags.FormattingEnabled = true;
            comboBoxTags.Location = new Point(566, 80);
            comboBoxTags.Name = "comboBoxTags";
            comboBoxTags.Size = new Size(187, 23);
            comboBoxTags.TabIndex = 8;
            comboBoxTags.Text = "Tags";
            comboBoxTags.SelectedIndexChanged += comboBoxTags_SelectedIndexChanged;
            // 
            // trackLength
            // 
            trackLength.Location = new Point(586, 241);
            trackLength.Maximum = 64;
            trackLength.Minimum = 8;
            trackLength.Name = "trackLength";
            trackLength.Size = new Size(244, 45);
            trackLength.TabIndex = 9;
            trackLength.Value = 16;
            trackLength.Scroll += trackLength_Scroll;
            // 
            // labelLengthValue
            // 
            labelLengthValue.AutoSize = true;
            labelLengthValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLengthValue.Location = new Point(663, 289);
            labelLengthValue.Name = "labelLengthValue";
            labelLengthValue.Size = new Size(77, 30);
            labelLengthValue.TabIndex = 10;
            labelLengthValue.Text = "Length";
            labelLengthValue.Click += label1_Click;
            // 
            // checkUpper
            // 
            checkUpper.AutoSize = true;
            checkUpper.Location = new Point(545, 336);
            checkUpper.Name = "checkUpper";
            checkUpper.Size = new Size(112, 19);
            checkUpper.TabIndex = 11;
            checkUpper.Text = "Uppercase (A-Z)";
            checkUpper.UseVisualStyleBackColor = true;
            checkUpper.CheckedChanged += checkUpper_CheckedChanged;
            // 
            // checkNumbers
            // 
            checkNumbers.AutoSize = true;
            checkNumbers.Location = new Point(792, 336);
            checkNumbers.Name = "checkNumbers";
            checkNumbers.Size = new Size(103, 19);
            checkNumbers.TabIndex = 12;
            checkNumbers.Text = "Numbers (0-9)";
            checkNumbers.UseVisualStyleBackColor = true;
            checkNumbers.CheckedChanged += checkNumbers_CheckedChanged;
            // 
            // checkSymbols
            // 
            checkSymbols.AutoSize = true;
            checkSymbols.Location = new Point(663, 336);
            checkSymbols.Name = "checkSymbols";
            checkSymbols.Size = new Size(110, 19);
            checkSymbols.TabIndex = 13;
            checkSymbols.Text = "Symbols (@,!,~)";
            checkSymbols.UseVisualStyleBackColor = true;
            checkSymbols.CheckedChanged += checkSymbols_CheckedChanged;
            // 
            // buttonGenerate
            // 
            buttonGenerate.FlatStyle = FlatStyle.Flat;
            buttonGenerate.ForeColor = Color.FromArgb(19, 22, 26);
            buttonGenerate.Image = (Image)resources.GetObject("buttonGenerate.Image");
            buttonGenerate.Location = new Point(625, 361);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(169, 94);
            buttonGenerate.TabIndex = 15;
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // labelCopied
            // 
            labelCopied.AutoSize = true;
            labelCopied.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCopied.Location = new Point(811, 396);
            labelCopied.Name = "labelCopied";
            labelCopied.Size = new Size(64, 21);
            labelCopied.TabIndex = 16;
            labelCopied.Text = "Copied!";
            labelCopied.Visible = false;
            // 
            // AddAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 26);
            ClientSize = new Size(923, 488);
            Controls.Add(labelCopied);
            Controls.Add(buttonGenerate);
            Controls.Add(checkSymbols);
            Controls.Add(checkNumbers);
            Controls.Add(checkUpper);
            Controls.Add(labelLengthValue);
            Controls.Add(trackLength);
            Controls.Add(comboBoxTags);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(textBox3);
            Controls.Add(labelPassword);
            Controls.Add(textBox2);
            Controls.Add(labelUsername);
            Controls.Add(textBox1);
            Controls.Add(labelService);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddAccountForm";
            Text = "Add Account";
            Load += AddAccountForm_Load;
            ((System.ComponentModel.ISupportInitialize)trackLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelService;
        private TextBox textBox1;
        private Label labelUsername;
        private TextBox textBox2;
        private Label labelPassword;
        private TextBox textBox3;
        private Button buttonOk;
        private Button buttonCancel;
        private ComboBox comboBoxTags;
        private TrackBar trackLength;
        private Label labelLengthValue;
        private CheckBox checkUpper;
        private CheckBox checkNumbers;
        private CheckBox checkSymbols;
        private Button buttonGenerate;
        private Label labelCopied;
    }
}