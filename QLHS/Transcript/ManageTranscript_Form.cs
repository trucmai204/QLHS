using Functions;

namespace QLHS
{
    public partial class ManageTranscript_Form : Form
    {
        public ManageTranscript_Form()
        {
            InitializeComponent();
        }

        private void fDiem_Load(object sender, EventArgs e)
        {
            OutputTable.DataSource = TranscriptScope.FindByStudentName();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            var addDiem = new CreateTranscript_Form();
            addDiem.ShowDialog();
            OutputTable.DataSource = TranscriptScope.FindByStudentName();
        }

        private void btFind_Click(object sender, EventArgs e)
        {

            if (txtfind.Text.Trim() != string.Empty)
            {
                OutputTable.DataSource = TranscriptScope.FindByStudentName(txtfind.Text);
            }

        }


        private void OutputTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && OutputTable.Columns[e.ColumnIndex].Name == "Edit") // Kiểm tra xem row có hợp lệ hay không
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
                DataGridViewRow row = OutputTable.Rows[e.RowIndex]; // Lấy row hiện tại
                if (row.Cells.Count > 0) // Kiểm tra xem row có cell nào không
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

        private void button1_Click(object sender, EventArgs e)
        {
            var type = comboBox1.Text;
            var transcripts = TranscriptScope.FindTypeOf(type);
            OutputTable.DataSource = transcripts;
        }
    }
}
