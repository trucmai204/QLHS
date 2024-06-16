namespace QLHS.Student
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
            label2 = new Label();
            OutputTable = new DataGridView();
            btFind = new Button();
            label1 = new Label();
            comboBoxSemester = new ComboBox();
            comboBoxClassName = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            SubjectId = new DataGridViewTextBoxColumn();
            SubjectName = new DataGridViewTextBoxColumn();
            MidtermWeight = new DataGridViewTextBoxColumn();
            FinalWeight = new DataGridViewTextBoxColumn();
            Semester = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)OutputTable).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 45);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 17;
            label2.Text = "Tra cứu môn học";
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
            OutputTable.Location = new Point(4, 77);
            OutputTable.Margin = new Padding(1);
            OutputTable.Name = "OutputTable";
            OutputTable.ReadOnly = true;
            OutputTable.RowHeadersWidth = 51;
            OutputTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OutputTable.Size = new Size(793, 293);
            OutputTable.TabIndex = 15;
            OutputTable.CellContentClick += OutputTable_CellContentClick;
            // 
            // btFind
            // 
            btFind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btFind.Location = new Point(665, 45);
            btFind.Margin = new Padding(1);
            btFind.Name = "btFind";
            btFind.Size = new Size(51, 25);
            btFind.TabIndex = 14;
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
            label1.Location = new Point(256, 8);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 37);
            label1.TabIndex = 12;
            label1.Text = "QUẢN LÝ MÔN HỌC";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxSemester
            // 
            comboBoxSemester.FormattingEnabled = true;
            comboBoxSemester.Items.AddRange(new object[] { "1", "2" });
            comboBoxSemester.Location = new Point(523, 45);
            comboBoxSemester.Name = "comboBoxSemester";
            comboBoxSemester.Size = new Size(121, 23);
            comboBoxSemester.TabIndex = 18;
            // 
            // comboBoxClassName
            // 
            comboBoxClassName.FormattingEnabled = true;
            comboBoxClassName.Location = new Point(307, 45);
            comboBoxClassName.Name = "comboBoxClassName";
            comboBoxClassName.Size = new Size(121, 23);
            comboBoxClassName.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 49);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 20;
            label3.Text = "Tên môn học";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(463, 50);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 21;
            label4.Text = "Học kỳ";
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
            // ManageSubject_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(801, 377);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxClassName);
            Controls.Add(comboBoxSemester);
            Controls.Add(label2);
            Controls.Add(OutputTable);
            Controls.Add(btFind);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(1);
            Name = "ManageSubject_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý môn học";
            WindowState = FormWindowState.Maximized;
            Load += ManageSubject_Form_Load;
            ((System.ComponentModel.ISupportInitialize)OutputTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView OutputTable;
        private Button btFind;
        private Label label1;
        private ComboBox comboBoxSemester;
        private ComboBox comboBoxClassName;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn SubjectId;
        private DataGridViewTextBoxColumn SubjectName;
        private DataGridViewTextBoxColumn MidtermWeight;
        private DataGridViewTextBoxColumn FinalWeight;
        private DataGridViewTextBoxColumn Semester;
        private DataGridViewButtonColumn Edit;
    }
}