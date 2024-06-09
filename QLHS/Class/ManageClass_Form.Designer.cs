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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            label1 = new Label();
            label3 = new Label();
            txtFind = new TextBox();
            btNew = new Button();
            label4 = new Label();
            btFind = new Button();
            txtNienKhoa = new TextBox();
            btNienkhoa = new Button();
            OutputTable = new DataGridView();
            ClassId = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            SchoolYear = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)OutputTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(597, 12);
            label1.Name = "label1";
            label1.Size = new Size(418, 60);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(8, 88);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 3;
            label3.Text = "Khối Lớp:";
            // 
            // txtFind
            // 
            txtFind.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFind.Location = new Point(595, 87);
            txtFind.Margin = new Padding(3, 4, 3, 4);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(737, 31);
            txtFind.TabIndex = 2;
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.Location = new Point(1427, 87);
            btNew.Margin = new Padding(3, 4, 3, 4);
            btNew.Name = "btNew";
            btNew.Size = new Size(172, 31);
            btNew.TabIndex = 0;
            btNew.Text = "Thêm lớp học";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(423, 88);
            label4.Name = "label4";
            label4.Size = new Size(166, 28);
            label4.TabIndex = 7;
            label4.Text = "Tìm kiếm lớp học:";
            // 
            // btFind
            // 
            btFind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btFind.Location = new Point(1338, 86);
            btFind.Margin = new Padding(3, 4, 3, 4);
            btFind.Name = "btFind";
            btFind.Size = new Size(83, 32);
            btFind.TabIndex = 3;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // txtNienKhoa
            // 
            txtNienKhoa.Location = new Point(108, 87);
            txtNienKhoa.Margin = new Padding(3, 4, 3, 4);
            txtNienKhoa.Name = "txtNienKhoa";
            txtNienKhoa.Size = new Size(159, 31);
            txtNienKhoa.TabIndex = 1;
            // 
            // btNienkhoa
            // 
            btNienkhoa.Location = new Point(272, 86);
            btNienkhoa.Margin = new Padding(3, 4, 3, 4);
            btNienkhoa.Name = "btNienkhoa";
            btNienkhoa.Size = new Size(76, 32);
            btNienkhoa.TabIndex = 8;
            btNienkhoa.Text = "Lọc";
            btNienkhoa.UseVisualStyleBackColor = true;
            btNienkhoa.Click += btNienkhoa_Click;
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
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            OutputTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            OutputTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OutputTable.Columns.AddRange(new DataGridViewColumn[] { ClassId, ClassName, Grade, SchoolYear, Edit, Delete });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            OutputTable.DefaultCellStyle = dataGridViewCellStyle10;
            OutputTable.Location = new Point(8, 133);
            OutputTable.Margin = new Padding(2);
            OutputTable.Name = "OutputTable";
            OutputTable.ReadOnly = true;
            OutputTable.RowHeadersWidth = 51;
            OutputTable.RowTemplate.Height = 25;
            OutputTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OutputTable.Size = new Size(1595, 754);
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
            // ManageClass_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1612, 896);
            Controls.Add(OutputTable);
            Controls.Add(btNienkhoa);
            Controls.Add(txtNienKhoa);
            Controls.Add(btFind);
            Controls.Add(label4);
            Controls.Add(btNew);
            Controls.Add(txtFind);
            Controls.Add(label3);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 5, 4, 5);
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
        private TextBox txtFind;
        private Button btNew;
        private Label label4;
        private Button btFind;
        private TextBox txtNienKhoa;
        private Button btNienkhoa;
        private DataGridView OutputTable;
        private DataGridViewTextBoxColumn ClassId;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn SchoolYear;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}