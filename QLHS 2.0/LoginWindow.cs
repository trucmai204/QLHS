using Entities;
using Functions;

namespace QLHS_2._0
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.icon;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login()
        {
            if (txtUserName.Text.Trim() != string.Empty && txtPassWord.Text.Trim() != string.Empty)
            {
                var user = UserScope.GetByInfo(txtUserName.Text, txtPassWord.Text);
                if (user != null)
                {
                    CacheScope.RoleId = (EnumRole)user.RoleId;

                    this.Hide();
                    var fmain = new MainWindow();
                    fmain.ShowDialog();

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

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
