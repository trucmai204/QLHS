using Functions;

namespace QLHS.Student
{
    public partial class UpdateStudent_Form : Form
    {
        private int Id;
        public UpdateStudent_Form(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var studentName = txtName.Text;
            var gender = genderCheckBox.Checked;
            var classId = int.Parse(txtClassId.Text);
            var birthdate = birthdateTimePicker.Value;

            StudentScope.Update(Id, studentName, birthdate, gender, classId);

            this.Close();
        }

        private void UpdateStudent_Form_Load(object sender, EventArgs e)
        {
            var student = StudentScope.FindById(Id);

            txtName.Text = student.Name;
            genderCheckBox.Checked = student.Gender;
            txtClassId.Text = student.ClassId.ToString();
            birthdateTimePicker.Value = student.Birthdate;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
