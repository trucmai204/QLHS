using Functions;

namespace QLHS
{
    public partial class fDiem : Form
    {
        public fDiem()
        {
            InitializeComponent();
        }

        private void fDiem_Load(object sender, EventArgs e)
        {
            OutputTable.DataSource = TranscriptScope.GetTranscripts();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            var addDiem = new fNewDiem();
            addDiem.ShowDialog();
            OutputTable.DataSource = TranscriptScope.GetTranscripts();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            OutputTable.DataSource = StudentScope.GetStudentBy(txtfind.Text);
        }

        private void txtfind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OutputTable.DataSource = TranscriptScope.GetTranscriptByStudentName(txtfind.Text);
            }
        }

        private void OutputTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem row có hợp lệ hay không
            {
                DataGridViewRow row = OutputTable.Rows[e.RowIndex]; // Lấy row hiện tại
                if (row.Cells.Count > 0) // Kiểm tra xem row có cell nào không
                {
                    DataGridViewCell cell = row.Cells[0];

                    var editDiem = new fEditDiem((int)cell.Value);
                    editDiem.ShowDialog();
                    OutputTable.DataSource = TranscriptScope.GetTranscripts();
                }
            }


        }

        private void OutputTable_Click(object sender, EventArgs e)
        {
            //if (OutputTable.SelectedRows.Count > 0)
            //{
            //    DialogResult dialogResult = MessageBox.Show("This is your message. Do you want to proceed?", "Yes/No Confirmation", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        DataGridViewRow selectedRow = OutputTable.SelectedRows[0];

            //        TranscriptScope.DeleteTranscriptById((int)selectedRow.Cells[0].Value);
            //        OutputTable.DataSource = TranscriptScope.GetTranscripts();
            //    }
            //}
        }

        private void OutputTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem row có hợp lệ hay không
            {
                DataGridViewRow row = OutputTable.Rows[e.RowIndex]; // Lấy row hiện tại
                if (row.Cells.Count > 0) // Kiểm tra xem row có cell nào không
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa học sinh không?", "Yes/No Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DataGridViewCell cell = row.Cells[0];

                        TranscriptScope.DeleteTranscriptById((int)cell.Value);
                        OutputTable.DataSource = TranscriptScope.GetTranscripts();
                    }
                }
            }
        }
    }
}
