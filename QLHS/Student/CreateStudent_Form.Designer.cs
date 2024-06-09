namespace QLHS.Student
{
    partial class CreateStudent_Form
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
            label2 = new Label();
            birthdateTimePicker = new DateTimePicker();
            genderCheckBox = new CheckBox();
            txtClassId = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btClose = new Button();
            btSave = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.Location = new Point(294, 14);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(329, 41);
            label6.TabIndex = 45;
            label6.Text = "THÊM HỌC SINH MỚI";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(405, 136);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 44;
            label2.Text = "Ngày sinh:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // birthdateTimePicker
            // 
            birthdateTimePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            birthdateTimePicker.DropDownAlign = LeftRightAlignment.Right;
            birthdateTimePicker.Format = DateTimePickerFormat.Short;
            birthdateTimePicker.Location = new Point(518, 131);
            birthdateTimePicker.Name = "birthdateTimePicker";
            birthdateTimePicker.Size = new Size(325, 31);
            birthdateTimePicker.TabIndex = 43;
            // 
            // genderCheckBox
            // 
            genderCheckBox.Anchor = AnchorStyles.Right;
            genderCheckBox.AutoSize = true;
            genderCheckBox.Location = new Point(709, 84);
            genderCheckBox.Name = "genderCheckBox";
            genderCheckBox.Size = new Size(144, 29);
            genderCheckBox.TabIndex = 42;
            genderCheckBox.Text = "Giới tính nam";
            genderCheckBox.UseVisualStyleBackColor = true;
            // 
            // txtClassId
            // 
            txtClassId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtClassId.Location = new Point(174, 131);
            txtClassId.Margin = new Padding(4, 5, 4, 5);
            txtClassId.Name = "txtClassId";
            txtClassId.Size = new Size(221, 31);
            txtClassId.TabIndex = 40;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(174, 84);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(517, 31);
            txtName.TabIndex = 38;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(84, 134);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 41;
            label5.Text = "Mã lớp:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(63, 87);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 39;
            label4.Text = "Họ và tên:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.None;
            btClose.BackColor = Color.FromArgb(255, 192, 192);
            btClose.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btClose.Location = new Point(471, 185);
            btClose.Margin = new Padding(4, 5, 4, 5);
            btClose.Name = "btClose";
            btClose.Size = new Size(143, 55);
            btClose.TabIndex = 37;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Anchor = AnchorStyles.None;
            btSave.BackColor = Color.FromArgb(192, 255, 192);
            btSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btSave.Location = new Point(302, 185);
            btSave.Margin = new Padding(4, 5, 4, 5);
            btSave.Name = "btSave";
            btSave.Size = new Size(143, 55);
            btSave.TabIndex = 36;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // CreateStudent_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 262);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(birthdateTimePicker);
            Controls.Add(genderCheckBox);
            Controls.Add(txtClassId);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Name = "CreateStudent_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm học sinh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label2;
        private DateTimePicker birthdateTimePicker;
        private CheckBox genderCheckBox;
        private TextBox txtClassId;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Button btClose;
        private Button btSave;
    }
}