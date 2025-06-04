using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using static quanlynhasach.frmThem;

namespace quanlynhasach
{
    public partial class frmHoaDon : Form
    {
        public static string TenThem;
        private SqliteConnection conn;
        private DataTable dtSach;
        private DataTable dtCTHD;
        private DataTable _dtIn; // Lưu tạm dữ liệu để in
        private string _maHD, _ngayLap, _tenKH;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public enum HoaDonMode { Them, Sua }
        private HoaDonMode _mode = HoaDonMode.Them;

        public frmHoaDon()
        {
            InitializeComponent();
            dtpNgayLap.Value = DateTime.Now;
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            ConnectDatabase();
            LoadKhachHang();
            LoadSachNhap();
            InitCTHD();
            SetButtonMode();
        }

        public frmHoaDon(HoaDonMode mode)
            : this()
        {
            _mode = mode;
            SetButtonMode();
        }

        public frmHoaDon(string maHD) : this(HoaDonMode.Sua)
        {
            LoadHoaDon(maHD);
        }

        private void ConnectDatabase()
        {
            conn = new SqliteConnection("Data Source=nha_sach.db");
            conn.Open();
        }

        private void LoadSachNhap()
        {
            string query = @"
                SELECT 
                    ctpn.MaSach, 
                    s.TenSach, 
                    ctpn.SoLuong AS SoLuongNhap, 
                    ctpn.DonGiaNhap, 
                    ctpn.MaPN
                FROM CTPhieuNhap ctpn
                JOIN Sach s ON ctpn.MaSach = s.MaSach
                ORDER BY ctpn.MaSach, ctpn.MaPN DESC
            ";
            dtSach = new DataTable();
            using (var cmd = new SqliteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                dtSach.Load(reader);
            }
            dgvChon.DataSource = dtSach;
        }

        private void InitCTHD()
        {
            dtCTHD = new DataTable();
            dtCTHD.Columns.Add("MaSach");
            dtCTHD.Columns.Add("TenSach");
            dtCTHD.Columns.Add("SoLuong", typeof(int));
            dtCTHD.Columns.Add("DonGia", typeof(decimal));
            dtCTHD.Columns.Add("ThanhTien", typeof(decimal));
            dgvCTHD.DataSource = dtCTHD;
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (dgvChon.CurrentRow != null)
            {
                string maSach = dgvChon.CurrentRow.Cells["MaSach"].Value.ToString();
                string tenSach = dgvChon.CurrentRow.Cells["TenSach"].Value.ToString();
                string maPN = dgvChon.CurrentRow.Cells["MaPN"].Value.ToString();
                int soLuongNhap = Convert.ToInt32(dgvChon.CurrentRow.Cells["SoLuongNhap"].Value);
                decimal donGiaNhap = Convert.ToDecimal(dgvChon.CurrentRow.Cells["DonGiaNhap"].Value);

                int soLuong = (int)nSoLuong.Value;
                decimal DonGia = Math.Round(donGiaNhap * 1.05m, 2);

                if (soLuong <= 0 || soLuong > soLuongNhap)
                {
                    MessageBox.Show("Số lượng bán phải lớn hơn 0 và không vượt quá số lượng nhập.");
                    return;
                }

                // Kiểm tra trùng mã sách và đơn giá bán để gộp số lượng
                foreach (DataRow row in dtCTHD.Rows)
                {
                    if (row["MaSach"].ToString() == maSach && Convert.ToDecimal(row["DonGia"]) == DonGia)
                    {
                        int soLuongHienTai = Convert.ToInt32(row["SoLuong"]);
                        int tongSoLuong = soLuongHienTai + soLuong;
                        if (tongSoLuong > soLuongNhap)
                        {
                            MessageBox.Show("Tổng số lượng bán vượt quá số lượng nhập.");
                            return;
                        }
                        row["SoLuong"] = tongSoLuong;
                        row["ThanhTien"] = tongSoLuong * DonGia;
                        dgvCTHD.Refresh();
                        return;
                    }
                }

                // Có thể kiểm tra trùng mã sách + mã phiếu nhập nếu muốn gom dòng
                DataRow newRow = dtCTHD.NewRow();
                newRow["MaSach"] = maSach;
                newRow["TenSach"] = tenSach;
                newRow["SoLuong"] = soLuong;
                newRow["DonGia"] = DonGia;
                newRow["ThanhTien"] = soLuong * DonGia;
                // Nếu muốn lưu MaPN để truy vết, có thể thêm cột MaPN vào dtCTHD
                dtCTHD.Rows.Add(newRow);
            }
        }


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



        private void lbThem_Click(object sender, EventArgs e)
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

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            _maHD = txtMa.Text.Trim();
            _ngayLap = dtpNgayLap.Value.ToString("dd-MM-yyyy");
            _tenKH = txtTen.Text.Trim();

            if (_mode == HoaDonMode.Them)
            {
                btnThem_Click(sender, e);
            }

            // Lấy dữ liệu chi tiết hóa đơn để in
            _dtIn = new DataTable();
            _dtIn.Columns.Add("STT", typeof(int));
            _dtIn.Columns.Add("TenSach");
            _dtIn.Columns.Add("TheLoai");
            _dtIn.Columns.Add("SoLuong", typeof(int));
            _dtIn.Columns.Add("DonGia", typeof(decimal));

            using (var conn = new Microsoft.Data.Sqlite.SqliteConnection("Data Source=nha_sach.db"))
            {
                conn.Open();
                string sql = @"SELECT s.TenSach, tl.TenTL, ct.SoLuong, ct.DonGia
                               FROM CTHoaDon ct
                               JOIN Sach s ON ct.MaSach = s.MaSach
                               LEFT JOIN TheLoai tl ON s.MaTL = tl.MaTL
                               WHERE ct.MaHD = @MaHD";
                using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", _maHD);
                    using (var reader = cmd.ExecuteReader())
                    {
                        int stt = 1;
                        while (reader.Read())
                        {
                            _dtIn.Rows.Add(
                                stt++,
                                reader["TenSach"].ToString(),
                                reader["TenTL"].ToString(),
                                Convert.ToInt32(reader["SoLuong"]),
                                Convert.ToDecimal(reader["DonGia"])
                            );
                        }
                    }
                }
            }

            // In trực tiếp
            var pd = new System.Drawing.Printing.PrintDocument();
            pd.PrintPage += Pd_PrintPage;
            var dlg = new PrintDialog();
            dlg.Document = pd;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void Pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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

            // Tỉ lệ cột: STT, Sách, Thể Loại, Số Lượng, Đơn Giá Bán
            float[] colPercents = { 0.10f, 0.28f, 0.20f, 0.18f, 0.24f };
            int colCount = colPercents.Length;
            float[] colWidths = new float[colCount];
            for (int i = 0; i < colCount; i++)
                colWidths[i] = tableWidth * colPercents[i];

            string[] headers = { "STT", "Sách", "Thể Loại", "Số Lượng", "Đơn Giá Bán" };

            // --- Dòng đầu: BM2 và Tiêu đề ---
            float bmWidth = colWidths[0] + colWidths[1];
            float titleWidth = tableWidth - bmWidth;

            // BM2 (sát trái, là mã hóa đơn)
            g.FillRectangle(Brushes.Black, marginLeft, y, bmWidth, headerHeight);
            g.DrawRectangle(Pens.Black, marginLeft, y, bmWidth, headerHeight);
            g.DrawString(_maHD ?? "", fontBold, Brushes.White,
                new RectangleF(marginLeft + 6, y, bmWidth - 12, headerHeight),
                new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });

            // Tiêu đề căn giữa toàn bảng
            g.FillRectangle(Brushes.Black, marginLeft + bmWidth, y, titleWidth, headerHeight);
            g.DrawRectangle(Pens.Black, marginLeft + bmWidth, y, titleWidth, headerHeight);
            g.DrawString("Hóa Đơn Bán Sách", fontBold, Brushes.White,
                new RectangleF(marginLeft, y, tableWidth, headerHeight),
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            y += headerHeight;
            g.DrawRectangle(Pens.Black, marginLeft, marginTop, tableWidth, headerHeight);

            // --- Dòng thông tin khách hàng và ngày lập ---
            float infoRowHeight = 28;
            float infoColWidth = tableWidth / 2f;
            g.DrawRectangle(Pens.Black, marginLeft, y, infoColWidth, infoRowHeight);
            g.DrawRectangle(Pens.Black, marginLeft + infoColWidth, y, infoColWidth, infoRowHeight);

            g.DrawString($"Họ tên khách hàng: {_tenKH}", font, Brushes.Black,
                new RectangleF(marginLeft + 4, y, infoColWidth - 8, infoRowHeight),
                new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });

            g.DrawString($"Ngày lập hóa đơn: {_ngayLap}", font, Brushes.Black,
                new RectangleF(marginLeft + infoColWidth + 4, y, infoColWidth - 8, infoRowHeight),
                new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });

            y += infoRowHeight;

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
                g.DrawString(row["SoLuong"].ToString(), font, Brushes.Black, new RectangleF(colX, y, colWidths[3], rowHeight),
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                colX += colWidths[3];

                g.DrawRectangle(Pens.Black, colX, y, colWidths[4], rowHeight);
                g.DrawString(string.Format("{0:N0}", row["DonGia"]), font, Brushes.Black, new RectangleF(colX, y, colWidths[4], rowHeight),
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                colX += colWidths[4];

                y += rowHeight;
                rowIdx++;
                if (rowIdx >= maxRows) break;
            }

            // --- Kẻ thêm dòng trống nếu chưa đủ ---
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

        private void btnThem_KH_Click(object sender, EventArgs e)
        {
            frmThem formThem = new frmThem();
            formThem.LoadFormConVaoPanel(new frmKhachHang());
            TenThem = "KHÁCH HÀNG";
            formThem.labelThem.Text = "        " + TenThem;
            formThem.ShowDialog();
        }



        private DataTable dtKhachHang;

        private void LoadKhachHang()
        {
            using (var cmd = new SqliteCommand("SELECT MaKH, HoTen, DienThoai, DiaChi, Email FROM KhachHang", conn))
            using (var reader = cmd.ExecuteReader())
            {
                dtKhachHang = new DataTable();
                dtKhachHang.Load(reader);
                cbMaKH.DataSource = dtKhachHang;
                cbMaKH.DisplayMember = "MaKH";
                cbMaKH.ValueMember = "MaKH";
            }
        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaKH.SelectedValue == null || dtKhachHang == null) return;
            DataRow[] rows = dtKhachHang.Select($"MaKH = '{cbMaKH.SelectedValue}'");
            if (rows.Length > 0)
            {
                txtTen.Text = rows[0]["HoTen"].ToString();
                txtDienThoai.Text = rows[0]["DienThoai"].ToString();
                txtDiaChi.Text = rows[0]["DiaChi"].ToString();
                txtEmail.Text = rows[0]["Email"].ToString();
            }
            else
            {
                txtTen.Text = "";
                txtDienThoai.Text = "";
                txtDiaChi.Text = "";
                txtEmail.Text = "";
            }
        }



        private void btnLoaiBoSach_Click(object sender, EventArgs e)
        {
            if (dgvCTHD.CurrentRow != null)
            {
                dgvCTHD.Rows.RemoveAt(dgvCTHD.CurrentRow.Index);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHD = txtMa.Text.Trim();
            string ngayLap = dtpNgayLap.Value.ToString("yyyy-MM-dd");
            string maKH = cbMaKH.SelectedValue?.ToString();
            string nguoiLap = "admin";

            if (maHD == "" || dtCTHD.Rows.Count == 0 || string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn, chọn khách hàng và thêm ít nhất một sách.");
                return;
            }

            string sqlHD = "INSERT INTO HoaDon (MaHD, NgayLap, MaKH, NguoiLap) VALUES (@MaHD, @NgayLap, @MaKH, @NguoiLap)";
            using (var cmd = new SqliteCommand(sqlHD, conn))
            {
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                cmd.Parameters.AddWithValue("@NgayLap", ngayLap);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@NguoiLap", nguoiLap);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại!");
                    return;
                }
            }

            foreach (DataRow row in dtCTHD.Rows)
            {
                string sqlCT = "INSERT INTO CTHoaDon (MaHD, MaSach, SoLuong, DonGia) VALUES (@MaHD, @MaSach, @SoLuong, @DonGia)";
                using (var cmdCT = new SqliteCommand(sqlCT, conn))
                {
                    cmdCT.Parameters.AddWithValue("@MaHD", maHD);
                    cmdCT.Parameters.AddWithValue("@MaSach", row["MaSach"]);
                    cmdCT.Parameters.AddWithValue("@SoLuong", row["SoLuong"]);
                    cmdCT.Parameters.AddWithValue("@DonGia", row["DonGia"]);
                    cmdCT.ExecuteNonQuery();
                }
                // Cập nhật số lượng sách trong kho
                string sqlUpdate = "UPDATE Sach SET SoLuong = SoLuong - @SoLuong WHERE MaSach = @MaSach";
                using (var cmdUpdate = new SqliteCommand(sqlUpdate, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@SoLuong", row["SoLuong"]);
                    cmdUpdate.Parameters.AddWithValue("@MaSach", row["MaSach"]);
                    cmdUpdate.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Thêm hóa đơn thành công!");
            dtCTHD.Clear();
            txtMa.Clear();
            nSoLuong.Value = 0;
            nGia.Value = 0;
            LoadSachNhap();
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHD = txtMa.Text.Trim();

            if (string.IsNullOrEmpty(maHD) || dtCTHD.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn và thêm ít nhất một sách.");
                return;
            }

            if (dgvCTHD.CurrentRow != null)
            {
                int rowIndex = dgvCTHD.CurrentRow.Index;
                dtCTHD.Rows[rowIndex]["SoLuong"] = (int)nSoLuong.Value;
                dtCTHD.Rows[rowIndex]["DonGia"] = nGia.Value;
                dgvCTHD.Refresh();
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn lưu các thay đổi chi tiết hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using (var cmd = new SqliteCommand("DELETE FROM CTHoaDon WHERE MaHD = @MaHD", conn))
            {
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                cmd.ExecuteNonQuery();
            }

            foreach (DataRow row in dtCTHD.Rows)
            {
                string sqlCT = "INSERT INTO CTHoaDon (MaHD, MaSach, SoLuong, DonGia) VALUES (@MaHD, @MaSach, @SoLuong, @DonGia)";
                using (var cmdCT = new SqliteCommand(sqlCT, conn))
                {
                    cmdCT.Parameters.AddWithValue("@MaHD", maHD);
                    cmdCT.Parameters.AddWithValue("@MaSach", row["MaSach"]);
                    cmdCT.Parameters.AddWithValue("@SoLuong", row["SoLuong"]);
                    cmdCT.Parameters.AddWithValue("@DonGia", row["DonGia"]);
                    cmdCT.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cập nhật chi tiết hóa đơn thành công!");
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHD = txtMa.Text.Trim();
            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Không có mã hóa đơn để xóa.");
                return;
            }

            // Cảnh báo người dùng về việc xóa liên quan
            var result = MessageBox.Show(
                "Nếu xóa hóa đơn này, tất cả các chi tiết hóa đơn liên quan cũng sẽ bị xóa!\nBạn có chắc chắn muốn tiếp tục?",
                "Cảnh báo xóa dữ liệu liên quan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            // Xóa chi tiết hóa đơn trước
            using (var cmd = new SqliteCommand("DELETE FROM CTHoaDon WHERE MaHD = @MaHD", conn))
            {
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                cmd.ExecuteNonQuery();
            }
            // Xóa hóa đơn
            using (var cmd = new SqliteCommand("DELETE FROM HoaDon WHERE MaHD = @MaHD", conn))
            {
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Đã xóa hóa đơn!");
            this.Close();
        }

        private void LoadHoaDon(string maHD)
        {
            // Load thông tin hóa đơn
            string sql = "SELECT MaHD, NgayLap, MaKH, NguoiLap FROM HoaDon WHERE MaHD = @MaHD";
            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtMa.Text = reader["MaHD"].ToString();
                        dtpNgayLap.Value = DateTime.Parse(reader["NgayLap"].ToString());
                        cbMaKH.SelectedValue = reader["MaKH"].ToString();
                        cbMaKH_SelectedIndexChanged(cbMaKH, EventArgs.Empty);
                    }
                }
            }

            // Load chi tiết hóa đơn
            dtCTHD.Clear();
            string sqlCT = @"SELECT ct.MaSach, s.TenSach, ct.SoLuong, ct.DonGia
                             FROM CTHoaDon ct
                             JOIN Sach s ON ct.MaSach = s.MaSach
                             WHERE ct.MaHD = @MaHD";
            using (var cmd = new SqliteCommand(sqlCT, conn))
            {
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataRow row = dtCTHD.NewRow();
                        row["MaSach"] = reader["MaSach"];
                        row["TenSach"] = reader["TenSach"];
                        row["SoLuong"] = reader.GetInt32(2);
                        row["DonGia"] = reader.GetDecimal(3);
                        row["ThanhTien"] = reader.GetInt32(2) * reader.GetDecimal(3);
                        dtCTHD.Rows.Add(row);
                    }
                }
            }
        }

        private void dgvChon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChon.CurrentRow == null) return;
            // Kiểm tra dòng hiện tại có phải là dòng mới (dòng trống cuối cùng) không
            if (dgvChon.CurrentRow.IsNewRow) return;

            // Kiểm tra dữ liệu cell không null trước khi gán
            var cellSoLuongNhap = dgvChon.CurrentRow.Cells["SoLuongNhap"].Value;
            var cellDonGiaNhap = dgvChon.CurrentRow.Cells["DonGiaNhap"].Value;

            if (cellSoLuongNhap != null && cellDonGiaNhap != null
                && decimal.TryParse(cellSoLuongNhap.ToString(), out decimal soLuongNhap)
                && decimal.TryParse(cellDonGiaNhap.ToString(), out decimal donGiaNhap))
            {
                nSoLuong.Maximum = soLuongNhap;
                nSoLuong.Value = soLuongNhap > 0 ? 1 : 0;
                decimal giaMoi = Math.Round(donGiaNhap * 1.05m, 2);
                if (giaMoi > nGia.Maximum) nGia.Maximum = giaMoi;
                if (giaMoi < nGia.Minimum) nGia.Minimum = giaMoi;
                nGia.Value = giaMoi;
                nGia.ReadOnly = true;
                nGia.Controls[0].Enabled = false;
                nGia.TabStop = false;
            }
        }


        private void dgvCTHD_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCTHD.CurrentRow == null) return;
            // Kiểm tra dòng hiện tại có phải là dòng mới (dòng trống cuối cùng) không
            if (dgvCTHD.CurrentRow.IsNewRow) return;

            // Kiểm tra dữ liệu cell không null trước khi gán
            var cellSoLuong = dgvCTHD.CurrentRow.Cells["SoLuong"].Value;
            var cellDonGia = dgvCTHD.CurrentRow.Cells["DonGia"].Value;

            if (cellSoLuong != null && cellDonGia != null
                && decimal.TryParse(cellSoLuong.ToString(), out decimal soLuong)
                && decimal.TryParse(cellDonGia.ToString(), out decimal DonGia))
            {
                if (nSoLuong.Maximum < soLuong)
                    nSoLuong.Maximum = soLuong;
                if (nSoLuong.Minimum > soLuong)
                    nSoLuong.Minimum = soLuong;
                nSoLuong.Value = soLuong;
                nGia.Value = DonGia;
            }
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                nSoLuong.Value = Convert.ToDecimal(dgvCTHD.Rows[e.RowIndex].Cells["SoLuong"].Value);
                nGia.Value = Convert.ToDecimal(dgvCTHD.Rows[e.RowIndex].Cells["DonGia"].Value);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (dtSach == null) return;
            string filter = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(filter))
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Xóa trắng các textbox
            txtMa.Clear();
            txtTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();

            // Đặt lại giá trị mặc định cho số lượng và giá
            nSoLuong.Value = 0;
            nGia.Value = 0;

            // Đặt lại ngày lập về hiện tại
            dtpNgayLap.Value = DateTime.Now;

            // Xóa chi tiết hóa đơn
            if (dtCTHD != null)
                dtCTHD.Clear();

            // Load lại danh sách khách hàng và sách nhập
            LoadKhachHang();
            LoadSachNhap();
        }

        private void SetButtonMode()
        {
            if (_mode == HoaDonMode.Them)
            {
                btnThem.Visible = true;
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }
            else // HoaDonMode.Sua
            {
                btnThem.Visible = false;
                btnSua.Visible = true;
                btnXoa.Visible = true;
            }
        }
    }
}