using Functions;

namespace QLHS.Subject
{
    public partial class UpdateSubject_Form : Form
    {
        private int Id;
        public UpdateSubject_Form(int id)
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

            var name = txtName.Text;
            var midtermWeight = (double)numericUpDownMid.Value;
            var finalWeight = (double)numericUpDownFinal.Value;
            var semester = (short)numericUpDownSe.Value;

            SubjectScope.Update(Id, name, midtermWeight, finalWeight, semester);
            this.Close();
        }

        private void UpdateSubject_Form_Load(object sender, EventArgs e)
        {
            var subjects = SubjectScope.FindById(Id);
            txtName.Text = subjects.Name;
            numericUpDownMid.Value = (decimal)subjects.MidtermWeight * 100;
            numericUpDownFinal.Value = (decimal)subjects.FinalWeight * 100;
            numericUpDownSe.Value = subjects.Semester;
        }
    }
}
