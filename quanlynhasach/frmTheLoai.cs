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
    public partial class frmTheLoai : Form
    {
        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void frmTheLoai_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();

        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtGhiChu.Clear();
            txtTen.Clear();
        }
    }
}
