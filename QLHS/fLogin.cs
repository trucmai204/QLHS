﻿using Functions;

namespace QLHS
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void Login()
        {
            if (txtUserName.Text.Trim() != string.Empty && txtPassWord.Text.Trim() != string.Empty)
            {

                if (UserScope.IsValid(txtUserName.Text, txtPassWord.Text))
                {
                    this.Hide();
                    var fmain = new fMain();
                    fmain.ShowDialog(); // ShowDialog() bắt buộc user phải đóng form được mở để thực hiện tiếp logic trên form hiện tại, còn với Show() thì không bắt buộc 

                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Text = txtPassWord.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
