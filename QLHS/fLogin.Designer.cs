namespace QLHS
{
    partial class fLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            txtPassWord = new TextBox();
            btLogin = new Button();
            btClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(62, 9);
            label1.Name = "label1";
            label1.Size = new Size(248, 32);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập hệ thống";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 75);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 124);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(137, 72);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(193, 23);
            txtUserName.TabIndex = 3;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(137, 116);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(193, 23);
            txtPassWord.TabIndex = 4;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(137, 162);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(96, 39);
            btLogin.TabIndex = 5;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            btClose.Location = new Point(255, 162);
            btClose.Name = "btClose";
            btClose.Size = new Size(93, 39);
            btClose.TabIndex = 6;
            btClose.Text = "Thoát";
            btClose.UseVisualStyleBackColor = true;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 254);
            Controls.Add(btClose);
            Controls.Add(btLogin);
            Controls.Add(txtPassWord);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private TextBox txtPassWord;
        private Button btLogin;
        private Button btClose;
    }
}