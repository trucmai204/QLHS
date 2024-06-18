namespace QLHS_2._0.Subject
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
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label6.Location = new Point(235, 31);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(279, 48);
            label6.TabIndex = 92;
            label6.Text = "SỬA MÔN HỌC";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.None;
            btClose.BackColor = Color.FromArgb(255, 192, 192);
            btClose.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btClose.Location = new Point(383, 203);
            btClose.Margin = new Padding(2);
            btClose.Name = "btClose";
            btClose.Size = new Size(126, 46);
            btClose.TabIndex = 91;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Anchor = AnchorStyles.None;
            btSave.BackColor = Color.FromArgb(192, 255, 192);
            btSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btSave.Location = new Point(239, 203);
            btSave.Margin = new Padding(2);
            btSave.Name = "btSave";
            btSave.Size = new Size(126, 46);
            btSave.TabIndex = 90;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // numericUpDownSe
            // 
            numericUpDownSe.Anchor = AnchorStyles.Right;
            numericUpDownSe.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownSe.Location = new Point(556, 101);
            numericUpDownSe.Margin = new Padding(1);
            numericUpDownSe.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownSe.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownSe.Name = "numericUpDownSe";
            numericUpDownSe.Size = new Size(110, 31);
            numericUpDownSe.TabIndex = 89;
            numericUpDownSe.TextAlign = HorizontalAlignment.Center;
            numericUpDownSe.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(473, 101);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 88;
            label4.Text = "Học kỳ:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDownFinal
            // 
            numericUpDownFinal.Anchor = AnchorStyles.Right;
            numericUpDownFinal.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownFinal.Location = new Point(556, 145);
            numericUpDownFinal.Margin = new Padding(1);
            numericUpDownFinal.Name = "numericUpDownFinal";
            numericUpDownFinal.Size = new Size(110, 31);
            numericUpDownFinal.TabIndex = 87;
            numericUpDownFinal.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDownMid
            // 
            numericUpDownMid.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownMid.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownMid.Location = new Point(244, 145);
            numericUpDownMid.Margin = new Padding(1);
            numericUpDownMid.Name = "numericUpDownMid";
            numericUpDownMid.Size = new Size(115, 31);
            numericUpDownMid.TabIndex = 86;
            numericUpDownMid.TextAlign = HorizontalAlignment.Center;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(244, 95);
            txtName.Margin = new Padding(1);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(206, 31);
            txtName.TabIndex = 85;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(395, 148);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 84;
            label3.Text = "Điểm cuối kỳ (%):";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(82, 148);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 83;
            label2.Text = "Điểm giữa kỳ (%):";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(115, 101);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 82;
            label1.Text = "Tên môn học:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UpdateSubject_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 275);
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
            Name = "UpdateSubject_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa môn học";
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