namespace QLHS
{
    partial class fNewPhanLopHoc
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            txtMahs = new TextBox();
            txtMalop = new TextBox();
            txtTenlop = new TextBox();
            txtNienKhoa = new TextBox();
            btSave = new Button();
            btClose = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 38);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Phân lớp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 38);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã học sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 95);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Mã lớp: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(314, 95);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Tên lớp: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 152);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 4;
            label5.Text = "Niên khóa:";
            // 
            // txtId
            // 
            txtId.Location = new Point(139, 35);
            txtId.Name = "txtId";
            txtId.Size = new Size(131, 23);
            txtId.TabIndex = 0;
            // 
            // txtMahs
            // 
            txtMahs.Location = new Point(389, 37);
            txtMahs.Name = "txtMahs";
            txtMahs.Size = new Size(158, 23);
            txtMahs.TabIndex = 1;
            // 
            // txtMalop
            // 
            txtMalop.Location = new Point(139, 95);
            txtMalop.Name = "txtMalop";
            txtMalop.Size = new Size(131, 23);
            txtMalop.TabIndex = 2;
            // 
            // txtTenlop
            // 
            txtTenlop.Location = new Point(389, 97);
            txtTenlop.Name = "txtTenlop";
            txtTenlop.Size = new Size(158, 23);
            txtTenlop.TabIndex = 3;
            // 
            // txtNienKhoa
            // 
            txtNienKhoa.Location = new Point(139, 152);
            txtNienKhoa.Name = "txtNienKhoa";
            txtNienKhoa.Size = new Size(131, 23);
            txtNienKhoa.TabIndex = 4;
            // 
            // btSave
            // 
            btSave.Location = new Point(425, 152);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 5;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            btClose.Location = new Point(425, 211);
            btClose.Name = "btClose";
            btClose.Size = new Size(75, 23);
            btClose.TabIndex = 6;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            // 
            // fNewPhanLopHoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(txtNienKhoa);
            Controls.Add(txtTenlop);
            Controls.Add(txtMalop);
            Controls.Add(txtMahs);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fNewPhanLopHoc";
            Text = "Mới phân lớp học ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtMahs;
        private TextBox txtMalop;
        private TextBox txtTenlop;
        private TextBox txtNienKhoa;
        private Button btSave;
        private Button btClose;
        private ToolTip toolTip1;
    }
}