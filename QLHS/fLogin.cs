using Functions;

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
            if (txtUserName.Text != string.Empty && txtPassWord.Text != string.Empty)
            {
               
                if (UserScope.IsValid(txtUserName.Text, txtPassWord.Text))
                {
                    this.Hide();
                    var fmain = new fmain();
                    fmain.ShowDialog(); // Dialog thuc hien xong r dong, chan hành dong 
                    
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu");
                }
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
