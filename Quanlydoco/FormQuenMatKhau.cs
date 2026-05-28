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
    public partial class FormQuenMatKhau : Form
    {
        public FormQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) ||
                string.IsNullOrEmpty(txtMatKhauMoi.Text) ||
                string.IsNullOrEmpty(txtNhapLai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMatKhauMoi.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMatKhauMoi.Text.Length > 50)
            {
                MessageBox.Show("Mật khẩu không được vượt quá 50 ký tự!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DatabaseHelper db = new DatabaseHelper();

            string checkQuery = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @User";
            SqlParameter[] checkParams = { new SqlParameter("@User", txtTenDangNhap.Text.Trim()) };
            DataTable dt = db.ExecuteQuery(checkQuery, checkParams);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Tên đăng nhập không tồn tại!", "Thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string updateQuery = "UPDATE TaiKhoan SET MatKhau = @NewPass WHERE TenDangNhap = @User";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@NewPass", txtMatKhauMoi.Text.Trim()),
                new SqlParameter("@User",    txtTenDangNhap.Text.Trim())
            };
            db.ExecuteNonQuery(updateQuery, updateParams);

            MessageBox.Show("Đổi mật khẩu thành công!", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
