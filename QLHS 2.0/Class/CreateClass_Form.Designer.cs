namespace QLHS_2._0.Class
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
            toolTip1 = new ToolTip(components);
            label6 = new Label();
            btClose = new Button();
            btSave = new Button();
            comboBoxSchoolYear = new ComboBox();
            label3 = new Label();
            numericUpDownGrade = new NumericUpDown();
            txtTenlop = new TextBox();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label6.Location = new Point(288, 29);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(254, 48);
            label6.TabIndex = 86;
            label6.Text = "TẠO LỚP MỚI";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.None;
            btClose.BackColor = Color.FromArgb(255, 192, 192);
            btClose.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btClose.Location = new Point(421, 199);
            btClose.Margin = new Padding(2);
            btClose.Name = "btClose";
            btClose.Size = new Size(115, 44);
            btClose.TabIndex = 85;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Anchor = AnchorStyles.None;
            btSave.BackColor = Color.FromArgb(192, 255, 192);
            btSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btSave.Location = new Point(295, 199);
            btSave.Margin = new Padding(2);
            btSave.Name = "btSave";
            btSave.Size = new Size(115, 44);
            btSave.TabIndex = 84;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // comboBoxSchoolYear
            // 
            comboBoxSchoolYear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSchoolYear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSchoolYear.FormattingEnabled = true;
            comboBoxSchoolYear.Items.AddRange(new object[] { "2021-2022", "2022-2023", "2023-2024" });
            comboBoxSchoolYear.Location = new Point(204, 145);
            comboBoxSchoolYear.Name = "comboBoxSchoolYear";
            comboBoxSchoolYear.Size = new Size(525, 33);
            comboBoxSchoolYear.TabIndex = 83;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(569, 101);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 82;
            label3.Text = "Khối:";
            // 
            // numericUpDownGrade
            // 
            numericUpDownGrade.Anchor = AnchorStyles.Right;
            numericUpDownGrade.Location = new Point(624, 98);
            numericUpDownGrade.Margin = new Padding(2, 1, 2, 1);
            numericUpDownGrade.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDownGrade.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownGrade.Name = "numericUpDownGrade";
            numericUpDownGrade.Size = new Size(105, 31);
            numericUpDownGrade.TabIndex = 81;
            numericUpDownGrade.TextAlign = HorizontalAlignment.Center;
            numericUpDownGrade.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // txtTenlop
            // 
            txtTenlop.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTenlop.Location = new Point(203, 98);
            txtTenlop.Margin = new Padding(2);
            txtTenlop.Name = "txtTenlop";
            txtTenlop.Size = new Size(334, 31);
            txtTenlop.TabIndex = 78;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(101, 148);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 80;
            label5.Text = "Niên khóa:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(119, 101);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 79;
            label4.Text = "Tên lớp: ";
            // 
            // CreateClass_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 273);
            Controls.Add(label6);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(comboBoxSchoolYear);
            Controls.Add(label3);
            Controls.Add(numericUpDownGrade);
            Controls.Add(txtTenlop);
            Controls.Add(label5);
            Controls.Add(label4);
            DoubleBuffered = true;
            Name = "CreateClass_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo lớp mới";
            Load += CreateClass_Form_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip toolTip1;
        private Label label6;
        private Button btClose;
        private Button btSave;
        private ComboBox comboBoxSchoolYear;
        private Label label3;
        private NumericUpDown numericUpDownGrade;
        private TextBox txtTenlop;
        private Label label5;
        private Label label4;
    }
}