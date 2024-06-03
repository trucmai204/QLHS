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
            Mahs = new DataGridViewTextBoxColumn();
            Malop = new DataGridViewTextBoxColumn();
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
            label1.Location = new Point(686, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(354, 60);
            label1.TabIndex = 0;
            label1.Text = "PHÂN LỚP HỌC";
            // 
            // OutputTable
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdPhanLop, Mahs, Malop, Tenlop, NienKhoa, Edit, Delete });
            dataGridView1.Location = new Point(17, 158);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1693, 722);
            dataGridView1.TabIndex = 4;
            // 
            // IdPhanLop
            // 
            IdPhanLop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IdPhanLop.DataPropertyName = "Id";
            IdPhanLop.HeaderText = "ID Phân Lớp";
            IdPhanLop.MinimumWidth = 8;
            IdPhanLop.Name = "IdPhanLop";
            IdPhanLop.Width = 145;
            // 
            // Mahs
            // 
            Mahs.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Mahs.HeaderText = "Mã Học Sinh";
            Mahs.MinimumWidth = 8;
            Mahs.Name = "Mahs";
            Mahs.Width = 149;
            // 
            // Malop
            // 
            Malop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Malop.HeaderText = "Mã Lớp";
            Malop.MinimumWidth = 8;
            Malop.Name = "Malop";
            Malop.Width = 108;
            // 
            // Tenlop
            // 
            Tenlop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tenlop.HeaderText = "Tên lớp";
            Tenlop.MinimumWidth = 8;
            Tenlop.Name = "Tenlop";
            Tenlop.Width = 105;
            // 
            // NienKhoa
            // 
            NienKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NienKhoa.HeaderText = "Niên Khóa";
            NienKhoa.MinimumWidth = 8;
            NienKhoa.Name = "NienKhoa";
            NienKhoa.Width = 129;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
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
            Delete.Width = 79;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(21, 103);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 3;
            label3.Text = "Niên khóa:";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(672, 104);
            txtFind.Margin = new Padding(4, 5, 4, 5);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(150, 31);
            txtFind.TabIndex = 2;
            // 
            // btNew
            // 
            btNew.Location = new Point(949, 99);
            btNew.Margin = new Padding(4, 5, 4, 5);
            btNew.Name = "btNew";
            btNew.Size = new Size(116, 40);
            btNew.TabIndex = 0;
            btNew.Text = "New";
            btNew.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(464, 103);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(205, 32);
            label4.TabIndex = 7;
            label4.Text = "Tìm kiếm lớp học:";
            // 
            // btFind
            // 
            btFind.Location = new Point(834, 99);
            btFind.Margin = new Padding(4, 5, 4, 5);
            btFind.Name = "btFind";
            btFind.Size = new Size(107, 40);
            btFind.TabIndex = 3;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
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
            // 
            // fPhanLopHoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1727, 888);
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
            StartPosition = FormStartPosition.CenterParent;
            Text = "Phân lớp học";
            WindowState = FormWindowState.Maximized;
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
        private DataGridViewTextBoxColumn IdPhanLop;
        private DataGridViewTextBoxColumn Mahs;
        private DataGridViewTextBoxColumn Malop;
        private DataGridViewTextBoxColumn Tenlop;
        private DataGridViewTextBoxColumn NienKhoa;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private TextBox txtNienKhoa;
        private Button btNienkhoa;
    }
}