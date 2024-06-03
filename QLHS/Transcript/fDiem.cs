using Functions;

namespace QLHS
{
    public partial class fDiem : Form
    {
        public fDiem()
        {
            InitializeComponent();
        }

        private void fDiem_Load(object sender, EventArgs e)
        {
            OutputTable.DataSource = TranscriptScope.GetTranscripts();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            var addDiem = new fNewDiem();
            addDiem.ShowDialog();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            OutputTable.DataSource = StudentScope.GetStudentBy(txtfind.Text);
        }

        private void txtfind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OutputTable.DataSource = StudentScope.GetStudentBy(txtfind.Text);
            }
        }
    }
}
