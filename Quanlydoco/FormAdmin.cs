using QuanLyDoCo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlydoco
{
    public partial class FormAdmin : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieuBoLoc();
            TaiDuLieuTraCuuHeThong();
        }

        private void KhoiTaoDuLieuBoLoc()
        {
            
            try
            {
                DataTable dtDM = db.ExecuteQuery("SELECT MaDM, TenDanhMuc FROM DanhMuc");
                DataRow row = dtDM.NewRow();
                row["MaDM"] = DBNull.Value;
                row["TenDanhMuc"] = "--- Tất cả ---";
                dtDM.Rows.InsertAt(row, 0);

                cboFilterDanhMuc.DataSource = dtDM;
                cboFilterDanhMuc.DisplayMember = "TenDanhMuc";
                cboFilterDanhMuc.ValueMember = "MaDM";
            }
            catch { }

            cboFilterDoHiem.Items.Clear();
            cboFilterDoHiem.Items.Add("--- Tất cả ---");
            cboFilterDoHiem.Items.Add("Bình thường");
            cboFilterDoHiem.Items.Add("Hiếm");
            cboFilterDoHiem.Items.Add("Cực hiếm");
            cboFilterDoHiem.SelectedIndex = 0;

            cboFilterTrangThai.Items.Clear();
            cboFilterTrangThai.Items.Add("--- Tất cả ---");
            cboFilterTrangThai.Items.Add("Chưa đấu giá");
            cboFilterTrangThai.Items.Add("Đang đấu giá");
            cboFilterTrangThai.Items.Add("Đã bán");
            cboFilterTrangThai.SelectedIndex = 0;
        }

        public void TaiDuLieuTraCuuHeThong()
        {
            btnTimDG_Click(null, null);
            btnTimDM_Click(null, null);
            btnTimSP_Click(null, null);
            btnTimKH_Click(null, null);
        }

        private void btnTimDG_Click(object sender, EventArgs e)
        {
            string tuKhoaSP = txtTimDG_SanPham.Text.Trim();
            string tuKhoaKH = txtTimDG_KhachHang.Text.Trim();

            string query = @"SELECT pdg.MaPhien AS [Mã Phiên], sp.TenSP AS [Tên Sản Phẩm], 
                            kh.HoTen AS [Người Đặt Giá], ls.SoTienTra AS [Mức Giá Trả], 
                            ls.ThoiGianTra AS [Thời Gian Đặt]
                            FROM LichSuDauGia ls
                            JOIN PhienDauGia pdg ON ls.MaPhien = pdg.MaPhien
                            JOIN SanPham sp ON pdg.MaSP = sp.MaSP
                            JOIN KhachHang kh ON ls.MaKH = kh.MaKH
                            WHERE sp.TenSP LIKE @KeySP AND kh.HoTen LIKE @KeyKH
                            ORDER BY ls.ThoiGianTra DESC";

            SqlParameter[] p = {
                new SqlParameter("@KeySP", "%" + tuKhoaSP + "%"),
                new SqlParameter("@KeyKH", "%" + tuKhoaKH + "%")
            };
            dgvTimDG.DataSource = db.ExecuteQuery(query, p);
        }

        private void btnTimDM_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimDM.Text.Trim();
            string query = @"SELECT MaDM AS [Mã Danh Mục], TenDanhMuc AS [Tên Danh Mục],
                            (SELECT COUNT(*) FROM SanPham WHERE MaDM = DanhMuc.MaDM) AS [Số Lượng SP]
                            FROM DanhMuc
                            WHERE TenDanhMuc LIKE @Keyword";

            SqlParameter[] p = { new SqlParameter("@Keyword", "%" + tuKhoa + "%") };
            dgvTimDM.DataSource = db.ExecuteQuery(query, p);
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimSP.Text.Trim();

            string query = @"SELECT sp.MaSP AS [Mã SP], sp.TenSP AS [Tên Vật Phẩm], dm.TenDanhMuc AS [Thuộc Danh Mục], 
                            sp.NamSanXuat AS [Năm SX], sp.DoHiem AS [Độ Hiếm], sp.GiaBanThuong AS [Giá Bán Đứt], 
                            sp.TrangThai AS [Trạng Thái]
                            FROM SanPham sp
                            LEFT JOIN DanhMuc dm ON sp.MaDM = dm.MaDM
                            WHERE sp.TenSP LIKE @Keyword";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Keyword", "%" + tuKhoa + "%"));

            if (cboFilterDanhMuc.SelectedValue != null && cboFilterDanhMuc.SelectedValue != DBNull.Value)
            {
                query += " AND sp.MaDM = @MaDM";
                parameters.Add(new SqlParameter("@MaDM", cboFilterDanhMuc.SelectedValue));
            }

            if (cboFilterDoHiem.SelectedIndex > 0)
            {
                query += " AND sp.DoHiem = @DoHiem";
                parameters.Add(new SqlParameter("@DoHiem", cboFilterDoHiem.SelectedItem.ToString()));
            }

            if (cboFilterTrangThai.SelectedIndex > 0)
            {
                query += " AND sp.TrangThai = @TrangThai";
                parameters.Add(new SqlParameter("@TrangThai", cboFilterTrangThai.SelectedItem.ToString()));
            }

            dgvTimSP.DataSource = db.ExecuteQuery(query, parameters.ToArray());
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKH.Text.Trim();
            string query = @"SELECT kh.MaKH AS [Mã KH], kh.HoTen AS [Họ Tên Khách], kh.SoDienThoai AS [SĐT], 
                            kh.Email, kh.DiaChi AS [Địa Chỉ]
                            FROM KhachHang kh
                            WHERE kh.HoTen LIKE @Keyword OR kh.SoDienThoai LIKE @Keyword";

            SqlParameter[] p = { new SqlParameter("@Keyword", "%" + tuKhoa + "%") };
            dgvTimKH.DataSource = db.ExecuteQuery(query, p);
        }

        private void dgvTimSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}