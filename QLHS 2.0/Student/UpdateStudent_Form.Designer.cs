namespace QLHS_2._0.Student
{
    partial class UpdateStudent_Form
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
            comboBoxClassName = new ComboBox();
            label6 = new Label();
            label2 = new Label();
            birthdateTimePicker = new DateTimePicker();
            genderCheckBox = new CheckBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btClose = new Button();
            btSave = new Button();
            SuspendLayout();
            // 
            // comboBoxClassName
            // 
            comboBoxClassName.AutoCompleteCustomSource.AddRange(new string[] { "1", "", "2", "", "3", "", "4", "", "5", "", "6", "", "7", "", "8", "", "9", "", "10", "", "11", "", "12", "", "13", "", "14", "", "15", "", "16", "", "17", "", "18", "", "19", "", "20", "", "21", "", "22", "", "23", "", "24", "", "25", "", "26", "", "27", "", "28", "", "29", "", "30", "", "31", "", "32", "", "33", "", "34", "", "35", "", "36", "", "37", "", "38", "", "39", "", "40", "", "41", "", "42", "", "43", "", "44", "", "45", "", "46", "", "47", "", "48", "", "49", "", "50", "", "51", "", "52", "", "53", "", "54", "", "55", "", "56", "", "57", "", "58", "", "59", "", "60", "", "61", "", "62", "", "63", "", "64", "", "65", "", "66", "", "67", "", "68", "", "69", "", "70", "", "71", "", "72", "", "73", "", "74", "", "75" });
            comboBoxClassName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClassName.FormattingEnabled = true;
            comboBoxClassName.Location = new Point(184, 153);
            comboBoxClassName.Name = "comboBoxClassId";
            comboBoxClassName.Size = new Size(139, 33);
            comboBoxClassName.TabIndex = 76;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label6.Location = new Point(169, 31);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(385, 48);
            label6.TabIndex = 75;
            label6.Text = "CẬP NHẬT HỌC SINH";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(357, 156);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 74;
            label2.Text = "Ngày sinh:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // birthdateTimePicker
            // 
            birthdateTimePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            birthdateTimePicker.CustomFormat = "dd/MM/yyyy";
            birthdateTimePicker.DropDownAlign = LeftRightAlignment.Right;
            birthdateTimePicker.Format = DateTimePickerFormat.Custom;
            birthdateTimePicker.Location = new Point(469, 153);
            birthdateTimePicker.Margin = new Padding(1);
            birthdateTimePicker.Name = "birthdateTimePicker";
            birthdateTimePicker.Size = new Size(167, 31);
            birthdateTimePicker.TabIndex = 73;
            // 
            // genderCheckBox
            // 
            genderCheckBox.Anchor = AnchorStyles.Right;
            genderCheckBox.AutoSize = true;
            genderCheckBox.Location = new Point(492, 108);
            genderCheckBox.Margin = new Padding(1);
            genderCheckBox.Name = "genderCheckBox";
            genderCheckBox.Size = new Size(144, 29);
            genderCheckBox.TabIndex = 72;
            genderCheckBox.Text = "Giới tính nam";
            genderCheckBox.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(184, 107);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(268, 31);
            txtName.TabIndex = 69;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(133, 156);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 25);
            label5.TabIndex = 71;
            label5.Text = "Lớp:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(87, 110);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 70;
            label4.Text = "Họ và tên:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.None;
            btClose.BackColor = Color.FromArgb(255, 192, 192);
            btClose.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btClose.Location = new Point(367, 210);
            btClose.Margin = new Padding(2);
            btClose.Name = "btClose";
            btClose.Size = new Size(115, 44);
            btClose.TabIndex = 68;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Anchor = AnchorStyles.None;
            btSave.BackColor = Color.FromArgb(192, 255, 192);
            btSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btSave.Location = new Point(241, 210);
            btSave.Margin = new Padding(2);
            btSave.Name = "btSave";
            btSave.Size = new Size(115, 44);
            btSave.TabIndex = 67;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // UpdateStudent_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 285);
            Controls.Add(comboBoxClassName);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(birthdateTimePicker);
            Controls.Add(genderCheckBox);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btClose);
            Controls.Add(btSave);
            DoubleBuffered = true;
            Name = "UpdateStudent_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cập nhật học sinh";
            Load += UpdateStudent_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxClassName;
        private Label label6;
        private Label label2;
        private DateTimePicker birthdateTimePicker;
        private CheckBox genderCheckBox;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Button btClose;
        private Button btSave;
    }
}