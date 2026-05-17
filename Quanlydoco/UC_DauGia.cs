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
    public partial class UC_DauGia : UserControl
    {
        private DatabaseHelper db = new DatabaseHelper();
        private int maPhienHienTai = -1;

        public UC_DauGia()
        {
            InitializeComponent();
        }

        private void UC_DauGia_Load(object sender, EventArgs e)
        {
            LoadComboBoxSanPham();
            LoadComboBoxKhachHang();
        }

        private void LoadComboBoxSanPham()
        {
            string query = "SELECT MaSP, TenSP FROM SanPham WHERE TrangThai IN (N'Sẵn sàng', N'Đang đấu giá')";
            DataTable dt = db.ExecuteQuery(query);
            cboSanPhamDG.DataSource = dt;
            cboSanPhamDG.DisplayMember = "TenSP";
            cboSanPhamDG.ValueMember = "MaSP";
        }

        private void LoadComboBoxKhachHang()
        {
            string query = "SELECT MaKH, HoTen FROM KhachHang";
            DataTable dt = db.ExecuteQuery(query);
            cboKhachHang.DataSource = dt;
            cboKhachHang.DisplayMember = "HoTen";
            cboKhachHang.ValueMember = "MaKH";
        }

        private void cboSanPhamDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPhamDG.SelectedValue != null && int.TryParse(cboSanPhamDG.SelectedValue.ToString(), out int maSP))
            {
                LayThongTinSanPhamHienTai(maSP);
            }
        }

        private void LayThongTinSanPhamHienTai(int maSP)
        {
            string querySP = "SELECT GiaBanThuong, TrangThai FROM SanPham WHERE MaSP = @MaSP";
            SqlParameter[] p1 = { new SqlParameter("@MaSP", maSP) };
            DataTable dtSP = db.ExecuteQuery(querySP, p1);

            if (dtSP.Rows.Count > 0)
            {
                txtGiaKhoiDiem.Text = dtSP.Rows[0]["GiaBanThuong"].ToString();

                string queryP = "SELECT MaPhien, GiaHienTai FROM PhienDauGia WHERE MaSP = @MaSP AND TrangThaiPhien = 1";
                SqlParameter[] p2 = { new SqlParameter("@MaSP", maSP) };
                DataTable dtP = db.ExecuteQuery(queryP, p2);

                if (dtP.Rows.Count > 0)
                {
                    maPhienHienTai = Convert.ToInt32(dtP.Rows[0]["MaPhien"]);
                    txtGiaHienTai.Text = dtP.Rows[0]["GiaHienTai"].ToString();
                    LoadLichSuTraGia(maPhienHienTai);
                }
                else
                {
                    maPhienHienTai = -1;
                    txtGiaHienTai.Text = "Chưa bắt đầu";
                    dgvLichSuGia.DataSource = null;
                }
            }
        }

        private void LoadLichSuTraGia(int maPhien)
        {
            string query = @"SELECT ls.ThoiGianTra AS [Thời Gian], kh.HoTen AS [Khách Hàng], ls.SoTienTra AS [Mức Giá Trả] 
                            FROM LichSuDauGia ls
                            JOIN KhachHang kh ON ls.MaKH = kh.MaKH
                            WHERE ls.MaPhien = @MaPhien
                            ORDER BY ls.ThoiGianTra DESC";
            SqlParameter[] p = { new SqlParameter("@MaPhien", maPhien) };
            dgvLichSuGia.DataSource = db.ExecuteQuery(query, p);
        }

        private void btnBatDauPhien_Click(object sender, EventArgs e)
        {
            if (cboSanPhamDG.SelectedValue == null) return;
            int maSP = (int)cboSanPhamDG.SelectedValue;

            decimal.TryParse(txtGiaKhoiDiem.Text, out decimal giaKhoiDiem);

            string queryTaoPhien = @"INSERT INTO PhienDauGia (MaSP, GiaKhoiDiem, ThoiGianBatDau, ThoiGianKetThuc, GiaHienTai, TrangThaiPhien) 
                                    VALUES (@MaSP, @GiaGoc, GETDATE(), DATEADD(hour, 2, GETDATE()), @GiaGoc, 1)";
            SqlParameter[] p1 = { new SqlParameter("@MaSP", maSP), new SqlParameter("@GiaGoc", giaKhoiDiem) };

            string queryUpdateSP = "UPDATE SanPham SET TrangThai = N'Đang đấu giá' WHERE MaSP = @MaSP";
            SqlParameter[] p2 = { new SqlParameter("@MaSP", maSP) };

            db.ExecuteNonQuery(queryTaoPhien, p1);
            db.ExecuteNonQuery(queryUpdateSP, p2);

            MessageBox.Show("Đã mở phiên đấu giá cho sản phẩm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LayThongTinSanPhamHienTai(maSP);
        }

        private void btnGhiNhanGia_Click(object sender, EventArgs e)
        {
            if (maPhienHienTai == -1)
            {
                MessageBox.Show("Phiên đấu giá chưa được bắt đầu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtTienTraGia.Text, out decimal tienTra) || tienTra <= 0)
            {
                MessageBox.Show("Số tiền trả giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal.TryParse(txtGiaHienTai.Text, out decimal giaHienTai);
            if (tienTra <= giaHienTai)
            {
                MessageBox.Show("Giá trả mới phải cao hơn Giá hiện tại!", "Quy tắc đấu giá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string queryLog = "INSERT INTO LichSuDauGia (MaPhien, MaKH, SoTienTra, ThoiGianTra) VALUES (@MaPhien, @MaKH, @SoTien, GETDATE())";
            SqlParameter[] p1 = {
                new SqlParameter("@MaPhien", maPhienHienTai),
                new SqlParameter("@MaKH", cboKhachHang.SelectedValue),
                new SqlParameter("@SoTien", tienTra)
            };

            string queryUpdatePhien = "UPDATE PhienDauGia SET GiaHienTai = @SoTien, MaNguoiGiaCaoNhat = @MaKH WHERE MaPhien = @MaPhien";
            SqlParameter[] p2 = {
                new SqlParameter("@SoTien", tienTra),
                new SqlParameter("@MaKH", cboKhachHang.SelectedValue),
                new SqlParameter("@MaPhien", maPhienHienTai)
            };

            db.ExecuteNonQuery(queryLog, p1);
            db.ExecuteNonQuery(queryUpdatePhien, p2);

            MessageBox.Show("Ghi nhận lượt trả giá thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtGiaHienTai.Text = tienTra.ToString();
            txtTienTraGia.Clear();
            LoadLichSuTraGia(maPhienHienTai);
        }

        private void btnKetThucPhien_Click(object sender, EventArgs e)
        {
            if (maPhienHienTai == -1) return;

            int maSP = (int)cboSanPhamDG.SelectedValue;

            string queryDongPhien = "UPDATE PhienDauGia SET TrangThaiPhien = 0 WHERE MaPhien = @MaPhien";
            SqlParameter[] p1 = { new SqlParameter("@MaPhien", maPhienHienTai) };

            string queryBanSP = "UPDATE SanPham SET TrangThai = N'Đã bán' WHERE MaSP = @MaSP";
            SqlParameter[] p2 = { new SqlParameter("@MaSP", maSP) };

            db.ExecuteNonQuery(queryDongPhien, p1);
            db.ExecuteNonQuery(queryBanSP, p2);

            MessageBox.Show("Đã đóng phiên! Đồ cổ này đã chính thức thuộc về người trả giá cao nhất hiển thị trên màn hình.", "Kết thúc", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadComboBoxSanPham();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}