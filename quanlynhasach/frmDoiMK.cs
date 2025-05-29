using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace quanlynhasach
{
    public partial class frmDoiMK : Form
    {
        private string tenDN;
        private string connectionString = "Data Source=nha_sach.db;";


        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        public frmDoiMK(string tenDangNhap)
        {
            InitializeComponent();
            tenDN = tenDangNhap;
        }

        private void cbHien_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHien.Checked == true)
            {
                txtMatKhauCu.PasswordChar = '\0';
                txtMatKhauMoi.PasswordChar = '\0';
                txtRe_MatKhauMoi.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauCu.PasswordChar = '*';
                txtMatKhauMoi.PasswordChar = '*';
                txtRe_MatKhauMoi.PasswordChar = '*';
            }

        }

        private void txtTenDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtMatKhauCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtMatKhauMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtRe_MatKhauMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text.Trim() != tenDN)
            {
                MessageBox.Show("Tên đăng nhập không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMatKhauMoi.Text.Trim() != txtRe_MatKhauMoi.Text.Trim())
            {
                MessageBox.Show("Mật khẩu mới không khớp nhau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            string sqlCheck = "SELECT COUNT(*) FROM NguoiDung WHERE TenDN = @TenDN AND MatKhau = @MatKhauCu";
            using var cmdCheck = new SqliteCommand(sqlCheck, connection);
            cmdCheck.Parameters.AddWithValue("@TenDN", tenDN);
            cmdCheck.Parameters.AddWithValue("@MatKhauCu", txtMatKhauCu.Text.Trim());

            long userCount = (long)cmdCheck.ExecuteScalar();

            if (userCount == 0)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sqlUpdate = "UPDATE NguoiDung SET MatKhau = @MatKhauMoi WHERE TenDN = @TenDN";
            using var cmdUpdate = new SqliteCommand(sqlUpdate, connection);
            cmdUpdate.Parameters.AddWithValue("@MatKhauMoi", txtMatKhauMoi.Text.Trim());
            cmdUpdate.Parameters.AddWithValue("@TenDN", tenDN);

            int rowsAffected = cmdUpdate.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
