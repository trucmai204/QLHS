namespace QLHS_2._0.Transcript
{
    partial class UpdateTranscript_Form
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
            txtTenMonHoc = new ComboBox();
            txtTenhs = new ComboBox();
            label14 = new Label();
            btClose = new Button();
            btSave = new Button();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtDiemCK2 = new NumericUpDown();
            txtDiemCK1 = new NumericUpDown();
            txtDiemGK2 = new NumericUpDown();
            txtDiemGK1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtDiemCK2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDiemCK1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDiemGK2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDiemGK1).BeginInit();
            SuspendLayout();
            // 
            // txtTenMonHoc
            // 
            txtTenMonHoc.Anchor = AnchorStyles.None;
            txtTenMonHoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTenMonHoc.DropDownStyle = ComboBoxStyle.Simple;
            txtTenMonHoc.Enabled = false;
            txtTenMonHoc.Font = new Font("Segoe UI", 8F);
            txtTenMonHoc.FormattingEnabled = true;
            txtTenMonHoc.Location = new Point(592, 114);
            txtTenMonHoc.Name = "txtTenMonHoc";
            txtTenMonHoc.Size = new Size(183, 29);
            txtTenMonHoc.TabIndex = 119;
            // 
            // txtTenhs
            // 
            txtTenhs.Anchor = AnchorStyles.None;
            txtTenhs.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTenhs.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTenhs.DropDownStyle = ComboBoxStyle.Simple;
            txtTenhs.Enabled = false;
            txtTenhs.Font = new Font("Segoe UI", 8F);
            txtTenhs.FormattingEnabled = true;
            txtTenhs.Location = new Point(234, 114);
            txtTenhs.Name = "txtTenhs";
            txtTenhs.Size = new Size(180, 29);
            txtTenhs.TabIndex = 118;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(0, 0, 192);
            label14.Location = new Point(227, 37);
            label14.Margin = new Padding(1, 0, 1, 0);
            label14.Name = "label14";
            label14.Size = new Size(411, 55);
            label14.TabIndex = 117;
            label14.Text = "CẬP NHẬT ĐIỂM SỐ";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.None;
            btClose.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.Location = new Point(446, 248);
            btClose.Margin = new Padding(2);
            btClose.Name = "btClose";
            btClose.Size = new Size(144, 59);
            btClose.TabIndex = 116;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Anchor = AnchorStyles.None;
            btSave.BackColor = SystemColors.ActiveCaption;
            btSave.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSave.Location = new Point(274, 248);
            btSave.Margin = new Padding(2);
            btSave.Name = "btSave";
            btSave.Size = new Size(144, 59);
            btSave.TabIndex = 115;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(462, 198);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(125, 25);
            label9.TabIndex = 107;
            label9.Text = "Điểm cuối kì II";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(90, 198);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(127, 25);
            label8.TabIndex = 105;
            label8.Text = "Điểm giữa kì II";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(467, 157);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 102;
            label6.Text = "Điểm cuối kì I";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(95, 157);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 100;
            label5.Text = "Điểm giữa kì I";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(473, 117);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 98;
            label4.Text = "Tên môn học";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(108, 117);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 97;
            label3.Text = "Tên học sinh";
            // 
            // txtDiemCK2
            // 
            txtDiemCK2.Anchor = AnchorStyles.None;
            txtDiemCK2.DecimalPlaces = 2;
            txtDiemCK2.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            txtDiemCK2.Location = new Point(595, 199);
            txtDiemCK2.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            txtDiemCK2.Name = "txtDiemCK2";
            txtDiemCK2.Size = new Size(180, 31);
            txtDiemCK2.TabIndex = 123;
            txtDiemCK2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDiemCK1
            // 
            txtDiemCK1.Anchor = AnchorStyles.None;
            txtDiemCK1.DecimalPlaces = 2;
            txtDiemCK1.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            txtDiemCK1.Location = new Point(595, 157);
            txtDiemCK1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            txtDiemCK1.Name = "txtDiemCK1";
            txtDiemCK1.Size = new Size(180, 31);
            txtDiemCK1.TabIndex = 122;
            txtDiemCK1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDiemGK2
            // 
            txtDiemGK2.Anchor = AnchorStyles.None;
            txtDiemGK2.DecimalPlaces = 2;
            txtDiemGK2.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            txtDiemGK2.Location = new Point(234, 198);
            txtDiemGK2.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            txtDiemGK2.Name = "txtDiemGK2";
            txtDiemGK2.Size = new Size(180, 31);
            txtDiemGK2.TabIndex = 121;
            txtDiemGK2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDiemGK1
            // 
            txtDiemGK1.Anchor = AnchorStyles.None;
            txtDiemGK1.DecimalPlaces = 2;
            txtDiemGK1.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            txtDiemGK1.Location = new Point(234, 157);
            txtDiemGK1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            txtDiemGK1.Name = "txtDiemGK1";
            txtDiemGK1.Size = new Size(180, 31);
            txtDiemGK1.TabIndex = 120;
            txtDiemGK1.TextAlign = HorizontalAlignment.Center;
            // 
            // UpdateTranscript_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 344);
            Controls.Add(txtDiemCK2);
            Controls.Add(txtDiemCK1);
            Controls.Add(txtDiemGK2);
            Controls.Add(txtDiemGK1);
            Controls.Add(txtTenMonHoc);
            Controls.Add(txtTenhs);
            Controls.Add(label14);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "UpdateTranscript_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cập nhật điểm số";
            Load += UpdateTranscript_Form_Load;
            ((System.ComponentModel.ISupportInitialize)txtDiemCK2).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDiemCK1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDiemGK2).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDiemGK1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txtTenMonHoc;
        private ComboBox txtTenhs;
        private Label label14;
        private Button btClose;
        private Button btSave;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private NumericUpDown txtDiemCK2;
        private NumericUpDown txtDiemCK1;
        private NumericUpDown txtDiemGK2;
        private NumericUpDown txtDiemGK1;
    }
}