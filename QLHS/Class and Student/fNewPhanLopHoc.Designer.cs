namespace QLHS
{
    partial class fNewPhanLopHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btSave = new Button();
            btClose = new Button();
            toolTip1 = new ToolTip(components);
            label3 = new Label();
            numericUpDownGrade = new NumericUpDown();
            txtNienKhoa = new TextBox();
            txtTenlop = new TextBox();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).BeginInit();
            SuspendLayout();
            // 
            // btSave
            // 
            btSave.Location = new Point(206, 132);
            btSave.Margin = new Padding(4, 5, 4, 5);
            btSave.Name = "btSave";
            btSave.Size = new Size(107, 38);
            btSave.TabIndex = 5;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(321, 132);
            btClose.Margin = new Padding(4, 5, 4, 5);
            btClose.Name = "btClose";
            btClose.Size = new Size(107, 38);
            btClose.TabIndex = 6;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(362, 40);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 22;
            label3.Text = "Khối:";
            // 
            // numericUpDownGrade
            // 
            numericUpDownGrade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownGrade.Location = new Point(435, 37);
            numericUpDownGrade.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDownGrade.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownGrade.Name = "numericUpDownGrade";
            numericUpDownGrade.Size = new Size(123, 31);
            numericUpDownGrade.TabIndex = 21;
            numericUpDownGrade.TextAlign = HorizontalAlignment.Center;
            numericUpDownGrade.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // txtNienKhoa
            // 
            txtNienKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNienKhoa.Location = new Point(194, 81);
            txtNienKhoa.Margin = new Padding(4, 5, 4, 5);
            txtNienKhoa.Name = "txtNienKhoa";
            txtNienKhoa.Size = new Size(364, 31);
            txtNienKhoa.TabIndex = 19;
            // 
            // txtTenlop
            // 
            txtTenlop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTenlop.Location = new Point(194, 37);
            txtTenlop.Margin = new Padding(4, 5, 4, 5);
            txtTenlop.Name = "txtTenlop";
            txtTenlop.Size = new Size(146, 31);
            txtTenlop.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 81);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 20;
            label5.Text = "Niên khóa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 40);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 18;
            label4.Text = "Tên lớp: ";
            // 
            // fNewPhanLopHoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 184);
            Controls.Add(label3);
            Controls.Add(numericUpDownGrade);
            Controls.Add(txtNienKhoa);
            Controls.Add(txtTenlop);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Margin = new Padding(4, 5, 4, 5);
            Name = "fNewPhanLopHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mới phân lớp học ";
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btSave;
        private Button btClose;
        private ToolTip toolTip1;
        private Label label3;
        private NumericUpDown numericUpDownGrade;
        private TextBox txtNienKhoa;
        private TextBox txtTenlop;
        private Label label5;
        private Label label4;
    }
}