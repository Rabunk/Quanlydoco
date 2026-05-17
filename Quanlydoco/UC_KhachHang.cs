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
    public partial class UC_KhachHang : UserControl
    {
        private DatabaseHelper db = new DatabaseHelper();
        public UC_KhachHang()
        {
            InitializeComponent();
        }
        private void TaiDuLieu()
        {
            string query = "SELECT MaKH AS [Mã KH], HoTen AS [Họ Tên], SoDienThoai AS [SĐT], Email, DiaChi AS [Địa Chỉ] FROM KhachHang";
            dgvKhachHang.DataSource = db.ExecuteQuery(query);
        }
        private void UC_KhachHang_Load(object sender, EventArgs e) { TaiDuLieu(); }

        private bool ExistsPhone(string phone, int? excludeId = null)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;
            string q = "SELECT COUNT(*) AS cnt FROM KhachHang WHERE SoDienThoai = @SDT";
            if (excludeId != null) q += " AND MaKH <> @Ma";
            var parameters = excludeId != null
                ? new SqlParameter[] { new SqlParameter("@SDT", phone), new SqlParameter("@Ma", excludeId.Value) }
                : new SqlParameter[] { new SqlParameter("@SDT", phone) };
            DataTable dt = db.ExecuteQuery(q, parameters);
            return dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["cnt"]) > 0;
        }

        private bool ExistsEmail(string email, int? excludeId = null)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            string q = "SELECT COUNT(*) AS cnt FROM KhachHang WHERE Email = @Mail";
            if (excludeId != null) q += " AND MaKH <> @Ma";
            var parameters = excludeId != null
                ? new SqlParameter[] { new SqlParameter("@Mail", email), new SqlParameter("@Ma", excludeId.Value) }
                : new SqlParameter[] { new SqlParameter("@Mail", email) };
            DataTable dt = db.ExecuteQuery(q, parameters);
            return dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["cnt"]) > 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtSDT.Text) && ExistsPhone(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && ExistsEmail(txtEmail.Text))
            {
                MessageBox.Show("Email đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO KhachHang (HoTen, SoDienThoai, Email, DiaChi) VALUES (@Ten, @SDT, @Mail, @DC)";
            SqlParameter[] p = {
                new SqlParameter("@Ten", txtHoTen.Text.Trim()),
                new SqlParameter("@SDT", string.IsNullOrWhiteSpace(txtSDT.Text) ? (object)DBNull.Value : txtSDT.Text.Trim()),
                new SqlParameter("@Mail", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text.Trim()),
                new SqlParameter("@DC", string.IsNullOrWhiteSpace(txtDiaChi.Text) ? (object)DBNull.Value : txtDiaChi.Text.Trim())
            };
            if (db.ExecuteNonQuery(query, p) > 0) { TaiDuLieu(); LamMoi(); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa từ bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int.TryParse(txtMaKH.Text, out int maKH);

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Tên khách không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtSDT.Text) && ExistsPhone(txtSDT.Text, maKH))
            {
                MessageBox.Show("Số điện thoại đã tồn tại (khách hàng khác)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && ExistsEmail(txtEmail.Text, maKH))
            {
                MessageBox.Show("Email đã tồn tại (khách hàng khác)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE KhachHang SET HoTen=@Ten, SoDienThoai=@SDT, Email=@Mail, DiaChi=@DC WHERE MaKH=@Ma";
            SqlParameter[] p = {
                new SqlParameter("@Ten", txtHoTen.Text.Trim()),
                new SqlParameter("@SDT", string.IsNullOrWhiteSpace(txtSDT.Text) ? (object)DBNull.Value : txtSDT.Text.Trim()),
                new SqlParameter("@Mail", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text.Trim()),
                new SqlParameter("@DC", string.IsNullOrWhiteSpace(txtDiaChi.Text) ? (object)DBNull.Value : txtDiaChi.Text.Trim()),
                new SqlParameter("@Ma", txtMaKH.Text)
            };
            if (db.ExecuteNonQuery(query, p) > 0) { TaiDuLieu(); }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text)) return;
            if (db.ExecuteNonQuery("DELETE FROM KhachHang WHERE MaKH=" + txtMaKH.Text) > 0) TaiDuLieu();
        }

        private void LamMoi() { txtMaKH.Clear(); txtHoTen.Clear(); txtSDT.Clear(); txtEmail.Clear(); txtDiaChi.Clear(); }
        private void btnLamMoi_Click(object sender, EventArgs e) => LamMoi();

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = r.Cells[0].Value.ToString();
                txtHoTen.Text = r.Cells[1].Value.ToString();
                txtSDT.Text = r.Cells[2].Value.ToString();
                txtEmail.Text = r.Cells[3].Value.ToString();
                txtDiaChi.Text = r.Cells[4].Value.ToString();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
