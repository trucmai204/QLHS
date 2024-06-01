namespace QLHS
{
    public partial class fmain : Form
    {
        public fmain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void phânLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fPhanLopHoc"))
                return;
            var f = new fPhanLopHoc();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fDiem"))
                return;
            fDiem f = new fDiem();
            f.MdiParent = this;
            f.Show();
        }
    }
}