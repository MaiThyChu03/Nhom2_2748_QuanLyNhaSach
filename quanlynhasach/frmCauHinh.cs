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
            nQD1_1.Value = 150;
            nQD1_2.Value = 300;
            nQD2_1.Value = 20000;
            nQD2_2.Value = 20;
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            nQD1_1.Value = 150;
            nQD1_2.Value = 300;
            nQD2_1.Value = 20000;
            nQD2_2.Value = 20;
            checkQD1_1.Checked=true;
            checkQD1_2.Checked=true;
            checkQD2_1.Checked=true;
            checkQD2_2.Checked = true;
        }
    }
}
