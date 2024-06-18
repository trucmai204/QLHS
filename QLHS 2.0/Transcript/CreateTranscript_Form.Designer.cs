namespace QLHS_2._0.Transcript
{
    partial class CreateTranscript_Form
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
            label14 = new Label();
            txtLoai = new TextBox();
            txtDiemTBHK2 = new TextBox();
            txtDiemTBHK1 = new TextBox();
            txtDiemCK2 = new TextBox();
            txtDiemCK1 = new TextBox();
            txtTongKet = new TextBox();
            txtDiemGK2 = new TextBox();
            txtDiemGK1 = new TextBox();
            btClose = new Button();
            btSave = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtTenhs = new ComboBox();
            txtTenMonHoc = new ComboBox();
            SuspendLayout();
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(0, 0, 192);
            label14.Location = new Point(257, 23);
            label14.Margin = new Padding(1, 0, 1, 0);
            label14.Name = "label14";
            label14.Size = new Size(351, 55);
            label14.TabIndex = 94;
            label14.Text = "NHẬP ĐIỂM MỚI";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLoai
            // 
            txtLoai.Anchor = AnchorStyles.None;
            txtLoai.ForeColor = Color.Red;
            txtLoai.Location = new Point(436, 222);
            txtLoai.Margin = new Padding(2);
            txtLoai.Name = "txtLoai";
            txtLoai.ReadOnly = true;
            txtLoai.Size = new Size(275, 31);
            txtLoai.TabIndex = 90;
            // 
            // txtDiemTBHK2
            // 
            txtDiemTBHK2.Anchor = AnchorStyles.None;
            txtDiemTBHK2.ForeColor = Color.FromArgb(192, 0, 0);
            txtDiemTBHK2.Location = new Point(723, 180);
            txtDiemTBHK2.Margin = new Padding(2);
            txtDiemTBHK2.Name = "txtDiemTBHK2";
            txtDiemTBHK2.ReadOnly = true;
            txtDiemTBHK2.Size = new Size(78, 31);
            txtDiemTBHK2.TabIndex = 87;
            // 
            // txtDiemTBHK1
            // 
            txtDiemTBHK1.Anchor = AnchorStyles.None;
            txtDiemTBHK1.ForeColor = Color.FromArgb(192, 0, 0);
            txtDiemTBHK1.Location = new Point(723, 139);
            txtDiemTBHK1.Margin = new Padding(2);
            txtDiemTBHK1.Name = "txtDiemTBHK1";
            txtDiemTBHK1.ReadOnly = true;
            txtDiemTBHK1.Size = new Size(78, 31);
            txtDiemTBHK1.TabIndex = 80;
            // 
            // txtDiemCK2
            // 
            txtDiemCK2.Anchor = AnchorStyles.None;
            txtDiemCK2.Location = new Point(436, 180);
            txtDiemCK2.Margin = new Padding(2);
            txtDiemCK2.Name = "txtDiemCK2";
            txtDiemCK2.Size = new Size(78, 31);
            txtDiemCK2.TabIndex = 85;
            // 
            // txtDiemCK1
            // 
            txtDiemCK1.Anchor = AnchorStyles.None;
            txtDiemCK1.Location = new Point(436, 139);
            txtDiemCK1.Margin = new Padding(2);
            txtDiemCK1.Name = "txtDiemCK1";
            txtDiemCK1.Size = new Size(78, 31);
            txtDiemCK1.TabIndex = 78;
            // 
            // txtTongKet
            // 
            txtTongKet.Anchor = AnchorStyles.None;
            txtTongKet.ForeColor = Color.Red;
            txtTongKet.Location = new Point(207, 222);
            txtTongKet.Margin = new Padding(2);
            txtTongKet.Name = "txtTongKet";
            txtTongKet.ReadOnly = true;
            txtTongKet.Size = new Size(78, 31);
            txtTongKet.TabIndex = 88;
            // 
            // txtDiemGK2
            // 
            txtDiemGK2.Anchor = AnchorStyles.None;
            txtDiemGK2.Location = new Point(207, 180);
            txtDiemGK2.Margin = new Padding(2);
            txtDiemGK2.Name = "txtDiemGK2";
            txtDiemGK2.Size = new Size(78, 31);
            txtDiemGK2.TabIndex = 83;
            // 
            // txtDiemGK1
            // 
            txtDiemGK1.Anchor = AnchorStyles.None;
            txtDiemGK1.Location = new Point(207, 139);
            txtDiemGK1.Margin = new Padding(2);
            txtDiemGK1.Name = "txtDiemGK1";
            txtDiemGK1.Size = new Size(78, 31);
            txtDiemGK1.TabIndex = 76;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.None;
            btClose.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.Location = new Point(446, 281);
            btClose.Margin = new Padding(2);
            btClose.Name = "btClose";
            btClose.Size = new Size(144, 59);
            btClose.TabIndex = 93;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Anchor = AnchorStyles.None;
            btSave.BackColor = SystemColors.ActiveCaption;
            btSave.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSave.Location = new Point(274, 281);
            btSave.Margin = new Padding(2);
            btSave.Name = "btSave";
            btSave.Size = new Size(144, 59);
            btSave.TabIndex = 92;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Location = new Point(349, 225);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(76, 25);
            label12.TabIndex = 91;
            label12.Text = "Xếp loại";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(108, 225);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(82, 25);
            label11.TabIndex = 89;
            label11.Text = "Tổng kết";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(531, 183);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(180, 25);
            label10.TabIndex = 86;
            label10.Text = "Điểm trung bình HKII";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(300, 183);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(125, 25);
            label9.TabIndex = 84;
            label9.Text = "Điểm cuối kì II";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(63, 183);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(127, 25);
            label8.TabIndex = 82;
            label8.Text = "Điểm giữa kì II";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(536, 142);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(175, 25);
            label7.TabIndex = 81;
            label7.Text = "Điểm trung bình HKI";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(300, 142);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 79;
            label6.Text = "Điểm cuối kì I";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(68, 142);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 77;
            label5.Text = "Điểm giữa kì I";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(446, 102);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 75;
            label4.Text = "Tên môn học";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(81, 102);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 73;
            label3.Text = "Tên học sinh";
            // 
            // txtTenhs
            // 
            txtTenhs.Anchor = AnchorStyles.None;
            txtTenhs.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTenhs.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTenhs.Font = new Font("Segoe UI", 8F);
            txtTenhs.FormattingEnabled = true;
            txtTenhs.Location = new Point(207, 99);
            txtTenhs.Name = "txtTenhs";
            txtTenhs.Size = new Size(211, 29);
            txtTenhs.TabIndex = 95;
            // 
            // txtTenMonHoc
            // 
            txtTenMonHoc.Anchor = AnchorStyles.None;
            txtTenMonHoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTenMonHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTenMonHoc.Font = new Font("Segoe UI", 8F);
            txtTenMonHoc.FormattingEnabled = true;
            txtTenMonHoc.Location = new Point(565, 99);
            txtTenMonHoc.Name = "txtTenMonHoc";
            txtTenMonHoc.Size = new Size(236, 29);
            txtTenMonHoc.TabIndex = 96;
            // 
            // CreateTranscript_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 363);
            Controls.Add(txtTenMonHoc);
            Controls.Add(txtTenhs);
            Controls.Add(label14);
            Controls.Add(txtLoai);
            Controls.Add(txtDiemTBHK2);
            Controls.Add(txtDiemTBHK1);
            Controls.Add(txtDiemCK2);
            Controls.Add(txtDiemCK1);
            Controls.Add(txtTongKet);
            Controls.Add(txtDiemGK2);
            Controls.Add(txtDiemGK1);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            DoubleBuffered = true;
            Name = "CreateTranscript_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nhập điểm mới";
            Load += CreateTranscript_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label14;
        private TextBox txtLoai;
        private TextBox txtDiemTBHK2;
        private TextBox txtDiemTBHK1;
        private TextBox txtDiemCK2;
        private TextBox txtDiemCK1;
        private TextBox txtTongKet;
        private TextBox txtDiemGK2;
        private TextBox txtDiemGK1;
        private Button btClose;
        private Button btSave;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox txtTenhs;
        private ComboBox txtTenMonHoc;
    }
}