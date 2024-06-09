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
            // Load danh sách môn học
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            var createSubjectForm = new CreateSubject_Form();
            createSubjectForm.ShowDialog();
            // Load danh sách môn học sau khi tạo môn học mới
        }

        private void OutputTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thực hiện hành động Xóa hoặc Sửa
        }
    }
}
