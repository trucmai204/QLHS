﻿namespace QLHS_2._0.Student
{
    partial class ManageStudent_Form
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
            btNew = new Button();
            OutputTable = new DataGridView();
            StudentId = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Birthdate = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewCheckBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            SchoolYear = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btFind = new Button();
            txtfind = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)OutputTable).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(579, 109);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 23;
            label2.Text = "Tra cứu học sinh";
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.Enabled = false;
            btNew.Location = new Point(1230, 105);
            btNew.Margin = new Padding(1);
            btNew.Name = "btNew";
            btNew.Size = new Size(138, 37);
            btNew.TabIndex = 22;
            btNew.Text = "Thêm học sinh";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
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
            OutputTable.Columns.AddRange(new DataGridViewColumn[] { StudentId, StudentName, Birthdate, Gender, ClassName, Grade, SchoolYear, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            OutputTable.DefaultCellStyle = dataGridViewCellStyle2;
            OutputTable.Location = new Point(10, 160);
            OutputTable.Margin = new Padding(1);
            OutputTable.Name = "OutputTable";
            OutputTable.ReadOnly = true;
            OutputTable.RowHeadersWidth = 51;
            OutputTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OutputTable.Size = new Size(1358, 546);
            OutputTable.TabIndex = 21;
            OutputTable.CellContentClick += OutputTable_CellContentClick;
            // 
            // StudentId
            // 
            StudentId.DataPropertyName = "Id";
            StudentId.HeaderText = "Mã học sinh";
            StudentId.MinimumWidth = 8;
            StudentId.Name = "StudentId";
            StudentId.ReadOnly = true;
            // 
            // StudentName
            // 
            StudentName.DataPropertyName = "StudentName";
            StudentName.HeaderText = "Họ và tên";
            StudentName.MinimumWidth = 8;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            // 
            // Birthdate
            // 
            Birthdate.DataPropertyName = "Birthdate";
            Birthdate.HeaderText = "Ngày sinh";
            Birthdate.MinimumWidth = 8;
            Birthdate.Name = "Birthdate";
            Birthdate.ReadOnly = true;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Giới tính";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            // 
            // ClassName
            // 
            ClassName.DataPropertyName = "ClassName";
            ClassName.HeaderText = "Lớp";
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
            Edit.HeaderText = "Hành động";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Hành động";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // btFind
            // 
            btFind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btFind.Location = new Point(1156, 105);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(64, 37);
            btFind.TabIndex = 20;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // txtfind
            // 
            txtfind.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtfind.Font = new Font("Segoe UI", 10F);
            txtfind.Location = new Point(744, 106);
            txtfind.Margin = new Padding(2);
            txtfind.Name = "txtfind";
            txtfind.PlaceholderText = "  Tìm học sinh . . .";
            txtfind.Size = new Size(400, 34);
            txtfind.TabIndex = 19;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(484, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(410, 55);
            label1.TabIndex = 18;
            label1.Text = "QUẢN LÝ HỌC SINH";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageStudent_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1378, 716);
            Controls.Add(txtfind);
            Controls.Add(label2);
            Controls.Add(btNew);
            Controls.Add(OutputTable);
            Controls.Add(btFind);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "ManageStudent_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý học sinh";
            WindowState = FormWindowState.Maximized;
            Load += ManageStudent_Form_Load;
            ((System.ComponentModel.ISupportInitialize)OutputTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btNew;
        private DataGridView OutputTable;
        private DataGridViewTextBoxColumn StudentId;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Birthdate;
        private DataGridViewCheckBoxColumn Gender;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn SchoolYear;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btFind;
        private TextBox txtfind;
        private Label label1;
    }
}