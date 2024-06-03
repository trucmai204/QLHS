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
    }
}
