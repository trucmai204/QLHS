namespace QLHS
{
    partial class ManageTranscript_Form
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
            txtfind = new TextBox();
            btFind = new Button();
            OutputTable = new DataGridView();
            btNew = new Button();
            label2 = new Label();
            Id = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            SubjectName = new DataGridViewTextBoxColumn();
            MidtermGradeI = new DataGridViewTextBoxColumn();
            FinalGradeI = new DataGridViewTextBoxColumn();
            AverageGradeI = new DataGridViewTextBoxColumn();
            MidtermGradeII = new DataGridViewTextBoxColumn();
            FinalGradeII = new DataGridViewTextBoxColumn();
            AverageGradeII = new DataGridViewTextBoxColumn();
            FinalAverageGrade = new DataGridViewTextBoxColumn();
            GradeType = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)OutputTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(588, 22);
            label1.Name = "label1";
            label1.Size = new Size(437, 46);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ ĐIỂM HỌC SINH";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtfind
            // 
            txtfind.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtfind.Font = new Font("Segoe UI", 11F);
            txtfind.Location = new Point(190, 98);
            txtfind.Name = "txtfind";
            txtfind.PlaceholderText = "  Tìm học sinh . . .";
            txtfind.Size = new Size(1234, 32);
            txtfind.TabIndex = 1;
            // 
            // btFind
            // 
            btFind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btFind.Location = new Point(1430, 98);
            btFind.Name = "btFind";
            btFind.Size = new Size(95, 37);
            btFind.TabIndex = 2;
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
            OutputTable.Columns.AddRange(new DataGridViewColumn[] { Id, StudentName, SubjectName, MidtermGradeI, FinalGradeI, AverageGradeI, MidtermGradeII, FinalGradeII, AverageGradeII, FinalAverageGrade, GradeType, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            OutputTable.DefaultCellStyle = dataGridViewCellStyle2;
            OutputTable.Location = new Point(8, 148);
            OutputTable.Name = "OutputTable";
            OutputTable.ReadOnly = true;
            OutputTable.RowHeadersWidth = 51;
            OutputTable.RowTemplate.Height = 25;
            OutputTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OutputTable.Size = new Size(1680, 728);
            OutputTable.TabIndex = 3;
            OutputTable.CellContentClick += OutputTable_CellContentClick;
       
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.Location = new Point(1531, 98);
            btNew.Name = "btNew";
            btNew.Size = new Size(157, 37);
            btNew.TabIndex = 4;
            btNew.Text = "Nhập điểm";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 101);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 5;
            label2.Text = "Tra cứu học sinh";
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Mã bảng điểm";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 138;
            // 
            // StudentName
            // 
            StudentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentName.DataPropertyName = "StudentName";
            StudentName.HeaderText = "Tên học sinh";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            StudentName.Width = 125;
            // 
            // SubjectName
            // 
            SubjectName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SubjectName.DataPropertyName = "SubjectName";
            SubjectName.HeaderText = "Tên môn học";
            SubjectName.MinimumWidth = 6;
            SubjectName.Name = "SubjectName";
            SubjectName.ReadOnly = true;
            SubjectName.Width = 128;
            // 
            // MidtermGradeI
            // 
            MidtermGradeI.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MidtermGradeI.DataPropertyName = "MidtermGradeI";
            MidtermGradeI.HeaderText = "Điểm giữa kì I";
            MidtermGradeI.MinimumWidth = 6;
            MidtermGradeI.Name = "MidtermGradeI";
            MidtermGradeI.ReadOnly = true;
            MidtermGradeI.Width = 135;
            // 
            // FinalGradeI
            // 
            FinalGradeI.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FinalGradeI.DataPropertyName = "FinalGradeI";
            FinalGradeI.HeaderText = "Điểm cuối kì I";
            FinalGradeI.MinimumWidth = 6;
            FinalGradeI.Name = "FinalGradeI";
            FinalGradeI.ReadOnly = true;
            FinalGradeI.Width = 133;
            // 
            // AverageGradeI
            // 
            AverageGradeI.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AverageGradeI.DataPropertyName = "AverageGradeI";
            AverageGradeI.HeaderText = "Điểm trung bình HKI";
            AverageGradeI.MinimumWidth = 6;
            AverageGradeI.Name = "AverageGradeI";
            AverageGradeI.ReadOnly = true;
            AverageGradeI.Width = 144;
            // 
            // MidtermGradeII
            // 
            MidtermGradeII.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MidtermGradeII.DataPropertyName = "MidtermGradeII";
            MidtermGradeII.HeaderText = "Điểm giữa kì II";
            MidtermGradeII.MinimumWidth = 6;
            MidtermGradeII.Name = "MidtermGradeII";
            MidtermGradeII.ReadOnly = true;
            MidtermGradeII.Width = 105;
            // 
            // FinalGradeII
            // 
            FinalGradeII.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FinalGradeII.DataPropertyName = "FinalGradeII";
            FinalGradeII.HeaderText = "Điểm cuối kì II";
            FinalGradeII.MinimumWidth = 6;
            FinalGradeII.Name = "FinalGradeII";
            FinalGradeII.ReadOnly = true;
            FinalGradeII.Width = 103;
            // 
            // AverageGradeII
            // 
            AverageGradeII.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AverageGradeII.DataPropertyName = "AverageGradeII";
            AverageGradeII.HeaderText = "Điểm trung bình HKII";
            AverageGradeII.MinimumWidth = 6;
            AverageGradeII.Name = "AverageGradeII";
            AverageGradeII.ReadOnly = true;
            AverageGradeII.Width = 144;
            // 
            // FinalAverageGrade
            // 
            FinalAverageGrade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FinalAverageGrade.DataPropertyName = "FinalAverageGrade";
            FinalAverageGrade.HeaderText = "Tổng kết";
            FinalAverageGrade.MinimumWidth = 6;
            FinalAverageGrade.Name = "FinalAverageGrade";
            FinalAverageGrade.ReadOnly = true;
            FinalAverageGrade.Width = 92;
            // 
            // GradeType
            // 
            GradeType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GradeType.DataPropertyName = "GradeType";
            GradeType.HeaderText = "Xếp loại";
            GradeType.MinimumWidth = 6;
            GradeType.Name = "GradeType";
            GradeType.ReadOnly = true;
            GradeType.Width = 65;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 42;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 60;
            // 
            // ManageTranscript_Form
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1700, 888);
            Controls.Add(label2);
            Controls.Add(btNew);
            Controls.Add(OutputTable);
            Controls.Add(btFind);
            Controls.Add(txtfind);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "ManageTranscript_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Điểm Học Sinh";
            WindowState = FormWindowState.Maximized;
            Load += fDiem_Load;
            ((System.ComponentModel.ISupportInitialize)OutputTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtfind;
        private Button btFind;
        private DataGridView OutputTable;
        private Button btNew;
        private Label label2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn SubjectName;
        private DataGridViewTextBoxColumn MidtermGradeI;
        private DataGridViewTextBoxColumn FinalGradeI;
        private DataGridViewTextBoxColumn AverageGradeI;
        private DataGridViewTextBoxColumn MidtermGradeII;
        private DataGridViewTextBoxColumn FinalGradeII;
        private DataGridViewTextBoxColumn AverageGradeII;
        private DataGridViewTextBoxColumn FinalAverageGrade;
        private DataGridViewTextBoxColumn GradeType;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}