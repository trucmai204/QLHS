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
            dataGridView1.DataSource = ClassScope.GetClass("");
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            string classby = txtFind.Text;
            var classes = ClassScope.GetClass(classby);
            dataGridView1.DataSource = classes;

        }

        private void btNienkhoa_Click(object sender, EventArgs e)
        {
            string gradeBy = txtNienKhoa.Text;
            var grade = ClassScope.GetClass(gradeBy);
            dataGridView1.DataSource = grade;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                ClassScope.DeleteClassById(id);
            }

        }
    }
}
