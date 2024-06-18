using Functions;

namespace QLHS_2._0.Transcript
{
    public partial class UpdateTranscript_Form : Form
    {
        private int Id;
        public UpdateTranscript_Form(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void UpdateTranscript_Form_Load(object sender, EventArgs e)
        {
            var transcript = TranscriptScope.FindById(Id);

            txtTenhs.Text = transcript.StudentName;
            txtDiemGK1.Value = (decimal)transcript.MidtermGradeII;
            txtDiemCK1.Value = (decimal)transcript.FinalGradeI;
            txtDiemGK2.Value = (decimal)transcript.MidtermGradeII;
            txtDiemCK2.Value = (decimal)transcript.FinalGradeII;
            txtTenMonHoc.Text = transcript.SubjectName;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                var midGradeI = (double)txtDiemGK1.Value;
                var finalGradeI = (double)txtDiemCK1.Value;
                var midGradeII = (double)txtDiemGK2.Value;
                var finalGradeII = (double)txtDiemCK2.Value;
                TranscriptScope.Update(Id, midGradeI, finalGradeI, midGradeII, finalGradeII);
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
