using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static quanlynhasach.frmDoiMK;

namespace quanlynhasach
{
    public partial class frmTrangChu : Form
    {

        private string connectionString = "Data Source=nha_sach.db;";
        public Label labelName => lbName;
        public TableLayoutPanel tableLayoutPanelMenu => tlpMenu;
        public Button buttonGioiThieu => btnGioiThieu;
        public Button buttonNguoiDung => btnNguoiDung;
        public Button buttonBaoCaoTon => btnBaoCaoTon;
        public Button buttonBaoCaoCongNo => btnBaocaoCongNo;


        public frmTrangChu()
        {
            InitializeComponent();
        }
        private void LoadPhieuNhap()
        {
            string query = @"SELECT pn.MaPN, pn.NgayNhap, pn.NguoiLap, 
                            SUM(ct.SoLuong * ct.DonGiaNhap) AS TongTien
                     FROM PhieuNhap pn
                     LEFT JOIN CTPhieuNhap ct ON pn.MaPN = ct.MaPN
                     GROUP BY pn.MaPN, pn.NgayNhap, pn.NguoiLap";
            DataTable dt = new DataTable();
            using (var conn = new Microsoft.Data.Sqlite.SqliteConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            dgv.Visible = true;
            dgv.Columns.Clear();
            dgv.AutoGenerateColumns = true;
            dgv.DataSource = dt;

        }

        private void LoadHoaDon()
        {
            using (var conn = new Microsoft.Data.Sqlite.SqliteConnection("Data Source=nha_sach.db"))
            {
                conn.Open();
                string query = @"
                    SELECT hd.MaHD, hd.MaKH, hd.NgayLap, hd.NguoiLap,
                           IFNULL(SUM(ct.SoLuong * ct.DonGia), 0) AS TongTien
                    FROM HoaDon hd
                    LEFT JOIN CTHoaDon ct ON hd.MaHD = ct.MaHD
                    GROUP BY hd.MaHD, hd.MaKH, hd.NgayLap, hd.NguoiLap
                ";
                var dt = new DataTable();
                using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                dgv.DataSource = dt;
            }
        }

        public void LoadFormConVaoPanel(Form formCon)
        {
            pBody.Controls.Clear();
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            pBody.Controls.Add(formCon);
            pBody.Tag = formCon;
            formCon.Show();
        }
        public void LoadControl_HD(Panel pControl, DataGridView dgv)
        {
            pBody.Controls.Clear();
            pBody.Controls.Add(dgv);      // Add dgv trước
            pBody.Controls.Add(pControl);
            LoadHoaDon();

        }

        public void LoadControl_PN(Panel pControl, DataGridView dgv)
        {
            pBody.Controls.Clear();
            pBody.Controls.Add(dgv);      // Add dgv trước
            pBody.Controls.Add(pControl);
            LoadPhieuNhap();
        }
        private void DoiMauKhiChon(Button nutDuocChon)
        {
            foreach (Control control in tlpMenu.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = ColorTranslator.FromHtml("#507DBC");
                    btn.ForeColor = ColorTranslator.FromHtml("#DAE3E5");

                }
            }

            nutDuocChon.BackColor = ColorTranslator.FromHtml("#04080F");
            nutDuocChon.ForeColor = ColorTranslator.FromHtml("#DAE3E5");

        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            LoadFormConVaoPanel(new frmGioiThieu());
        }


        private void btnSach_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmSach());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmKhachHang());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadControl_PN(pNav, dgv);
            lbTenChucNang.Text = "DANH SÁCH HÓA ĐƠN";
            LoadHoaDon(); // Load dữ liệu hóa đơn
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadControl_PN(pNav, dgv);
            lbTenChucNang.Text = "DANH SÁCH PHIẾU NHẬP SÁCH";
            LoadPhieuNhap(); // Load dữ liệu phiếu nhập


        }

        private void btnThuTien_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmThuTien());

        }

        private void btnBaoCaoTon_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmBaoCaoTon());

        }


        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmTheLoai());

        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmTacGia());

        }

        private void btnBaocaoCongNo_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmBaoCaoCongNo());

        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmNguoiDung());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lbTenChucNang.Text == "DANH SÁCH HÓA ĐƠN")
            {
                frmHoaDon frmHoaDon = new frmHoaDon();
                frmHoaDon.ShowDialog();
                LoadHoaDon();
            }
            else if (lbTenChucNang.Text == "DANH SÁCH PHIẾU NHẬP SÁCH")
            {
                frmPhieuNhapSach frmPhieuNhapSach = new frmPhieuNhapSach();
                frmPhieuNhapSach.ShowDialog();
                LoadPhieuNhap();
            }
            else
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lbTenChucNang.Text == "DANH SÁCH HÓA ĐƠN" && dgv.CurrentRow != null)
            {
                string maHD = dgv.CurrentRow.Cells["MaHD"].Value.ToString();
                frmHoaDon frm = new frmHoaDon(maHD);
                frm.ShowDialog();
                LoadHoaDon();
            }
            else if (lbTenChucNang.Text == "DANH SÁCH PHIẾU NHẬP SÁCH" && dgv.CurrentRow != null)
            {
                string maPN = dgv.CurrentRow.Cells["MaPN"].Value.ToString();
                frmPhieuNhapSach frm = new frmPhieuNhapSach(maPN);
                frm.ShowDialog();
                LoadPhieuNhap();
            }
            else
            {

            }
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmGioiThieu());
        }

        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            frmCauHinh frmCauHinh = new frmCauHinh();
            frmCauHinh.ShowDialog();
        }
        private void btnDoiMK_Click(object sender, EventArgs e)
        {

            string tenDangNhap = frmDangNhap.UserID;
            frmDoiMK frmDoiMK = new frmDoiMK(tenDangNhap);
            frmDoiMK.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lbTenChucNang.Text == "DANH SÁCH PHIẾU NHẬP SÁCH" && dgv.CurrentRow != null)
            {
                string maPN = dgv.CurrentRow.Cells["MaPN"].Value.ToString();
                if (string.IsNullOrEmpty(maPN))
                {
                    MessageBox.Show("Không có mã phiếu nhập để xóa.");
                    return;
                }

                using (var conn = new Microsoft.Data.Sqlite.SqliteConnection(connectionString))
                {
                    conn.Open();

                    // Lấy danh sách các mã sách trong phiếu nhập này
                    var maSachList = new List<string>();
                    using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand("SELECT MaSach FROM CTPhieuNhap WHERE MaPN = @MaPN", conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPN", maPN);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                                maSachList.Add(reader["MaSach"].ToString());
                        }
                    }

                    // Kiểm tra có hóa đơn liên quan không
                    bool coHoaDonLienQuan = false;
                    foreach (var maSach in maSachList)
                    {
                        using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand("SELECT COUNT(*) FROM CTHoaDon WHERE MaSach = @MaSach", conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSach", maSach);
                            var count = Convert.ToInt32(cmd.ExecuteScalar());
                            if (count > 0)
                            {
                                coHoaDonLienQuan = true;
                                break;
                            }
                        }
                    }

                    if (coHoaDonLienQuan)
                    {
                        var result = MessageBox.Show(
                            "Có hóa đơn liên quan đến các sản phẩm trong phiếu nhập này. Nếu tiếp tục xóa, tất cả các hóa đơn và chi tiết hóa đơn liên quan sẽ bị xóa!\nBạn có chắc chắn muốn tiếp tục?",
                            "Cảnh báo xóa dữ liệu liên quan",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (result != DialogResult.Yes)
                            return;

                        // Xóa tất cả các chi tiết hóa đơn liên quan đến các mã sách này
                        foreach (var maSach in maSachList)
                        {
                            using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand("DELETE FROM CTHoaDon WHERE MaSach = @MaSach", conn))
                            {
                                cmd.Parameters.AddWithValue("@MaSach", maSach);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Xóa các hóa đơn không còn chi tiết nào
                        using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand(
                            @"DELETE FROM HoaDon WHERE MaHD NOT IN (SELECT MaHD FROM CTHoaDon)", conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Xóa chi tiết phiếu nhập
                    using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand("DELETE FROM CTPhieuNhap WHERE MaPN = @MaPN", conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPN", maPN);
                        cmd.ExecuteNonQuery();
                    }

                    // Xóa phiếu nhập
                    using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand("DELETE FROM PhieuNhap WHERE MaPN = @MaPN", conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPN", maPN);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Đã xóa phiếu nhập và các dữ liệu liên quan!");
                LoadPhieuNhap();
            }

            if (lbTenChucNang.Text == "DANH SÁCH HÓA ĐƠN" && dgv.CurrentRow != null)
            {
                string maHD = dgv.CurrentRow.Cells["MaHD"].Value.ToString();
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var conn = new Microsoft.Data.Sqlite.SqliteConnection("Data Source=nha_sach.db"))
                    {
                        conn.Open();
                        using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand("DELETE FROM CTHoaDon WHERE MaHD = @MaHD", conn))
                        {
                            cmd.Parameters.AddWithValue("@MaHD", maHD);
                            cmd.ExecuteNonQuery();
                        }
                        using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand("DELETE FROM HoaDon WHERE MaHD = @MaHD", conn))
                        {
                            cmd.Parameters.AddWithValue("@MaHD", maHD);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Đã xóa hóa đơn!");
                    LoadHoaDon();
                }
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
