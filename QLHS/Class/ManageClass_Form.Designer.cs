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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ClassId = new DataGridViewTextBoxColumn();
            Tenlop = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            SchoolYear = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label3 = new Label();
            txtFind = new TextBox();
            btNew = new Button();
            label4 = new Label();
            btFind = new Button();
            txtNienKhoa = new TextBox();
            btNienkhoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(386, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(354, 60);
            label1.TabIndex = 0;
            label1.Text = "PHÂN LỚP HỌC";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ClassId, Tenlop, Grade, SchoolYear, Edit, Delete });
            dataGridView1.Location = new Point(18, 158);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1093, 382);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ClassId
            // 
            ClassId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ClassId.DataPropertyName = "Id";
            ClassId.HeaderText = "Mã lớp";
            ClassId.MinimumWidth = 8;
            ClassId.Name = "ClassId";
            ClassId.Width = 104;
            // 
            // Tenlop
            // 
            Tenlop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tenlop.DataPropertyName = "Name";
            Tenlop.HeaderText = "Tên lớp";
            Tenlop.MinimumWidth = 8;
            Tenlop.Name = "Tenlop";
            Tenlop.Width = 105;
            // 
            // Grade
            // 
            Grade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Grade.DataPropertyName = "Grade";
            Grade.HeaderText = "Khối Lớp";
            Grade.MinimumWidth = 8;
            Grade.Name = "Grade";
            Grade.Width = 118;
            // 
            // SchoolYear
            // 
            SchoolYear.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SchoolYear.DataPropertyName = "SchoolYear";
            SchoolYear.HeaderText = "Niên Khóa";
            SchoolYear.MinimumWidth = 8;
            SchoolYear.Name = "SchoolYear";
            SchoolYear.Width = 129;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 78;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 79;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(21, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 3;
            label3.Text = "Niên khóa:";
            // 
            // txtFind
            // 
            txtFind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFind.Location = new Point(719, 104);
            txtFind.Margin = new Padding(4, 5, 4, 5);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(150, 31);
            txtFind.TabIndex = 2;
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.Location = new Point(996, 99);
            btNew.Margin = new Padding(4, 5, 4, 5);
            btNew.Name = "btNew";
            btNew.Size = new Size(116, 40);
            btNew.TabIndex = 0;
            btNew.Text = "New";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(511, 102);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(205, 32);
            label4.TabIndex = 7;
            label4.Text = "Tìm kiếm lớp học:";
            // 
            // btFind
            // 
            btFind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btFind.Location = new Point(881, 99);
            btFind.Margin = new Padding(4, 5, 4, 5);
            btFind.Name = "btFind";
            btFind.Size = new Size(108, 40);
            btFind.TabIndex = 3;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // txtNienKhoa
            // 
            txtNienKhoa.Location = new Point(154, 104);
            txtNienKhoa.Margin = new Padding(4, 5, 4, 5);
            txtNienKhoa.Name = "txtNienKhoa";
            txtNienKhoa.Size = new Size(164, 31);
            txtNienKhoa.TabIndex = 1;
            // 
            // btNienkhoa
            // 
            btNienkhoa.Location = new Point(329, 102);
            btNienkhoa.Margin = new Padding(4, 5, 4, 5);
            btNienkhoa.Name = "btNienkhoa";
            btNienkhoa.Size = new Size(84, 34);
            btNienkhoa.TabIndex = 8;
            btNienkhoa.Text = "Lọc";
            btNienkhoa.UseVisualStyleBackColor = true;
            btNienkhoa.Click += btNienkhoa_Click;
            // 
            // fPhanLopHoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1128, 548);
            Controls.Add(btNienkhoa);
            Controls.Add(txtNienKhoa);
            Controls.Add(btFind);
            Controls.Add(label4);
            Controls.Add(btNew);
            Controls.Add(txtFind);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 5, 4, 5);
            Name = "fPhanLopHoc";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phân lớp học";
            WindowState = FormWindowState.Maximized;
            Load += fPhanLopHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtFind;
        private Button btNew;
        private Label label4;
        private Button btFind;
        private TextBox txtNienKhoa;
        private Button btNienkhoa;
        private DataGridViewTextBoxColumn ClassId;
        private DataGridViewTextBoxColumn Tenlop;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn SchoolYear;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}