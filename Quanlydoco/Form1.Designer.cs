namespace Quanlydoco
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dauGiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem,
            this.dauGiaToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sanPhamToolStripMenuItem,
            this.danhMucToolStripMenuItem,
            this.khachHangToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // sanPhamToolStripMenuItem
            // 
            this.sanPhamToolStripMenuItem.Name = "sanPhamToolStripMenuItem";
            this.sanPhamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sanPhamToolStripMenuItem.Text = "Sản phẩm";
            this.sanPhamToolStripMenuItem.Click += new System.EventHandler(this.sanPhamToolStripMenuItem_Click);
            // 
            // danhMucToolStripMenuItem
            // 
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.danhMucToolStripMenuItem.Text = "Danh mục";
            this.danhMucToolStripMenuItem.Click += new System.EventHandler(this.danhMucToolStripMenuItem_Click);
            // 
            // khachHangToolStripMenuItem
            // 
            this.khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            this.khachHangToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.khachHangToolStripMenuItem.Text = "Khách hàng";
            this.khachHangToolStripMenuItem.Click += new System.EventHandler(this.khachHangToolStripMenuItem_Click);
            // 
            // dauGiaToolStripMenuItem
            // 
            this.dauGiaToolStripMenuItem.Name = "dauGiaToolStripMenuItem";
            this.dauGiaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.dauGiaToolStripMenuItem.Text = "Đấu giá";
            this.dauGiaToolStripMenuItem.Click += new System.EventHandler(this.dauGiaToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.adminToolStripMenuItem.Text = "Tra cứu";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlWelcome);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 24);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(900, 526);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.pnlWelcome.Controls.Add(this.pictureBox1);
            this.pnlWelcome.Controls.Add(this.lblWelcomeTitle);
            this.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWelcome.Location = new System.Drawing.Point(0, 0);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(900, 526);
            this.pnlWelcome.TabIndex = 0;
            // 
            // lblWelcomeTitle
            // 
            this.lblWelcomeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblWelcomeTitle.Location = new System.Drawing.Point(97, 13);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(701, 47);
            this.lblWelcomeTitle.TabIndex = 0;
            this.lblWelcomeTitle.Text = "HỆ THỐNG QUẢN LÝ VÀ ĐẤU GIÁ ĐỒ CỔ";
            this.lblWelcomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcomeTitle.Click += new System.EventHandler(this.lblWelcomeTitle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quanlydoco.Properties.Resources.di_vat_co_vat;
            this.pictureBox1.Location = new System.Drawing.Point(151, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 370);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý đồ cổ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dauGiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label lblWelcomeTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

