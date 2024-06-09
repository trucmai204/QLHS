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
            thêmMônHọcToolStripMenuItem = new ToolStripMenuItem();
            điểmToolStripMenuItem = new ToolStripMenuItem();
            fDiem = new ToolStripMenuItem();
            fNewDiem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(128, 128, 255);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { họcSinhToolStripMenuItem, lớpHọcToolStripMenuItem, mônHọcToolStripMenuItem, điểmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 4, 0, 4);
            menuStrip1.Size = new Size(1821, 50);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // họcSinhToolStripMenuItem
            // 
            họcSinhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýHọcSinhToolStripMenuItem, thêmHọcSinhToolStripMenuItem });
            họcSinhToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            họcSinhToolStripMenuItem.Name = "họcSinhToolStripMenuItem";
            họcSinhToolStripMenuItem.Size = new Size(108, 42);
            họcSinhToolStripMenuItem.Text = "&Học sinh";
            // 
            // quảnLýHọcSinhToolStripMenuItem
            // 
            quảnLýHọcSinhToolStripMenuItem.Name = "quảnLýHọcSinhToolStripMenuItem";
            quảnLýHọcSinhToolStripMenuItem.Size = new Size(267, 36);
            quảnLýHọcSinhToolStripMenuItem.Text = "Quản lý học sinh";
            quảnLýHọcSinhToolStripMenuItem.Click += quảnLýHọcSinhToolStripMenuItem_Click;
            // 
            // thêmHọcSinhToolStripMenuItem
            // 
            thêmHọcSinhToolStripMenuItem.Name = "thêmHọcSinhToolStripMenuItem";
            thêmHọcSinhToolStripMenuItem.Size = new Size(267, 36);
            thêmHọcSinhToolStripMenuItem.Text = "Thêm học sinh";
            thêmHọcSinhToolStripMenuItem.Click += thêmHọcSinhToolStripMenuItem_Click;
            // 
            // lớpHọcToolStripMenuItem
            // 
            lớpHọcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fPhanLopHoc, thêmLớpHọcToolStripMenuItem });
            lớpHọcToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            lớpHọcToolStripMenuItem.Size = new Size(101, 42);
            lớpHọcToolStripMenuItem.Text = "&Lớp học";
            // 
            // fPhanLopHoc
            // 
            fPhanLopHoc.Name = "fPhanLopHoc";
            fPhanLopHoc.Size = new Size(258, 36);
            fPhanLopHoc.Text = "Quản lý lớp học";
            fPhanLopHoc.Click += fPhanLopHoc_Click;
            // 
            // thêmLớpHọcToolStripMenuItem
            // 
            thêmLớpHọcToolStripMenuItem.Name = "thêmLớpHọcToolStripMenuItem";
            thêmLớpHọcToolStripMenuItem.Size = new Size(258, 36);
            thêmLớpHọcToolStripMenuItem.Text = "Thêm lớp học";
            thêmLớpHọcToolStripMenuItem.Click += thêmLớpHọcToolStripMenuItem_Click;
            // 
            // mônHọcToolStripMenuItem
            // 
            mônHọcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýMônHọcToolStripMenuItem, thêmMônHọcToolStripMenuItem });
            mônHọcToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            mônHọcToolStripMenuItem.Size = new Size(109, 42);
            mônHọcToolStripMenuItem.Text = "&Môn học";
            // 
            // quảnLýMônHọcToolStripMenuItem
            // 
            quảnLýMônHọcToolStripMenuItem.Name = "quảnLýMônHọcToolStripMenuItem";
            quảnLýMônHọcToolStripMenuItem.Size = new Size(271, 36);
            quảnLýMônHọcToolStripMenuItem.Text = "Quản lý môn học";
            quảnLýMônHọcToolStripMenuItem.Click += quảnLýMônHọcToolStripMenuItem_Click;
            // 
            // thêmMônHọcToolStripMenuItem
            // 
            thêmMônHọcToolStripMenuItem.Name = "thêmMônHọcToolStripMenuItem";
            thêmMônHọcToolStripMenuItem.Size = new Size(271, 36);
            thêmMônHọcToolStripMenuItem.Text = "Thêm môn học";
            thêmMônHọcToolStripMenuItem.Click += thêmMônHọcToolStripMenuItem_Click;
            // 
            // điểmToolStripMenuItem
            // 
            điểmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fDiem, fNewDiem });
            điểmToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            điểmToolStripMenuItem.ForeColor = SystemColors.ControlText;
            điểmToolStripMenuItem.Name = "điểmToolStripMenuItem";
            điểmToolStripMenuItem.Size = new Size(76, 42);
            điểmToolStripMenuItem.Text = "&Điểm";
            // 
            // fDiem
            // 
            fDiem.Name = "fDiem";
            fDiem.Size = new Size(236, 36);
            fDiem.Text = "Quản lý điểm";
            fDiem.Click += fDiem_Click;
            // 
            // fNewDiem
            // 
            fNewDiem.Name = "fNewDiem";
            fNewDiem.Size = new Size(236, 36);
            fNewDiem.Text = "Nhập điểm";
            fNewDiem.Click += fNewDiem_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1821, 941);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
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
        private ToolStripMenuItem thêmMônHọcToolStripMenuItem;
        private ToolStripMenuItem fNewDiem;
    }
}