namespace QLHS_2._0.Subject
{
    partial class ManageSubject_Form
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            OutputTable = new DataGridView();
            SubjectId = new DataGridViewTextBoxColumn();
            SubjectName = new DataGridViewTextBoxColumn();
            MidtermWeight = new DataGridViewTextBoxColumn();
            FinalWeight = new DataGridViewTextBoxColumn();
            Semester = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            label4 = new Label();
            label3 = new Label();
            comboBoxSubjectName = new ComboBox();
            comboBoxSemester = new ComboBox();
            btFind = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)OutputTable).BeginInit();
            SuspendLayout();
            // 
            // OutputTable
            // 
            OutputTable.AllowUserToAddRows = false;
            OutputTable.AllowUserToDeleteRows = false;
            OutputTable.AllowUserToResizeRows = false;
            OutputTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OutputTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OutputTable.BackgroundColor = SystemColors.ControlLight;
            OutputTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            OutputTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            OutputTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OutputTable.Columns.AddRange(new DataGridViewColumn[] { SubjectId, SubjectName, MidtermWeight, FinalWeight, Semester, Edit });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            OutputTable.DefaultCellStyle = dataGridViewCellStyle2;
            OutputTable.Location = new Point(10, 139);
            OutputTable.Margin = new Padding(1);
            OutputTable.Name = "OutputTable";
            OutputTable.ReadOnly = true;
            OutputTable.RowHeadersWidth = 51;
            OutputTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OutputTable.Size = new Size(1305, 557);
            OutputTable.TabIndex = 24;
            OutputTable.CellContentClick += OutputTable_CellContentClick;
            // 
            // SubjectId
            // 
            SubjectId.DataPropertyName = "Id";
            SubjectId.HeaderText = "Mã môn học";
            SubjectId.MinimumWidth = 8;
            SubjectId.Name = "SubjectId";
            SubjectId.ReadOnly = true;
            // 
            // SubjectName
            // 
            SubjectName.DataPropertyName = "Name";
            SubjectName.HeaderText = "Tên môn học";
            SubjectName.MinimumWidth = 8;
            SubjectName.Name = "SubjectName";
            SubjectName.ReadOnly = true;
            // 
            // MidtermWeight
            // 
            MidtermWeight.DataPropertyName = "MidtermWeight";
            MidtermWeight.HeaderText = "Tỉ lệ điểm giữa kỳ";
            MidtermWeight.MinimumWidth = 8;
            MidtermWeight.Name = "MidtermWeight";
            MidtermWeight.ReadOnly = true;
            // 
            // FinalWeight
            // 
            FinalWeight.DataPropertyName = "FinalWeight";
            FinalWeight.HeaderText = "Tỉ lệ điểm cuối kỳ";
            FinalWeight.MinimumWidth = 8;
            FinalWeight.Name = "FinalWeight";
            FinalWeight.ReadOnly = true;
            FinalWeight.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Semester
            // 
            Semester.DataPropertyName = "Semester";
            Semester.HeaderText = "Học kỳ";
            Semester.MinimumWidth = 8;
            Semester.Name = "Semester";
            Semester.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.HeaderText = "Hành động";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(1015, 90);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 29;
            label4.Text = "Học kỳ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(650, 90);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 28;
            label3.Text = "Tên môn học";
            // 
            // comboBoxSubjectName
            // 
            comboBoxSubjectName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxSubjectName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubjectName.FormattingEnabled = true;
            comboBoxSubjectName.Location = new Point(769, 86);
            comboBoxSubjectName.Name = "comboBoxSubjectName";
            comboBoxSubjectName.Size = new Size(226, 33);
            comboBoxSubjectName.TabIndex = 27;
            // 
            // comboBoxSemester
            // 
            comboBoxSemester.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSemester.FormattingEnabled = true;
            comboBoxSemester.Items.AddRange(new object[] { "1", "2" });
            comboBoxSemester.Location = new Point(1087, 86);
            comboBoxSemester.Name = "comboBoxSemester";
            comboBoxSemester.Size = new Size(121, 33);
            comboBoxSemester.TabIndex = 26;
            // 
            // btFind
            // 
            btFind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btFind.Location = new Point(1227, 86);
            btFind.Margin = new Padding(1);
            btFind.Name = "btFind";
            btFind.Size = new Size(88, 33);
            btFind.TabIndex = 23;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(456, 20);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(413, 55);
            label1.TabIndex = 22;
            label1.Text = "QUẢN LÝ MÔN HỌC";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageSubject_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1325, 706);
            Controls.Add(OutputTable);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxSubjectName);
            Controls.Add(comboBoxSemester);
            Controls.Add(btFind);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "ManageSubject_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý môn học";
            WindowState = FormWindowState.Maximized;
            Load += ManageSubject_Form_Load;
            ((System.ComponentModel.ISupportInitialize)OutputTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView OutputTable;
        private DataGridViewTextBoxColumn SubjectId;
        private DataGridViewTextBoxColumn SubjectName;
        private DataGridViewTextBoxColumn MidtermWeight;
        private DataGridViewTextBoxColumn FinalWeight;
        private DataGridViewTextBoxColumn Semester;
        private DataGridViewButtonColumn Edit;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxSubjectName;
        private ComboBox comboBoxSemester;
        private Button btFind;
        private Label label1;
    }
}