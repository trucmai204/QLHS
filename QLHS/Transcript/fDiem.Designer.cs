namespace QLHS
{
    partial class fDiem
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
            label1 = new Label();
            label2 = new Label();
            txtfind = new TextBox();
            btFind = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            StudentId = new DataGridViewTextBoxColumn();
            SubjectId = new DataGridViewTextBoxColumn();
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
            btNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(625, 14);
            label1.Name = "label1";
            label1.Size = new Size(476, 55);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Điểm Học Sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(156, 32);
            label2.TabIndex = 2;
            label2.Text = "Tìm học sinh:";
            // 
            // txtfind
            // 
            txtfind.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtfind.Location = new Point(174, 92);
            txtfind.Name = "txtfind";
            txtfind.Size = new Size(565, 31);
            txtfind.TabIndex = 1;
            // 
            // btFind
            // 
            btFind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btFind.Location = new Point(745, 90);
            btFind.Name = "btFind";
            btFind.Size = new Size(95, 34);
            btFind.TabIndex = 2;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, StudentId, SubjectId, MidtermGradeI, FinalGradeI, AverageGradeI, MidtermGradeII, FinalGradeII, AverageGradeII, FinalAverageGrade, GradeType, Edit, Delete });
            dataGridView1.Location = new Point(8, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1712, 728);
            dataGridView1.TabIndex = 3;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Mã bảng điểm";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 156;
            // 
            // StudentId
            // 
            StudentId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentId.DataPropertyName = "StudentId";
            StudentId.HeaderText = "Mã học sinh";
            StudentId.MinimumWidth = 6;
            StudentId.Name = "StudentId";
            StudentId.ReadOnly = true;
            StudentId.Width = 139;
            // 
            // SubjectId
            // 
            SubjectId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SubjectId.DataPropertyName = "SubjectId";
            SubjectId.HeaderText = "Mã môn học";
            SubjectId.MinimumWidth = 6;
            SubjectId.Name = "SubjectId";
            SubjectId.ReadOnly = true;
            SubjectId.Width = 142;
            // 
            // MidtermGradeI
            // 
            MidtermGradeI.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MidtermGradeI.DataPropertyName = "MidtermGradeI";
            MidtermGradeI.HeaderText = "Điểm giữa kì I";
            MidtermGradeI.MinimumWidth = 6;
            MidtermGradeI.Name = "MidtermGradeI";
            MidtermGradeI.ReadOnly = true;
            MidtermGradeI.Width = 129;
            // 
            // FinalGradeI
            // 
            FinalGradeI.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FinalGradeI.DataPropertyName = "FinalGradeI";
            FinalGradeI.HeaderText = "Điểm cuối kì I";
            FinalGradeI.MinimumWidth = 6;
            FinalGradeI.Name = "FinalGradeI";
            FinalGradeI.ReadOnly = true;
            FinalGradeI.Width = 127;
            // 
            // AverageGradeI
            // 
            AverageGradeI.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AverageGradeI.DataPropertyName = "AverageGradeI";
            AverageGradeI.HeaderText = "Điểm trung bình HKI";
            AverageGradeI.MinimumWidth = 6;
            AverageGradeI.Name = "AverageGradeI";
            AverageGradeI.ReadOnly = true;
            AverageGradeI.Width = 176;
            // 
            // MidtermGradeII
            // 
            MidtermGradeII.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MidtermGradeII.DataPropertyName = "MidtermGradeII";
            MidtermGradeII.HeaderText = "Điểm giữa kì II";
            MidtermGradeII.MinimumWidth = 6;
            MidtermGradeII.Name = "MidtermGradeII";
            MidtermGradeII.ReadOnly = true;
            MidtermGradeII.Width = 129;
            // 
            // FinalGradeII
            // 
            FinalGradeII.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FinalGradeII.DataPropertyName = "FinalGradeII";
            FinalGradeII.HeaderText = "Điểm cuối kì II";
            FinalGradeII.MinimumWidth = 6;
            FinalGradeII.Name = "FinalGradeII";
            FinalGradeII.ReadOnly = true;
            FinalGradeII.Width = 127;
            // 
            // AverageGradeII
            // 
            AverageGradeII.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AverageGradeII.DataPropertyName = "AverageGradeII";
            AverageGradeII.HeaderText = "Điểm trung bình HKII";
            AverageGradeII.MinimumWidth = 6;
            AverageGradeII.Name = "AverageGradeII";
            AverageGradeII.ReadOnly = true;
            AverageGradeII.Width = 176;
            // 
            // FinalAverageGrade
            // 
            FinalAverageGrade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FinalAverageGrade.DataPropertyName = "FinalAverageGrade";
            FinalAverageGrade.HeaderText = "Tổng kết";
            FinalAverageGrade.MinimumWidth = 6;
            FinalAverageGrade.Name = "FinalAverageGrade";
            FinalAverageGrade.ReadOnly = true;
            FinalAverageGrade.Width = 115;
            // 
            // GradeType
            // 
            GradeType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GradeType.DataPropertyName = "GradeType";
            GradeType.HeaderText = "Loại";
            GradeType.MinimumWidth = 6;
            GradeType.Name = "GradeType";
            GradeType.ReadOnly = true;
            GradeType.Width = 83;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Width = 80;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Width = 81;
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.Location = new Point(846, 90);
            btNew.Name = "btNew";
            btNew.Size = new Size(157, 34);
            btNew.TabIndex = 4;
            btNew.Text = "Thêm điểm";
            btNew.UseVisualStyleBackColor = true;
            // 
            // fDiem
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1727, 888);
            Controls.Add(btNew);
            Controls.Add(dataGridView1);
            Controls.Add(btFind);
            Controls.Add(txtfind);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "fDiem";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Điểm Học Sinh";
            WindowState = FormWindowState.Maximized;
            Load += fDiem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtfind;
        private Button btFind;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn StudentId;
        private DataGridViewTextBoxColumn SubjectId;
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
        private Button btNew;
    }
}