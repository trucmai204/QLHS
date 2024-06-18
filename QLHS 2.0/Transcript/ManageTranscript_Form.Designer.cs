namespace QLHS_2._0.Transcript
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
            btFindTypeOf = new Button();
            gradeTypeComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            btNew = new Button();
            btFind = new Button();
            txtfind = new TextBox();
            OutputTable = new DataGridView();
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
            label1.Location = new Point(635, 26);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(525, 55);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ ĐIỂM HỌC SINH";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btFindTypeOf
            // 
            btFindTypeOf.Location = new Point(258, 103);
            btFindTypeOf.Name = "btFindTypeOf";
            btFindTypeOf.Size = new Size(85, 34);
            btFindTypeOf.TabIndex = 25;
            btFindTypeOf.Text = "Lọc";
            btFindTypeOf.UseVisualStyleBackColor = true;
            btFindTypeOf.Click += btFindTypeOf_Click;
            // 
            // gradeTypeComboBox
            // 
            gradeTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Xuất sắc", "Giỏi", "Khá", "Trung bình" });
            gradeTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            gradeTypeComboBox.Font = new Font("Segoe UI", 8.5F);
            gradeTypeComboBox.FormattingEnabled = true;
            gradeTypeComboBox.Items.AddRange(new object[] { "Tất cả", "Giỏi", "Khá", "Trung Bình", "Kém" });
            gradeTypeComboBox.Location = new Point(102, 104);
            gradeTypeComboBox.Name = "gradeTypeComboBox";
            gradeTypeComboBox.Size = new Size(150, 31);
            gradeTypeComboBox.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(91, 30);
            label3.TabIndex = 23;
            label3.Text = "Xếp loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(710, 105);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 30);
            label2.TabIndex = 22;
            label2.Text = "Tra cứu học sinh";
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.Location = new Point(1621, 105);
            btNew.Margin = new Padding(1);
            btNew.Name = "btNew";
            btNew.Size = new Size(163, 34);
            btNew.TabIndex = 21;
            btNew.Text = "Nhập điểm";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // btFind
            // 
            btFind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btFind.Location = new Point(1549, 105);
            btFind.Margin = new Padding(1);
            btFind.Name = "btFind";
            btFind.Size = new Size(64, 34);
            btFind.TabIndex = 20;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // txtfind
            // 
            txtfind.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtfind.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtfind.Font = new Font("Segoe UI", 10.5F);
            txtfind.Location = new Point(880, 105);
            txtfind.Margin = new Padding(1);
            txtfind.Name = "txtfind";
            txtfind.PlaceholderText = "  Tìm học sinh . . .";
            txtfind.Size = new Size(661, 35);
            txtfind.TabIndex = 19;
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
            OutputTable.Location = new Point(12, 153);
            OutputTable.Margin = new Padding(1);
            OutputTable.Name = "OutputTable";
            OutputTable.ReadOnly = true;
            OutputTable.RowHeadersWidth = 51;
            OutputTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OutputTable.Size = new Size(1772, 707);
            OutputTable.TabIndex = 26;
            OutputTable.CellContentClick += OutputTable_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Mã bảng điểm";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // StudentName
            // 
            StudentName.DataPropertyName = "StudentName";
            StudentName.HeaderText = "Tên học sinh";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            // 
            // SubjectName
            // 
            SubjectName.DataPropertyName = "SubjectName";
            SubjectName.HeaderText = "Tên môn học";
            SubjectName.MinimumWidth = 6;
            SubjectName.Name = "SubjectName";
            SubjectName.ReadOnly = true;
            // 
            // MidtermGradeI
            // 
            MidtermGradeI.DataPropertyName = "MidtermGradeI";
            MidtermGradeI.HeaderText = "Điểm giữa kì I";
            MidtermGradeI.MinimumWidth = 6;
            MidtermGradeI.Name = "MidtermGradeI";
            MidtermGradeI.ReadOnly = true;
            // 
            // FinalGradeI
            // 
            FinalGradeI.DataPropertyName = "FinalGradeI";
            FinalGradeI.HeaderText = "Điểm cuối kì I";
            FinalGradeI.MinimumWidth = 6;
            FinalGradeI.Name = "FinalGradeI";
            FinalGradeI.ReadOnly = true;
            // 
            // AverageGradeI
            // 
            AverageGradeI.DataPropertyName = "AverageGradeI";
            AverageGradeI.HeaderText = "Điểm trung bình HKI";
            AverageGradeI.MinimumWidth = 6;
            AverageGradeI.Name = "AverageGradeI";
            AverageGradeI.ReadOnly = true;
            // 
            // MidtermGradeII
            // 
            MidtermGradeII.DataPropertyName = "MidtermGradeII";
            MidtermGradeII.HeaderText = "Điểm giữa kì II";
            MidtermGradeII.MinimumWidth = 6;
            MidtermGradeII.Name = "MidtermGradeII";
            MidtermGradeII.ReadOnly = true;
            // 
            // FinalGradeII
            // 
            FinalGradeII.DataPropertyName = "FinalGradeII";
            FinalGradeII.HeaderText = "Điểm cuối kì II";
            FinalGradeII.MinimumWidth = 6;
            FinalGradeII.Name = "FinalGradeII";
            FinalGradeII.ReadOnly = true;
            // 
            // AverageGradeII
            // 
            AverageGradeII.DataPropertyName = "AverageGradeII";
            AverageGradeII.HeaderText = "Điểm trung bình HKII";
            AverageGradeII.MinimumWidth = 6;
            AverageGradeII.Name = "AverageGradeII";
            AverageGradeII.ReadOnly = true;
            // 
            // FinalAverageGrade
            // 
            FinalAverageGrade.DataPropertyName = "FinalAverageGrade";
            FinalAverageGrade.HeaderText = "Tổng kết";
            FinalAverageGrade.MinimumWidth = 6;
            FinalAverageGrade.Name = "FinalAverageGrade";
            FinalAverageGrade.ReadOnly = true;
            // 
            // GradeType
            // 
            GradeType.DataPropertyName = "GradeType";
            GradeType.HeaderText = "Xếp loại";
            GradeType.MinimumWidth = 6;
            GradeType.Name = "GradeType";
            GradeType.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.HeaderText = "Hành động";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Hành động";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // ManageTranscript_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1794, 870);
            Controls.Add(OutputTable);
            Controls.Add(btFindTypeOf);
            Controls.Add(gradeTypeComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btNew);
            Controls.Add(btFind);
            Controls.Add(txtfind);
            Controls.Add(label1);
            DoubleBuffered = true;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "ManageTranscript_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản Lý Điểm Học Sinh";
            WindowState = FormWindowState.Maximized;
            Load += ManageTranscript_Form_Load;
            ((System.ComponentModel.ISupportInitialize)OutputTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btFindTypeOf;
        private ComboBox gradeTypeComboBox;
        private Label label3;
        private Label label2;
        private Button btNew;
        private Button btFind;
        private TextBox txtfind;
        private DataGridView OutputTable;
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