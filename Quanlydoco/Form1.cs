using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlydoco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_SanPham ucSanPham = new UC_SanPham();
            HienThiGiaoDien(ucSanPham);
        }
        private void HienThiGiaoDien(UserControl uc)
        {
            pnlContent.Controls.Clear(); 
            uc.Dock = DockStyle.Fill;   
            pnlContent.Controls.Add(uc); 
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_SanPham ucSanPham = new UC_SanPham();
            HienThiGiaoDien(ucSanPham);
        }

        private void danhMucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_DanhMuc ucDanhMuc = new UC_DanhMuc();
            HienThiGiaoDien(ucDanhMuc);
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_KhachHang ucKhachHang = new UC_KhachHang();
            HienThiGiaoDien(ucKhachHang);
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin frmAdmin = new FormAdmin();

            frmAdmin.ShowDialog();
        }

        private void dauGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_DauGia ucDauGia = new UC_DauGia();
            HienThiGiaoDien(ucDauGia);
        }

        private void lblWelcomeTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcomeSub_Click(object sender, EventArgs e)
        {

        }
    }
}
