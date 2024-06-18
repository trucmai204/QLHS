using Entities;
using Functions;
using QLHS_2._0.Class;
using QLHS_2._0.Student;
using QLHS_2._0.Subject;
using QLHS_2._0.Transcript;

namespace QLHS_2._0
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CacheScope.RoleId = EnumRole.None;
            var form = new LoginWindow();
            this.Hide();
            form.ShowDialog();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            switch (CacheScope.RoleId)
            {
                case EnumRole.Admin:
                    addTranscriptSubMenuItem.Enabled = true;
                    addStudentSubMenuItem.Enabled = true;
                    addClassSubMenuItem.Enabled = true;
                    break;
                case EnumRole.Inputer:
                    addTranscriptSubMenuItem.Enabled = true;
                    break;
                case EnumRole.ClassTeacher:
                    addStudentSubMenuItem.Enabled = true;
                    break;
                case EnumRole.SubjectTeacher:
                    addTranscriptSubMenuItem.Enabled = true;
                    break;
            }
        }

        private void classManagementMenuItem_Click(object sender, EventArgs e)
        {
            var openingForm = this.MdiChildren.FirstOrDefault(form => form is ManageClass_Form);
            if (openingForm != null)
            {
                openingForm.BringToFront();
                openingForm.WindowState = FormWindowState.Maximized;
                return;
            }

            var form = new ManageClass_Form();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void addClassMenuItem_Click(object sender, EventArgs e)
        {
            classManagementMenuItem_Click(sender, e);
            var createForm = new CreateClass_Form();
            createForm.ShowDialog();
        }

        private void subjectManagementMenuItem_Click(object sender, EventArgs e)
        {
            var openingForm = this.MdiChildren.FirstOrDefault(form => form is ManageSubject_Form);
            if (openingForm != null)
            {
                openingForm.BringToFront();
                openingForm.WindowState = FormWindowState.Maximized;
                return;
            }

            var form = new ManageSubject_Form();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void transcriptManagementMenuItem_Click(object sender, EventArgs e)
        {
            var openingForm = this.MdiChildren.FirstOrDefault(form => form is ManageTranscript_Form);
            if (openingForm != null)
            {
                openingForm.BringToFront();
                openingForm.WindowState = FormWindowState.Maximized;
                return;
            }

            var form = new ManageTranscript_Form();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void addTranscriptMenuItem_Click(object sender, EventArgs e)
        {
            transcriptManagementMenuItem_Click(sender, e);

            var createForm = new CreateTranscript_Form();
            createForm.ShowDialog();
        }

        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openingForm = this.MdiChildren.FirstOrDefault(form => form is ManageStudent_Form);
            if (openingForm != null)
            {
                openingForm.BringToFront();
                openingForm.WindowState = FormWindowState.Maximized;
                return;
            }

            var form = new ManageStudent_Form();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void addStudentSubMenuItem_Click(object sender, EventArgs e)
        {
            quảnLýHọcSinhToolStripMenuItem_Click(sender, e);

            var createForm = new CreateStudent_Form();
            createForm.ShowDialog();
        }
    }
}
