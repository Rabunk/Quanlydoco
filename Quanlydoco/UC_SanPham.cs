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
    public partial class UC_SanPham : UserControl
    {
        private DatabaseHelper db = new DatabaseHelper();
        public UC_SanPham()
        {
            InitializeComponent();
        }
        private void TaiDuLieu()
        {
            string query = @"SELECT sp.MaSP AS [Mã SP], sp.TenSP AS [Tên Sản Phẩm], dm.TenDanhMuc AS [Danh Mục], 
                            sp.NamSanXuat AS [Năm SX], sp.DoHiem AS [Độ Hiếm], sp.GiaBanThuong AS [Giá Bán Thường], 
                            sp.TrangThai AS [Trạng Thái], sp.MoTa AS [Mô Tả]
                            FROM SanPham sp 
                            LEFT JOIN DanhMuc dm ON sp.MaDM = dm.MaDM";

            DataTable dt = db.ExecuteQuery(query);
            dgvSanPham.DataSource = dt;
        }
        private void UC_SanPham_Load(object sender, EventArgs e)
        {
            LoadComboBoxDanhMuc();
            TaiDuLieu();
            cboDoHiem.SelectedIndex = 0; 
        }
        private void LoadComboBoxDanhMuc()
        {
            string query = "SELECT MaDM, TenDanhMuc FROM DanhMuc";
            DataTable dt = db.ExecuteQuery(query);

            cboDanhMuc.DataSource = dt;
            cboDanhMuc.DisplayMember = "TenDanhMuc"; 
            cboDanhMuc.ValueMember = "MaDM";         
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (cboDanhMuc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng tạo và chọn Danh mục cho sản phẩm trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboDoHiem.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mức độ Độ hiếm cho sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtTenSP.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm cổ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"INSERT INTO SanPham (TenSP, MaDM, NamSanXuat, MoTa, DoHiem, GiaBanThuong, TrangThai) 
                            VALUES (@TenSP, @MaDM, @NamSX, @MoTa, @DoHiem, @GiaBan, N'Sẵn sàng')";

            int.TryParse(txtNamSX.Text, out int namSX);
            decimal.TryParse(txtGiaBan.Text, out decimal giaBan);

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenSP", txtTenSP.Text.Trim()),
                new SqlParameter("@MaDM", cboDanhMuc.SelectedValue), 
                new SqlParameter("@NamSX", namSX > 0 ? (object)namSX : DBNull.Value),
                new SqlParameter("@MoTa", txtMoTa.Text.Trim()),
                new SqlParameter("@DoHiem", cboDoHiem.SelectedItem.ToString()),
                new SqlParameter("@GiaBan", giaBan > 0 ? (object)giaBan : DBNull.Value)
            };

            if (db.ExecuteNonQuery(query, parameters) > 0)
            {
                MessageBox.Show("Thêm đồ cổ thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu();
                btnLamMoi_Click(null, null);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa từ bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"UPDATE SanPham 
                            SET TenSP = @TenSP, MaDM = @MaDM, NamSanXuat = @NamSX, 
                                MoTa = @MoTa, DoHiem = @DoHiem, GiaBanThuong = @GiaBan 
                            WHERE MaSP = @MaSP";

            int.TryParse(txtNamSX.Text, out int namSX);
            decimal.TryParse(txtGiaBan.Text, out decimal giaBan);

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenSP", txtTenSP.Text.Trim()),
                new SqlParameter("@MaDM", cboDanhMuc.SelectedValue),
                new SqlParameter("@NamSX", namSX > 0 ? (object)namSX : DBNull.Value),
                new SqlParameter("@MoTa", txtMoTa.Text.Trim()),
                new SqlParameter("@DoHiem", cboDoHiem.SelectedItem.ToString()),
                new SqlParameter("@GiaBan", giaBan > 0 ? (object)giaBan : DBNull.Value),
                new SqlParameter("@MaSP", txtMaSP.Text)
            };

            if (db.ExecuteNonQuery(query, parameters) > 0)
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu();
                btnLamMoi_Click(null, null);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa từ bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm cổ này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string query = "DELETE FROM SanPham WHERE MaSP = @MaSP";
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@MaSP", txtMaSP.Text) };

                if (db.ExecuteNonQuery(query, parameters) > 0)
                {
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDuLieu();
                    btnLamMoi_Click(null, null);
                }
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtNamSX.Clear();
            txtGiaBan.Clear();
            txtMoTa.Clear();
            if (cboDanhMuc.Items.Count > 0) cboDanhMuc.SelectedIndex = 0;
            cboDoHiem.SelectedIndex = 0;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells["Mã SP"].Value.ToString();
                txtTenSP.Text = row.Cells["Tên Sản Phẩm"].Value.ToString();
                txtNamSX.Text = row.Cells["Năm SX"].Value.ToString();
                txtGiaBan.Text = row.Cells["Giá Bán Thường"].Value.ToString();
                txtMoTa.Text = row.Cells["Mô Tả"].Value.ToString();

                cboDanhMuc.Text = row.Cells["Danh Mục"].Value.ToString();
                cboDoHiem.Text = row.Cells["Độ Hiếm"].Value.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cboDoHiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
