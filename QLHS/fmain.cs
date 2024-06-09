using QLHS.Student;

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

        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openingForm = this.MdiChildren.FirstOrDefault(form => form is ManageStudent_Form);
            if (openingForm != null)
            {
                openingForm.BringToFront();
                return;
            }

            var form = new ManageStudent_Form();
            form.MdiParent = this;
            form.Show();
        }

        private void thêmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openingForm = this.MdiChildren.FirstOrDefault(form => form is ManageStudent_Form);
            if (openingForm != null)
            {
                openingForm.BringToFront();
                return;
            }

            var form = new ManageStudent_Form();
            form.MdiParent = this;
            form.Show();

            var createForm = new CreateStudent_Form();
            createForm.ShowDialog();
        }

        private void thêmLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
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

            var createForm = new fNewPhanLopHoc();
            createForm.ShowDialog();
        }

        private void fNewDiem_Click(object sender, EventArgs e)
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

            var createForm = new fNewDiem();
            createForm.ShowDialog();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openingForm = this.MdiChildren.FirstOrDefault(form => form is ManageSubject_Form);
            if (openingForm != null)
            {
                openingForm.BringToFront();
                return;
            }

            var form = new ManageSubject_Form();
            form.MdiParent = this;
            form.Show();
        }
    }
}