using Functions;

namespace QLHS
{
    public partial class fNewDiem : Form
    {
        public fNewDiem()
        {
            InitializeComponent();

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var midGradeI = double.Parse(txtDiemGK1.Text);
            var finalGradeI = double.Parse(txtDiemCK1.Text);
            var midGradeII = double.Parse(txtDiemGK2.Text);
            var finalGradeII = double.Parse(txtDiemCK2.Text);

            TranscriptScope.AddTranscript(txtTenhs.Text, txtTenMonHoc.Text, midGradeI, finalGradeI, midGradeII, finalGradeII);

            this.Close();
        }
    }
}