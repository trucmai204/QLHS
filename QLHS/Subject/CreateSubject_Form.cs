namespace QLHS.Subject
{
    public partial class CreateSubject_Form : Form
    {
        public CreateSubject_Form()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            // Gọi API tạo môn học mới
            this.Close();
        }
    }
}
