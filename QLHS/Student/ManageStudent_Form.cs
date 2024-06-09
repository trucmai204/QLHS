using Functions;

namespace QLHS.Student
{
    public partial class ManageStudent_Form : Form
    {
        public ManageStudent_Form()
        {
            InitializeComponent();
        }

        private void ManageStudent_Form_Load(object sender, EventArgs e)
        {
            OutputTable.DataSource = StudentScope.FindByName();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            var studentCreateForm = new CreateStudent_Form();
            studentCreateForm.ShowDialog();
            OutputTable.DataSource = StudentScope.FindByName();
        }

        private void OutputTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && OutputTable.Columns[e.ColumnIndex].Name == "Delete")
            {
                DataGridViewRow row = OutputTable.Rows[e.RowIndex];
                if (row.Cells.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa học sinh này không?", "Yes/No Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DataGridViewCell cell = row.Cells["StudentId"];

                        ClassScope.Delete((int)cell.Value);
                        OutputTable.DataSource = StudentScope.FindByName();
                    }
                }
            }
            else if (e.RowIndex >= 0 && OutputTable.Columns[e.ColumnIndex].Name == "Edit")
            {
                DataGridViewRow row = OutputTable.Rows[e.RowIndex];
                if (row.Cells.Count > 0)
                {
                    DataGridViewCell cell = row.Cells["StudentId"];

                    var fEdit = new UpdateStudent_Form((int)cell.Value);
                    fEdit.ShowDialog();
                    OutputTable.DataSource = StudentScope.FindByName();
                }
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            if (txtfind.Text.Trim() != string.Empty)
            {
                OutputTable.DataSource = StudentScope.FindByName(txtfind.Text);
            }
        }
    }
}
