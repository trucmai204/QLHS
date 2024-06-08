using Functions;

namespace QLHS
{
    public partial class fNewPhanLopHoc : Form
    {
        public fNewPhanLopHoc()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var className = txtTenlop.Text;
            var grade = (int)numericUpDownGrade.Value;
            var schoolYear = txtNienKhoa.Text;

            ClassScope.AddClass(className, grade, schoolYear);
            this.Close();
        }
    }
}
