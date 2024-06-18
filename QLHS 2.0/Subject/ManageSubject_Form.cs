using Functions;

namespace QLHS_2._0.Subject
{
    public partial class ManageSubject_Form : Form
    {
        public ManageSubject_Form()
        {
            InitializeComponent();
        }

        private void ManageSubject_Form_Load(object sender, EventArgs e)
        {
            OutputTable.DataSource = SubjectScope.Find(null);

            comboBoxSubjectName.Items.Clear();
            comboBoxSemester.Items.Clear();

            var subjectNames = SubjectScope.GetNames();
            var semesters = SubjectScope.GetSemesters();

            subjectNames.Add("Tất cả");
            semesters.Add("Tất cả");

            comboBoxSubjectName.Items.AddRange(subjectNames.ToArray());
            comboBoxSemester.Items.AddRange(semesters.ToArray());

            comboBoxSemester.Text = comboBoxSubjectName.Text = "Tất cả";
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            string? subjectName;
            short? semester;

            if (comboBoxSubjectName.Text == "Tất cả" || comboBoxSubjectName.Text == "")
            {
                subjectName = "";
            }
            else
            {
                subjectName = comboBoxSubjectName.Text;
            }

            if (comboBoxSemester.Text == "Tất cả" || comboBoxSemester.Text == "")
            {
                semester = null;
            }
            else
            {
                semester = short.Parse(comboBoxSemester.Text);
            }

            OutputTable.DataSource = SubjectScope.Find(semester, subjectName);
        }

        private void OutputTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && OutputTable.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (CacheScope.RoleId == Entities.EnumRole.Admin || CacheScope.RoleId == Entities.EnumRole.SubjectTeacher)
                {
                    DataGridViewRow row = OutputTable.Rows[e.RowIndex];
                    if (row.Cells.Count > 0)
                    {
                        DataGridViewCell cell = row.Cells["SubjectId"];

                        var fEdit = new UpdateSubject_Form((int)cell.Value);
                        fEdit.ShowDialog();

                        ManageSubject_Form_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền sửa", "Cấm", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
