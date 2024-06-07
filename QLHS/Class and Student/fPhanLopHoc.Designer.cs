namespace QLHS
{
    partial class fPhanLopHoc
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
            IdPhanLop = new DataGridViewTextBoxColumn();
            Tenlop = new DataGridViewTextBoxColumn();
            NienKhoa = new DataGridViewTextBoxColumn();
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
            label1.Location = new Point(290, 12);
            label1.Name = "label1";
            label1.Size = new Size(298, 50);
            label1.TabIndex = 0;
            label1.Text = "PHÂN LỚP HỌC";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdPhanLop, Tenlop, NienKhoa, Edit, Delete });
            dataGridView1.Location = new Point(14, 126);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(836, 578);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IdPhanLop
            // 
            IdPhanLop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IdPhanLop.DataPropertyName = "Id";
            IdPhanLop.HeaderText = "ID Phân Lớp";
            IdPhanLop.MinimumWidth = 8;
            IdPhanLop.Name = "IdPhanLop";
            IdPhanLop.Width = 118;
            // 
            // Tenlop
            // 
            Tenlop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tenlop.DataPropertyName = "Name";
            Tenlop.HeaderText = "Tên lớp";
            Tenlop.MinimumWidth = 8;
            Tenlop.Name = "Tenlop";
            Tenlop.Width = 87;
            // 
            // NienKhoa
            // 
            NienKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NienKhoa.DataPropertyName = "Grade";
            NienKhoa.HeaderText = "Niên Khóa";
            NienKhoa.MinimumWidth = 8;
            NienKhoa.Name = "NienKhoa";
            NienKhoa.Width = 107;
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
            Edit.Width = 63;
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
            Delete.Width = 64;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(17, 82);
            label3.Name = "label3";
            label3.Size = new Size(105, 28);
            label3.TabIndex = 3;
            label3.Text = "Niên khóa:";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(538, 83);
            txtFind.Margin = new Padding(3, 4, 3, 4);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(121, 27);
            txtFind.TabIndex = 2;
            // 
            // btNew
            // 
            btNew.Location = new Point(759, 79);
            btNew.Margin = new Padding(3, 4, 3, 4);
            btNew.Name = "btNew";
            btNew.Size = new Size(93, 32);
            btNew.TabIndex = 0;
            btNew.Text = "New";
            btNew.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(371, 82);
            label4.Name = "label4";
            label4.Size = new Size(166, 28);
            label4.TabIndex = 7;
            label4.Text = "Tìm kiếm lớp học:";
            // 
            // btFind
            // 
            btFind.Location = new Point(667, 79);
            btFind.Margin = new Padding(3, 4, 3, 4);
            btFind.Name = "btFind";
            btFind.Size = new Size(86, 32);
            btFind.TabIndex = 3;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // txtNienKhoa
            // 
            txtNienKhoa.Location = new Point(123, 83);
            txtNienKhoa.Margin = new Padding(3, 4, 3, 4);
            txtNienKhoa.Name = "txtNienKhoa";
            txtNienKhoa.Size = new Size(132, 27);
            txtNienKhoa.TabIndex = 1;
            // 
            // btNienkhoa
            // 
            btNienkhoa.Location = new Point(263, 82);
            btNienkhoa.Margin = new Padding(3, 4, 3, 4);
            btNienkhoa.Name = "btNienkhoa";
            btNienkhoa.Size = new Size(67, 27);
            btNienkhoa.TabIndex = 8;
            btNienkhoa.Text = "Lọc";
            btNienkhoa.UseVisualStyleBackColor = true;
            btNienkhoa.Click += btNienkhoa_Click;
            // 
            // fPhanLopHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(864, 710);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "fPhanLopHoc";
            StartPosition = FormStartPosition.CenterParent;
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
        private DataGridViewTextBoxColumn IdPhanLop;
        private DataGridViewTextBoxColumn Tenlop;
        private DataGridViewTextBoxColumn NienKhoa;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}