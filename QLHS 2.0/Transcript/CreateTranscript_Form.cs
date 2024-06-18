using Functions;

namespace QLHS_2._0.Transcript
{
    public partial class CreateTranscript_Form : Form
    {
        public CreateTranscript_Form()
        {
            InitializeComponent();
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

                TranscriptScope.Create(txtTenhs.Text, txtTenMonHoc.Text, midGradeI, finalGradeI, midGradeII, finalGradeII);

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateTranscript_Form_Load(object sender, EventArgs e)
        {
            txtTenMonHoc.DataSource = SubjectScope.GetNames();
            txtTenhs.DataSource = StudentScope.GetNames();
        }
    }
}
