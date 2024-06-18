namespace QLHS_2._0
{
    partial class MainWindow
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
            menuStrip1 = new MenuStrip();
            họcSinhToolStripMenuItem = new ToolStripMenuItem();
            quảnLýHọcSinhToolStripMenuItem = new ToolStripMenuItem();
            addStudentSubMenuItem = new ToolStripMenuItem();
            lớpHọcToolStripMenuItem = new ToolStripMenuItem();
            quảnLýLớpHọcToolStripMenuItem = new ToolStripMenuItem();
            addClassSubMenuItem = new ToolStripMenuItem();
            mônHọcToolStripMenuItem = new ToolStripMenuItem();
            quảnLýMônHọcToolStripMenuItem = new ToolStripMenuItem();
            điểmToolStripMenuItem = new ToolStripMenuItem();
            quảnLýĐiểmToolStripMenuItem = new ToolStripMenuItem();
            addTranscriptSubMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(128, 128, 255);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { họcSinhToolStripMenuItem, lớpHọcToolStripMenuItem, mônHọcToolStripMenuItem, điểmToolStripMenuItem, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1985, 49);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // họcSinhToolStripMenuItem
            // 
            họcSinhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýHọcSinhToolStripMenuItem, addStudentSubMenuItem });
            họcSinhToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            họcSinhToolStripMenuItem.Name = "họcSinhToolStripMenuItem";
            họcSinhToolStripMenuItem.Size = new Size(108, 45);
            họcSinhToolStripMenuItem.Text = "Học sinh";
            // 
            // quảnLýHọcSinhToolStripMenuItem
            // 
            quảnLýHọcSinhToolStripMenuItem.Name = "quảnLýHọcSinhToolStripMenuItem";
            quảnLýHọcSinhToolStripMenuItem.Size = new Size(270, 36);
            quảnLýHọcSinhToolStripMenuItem.Text = "Quản lý học sinh";
            quảnLýHọcSinhToolStripMenuItem.Click += quảnLýHọcSinhToolStripMenuItem_Click;
            // 
            // addStudentSubMenuItem
            // 
            addStudentSubMenuItem.Enabled = false;
            addStudentSubMenuItem.Name = "addStudentSubMenuItem";
            addStudentSubMenuItem.Size = new Size(270, 36);
            addStudentSubMenuItem.Text = "Thêm học sinh";
            addStudentSubMenuItem.Click += addStudentSubMenuItem_Click;
            // 
            // lớpHọcToolStripMenuItem
            // 
            lớpHọcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýLớpHọcToolStripMenuItem, addClassSubMenuItem });
            lớpHọcToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            lớpHọcToolStripMenuItem.Size = new Size(101, 45);
            lớpHọcToolStripMenuItem.Text = "Lớp học";
            // 
            // quảnLýLớpHọcToolStripMenuItem
            // 
            quảnLýLớpHọcToolStripMenuItem.Name = "quảnLýLớpHọcToolStripMenuItem";
            quảnLýLớpHọcToolStripMenuItem.Size = new Size(258, 36);
            quảnLýLớpHọcToolStripMenuItem.Text = "Quản lý lớp học";
            quảnLýLớpHọcToolStripMenuItem.Click += classManagementMenuItem_Click;
            // 
            // addClassSubMenuItem
            // 
            addClassSubMenuItem.Enabled = false;
            addClassSubMenuItem.Name = "addClassSubMenuItem";
            addClassSubMenuItem.Size = new Size(258, 36);
            addClassSubMenuItem.Text = "Thêm lớp học";
            addClassSubMenuItem.Click += addClassMenuItem_Click;
            // 
            // mônHọcToolStripMenuItem
            // 
            mônHọcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýMônHọcToolStripMenuItem });
            mônHọcToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            mônHọcToolStripMenuItem.Size = new Size(109, 45);
            mônHọcToolStripMenuItem.Text = "Môn học";
            // 
            // quảnLýMônHọcToolStripMenuItem
            // 
            quảnLýMônHọcToolStripMenuItem.Name = "quảnLýMônHọcToolStripMenuItem";
            quảnLýMônHọcToolStripMenuItem.Size = new Size(271, 36);
            quảnLýMônHọcToolStripMenuItem.Text = "Quản lý môn học";
            quảnLýMônHọcToolStripMenuItem.Click += subjectManagementMenuItem_Click;
            // 
            // điểmToolStripMenuItem
            // 
            điểmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýĐiểmToolStripMenuItem, addTranscriptSubMenuItem });
            điểmToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            điểmToolStripMenuItem.Name = "điểmToolStripMenuItem";
            điểmToolStripMenuItem.Size = new Size(76, 45);
            điểmToolStripMenuItem.Text = "Điểm";
            // 
            // quảnLýĐiểmToolStripMenuItem
            // 
            quảnLýĐiểmToolStripMenuItem.Name = "quảnLýĐiểmToolStripMenuItem";
            quảnLýĐiểmToolStripMenuItem.Size = new Size(236, 36);
            quảnLýĐiểmToolStripMenuItem.Text = "Quản lý điểm";
            quảnLýĐiểmToolStripMenuItem.Click += transcriptManagementMenuItem_Click;
            // 
            // addTranscriptSubMenuItem
            // 
            addTranscriptSubMenuItem.Enabled = false;
            addTranscriptSubMenuItem.Name = "addTranscriptSubMenuItem";
            addTranscriptSubMenuItem.Size = new Size(236, 36);
            addTranscriptSubMenuItem.Text = "Nhập điểm";
            addTranscriptSubMenuItem.Click += addTranscriptMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(121, 45);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1985, 1077);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý chung";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem họcSinhToolStripMenuItem;
        private ToolStripMenuItem lớpHọcToolStripMenuItem;
        private ToolStripMenuItem mônHọcToolStripMenuItem;
        private ToolStripMenuItem điểmToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem quảnLýHọcSinhToolStripMenuItem;
        private ToolStripMenuItem addStudentSubMenuItem;
        private ToolStripMenuItem quảnLýLớpHọcToolStripMenuItem;
        private ToolStripMenuItem addClassSubMenuItem;
        private ToolStripMenuItem quảnLýMônHọcToolStripMenuItem;
        private ToolStripMenuItem quảnLýĐiểmToolStripMenuItem;
        private ToolStripMenuItem addTranscriptSubMenuItem;
    }
}