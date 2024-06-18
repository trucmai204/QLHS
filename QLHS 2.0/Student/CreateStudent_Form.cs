using Functions;

namespace QLHS_2._0.Student
{
    public partial class CreateStudent_Form : Form
    {
        public CreateStudent_Form()
        {
            InitializeComponent();
        }

        private void CreateStudent_Form_Load(object sender, EventArgs e)
        {
            var classNames = ClassScope.GetNames();

            comboBoxClassName.DataSource = classNames;
            comboBoxClassName.Text = classNames.Last();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var studentName = txtName.Text;
            var gender = genderCheckBox.Checked;
            var className = comboBoxClassName.Text;
            var birthdate = birthdateTimePicker.Value;

            StudentScope.Create(studentName, birthdate, gender, className);
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
