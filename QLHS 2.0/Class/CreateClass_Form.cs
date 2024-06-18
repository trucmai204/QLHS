using Functions;

namespace QLHS_2._0.Class
{
    public partial class CreateClass_Form : Form
    {
        public CreateClass_Form()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var className = txtTenlop.Text;
            var grade = (int)numericUpDownGrade.Value;
            var schoolYear = comboBoxSchoolYear.Text;

            ClassScope.Create(className, grade, schoolYear);
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateClass_Form_Load(object sender, EventArgs e)
        {
            var schoolYears = ClassScope.GetSchoolYears();

            comboBoxSchoolYear.DataSource = schoolYears;
            comboBoxSchoolYear.Text = schoolYears.Last();
        }
    }
}
