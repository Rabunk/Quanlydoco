namespace Quanlydoco
{
    partial class FormAdmin
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panelKH = new System.Windows.Forms.Panel();
            this.lblTimKH = new System.Windows.Forms.Label();
            this.txtTimKH = new System.Windows.Forms.TextBox();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.dgvTimKH = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelSP = new System.Windows.Forms.Panel();
            this.cboFilterTrangThai = new System.Windows.Forms.ComboBox();
            this.lblFilterTT = new System.Windows.Forms.Label();
            this.cboFilterDoHiem = new System.Windows.Forms.ComboBox();
            this.lblFilterDH = new System.Windows.Forms.Label();
            this.cboFilterDanhMuc = new System.Windows.Forms.ComboBox();
            this.lblFilterDM = new System.Windows.Forms.Label();
            this.lblTimSP = new System.Windows.Forms.Label();
            this.txtTimSP = new System.Windows.Forms.TextBox();
            this.btnTimSP = new System.Windows.Forms.Button();
            this.dgvTimSP = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelDM = new System.Windows.Forms.Panel();
            this.lblTimDM = new System.Windows.Forms.Label();
            this.txtTimDM = new System.Windows.Forms.TextBox();
            this.btnTimDM = new System.Windows.Forms.Button();
            this.dgvTimDM = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelDG = new System.Windows.Forms.Panel();
            this.lblTimDG_KH = new System.Windows.Forms.Label();
            this.txtTimDG_KhachHang = new System.Windows.Forms.TextBox();
            this.lblTimDG_SP = new System.Windows.Forms.Label();
            this.txtTimDG_SanPham = new System.Windows.Forms.TextBox();
            this.btnTimDG = new System.Windows.Forms.Button();
            this.dgvTimDG = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            this.panelKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKH)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panelSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimSP)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimDM)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panelDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimDG)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvTimKH);
            this.tabPage4.Controls.Add(this.panelKH);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1016, 624);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Khách hàng";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panelKH
            // 
            this.panelKH.Controls.Add(this.btnTimKH);
            this.panelKH.Controls.Add(this.txtTimKH);
            this.panelKH.Controls.Add(this.lblTimKH);
            this.panelKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKH.Location = new System.Drawing.Point(0, 0);
            this.panelKH.Name = "panelKH";
            this.panelKH.Size = new System.Drawing.Size(1016, 45);
            this.panelKH.TabIndex = 1;
            // 
            // lblTimKH
            // 
            this.lblTimKH.AutoSize = true;
            this.lblTimKH.Location = new System.Drawing.Point(10, 15);
            this.lblTimKH.Name = "lblTimKH";
            this.lblTimKH.Size = new System.Drawing.Size(157, 13);
            this.lblTimKH.TabIndex = 2;
            this.lblTimKH.Text = "Tìm khách hàng (Tên / Số ĐT):";
            // 
            // txtTimKH
            // 
            this.txtTimKH.Location = new System.Drawing.Point(160, 12);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(200, 20);
            this.txtTimKH.TabIndex = 1;
            // 
            // btnTimKH
            // 
            this.btnTimKH.Location = new System.Drawing.Point(370, 10);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(80, 23);
            this.btnTimKH.TabIndex = 0;
            this.btnTimKH.Text = "Tìm nhanh";
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // dgvTimKH
            // 
            this.dgvTimKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTimKH.Location = new System.Drawing.Point(0, 51);
            this.dgvTimKH.Name = "dgvTimKH";
            this.dgvTimKH.ReadOnly = true;
            this.dgvTimKH.Size = new System.Drawing.Size(1016, 573);
            this.dgvTimKH.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvTimSP);
            this.tabPage3.Controls.Add(this.panelSP);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1016, 624);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sản phẩm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelSP
            // 
            this.panelSP.Controls.Add(this.btnTimSP);
            this.panelSP.Controls.Add(this.txtTimSP);
            this.panelSP.Controls.Add(this.lblTimSP);
            this.panelSP.Controls.Add(this.lblFilterDM);
            this.panelSP.Controls.Add(this.cboFilterDanhMuc);
            this.panelSP.Controls.Add(this.lblFilterDH);
            this.panelSP.Controls.Add(this.cboFilterDoHiem);
            this.panelSP.Controls.Add(this.lblFilterTT);
            this.panelSP.Controls.Add(this.cboFilterTrangThai);
            this.panelSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSP.Location = new System.Drawing.Point(3, 3);
            this.panelSP.Name = "panelSP";
            this.panelSP.Size = new System.Drawing.Size(1010, 75);
            this.panelSP.TabIndex = 1;
            // 
            // cboFilterTrangThai
            // 
            this.cboFilterTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterTrangThai.Location = new System.Drawing.Point(710, 12);
            this.cboFilterTrangThai.Name = "cboFilterTrangThai";
            this.cboFilterTrangThai.Size = new System.Drawing.Size(110, 21);
            this.cboFilterTrangThai.TabIndex = 8;
            // 
            // lblFilterTT
            // 
            this.lblFilterTT.AutoSize = true;
            this.lblFilterTT.Location = new System.Drawing.Point(645, 15);
            this.lblFilterTT.Name = "lblFilterTT";
            this.lblFilterTT.Size = new System.Drawing.Size(58, 13);
            this.lblFilterTT.TabIndex = 7;
            this.lblFilterTT.Text = "Trạng thái:";
            // 
            // cboFilterDoHiem
            // 
            this.cboFilterDoHiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterDoHiem.Location = new System.Drawing.Point(525, 12);
            this.cboFilterDoHiem.Name = "cboFilterDoHiem";
            this.cboFilterDoHiem.Size = new System.Drawing.Size(100, 21);
            this.cboFilterDoHiem.TabIndex = 6;
            // 
            // lblFilterDH
            // 
            this.lblFilterDH.AutoSize = true;
            this.lblFilterDH.Location = new System.Drawing.Point(470, 15);
            this.lblFilterDH.Name = "lblFilterDH";
            this.lblFilterDH.Size = new System.Drawing.Size(49, 13);
            this.lblFilterDH.TabIndex = 5;
            this.lblFilterDH.Text = "Độ hiếm:";
            // 
            // cboFilterDanhMuc
            // 
            this.cboFilterDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterDanhMuc.Location = new System.Drawing.Point(320, 12);
            this.cboFilterDanhMuc.Name = "cboFilterDanhMuc";
            this.cboFilterDanhMuc.Size = new System.Drawing.Size(130, 21);
            this.cboFilterDanhMuc.TabIndex = 4;
            // 
            // lblFilterDM
            // 
            this.lblFilterDM.AutoSize = true;
            this.lblFilterDM.Location = new System.Drawing.Point(260, 15);
            this.lblFilterDM.Name = "lblFilterDM";
            this.lblFilterDM.Size = new System.Drawing.Size(59, 13);
            this.lblFilterDM.TabIndex = 3;
            this.lblFilterDM.Text = "Danh mục:";
            // 
            // lblTimSP
            // 
            this.lblTimSP.AutoSize = true;
            this.lblTimSP.Location = new System.Drawing.Point(10, 15);
            this.lblTimSP.Name = "lblTimSP";
            this.lblTimSP.Size = new System.Drawing.Size(81, 13);
            this.lblTimSP.TabIndex = 2;
            this.lblTimSP.Text = "Tên Sản Phẩm:";
            // 
            // txtTimSP
            // 
            this.txtTimSP.Location = new System.Drawing.Point(90, 12);
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.Size = new System.Drawing.Size(150, 20);
            this.txtTimSP.TabIndex = 1;
            // 
            // btnTimSP
            // 
            this.btnTimSP.Location = new System.Drawing.Point(840, 10);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(80, 23);
            this.btnTimSP.TabIndex = 0;
            this.btnTimSP.Text = "Lọc dữ liệu";
            this.btnTimSP.Click += new System.EventHandler(this.btnTimSP_Click);
            // 
            // dgvTimSP
            // 
            this.dgvTimSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTimSP.Location = new System.Drawing.Point(3, 84);
            this.dgvTimSP.Name = "dgvTimSP";
            this.dgvTimSP.ReadOnly = true;
            this.dgvTimSP.Size = new System.Drawing.Size(1010, 537);
            this.dgvTimSP.TabIndex = 0;
            this.dgvTimSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimSP_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTimDM);
            this.tabPage2.Controls.Add(this.panelDM);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1016, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh mục";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelDM
            // 
            this.panelDM.Controls.Add(this.btnTimDM);
            this.panelDM.Controls.Add(this.txtTimDM);
            this.panelDM.Controls.Add(this.lblTimDM);
            this.panelDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDM.Location = new System.Drawing.Point(3, 3);
            this.panelDM.Name = "panelDM";
            this.panelDM.Size = new System.Drawing.Size(1010, 45);
            this.panelDM.TabIndex = 1;
            // 
            // lblTimDM
            // 
            this.lblTimDM.AutoSize = true;
            this.lblTimDM.Location = new System.Drawing.Point(10, 15);
            this.lblTimDM.Name = "lblTimDM";
            this.lblTimDM.Size = new System.Drawing.Size(135, 13);
            this.lblTimDM.TabIndex = 2;
            this.lblTimDM.Text = "Tìm kiếm nhanh danh mục:";
            // 
            // txtTimDM
            // 
            this.txtTimDM.Location = new System.Drawing.Point(150, 12);
            this.txtTimDM.Name = "txtTimDM";
            this.txtTimDM.Size = new System.Drawing.Size(200, 20);
            this.txtTimDM.TabIndex = 1;
            // 
            // btnTimDM
            // 
            this.btnTimDM.Location = new System.Drawing.Point(360, 10);
            this.btnTimDM.Name = "btnTimDM";
            this.btnTimDM.Size = new System.Drawing.Size(80, 23);
            this.btnTimDM.TabIndex = 0;
            this.btnTimDM.Text = "Tìm kiếm";
            this.btnTimDM.Click += new System.EventHandler(this.btnTimDM_Click);
            // 
            // dgvTimDM
            // 
            this.dgvTimDM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimDM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTimDM.Location = new System.Drawing.Point(3, 54);
            this.dgvTimDM.Name = "dgvTimDM";
            this.dgvTimDM.ReadOnly = true;
            this.dgvTimDM.Size = new System.Drawing.Size(1010, 567);
            this.dgvTimDM.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTimDG);
            this.tabPage1.Controls.Add(this.panelDG);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1016, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phiên đấu giá";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelDG
            // 
            this.panelDG.Controls.Add(this.btnTimDG);
            this.panelDG.Controls.Add(this.txtTimDG_SanPham);
            this.panelDG.Controls.Add(this.lblTimDG_SP);
            this.panelDG.Controls.Add(this.txtTimDG_KhachHang);
            this.panelDG.Controls.Add(this.lblTimDG_KH);
            this.panelDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDG.Location = new System.Drawing.Point(3, 3);
            this.panelDG.Name = "panelDG";
            this.panelDG.Size = new System.Drawing.Size(1010, 45);
            this.panelDG.TabIndex = 0;
            // 
            // lblTimDG_KH
            // 
            this.lblTimDG_KH.AutoSize = true;
            this.lblTimDG_KH.Location = new System.Drawing.Point(265, 15);
            this.lblTimDG_KH.Name = "lblTimDG_KH";
            this.lblTimDG_KH.Size = new System.Drawing.Size(90, 13);
            this.lblTimDG_KH.TabIndex = 4;
            this.lblTimDG_KH.Text = "Tìm Khách Hàng:";
            // 
            // txtTimDG_KhachHang
            // 
            this.txtTimDG_KhachHang.Location = new System.Drawing.Point(355, 12);
            this.txtTimDG_KhachHang.Name = "txtTimDG_KhachHang";
            this.txtTimDG_KhachHang.Size = new System.Drawing.Size(150, 20);
            this.txtTimDG_KhachHang.TabIndex = 3;
            // 
            // lblTimDG_SP
            // 
            this.lblTimDG_SP.AutoSize = true;
            this.lblTimDG_SP.Location = new System.Drawing.Point(10, 15);
            this.lblTimDG_SP.Name = "lblTimDG_SP";
            this.lblTimDG_SP.Size = new System.Drawing.Size(79, 13);
            this.lblTimDG_SP.TabIndex = 2;
            this.lblTimDG_SP.Text = "Tìm Sản Phẩm:";
            // 
            // txtTimDG_SanPham
            // 
            this.txtTimDG_SanPham.Location = new System.Drawing.Point(95, 12);
            this.txtTimDG_SanPham.Name = "txtTimDG_SanPham";
            this.txtTimDG_SanPham.Size = new System.Drawing.Size(150, 20);
            this.txtTimDG_SanPham.TabIndex = 1;
            // 
            // btnTimDG
            // 
            this.btnTimDG.Location = new System.Drawing.Point(520, 10);
            this.btnTimDG.Name = "btnTimDG";
            this.btnTimDG.Size = new System.Drawing.Size(85, 23);
            this.btnTimDG.TabIndex = 0;
            this.btnTimDG.Text = "Tra cứu";
            this.btnTimDG.Click += new System.EventHandler(this.btnTimDG_Click);
            // 
            // dgvTimDG
            // 
            this.dgvTimDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTimDG.Location = new System.Drawing.Point(3, 54);
            this.dgvTimDG.Name = "dgvTimDG";
            this.dgvTimDG.ReadOnly = true;
            this.dgvTimDG.Size = new System.Drawing.Size(1010, 567);
            this.dgvTimDG.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 650);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản trị Đồ cổ";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tabPage4.ResumeLayout(false);
            this.panelKH.ResumeLayout(false);
            this.panelKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKH)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panelSP.ResumeLayout(false);
            this.panelSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimSP)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panelDM.ResumeLayout(false);
            this.panelDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimDM)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panelDG.ResumeLayout(false);
            this.panelDG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimDG)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvTimKH;
        private System.Windows.Forms.Panel panelKH;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.Label lblTimKH;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvTimSP;
        private System.Windows.Forms.Panel panelSP;
        private System.Windows.Forms.Button btnTimSP;
        private System.Windows.Forms.TextBox txtTimSP;
        private System.Windows.Forms.Label lblTimSP;
        private System.Windows.Forms.Label lblFilterDM;
        private System.Windows.Forms.ComboBox cboFilterDanhMuc;
        private System.Windows.Forms.Label lblFilterDH;
        private System.Windows.Forms.ComboBox cboFilterDoHiem;
        private System.Windows.Forms.Label lblFilterTT;
        private System.Windows.Forms.ComboBox cboFilterTrangThai;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTimDM;
        private System.Windows.Forms.Panel panelDM;
        private System.Windows.Forms.Button btnTimDM;
        private System.Windows.Forms.TextBox txtTimDM;
        private System.Windows.Forms.Label lblTimDM;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvTimDG;
        private System.Windows.Forms.Panel panelDG;
        private System.Windows.Forms.Button btnTimDG;
        private System.Windows.Forms.TextBox txtTimDG_SanPham;
        private System.Windows.Forms.Label lblTimDG_SP;
        private System.Windows.Forms.TextBox txtTimDG_KhachHang;
        private System.Windows.Forms.Label lblTimDG_KH;
        private System.Windows.Forms.TabControl tabControl1;
    }
}