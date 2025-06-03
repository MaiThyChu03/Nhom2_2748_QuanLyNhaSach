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
    public partial class frmInPhieuNhapSach : Form
    {
        public frmInPhieuNhapSach(string maPN, string ngayNhap, DataTable chiTiet)
        {
            InitializeComponent();
            txtMaPN.Text = maPN;
            dtpNgayNhap.Text = ngayNhap;
            dgvInPhieuNhapSach.DataSource = chiTiet;
           
        }
    }
}
