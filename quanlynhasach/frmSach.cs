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
using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
namespace quanlynhasach
{
    public partial class frmSach : Form
    {
        public static string TenThem;
        private SqliteConnection conn;
        private DataTable dtSach;
        private DataTable dtTheLoai;
        private DataTable dtTacGia;
        public frmSach()
        {
            InitializeComponent();
            ConnectDatabase();
            LoadTheLoai();
            LoadTacGia();
            InitComboBoxTimKiem();
            // KHÔNG gọi LoadSach() ở đây
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            LoadSach();
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
            cbTheLoai.DataSource = dtTheLoai;
            cbTheLoai.DisplayMember = "TenTL";
            cbTheLoai.ValueMember = "MaTL";
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
            cbTacGia.DataSource = dtTacGia;
            cbTacGia.DisplayMember = "TenTG";
            cbTacGia.ValueMember = "MaTG";
        }

        private void LoadSach()
        {
            string query = @"SELECT s.MaSach, s.TenSach, s.SoLuong, s.MaTL, tl.TenTL, s.MaTG, tg.TenTG, s.NguoiLap
                             FROM Sach s
                             LEFT JOIN TheLoai tl ON s.MaTL = tl.MaTL
                             LEFT JOIN TacGia tg ON s.MaTG = tg.MaTG";
            dtSach = new DataTable();
            using (var cmd = new SqliteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                dtSach.Load(reader);
            }
            dgvSach.DataSource = dtSach;
        }

        private void InitComboBoxTimKiem()
        {
            cbTimKiem.Items.Clear();
            cbTimKiem.Items.Add("Mã sách");
            cbTimKiem.Items.Add("Tên sách");
            cbTimKiem.Items.Add("Thể loại");
            cbTimKiem.Items.Add("Tác giả");
            cbTimKiem.SelectedIndex = 0;
        }
        private void frmSach_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_TL_Click(object sender, EventArgs e)
        {
            frmThem formThem = new frmThem();
            formThem.LoadFormConVaoPanel(new frmTheLoai());
            TenThem = "THỂ LOẠI";
            formThem.labelThem.Text = "        " + TenThem;
            formThem.ShowDialog();
            LoadTheLoai(); // Cập nhật lại combobox sau khi thêm mới
        }

        private void btnThem_TG_Click(object sender, EventArgs e)
        {
            frmThem formThem = new frmThem();
            formThem.LoadFormConVaoPanel(new frmTacGia());
            TenThem = "TÁC GIẢ";
            formThem.labelThem.Text = "        " + TenThem;
            formThem.ShowDialog();
            LoadTacGia(); // Cập nhật lại combobox sau khi thêm mới
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSach = txtMa.Text.Trim();
            string tenSach = txtTen.Text.Trim();
            int soLuong = (int)numSoLuong.Value;
            string maTL = cbTheLoai.SelectedValue?.ToString();
            string maTG = cbTacGia.SelectedValue?.ToString();
            string nguoiLap = "admin"; // hoặc lấy từ đăng nhập

            if (maSach == "" || tenSach == "" || maTL == null || maTG == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string sql = "INSERT INTO Sach (MaSach, TenSach, SoLuong, MaTL, MaTG, NguoiLap) VALUES (@MaSach, @TenSach, @SoLuong, @MaTL, @MaTG, @NguoiLap)";
            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaSach", maSach);
                cmd.Parameters.AddWithValue("@TenSach", tenSach);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                cmd.Parameters.AddWithValue("@MaTL", maTL);
                cmd.Parameters.AddWithValue("@MaTG", maTG);
                cmd.Parameters.AddWithValue("@NguoiLap", nguoiLap);
                try
                {
                    cmd.ExecuteNonQuery();
                    LoadSach();
                    MessageBox.Show("Thêm thành công!");
                }
                catch
                {
                    MessageBox.Show("Mã sách đã tồn tại!");
                }
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSach = txtMa.Text.Trim();
            string tenSach = txtTen.Text.Trim();
            int soLuong = (int)numSoLuong.Value;
            string maTL = cbTheLoai.SelectedValue?.ToString();
            string maTG = cbTacGia.SelectedValue?.ToString();

            if (maSach == "" || tenSach == "" || maTL == null || maTG == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string sql = "UPDATE Sach SET TenSach = @TenSach, SoLuong = @SoLuong, MaTL = @MaTL, MaTG = @MaTG WHERE MaSach = @MaSach";
            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaSach", maSach);
                cmd.Parameters.AddWithValue("@TenSach", tenSach);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                cmd.Parameters.AddWithValue("@MaTL", maTL);
                cmd.Parameters.AddWithValue("@MaTG", maTG);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    LoadSach();
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã sách!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSach = txtMa.Text.Trim();
            if (maSach == "")
            {
                MessageBox.Show("Vui lòng nhập mã sách cần xóa.");
                return;
            }

            // Cảnh báo người dùng về việc xóa liên quan
            var result = MessageBox.Show(
                "Nếu xóa sách này, tất cả các phiếu nhập, hóa đơn liên quan cũng sẽ bị xóa!\nBạn có chắc chắn muốn tiếp tục?",
                "Cảnh báo xóa dữ liệu liên quan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            using (var conn = new SqliteConnection("Data Source=nha_sach.db"))
            {
                conn.Open();

                // 1. Xóa chi tiết hóa đơn liên quan đến sách
                using (var cmd = new SqliteCommand("DELETE FROM CTHoaDon WHERE MaSach = @MaSach", conn))
                {
                    cmd.Parameters.AddWithValue("@MaSach", maSach);
                    cmd.ExecuteNonQuery();
                }

                // 2. Xóa hóa đơn không còn chi tiết nào
                using (var cmd = new SqliteCommand(
                    @"DELETE FROM HoaDon 
                      WHERE MaHD NOT IN (SELECT MaHD FROM CTHoaDon)", conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // 3. Xóa chi tiết phiếu nhập liên quan đến sách
                using (var cmd = new SqliteCommand("DELETE FROM CTPhieuNhap WHERE MaSach = @MaSach", conn))
                {
                    cmd.Parameters.AddWithValue("@MaSach", maSach);
                    cmd.ExecuteNonQuery();
                }

                // 4. Xóa phiếu nhập không còn chi tiết nào
                using (var cmd = new SqliteCommand(
                    @"DELETE FROM PhieuNhap 
                      WHERE MaPN NOT IN (SELECT MaPN FROM CTPhieuNhap)", conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // 5. Xóa sách
                using (var cmd = new SqliteCommand("DELETE FROM Sach WHERE MaSach = @MaSach", conn))
                {
                    cmd.Parameters.AddWithValue("@MaSach", maSach);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        LoadSach();
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã sách!");
                    }
                }
            }
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && !dgvSach.Rows[e.RowIndex].IsNewRow)
            {
                txtMa.Text = dgvSach.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
                txtTen.Text = dgvSach.Rows[e.RowIndex].Cells["TenSach"].Value.ToString();
                numSoLuong.Value = Convert.ToInt32(dgvSach.Rows[e.RowIndex].Cells["SoLuong"].Value);
                cbTheLoai.SelectedValue = dgvSach.Rows[e.RowIndex].Cells["MaTL"].Value.ToString();
                cbTacGia.SelectedValue = dgvSach.Rows[e.RowIndex].Cells["MaTG"].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (dtSach == null) return; // Không làm gì nếu chưa có dữ liệu

            string filter = txtTimKiem.Text.Trim();
            string col = "MaSach";
            switch (cbTimKiem.SelectedIndex)
            {
                case 0: col = "MaSach"; break;
                case 1: col = "TenSach"; break;
                case 2: col = "TenTL"; break;
                case 3: col = "TenTG"; break;
            }
            if (string.IsNullOrEmpty(filter))
            {
                dgvSach.DataSource = dtSach;
            }
            else
            {
                DataView dv = dtSach.DefaultView;
                dv.RowFilter = $"{col} LIKE '%{filter}%'";
                dgvSach.DataSource = dv.ToTable();
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
            numSoLuong.Value = 0;
            txtTimKiem.Clear();
            LoadSach();
        }
    }
}
