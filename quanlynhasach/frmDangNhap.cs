using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using static quanlynhasach.frmMain;
using static quanlynhasach.frmTrangChu;
namespace quanlynhasach
{
    public partial class frmDangNhap : Form
    {
        public static string UserID;
        public static string VaiTro;
        private string connectionString = "Data Source=nha_sach.db;";

        public frmDangNhap()
        {
            InitializeComponent();
            txtMatKhau.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "" | txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tenDN = txtTenDN.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();

                using var connection = new SqliteConnection(connectionString);
                connection.Open();

                string sql = "SELECT HoTen, VaiTro FROM NguoiDung WHERE TenDN = @TenDN AND MatKhau = @MatKhau";
                using var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@TenDN", tenDN);
                command.Parameters.AddWithValue("@MatKhau", matKhau);

                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string hoTen = reader.GetString(0);
                    string vaiTroDB = reader.GetString(1);

                    frmMain mainForm = (frmMain)Application.OpenForms["frmMain"];
                    mainForm.LoadFormConVaoPanel(new frmTrangChu());
                    mainForm.labelbDangXuat.Visible = true;
                    UserID = tenDN;
                    VaiTro = vaiTroDB == "QuanTri" ? "--- QUẢN TRỊ ---" : "--- NHÂN VIÊN ---";

                    frmTrangChu TrangChuForm = (frmTrangChu)Application.OpenForms["frmTrangChu"];

                    TrangChuForm.labelName.Text = hoTen;

                    if (vaiTroDB == "QuanTri")
                    {
                        mainForm.labelTieuDe.Text = "       QUẢN LÝ NHÀ SÁCH | Bạn đang đăng nhập với tư cách " + VaiTro + " : " + hoTen;
                        TrangChuForm.tableLayoutPanelMenu.Controls.Remove(TrangChuForm.tableLayoutPanelMenu.GetControlFromPosition(0, 11));
                        TrangChuForm.tableLayoutPanelMenu.Controls.Add(TrangChuForm.buttonNguoiDung, 0, 11);
                        TrangChuForm.buttonGioiThieu.Visible = false;
                        TrangChuForm.buttonNguoiDung.Visible = true;
                        TrangChuForm.buttonBaoCaoTon.Enabled = true;
                        TrangChuForm.buttonBaoCaoCongNo.Enabled = true;
                    }
                    else
                    {
                        mainForm.labelTieuDe.Text = "       QUẢN LÝ NHÀ SÁCH | Bạn đang đăng nhập với tư cách " + VaiTro + " : " + hoTen;
                        TrangChuForm.tableLayoutPanelMenu.Controls.Remove(TrangChuForm.tableLayoutPanelMenu.GetControlFromPosition(0, 11));
                        TrangChuForm.tableLayoutPanelMenu.Controls.Add(TrangChuForm.buttonGioiThieu, 0, 11);
                        TrangChuForm.buttonGioiThieu.Visible = true;
                        TrangChuForm.buttonNguoiDung.Visible = false;
                        TrangChuForm.buttonBaoCaoTon.Enabled = false;
                        TrangChuForm.buttonBaoCaoCongNo.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnHide.Visible = true;
            btnShow.Visible = false;
            txtMatKhau.PasswordChar = '\0';
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnHide.Visible = false;
            btnShow.Visible = true;
            txtMatKhau.PasswordChar = '*';
        }

        private void txtTenDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
