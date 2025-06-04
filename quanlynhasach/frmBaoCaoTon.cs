using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace quanlynhasach
{
    public partial class frmBaoCaoTon : Form
    {
        private PrintDocument printDocument = new PrintDocument();

        public frmBaoCaoTon()
        {
            InitializeComponent();
            dtp.Value = DateTime.Now;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "MM-yyyy";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            printDocument.PrintPage -= PrintDocument_PrintPage;
            printDocument.PrintPage += PrintDocument_PrintPage;
            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };
            preview.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Đảm bảo dgv không null và có dữ liệu
            if (dgv == null || dgv.Rows == null)
            {
                e.Graphics.DrawString("Không có dữ liệu để in.", new Font("Arial", 12), Brushes.Black, 100, 100);
                e.HasMorePages = false;
                return;
            }

            Font fontHeader = new Font("Arial", 14, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 11);
            Font fontTableHeader = new Font("Arial", 11, FontStyle.Bold);
            Pen blackPen = new Pen(Color.Black, 1);

            float x = 50;
            float y = 50;
            float rowHeight = 32;
            float colSTT = 50;
            float colSach = 250;
            float colTonDau = 100;
            float colPhatSinh = 120;
            float colTonCuoi = 120;

            // Draw BM5.1 and Title
            e.Graphics.FillRectangle(Brushes.Black, x, y, colSTT, rowHeight);
            e.Graphics.DrawRectangle(blackPen, x, y, colSTT, rowHeight);
            e.Graphics.DrawString("BM5.1", fontTableHeader, Brushes.White, x + 8, y + 7);

            e.Graphics.FillRectangle(Brushes.Black, x + colSTT, y, colSach + colTonDau + colPhatSinh + colTonCuoi, rowHeight);
            e.Graphics.DrawRectangle(blackPen, x + colSTT, y, colSach + colTonDau + colPhatSinh + colTonCuoi, rowHeight);
            e.Graphics.DrawString("Báo Cáo Tồn", fontHeader, Brushes.White, x + colSTT + 10, y + 5);

            y += rowHeight;

            // Draw Month
            string thang = dtp.Value.ToString("MM/yyyy");
            e.Graphics.DrawString($"Tháng: {thang}", fontNormal, Brushes.Black, x + 10, y + 10);
            y += rowHeight;

            // Draw table headers
            float colX = x;
            e.Graphics.FillRectangle(Brushes.Black, colX, y, colSTT, rowHeight);
            e.Graphics.DrawRectangle(blackPen, colX, y, colSTT, rowHeight);
            e.Graphics.DrawString("STT", fontTableHeader, Brushes.White, colX + 10, y + 7);
            colX += colSTT;

            e.Graphics.FillRectangle(Brushes.Black, colX, y, colSach, rowHeight);
            e.Graphics.DrawRectangle(blackPen, colX, y, colSach, rowHeight);
            e.Graphics.DrawString("Sách", fontTableHeader, Brushes.White, colX + 10, y + 7);
            colX += colSach;

            e.Graphics.FillRectangle(Brushes.Black, colX, y, colTonDau, rowHeight);
            e.Graphics.DrawRectangle(blackPen, colX, y, colTonDau, rowHeight);
            e.Graphics.DrawString("Tồn Đầu", fontTableHeader, Brushes.White, colX + 10, y + 7);
            colX += colTonDau;

            e.Graphics.FillRectangle(Brushes.Black, colX, y, colPhatSinh, rowHeight);
            e.Graphics.DrawRectangle(blackPen, colX, y, colPhatSinh, rowHeight);
            e.Graphics.DrawString("Phát Sinh", fontTableHeader, Brushes.White, colX + 10, y + 7);
            colX += colPhatSinh;

            e.Graphics.FillRectangle(Brushes.Black, colX, y, colTonCuoi, rowHeight);
            e.Graphics.DrawRectangle(blackPen, colX, y, colTonCuoi, rowHeight);
            e.Graphics.DrawString("Tồn Cuối", fontTableHeader, Brushes.White, colX + 10, y + 7);

            y += rowHeight;

            // Print data rows
            int stt = 1;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                colX = x;
                e.Graphics.DrawRectangle(blackPen, colX, y, colSTT, rowHeight);
                e.Graphics.DrawString(stt.ToString(), fontNormal, Brushes.Black, colX + 15, y + 7);
                colX += colSTT;

                e.Graphics.DrawRectangle(blackPen, colX, y, colSach, rowHeight);
                e.Graphics.DrawString(row.Cells["TenSach"].Value?.ToString() ?? "", fontNormal, Brushes.Black, colX + 8, y + 7);
                colX += colSach;

                e.Graphics.DrawRectangle(blackPen, colX, y, colTonDau, rowHeight);
                e.Graphics.DrawString(row.Cells["TonDau"].Value?.ToString() ?? "0", fontNormal, Brushes.Black, colX + 15, y + 7);
                colX += colTonDau;

                e.Graphics.DrawRectangle(blackPen, colX, y, colPhatSinh, rowHeight);
                e.Graphics.DrawString(row.Cells["Nhap"].Value?.ToString() ?? "0", fontNormal, Brushes.Black, colX + 15, y + 7);
                colX += colPhatSinh;

                e.Graphics.DrawRectangle(blackPen, colX, y, colTonCuoi, rowHeight);
                e.Graphics.DrawString(row.Cells["TonCuoi"].Value?.ToString() ?? "0", fontNormal, Brushes.Black, colX + 15, y + 7);
                y += rowHeight;
                stt++;
                if (y > e.MarginBounds.Bottom - rowHeight)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
            e.HasMorePages = false;
        }

        private void frmBaoCaoTon_Load(object sender, EventArgs e)
        {
            LoadTonKho();
        }

        private void LoadTonKho()
        {
            var dt = new DataTable();
            dt.Columns.Add("MaSach");
            dt.Columns.Add("TenSach");
            dt.Columns.Add("TonDau", typeof(int));
            dt.Columns.Add("Nhap", typeof(int));
            dt.Columns.Add("Xuat", typeof(int));
            dt.Columns.Add("TonCuoi", typeof(int));

            string dbPath = "nha_sach.db";
            using (var conn = new Microsoft.Data.Sqlite.SqliteConnection($"Data Source={dbPath}"))
            {
                conn.Open();
                string sql = @"
CREATE TABLE IF NOT EXISTS TonDauKy (
    MaSach TEXT,
    Ngay DATE,
    SoLuong INTEGER,
    PRIMARY KEY (MaSach, Ngay),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
);

SELECT 
    s.MaSach, 
    s.TenSach,
    IFNULL(td.TonDau, 0) AS TonDau,
    IFNULL(nh.Nhap, 0) AS Nhap,
    IFNULL(xh.Xuat, 0) AS Xuat,
    (IFNULL(td.TonDau, 0) + IFNULL(nh.Nhap, 0) - IFNULL(xh.Xuat, 0)) AS TonCuoi
FROM Sach s
LEFT JOIN (
    SELECT MaSach, SUM(SoLuong) AS TonDau
    FROM TonDauKy
    WHERE strftime('%m-%Y', Ngay) = @ThangNam
    GROUP BY MaSach
) td ON s.MaSach = td.MaSach
LEFT JOIN (
    SELECT ctpn.MaSach, SUM(ctpn.SoLuong) AS Nhap
    FROM PhieuNhap pn
    JOIN CTPhieuNhap ctpn ON pn.MaPN = ctpn.MaPN
    WHERE strftime('%m-%Y', pn.NgayNhap) = @ThangNam
    GROUP BY ctpn.MaSach
) nh ON s.MaSach = nh.MaSach
LEFT JOIN (
    SELECT ct.MaSach, SUM(ct.SoLuong) AS Xuat
    FROM HoaDon hd
    JOIN CTHoaDon ct ON hd.MaHD = ct.MaHD
    WHERE strftime('%m-%Y', hd.NgayLap) = @ThangNam
    GROUP BY ct.MaSach
) xh ON s.MaSach = xh.MaSach
ORDER BY s.MaSach
";
                using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand(sql, conn))
                {
                    string thangNam = dtp.Value.ToString("MM-yyyy");
                    cmd.Parameters.AddWithValue("@ThangNam", thangNam);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dt.Rows.Add(
                                reader["MaSach"],
                                reader["TenSach"],
                                reader["TonDau"],
                                reader["Nhap"],
                                reader["Xuat"],
                                reader["TonCuoi"]
                            );
                        }
                    }
                }
            }
            dgv.DataSource = dt;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            frmBaoCaoTon_Load(this, EventArgs.Empty);
        }
    }
}
