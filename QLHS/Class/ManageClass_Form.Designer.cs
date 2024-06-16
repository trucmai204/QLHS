namespace QLHS
{
    partial class ManageClass_Form
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
            label1 = new Label();
            label3 = new Label();
            btNew = new Button();
            label4 = new Label();
            btFind = new Button();
            OutputTable = new DataGridView();
            ClassId = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            SchoolYear = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            comboBoxGrade = new ComboBox();
            comboBoxSchoolYear = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)OutputTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(418, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(277, 40);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(299, 49);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 3;
            label3.Text = "Khối Lớp:";
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.Location = new Point(936, 43);
            btNew.Margin = new Padding(2);
            btNew.Name = "btNew";
            btNew.Size = new Size(131, 25);
            btNew.TabIndex = 0;
            btNew.Text = "Thêm lớp học";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(511, 49);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 19);
            label4.TabIndex = 7;
            label4.Text = "Niên Khóa:";
            // 
            // btFind
            // 
            btFind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btFind.Location = new Point(761, 46);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(64, 25);
            btFind.TabIndex = 3;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
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
            OutputTable.Columns.AddRange(new DataGridViewColumn[] { ClassId, ClassName, Grade, SchoolYear, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            OutputTable.DefaultCellStyle = dataGridViewCellStyle2;
            OutputTable.Location = new Point(10, 74);
            OutputTable.Margin = new Padding(1);
            OutputTable.Name = "OutputTable";
            OutputTable.ReadOnly = true;
            OutputTable.RowHeadersWidth = 51;
            OutputTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OutputTable.Size = new Size(1058, 430);
            OutputTable.TabIndex = 16;
            OutputTable.CellContentClick += OutputTable_CellContentClick;
            // 
            // ClassId
            // 
            ClassId.DataPropertyName = "Id";
            ClassId.HeaderText = "Mã lớp";
            ClassId.MinimumWidth = 8;
            ClassId.Name = "ClassId";
            ClassId.ReadOnly = true;
            // 
            // ClassName
            // 
            ClassName.DataPropertyName = "Name";
            ClassName.HeaderText = "Tên lớp";
            ClassName.MinimumWidth = 8;
            ClassName.Name = "ClassName";
            ClassName.ReadOnly = true;
            // 
            // Grade
            // 
            Grade.DataPropertyName = "Grade";
            Grade.HeaderText = "Khối";
            Grade.MinimumWidth = 8;
            Grade.Name = "Grade";
            Grade.ReadOnly = true;
            // 
            // SchoolYear
            // 
            SchoolYear.DataPropertyName = "SchoolYear";
            SchoolYear.HeaderText = "Niên khóa";
            SchoolYear.MinimumWidth = 8;
            SchoolYear.Name = "SchoolYear";
            SchoolYear.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Hành động";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 93;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Hành động";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 93;
            // 
            // comboBoxGrade
            // 
            comboBoxGrade.FormattingEnabled = true;
            comboBoxGrade.Items.AddRange(new object[] { "10", "11", "12" });
            comboBoxGrade.Location = new Point(370, 46);
            comboBoxGrade.Name = "comboBoxGrade";
            comboBoxGrade.Size = new Size(121, 23);
            comboBoxGrade.TabIndex = 17;
            // 
            // comboBoxSchoolYear
            // 
            comboBoxSchoolYear.FormattingEnabled = true;
            comboBoxSchoolYear.Items.AddRange(new object[] { "2021-2022", "2022-2023", "2023-2024" });
            comboBoxSchoolYear.Location = new Point(606, 46);
            comboBoxSchoolYear.Name = "comboBoxSchoolYear";
            comboBoxSchoolYear.Size = new Size(121, 23);
            comboBoxSchoolYear.TabIndex = 18;
            // 
            // ManageClass_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1078, 507);
            Controls.Add(comboBoxSchoolYear);
            Controls.Add(comboBoxGrade);
            Controls.Add(OutputTable);
            Controls.Add(btFind);
            Controls.Add(label4);
            Controls.Add(btNew);
            Controls.Add(label3);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "ManageClass_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phân lớp học";
            WindowState = FormWindowState.Maximized;
            Load += fPhanLopHoc_Load;
            ((System.ComponentModel.ISupportInitialize)OutputTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Button btNew;
        private Label label4;
        private Button btFind;
        private DataGridView OutputTable;
        private DataGridViewTextBoxColumn ClassId;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn SchoolYear;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private ComboBox comboBoxGrade;
        private ComboBox comboBoxSchoolYear;
    }
}