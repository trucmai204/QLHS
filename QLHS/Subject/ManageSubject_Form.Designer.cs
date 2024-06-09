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
            btNew = new Button();
            OutputTable = new DataGridView();
            SubjectId = new DataGridViewTextBoxColumn();
            SubjectName = new DataGridViewTextBoxColumn();
            MidtermWeight = new DataGridViewTextBoxColumn();
            FinalWeight = new DataGridViewTextBoxColumn();
            Semester = new DataGridViewTextBoxColumn();
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
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 96);
            label2.Name = "label2";
            label2.Size = new Size(178, 30);
            label2.TabIndex = 17;
            label2.Text = "Tra cứu môn học";
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.Location = new Point(871, 93);
            btNew.Name = "btNew";
            btNew.Size = new Size(157, 37);
            btNew.TabIndex = 16;
            btNew.Text = "Thêm môn học";
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
            OutputTable.Columns.AddRange(new DataGridViewColumn[] { SubjectId, SubjectName, MidtermWeight, FinalWeight, Semester, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            OutputTable.DefaultCellStyle = dataGridViewCellStyle2;
            OutputTable.Location = new Point(7, 143);
            OutputTable.Name = "OutputTable";
            OutputTable.ReadOnly = true;
            OutputTable.RowHeadersWidth = 51;
            OutputTable.RowTemplate.Height = 25;
            OutputTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OutputTable.Size = new Size(1023, 421);
            OutputTable.TabIndex = 15;
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
            btFind.Location = new Point(770, 93);
            btFind.Name = "btFind";
            btFind.Size = new Size(95, 37);
            btFind.TabIndex = 14;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            // 
            // txtfind
            // 
            txtfind.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtfind.Font = new Font("Segoe UI", 11F);
            txtfind.Location = new Point(192, 93);
            txtfind.Name = "txtfind";
            txtfind.PlaceholderText = "  Tìm môn học . . .";
            txtfind.Size = new Size(572, 37);
            txtfind.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(314, 18);
            label1.Name = "label1";
            label1.Size = new Size(413, 55);
            label1.TabIndex = 12;
            label1.Text = "QUẢN LÝ MÔN HỌC";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageSubject_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1038, 581);
            Controls.Add(label2);
            Controls.Add(btNew);
            Controls.Add(OutputTable);
            Controls.Add(btFind);
            Controls.Add(txtfind);
            Controls.Add(label1);
            DoubleBuffered = true;
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
        private Button btNew;
        private DataGridView OutputTable;
        private Button btFind;
        private TextBox txtfind;
        private Label label1;
        private DataGridViewTextBoxColumn SubjectId;
        private DataGridViewTextBoxColumn SubjectName;
        private DataGridViewTextBoxColumn MidtermWeight;
        private DataGridViewTextBoxColumn FinalWeight;
        private DataGridViewTextBoxColumn Semester;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}