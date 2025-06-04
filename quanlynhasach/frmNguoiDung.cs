using System.Data;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace quanlynhasach
{
    public partial class frmNguoiDung : Form
    {
        private string connectionString = "Data Source=nha_sach.db";

        public frmNguoiDung()
        {
            InitializeComponent();
            LoadData();
            dgv.CellClick += dgv_CellClick;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
        }

        private void LoadData()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM NguoiDung";
                    using (var cmd = new SqliteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgv.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtMatKhau.Clear();
            if (cbQuyen.Items.Count > 0)
                cbQuyen.SelectedIndex = 0;
            dgv.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtMa.Text.Trim();
            string hoTen = txtTen.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string vaiTro = cbQuyen.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) ||
                string.IsNullOrEmpty(hoTen) ||
                string.IsNullOrEmpty(matKhau) ||
                string.IsNullOrEmpty(vaiTro))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string checkSql = "SELECT COUNT(*) FROM NguoiDung WHERE TenDN=@TenDN";
                using (var checkCmd = new SqliteCommand(checkSql, conn))
                {
                    checkCmd.Parameters.AddWithValue("@TenDN", tenDangNhap);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string sql = "INSERT INTO NguoiDung (TenDN, HoTen, MatKhau, VaiTro) VALUES (@TenDN, @HoTen, @MatKhau, @VaiTro)";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDN", tenDangNhap);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    cmd.Parameters.AddWithValue("@VaiTro", vaiTro);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Thêm người dùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        txtMa.Clear();
                        txtTen.Clear();
                        txtMatKhau.Clear();
                        if (cbQuyen.Items.Count > 0)
                            cbQuyen.SelectedIndex = 0;
                        dgv.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Thêm người dùng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtMa.Text.Trim();
            string hoTen = txtTen.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string vaiTro = cbQuyen.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) ||
                string.IsNullOrEmpty(hoTen) ||
                string.IsNullOrEmpty(matKhau) ||
                string.IsNullOrEmpty(vaiTro))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE NguoiDung SET HoTen=@HoTen, MatKhau=@MatKhau, VaiTro=@VaiTro WHERE TenDN=@TenDN";
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                        cmd.Parameters.AddWithValue("@VaiTro", vaiTro);
                        cmd.Parameters.AddWithValue("@TenDN", tenDangNhap);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            LoadData();
                            MessageBox.Show("Cập nhật người dùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtMa.Clear();
                            txtTen.Clear();
                            txtMatKhau.Clear();
                            if (cbQuyen.Items.Count > 0)
                                cbQuyen.SelectedIndex = 0;
                            dgv.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy người dùng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show("Vui lòng chọn người dùng để xóa.");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            using (var conn = new SqliteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM NguoiDung WHERE TenDN=@TenDN";
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenDN", txtMa.Text);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            LoadData();
                            btnLamMoi_Click(sender, e);
                            MessageBox.Show("Xóa người dùng thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy người dùng để xóa.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa người dùng: " + ex.Message);
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv.Rows.Count > e.RowIndex)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                txtMa.Text = row.Cells["TenDN"].Value?.ToString();
                txtTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString();
                cbQuyen.Text = row.Cells["VaiTro"].Value?.ToString();
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
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
                        string query = "SELECT * FROM NguoiDung WHERE TenDN LIKE @kw OR HoTen LIKE @kw";
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
        }
    } 
}