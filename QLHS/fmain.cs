namespace QLHS
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fPhanLopHoc_Click(object sender, EventArgs e)
        {
            var openingForm = this.MdiChildren.FirstOrDefault(form => form is fPhanLopHoc);
            if (openingForm != null)
            {
                openingForm.BringToFront();
                return;
            }

            var form = new fPhanLopHoc();
            form.MdiParent = this;
            form.Show();
        }

        private void fDiem_Click(object sender, EventArgs e)
        {
            var openingForm = this.MdiChildren.FirstOrDefault(form => form is fDiem);
            if (openingForm != null)
            {
                openingForm.BringToFront();
                return;
            }

            var form = new fDiem();
            form.MdiParent = this;
            form.Show();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}