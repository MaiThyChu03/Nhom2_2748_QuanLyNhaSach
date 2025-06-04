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
    public partial class frmTacGia : Form
    {
        private SqliteConnection conn;
        private DataTable dtTacGia;

        public frmTacGia()
        {
            InitializeComponent();
            ConnectDatabase();
            LoadTacGia();
        }

        private void ConnectDatabase()
        {
            conn = new SqliteConnection("Data Source=nha_sach.db");
            conn.Open();
        }

        private void LoadTacGia()
        {
            string query = "SELECT MaTG, TenTG FROM TacGia";
            dtTacGia = new DataTable();
            using (var cmd = new SqliteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                dtTacGia.Load(reader);
            }
            dgvTacGia.DataSource = dtTacGia;
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            // Khởi tạo ComboBox tìm kiếm
            cbTimKiem.Items.Clear();
            cbTimKiem.Items.Add("Mã tác giả");
            cbTimKiem.Items.Add("Tên tác giả");
            cbTimKiem.SelectedIndex = 0; // Mặc định tìm theo mã
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtTimKiem.Clear();
            LoadTacGia();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maTG = txtMa.Text.Trim();
            string tenTG = txtTen.Text.Trim();
            if (maTG == "" || tenTG == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            string sql = "INSERT INTO TacGia (MaTG, TenTG) VALUES (@MaTG, @TenTG)";
            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaTG", maTG);
                cmd.Parameters.AddWithValue("@TenTG", tenTG);
                try
                {
                    cmd.ExecuteNonQuery();
                    LoadTacGia();
                    MessageBox.Show("Thêm thành công!");
                }
                catch
                {
                    MessageBox.Show("Mã tác giả đã tồn tại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maTG = txtMa.Text.Trim();
            string tenTG = txtTen.Text.Trim();
            if (maTG == "" || tenTG == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            string sql = "UPDATE TacGia SET TenTG = @TenTG WHERE MaTG = @MaTG";
            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaTG", maTG);
                cmd.Parameters.AddWithValue("@TenTG", tenTG);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    LoadTacGia();
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã tác giả!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maTG = txtMa.Text.Trim();
            if (maTG == "")
            {
                MessageBox.Show("Vui lòng nhập mã tác giả cần xóa.");
                return;
            }

            // Cảnh báo người dùng về việc xóa liên quan
            var result = MessageBox.Show(
                "Nếu xóa tác giả này, tất cả các sách, phiếu nhập, hóa đơn liên quan cũng sẽ bị xóa!\nBạn có chắc chắn muốn tiếp tục?",
                "Cảnh báo xóa dữ liệu liên quan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            // Xóa các bản ghi liên quan trước để tránh lỗi khóa ngoại
            // 1. Lấy danh sách các mã sách của tác giả này
            var maSachList = new List<string>();
            using (var cmd = new SqliteCommand("SELECT MaSach FROM Sach WHERE MaTG = @MaTG", conn))
            {
                cmd.Parameters.AddWithValue("@MaTG", maTG);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        maSachList.Add(reader["MaSach"].ToString());
                }
            }

            foreach (var maSach in maSachList)
            {
                // Xóa chi tiết hóa đơn liên quan đến sách
                using (var cmd = new SqliteCommand("DELETE FROM CTHoaDon WHERE MaSach = @MaSach", conn))
                {
                    cmd.Parameters.AddWithValue("@MaSach", maSach);
                    cmd.ExecuteNonQuery();
                }
                // Xóa chi tiết phiếu nhập liên quan đến sách
                using (var cmd = new SqliteCommand("DELETE FROM CTPhieuNhap WHERE MaSach = @MaSach", conn))
                {
                    cmd.Parameters.AddWithValue("@MaSach", maSach);
                    cmd.ExecuteNonQuery();
                }
                // Xóa sách
                using (var cmd = new SqliteCommand("DELETE FROM Sach WHERE MaSach = @MaSach", conn))
                {
                    cmd.Parameters.AddWithValue("@MaSach", maSach);
                    cmd.ExecuteNonQuery();
                }
            }

            // Xóa tác giả
            using (var cmd = new SqliteCommand("DELETE FROM TacGia WHERE MaTG = @MaTG", conn))
            {
                cmd.Parameters.AddWithValue("@MaTG", maTG);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    LoadTacGia();
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã tác giả!");
                }
            }
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMa.Text = dgvTacGia.Rows[e.RowIndex].Cells["MaTG"].Value.ToString();
                txtTen.Text = dgvTacGia.Rows[e.RowIndex].Cells["TenTG"].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string filter = txtTimKiem.Text.Trim();
            string col = cbTimKiem.SelectedIndex == 0 ? "MaTG" : "TenTG";
            if (string.IsNullOrEmpty(filter))
            {
                dgvTacGia.DataSource = dtTacGia;
            }
            else
            {
                DataView dv = dtTacGia.DefaultView;
                dv.RowFilter = $"{col} LIKE '%{filter}%'";
                dgvTacGia.DataSource = dv.ToTable();
            }
        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi đổi loại tìm kiếm thì lọc lại theo giá trị hiện tại
            txtTimKiem_TextChanged(sender, e);
        }
    }
}
