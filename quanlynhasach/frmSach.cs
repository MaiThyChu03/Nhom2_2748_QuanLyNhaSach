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
    public partial class frmSach : Form
    {
        public static string TenThem;
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Click(object sender, EventArgs e)
        {

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
    }
}
