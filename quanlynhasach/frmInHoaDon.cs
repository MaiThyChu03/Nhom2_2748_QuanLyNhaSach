using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhasach
{
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon(string maHD, string tenKH, string ngayLap, DataTable chiTiet)
        {
            InitializeComponent();
            txtMaHD.Text = maHD;
            txtTen.Text = tenKH;
            dtpNgayLap.Text = ngayLap;
            dgvInHoaDon.DataSource = chiTiet;
        }
    }
}
