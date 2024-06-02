namespace QLHS
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void fPhanLopHoc_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fPhanLopHoc"))
                return;
            fPhanLopHoc f = new fPhanLopHoc();
            f.MdiParent = this;
            f.Show();
        }

        private void fDiem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fDiem"))
                return;
            fDiem f = new fDiem();
            f.MdiParent = this;
            f.Show();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}