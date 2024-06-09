using Functions;

namespace QLHS
{
    public partial class fPhanLopHoc : Form
    {
        public fPhanLopHoc()
        {
            InitializeComponent();
        }

        private void fPhanLopHoc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClassScope.FindByName();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            string classby = txtFind.Text;
            var classes = ClassScope.FindByName(classby);
            dataGridView1.DataSource = classes;

        }

        private void btNienkhoa_Click(object sender, EventArgs e)
        {
            var grade = int.Parse(txtNienKhoa.Text);
            var classes = ClassScope.FindByGrade(grade);
            dataGridView1.DataSource = classes;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Delete") // Kiểm tra xem row có hợp lệ hay không
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; // Lấy row hiện tại
                if (row.Cells.Count > 0) // Kiểm tra xem row có cell nào không
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa lớp không?", "Yes/No Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DataGridViewCell cell = row.Cells["IdPhanLop"];

                        ClassScope.Delete((int)cell.Value);
                        dataGridView1.DataSource = ClassScope.FindByName();
                    }
                }
            }

            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Edit") // Kiểm tra xem row có hợp lệ hay không
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; // Lấy row hiện tại
                if (row.Cells.Count > 0) // Kiểm tra xem row có cell nào không
                {
                    DataGridViewCell cell = row.Cells["IdPhanLop"];

                    var fEdit = new fEditPhanLopHoc((int)cell.Value);
                    fEdit.ShowDialog();
                    dataGridView1.DataSource = ClassScope.FindByName();
                }
            }


        }

        private void btNew_Click(object sender, EventArgs e)
        {
            var fNewClass = new fNewPhanLopHoc();
            fNewClass.ShowDialog();

            dataGridView1.DataSource= ClassScope.FindByName();
        }
    }
}
