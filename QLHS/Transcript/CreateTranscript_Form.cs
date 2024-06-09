﻿using Functions;

namespace QLHS
{
    public partial class CreateTranscript_Form : Form
    {
        public CreateTranscript_Form()
        {
            InitializeComponent();

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var midGradeI = double.Parse(txtDiemGK1.Text);
            var finalGradeI = double.Parse(txtDiemCK1.Text);
            var midGradeII = double.Parse(txtDiemGK2.Text);
            var finalGradeII = double.Parse(txtDiemCK2.Text);

            TranscriptScope.Create(txtTenhs.Text, txtTenMonHoc.Text, midGradeI, finalGradeI, midGradeII, finalGradeII);

            this.Close();
        }
    }
}