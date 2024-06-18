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
            txtDiemGK1.Text = transcript.MidtermGradeII.ToString();
            txtDiemCK1.Text = transcript.FinalGradeI.ToString();
            txtDiemGK2.Text = transcript.MidtermGradeII.ToString();
            txtDiemCK2.Text = transcript.FinalGradeII.ToString();
            txtDiemTBHK1.Text = transcript.AverageGradeI.ToString();
            txtDiemTBHK2.Text = transcript.AverageGradeII.ToString();
            txtTongKet.Text = transcript.FinalAverageGrade.ToString();
            txtTenMonHoc.Text = transcript.SubjectName;
            txtLoai.Text = transcript.GradeType;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                var midGradeI = double.Parse(txtDiemGK1.Text);
                var midGradeII = double.Parse(txtDiemGK2.Text);
                var finalGradeI = double.Parse(txtDiemCK1.Text);
                var finalGradeII = double.Parse(txtDiemCK2.Text);
                TranscriptScope.Update(Id, midGradeI, finalGradeI, midGradeII, finalGradeII);
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
