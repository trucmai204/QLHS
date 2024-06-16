namespace QLHS.Subject
{
    partial class UpdateSubject_Form
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
            label6 = new Label();
            btClose = new Button();
            btSave = new Button();
            numericUpDownSe = new NumericUpDown();
            label4 = new Label();
            numericUpDownFinal = new NumericUpDown();
            numericUpDownMid = new NumericUpDown();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMid).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.Location = new Point(103, 11);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(220, 28);
            label6.TabIndex = 59;
            label6.Text = "THÊM MÔN HỌC MỚI";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.None;
            btClose.BackColor = Color.FromArgb(255, 192, 192);
            btClose.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btClose.Location = new Point(225, 108);
            btClose.Margin = new Padding(2);
            btClose.Name = "btClose";
            btClose.Size = new Size(77, 26);
            btClose.TabIndex = 58;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Anchor = AnchorStyles.None;
            btSave.BackColor = Color.FromArgb(192, 255, 192);
            btSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btSave.Location = new Point(134, 108);
            btSave.Margin = new Padding(2);
            btSave.Name = "btSave";
            btSave.Size = new Size(77, 26);
            btSave.TabIndex = 57;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // numericUpDownSe
            // 
            numericUpDownSe.Anchor = AnchorStyles.Right;
            numericUpDownSe.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownSe.Location = new Point(342, 48);
            numericUpDownSe.Margin = new Padding(1);
            numericUpDownSe.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownSe.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownSe.Name = "numericUpDownSe";
            numericUpDownSe.Size = new Size(48, 23);
            numericUpDownSe.TabIndex = 56;
            numericUpDownSe.TextAlign = HorizontalAlignment.Center;
            numericUpDownSe.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(276, 49);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 55;
            label4.Text = "Học kỳ:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDownFinal
            // 
            numericUpDownFinal.Anchor = AnchorStyles.Right;
            numericUpDownFinal.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownFinal.Location = new Point(342, 72);
            numericUpDownFinal.Margin = new Padding(1);
            numericUpDownFinal.Name = "numericUpDownFinal";
            numericUpDownFinal.Size = new Size(48, 23);
            numericUpDownFinal.TabIndex = 54;
            numericUpDownFinal.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDownMid
            // 
            numericUpDownMid.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownMid.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownMid.Location = new Point(155, 72);
            numericUpDownMid.Margin = new Padding(1);
            numericUpDownMid.Name = "numericUpDownMid";
            numericUpDownMid.Size = new Size(57, 23);
            numericUpDownMid.TabIndex = 53;
            numericUpDownMid.TextAlign = HorizontalAlignment.Center;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(136, 48);
            txtName.Margin = new Padding(1);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(129, 23);
            txtName.TabIndex = 52;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(234, 74);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 51;
            label3.Text = "Điểm cuối kỳ (%):";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(47, 74);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 50;
            label2.Text = "Điểm giữa kỳ (%):";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(48, 49);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 49;
            label1.Text = "Tên môn học:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UpdateSubject_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 145);
            Controls.Add(label6);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(numericUpDownSe);
            Controls.Add(label4);
            Controls.Add(numericUpDownFinal);
            Controls.Add(numericUpDownMid);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(1);
            Name = "UpdateSubject_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa đổi môn học";
            Load += UpdateSubject_Form_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownSe).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFinal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button btClose;
        private Button btSave;
        private NumericUpDown numericUpDownSe;
        private Label label4;
        private NumericUpDown numericUpDownFinal;
        private NumericUpDown numericUpDownMid;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}