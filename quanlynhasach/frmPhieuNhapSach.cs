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
using static quanlynhasach.frmThem;
using System.Drawing.Printing;

namespace quanlynhasach
{
    public partial class frmPhieuNhapSach : Form
    {
        public static string TenThem;
        private SqliteConnection conn;
        private DataTable dtSach;
        private DataTable dtTheLoai;
        private DataTable dtTacGia;
        private DataTable dtCTPhieuNhap;
        private DataTable _dtIn; // Lưu tạm dữ liệu để in
        private string _maPN, _ngayNhap, _nguoiLap;

        public enum PhieuNhapMode { Them, Sua }
        private PhieuNhapMode _mode = PhieuNhapMode.Them;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        protected override void WndProc(ref Message TinHieu)
        {
            const int KichThuocKeo = 10;
            const int MaThongDiepKiemTraViTriChuot = 0x84;

            const int Giua = 1;
            const int VienTrai = 10;
            const int VienPhai = 11;
            const int VienTren = 12;
            const int GocTrenTrai = 13;
            const int GocTrenPhai = 14;
            const int VienDuoi = 15;
            const int GocDuoiTrai = 16;
            const int GocDuoiPhai = 17;

            if (TinHieu.Msg == MaThongDiepKiemTraViTriChuot)
            {
                base.WndProc(ref TinHieu);
                Point ViTriChuot = PointToClient(new Point(TinHieu.LParam.ToInt32()));

                if (ViTriChuot.X <= KichThuocKeo)
                {
                    if (ViTriChuot.Y <= KichThuocKeo)
                        TinHieu.Result = (IntPtr)GocTrenTrai;
                    else if (ViTriChuot.Y >= ClientSize.Height - KichThuocKeo)
                        TinHieu.Result = (IntPtr)GocDuoiTrai;
                    else
                        TinHieu.Result = (IntPtr)VienTrai;
                }
                else if (ViTriChuot.X >= ClientSize.Width - KichThuocKeo)
                {
                    if (ViTriChuot.Y <= KichThuocKeo)
                        TinHieu.Result = (IntPtr)GocTrenPhai;
                    else if (ViTriChuot.Y >= ClientSize.Height - KichThuocKeo)
                        TinHieu.Result = (IntPtr)GocDuoiPhai;
                    else
                        TinHieu.Result = (IntPtr)VienPhai;
                }
                else if (ViTriChuot.Y <= KichThuocKeo)
                {
                    TinHieu.Result = (IntPtr)VienTren;
                }
                else if (ViTriChuot.Y >= ClientSize.Height - KichThuocKeo)
                {
                    TinHieu.Result = (IntPtr)VienDuoi;
                }
                else
                {
                    TinHieu.Result = (IntPtr)Giua;
                }
                return;
            }

            base.WndProc(ref TinHieu);
        }
        public frmPhieuNhapSach()
        {
            InitializeComponent();
            dtpNgayLap.Value = DateTime.Now;
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            ConnectDatabase();
            LoadSach();
            LoadComboBoxData(); // Thêm dòng này
            InitCTPhieuNhap();
            dgvChon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCTPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bntThemSach.Click += bntThemSach_Click;
            btnLoaiBoSach.Click += btnLoaiBoSach_Click;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            dgvChon.SelectionChanged += dgvChon_SelectionChanged; // Thêm dòng này
            dgvCTPN.SelectionChanged += dgvCTPN_SelectionChanged;
            SetButtonMode(); // Gọi sau khi khởi tạo các control
        }

        public frmPhieuNhapSach(PhieuNhapMode mode) : this()
        {
            _mode = mode;
            SetButtonMode();
        }

        public frmPhieuNhapSach(string maPN)
            : this(PhieuNhapMode.Sua)
        {
            LoadPhieuNhap(maPN);
        }

        private void ConnectDatabase()
        {
            conn = new SqliteConnection("Data Source=nha_sach.db");
            conn.Open();
        }

        private void LoadSach()
        {
            string query = @"SELECT s.MaSach, s.TenSach, tl.TenTL, tg.TenTG
                             FROM Sach s
                             LEFT JOIN TheLoai tl ON s.MaTL = tl.MaTL
                             LEFT JOIN TacGia tg ON s.MaTG = tg.MaTG";
            dtSach = new DataTable();
            using (var cmd = new SqliteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                dtSach.Load(reader);
            }
            dgvChon.DataSource = dtSach;
        }

        private void InitCTPhieuNhap()
        {
            dtCTPhieuNhap = new DataTable();
            dtCTPhieuNhap.Columns.Add("MaSach");
            dtCTPhieuNhap.Columns.Add("TenSach");
            dtCTPhieuNhap.Columns.Add("SoLuong", typeof(int));
            dtCTPhieuNhap.Columns.Add("DonGiaNhap", typeof(decimal));
            dgvCTPN.DataSource = dtCTPhieuNhap;
        }

        private void bntThemSach_Click(object sender, EventArgs e)
        {
            if (dgvChon.CurrentRow != null)
            {
                string maSach = dgvChon.CurrentRow.Cells["MaSach"].Value.ToString();
                string tenSach = dgvChon.CurrentRow.Cells["TenSach"].Value.ToString();
                int soLuong = (int)nSoLuong.Value;
                decimal donGiaNhap = nGia.Value;

                if (soLuong <= 0 || donGiaNhap <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng và đơn giá nhập hợp lệ.");
                    return;
                }

                // Kiểm tra sách đã có trong chi tiết chưa
                foreach (DataRow row in dtCTPhieuNhap.Rows)
                {
                    if (row["MaSach"].ToString() == maSach)
                    {
                        // Nếu đã có thì cộng dồn số lượng và cập nhật giá
                        row["SoLuong"] = Convert.ToInt32(row["SoLuong"]) + soLuong;
                        row["DonGiaNhap"] = donGiaNhap; // Có thể cập nhật giá mới nhất
                        dgvCTPN.Refresh();
                        return;
                    }
                }

                // Thêm mới
                DataRow newRow = dtCTPhieuNhap.NewRow();
                newRow["MaSach"] = maSach;
                newRow["TenSach"] = tenSach;
                newRow["SoLuong"] = soLuong;
                newRow["DonGiaNhap"] = donGiaNhap;
                dtCTPhieuNhap.Rows.Add(newRow);
            }
        }

        private void btnLoaiBoSach_Click(object sender, EventArgs e)
        {
            if (dgvCTPN.CurrentRow != null)
            {
                dgvCTPN.Rows.RemoveAt(dgvCTPN.CurrentRow.Index);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPN = txtMa.Text.Trim();
            string ngayLap = dtpNgayLap.Value.ToString("yyyy-MM-dd");
            string nguoiLap = "admin"; // Hoặc lấy từ đăng nhập

            if (maPN == "" || dtCTPhieuNhap.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu nhập và thêm ít nhất một sách.");
                return;
            }

            // Thêm phiếu nhập
            string sqlPN = "INSERT INTO PhieuNhap (MaPN, NgayNhap, NguoiLap) VALUES (@MaPN, @NgayNhap, @NguoiLap)";
            using (var cmd = new SqliteCommand(sqlPN, conn))
            {
                cmd.Parameters.AddWithValue("@MaPN", maPN);
                cmd.Parameters.AddWithValue("@NgayNhap", ngayLap);
                cmd.Parameters.AddWithValue("@NguoiLap", nguoiLap);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại!");
                    return;
                }
            }

            // Thêm chi tiết phiếu nhập
            foreach (DataRow row in dtCTPhieuNhap.Rows)
            {
                string sqlCT = "INSERT INTO CTPhieuNhap (MaPN, MaSach, SoLuong, DonGiaNhap) VALUES (@MaPN, @MaSach, @SoLuong, @DonGiaNhap)";
                using (var cmdCT = new SqliteCommand(sqlCT, conn))
                {
                    cmdCT.Parameters.AddWithValue("@MaPN", maPN);
                    cmdCT.Parameters.AddWithValue("@MaSach", row["MaSach"]);
                    cmdCT.Parameters.AddWithValue("@SoLuong", row["SoLuong"]);
                    cmdCT.Parameters.AddWithValue("@DonGiaNhap", row["DonGiaNhap"]);
                    cmdCT.ExecuteNonQuery();
                }

                // Cập nhật số lượng sách trong kho
                string sqlUpdate = "UPDATE Sach SET SoLuong = SoLuong + @SoLuong WHERE MaSach = @MaSach";
                using (var cmdUpdate = new SqliteCommand(sqlUpdate, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@SoLuong", row["SoLuong"]);
                    cmdUpdate.Parameters.AddWithValue("@MaSach", row["MaSach"]);
                    cmdUpdate.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Thêm phiếu nhập thành công!");
            dtCTPhieuNhap.Clear();
            txtMa.Clear();
            nSoLuong.Value = 0;
            nGia.Value = 0;
            LoadSach();
            this.Close();
            return;

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (dtSach == null) return;
            string filter = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(filter) || filter == "Nhập tên sách bạn muốn tìm kiếm")
            {
                dgvChon.DataSource = dtSach;
            }
            else
            {
                DataView dv = dtSach.DefaultView;
                dv.RowFilter = $"TenSach LIKE '%{filter}%'";
                dgvChon.DataSource = dv.ToTable();
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }

        private void frmPhieuNhapSach_Load(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            btnPhong.Visible = false;
            btnThu.Visible = true;
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThu_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
            btnPhong.Visible = true;
            btnThu.Visible = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnThem_Sach_Click(object sender, EventArgs e)
        {
            frmThem formThem = new frmThem();
            formThem.LoadFormConVaoPanel(new frmSach());
            TenThem = "SÁCH";
            formThem.labelThem.Text = "        " + TenThem;
            formThem.ShowDialog();
        }

        private void btnThem_TL_Click(object sender, EventArgs e)
        {
            frmThem formThem = new frmThem();
            formThem.LoadFormConVaoPanel(new frmTheLoai());
            TenThem = "THỂ LOẠI";
            formThem.labelThem.Text = "        " + TenThem;
            formThem.ShowDialog();
        }

        private void btnThem_TG_Click(object sender, EventArgs e)
        {
            frmThem formThem = new frmThem();
            formThem.LoadFormConVaoPanel(new frmTacGia());
            TenThem = "TÁC GIẢ";
            formThem.labelThem.Text = "        " + TenThem;
            formThem.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            nSoLuong.Value = 0;
            nGia.Value = 0;
            dtpNgayLap.Value = DateTime.Now;
            dtCTPhieuNhap.Clear();
            LoadSach();
            txtMa.Focus();
        }
        private void LoadPhieuNhap(string maPN)
        {
            // Load thông tin phiếu nhập
            string sql = "SELECT MaPN, NgayNhap, NguoiLap FROM PhieuNhap WHERE MaPN = @MaPN";
            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaPN", maPN);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtMa.Text = reader["MaPN"].ToString();
                        dtpNgayLap.Value = DateTime.Parse(reader["NgayNhap"].ToString());
                        // txtNguoiLap.Text = reader["NguoiLap"].ToString(); // Nếu có
                    }
                }
            }

            // Load chi tiết phiếu nhập
            dtCTPhieuNhap.Clear();
            string sqlCT = @"SELECT ct.MaSach, s.TenSach, ct.SoLuong, ct.DonGiaNhap
                             FROM CTPhieuNhap ct
                             JOIN Sach s ON ct.MaSach = s.MaSach
                             WHERE ct.MaPN = @MaPN";
            using (var cmd = new SqliteCommand(sqlCT, conn))
            {
                cmd.Parameters.AddWithValue("@MaPN", maPN);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataRow row = dtCTPhieuNhap.NewRow();
                        row["MaSach"] = reader["MaSach"];
                        row["TenSach"] = reader["TenSach"];
                        row["SoLuong"] = reader.GetInt32(2);
                        row["DonGiaNhap"] = reader.GetDecimal(3);
                        dtCTPhieuNhap.Rows.Add(row);
                    }
                }
            }

            if (dtCTPhieuNhap.Rows.Count > 0)
            {
                string maSach = dtCTPhieuNhap.Rows[0]["MaSach"].ToString();
                cbTenSach.SelectedValue = maSach;

                // Lấy mã thể loại và tác giả
                string maTL = "";
                string maTG = "";
                using (var cmd = new SqliteCommand("SELECT MaTL, MaTG FROM Sach WHERE MaSach = @MaSach", conn))
                {
                    cmd.Parameters.AddWithValue("@MaSach", maSach);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            maTL = reader["MaTL"].ToString();
                            maTG = reader["MaTG"].ToString();
                        }
                    }
                }
                if (!string.IsNullOrEmpty(maTL))
                    cbTheLoai.SelectedValue = maTL;
                if (!string.IsNullOrEmpty(maTG))
                    cbTacGia.SelectedValue = maTG;
            }
        }
        private void dgvChon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChon.CurrentRow != null)
            {
                // Lấy mã sách, mã thể loại, mã tác giả từ dòng được chọn
                string maSach = dgvChon.CurrentRow.Cells["MaSach"].Value.ToString();

                // Lấy mã thể loại và mã tác giả từ database (nếu không có sẵn trong dgvChon)
                string maTL = "";
                string maTG = "";
                using (var cmd = new SqliteCommand("SELECT MaTL, MaTG FROM Sach WHERE MaSach = @MaSach", conn))
                {
                    cmd.Parameters.AddWithValue("@MaSach", maSach);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            maTL = reader["MaTL"].ToString();
                            maTG = reader["MaTG"].ToString();
                        }
                    }
                }

                // Set selected value cho các combobox
                cbTenSach.SelectedValue = maSach;
                if (!string.IsNullOrEmpty(maTL))
                    cbTheLoai.SelectedValue = maTL;
                if (!string.IsNullOrEmpty(maTG))
                    cbTacGia.SelectedValue = maTG;
            }
        }

        private void LoadComboBoxData()
        {
            // Load sách
            using (var cmd = new SqliteCommand("SELECT MaSach, TenSach FROM Sach", conn))
            using (var reader = cmd.ExecuteReader())
            {
                var dt = new DataTable();
                dt.Load(reader);
                cbTenSach.DataSource = dt;
                cbTenSach.DisplayMember = "TenSach";
                cbTenSach.ValueMember = "MaSach";
            }

            // Load thể loại
            using (var cmd = new SqliteCommand("SELECT MaTL, TenTL FROM TheLoai", conn))
            using (var reader = cmd.ExecuteReader())
            {
                var dt = new DataTable();
                dt.Load(reader);
                cbTheLoai.DataSource = dt;
                cbTheLoai.DisplayMember = "TenTL";
                cbTheLoai.ValueMember = "MaTL";
            }

            // Load tác giả
            using (var cmd = new SqliteCommand("SELECT MaTG, TenTG FROM TacGia", conn))
            using (var reader = cmd.ExecuteReader())
            {
                var dt = new DataTable();
                dt.Load(reader);
                cbTacGia.DataSource = dt;
                cbTacGia.DisplayMember = "TenTG";
                cbTacGia.ValueMember = "MaTG";
            }
        }
        private void dgvCTPN_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCTPN.CurrentRow == null) return;
            // Kiểm tra dòng hiện tại có phải là dòng mới (dòng trống cuối cùng) không
            if (dgvCTPN.CurrentRow.IsNewRow) return;

            // Kiểm tra dữ liệu cell không null trước khi gán
            var cellSoLuong = dgvCTPN.CurrentRow.Cells["SoLuong"].Value;
            var cellDonGia = dgvCTPN.CurrentRow.Cells["DonGiaNhap"].Value;

            if (cellSoLuong != null && cellDonGia != null
                && decimal.TryParse(cellSoLuong.ToString(), out decimal soLuong)
                && decimal.TryParse(cellDonGia.ToString(), out decimal donGia))
            {
                nSoLuong.Value = soLuong;
                nGia.Value = donGia;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPN = txtMa.Text.Trim();

            if (string.IsNullOrEmpty(maPN) || dtCTPhieuNhap.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu nhập và thêm ít nhất một sách.");
                return;
            }

            if (dgvCTPN.CurrentRow != null)
            {
                int rowIndex = dgvCTPN.CurrentRow.Index;
                dtCTPhieuNhap.Rows[rowIndex]["SoLuong"] = (int)nSoLuong.Value;
                dtCTPhieuNhap.Rows[rowIndex]["DonGiaNhap"] = nGia.Value;
                dgvCTPN.Refresh();
            }

            // Xác nhận sửa
            if (MessageBox.Show("Bạn có chắc chắn muốn lưu các thay đổi chi tiết phiếu nhập?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            // Xóa chi tiết cũ
            using (var cmd = new SqliteCommand("DELETE FROM CTPhieuNhap WHERE MaPN = @MaPN", conn))
            {
                cmd.Parameters.AddWithValue("@MaPN", maPN);
                cmd.ExecuteNonQuery();
            }

            // Thêm lại chi tiết mới
            foreach (DataRow row in dtCTPhieuNhap.Rows)
            {
                string sqlCT = "INSERT INTO CTPhieuNhap (MaPN, MaSach, SoLuong, DonGiaNhap) VALUES (@MaPN, @MaSach, @SoLuong, @DonGiaNhap)";
                using (var cmdCT = new SqliteCommand(sqlCT, conn))
                {
                    cmdCT.Parameters.AddWithValue("@MaPN", maPN);
                    cmdCT.Parameters.AddWithValue("@MaSach", row["MaSach"]);
                    cmdCT.Parameters.AddWithValue("@SoLuong", row["SoLuong"]);
                    cmdCT.Parameters.AddWithValue("@DonGiaNhap", row["DonGiaNhap"]);
                    cmdCT.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cập nhật chi tiết phiếu nhập thành công!");
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPN = txtMa.Text.Trim();
            if (string.IsNullOrEmpty(maPN))
            {
                MessageBox.Show("Không có mã phiếu nhập để xóa.");
                return;
            }

            // Lấy danh sách các mã sách trong phiếu nhập này
            var maSachList = new List<string>();
            using (var cmd = new SqliteCommand("SELECT MaSach FROM CTPhieuNhap WHERE MaPN = @MaPN", conn))
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
                using (var cmd = new SqliteCommand("SELECT COUNT(*) FROM CTHoaDon WHERE MaSach = @MaSach", conn))
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
                    using (var cmd = new SqliteCommand("DELETE FROM CTHoaDon WHERE MaSach = @MaSach", conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", maSach);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Xóa các hóa đơn không còn chi tiết nào
                using (var cmd = new SqliteCommand(
                    @"DELETE FROM HoaDon WHERE MaHD NOT IN (SELECT MaHD FROM CTHoaDon)", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            // Xóa chi tiết phiếu nhập
            using (var cmd = new SqliteCommand("DELETE FROM CTPhieuNhap WHERE MaPN = @MaPN", conn))
            {
                cmd.Parameters.AddWithValue("@MaPN", maPN);
                cmd.ExecuteNonQuery();
            }

            // Xóa phiếu nhập
            using (var cmd = new SqliteCommand("DELETE FROM PhieuNhap WHERE MaPN = @MaPN", conn))
            {
                cmd.Parameters.AddWithValue("@MaPN", maPN);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Đã xóa phiếu nhập và các dữ liệu liên quan!");
            this.Close();
        }

        private void SetButtonMode()
        {
            if (_mode == PhieuNhapMode.Them)
            {
                btnThem.Visible = true;
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }
            else // PhieuNhapMode.Sua
            {
                btnThem.Visible = false;
                btnSua.Visible = true;
                btnXoa.Visible = true;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            _maPN = txtMa.Text.Trim();
            _ngayNhap = dtpNgayLap.Value.ToString("dd-MM-yyyy");
            _nguoiLap = "admin";

            if (_mode == PhieuNhapMode.Them)
            {
                btnThem_Click(sender, e);
            }

            // Lấy dữ liệu chi tiết phiếu nhập
            _dtIn = new DataTable();
            _dtIn.Columns.Add("STT", typeof(int));
            _dtIn.Columns.Add("TenSach");
            _dtIn.Columns.Add("TheLoai");
            _dtIn.Columns.Add("TacGia");
            _dtIn.Columns.Add("SoLuong", typeof(int));
            _dtIn.Columns.Add("DonGiaNhap", typeof(decimal));

            using (var conn = new Microsoft.Data.Sqlite.SqliteConnection("Data Source=nha_sach.db"))
            {
                conn.Open();
                string sql = @"SELECT s.TenSach, tl.TenTL, tg.TenTG, ct.SoLuong, ct.DonGiaNhap
                               FROM CTPhieuNhap ct
                               JOIN Sach s ON ct.MaSach = s.MaSach
                               LEFT JOIN TheLoai tl ON s.MaTL = tl.MaTL
                               LEFT JOIN TacGia tg ON s.MaTG = tg.MaTG
                               WHERE ct.MaPN = @MaPN";
                using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPN", _maPN);
                    using (var reader = cmd.ExecuteReader())
                    {
                        int stt = 1;
                        while (reader.Read())
                        {
                            _dtIn.Rows.Add(
                                stt++,
                                reader["TenSach"].ToString(),
                                reader["TenTL"].ToString(),
                                reader["TenTG"].ToString(),
                                Convert.ToInt32(reader["SoLuong"]),
                                Convert.ToDecimal(reader["DonGiaNhap"])
                            );
                        }
                    }
                }
            }

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += Pd_PrintPage;
            PrintDialog dlg = new PrintDialog();
            dlg.Document = pd;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Times New Roman", 12);
            Font fontBold = new Font("Times New Roman", 12, FontStyle.Bold);

            float marginLeft = e.MarginBounds.Left;
            float marginTop = e.MarginBounds.Top;
            float tableWidth = e.MarginBounds.Width;
            float rowHeight = 28;
            float headerHeight = 28;
            float y = marginTop;

            float[] colPercents = { 0.08f, 0.22f, 0.18f, 0.18f, 0.14f, 0.20f };
            int colCount = colPercents.Length;
            float[] colWidths = new float[colCount];
            for (int i = 0; i < colCount; i++)
                colWidths[i] = tableWidth * colPercents[i];

            string[] headers = { "STT", "Sách", "Thể Loại", "Tác Giả", "Số Lượng", "Đơn Giá Nhập" };

            // --- Dòng đầu: Mã phiếu nhập và Tiêu đề ---
            float maPNWidth = colWidths[0] + colWidths[1];
            float titleWidth = tableWidth - maPNWidth;

            // Mã phiếu nhập (sát trái)
            g.FillRectangle(Brushes.Black, marginLeft, y, maPNWidth, headerHeight);
            g.DrawRectangle(Pens.Black, marginLeft, y, maPNWidth, headerHeight);
            g.DrawString(_maPN ?? "", fontBold, Brushes.White,
                new RectangleF(marginLeft + 6, y, maPNWidth - 12, headerHeight),
                new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });

            // Tiêu đề căn giữa toàn bảng
            g.FillRectangle(Brushes.Black, marginLeft + maPNWidth, y, titleWidth, headerHeight);
            g.DrawRectangle(Pens.Black, marginLeft + maPNWidth, y, titleWidth, headerHeight);
            g.DrawString("Phiếu Nhập Sách", fontBold, Brushes.White,
                new RectangleF(marginLeft, y, tableWidth, headerHeight),
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            y += headerHeight;
            g.DrawRectangle(Pens.Black, marginLeft, marginTop, tableWidth, headerHeight);

            // --- Dòng ngày nhập ---
            float dateRowHeight = 28;
            g.DrawRectangle(Pens.Black, marginLeft, y, tableWidth, dateRowHeight);
            g.DrawString($"Ngày nhập: {(_ngayNhap ?? ".................................")}", font, Brushes.Black,
                new RectangleF(marginLeft, y, tableWidth, dateRowHeight),
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            y += dateRowHeight;

            // --- Header bảng ---
            float tableX = marginLeft;
            float tableY = y;
            float colX = tableX;
            for (int i = 0; i < headers.Length; i++)
            {
                g.FillRectangle(Brushes.Black, colX, tableY, colWidths[i], headerHeight);
                g.DrawRectangle(Pens.Black, colX, tableY, colWidths[i], headerHeight);
                g.DrawString(headers[i], fontBold, Brushes.White, new RectangleF(colX, tableY, colWidths[i], headerHeight),
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                colX += colWidths[i];
            }
            y += headerHeight;

            // --- Nội dung bảng ---
            int maxRows = 10;
            int rowIdx = 0;
            foreach (DataRow row in _dtIn.Rows)
            {
                colX = tableX;
                g.DrawRectangle(Pens.Black, colX, y, colWidths[0], rowHeight);
                g.DrawString(row["STT"].ToString(), font, Brushes.Black, new RectangleF(colX, y, colWidths[0], rowHeight),
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                colX += colWidths[0];

                g.DrawRectangle(Pens.Black, colX, y, colWidths[1], rowHeight);
                g.DrawString(row["TenSach"].ToString(), font, Brushes.Black, new RectangleF(colX, y, colWidths[1], rowHeight),
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                colX += colWidths[1];

                g.DrawRectangle(Pens.Black, colX, y, colWidths[2], rowHeight);
                g.DrawString(row["TheLoai"].ToString(), font, Brushes.Black, new RectangleF(colX, y, colWidths[2], rowHeight),
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                colX += colWidths[2];

                g.DrawRectangle(Pens.Black, colX, y, colWidths[3], rowHeight);
                g.DrawString(row["TacGia"].ToString(), font, Brushes.Black, new RectangleF(colX, y, colWidths[3], rowHeight),
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                colX += colWidths[3];

                g.DrawRectangle(Pens.Black, colX, y, colWidths[4], rowHeight);
                g.DrawString(row["SoLuong"].ToString(), font, Brushes.Black, new RectangleF(colX, y, colWidths[4], rowHeight),
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                colX += colWidths[4];

                g.DrawRectangle(Pens.Black, colX, y, colWidths[5], rowHeight);
                g.DrawString(string.Format("{0:N0}", row["DonGiaNhap"]), font, Brushes.Black, new RectangleF(colX, y, colWidths[5], rowHeight),
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                colX += colWidths[5];

                y += rowHeight;
                rowIdx++;
                if (rowIdx >= maxRows) break;
            }

            for (; rowIdx < maxRows; rowIdx++)
            {
                colX = tableX;
                for (int i = 0; i < headers.Length; i++)
                {
                    g.DrawRectangle(Pens.Black, colX, y, colWidths[i], rowHeight);
                    colX += colWidths[i];
                }
                y += rowHeight;
            }

            float tableHeight = headerHeight + maxRows * rowHeight;
            g.DrawRectangle(Pens.Black, tableX, tableY, tableWidth, tableHeight);

            e.HasMorePages = false;
        }
    }
}
