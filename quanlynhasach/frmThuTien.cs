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

namespace quanlynhasach
{
    public partial class frmThuTien : Form
    {
        public static string TenThem;
        public frmThuTien()
        {
            InitializeComponent();
            dtpNgayLap.Value = DateTime.Now;
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.CustomFormat = "dd-MM-yyyy HH:mm:ss";
        }

        private void frmThuTien_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_KH_Click(object sender, EventArgs e)
        {
            frmThem formThem = new frmThem();
            formThem.LoadFormConVaoPanel(new frmKhachHang());
            TenThem = "Khách hàng";
            formThem.labelThem.Text = "        " + TenThem;
            formThem.ShowDialog();
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
