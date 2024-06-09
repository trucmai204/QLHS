using Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.Student
{
    public partial class ManageStudent_Form : Form
    {
        public ManageStudent_Form()
        {
            InitializeComponent();
        }

        private void ManageStudent_Form_Load(object sender, EventArgs e)
        {
            StudentScope.FindByName();
        }
    }
}
