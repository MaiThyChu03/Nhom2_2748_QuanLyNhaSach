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
        private string connectionString = "Data Source=nha_sach.db";

        public frmKhachHang()
        {
            InitializeComponent();
            txtMaKH.MaxLength = 10;
            txtDienThoai.MaxLength = 10; // Đặt giới hạn ngay sau khi khởi tạo
            LoadData();
            dgv.CellClick += dgv_CellClick;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            txtDienThoai.TextChanged += txtDienThoai_TextChanged;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKH.Text = GetNextMaKhachHang();
            txtMaKH.ReadOnly = true;
        }

        private void LoadData()
        {
            using var conn = new SqliteConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT * FROM KhachHang";
                using var cmd = new SqliteCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            string tenKH = txtTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string dienThoai = txtDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã KH và Tên KH.");
                return;
            }

            using var conn = new SqliteConnection(connectionString);
            try
            {
                conn.Open();
                string checkSql = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH";
                using (var checkCmd = new SqliteCommand(checkSql, conn))
                {
                    checkCmd.Parameters.AddWithValue("@MaKH", maKH);
                    long count = Convert.ToInt64(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại.");
                        return;
                    }
                }

                string insertSql = "INSERT INTO KhachHang (MaKH, HoTen, DiaChi, DienThoai, Email) VALUES (@MaKH, @HoTen, @DiaChi, @DienThoai, @Email)";
                using (var insertCmd = new SqliteCommand(insertSql, conn))
                {
                    insertCmd.Parameters.AddWithValue("@MaKH", maKH);
                    insertCmd.Parameters.AddWithValue("@HoTen", tenKH);
                    insertCmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    insertCmd.Parameters.AddWithValue("@DienThoai", dienThoai);
                    insertCmd.Parameters.AddWithValue("@Email", email);
                    insertCmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm khách hàng thành công.");
                LoadData();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            string tenKH = txtTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string dienThoai = txtDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã KH và Tên KH.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var conn = new SqliteConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "UPDATE KhachHang SET HoTen=@HoTen, DiaChi=@DiaChi, DienThoai=@DienThoai, Email=@Email WHERE MaKH=@MaKH";
                using var cmd = new SqliteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@HoTen", tenKH);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@DienThoai", dienThoai);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    LoadData();
                    MessageBox.Show("Cập nhật khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật khách hàng: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.");
                return;
            }

            // Kiểm tra ràng buộc khóa ngoại trước khi xóa
            using var conn = new SqliteConnection(connectionString);
            try
            {
                conn.Open();

                // Kiểm tra khách hàng có phiếu thu liên quan không
                string checkFK = "SELECT COUNT(*) FROM PhieuThuTien WHERE MaKH = @MaKH";
                using (var checkCmd = new SqliteCommand(checkFK, conn))
                {
                    checkCmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    long count = Convert.ToInt64(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Không thể xóa khách hàng này vì đã phát sinh phiếu thu liên quan.");
                        return;
                    }
                }

                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes) return;

                string sql = "DELETE FROM KhachHang WHERE MaKH=@MaKH";
                using var cmd = new SqliteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    LoadData();
                    btnLamMoi_Click(sender, e);
                    MessageBox.Show("Xóa khách hàng thành công.");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = GetNextMaKhachHang();
            txtMaKH.ReadOnly = true;
        }

        private void LamMoi()
        {
            txtMaKH.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtMaKH.ReadOnly = false;
            dgv.ClearSelection();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv.Rows.Count > e.RowIndex)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value?.ToString();
                txtTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtMaKH.ReadOnly = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            string cot = "MaKH";
            switch (cbTimKiem.SelectedIndex)
            {
                case 0: cot = "MaKH"; break;
                case 1: cot = "HoTen"; break;
                case 2: cot = "DiaChi"; break;
                case 3: cot = "DienThoai"; break;
                case 4: cot = "Email"; break;
            }

            using var conn = new SqliteConnection(connectionString);
            try
            {
                conn.Open();
                string query = $"SELECT * FROM KhachHang WHERE {cot} LIKE @TuKhoa";
                using var cmd = new SqliteCommand(query, conn);
                cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
                return;
            }

            using (var conn = new SqliteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM KhachHang WHERE MaKH LIKE @kw OR HoTen LIKE @kw OR Email LIKE @kw OR DienThoai LIKE @kw";
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgv.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
                }
            }
        }

        public void SetNewCustomerInfo(string ten, string diaChi, string dienThoai, string email)
        {
            txtTen.Text = ten;
            txtDiaChi.Text = diaChi;
            txtDienThoai.Text = dienThoai;
            txtEmail.Text = email;
        }

        private string GetNextMaKhachHang()
        {
            using var conn = new SqliteConnection("Data Source=nha_sach.db");
            conn.Open();
            string sql = "SELECT MaKH FROM KhachHang ORDER BY MaKH DESC LIMIT 1";
            using var cmd = new SqliteCommand(sql, conn);
            var lastMaKH = cmd.ExecuteScalar() as string;
            int nextNumber = 1;
            if (!string.IsNullOrEmpty(lastMaKH))
            {
                string numberPart = new string(lastMaKH.Where(char.IsDigit).ToArray());
                if (int.TryParse(numberPart, out int num))
                    nextNumber = num + 1;
            }
            return $"KH{nextNumber:D3}";
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            txtDienThoai.MaxLength = 10;
        }
    }
}
