using Functions;

namespace QLHS_2._0.Transcript
{
    public partial class ManageTranscript_Form : Form
    {
        public ManageTranscript_Form()
        {
            InitializeComponent();
        }

        private void ManageTranscript_Form_Load(object sender, EventArgs e)
        {
            OutputTable.DataSource = TranscriptScope.FindByStudentName();
            gradeTypeComboBox.Text = "Tất cả";
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            var addDiem = new CreateTranscript_Form();
            addDiem.ShowDialog();
            OutputTable.DataSource = TranscriptScope.FindByStudentName();
        }

        private void OutputTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && OutputTable.Columns[e.ColumnIndex].Name == "Edit")
            {
                DataGridViewRow row = OutputTable.Rows[e.RowIndex];
                if (row.Cells.Count > 0)
                {
                    DataGridViewCell cell = row.Cells["Id"];

                    var editDiem = new UpdateTranscript_Form((int)cell.Value);
                    editDiem.ShowDialog();
                    OutputTable.DataSource = TranscriptScope.FindByStudentName();
                }

            }
            else if (e.RowIndex >= 0 && OutputTable.Columns[e.ColumnIndex].Name == "Delete")
            {
                DataGridViewRow row = OutputTable.Rows[e.RowIndex];
                if (row.Cells.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa bảng điểm của học sinh không?", "Yes/No Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DataGridViewCell cell = row.Cells["Id"];

                        TranscriptScope.Delete((int)cell.Value);
                        OutputTable.DataSource = TranscriptScope.FindByStudentName();
                    }
                }
            }
        }

        private void btFindTypeOf_Click(object sender, EventArgs e)
        {
            var type = gradeTypeComboBox.Text;
            if (type == "Tất cả")
            {
                OutputTable.DataSource = TranscriptScope.FindTypeOf("");
            }
            else
            {
                OutputTable.DataSource = TranscriptScope.FindTypeOf(type);
            }

        }

        private void btFind_Click(object sender, EventArgs e)
        {
            OutputTable.DataSource = TranscriptScope.FindByStudentName(txtfind.Text);
        }
    }
}
