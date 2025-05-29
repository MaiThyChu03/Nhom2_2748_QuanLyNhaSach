namespace quanlynhasach
{
    partial class frmPhieuNhapSach
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
            panel1 = new Panel();
            label2 = new Label();
            btnThu = new Button();
            btnDong = new Button();
            btnAn = new Button();
            btnPhong = new Button();
            gThongTin = new GroupBox();
            btnThem_TG = new Button();
            btnThem_TL = new Button();
            btnThem_Sach = new Button();
            tlpDSSach = new TableLayoutPanel();
            btnXoa = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            nGia = new NumericUpDown();
            nSoLuong = new NumericUpDown();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            cbTheLoai = new ComboBox();
            dtpNgayLap = new DateTimePicker();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtMa = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label9 = new Label();
            dgvCTHD = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            bntThemSach = new Button();
            btnLoaiBoSach = new Button();
            groupBox1 = new GroupBox();
            dgvChon = new DataGridView();
            txtTimKiem = new TextBox();
            label8 = new Label();
            btnIn = new Button();
            panel1.SuspendLayout();
            gThongTin.SuspendLayout();
            tlpDSSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nSoLuong).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(80, 125, 188);
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnThu);
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(btnAn);
            panel1.Controls.Add(btnPhong);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1208, 34);
            panel1.TabIndex = 4;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.FromArgb(218, 227, 229);
            label2.Image = Properties.Resources.logo;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 2;
            label2.Text = "       PHIẾU NHẬP SÁCH";
            label2.UseWaitCursor = true;
            // 
            // btnThu
            // 
            btnThu.Anchor = AnchorStyles.Right;
            btnThu.FlatAppearance.BorderSize = 0;
            btnThu.FlatStyle = FlatStyle.Flat;
            btnThu.Image = Properties.Resources.nav_min;
            btnThu.Location = new Point(1133, 3);
            btnThu.Name = "btnThu";
            btnThu.Size = new Size(33, 28);
            btnThu.TabIndex = 12;
            btnThu.UseVisualStyleBackColor = true;
            btnThu.Click += btnThu_Click;
            // 
            // btnDong
            // 
            btnDong.Anchor = AnchorStyles.Right;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Image = Properties.Resources.nav_exit;
            btnDong.Location = new Point(1172, 4);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(33, 28);
            btnDong.TabIndex = 14;
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnAn
            // 
            btnAn.Anchor = AnchorStyles.Right;
            btnAn.FlatAppearance.BorderSize = 0;
            btnAn.FlatStyle = FlatStyle.Flat;
            btnAn.Image = Properties.Resources.nav_hide;
            btnAn.Location = new Point(1094, 6);
            btnAn.Name = "btnAn";
            btnAn.Size = new Size(33, 25);
            btnAn.TabIndex = 13;
            btnAn.UseVisualStyleBackColor = true;
            btnAn.Click += btnAn_Click;
            // 
            // btnPhong
            // 
            btnPhong.Anchor = AnchorStyles.Right;
            btnPhong.FlatAppearance.BorderSize = 0;
            btnPhong.FlatStyle = FlatStyle.Flat;
            btnPhong.Image = Properties.Resources.nav_max;
            btnPhong.Location = new Point(1133, 5);
            btnPhong.Name = "btnPhong";
            btnPhong.Size = new Size(33, 25);
            btnPhong.TabIndex = 15;
            btnPhong.UseVisualStyleBackColor = true;
            btnPhong.Click += btnPhong_Click;
            // 
            // gThongTin
            // 
            gThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gThongTin.BackColor = Color.FromArgb(161, 198, 234);
            gThongTin.Controls.Add(btnIn);
            gThongTin.Controls.Add(btnThem_TG);
            gThongTin.Controls.Add(btnThem_TL);
            gThongTin.Controls.Add(btnThem_Sach);
            gThongTin.Controls.Add(tlpDSSach);
            gThongTin.Controls.Add(nGia);
            gThongTin.Controls.Add(nSoLuong);
            gThongTin.Controls.Add(comboBox2);
            gThongTin.Controls.Add(comboBox1);
            gThongTin.Controls.Add(cbTheLoai);
            gThongTin.Controls.Add(dtpNgayLap);
            gThongTin.Controls.Add(label10);
            gThongTin.Controls.Add(label7);
            gThongTin.Controls.Add(label6);
            gThongTin.Controls.Add(label5);
            gThongTin.Controls.Add(label4);
            gThongTin.Controls.Add(label1);
            gThongTin.Controls.Add(label3);
            gThongTin.Controls.Add(txtMa);
            gThongTin.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            gThongTin.Location = new Point(4, 39);
            gThongTin.Name = "gThongTin";
            gThongTin.Size = new Size(1201, 245);
            gThongTin.TabIndex = 17;
            gThongTin.TabStop = false;
            gThongTin.Text = "Thông tin";
            // 
            // btnThem_TG
            // 
            btnThem_TG.BackColor = Color.FromArgb(217, 234, 248);
            btnThem_TG.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThem_TG.Image = Properties.Resources.n_icon_add;
            btnThem_TG.Location = new Point(455, 191);
            btnThem_TG.Name = "btnThem_TG";
            btnThem_TG.Size = new Size(84, 31);
            btnThem_TG.TabIndex = 29;
            btnThem_TG.Text = "Thêm";
            btnThem_TG.TextAlign = ContentAlignment.MiddleRight;
            btnThem_TG.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem_TG.UseVisualStyleBackColor = false;
            btnThem_TG.Click += btnThem_TG_Click;
            // 
            // btnThem_TL
            // 
            btnThem_TL.BackColor = Color.FromArgb(217, 234, 248);
            btnThem_TL.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThem_TL.Image = Properties.Resources.n_icon_add;
            btnThem_TL.Location = new Point(455, 142);
            btnThem_TL.Name = "btnThem_TL";
            btnThem_TL.Size = new Size(84, 31);
            btnThem_TL.TabIndex = 29;
            btnThem_TL.Text = "Thêm";
            btnThem_TL.TextAlign = ContentAlignment.MiddleRight;
            btnThem_TL.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem_TL.UseVisualStyleBackColor = false;
            btnThem_TL.Click += btnThem_TL_Click;
            // 
            // btnThem_Sach
            // 
            btnThem_Sach.BackColor = Color.FromArgb(217, 234, 248);
            btnThem_Sach.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThem_Sach.Image = Properties.Resources.n_icon_add;
            btnThem_Sach.Location = new Point(455, 93);
            btnThem_Sach.Name = "btnThem_Sach";
            btnThem_Sach.Size = new Size(84, 31);
            btnThem_Sach.TabIndex = 29;
            btnThem_Sach.Text = "Thêm";
            btnThem_Sach.TextAlign = ContentAlignment.MiddleRight;
            btnThem_Sach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem_Sach.UseVisualStyleBackColor = false;
            btnThem_Sach.Click += btnThem_Sach_Click;
            // 
            // tlpDSSach
            // 
            tlpDSSach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tlpDSSach.ColumnCount = 4;
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.3684216F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.8947372F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7192974F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpDSSach.Controls.Add(btnXoa, 3, 0);
            tlpDSSach.Controls.Add(btnSua, 2, 0);
            tlpDSSach.Controls.Add(btnLamMoi, 0, 0);
            tlpDSSach.Controls.Add(btnThem, 1, 0);
            tlpDSSach.Location = new Point(624, 180);
            tlpDSSach.Name = "tlpDSSach";
            tlpDSSach.RowCount = 1;
            tlpDSSach.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDSSach.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDSSach.Size = new Size(570, 48);
            tlpDSSach.TabIndex = 21;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(217, 234, 248);
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.Image = Properties.Resources.tt_xoa;
            btnXoa.Location = new Point(476, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 42);
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
            btnSua.Location = new Point(318, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(152, 42);
            btnSua.TabIndex = 8;
            btnSua.Text = "     Chỉnh sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(217, 234, 248);
            btnLamMoi.Dock = DockStyle.Fill;
            btnLamMoi.Image = Properties.Resources.tt_reset;
            btnLamMoi.Location = new Point(3, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(150, 42);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "     Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
            btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(217, 234, 248);
            btnThem.Dock = DockStyle.Fill;
            btnThem.Image = Properties.Resources.tt_them;
            btnThem.Location = new Point(159, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(153, 42);
            btnThem.TabIndex = 8;
            btnThem.Text = "     Thêm mới";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            // 
            // nGia
            // 
            nGia.Location = new Point(1050, 93);
            nGia.Name = "nGia";
            nGia.Size = new Size(125, 31);
            nGia.TabIndex = 19;
            // 
            // nSoLuong
            // 
            nSoLuong.Location = new Point(792, 93);
            nSoLuong.Name = "nSoLuong";
            nSoLuong.Size = new Size(73, 31);
            nSoLuong.TabIndex = 19;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(158, 193);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(275, 31);
            comboBox2.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(158, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(275, 31);
            comboBox1.TabIndex = 18;
            // 
            // cbTheLoai
            // 
            cbTheLoai.FormattingEnabled = true;
            cbTheLoai.Location = new Point(158, 145);
            cbTheLoai.Name = "cbTheLoai";
            cbTheLoai.Size = new Size(275, 31);
            cbTheLoai.TabIndex = 18;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Enabled = false;
            dtpNgayLap.Location = new Point(792, 38);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(384, 31);
            dtpNgayLap.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(886, 97);
            label10.Name = "label10";
            label10.Size = new Size(123, 23);
            label10.TabIndex = 13;
            label10.Text = "Đơn giá nhập";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(628, 97);
            label7.Name = "label7";
            label7.Size = new Size(132, 23);
            label7.TabIndex = 13;
            label7.Text = "Số lượng nhập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(628, 42);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 13;
            label6.Text = "Ngày lập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 196);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 13;
            label5.Text = "Tác giả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 149);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 13;
            label4.Text = "Thể loại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 97);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 13;
            label1.Text = "Tên sách nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 46);
            label3.Name = "label3";
            label3.Size = new Size(136, 23);
            label3.TabIndex = 13;
            label3.Text = "Mã phiếu nhập";
            // 
            // txtMa
            // 
            txtMa.BackColor = Color.FromArgb(218, 227, 229);
            txtMa.BorderStyle = BorderStyle.FixedSingle;
            txtMa.ForeColor = Color.SlateGray;
            txtMa.Location = new Point(158, 42);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(275, 31);
            txtMa.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.6334152F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.15378237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.2128029F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(1, 290);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1208, 457);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.BackColor = Color.FromArgb(161, 198, 234);
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(label9, 0, 0);
            tableLayoutPanel3.Controls.Add(dgvCTHD, 0, 1);
            tableLayoutPanel3.Location = new Point(628, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 5.371901F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 94.6281F));
            tableLayoutPanel3.Size = new Size(577, 451);
            tableLayoutPanel3.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(161, 198, 234);
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(571, 24);
            label9.TabIndex = 13;
            label9.Text = "Danh sách sách";
            // 
            // dgvCTHD
            // 
            dgvCTHD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTHD.Location = new Point(3, 27);
            dgvCTHD.Name = "dgvCTHD";
            dgvCTHD.RowHeadersWidth = 51;
            dgvCTHD.Size = new Size(571, 421);
            dgvCTHD.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(161, 198, 234);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(bntThemSach, 0, 0);
            tableLayoutPanel2.Controls.Add(btnLoaiBoSach, 0, 1);
            tableLayoutPanel2.Location = new Point(566, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(56, 451);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // bntThemSach
            // 
            bntThemSach.BackColor = Color.FromArgb(218, 227, 229);
            bntThemSach.Dock = DockStyle.Bottom;
            bntThemSach.FlatAppearance.BorderSize = 0;
            bntThemSach.FlatStyle = FlatStyle.Flat;
            bntThemSach.Font = new Font("Cambria", 12F, FontStyle.Bold);
            bntThemSach.Location = new Point(3, 165);
            bntThemSach.Name = "bntThemSach";
            bntThemSach.Size = new Size(50, 57);
            bntThemSach.TabIndex = 18;
            bntThemSach.Text = ">>";
            bntThemSach.UseVisualStyleBackColor = false;
            // 
            // btnLoaiBoSach
            // 
            btnLoaiBoSach.BackColor = Color.FromArgb(218, 227, 229);
            btnLoaiBoSach.Dock = DockStyle.Top;
            btnLoaiBoSach.FlatAppearance.BorderSize = 0;
            btnLoaiBoSach.FlatStyle = FlatStyle.Flat;
            btnLoaiBoSach.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnLoaiBoSach.Location = new Point(3, 228);
            btnLoaiBoSach.Name = "btnLoaiBoSach";
            btnLoaiBoSach.Size = new Size(50, 60);
            btnLoaiBoSach.TabIndex = 18;
            btnLoaiBoSach.Text = "<<";
            btnLoaiBoSach.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dgvChon);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 451);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn sách thêm vào phiếu nhập";
            // 
            // dgvChon
            // 
            dgvChon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChon.Location = new Point(6, 75);
            dgvChon.Name = "dgvChon";
            dgvChon.RowHeadersWidth = 51;
            dgvChon.Size = new Size(545, 373);
            dgvChon.TabIndex = 13;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.BackColor = Color.FromArgb(218, 227, 229);
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.ForeColor = Color.SlateGray;
            txtTimKiem.Location = new Point(95, 37);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(456, 29);
            txtTimKiem.TabIndex = 14;
            txtTimKiem.Text = "Nhập tên sách bạn muốn tìm kiếm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 45);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 13;
            label8.Text = "Tìm kiếm";
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.FromArgb(217, 234, 248);
            btnIn.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnIn.ForeColor = Color.Black;
            btnIn.Image = Properties.Resources.n_icon_print;
            btnIn.Location = new Point(455, 42);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(84, 36);
            btnIn.TabIndex = 44;
            btnIn.Text = "     In";
            btnIn.TextAlign = ContentAlignment.MiddleRight;
            btnIn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIn.UseVisualStyleBackColor = false;
            // 
            // frmPhieuNhapSach
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 209, 234);
            ClientSize = new Size(1210, 751);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(gThongTin);
            Controls.Add(panel1);
            Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmPhieuNhapSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPhieuNhapSach";
            Load += frmPhieuNhapSach_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gThongTin.ResumeLayout(false);
            gThongTin.PerformLayout();
            tlpDSSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)nSoLuong).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button btnPhong;
        private Button btnAn;
        private Button btnDong;
        private Button btnThu;
        private GroupBox gThongTin;
        private DateTimePicker dtpNgayLap;
        private Label label6;
        private Label label3;
        private TextBox txtMa;
        private ComboBox cbTheLoai;
        private Label label5;
        private Label label4;
        private Label label1;
        private NumericUpDown nGia;
        private NumericUpDown nSoLuong;
        private Label label10;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label9;
        private DataGridView dgvCTHD;
        private TableLayoutPanel tableLayoutPanel2;
        private Button bntThemSach;
        private Button btnLoaiBoSach;
        private GroupBox groupBox1;
        private DataGridView dgvChon;
        private TextBox txtTimKiem;
        private Label label8;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TableLayoutPanel tlpDSSach;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnThem_TG;
        private Button btnThem_TL;
        private Button btnThem_Sach;
        private Button btnIn;
    }
}