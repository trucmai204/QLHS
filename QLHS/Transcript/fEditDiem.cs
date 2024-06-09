using Entities;
using Functions;

namespace QLHS
{
    public partial class fEditDiem : Form
    {
        int Id;
        public fEditDiem(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var midGradeI = double.Parse(txtDiemGK1.Text);
            var midGradeII = double.Parse(txtDiemGK2.Text);
            var finalGradeI = double.Parse(txtDiemCK1.Text);
            var finalGradeII = double.Parse(txtDiemCK2.Text);
            TranscriptScope.Update(Id, midGradeI, finalGradeI, midGradeII, finalGradeII);
            this.Close();
        }

        private void fEditDiem_Load(object sender, EventArgs e)
        {
            var transcript = TranscriptScope.FindById(Id);
            txtTenhs.Text = transcript.StudentName;
            txtTenMonHoc.Text = transcript.SubjectName;
            txtDiemGK1.Text = transcript.MidtermGradeII.ToString();
            txtDiemCK1.Text = transcript.FinalGradeI.ToString();
            txtDiemGK2.Text = transcript.MidtermGradeII.ToString();
            txtDiemCK2.Text = transcript.FinalGradeII.ToString();
            txtDiemTBHK1.Text = transcript.AverageGradeI.ToString();
            txtDiemTBHK2.Text = transcript.AverageGradeII.ToString();
            txtTongKet.Text = transcript.FinalAverageGrade.ToString();
            txtLoai.Text = transcript.GradeType;

        }
    }
}
                           