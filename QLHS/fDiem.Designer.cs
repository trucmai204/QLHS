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
            label1 = new Label();
            btNew = new Button();
            label2 = new Label();
            txtfind = new TextBox();
            btFind = new Button();
            dataGridView1 = new DataGridView();
            MaBangDiem = new DataGridViewTextBoxColumn();
            Mahs = new DataGridViewTextBoxColumn();
            Tenhs = new DataGridViewTextBoxColumn();
            MaMonHoc = new DataGridViewTextBoxColumn();
            DiemGK1 = new DataGridViewTextBoxColumn();
            DiemCK1 = new DataGridViewTextBoxColumn();
            DiemTBHK1 = new DataGridViewTextBoxColumn();
            DiemGK2 = new DataGridViewTextBoxColumn();
            DiemCK2 = new DataGridViewTextBoxColumn();
            DiemTBHK2 = new DataGridViewTextBoxColumn();
            TongKet = new DataGridViewTextBoxColumn();
            Loai = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(188, 36);
            label1.Name = "label1";
            label1.Size = new Size(393, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Điểm Học Sinh";
            // 
            // btNew
            // 
            btNew.Location = new Point(30, 33);
            btNew.Name = "btNew";
            btNew.Size = new Size(99, 40);
            btNew.TabIndex = 0;
            btNew.Text = "New";
            btNew.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(544, 33);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 2;
            label2.Text = "Tìm học sinh:";
            // 
            // txtfind
            // 
            txtfind.Location = new Point(545, 57);
            txtfind.Name = "txtfind";
            txtfind.Size = new Size(170, 27);
            txtfind.TabIndex = 1;
            // 
            // btFind
            // 
            btFind.Location = new Point(721, 57);
            btFind.Name = "btFind";
            btFind.Size = new Size(67, 23);
            btFind.TabIndex = 2;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaBangDiem, Mahs, Tenhs, MaMonHoc, DiemGK1, DiemCK1, DiemTBHK1, DiemGK2, DiemCK2, DiemTBHK2, TongKet, Loai, Edit, Delete });
            dataGridView1.Location = new Point(3, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(785, 340);
            dataGridView1.TabIndex = 3;
            // 
            // MaBangDiem
            // 
            MaBangDiem.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaBangDiem.HeaderText = "Mã bảng điểm";
            MaBangDiem.MinimumWidth = 6;
            MaBangDiem.Name = "MaBangDiem";
            MaBangDiem.Width = 124;
            // 
            // Mahs
            // 
            Mahs.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Mahs.HeaderText = "Mã học sinh";
            Mahs.MinimumWidth = 6;
            Mahs.Name = "Mahs";
            Mahs.Width = 108;
            // 
            // Tenhs
            // 
            Tenhs.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tenhs.HeaderText = "Tên học sinh";
            Tenhs.MinimumWidth = 6;
            Tenhs.Name = "Tenhs";
            Tenhs.Width = 110;
            // 
            // MaMonHoc
            // 
            MaMonHoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaMonHoc.HeaderText = "Mã môn học";
            MaMonHoc.MinimumWidth = 6;
            MaMonHoc.Name = "MaMonHoc";
            MaMonHoc.Width = 111;
            // 
            // DiemGK1
            // 
            DiemGK1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiemGK1.HeaderText = "Điểm giữa kì I";
            DiemGK1.MinimumWidth = 6;
            DiemGK1.Name = "DiemGK1";
            DiemGK1.Width = 103;
            // 
            // DiemCK1
            // 
            DiemCK1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiemCK1.HeaderText = "Điểm cuối kì I";
            DiemCK1.MinimumWidth = 6;
            DiemCK1.Name = "DiemCK1";
            DiemCK1.Width = 101;
            // 
            // DiemTBHK1
            // 
            DiemTBHK1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiemTBHK1.HeaderText = "Điểm trung bình HKI";
            DiemTBHK1.MinimumWidth = 6;
            DiemTBHK1.Name = "DiemTBHK1";
            DiemTBHK1.Width = 137;
            // 
            // DiemGK2
            // 
            DiemGK2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiemGK2.HeaderText = "Điểm giữa kì II";
            DiemGK2.MinimumWidth = 6;
            DiemGK2.Name = "DiemGK2";
            DiemGK2.Width = 103;
            // 
            // DiemCK2
            // 
            DiemCK2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiemCK2.HeaderText = "Điểm cuối kì II";
            DiemCK2.MinimumWidth = 6;
            DiemCK2.Name = "DiemCK2";
            DiemCK2.Width = 101;
            // 
            // DiemTBHK2
            // 
            DiemTBHK2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiemTBHK2.HeaderText = "Điểm trung bình HKII";
            DiemTBHK2.MinimumWidth = 6;
            DiemTBHK2.Name = "DiemTBHK2";
            DiemTBHK2.Width = 137;
            // 
            // TongKet
            // 
            TongKet.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TongKet.HeaderText = "Tổng kết";
            TongKet.MinimumWidth = 6;
            TongKet.Name = "TongKet";
            TongKet.Width = 89;
            // 
            // Loai
            // 
            Loai.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Loai.HeaderText = "Loại";
            Loai.MinimumWidth = 6;
            Loai.Name = "Loai";
            Loai.Width = 66;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Width = 63;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Width = 64;
            // 
            // fDiem
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(860, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btFind);
            Controls.Add(txtfind);
            Controls.Add(label2);
            Controls.Add(btNew);
            Controls.Add(label1);
            Name = "fDiem";
            Text = "Quản Lý Điểm Học Sinh";
            Load += fDiem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btNew;
        private Label label2;
        private TextBox txtfind;
        private Button btFind;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaBangDiem;
        private DataGridViewTextBoxColumn Mahs;
        private DataGridViewTextBoxColumn Tenhs;
        private DataGridViewTextBoxColumn MaMonHoc;
        private DataGridViewTextBoxColumn DiemGK1;
        private DataGridViewTextBoxColumn DiemCK1;
        private DataGridViewTextBoxColumn DiemTBHK1;
        private DataGridViewTextBoxColumn DiemGK2;
        private DataGridViewTextBoxColumn DiemCK2;
        private DataGridViewTextBoxColumn DiemTBHK2;
        private DataGridViewTextBoxColumn TongKet;
        private DataGridViewTextBoxColumn Loai;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}