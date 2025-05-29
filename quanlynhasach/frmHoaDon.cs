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
using static quanlynhasach.frmThem;
namespace quanlynhasach
{
    public partial class frmHoaDon : Form
    {
        public static string TenThem;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public frmHoaDon()
        {
            InitializeComponent();
            dtpNgayLap.Value = DateTime.Now;
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.CustomFormat = "dd-MM-yyyy HH:mm:ss";
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


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();

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

        }

        private void btnThem_KH_Click(object sender, EventArgs e)
        {
            frmThem formThem = new frmThem();
            formThem.LoadFormConVaoPanel(new frmKhachHang());
            TenThem = "KHÁCH HÀNG";
            formThem.labelThem.Text = "        " + TenThem;
            formThem.ShowDialog();
        }
    }
}
    