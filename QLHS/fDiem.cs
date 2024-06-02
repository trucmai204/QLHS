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
            dataGridView1.DataSource = TranscriptScope.GetTranscripts();
        }
    }
}
