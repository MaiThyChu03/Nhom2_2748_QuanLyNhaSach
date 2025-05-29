namespace quanlynhasach
{
    partial class frmTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            pMenu = new Panel();
            tlpMenu = new TableLayoutPanel();
            btnCauHinh = new Button();
            btnTacGia = new Button();
            btnBaocaoCongNo = new Button();
            btnSach = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDoiMK = new Label();
            lbName = new Label();
            label1 = new Label();
            btnBaoCaoTon = new Button();
            btnKhachHang = new Button();
            btnThuTien = new Button();
            btnHoaDon = new Button();
            btnNhapSach = new Button();
            btnTheLoai = new Button();
            btnGioiThieu = new Button();
            pBody = new Panel();
            pNav = new Panel();
            pChucNang = new Panel();
            tlpDSSach = new TableLayoutPanel();
            lbTenChucNang = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dgv = new DataGridView();
            tlpTimKiem = new TableLayoutPanel();
            txtTimKiem = new TextBox();
            cbTimKiem = new ComboBox();
            btnNguoiDung = new Button();
            pMenu.SuspendLayout();
            tlpMenu.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pBody.SuspendLayout();
            pNav.SuspendLayout();
            pChucNang.SuspendLayout();
            tlpDSSach.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            tlpTimKiem.SuspendLayout();
            SuspendLayout();
            // 
            // pMenu
            // 
            pMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pMenu.BackColor = Color.FromArgb(80, 125, 188);
            pMenu.Controls.Add(tlpMenu);
            pMenu.Location = new Point(0, -3);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(234, 716);
            pMenu.TabIndex = 1;
            // 
            // tlpMenu
            // 
            tlpMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpMenu.BackColor = Color.FromArgb(80, 125, 188);
            tlpMenu.ColumnCount = 1;
            tlpMenu.ColumnStyles.Add(new ColumnStyle());
            tlpMenu.Controls.Add(btnCauHinh, 0, 10);
            tlpMenu.Controls.Add(btnTacGia, 0, 2);
            tlpMenu.Controls.Add(btnBaocaoCongNo, 0, 9);
            tlpMenu.Controls.Add(btnSach, 0, 3);
            tlpMenu.Controls.Add(panel1, 0, 0);
            tlpMenu.Controls.Add(btnBaoCaoTon, 0, 8);
            tlpMenu.Controls.Add(btnKhachHang, 0, 4);
            tlpMenu.Controls.Add(btnThuTien, 0, 7);
            tlpMenu.Controls.Add(btnHoaDon, 0, 5);
            tlpMenu.Controls.Add(btnNhapSach, 0, 6);
            tlpMenu.Controls.Add(btnTheLoai, 0, 1);
            tlpMenu.Controls.Add(btnGioiThieu, 0, 11);
            tlpMenu.ForeColor = Color.FromArgb(218, 227, 229);
            tlpMenu.Location = new Point(0, 3);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.RowCount = 12;
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 23.4768276F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 6.95609856F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 6.95609856F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 6.95609856F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 6.95609856F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 6.95609856F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 6.95609856F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 6.95609856F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 6.95609856F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 6.95609856F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 6.95609856F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 6.962184F));
            tlpMenu.Size = new Size(234, 710);
            tlpMenu.TabIndex = 1;
            // 
            // btnCauHinh
            // 
            btnCauHinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCauHinh.FlatAppearance.BorderSize = 0;
            btnCauHinh.FlatStyle = FlatStyle.Flat;
            btnCauHinh.Image = Properties.Resources.icon_cauhinh;
            btnCauHinh.ImageAlign = ContentAlignment.MiddleLeft;
            btnCauHinh.Location = new Point(3, 610);
            btnCauHinh.Name = "btnCauHinh";
            btnCauHinh.Size = new Size(231, 43);
            btnCauHinh.TabIndex = 10;
            btnCauHinh.Text = "               Cấu hình";
            btnCauHinh.TextAlign = ContentAlignment.MiddleLeft;
            btnCauHinh.UseVisualStyleBackColor = true;
            btnCauHinh.Click += btnCauHinh_Click;
            // 
            // btnTacGia
            // 
            btnTacGia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTacGia.FlatAppearance.BorderSize = 0;
            btnTacGia.FlatStyle = FlatStyle.Flat;
            btnTacGia.Image = Properties.Resources.icon_tacgia;
            btnTacGia.ImageAlign = ContentAlignment.MiddleLeft;
            btnTacGia.Location = new Point(3, 218);
            btnTacGia.Name = "btnTacGia";
            btnTacGia.Size = new Size(231, 43);
            btnTacGia.TabIndex = 1;
            btnTacGia.Text = "               Tác giả";
            btnTacGia.TextAlign = ContentAlignment.MiddleLeft;
            btnTacGia.UseVisualStyleBackColor = true;
            btnTacGia.Click += btnTacGia_Click;
            // 
            // btnBaocaoCongNo
            // 
            btnBaocaoCongNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBaocaoCongNo.FlatAppearance.BorderSize = 0;
            btnBaocaoCongNo.FlatStyle = FlatStyle.Flat;
            btnBaocaoCongNo.Image = Properties.Resources.icon_baocaocongno;
            btnBaocaoCongNo.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaocaoCongNo.Location = new Point(3, 561);
            btnBaocaoCongNo.Name = "btnBaocaoCongNo";
            btnBaocaoCongNo.Size = new Size(231, 43);
            btnBaocaoCongNo.TabIndex = 8;
            btnBaocaoCongNo.Text = "               Báo cáo công nợ";
            btnBaocaoCongNo.TextAlign = ContentAlignment.MiddleLeft;
            btnBaocaoCongNo.UseVisualStyleBackColor = true;
            btnBaocaoCongNo.Click += btnBaocaoCongNo_Click;
            // 
            // btnSach
            // 
            btnSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSach.FlatAppearance.BorderSize = 0;
            btnSach.FlatStyle = FlatStyle.Flat;
            btnSach.Image = Properties.Resources.icon_sach;
            btnSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnSach.Location = new Point(3, 267);
            btnSach.Name = "btnSach";
            btnSach.Size = new Size(231, 43);
            btnSach.TabIndex = 2;
            btnSach.Text = "               Sách";
            btnSach.TextAlign = ContentAlignment.MiddleLeft;
            btnSach.UseVisualStyleBackColor = true;
            btnSach.Click += btnSach_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 160);
            panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnDoiMK, 0, 1);
            tableLayoutPanel1.Controls.Add(lbName, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 71);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(231, 86);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDoiMK
            // 
            btnDoiMK.AutoSize = true;
            btnDoiMK.Dock = DockStyle.Fill;
            btnDoiMK.Font = new Font("Cambria", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 163);
            btnDoiMK.Location = new Point(3, 43);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(225, 43);
            btnDoiMK.TabIndex = 3;
            btnDoiMK.Text = "Đổi mật khẩu";
            btnDoiMK.TextAlign = ContentAlignment.MiddleCenter;
            btnDoiMK.Click += btnDoiMK_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Dock = DockStyle.Fill;
            lbName.Location = new Point(3, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(225, 43);
            lbName.TabIndex = 5;
            lbName.Text = "Your name";
            lbName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Image = Properties.Resources.icon_accpng;
            label1.Location = new Point(45, 32);
            label1.Name = "label1";
            label1.Size = new Size(141, 36);
            label1.TabIndex = 4;
            label1.Text = "                  ";
            // 
            // btnBaoCaoTon
            // 
            btnBaoCaoTon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBaoCaoTon.FlatAppearance.BorderSize = 0;
            btnBaoCaoTon.FlatStyle = FlatStyle.Flat;
            btnBaoCaoTon.Image = Properties.Resources.icon_baocaoton;
            btnBaoCaoTon.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoTon.Location = new Point(3, 512);
            btnBaoCaoTon.Name = "btnBaoCaoTon";
            btnBaoCaoTon.Size = new Size(231, 43);
            btnBaoCaoTon.TabIndex = 7;
            btnBaoCaoTon.Text = "               Báo cáo tồn";
            btnBaoCaoTon.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoTon.UseVisualStyleBackColor = true;
            btnBaoCaoTon.Click += btnBaoCaoTon_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Image = Properties.Resources.icon_khachhang;
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(3, 316);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(231, 43);
            btnKhachHang.TabIndex = 3;
            btnKhachHang.Text = "               Khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnThuTien
            // 
            btnThuTien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnThuTien.FlatAppearance.BorderSize = 0;
            btnThuTien.FlatStyle = FlatStyle.Flat;
            btnThuTien.Image = Properties.Resources.icon_thutien;
            btnThuTien.ImageAlign = ContentAlignment.MiddleLeft;
            btnThuTien.Location = new Point(3, 463);
            btnThuTien.Name = "btnThuTien";
            btnThuTien.Size = new Size(231, 43);
            btnThuTien.TabIndex = 6;
            btnThuTien.Text = "               Thu tiền";
            btnThuTien.TextAlign = ContentAlignment.MiddleLeft;
            btnThuTien.UseVisualStyleBackColor = true;
            btnThuTien.Click += btnThuTien_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Image = Properties.Resources.icon_hoadon;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(3, 365);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(231, 43);
            btnHoaDon.TabIndex = 4;
            btnHoaDon.Text = "               Hóa đơn";
            btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnNhapSach
            // 
            btnNhapSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNhapSach.FlatAppearance.BorderSize = 0;
            btnNhapSach.FlatStyle = FlatStyle.Flat;
            btnNhapSach.Image = Properties.Resources.icon_nhapsach;
            btnNhapSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhapSach.Location = new Point(3, 414);
            btnNhapSach.Name = "btnNhapSach";
            btnNhapSach.Size = new Size(231, 43);
            btnNhapSach.TabIndex = 5;
            btnNhapSach.Text = "               Nhập sách";
            btnNhapSach.TextAlign = ContentAlignment.MiddleLeft;
            btnNhapSach.UseVisualStyleBackColor = true;
            btnNhapSach.Click += btnNhapSach_Click;
            // 
            // btnTheLoai
            // 
            btnTheLoai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTheLoai.FlatAppearance.BorderSize = 0;
            btnTheLoai.FlatStyle = FlatStyle.Flat;
            btnTheLoai.Image = Properties.Resources.icon_theloai;
            btnTheLoai.ImageAlign = ContentAlignment.MiddleLeft;
            btnTheLoai.Location = new Point(3, 169);
            btnTheLoai.Name = "btnTheLoai";
            btnTheLoai.Size = new Size(231, 43);
            btnTheLoai.TabIndex = 0;
            btnTheLoai.Text = "               Thể loại";
            btnTheLoai.TextAlign = ContentAlignment.MiddleLeft;
            btnTheLoai.UseVisualStyleBackColor = true;
            btnTheLoai.Click += btnTheLoai_Click;
            // 
            // btnGioiThieu
            // 
            btnGioiThieu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGioiThieu.FlatAppearance.BorderSize = 0;
            btnGioiThieu.FlatStyle = FlatStyle.Flat;
            btnGioiThieu.Image = Properties.Resources.icon_gioithieu;
            btnGioiThieu.ImageAlign = ContentAlignment.MiddleLeft;
            btnGioiThieu.Location = new Point(3, 659);
            btnGioiThieu.Name = "btnGioiThieu";
            btnGioiThieu.Size = new Size(231, 48);
            btnGioiThieu.TabIndex = 10;
            btnGioiThieu.Text = "               Giới thiệu";
            btnGioiThieu.TextAlign = ContentAlignment.MiddleLeft;
            btnGioiThieu.UseVisualStyleBackColor = true;
            btnGioiThieu.Click += btnGioiThieu_Click;
            // 
            // pBody
            // 
            pBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pBody.BackColor = Color.FromArgb(187, 209, 234);
            pBody.Controls.Add(pNav);
            pBody.Controls.Add(btnNguoiDung);
            pBody.Location = new Point(237, 0);
            pBody.Name = "pBody";
            pBody.Size = new Size(1026, 713);
            pBody.TabIndex = 2;
            // 
            // pNav
            // 
            pNav.BackColor = Color.FromArgb(187, 209, 234);
            pNav.Controls.Add(pChucNang);
            pNav.Dock = DockStyle.Fill;
            pNav.Location = new Point(0, 0);
            pNav.Name = "pNav";
            pNav.Size = new Size(1026, 713);
            pNav.TabIndex = 11;
            // 
            // pChucNang
            // 
            pChucNang.Controls.Add(tlpDSSach);
            pChucNang.Controls.Add(label2);
            pChucNang.Controls.Add(pictureBox1);
            pChucNang.Controls.Add(dgv);
            pChucNang.Controls.Add(tlpTimKiem);
            pChucNang.Dock = DockStyle.Fill;
            pChucNang.Location = new Point(0, 0);
            pChucNang.Name = "pChucNang";
            pChucNang.Size = new Size(1026, 713);
            pChucNang.TabIndex = 0;
            // 
            // tlpDSSach
            // 
            tlpDSSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpDSSach.ColumnCount = 2;
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.19171F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.80829F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpDSSach.Controls.Add(lbTenChucNang, 0, 0);
            tlpDSSach.Controls.Add(tableLayoutPanel2, 1, 0);
            tlpDSSach.Location = new Point(58, 4);
            tlpDSSach.Name = "tlpDSSach";
            tlpDSSach.RowCount = 1;
            tlpDSSach.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDSSach.Size = new Size(965, 48);
            tlpDSSach.TabIndex = 41;
            // 
            // lbTenChucNang
            // 
            lbTenChucNang.Anchor = AnchorStyles.Left;
            lbTenChucNang.AutoSize = true;
            lbTenChucNang.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbTenChucNang.ForeColor = Color.FromArgb(4, 8, 15);
            lbTenChucNang.Location = new Point(3, 7);
            lbTenChucNang.Name = "lbTenChucNang";
            lbTenChucNang.Size = new Size(318, 33);
            lbTenChucNang.TabIndex = 8;
            lbTenChucNang.Text = "DANH SÁCH bla blaaaaa";
            lbTenChucNang.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.7033F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.4835167F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.8131886F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(btnXoa, 2, 0);
            tableLayoutPanel2.Controls.Add(btnSua, 1, 0);
            tableLayoutPanel2.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel2.Location = new Point(497, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(465, 42);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(217, 234, 248);
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.Image = Properties.Resources.tt_xoa;
            btnXoa.Location = new Point(342, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 36);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "     Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(217, 234, 248);
            btnSua.Dock = DockStyle.Fill;
            btnSua.Image = Properties.Resources.tt_sua;
            btnSua.Location = new Point(173, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(163, 36);
            btnSua.TabIndex = 8;
            btnSua.Text = "     Chỉnh sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(217, 234, 248);
            btnThem.Dock = DockStyle.Fill;
            btnThem.Image = Properties.Resources.tt_them;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(164, 36);
            btnThem.TabIndex = 8;
            btnThem.Text = "     Thêm mới";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 74);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 39;
            label2.Text = "Tra cứu theo:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.lb_Next;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 48);
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(4, 117);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1019, 591);
            dgv.TabIndex = 37;
            // 
            // tlpTimKiem
            // 
            tlpTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpTimKiem.ColumnCount = 2;
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.88552F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.11448F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpTimKiem.Controls.Add(txtTimKiem, 1, 0);
            tlpTimKiem.Controls.Add(cbTimKiem, 0, 0);
            tlpTimKiem.Location = new Point(135, 68);
            tlpTimKiem.Name = "tlpTimKiem";
            tlpTimKiem.RowCount = 1;
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTimKiem.Size = new Size(885, 35);
            tlpTimKiem.TabIndex = 40;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.BackColor = Color.FromArgb(218, 227, 229);
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.ForeColor = Color.SlateGray;
            txtTimKiem.Location = new Point(196, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(686, 31);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.Text = "Nhập thông tin bạn muốn tra cứu";
            // 
            // cbTimKiem
            // 
            cbTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbTimKiem.BackColor = Color.FromArgb(218, 227, 229);
            cbTimKiem.FormattingEnabled = true;
            cbTimKiem.Items.AddRange(new object[] { "Tên sách", "Mã sách", "Thể loại", "Tác giả" });
            cbTimKiem.Location = new Point(3, 3);
            cbTimKiem.Name = "cbTimKiem";
            cbTimKiem.Size = new Size(187, 31);
            cbTimKiem.TabIndex = 3;
            // 
            // btnNguoiDung
            // 
            btnNguoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNguoiDung.FlatAppearance.BorderSize = 0;
            btnNguoiDung.FlatStyle = FlatStyle.Flat;
            btnNguoiDung.Image = Properties.Resources.icon_nguoidung;
            btnNguoiDung.ImageAlign = ContentAlignment.MiddleLeft;
            btnNguoiDung.Location = new Point(3, 649);
            btnNguoiDung.Name = "btnNguoiDung";
            btnNguoiDung.Size = new Size(231, 58);
            btnNguoiDung.TabIndex = 10;
            btnNguoiDung.Text = "               Người dùng";
            btnNguoiDung.TextAlign = ContentAlignment.MiddleLeft;
            btnNguoiDung.UseVisualStyleBackColor = true;
            btnNguoiDung.Visible = false;
            btnNguoiDung.Click += btnNguoiDung_Click;
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 713);
            Controls.Add(pBody);
            Controls.Add(pMenu);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmTrangChu";
            Load += frmTrangChu_Load;
            pMenu.ResumeLayout(false);
            tlpMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pBody.ResumeLayout(false);
            pNav.ResumeLayout(false);
            pChucNang.ResumeLayout(false);
            pChucNang.PerformLayout();
            tlpDSSach.ResumeLayout(false);
            tlpDSSach.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            tlpTimKiem.ResumeLayout(false);
            tlpTimKiem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pMenu;
        private Panel pBody;
        private TableLayoutPanel tlpMenu;
        private Button btnGioiThieu;
        private Button btnSach;
        private Button btnKhachHang;
        private Button btnBaocaoCongNo;
        private Button btnHoaDon;
        private Button btnBaoCaoTon;
        private Button btnNhapSach;
        private Button btnThuTien;
        private Label btnDoiMK;
        private Panel panel1;
        private Label lbName;
        private Label label1;
        private Button btnTacGia;
        private Button btnTheLoai;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNguoiDung;
        private Panel pNav;
        private Button btnCauHinh;
        private Panel pChucNang;
        private TableLayoutPanel tlpDSSach;
        private Label lbTenChucNang;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dgv;
        private TableLayoutPanel tlpTimKiem;
        private TextBox txtTimKiem;
        private ComboBox cbTimKiem;
    }
}