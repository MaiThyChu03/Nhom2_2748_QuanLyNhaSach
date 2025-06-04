using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static quanlynhasach.frmThem;
using Microsoft.Data.Sqlite;
using System.Drawing.Printing;

namespace quanlynhasach
{
    public partial class frmThuTien : Form
    {
        public static string TenThem;
        private string connectionString = "Data Source=nha_sach.db";
        private TextBox txtGhiChu;
        private string printContent = "";

        public frmThuTien()
        {
            InitializeComponent();
            txtDienThoai.MaxLength = 10;
            txtMa.MaxLength = 10;
            cbMaKH.KeyPress += (s, e) =>
            {
                if (cbMaKH.Text.Length >= 10 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

            dtpNgayLap.Value = DateTime.Now;
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            LoadMaKhachHang();
            cbMaKH.SelectedIndexChanged += cbMaKH_SelectedIndexChanged;
            LoadData();
            txtGhiChu = new TextBox();
            txtGhiChu.Location = new Point(100, 100);
            txtGhiChu.Size = new Size(200, 30);
            Controls.Add(txtGhiChu);
            btnIn.Click += btnIn_Click;
            txtDienThoai.MaxLength = 10;
        }

        private void LoadData()
        {
            using var conn = new SqliteConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT * FROM PhieuThuTien";
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

        private void LoadMaKhachHang()
        {
            using var conn = new SqliteConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT MaKH FROM KhachHang";
                using var cmd = new SqliteCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                var list = new List<string>();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
                cbMaKH.DataSource = list;
                cbMaKH.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải mã khách hàng: " + ex.Message);
            }
        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaKH.SelectedIndex == -1) return;
            string maKH = cbMaKH.SelectedItem.ToString();
            using var conn = new SqliteConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT HoTen, DiaChi, DienThoai, Email FROM KhachHang WHERE MaKH = @MaKH";
                using var cmd = new SqliteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtTen.Text = reader["HoTen"].ToString();
                    txtDiaChi.Text = reader["DiaChi"].ToString();
                    txtDienThoai.Text = reader["DienThoai"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                }
                else
                {
                    txtTen.Clear();
                    txtDiaChi.Clear();
                    txtDienThoai.Clear();
                    txtEmail.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin khách hàng: " + ex.Message);
            }
            SetNextMaPhieuThu();
        }

        private void SetNextMaPhieuThu()
        {
            using var conn = new SqliteConnection(connectionString);
            conn.Open();
            string sql = "SELECT MaPT FROM PhieuThuTien ORDER BY MaPT DESC LIMIT 1";
            using var cmd = new SqliteCommand(sql, conn);
            var lastMaPT = cmd.ExecuteScalar() as string;
            int nextNumber = 1;
            if (!string.IsNullOrEmpty(lastMaPT))
            {
                string numberPart = new string(lastMaPT.Where(char.IsDigit).ToArray());
                if (int.TryParse(numberPart, out int num))
                    nextNumber = num + 1;
            }
            txtMa.Text = $"PT{nextNumber:D3}";
        }

        private void frmThuTien_Load(object sender, EventArgs e)
        {
            SetNextMaPhieuThu();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv.Rows.Count > e.RowIndex)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                txtMa.Text = row.Cells["MaPT"].Value?.ToString();
                cbMaKH.Text = row.Cells["MaKH"].Value?.ToString();
                nSoLuong.Text = row.Cells["SoTien"].Value?.ToString();

                // Lấy ngày thu
                if (DateTime.TryParse(row.Cells["NgayThu"].Value?.ToString(), out DateTime ngayThu))
                    dtpNgayLap.Value = ngayThu;

                // Lấy thông tin khách hàng từ MaKH
                string maKH = row.Cells["MaKH"].Value?.ToString();
                if (!string.IsNullOrEmpty(maKH))
                {
                    using var conn = new SqliteConnection(connectionString);
                    try
                    {
                        conn.Open();
                        string query = "SELECT HoTen, DiaChi, DienThoai, Email FROM KhachHang WHERE MaKH = @MaKH";
                        using var cmd = new SqliteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        using var reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtTen.Text = reader["HoTen"].ToString();
                            txtDiaChi.Text = reader["DiaChi"].ToString();
                            txtDienThoai.Text = reader["DienThoai"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                        }
                        else
                        {
                            txtTen.Clear();
                            txtDiaChi.Clear();
                            txtDienThoai.Clear();
                            txtEmail.Clear();
                        }
                    }
                    catch
                    {
                        txtTen.Clear();
                        txtDiaChi.Clear();
                        txtDienThoai.Clear();
                        txtEmail.Clear();
                    }
                }
                else
                {
                    txtTen.Clear();
                    txtDiaChi.Clear();
                    txtDienThoai.Clear();
                    txtEmail.Clear();
                }

                // Cho phép sửa mã phiếu thu và mã khách hàng
                txtMa.ReadOnly = false;
                cbMaKH.Enabled = true; // Dòng này cho phép sửa mã khách hàng
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và phím điều khiển (Backspace, Delete, v.v.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gThongTin_Enter(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            // Xóa trắng các trường nhập liệu và reset trạng thái
            txtMa.Clear();
            txtTen.Clear();
            txtGhiChu.Clear();
            nSoLuong.Value = 0;
            cbMaKH.SelectedIndex = -1;
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            dtpNgayLap.Value = DateTime.Now;
            txtMa.ReadOnly = false; // Đảm bảo cho phép nhập lại mã phiếu thu
            dgv.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMa.Text.Trim();
            string maKH = cbMaKH.Text.Trim();
            string soTienThu = nSoLuong.Value.ToString();
            string ngayLap = dtpNgayLap.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string ghiChu = txtGhiChu.Text.Trim();
            string nguoiLap = "admin"; // hoặc tên đăng nhập thực tế

            if (string.IsNullOrEmpty(maPhieu) || string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(soTienThu))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã phiếu, Mã KH và Số tiền thu.");
                return;
            }

            using var conn = new SqliteConnection(connectionString);
            try
            {
                conn.Open();

                // Kiểm tra mã khách hàng có tồn tại không
                string checkKHSql = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH";
                using (var checkKHCm = new SqliteCommand(checkKHSql, conn))
                {
                    checkKHCm.Parameters.AddWithValue("@MaKH", maKH);
                    long khCount = Convert.ToInt64(checkKHCm.ExecuteScalar());
                    if (khCount == 0)
                    {
                        MessageBox.Show("Mã khách hàng không tồn tại. Vui lòng chọn hoặc thêm khách hàng trước.");
                        return;
                    }
                }

                // Kiểm tra mã phiếu thu đã tồn tại chưa
                string checkSql = "SELECT COUNT(*) FROM PhieuThuTien WHERE MaPT = @MaPT";
                using (var checkCmd = new SqliteCommand(checkSql, conn))
                {
                    checkCmd.Parameters.AddWithValue("@MaPT", maPhieu);
                    long count = Convert.ToInt64(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Mã phiếu đã tồn tại.");
                        return;
                    }
                }

                // Thêm phiếu thu mới
                string insertSql = "INSERT INTO PhieuThuTien (MaPT, MaKH, NgayThu, SoTien, NguoiLap) VALUES (@MaPT, @MaKH, @NgayThu, @SoTien, @NguoiLap)";
                using (var insertCmd = new SqliteCommand(insertSql, conn))
                {
                    insertCmd.Parameters.AddWithValue("@MaPT", maPhieu);
                    insertCmd.Parameters.AddWithValue("@MaKH", maKH);
                    insertCmd.Parameters.AddWithValue("@NgayThu", ngayLap);
                    insertCmd.Parameters.AddWithValue("@SoTien", soTienThu);
                    insertCmd.Parameters.AddWithValue("@NguoiLap", nguoiLap);
                    insertCmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm phiếu thu thành công.");
                LoadData();
                btnLamMoi_Click_1(null, null);
                SetNextMaPhieuThu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiếu thu: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMa.Text.Trim();
            string maKH = cbMaKH.Text.Trim();
            string soTienThu = nSoLuong.Value.ToString();
            string ngayThu = dtpNgayLap.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string nguoiLap = "admin";

            if (string.IsNullOrEmpty(maPhieu) || string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(soTienThu))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã phiếu, Mã KH và Số tiền thu.");
                return;
            }

            using var conn = new SqliteConnection(connectionString);
            try
            {
                conn.Open();

                // Kiểm tra phiếu thu có tồn tại không
                string checkPTSql = "SELECT COUNT(*) FROM PhieuThuTien WHERE MaPT = @MaPT";
                using (var checkPTCmd = new SqliteCommand(checkPTSql, conn))
                {
                    checkPTCmd.Parameters.AddWithValue("@MaPT", maPhieu);
                    long ptCount = Convert.ToInt64(checkPTCmd.ExecuteScalar());
                    if (ptCount == 0)
                    {
                        MessageBox.Show("Phiếu thu không tồn tại.");
                        return;
                    }
                }

                // Kiểm tra mã khách hàng có tồn tại không
                string checkKHSql = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH";
                using (var checkKHCmd = new SqliteCommand(checkKHSql, conn))
                {
                    checkKHCmd.Parameters.AddWithValue("@MaKH", maKH);
                    long khCount = Convert.ToInt64(checkKHCmd.ExecuteScalar());
                    if (khCount == 0)
                    {
                        MessageBox.Show("Mã khách hàng không tồn tại. Vui lòng chọn hoặc thêm khách hàng trước.");
                        return;
                    }
                }

                // Cập nhật thông tin khách hàng
                string updateKHSql = "UPDATE KhachHang SET HoTen=@HoTen, DiaChi=@DiaChi, DienThoai=@DienThoai, Email=@Email WHERE MaKH=@MaKH";
                using (var updateKHCmd = new SqliteCommand(updateKHSql, conn))
                {
                    updateKHCmd.Parameters.AddWithValue("@HoTen", txtTen.Text.Trim());
                    updateKHCmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                    updateKHCmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text.Trim());
                    updateKHCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    updateKHCmd.Parameters.AddWithValue("@MaKH", maKH);
                    updateKHCmd.ExecuteNonQuery();
                }

                // Cập nhật thông tin phiếu thu
                string updateSql = "UPDATE PhieuThuTien SET MaKH=@MaKH, NgayThu=@NgayThu, SoTien=@SoTien, NguoiLap=@NguoiLap WHERE MaPT=@MaPT";
                using (var updateCmd = new SqliteCommand(updateSql, conn))
                {
                    updateCmd.Parameters.AddWithValue("@MaKH", maKH);
                    updateCmd.Parameters.AddWithValue("@NgayThu", ngayThu);
                    updateCmd.Parameters.AddWithValue("@SoTien", soTienThu);
                    updateCmd.Parameters.AddWithValue("@NguoiLap", nguoiLap);
                    updateCmd.Parameters.AddWithValue("@MaPT", maPhieu);

                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Lấy lại thông tin đã cập nhật
                        string selectSql = @"
                            SELECT pt.*, kh.HoTen, kh.DiaChi, kh.DienThoai, kh.Email 
                            FROM PhieuThuTien pt
                            JOIN KhachHang kh ON pt.MaKH = kh.MaKH
                            WHERE pt.MaPT = @MaPT";

                        using (var selectCmd = new SqliteCommand(selectSql, conn))
                        {
                            selectCmd.Parameters.AddWithValue("@MaPT", maPhieu);
                            using (var reader = selectCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtMa.Text = reader["MaPT"].ToString();
                                    cbMaKH.Text = reader["MaKH"].ToString();
                                    nSoLuong.Value = decimal.Parse(reader["SoTien"].ToString());
                                    if (DateTime.TryParse(reader["NgayThu"].ToString(), out DateTime ngayThuValue))
                                    {
                                        dtpNgayLap.Value = ngayThuValue;
                                    }
                                    txtTen.Text = reader["HoTen"].ToString();
                                    txtDiaChi.Text = reader["DiaChi"].ToString();
                                    txtDienThoai.Text = reader["DienThoai"].ToString();
                                    txtEmail.Text = reader["Email"].ToString();
                                }
                            }
                        }

                        LoadData();
                        MessageBox.Show("Cập nhật phiếu thu và khách hàng thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật phiếu thu.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phiếu thu: " + ex.Message);
            }
        }

        private void btnThem_KH_Click(object sender, EventArgs e)
        {
            frmThem formThem = new frmThem();
            formThem.LoadFormConVaoPanel(new frmKhachHang());
            TenThem = "Khách hàng";
            formThem.labelThem.Text = "        " + TenThem;
            formThem.ShowDialog();
            MessageBox.Show("Thêm khách hàng thành công!");
            txtMa.Text = GetNextMaKhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMa.Text.Trim();
            if (string.IsNullOrEmpty(maPhieu))
            {
                MessageBox.Show("Vui lòng chọn phiếu thu cần xóa.");
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa phiếu thu [{maPhieu}] không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            using var conn = new SqliteConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "DELETE FROM PhieuThuTien WHERE MaPT = @MaPT";
                using var cmd = new SqliteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaPT", maPhieu);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Xóa phiếu thu thành công.");
                    LoadData();
                    btnLamMoi_Click_1(null, null);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu thu để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phiếu thu: " + ex.Message);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += Pd_PrintPage_Receipt;

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();
        }

        private void Pd_PrintPage_Receipt(object sender, PrintPageEventArgs e)
        {
            // Lấy dữ liệu thực tế từ các control trên form
            string hoTen = txtTen.Text;
            string diaChi = txtDiaChi.Text;
            string dienThoai = txtDienThoai.Text;
            string email = txtEmail.Text;
            string ngayThu = dtpNgayLap.Value.ToString("dd/MM/yyyy");
            decimal soTien = nSoLuong.Value;

            PrintReceipt(hoTen, diaChi, dienThoai, email, ngayThu, soTien, e);
        }

        private void PrintReceipt(
            string hoTen, string diaChi, string dienThoai, string email,
            string ngayThu, decimal soTien, PrintPageEventArgs e)
        {
            float x = 40, y = 40;
            float lineHeight = 32;
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);
            Font normalFont = new Font("Arial", 12);
            Brush blackBrush = Brushes.Black;

            // Vẽ khung tiêu đề
            e.Graphics.FillRectangle(Brushes.Black, x, y, 520, lineHeight);
            e.Graphics.DrawRectangle(Pens.Black, x, y, 520, lineHeight);
            e.Graphics.DrawString("BM4:", boldFont, Brushes.White, x + 5, y + 6);
            e.Graphics.DrawString("Phiếu Thu Tiền", boldFont, Brushes.White, x + 120, y + 6);

            y += lineHeight;

            // Vẽ nội dung
            e.Graphics.DrawRectangle(Pens.Black, x, y, 520, lineHeight * 3);

            float yText = y + 7;
            e.Graphics.DrawString($"Họ tên khách hàng:  {hoTen}", normalFont, blackBrush, x + 5, yText);
            e.Graphics.DrawString($"Địa chỉ: {diaChi}", normalFont, blackBrush, x + 270, yText);

            yText += lineHeight;
            e.Graphics.DrawString($"Điện thoại: {dienThoai}", normalFont, blackBrush, x + 5, yText);
            e.Graphics.DrawString($"Email: {email}", normalFont, blackBrush, x + 270, yText);

            yText += lineHeight;
            e.Graphics.DrawString($"Ngày thu tiền: {ngayThu}", normalFont, blackBrush, x + 5, yText);
            e.Graphics.DrawString($"Số tiền thu: {soTien:N0}", normalFont, blackBrush, x + 270, yText);
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
                // Giả sử MaKH dạng KH001, KH002,...
                string numberPart = new string(lastMaKH.Where(char.IsDigit).ToArray());
                if (int.TryParse(numberPart, out int num))
                    nextNumber = num + 1;
            }
            return $"KH{nextNumber:D3}";
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            txtMa.Text = GetNextMaKhachHang();
            txtMa.ReadOnly = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMa.Text = GetNextMaKhachHang();
            // Xóa các trường khác nếu cần
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            txtDienThoai.MaxLength = 10;
        }
    }
}
