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
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(270, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 40);
            label1.TabIndex = 0;
            label1.Text = "Phân lớp học";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdPhanLop, Mahs, Malop, Tenlop, NienKhoa, Edit, Delete });
            dataGridView1.Location = new Point(12, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 289);
            dataGridView1.TabIndex = 4;
            // 
            // IdPhanLop
            // 
            IdPhanLop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IdPhanLop.DataPropertyName = "Id";
            IdPhanLop.HeaderText = "ID Phân Lớp";
            IdPhanLop.Name = "IdPhanLop";
            IdPhanLop.Width = 96;
            // 
            // Mahs
            // 
            Mahs.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Mahs.HeaderText = "Mã Học Sinh";
            Mahs.Name = "Mahs";
            // 
            // Malop
            // 
            Malop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Malop.HeaderText = "Mã Lớp";
            Malop.Name = "Malop";
            Malop.Width = 72;
            // 
            // Tenlop
            // 
            Tenlop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tenlop.HeaderText = "Tên lớp";
            Tenlop.Name = "Tenlop";
            Tenlop.Width = 70;
            // 
            // NienKhoa
            // 
            NienKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NienKhoa.HeaderText = "Niên Khóa";
            NienKhoa.Name = "NienKhoa";
            NienKhoa.Width = 87;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Sửa";
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Width = 51;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Xóa";
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Width = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(123, 77);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 3;
            label3.Text = "Niên khóa:";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(591, 75);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(106, 23);
            txtFind.TabIndex = 2;
            // 
            // btNew
            // 
            btNew.Location = new Point(15, 37);
            btNew.Name = "btNew";
            btNew.Size = new Size(102, 37);
            btNew.TabIndex = 0;
            btNew.Text = "New";
            btNew.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(452, 77);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 7;
            label4.Text = "Tìm kiếm lớp học:";
            // 
            // btFind
            // 
            btFind.Location = new Point(703, 73);
            btFind.Name = "btFind";
            btFind.Size = new Size(75, 29);
            btFind.TabIndex = 3;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            // 
            // txtNienKhoa
            // 
            txtNienKhoa.Location = new Point(213, 77);
            txtNienKhoa.Name = "txtNienKhoa";
            txtNienKhoa.Size = new Size(116, 23);
            txtNienKhoa.TabIndex = 1;
            // 
            // btNienkhoa
            // 
            btNienkhoa.Location = new Point(335, 79);
            btNienkhoa.Name = "btNienkhoa";
            btNienkhoa.Size = new Size(49, 23);
            btNienkhoa.TabIndex = 8;
            btNienkhoa.Text = "Lọc";
            btNienkhoa.UseVisualStyleBackColor = true;
            // 
            // fPhanLopHoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
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
            Name = "fPhanLopHoc";
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