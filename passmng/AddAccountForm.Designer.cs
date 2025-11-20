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
            SuspendLayout();
            // 
            // labelService
            // 
            labelService.AutoSize = true;
            labelService.Font = new Font("Roboto SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelService.ForeColor = Color.White;
            labelService.Location = new Point(135, 88);
            labelService.Name = "labelService";
            labelService.Size = new Size(94, 29);
            labelService.TabIndex = 0;
            labelService.Text = "Service";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 23);
            textBox1.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Roboto SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(135, 177);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(123, 29);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(344, 23);
            textBox2.TabIndex = 3;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Roboto SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(135, 262);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(120, 29);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(264, 270);
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
            buttonOk.Location = new Point(260, 348);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(142, 78);
            buttonOk.TabIndex = 6;
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.FromArgb(19, 22, 26);
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.Location = new Point(439, 360);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(124, 66);
            buttonCancel.TabIndex = 7;
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // AddAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 26);
            ClientSize = new Size(800, 450);
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
    }
}