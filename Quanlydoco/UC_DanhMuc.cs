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
    public partial class UC_DanhMuc : UserControl
    {
        private DatabaseHelper db = new DatabaseHelper();
        public UC_DanhMuc()
        {
            InitializeComponent();
        }
        private void TaiDuLieu()
        {
            string query = "SELECT MaDM AS [Mã Danh Mục], TenDanhMuc AS [Tên Danh Mục] FROM DanhMuc";
            DataTable dt = db.ExecuteQuery(query);
            dgvDanhMuc.DataSource = dt;
        }
        private void UC_DanhMuc_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDanhMuc.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO DanhMuc (TenDanhMuc) VALUES (@TenDM)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDM", txtTenDanhMuc.Text.Trim())
            };

            int kq = db.ExecuteNonQuery(query, parameters);
            if (kq > 0)
            {
                MessageBox.Show("Thêm danh mục thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu(); 
                btnLamMoi_Click(null, null); 
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDM.Clear();
            txtTenDanhMuc.Clear();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDM.Text))
            {
                MessageBox.Show("Vui lòng chọn danh mục cần sửa từ bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtTenDanhMuc.Text.Trim()))
            {
                MessageBox.Show("Tên danh mục không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE DanhMuc SET TenDanhMuc = @TenDM WHERE MaDM = @MaDM";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDM", txtTenDanhMuc.Text.Trim()),
                new SqlParameter("@MaDM", txtMaDM.Text)
            };

            int kq = db.ExecuteNonQuery(query, parameters);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật danh mục thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu();
                btnLamMoi_Click(null, null);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDM.Text))
            {
                MessageBox.Show("Vui lòng chọn danh mục cần xóa từ bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này? Điều này có thể ảnh hưởng đến các sản phẩm thuộc danh mục!", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string query = "DELETE FROM DanhMuc WHERE MaDM = @MaDM";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaDM", txtMaDM.Text)
                };

                int kq = db.ExecuteNonQuery(query, parameters);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa danh mục thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDuLieu();
                    btnLamMoi_Click(null, null);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhMuc.Rows[e.RowIndex];
                txtMaDM.Text = row.Cells["Mã Danh Mục"].Value.ToString();
                txtTenDanhMuc.Text = row.Cells["Tên Danh Mục"].Value.ToString();
            }
        }
    }
}
