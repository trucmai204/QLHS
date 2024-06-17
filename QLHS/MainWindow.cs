using Entities;
using Functions;
using QLHS.Student;

namespace QLHS
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            switch (CacheScope.RoleId)
            {
                case EnumRole.Admin:
                    nhapDiem.Enabled = true;
                    thêmHọcSinhToolStripMenuItem.Enabled = true;
                    thêmLớpHọcToolStripMenuItem.Enabled = true;
                    break;
                case EnumRole.Inputer:
                    nhapDiem.Enabled = true;
                    break;
                case EnumRole.ClassTeacher:
                    thêmHọcSinhToolStripMenuItem.Enabled = true;
                    break;
                case EnumRole.SubjectTeacher:
                    nhapDiem.Enabled = true;
                    break;
            }
        }

        private void fPhanLopHoc_Click(object sender, EventArgs e)
        {
            var openingForm = this.MdiChildren.FirstOrDefault(form => form is ManageClass_Form);
            if (openingForm != null)
            {
                openingForm.BringToFront();
                return;
            }

            var form = new ManageClass_Form();
            form.MdiParent = this;
            form.Show();
        }

        private void fDiem_Click(object sender, EventArgs e)
        {
            var openingForm = this.MdiChildren.FirstOrDefault(form => form is ManageTranscript_Form);
            if (openingForm != null)
            {
                openingForm.BringToFront();
                return;
            }

            var form = new ManageTranscript_Form();
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
            var openingForm = this.MdiChildren.FirstOrDefault(form => form is ManageClass_Form);
            if (openingForm != null)
            {
                openingForm.BringToFront();
                return;
            }

            var form = new ManageClass_Form();
            form.MdiParent = this;
            form.Show();

            var createForm = new CreateClass_Form();
            createForm.ShowDialog();
        }

        private void fNewDiem_Click(object sender, EventArgs e)
        {
            var openingForm = this.MdiChildren.FirstOrDefault(form => form is ManageTranscript_Form);
            if (openingForm != null)
            {
                openingForm.BringToFront();
                return;
            }

            var form = new ManageTranscript_Form();
            form.MdiParent = this;
            form.Show();

            var createForm = new CreateTranscript_Form();
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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CacheScope.RoleId = EnumRole.None;
            var form = new LoginWindow();
            this.Hide();
            form.ShowDialog();
        }
    }
}