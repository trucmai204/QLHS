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
            semesterNumericUpDown = new NumericUpDown();
            label4 = new Label();
            finalWeightNumericUpDown = new NumericUpDown();
            midtermWeightNumericUpDown = new NumericUpDown();
            txtSubjectName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)semesterNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)finalWeightNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)midtermWeightNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.Location = new Point(243, 24);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(331, 41);
            label6.TabIndex = 59;
            label6.Text = "THÊM MÔN HỌC MỚI";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.None;
            btClose.BackColor = Color.FromArgb(255, 192, 192);
            btClose.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btClose.Location = new Point(418, 231);
            btClose.Margin = new Padding(4, 5, 4, 5);
            btClose.Name = "btClose";
            btClose.Size = new Size(143, 55);
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
            btSave.Location = new Point(249, 231);
            btSave.Margin = new Padding(4, 5, 4, 5);
            btSave.Name = "btSave";
            btSave.Size = new Size(143, 55);
            btSave.TabIndex = 57;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // semesterNumericUpDown
            // 
            semesterNumericUpDown.Anchor = AnchorStyles.Right;
            semesterNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            semesterNumericUpDown.Location = new Point(593, 102);
            semesterNumericUpDown.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            semesterNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            semesterNumericUpDown.Name = "semesterNumericUpDown";
            semesterNumericUpDown.Size = new Size(89, 31);
            semesterNumericUpDown.TabIndex = 56;
            semesterNumericUpDown.TextAlign = HorizontalAlignment.Center;
            semesterNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(512, 105);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 55;
            label4.Text = "Học kỳ:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // finalWeightNumericUpDown
            // 
            finalWeightNumericUpDown.Anchor = AnchorStyles.Right;
            finalWeightNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            finalWeightNumericUpDown.Location = new Point(593, 154);
            finalWeightNumericUpDown.Name = "finalWeightNumericUpDown";
            finalWeightNumericUpDown.Size = new Size(89, 31);
            finalWeightNumericUpDown.TabIndex = 54;
            finalWeightNumericUpDown.TextAlign = HorizontalAlignment.Center;
            // 
            // midtermWeightNumericUpDown
            // 
            midtermWeightNumericUpDown.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            midtermWeightNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            midtermWeightNumericUpDown.Location = new Point(289, 154);
            midtermWeightNumericUpDown.Name = "midtermWeightNumericUpDown";
            midtermWeightNumericUpDown.Size = new Size(107, 31);
            midtermWeightNumericUpDown.TabIndex = 53;
            midtermWeightNumericUpDown.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSubjectName
            // 
            txtSubjectName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSubjectName.Location = new Point(254, 102);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(236, 31);
            txtSubjectName.TabIndex = 52;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(434, 157);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 51;
            label3.Text = "Điểm cuối kỳ (%):";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(128, 157);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 50;
            label2.Text = "Điểm giữa kỳ (%):";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(130, 105);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 49;
            label1.Text = "Tên môn học:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CreateSubject_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 310);
            Controls.Add(label6);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(semesterNumericUpDown);
            Controls.Add(label4);
            Controls.Add(finalWeightNumericUpDown);
            Controls.Add(midtermWeightNumericUpDown);
            Controls.Add(txtSubjectName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateSubject_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm môn học";
            ((System.ComponentModel.ISupportInitialize)semesterNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)finalWeightNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)midtermWeightNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button btClose;
        private Button btSave;
        private NumericUpDown semesterNumericUpDown;
        private Label label4;
        private NumericUpDown finalWeightNumericUpDown;
        private NumericUpDown midtermWeightNumericUpDown;
        private TextBox txtSubjectName;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}