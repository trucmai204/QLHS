namespace QLHS
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            menuStrip1 = new MenuStrip();
            họcSinhToolStripMenuItem = new ToolStripMenuItem();
            quảnLýHọcSinhToolStripMenuItem = new ToolStripMenuItem();
            thêmHọcSinhToolStripMenuItem = new ToolStripMenuItem();
            lớpHọcToolStripMenuItem = new ToolStripMenuItem();
            fPhanLopHoc = new ToolStripMenuItem();
            thêmLớpHọcToolStripMenuItem = new ToolStripMenuItem();
            mônHọcToolStripMenuItem = new ToolStripMenuItem();
            quảnLýMônHọcToolStripMenuItem = new ToolStripMenuItem();
            điểmToolStripMenuItem = new ToolStripMenuItem();
            fDiem = new ToolStripMenuItem();
            nhapDiem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(128, 128, 255);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { họcSinhToolStripMenuItem, lớpHọcToolStripMenuItem, mônHọcToolStripMenuItem, điểmToolStripMenuItem, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(981, 23);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // họcSinhToolStripMenuItem
            // 
            họcSinhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýHọcSinhToolStripMenuItem, thêmHọcSinhToolStripMenuItem });
            họcSinhToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            họcSinhToolStripMenuItem.Name = "họcSinhToolStripMenuItem";
            họcSinhToolStripMenuItem.Size = new Size(73, 19);
            họcSinhToolStripMenuItem.Text = "&Học sinh";
            // 
            // quảnLýHọcSinhToolStripMenuItem
            // 
            quảnLýHọcSinhToolStripMenuItem.Name = "quảnLýHọcSinhToolStripMenuItem";
            quảnLýHọcSinhToolStripMenuItem.Size = new Size(178, 22);
            quảnLýHọcSinhToolStripMenuItem.Text = "Quản lý học sinh";
            quảnLýHọcSinhToolStripMenuItem.Click += quảnLýHọcSinhToolStripMenuItem_Click;
            // 
            // thêmHọcSinhToolStripMenuItem
            // 
            thêmHọcSinhToolStripMenuItem.Enabled = false;
            thêmHọcSinhToolStripMenuItem.Name = "thêmHọcSinhToolStripMenuItem";
            thêmHọcSinhToolStripMenuItem.Size = new Size(178, 22);
            thêmHọcSinhToolStripMenuItem.Text = "Thêm học sinh";
            thêmHọcSinhToolStripMenuItem.Click += thêmHọcSinhToolStripMenuItem_Click;
            // 
            // lớpHọcToolStripMenuItem
            // 
            lớpHọcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fPhanLopHoc, thêmLớpHọcToolStripMenuItem });
            lớpHọcToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            lớpHọcToolStripMenuItem.Size = new Size(68, 19);
            lớpHọcToolStripMenuItem.Text = "&Lớp học";
            // 
            // fPhanLopHoc
            // 
            fPhanLopHoc.Name = "fPhanLopHoc";
            fPhanLopHoc.Size = new Size(172, 22);
            fPhanLopHoc.Text = "Quản lý lớp học";
            fPhanLopHoc.Click += fPhanLopHoc_Click;
            // 
            // thêmLớpHọcToolStripMenuItem
            // 
            thêmLớpHọcToolStripMenuItem.Enabled = false;
            thêmLớpHọcToolStripMenuItem.Name = "thêmLớpHọcToolStripMenuItem";
            thêmLớpHọcToolStripMenuItem.Size = new Size(172, 22);
            thêmLớpHọcToolStripMenuItem.Text = "Thêm lớp học";
            thêmLớpHọcToolStripMenuItem.Click += thêmLớpHọcToolStripMenuItem_Click;
            // 
            // mônHọcToolStripMenuItem
            // 
            mônHọcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýMônHọcToolStripMenuItem });
            mônHọcToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            mônHọcToolStripMenuItem.Size = new Size(74, 19);
            mônHọcToolStripMenuItem.Text = "&Môn học";
            // 
            // quảnLýMônHọcToolStripMenuItem
            // 
            quảnLýMônHọcToolStripMenuItem.Name = "quảnLýMônHọcToolStripMenuItem";
            quảnLýMônHọcToolStripMenuItem.Size = new Size(181, 22);
            quảnLýMônHọcToolStripMenuItem.Text = "Quản lý môn học";
            quảnLýMônHọcToolStripMenuItem.Click += quảnLýMônHọcToolStripMenuItem_Click;
            // 
            // điểmToolStripMenuItem
            // 
            điểmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fDiem, nhapDiem });
            điểmToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            điểmToolStripMenuItem.ForeColor = SystemColors.ControlText;
            điểmToolStripMenuItem.Name = "điểmToolStripMenuItem";
            điểmToolStripMenuItem.Size = new Size(51, 19);
            điểmToolStripMenuItem.Text = "&Điểm";
            // 
            // fDiem
            // 
            fDiem.Name = "fDiem";
            fDiem.Size = new Size(180, 22);
            fDiem.Text = "Quản lý điểm";
            fDiem.Click += fDiem_Click;
            // 
            // nhapDiem
            // 
            nhapDiem.Enabled = false;
            nhapDiem.Name = "nhapDiem";
            nhapDiem.Size = new Size(180, 22);
            nhapDiem.Text = "Nhập điểm";
            nhapDiem.Click += fNewDiem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(83, 19);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(981, 441);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý chung";
            FormClosing += fMain_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem họcSinhToolStripMenuItem;
        private ToolStripMenuItem quảnLýHọcSinhToolStripMenuItem;
        private ToolStripMenuItem lớpHọcToolStripMenuItem;
        private ToolStripMenuItem fPhanLopHoc;
        private ToolStripMenuItem mônHọcToolStripMenuItem;
        private ToolStripMenuItem quảnLýMônHọcToolStripMenuItem;
        private ToolStripMenuItem điểmToolStripMenuItem;
        private ToolStripMenuItem fDiem;
        private ToolStripMenuItem thêmHọcSinhToolStripMenuItem;
        private ToolStripMenuItem thêmLớpHọcToolStripMenuItem;
        private ToolStripMenuItem nhapDiem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}