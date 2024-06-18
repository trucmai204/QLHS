using Functions;

namespace QLHS_2._0.Class
{
    public partial class UpdateClass_Form : Form
    {
        public int Id;
        public UpdateClass_Form(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void UpdateClass_Form_Load(object sender, EventArgs e)
        {
            var classes = ClassScope.FindById(Id);
            var grades = ClassScope.GetGrades();
            var schoolYears = ClassScope.GetSchoolYears();

            txtTenlop.Text = classes.Name;
            comboBoxSchoolYear.Text = classes.SchoolYear;
            numericUpDownGrade.Value = classes.Grade;

            comboBoxSchoolYear.DataSource = schoolYears;

            numericUpDownGrade.Minimum = grades.Min();
            numericUpDownGrade.Minimum = grades.Max();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var name = txtTenlop.Text;
            var grade = (int)numericUpDownGrade.Value;
            var schoolYear = comboBoxSchoolYear.Text;

            ClassScope.Update(Id, name, grade, schoolYear);
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
