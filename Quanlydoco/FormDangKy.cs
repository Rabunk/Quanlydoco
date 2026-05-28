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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) ||
                string.IsNullOrEmpty(txtHoTen.Text) ||
                string.IsNullOrEmpty(txtMatKhau.Text) ||
                string.IsNullOrEmpty(txtNhapLai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMatKhau.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTenDangNhap.Text.Length > 50)
            {
                MessageBox.Show("Tên đăng nhập không được vượt quá 50 ký tự!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMatKhau.Text.Length > 50)
            {
                MessageBox.Show("Mật khẩu không được vượt quá 50 ký tự!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DatabaseHelper db = new DatabaseHelper();

            string checkQuery = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @User";
            SqlParameter[] checkParams = { new SqlParameter("@User", txtTenDangNhap.Text.Trim()) };
            DataTable dt = db.ExecuteQuery(checkQuery, checkParams);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tên đăng nhập này đã tồn tại!", "Thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string insertQuery = @"INSERT INTO TaiKhoan (TenDangNhap, MatKhau, HoTen, Quyen) 
                           VALUES (@User, @Pass, @HoTen, N'NguoiDung')";
            SqlParameter[] insertParams =
            {
                new SqlParameter("@User",  txtTenDangNhap.Text.Trim()),
                new SqlParameter("@Pass",  txtMatKhau.Text.Trim()),
                new SqlParameter("@HoTen", txtHoTen.Text.Trim())
            };
            db.ExecuteNonQuery(insertQuery, insertParams);

            MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập.", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
