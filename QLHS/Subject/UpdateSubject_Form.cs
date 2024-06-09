namespace QLHS.Subject
{
    public partial class UpdateSubject_Form : Form
    {
        public UpdateSubject_Form()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            // Gọi API update môn học
            this.Close();
        }
    }
}
