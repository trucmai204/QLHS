using Entities;
using Functions;
using System.Data;

namespace QLHS_2._0.Class
{
    public partial class ManageClass_Form : Form
    {
        public ManageClass_Form()
        {
            InitializeComponent();
            switch (CacheScope.RoleId)
            {
                case EnumRole.Admin:
                    btNew.Enabled = true;
                    break;
            }
        }

        private void ManageClass_Form_Load(object sender, EventArgs e)
        {
            comboBoxGrade.Items.Clear();
            comboBoxSchoolYear.Items.Clear();

            var grades = ClassScope.GetGrades().Select(grade => grade.ToString()).ToList();
            var schoolYears = ClassScope.GetSchoolYears();

            grades.Add("Tất cả");
            schoolYears.Add("Tất cả");

            comboBoxGrade.Items.AddRange(grades.ToArray());
            comboBoxSchoolYear.Items.AddRange(schoolYears.ToArray());

            comboBoxGrade.Text = comboBoxSchoolYear.Text = "Tất cả";

            OutputTable.DataSource = ClassScope.FindByName();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            var form = new CreateClass_Form();
            form.ShowDialog();
            ManageClass_Form_Load(sender, e);
        }

        private void OutputTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && OutputTable.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (CacheScope.RoleId == EnumRole.Admin)
                {
                    DataGridViewRow row = OutputTable.Rows[e.RowIndex];
                    if (row.Cells.Count > 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa lớp không?", "Yes/No Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            DataGridViewCell cell = row.Cells["ClassId"];

                            ClassScope.Delete((int)cell.Value);
                            ManageClass_Form_Load(sender, e);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền xóa", "Cấm", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else if (e.RowIndex >= 0 && OutputTable.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (CacheScope.RoleId == EnumRole.Admin || CacheScope.RoleId == EnumRole.ClassTeacher)
                {
                    DataGridViewRow row = OutputTable.Rows[e.RowIndex];
                    if (row.Cells.Count > 0)
                    {
                        DataGridViewCell cell = row.Cells["ClassId"];

                        var fEdit = new UpdateClass_Form((int)cell.Value);
                        fEdit.ShowDialog();
                        ManageClass_Form_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền sửa", "Cấm", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            int? grade;
            string? schoolYear;

            if (comboBoxGrade.Text == "" || comboBoxGrade.Text == "Tất cả")
            {
                grade = 0;
            }
            else
            {
                grade = int.Parse(comboBoxGrade.Text);
            }

            if (comboBoxSchoolYear.Text == "" || comboBoxSchoolYear.Text == "Tất cả")
            {
                schoolYear = "";
            }
            else
            {
                schoolYear = comboBoxSchoolYear.Text;
            }

            var classesWithGradeFilter = ClassScope.FindByGrade(grade);

            var classesWithSchoolYearFilter = ClassScope.FindBySchoolYear(schoolYear);

            var classes = classesWithGradeFilter.Intersect(classesWithSchoolYearFilter);
            OutputTable.DataSource = classes.ToList();
        }
    }
}
