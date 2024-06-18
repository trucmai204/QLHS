namespace QLHS_2._0
{
    partial class LoginWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUserName = new TextBox();
            txtPassWord = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btLogin = new Button();
            btClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(48, 79);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtUserName.ForeColor = Color.Red;
            txtUserName.Location = new Point(48, 114);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(775, 39);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "admin";
            txtUserName.TextAlign = HorizontalAlignment.Center;
            txtUserName.KeyDown += txtUserName_KeyDown;
            // 
            // txtPassWord
            // 
            txtPassWord.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassWord.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtPassWord.ForeColor = Color.Black;
            txtPassWord.Location = new Point(48, 195);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(775, 39);
            txtPassWord.TabIndex = 3;
            txtPassWord.Text = "1111";
            txtPassWord.TextAlign = HorizontalAlignment.Center;
            txtPassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(48, 160);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.OliveDrab;
            label3.Location = new Point(193, 18);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(486, 54);
            label3.TabIndex = 4;
            label3.Text = "ĐĂNG NHẬP HỆ THỐNG";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btLogin
            // 
            btLogin.Anchor = AnchorStyles.None;
            btLogin.AutoSize = true;
            btLogin.BackColor = Color.Cyan;
            btLogin.FlatAppearance.BorderColor = SystemColors.Control;
            btLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btLogin.Location = new Point(253, 254);
            btLogin.Margin = new Padding(0);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(167, 66);
            btLogin.TabIndex = 5;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.None;
            btClose.AutoSize = true;
            btClose.BackColor = Color.FromArgb(255, 192, 192);
            btClose.FlatAppearance.BorderColor = SystemColors.Control;
            btClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btClose.Location = new Point(460, 254);
            btClose.Margin = new Padding(0);
            btClose.Name = "btClose";
            btClose.Size = new Size(167, 66);
            btClose.TabIndex = 6;
            btClose.Text = "Thoát";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 338);
            Controls.Add(btClose);
            Controls.Add(btLogin);
            Controls.Add(label3);
            Controls.Add(txtPassWord);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "LoginWindow";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private TextBox txtPassWord;
        private Label label2;
        private Label label3;
        private Button btLogin;
        private Button btClose;
    }
}
