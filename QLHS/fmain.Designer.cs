namespace QLHS
{
    partial class fmain
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
            nhậpĐiểmToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(982, 89);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // họcSinhToolStripMenuItem
            // 
            họcSinhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýHọcSinhToolStripMenuItem, thêmHọcSinhToolStripMenuItem });
            họcSinhToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            họcSinhToolStripMenuItem.Name = "họcSinhToolStripMenuItem";
            họcSinhToolStripMenuItem.Size = new Size(91, 83);
            họcSinhToolStripMenuItem.Text = "&Học sinh";
            // 
            // quảnLýHọcSinhToolStripMenuItem
            // 
            quảnLýHọcSinhToolStripMenuItem.Name = "quảnLýHọcSinhToolStripMenuItem";
            quảnLýHọcSinhToolStripMenuItem.Size = new Size(223, 28);
            quảnLýHọcSinhToolStripMenuItem.Text = "Quản lý học sinh";
            // 
            // thêmHọcSinhToolStripMenuItem
            // 
            thêmHọcSinhToolStripMenuItem.Name = "thêmHọcSinhToolStripMenuItem";
            thêmHọcSinhToolStripMenuItem.Size = new Size(223, 28);
            thêmHọcSinhToolStripMenuItem.Text = "Thêm học sinh";
            // 
            // lớpHọcToolStripMenuItem
            // 
            lớpHọcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fPhanLopHoc, thêmLớpHọcToolStripMenuItem });
            lớpHọcToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            lớpHọcToolStripMenuItem.Size = new Size(85, 83);
            lớpHọcToolStripMenuItem.Text = "&Lớp học";
            // 
            // fPhanLopHoc
            // 
            fPhanLopHoc.Name = "fPhanLopHoc";
            fPhanLopHoc.Size = new Size(199, 28);
            fPhanLopHoc.Text = "Phân lớp học";
            fPhanLopHoc.Click += fPhanLopHoc_Click;
            // 
            // thêmLớpHọcToolStripMenuItem
            // 
            thêmLớpHọcToolStripMenuItem.Name = "thêmLớpHọcToolStripMenuItem";
            thêmLớpHọcToolStripMenuItem.Size = new Size(199, 28);
            thêmLớpHọcToolStripMenuItem.Text = "Thêm lớp học";
            // 
            // mônHọcToolStripMenuItem
            // 
            mônHọcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýMônHọcToolStripMenuItem, thêmMônHọcToolStripMenuItem });
            mônHọcToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            mônHọcToolStripMenuItem.Size = new Size(93, 83);
            mônHọcToolStripMenuItem.Text = "&Môn học";
            // 
            // quảnLýMônHọcToolStripMenuItem
            // 
            quảnLýMônHọcToolStripMenuItem.Name = "quảnLýMônHọcToolStripMenuItem";
            quảnLýMônHọcToolStripMenuItem.Size = new Size(227, 28);
            quảnLýMônHọcToolStripMenuItem.Text = "Quản lý môn học";
            // 
            // thêmMônHọcToolStripMenuItem
            // 
            thêmMônHọcToolStripMenuItem.Name = "thêmMônHọcToolStripMenuItem";
            thêmMônHọcToolStripMenuItem.Size = new Size(227, 28);
            thêmMônHọcToolStripMenuItem.Text = "Thêm môn học";
            // 
            // điểmToolStripMenuItem
            // 
            điểmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fDiem, nhậpĐiểmToolStripMenuItem });
            điểmToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            điểmToolStripMenuItem.ForeColor = SystemColors.ControlText;
            điểmToolStripMenuItem.Name = "điểmToolStripMenuItem";
            điểmToolStripMenuItem.Size = new Size(64, 83);
            điểmToolStripMenuItem.Text = "&Điểm";
            // 
            // fDiem
            // 
            fDiem.Name = "fDiem";
            fDiem.Size = new Size(197, 28);
            fDiem.Text = "Quản lý điểm";
            fDiem.Click += fDiem_Click;
            // 
            // nhậpĐiểmToolStripMenuItem
            // 
            nhậpĐiểmToolStripMenuItem.Name = "nhậpĐiểmToolStripMenuItem";
            nhậpĐiểmToolStripMenuItem.Size = new Size(197, 28);
            nhậpĐiểmToolStripMenuItem.Text = "Nhập điểm";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_school_classroom_desk_textbook_background_picture_image_2270261;
            pictureBox1.Location = new Point(0, 93);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(982, 637);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // fmain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "fmain";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ToolStripMenuItem nhậpĐiểmToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}