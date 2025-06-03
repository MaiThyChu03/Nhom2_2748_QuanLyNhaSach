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
using System.Drawing.Printing;

namespace quanlynhasach
{
    public partial class frmBaoCaoCongNo : Form
    {
        private string printContent = "";
        private PrintDocument printDocument = new PrintDocument();

        public frmBaoCaoCongNo()
        {
            InitializeComponent();
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "MM-yyyy";
        }

        private void frmBaoCaoCongNo_Load(object sender, EventArgs e)
        {
            LoadDebtReport();
        }

        private void LoadDebtReport()
        {
            var dt = new DataTable();
            dt.Columns.Add("MaKH");
            dt.Columns.Add("HoTen");
            dt.Columns.Add("TongNo", typeof(decimal));

            string dbPath = "nha_sach.db";
            using (var conn = new SqliteConnection($"Data Source={dbPath}"))
            {
                conn.Open();
                string sql = @"
SELECT 
    kh.MaKH, 
    kh.HoTen,
    IFNULL(hd.TongTien, 0) - IFNULL(ptt.DaThu, 0) AS TongNo
FROM KhachHang kh
LEFT JOIN (
    SELECT hd.MaKH, SUM(ct.SoLuong * ct.DonGia) AS TongTien
    FROM HoaDon hd
    JOIN CTHoaDon ct ON hd.MaHD = ct.MaHD
    GROUP BY hd.MaKH
) hd ON kh.MaKH = hd.MaKH
LEFT JOIN (
    SELECT MaKH, SUM(SoTien) AS DaThu
    FROM PhieuThuTien
    GROUP BY MaKH
) ptt ON kh.MaKH = ptt.MaKH
WHERE (IFNULL(hd.TongTien, 0) - IFNULL(ptt.DaThu, 0)) > 0
ORDER BY TongNo DESC
";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dt.Rows.Add(reader["MaKH"], reader["HoTen"], reader["TongNo"]);
                        }
                    }
                }
            }

            dgv.DataSource = dt;
            printContent = GeneratePrintContent(dt); // Cập nhật nội dung in
        }

        private string GeneratePrintContent(DataTable dt)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Debt Report");
            sb.AppendLine("------------");
            foreach (DataRow row in dt.Rows)
            {
                sb.AppendLine($"Customer ID: {row["MaKH"]}, Name: {row["HoTen"]}, Total Debt: {row["TongNo"]}");
            }
            return sb.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            printDocument.PrintPage -= PrintDocument_PrintPage; // Đảm bảo không bị đăng ký nhiều lần
            printDocument.PrintPage += PrintDocument_PrintPage;
            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };
            preview.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument.PrintPage += PrintDocument_PrintPage;
            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDocument
            };
            preview.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fontHeader = new Font("Arial", 14, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 11);
            Font fontTableHeader = new Font("Arial", 11, FontStyle.Bold);
            Pen blackPen = new Pen(Color.Black, 1);

            float x = 50;
            float y = 50;
            float rowHeight = 32;
            // Chia lại tỷ lệ cột cho cân đối, tổng width = 600
            float colSTT = 50;
            float colKhachHang = 200;
            float colNoDau = 100;
            float colPhatSinh = 120;
            float colNoCuoi = 130;

            // Draw BM5.2 and Title
            e.Graphics.FillRectangle(Brushes.Black, x, y, colSTT, rowHeight);
            e.Graphics.DrawRectangle(blackPen, x, y, colSTT, rowHeight);
            e.Graphics.DrawString("BM5.2", fontTableHeader, Brushes.White, x + 8, y + 7);

            e.Graphics.FillRectangle(Brushes.Black, x + colSTT, y, colKhachHang + colNoDau + colPhatSinh + colNoCuoi, rowHeight);
            e.Graphics.DrawRectangle(blackPen, x + colSTT, y, colKhachHang + colNoDau + colPhatSinh + colNoCuoi, rowHeight);
            e.Graphics.DrawString("Báo Cáo Công Nợ", fontHeader, Brushes.White, x + colSTT + 10, y + 5);

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

            e.Graphics.FillRectangle(Brushes.Black, colX, y, colKhachHang, rowHeight);
            e.Graphics.DrawRectangle(blackPen, colX, y, colKhachHang, rowHeight);
            e.Graphics.DrawString("Khách Hàng", fontTableHeader, Brushes.White, colX + 10, y + 7);
            colX += colKhachHang;

            e.Graphics.FillRectangle(Brushes.Black, colX, y, colNoDau, rowHeight);
            e.Graphics.DrawRectangle(blackPen, colX, y, colNoDau, rowHeight);
            e.Graphics.DrawString("Nợ Đầu", fontTableHeader, Brushes.White, colX + 10, y + 7);
            colX += colNoDau;

            e.Graphics.FillRectangle(Brushes.Black, colX, y, colPhatSinh, rowHeight);
            e.Graphics.DrawRectangle(blackPen, colX, y, colPhatSinh, rowHeight);
            e.Graphics.DrawString("Phát Sinh", fontTableHeader, Brushes.White, colX + 10, y + 7);
            colX += colPhatSinh;

            e.Graphics.FillRectangle(Brushes.Black, colX, y, colNoCuoi, rowHeight);
            e.Graphics.DrawRectangle(blackPen, colX, y, colNoCuoi, rowHeight);
            e.Graphics.DrawString("Nợ Cuối", fontTableHeader, Brushes.White, colX + 10, y + 7);

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

                e.Graphics.DrawRectangle(blackPen, colX, y, colKhachHang, rowHeight);
                e.Graphics.DrawString(row.Cells["HoTen"].Value?.ToString(), fontNormal, Brushes.Black, colX + 8, y + 7);
                colX += colKhachHang;

                e.Graphics.DrawRectangle(blackPen, colX, y, colNoDau, rowHeight);
                e.Graphics.DrawString("0", fontNormal, Brushes.Black, colX + 15, y + 7); // Nợ đầu: placeholder
                colX += colNoDau;

                e.Graphics.DrawRectangle(blackPen, colX, y, colPhatSinh, rowHeight);
                e.Graphics.DrawString("0", fontNormal, Brushes.Black, colX + 15, y + 7); // Phát sinh: placeholder
                colX += colPhatSinh;

                e.Graphics.DrawRectangle(blackPen, colX, y, colNoCuoi, rowHeight);
                e.Graphics.DrawString(row.Cells["TongNo"].Value?.ToString(), fontNormal, Brushes.Black, colX + 15, y + 7);
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
    }
}
