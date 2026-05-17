namespace Quanlydoco
{
    partial class UC_DauGia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSanPhamDG = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaKhoiDiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaHienTai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTienTraGia = new System.Windows.Forms.TextBox();
            this.btnGhiNhanGia = new System.Windows.Forms.Button();
            this.btnBatDauPhien = new System.Windows.Forms.Button();
            this.btnKetThucPhien = new System.Windows.Forms.Button();
            this.dgvLichSuGia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuGia)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnKetThucPhien);
            this.splitContainer1.Panel1.Controls.Add(this.btnBatDauPhien);
            this.splitContainer1.Panel1.Controls.Add(this.btnGhiNhanGia);
            this.splitContainer1.Panel1.Controls.Add(this.txtTienTraGia);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.cboKhachHang);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtGiaHienTai);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtGiaKhoiDiem);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cboSanPhamDG);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvLichSuGia);
            this.splitContainer1.Size = new System.Drawing.Size(680, 403);
            this.splitContainer1.SplitterDistance = 328;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn đồ cổ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboSanPhamDG
            // 
            this.cboSanPhamDG.FormattingEnabled = true;
            this.cboSanPhamDG.Location = new System.Drawing.Point(25, 57);
            this.cboSanPhamDG.Name = "cboSanPhamDG";
            this.cboSanPhamDG.Size = new System.Drawing.Size(121, 21);
            this.cboSanPhamDG.TabIndex = 1;
            this.cboSanPhamDG.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá khởi điểm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtGiaKhoiDiem
            // 
            this.txtGiaKhoiDiem.Location = new System.Drawing.Point(25, 134);
            this.txtGiaKhoiDiem.Name = "txtGiaKhoiDiem";
            this.txtGiaKhoiDiem.ReadOnly = true;
            this.txtGiaKhoiDiem.Size = new System.Drawing.Size(121, 20);
            this.txtGiaKhoiDiem.TabIndex = 3;
            this.txtGiaKhoiDiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá hiện tại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtGiaHienTai
            // 
            this.txtGiaHienTai.Location = new System.Drawing.Point(25, 205);
            this.txtGiaHienTai.Name = "txtGiaHienTai";
            this.txtGiaHienTai.ReadOnly = true;
            this.txtGiaHienTai.Size = new System.Drawing.Size(121, 20);
            this.txtGiaHienTai.TabIndex = 5;
            this.txtGiaHienTai.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Khách hàng trả giá";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.ForeColor = System.Drawing.Color.Yellow;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(191, 57);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(121, 21);
            this.cboKhachHang.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá đặt";
            // 
            // txtTienTraGia
            // 
            this.txtTienTraGia.Location = new System.Drawing.Point(191, 134);
            this.txtTienTraGia.Name = "txtTienTraGia";
            this.txtTienTraGia.Size = new System.Drawing.Size(121, 20);
            this.txtTienTraGia.TabIndex = 9;
            // 
            // btnGhiNhanGia
            // 
            this.btnGhiNhanGia.Location = new System.Drawing.Point(191, 205);
            this.btnGhiNhanGia.Name = "btnGhiNhanGia";
            this.btnGhiNhanGia.Size = new System.Drawing.Size(121, 23);
            this.btnGhiNhanGia.TabIndex = 10;
            this.btnGhiNhanGia.Text = "Đấu";
            this.btnGhiNhanGia.UseVisualStyleBackColor = true;
            this.btnGhiNhanGia.Click += new System.EventHandler(this.btnGhiNhanGia_Click);
            // 
            // btnBatDauPhien
            // 
            this.btnBatDauPhien.Location = new System.Drawing.Point(25, 328);
            this.btnBatDauPhien.Name = "btnBatDauPhien";
            this.btnBatDauPhien.Size = new System.Drawing.Size(121, 33);
            this.btnBatDauPhien.TabIndex = 11;
            this.btnBatDauPhien.Text = "Bắt đầu phiên";
            this.btnBatDauPhien.UseVisualStyleBackColor = true;
            this.btnBatDauPhien.Click += new System.EventHandler(this.btnBatDauPhien_Click);
            // 
            // btnKetThucPhien
            // 
            this.btnKetThucPhien.Location = new System.Drawing.Point(191, 328);
            this.btnKetThucPhien.Name = "btnKetThucPhien";
            this.btnKetThucPhien.Size = new System.Drawing.Size(121, 33);
            this.btnKetThucPhien.TabIndex = 12;
            this.btnKetThucPhien.Text = "kết thúc phiên";
            this.btnKetThucPhien.UseVisualStyleBackColor = true;
            this.btnKetThucPhien.Click += new System.EventHandler(this.btnKetThucPhien_Click);
            // 
            // dgvLichSuGia
            // 
            this.dgvLichSuGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSuGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSuGia.Location = new System.Drawing.Point(0, 0);
            this.dgvLichSuGia.Name = "dgvLichSuGia";
            this.dgvLichSuGia.Size = new System.Drawing.Size(348, 403);
            this.dgvLichSuGia.TabIndex = 0;
            // 
            // UC_DauGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UC_DauGia";
            this.Size = new System.Drawing.Size(680, 403);
            this.Load += new System.EventHandler(this.UC_DauGia_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnKetThucPhien;
        private System.Windows.Forms.Button btnBatDauPhien;
        private System.Windows.Forms.Button btnGhiNhanGia;
        private System.Windows.Forms.TextBox txtTienTraGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaHienTai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaKhoiDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSanPhamDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLichSuGia;
    }
}
