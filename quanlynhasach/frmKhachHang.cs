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

namespace quanlynhasach
{
    public partial class frmKhachHang : Form
    {
        private SqliteConnection conn;
        private DataTable dtKhachHang;

        public frmKhachHang()
        {
            InitializeComponent();
            ConnectDatabase();
            LoadKhachHang();
            cbTimKiem.Items.Clear();
            cbTimKiem.Items.Add("Mã khách hàng");
            cbTimKiem.Items.Add("Họ tên");
            cbTimKiem.Items.Add("Điện thoại");
            cbTimKiem.SelectedIndex = 0;
        }

        private void ConnectDatabase()
        {
            conn = new SqliteConnection("Data Source=nha_sach.db");
            conn.Open();
        }

        private void LoadKhachHang()
        {
            string query = "SELECT MaKH, HoTen, DienThoai, DiaChi, Email FROM KhachHang";
            dtKhachHang = new DataTable();
            using (var cmd = new SqliteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                dtKhachHang.Load(reader);
            }
            dgvKhachHang.DataSource = dtKhachHang;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (dtKhachHang == null) return;
            string filter = txtTimKiem.Text.Trim();
            string col = "MaKH";
            switch (cbTimKiem.SelectedIndex)
            {
                case 0: col = "MaKH"; break;
                case 1: col = "HoTen"; break;
                case 2: col = "DienThoai"; break;
            }
            if (string.IsNullOrEmpty(filter))
            {
                dgvKhachHang.DataSource = dtKhachHang;
            }
            else
            {
                DataView dv = dtKhachHang.DefaultView;
                dv.RowFilter = $"{col} LIKE '%{filter}%'";
                dgvKhachHang.DataSource = dv.ToTable();
            }
        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem_TextChanged(sender, e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = txtMa.Text.Trim();
            string HoTen = txtTen.Text.Trim();
            string DienThoai = txtDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (maKH == "" || HoTen == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.");
                return;
            }

            string sql = "INSERT INTO KhachHang (MaKH, HoTen, DienThoai, DiaChi, Email) VALUES (@MaKH, @HoTen, @DienThoai, @DiaChi, @Email)";
            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@Email", email);
                try
                {
                    cmd.ExecuteNonQuery();
                    LoadKhachHang();
                    MessageBox.Show("Thêm khách hàng thành công!");
                }
                catch
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMa.Text.Trim();
            string HoTen = txtTen.Text.Trim();
            string DienThoai = txtDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (maKH == "" || HoTen == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.");
                return;
            }

            string sql = "UPDATE KhachHang SET HoTen = @HoTen, DienThoai = @DienThoai, DiaChi = @DiaChi, Email = @Email WHERE MaKH = @MaKH";
            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@Email", email);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    LoadKhachHang();
                    MessageBox.Show("Sửa khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã khách hàng!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMa.Text.Trim();
            if (maKH == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng cần xóa.");
                return;
            }

            // Cảnh báo người dùng về việc xóa liên quan
            var result = MessageBox.Show(
                "Nếu xóa khách hàng này, tất cả các hóa đơn và chi tiết hóa đơn liên quan cũng sẽ bị xóa!\nBạn có chắc chắn muốn tiếp tục?",
                "Cảnh báo xóa dữ liệu liên quan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            // Lấy danh sách các mã hóa đơn của khách hàng này
            var maHDList = new List<string>();
            using (var cmd = new SqliteCommand("SELECT MaHD FROM HoaDon WHERE MaKH = @MaKH", conn))
            {
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        maHDList.Add(reader["MaHD"].ToString());
                }
            }

            // Xóa chi tiết hóa đơn liên quan đến từng hóa đơn
            foreach (var maHD in maHDList)
            {
                using (var cmd = new SqliteCommand("DELETE FROM CTHoaDon WHERE MaHD = @MaHD", conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.ExecuteNonQuery();
                }
            }

            // Xóa hóa đơn của khách hàng
            using (var cmd = new SqliteCommand("DELETE FROM HoaDon WHERE MaKH = @MaKH", conn))
            {
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.ExecuteNonQuery();
            }

            // Xóa khách hàng
            using (var cmd = new SqliteCommand("DELETE FROM KhachHang WHERE MaKH = @MaKH", conn))
            {
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    LoadKhachHang();
                    MessageBox.Show("Xóa khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã khách hàng!");
                }
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMa.Text = dgvKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                txtTen.Text = dgvKhachHang.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                txtDienThoai.Text = dgvKhachHang.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtEmail.Text = dgvKhachHang.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            }
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }
    }
}
