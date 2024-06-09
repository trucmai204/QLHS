﻿using Functions;

namespace QLHS.Student
{
    public partial class CreateStudent_Form : Form
    {
        public CreateStudent_Form()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var studentName = txtName.Text;
            var gender = genderCheckBox.Checked;
            var classId = int.Parse(txtClassId.Text);
            var birthdate = birthdateTimePicker.Value;

            StudentScope.Create(studentName, birthdate, gender, classId);
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
