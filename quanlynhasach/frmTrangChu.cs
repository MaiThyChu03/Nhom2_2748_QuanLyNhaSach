using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static quanlynhasach.frmDoiMK;

namespace quanlynhasach
{
    public partial class frmTrangChu : Form
    {
        private string connectionString = "Data Source=nha_sach.db;";
        public Label labelName => lbName;
        public TableLayoutPanel tableLayoutPanelMenu => tlpMenu;
        public Button buttonGioiThieu => btnGioiThieu;
        public Button buttonNguoiDung => btnNguoiDung;
        public Button buttonBaoCaoTon => btnBaoCaoTon;
        public Button buttonBaoCaoCongNo => btnBaocaoCongNo;

        public frmTrangChu()
        {
            InitializeComponent();
        }

        public void LoadFormConVaoPanel(Form formCon)
        {
            pBody.Controls.Clear();
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            pBody.Controls.Add(formCon);
            pBody.Tag = formCon;
            formCon.Show();
        }
        public void LoadControl(Panel pControl, DataGridView dgv)
        {
            pBody.Controls.Clear();
            pBody.Controls.Add(pControl);
            pBody.Controls.Add(dgv);
        }

        private void DoiMauKhiChon(Button nutDuocChon)
        {
            foreach (Control control in tlpMenu.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = ColorTranslator.FromHtml("#507DBC");
                    btn.ForeColor = ColorTranslator.FromHtml("#DAE3E5");

                }
            }

            nutDuocChon.BackColor = ColorTranslator.FromHtml("#04080F");
            nutDuocChon.ForeColor = ColorTranslator.FromHtml("#DAE3E5");

        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            LoadFormConVaoPanel(new frmGioiThieu());
        }


        private void btnSach_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmSach());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmKhachHang());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadControl(pNav, dgv);
            lbTenChucNang.Text = "DANH SÁCH HÓA ĐƠN";


        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadControl(pNav, dgv);
            lbTenChucNang.Text = "DANH SÁCH PHIẾU NHẬP SÁCH";

        }

        private void btnThuTien_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmThuTien());

        }

        private void btnBaoCaoTon_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmBaoCaoTon());

        }


        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmTheLoai());

        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmTacGia());

        }

        private void btnBaocaoCongNo_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmBaoCaoCongNo());

        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmNguoiDung());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lbTenChucNang.Text == "DANH SÁCH HÓA ĐƠN")
            {
                frmHoaDon frmHoaDon = new frmHoaDon();
                frmHoaDon.ShowDialog();
            }
            else if (lbTenChucNang.Text == "DANH SÁCH PHIẾU NHẬP SÁCH")
            {
                frmPhieuNhapSach frmPhieuNhapSach = new frmPhieuNhapSach();
                frmPhieuNhapSach.ShowDialog();
            }
            else
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lbTenChucNang.Text == "DANH SÁCH HÓA ĐƠN")
            {
                frmHoaDon frmHoaDon = new frmHoaDon();
                frmHoaDon.ShowDialog();
            }
            else if (lbTenChucNang.Text == "DANH SÁCH PHIẾU NHẬP SÁCH")
            {
                frmPhieuNhapSach frmPhieuNhapSach = new frmPhieuNhapSach();
                frmPhieuNhapSach.ShowDialog();
            }
            else
            {

            }
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            LoadFormConVaoPanel(new frmGioiThieu());
        }

        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            DoiMauKhiChon((Button)sender);
            frmCauHinh frmCauHinh = new frmCauHinh();
            frmCauHinh.ShowDialog();
        }
        private void btnDoiMK_Click(object sender, EventArgs e)
        {

            string tenDangNhap = frmDangNhap.UserID;
            frmDoiMK frmDoiMK = new frmDoiMK(tenDangNhap);
            frmDoiMK.ShowDialog();
        }
    }
}
