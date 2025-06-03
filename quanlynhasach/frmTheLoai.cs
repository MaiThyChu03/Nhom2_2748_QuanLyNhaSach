using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace quanlynhasach
{
    public partial class frmTheLoai : Form
    {
        private SqliteConnection conn;
        private DataTable dtTheLoai;

        public frmTheLoai()
        {
            InitializeComponent();
            ConnectDatabase();
            LoadTheLoai();
            InitComboBox();
        }

        private void ConnectDatabase()
        {
            conn = new SqliteConnection("Data Source=nha_sach.db");
            conn.Open();
        }

        private void LoadTheLoai()
        {
            string query = "SELECT MaTL, TenTL FROM TheLoai";
            dtTheLoai = new DataTable();
            using (var cmd = new SqliteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                dtTheLoai.Load(reader);
            }
            dgvTheLoai.DataSource = dtTheLoai;
        }

        private void InitComboBox()
        {
            cbTimKiem.Items.Clear();
            cbTimKiem.Items.Add("Mã thể loại");
            cbTimKiem.Items.Add("Tên thể loại");
            cbTimKiem.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maTL = txtMa.Text.Trim();
            string tenTL = txtTen.Text.Trim();
            if (maTL == "" || tenTL == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            string sql = "INSERT INTO TheLoai (MaTL, TenTL) VALUES (@MaTL, @TenTL)";
            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaTL", maTL);
                cmd.Parameters.AddWithValue("@TenTL", tenTL);
                try
                {
                    cmd.ExecuteNonQuery();
                    LoadTheLoai();
                    MessageBox.Show("Thêm thành công!");
                }
                catch
                {
                    MessageBox.Show("Mã thể loại đã tồn tại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maTL = txtMa.Text.Trim();
            string tenTL = txtTen.Text.Trim();
            if (maTL == "" || tenTL == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            string sql = "UPDATE TheLoai SET TenTL = @TenTL WHERE MaTL = @MaTL";
            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaTL", maTL);
                cmd.Parameters.AddWithValue("@TenTL", tenTL);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    LoadTheLoai();
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã thể loại!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maTL = txtMa.Text.Trim();
            if (maTL == "")
            {
                MessageBox.Show("Vui lòng nhập mã thể loại cần xóa.");
                return;
            }

            // Cảnh báo người dùng về việc xóa liên quan
            var result = MessageBox.Show(
                "Nếu xóa thể loại này, tất cả các sách, phiếu nhập, hóa đơn liên quan cũng sẽ bị xóa!\nBạn có chắc chắn muốn tiếp tục?",
                "Cảnh báo xóa dữ liệu liên quan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            // Xóa các bản ghi liên quan trước để tránh lỗi khóa ngoại
            // 1. Lấy danh sách các mã sách của thể loại này
            var maSachList = new List<string>();
            using (var cmd = new SqliteCommand("SELECT MaSach FROM Sach WHERE MaTL = @MaTL", conn))
            {
                cmd.Parameters.AddWithValue("@MaTL", maTL);
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

            // Xóa thể loại
            using (var cmd = new SqliteCommand("DELETE FROM TheLoai WHERE MaTL = @MaTL", conn))
            {
                cmd.Parameters.AddWithValue("@MaTL", maTL);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    LoadTheLoai();
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã thể loại!");
                }
            }
        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMa.Text = dgvTheLoai.Rows[e.RowIndex].Cells["MaTL"].Value.ToString();
                txtTen.Text = dgvTheLoai.Rows[e.RowIndex].Cells["TenTL"].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string filter = txtTimKiem.Text.Trim();
            string col = cbTimKiem.SelectedIndex == 0 ? "MaTL" : "TenTL";
            if (string.IsNullOrEmpty(filter))
            {
                dgvTheLoai.DataSource = dtTheLoai;
            }
            else
            {
                DataView dv = dtTheLoai.DefaultView;
                dv.RowFilter = $"{col} LIKE '%{filter}%'";
                dgvTheLoai.DataSource = dv.ToTable();
            }
        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem_TextChanged(sender, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtTimKiem.Clear();
            LoadTheLoai();
        }

        private void frmTheLoai_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
