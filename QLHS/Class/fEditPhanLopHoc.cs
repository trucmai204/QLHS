using Functions;

namespace QLHS
{
    public partial class fEditPhanLopHoc : Form
    {
        public int Id;
        public fEditPhanLopHoc(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var name = txtTenlop.Text;      
            var grade = (int)numericUpDownGrade.Value;
            var schoolYear = txtNienKhoa.Text;

            ClassScope.Update(Id, name, grade, schoolYear);
            this.Close();
        }

        private void fEditPhanLopHoc_Load(object sender, EventArgs e)
        {
           var classes = ClassScope.FindById(Id);
           txtTenlop.Text = classes.Name;
           txtNienKhoa.Text = classes.SchoolYear;
           numericUpDownGrade.Value = classes.Grade;
        }
    }
}
