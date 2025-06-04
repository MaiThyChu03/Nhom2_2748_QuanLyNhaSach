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

namespace quanlynhasach
{
    public partial class frmCauHinh : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        public frmCauHinh()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void frmCauHinh_Load(object sender, EventArgs e)
        {
            nQD2_1.Value = decimal.Parse(LoadConfig("QD02_SoTienNoToiDa", "0"));
            checkQD2_1.Checked = LoadConfig("QD02_ApDung", "0") == "1";
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            nQD2_1.Value = 20000;
            checkQD2_1.Checked = true;
            SaveConfig("QD02_SoTienNoToiDa", nQD2_1.Value.ToString());
            SaveConfig("QD02_ApDung", checkQD2_1.Checked ? "1" : "0");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {            SaveConfig("QD02_SoTienNoToiDa", nQD2_1.Value.ToString());
            SaveConfig("QD02_ApDung", checkQD2_1.Checked ? "1" : "0");
            MessageBox.Show("Đã lưu cấu hình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveConfig(string key, string value)
        {
            using var conn = new SqliteConnection("Data Source=nha_sach.db");
            conn.Open();

            string createCauHinhTable = @"
                CREATE TABLE IF NOT EXISTS CauHinh (
                    [Key] TEXT PRIMARY KEY,
                    [Value] TEXT
                );
            ";
            using (var cmdCauHinh = new SqliteCommand(createCauHinhTable, conn))
            {
                cmdCauHinh.ExecuteNonQuery();
            }

            string sql = "INSERT INTO CauHinh([Key], [Value]) VALUES(@Key, @Value) " +
                         "ON CONFLICT([Key]) DO UPDATE SET [Value]=excluded.[Value]";
            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Key", key);
            cmd.Parameters.AddWithValue("@Value", value);
            cmd.ExecuteNonQuery();
        }

        private string LoadConfig(string key, string defaultValue = "0")
        {
            using var conn = new SqliteConnection("Data Source=nha_sach.db");
            conn.Open();
            string createCauHinhTable = @"
                CREATE TABLE IF NOT EXISTS CauHinh (
                    [Key] TEXT PRIMARY KEY,
                    [Value] TEXT
                );
            ";
            using (var cmdCauHinh = new SqliteCommand(createCauHinhTable, conn))
            {
                cmdCauHinh.ExecuteNonQuery();
            }

            string sql = "SELECT [Value] FROM CauHinh WHERE [Key]=@Key";
            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Key", key);
            var result = cmd.ExecuteScalar();
            return result?.ToString() ?? defaultValue;
        }
    }
}
