namespace QLHS_2._0.Class
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            OutputTable = new DataGridView();
            ClassId = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            SchoolYear = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btFind = new Button();
            label4 = new Label();
            btNew = new Button();
            label3 = new Label();
            label1 = new Label();
            comboBoxSchoolYear = new ComboBox();
            comboBoxGrade = new ComboBox();
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            OutputTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            OutputTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OutputTable.Columns.AddRange(new DataGridViewColumn[] { ClassId, ClassName, Grade, SchoolYear, Edit, Delete });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            OutputTable.DefaultCellStyle = dataGridViewCellStyle4;
            OutputTable.Location = new Point(10, 156);
            OutputTable.Margin = new Padding(1);
            OutputTable.Name = "OutputTable";
            OutputTable.ReadOnly = true;
            OutputTable.RowHeadersWidth = 51;
            OutputTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OutputTable.Size = new Size(1168, 510);
            OutputTable.TabIndex = 24;
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
            Edit.Width = 143;
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
            Delete.Width = 143;
            // 
            // btFind
            // 
            btFind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btFind.Location = new Point(938, 106);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(80, 33);
            btFind.TabIndex = 21;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(683, 108);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 23;
            label4.Text = "Niên Khóa:";
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.Enabled = false;
            btNew.Location = new Point(1022, 106);
            btNew.Margin = new Padding(2);
            btNew.Name = "btNew";
            btNew.Size = new Size(156, 33);
            btNew.TabIndex = 19;
            btNew.Text = "Thêm lớp học";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(450, 108);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 22;
            label3.Text = "Khối Lớp:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(385, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(418, 60);
            label1.TabIndex = 20;
            label1.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // comboBoxSchoolYear
            // 
            comboBoxSchoolYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxSchoolYear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSchoolYear.FormattingEnabled = true;
            comboBoxSchoolYear.Location = new Point(795, 106);
            comboBoxSchoolYear.Name = "comboBoxSchoolYear";
            comboBoxSchoolYear.Size = new Size(137, 33);
            comboBoxSchoolYear.TabIndex = 26;
            // 
            // comboBoxGrade
            // 
            comboBoxGrade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGrade.FormattingEnabled = true;
            comboBoxGrade.Location = new Point(548, 106);
            comboBoxGrade.Name = "comboBoxGrade";
            comboBoxGrade.Size = new Size(121, 33);
            comboBoxGrade.TabIndex = 25;
            // 
            // ManageClass_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1188, 676);
            Controls.Add(OutputTable);
            Controls.Add(btFind);
            Controls.Add(label4);
            Controls.Add(btNew);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(comboBoxSchoolYear);
            Controls.Add(comboBoxGrade);
            DoubleBuffered = true;
            Name = "ManageClass_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý lớp học";
            WindowState = FormWindowState.Maximized;
            Load += ManageClass_Form_Load;
            ((System.ComponentModel.ISupportInitialize)OutputTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OutputTable;
        private DataGridViewTextBoxColumn ClassId;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn SchoolYear;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btFind;
        private Label label4;
        private Button btNew;
        private Label label3;
        private Label label1;
        private ComboBox comboBoxSchoolYear;
        private ComboBox comboBoxGrade;
    }
}