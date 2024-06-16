using Functions;
using QLHS.Subject;
using WinRT;


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
            OutputTable.DataSource = SubjectScope.FindByName(null);

            comboBoxClassName.Items.Clear();
            comboBoxClassName.Items.AddRange(SubjectScope.GetNames().ToArray());

        }



        private void OutputTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && OutputTable.Columns[e.ColumnIndex].Name == "Edit")
            {
                DataGridViewRow row = OutputTable.Rows[e.RowIndex]; // Lấy row hiện tại
                if (row.Cells.Count > 0) // Kiểm tra xem row có cell nào không
                {
                    DataGridViewCell cell = row.Cells["SubjectId"];

                    var fEdit = new UpdateSubject_Form((int)cell.Value);
                    fEdit.ShowDialog();
                    OutputTable.DataSource = SubjectScope.FindByName( short.Parse(comboBoxSemester.Text), comboBoxClassName.Text);
                }
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            OutputTable.DataSource = SubjectScope.FindByName(short.Parse(comboBoxSemester.Text), comboBoxClassName.Text);
        }


    }
}
