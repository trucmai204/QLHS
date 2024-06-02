using Functions;

namespace QLHS
{
    public partial class fmain : Form
    {
        public fmain()
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
            if(Utility.IsOpeningForm("fDiem"))
                return;
            fDiem f = new fDiem();
            f.MdiParent = this;
            f.Show();
        }
    }
}