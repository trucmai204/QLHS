using Functions;
using QLHS.Subject;


namespace QLHS.Student
{
    public partial class ManageSubject_Form : Form
    {
        public ManageSubject_Form()
        {
            InitializeComponent();
        }

        private void ManageSubject_Form_Load(object sender, EventArgs e)
        {
            OutputTable.DataSource = SubjectScope.FindByName(null);

            comboBoxSubjectName.Items.Clear();
            comboBoxSubjectName.Items.AddRange(SubjectScope.GetNames().ToArray());

            comboBoxSemester.Items.Clear();
            comboBoxSemester.Items.AddRange(SubjectScope.GetSemesters().ToArray());

        }

        private void OutputTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && OutputTable.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (CacheScope.RoleId == Entities.EnumRole.Admin || CacheScope.RoleId == Entities.EnumRole.SubjectTeacher)
                {
                    DataGridViewRow row = OutputTable.Rows[e.RowIndex]; // Lấy row hiện tại
                    if (row.Cells.Count > 0) // Kiểm tra xem row có cell nào không
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

        private void btFind_Click(object sender, EventArgs e)
        {
            OutputTable.DataSource = SubjectScope.FindByName(short.Parse(comboBoxSemester.Text), comboBoxSubjectName.Text);
        }


    }
}

