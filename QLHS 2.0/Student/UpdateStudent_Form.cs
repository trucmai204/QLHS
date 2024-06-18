using Functions;

namespace QLHS_2._0.Student
{
    public partial class UpdateStudent_Form : Form
    {
        private int Id;
        public UpdateStudent_Form(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void UpdateStudent_Form_Load(object sender, EventArgs e)
        {
            var student = StudentScope.FindById(Id);
            var className = ClassScope.FindById(student.ClassId).Name;

            txtName.Text = student.Name;
            genderCheckBox.Checked = student.Gender;
            comboBoxClassName.Text = className;
            birthdateTimePicker.Value = student.Birthdate;

            comboBoxClassName.DataSource = ClassScope.GetNames();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var studentName = txtName.Text;
            var gender = genderCheckBox.Checked;
            var classId = ClassScope.FindByName(comboBoxClassName.Text).First().Id;
            var birthdate = birthdateTimePicker.Value;

            StudentScope.Update(Id, studentName, birthdate, gender, classId);

            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
