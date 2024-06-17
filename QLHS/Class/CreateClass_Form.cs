using Functions;

namespace QLHS
{
    public partial class CreateClass_Form : Form
    {
        public CreateClass_Form()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var className = txtTenlop.Text;
            var grade = (int)numericUpDownGrade.Value;
            var schoolYear = comboBoxSchoolYear.Text;

            ClassScope.Create(className, grade, schoolYear);
            this.Close();
        }


    }
}
