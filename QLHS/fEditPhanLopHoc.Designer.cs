namespace QLHS
{
    partial class fEditPhanLopHoc
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
            btClose = new Button();
            btSave = new Button();
            txtNienKhoa = new TextBox();
            txtTenlop = new TextBox();
            txtMalop = new TextBox();
            txtMahs = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btClose
            // 
            btClose.Location = new Point(444, 232);
            btClose.Name = "btClose";
            btClose.Size = new Size(75, 23);
            btClose.TabIndex = 18;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            btSave.Location = new Point(444, 173);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 17;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            // 
            // txtNienKhoa
            // 
            txtNienKhoa.Location = new Point(158, 173);
            txtNienKhoa.Name = "txtNienKhoa";
            txtNienKhoa.Size = new Size(131, 23);
            txtNienKhoa.TabIndex = 15;
            // 
            // txtTenlop
            // 
            txtTenlop.Location = new Point(408, 118);
            txtTenlop.Name = "txtTenlop";
            txtTenlop.Size = new Size(158, 23);
            txtTenlop.TabIndex = 13;
            // 
            // txtMalop
            // 
            txtMalop.Location = new Point(158, 116);
            txtMalop.Name = "txtMalop";
            txtMalop.Size = new Size(131, 23);
            txtMalop.TabIndex = 11;
            // 
            // txtMahs
            // 
            txtMahs.Location = new Point(408, 58);
            txtMahs.Name = "txtMahs";
            txtMahs.Size = new Size(158, 23);
            txtMahs.TabIndex = 9;
            // 
            // txtId
            // 
            txtId.Location = new Point(158, 56);
            txtId.Name = "txtId";
            txtId.Size = new Size(131, 23);
            txtId.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 173);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 16;
            label5.Text = "Niên khóa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 116);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 14;
            label4.Text = "Tên lớp: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 116);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 12;
            label3.Text = "Mã lớp: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 59);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 10;
            label2.Text = "Mã học sinh:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 59);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 8;
            label1.Text = "ID Phân lớp:";
            // 
            // fEditPhanLopHoc
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
            Name = "fEditPhanLopHoc";
            Text = "Sửa phân lớp học";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btClose;
        private Button btSave;
        private TextBox txtNienKhoa;
        private TextBox txtTenlop;
        private TextBox txtMalop;
        private TextBox txtMahs;
        private TextBox txtId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ToolTip toolTip1;
    }
}