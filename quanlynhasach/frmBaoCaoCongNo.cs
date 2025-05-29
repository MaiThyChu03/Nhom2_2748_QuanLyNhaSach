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
    public partial class frmBaoCaoCongNo : Form
    {
        public frmBaoCaoCongNo()
        {
            InitializeComponent();
            dtp.Value = DateTime.Now;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "MM-yyyy";
        }

    }
}
