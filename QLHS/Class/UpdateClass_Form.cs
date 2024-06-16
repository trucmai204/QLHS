using Functions;

namespace QLHS
{
    public partial class UpdateClass_Form : Form
    {
        public int Id;
        public UpdateClass_Form(int id)
        {
            InitializeComponent();
            Id = id;
        }


        private void btSave_Click(object sender, EventArgs e)
        {
            var name = txtTenlop.Text;
            var grade = (int)numericUpDownGrade.Value;
            var schoolYear = comboBoxSchoolYear.Text;

            ClassScope.Update(Id, name, grade, schoolYear);
            this.Close();
        }

        private void fEditPhanLopHoc_Load(object sender, EventArgs e)
        {
            var classes = ClassScope.FindById(Id);
            txtTenlop.Text = classes.Name;
            comboBoxSchoolYear.Text = classes.SchoolYear;
            numericUpDownGrade.Value = classes.Grade;
        }

        private void btClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
