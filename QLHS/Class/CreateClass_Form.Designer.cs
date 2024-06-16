namespace QLHS
{
    partial class CreateClass_Form
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
            txtTenlop = new TextBox();
            label5 = new Label();
            label4 = new Label();
            comboBoxSchoolYear = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).BeginInit();
            SuspendLayout();
            // 
            // btSave
            // 
            btSave.Location = new Point(135, 77);
            btSave.Margin = new Padding(2);
            btSave.Name = "btSave";
            btSave.Size = new Size(58, 26);
            btSave.TabIndex = 5;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(216, 77);
            btClose.Margin = new Padding(2);
            btClose.Name = "btClose";
            btClose.Size = new Size(58, 26);
            btClose.TabIndex = 6;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(240, 19);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 22;
            label3.Text = "Khối:";
            // 
            // numericUpDownGrade
            // 
            numericUpDownGrade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownGrade.Location = new Point(279, 17);
            numericUpDownGrade.Margin = new Padding(2, 1, 2, 1);
            numericUpDownGrade.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDownGrade.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownGrade.Name = "numericUpDownGrade";
            numericUpDownGrade.Size = new Size(66, 23);
            numericUpDownGrade.TabIndex = 21;
            numericUpDownGrade.TextAlign = HorizontalAlignment.Center;
            numericUpDownGrade.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // txtTenlop
            // 
            txtTenlop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTenlop.Location = new Point(104, 17);
            txtTenlop.Margin = new Padding(2);
            txtTenlop.Name = "txtTenlop";
            txtTenlop.Size = new Size(125, 23);
            txtTenlop.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 52);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 20;
            label5.Text = "Niên khóa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 19);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 18;
            label4.Text = "Tên lớp: ";
            // 
            // comboBoxSchoolYear
            // 
            comboBoxSchoolYear.FormattingEnabled = true;
            comboBoxSchoolYear.Items.AddRange(new object[] { "2021-2022", "2022-2023", "2023-2024" });
            comboBoxSchoolYear.Location = new Point(153, 49);
            comboBoxSchoolYear.Name = "comboBoxSchoolYear";
            comboBoxSchoolYear.Size = new Size(121, 23);
            comboBoxSchoolYear.TabIndex = 23;
            // 
            // CreateClass_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 114);
            Controls.Add(comboBoxSchoolYear);
            Controls.Add(label3);
            Controls.Add(numericUpDownGrade);
            Controls.Add(txtTenlop);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Margin = new Padding(2);
            Name = "CreateClass_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm lớp học ";
          
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
        private TextBox txtTenlop;
        private Label label5;
        private Label label4;
        private ComboBox comboBoxSchoolYear;
    }
}