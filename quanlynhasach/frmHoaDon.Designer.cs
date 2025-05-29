namespace quanlynhasach
{
    partial class frmHoaDon
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
            btnAn = new Button();
            btnDong = new Button();
            btnPhong = new Button();
            btnThu = new Button();
            gThongTin = new GroupBox();
            tlpDSSach = new TableLayoutPanel();
            btnXoa = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            dtpNgayLap = new DateTimePicker();
            label6 = new Label();
            label3 = new Label();
            cbMaKH = new ComboBox();
            txtEmail = new TextBox();
            label7 = new Label();
            txtDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            label1 = new Label();
            label5 = new Label();
            txtTen = new TextBox();
            label4 = new Label();
            txtMa = new TextBox();
            groupBox1 = new GroupBox();
            txtTimKiem = new TextBox();
            label8 = new Label();
            dgvChon = new DataGridView();
            tlpControl = new TableLayoutPanel();
            btnThemSach = new Button();
            btnLoaiBoSach = new Button();
            tlpPhai = new TableLayoutPanel();
            label9 = new Label();
            dgvCTHD = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnIn = new Button();
            btnThem_KH = new Button();
            panel1.SuspendLayout();
            gThongTin.SuspendLayout();
            tlpDSSach.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChon).BeginInit();
            tlpControl.SuspendLayout();
            tlpPhai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(80, 125, 188);
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAn);
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(btnPhong);
            panel1.Controls.Add(btnThu);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1211, 34);
            panel1.TabIndex = 3;
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
            label2.Size = new Size(110, 20);
            label2.TabIndex = 2;
            label2.Text = "       HÓA ĐƠN";
            label2.UseWaitCursor = true;
            // 
            // btnAn
            // 
            btnAn.Anchor = AnchorStyles.Right;
            btnAn.FlatAppearance.BorderSize = 0;
            btnAn.FlatStyle = FlatStyle.Flat;
            btnAn.Image = Properties.Resources.nav_hide;
            btnAn.Location = new Point(1100, 3);
            btnAn.Name = "btnAn";
            btnAn.Size = new Size(33, 25);
            btnAn.TabIndex = 9;
            btnAn.UseVisualStyleBackColor = true;
            btnAn.Click += btnAn_Click;
            // 
            // btnDong
            // 
            btnDong.Anchor = AnchorStyles.Right;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Image = Properties.Resources.nav_exit;
            btnDong.Location = new Point(1178, 1);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(33, 28);
            btnDong.TabIndex = 10;
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnPhong
            // 
            btnPhong.Anchor = AnchorStyles.Right;
            btnPhong.FlatAppearance.BorderSize = 0;
            btnPhong.FlatStyle = FlatStyle.Flat;
            btnPhong.Image = Properties.Resources.nav_max;
            btnPhong.Location = new Point(1139, 3);
            btnPhong.Name = "btnPhong";
            btnPhong.Size = new Size(33, 25);
            btnPhong.TabIndex = 11;
            btnPhong.UseVisualStyleBackColor = true;
            btnPhong.Click += btnPhong_Click;
            // 
            // btnThu
            // 
            btnThu.Anchor = AnchorStyles.Right;
            btnThu.FlatAppearance.BorderSize = 0;
            btnThu.FlatStyle = FlatStyle.Flat;
            btnThu.Image = Properties.Resources.nav_min;
            btnThu.Location = new Point(1139, 3);
            btnThu.Name = "btnThu";
            btnThu.Size = new Size(33, 25);
            btnThu.TabIndex = 8;
            btnThu.UseVisualStyleBackColor = true;
            btnThu.Click += btnThu_Click;
            // 
            // gThongTin
            // 
            gThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gThongTin.BackColor = Color.FromArgb(161, 198, 234);
            gThongTin.Controls.Add(btnIn);
            gThongTin.Controls.Add(btnThem_KH);
            gThongTin.Controls.Add(tlpDSSach);
            gThongTin.Controls.Add(dtpNgayLap);
            gThongTin.Controls.Add(label6);
            gThongTin.Controls.Add(label3);
            gThongTin.Controls.Add(cbMaKH);
            gThongTin.Controls.Add(txtEmail);
            gThongTin.Controls.Add(label7);
            gThongTin.Controls.Add(txtDienThoai);
            gThongTin.Controls.Add(txtDiaChi);
            gThongTin.Controls.Add(label1);
            gThongTin.Controls.Add(label5);
            gThongTin.Controls.Add(txtTen);
            gThongTin.Controls.Add(label4);
            gThongTin.Controls.Add(txtMa);
            gThongTin.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            gThongTin.Location = new Point(4, 35);
            gThongTin.Name = "gThongTin";
            gThongTin.Size = new Size(1201, 238);
            gThongTin.TabIndex = 16;
            gThongTin.TabStop = false;
            gThongTin.Text = "Thông tin";
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
            tlpDSSach.Location = new Point(624, 178);
            tlpDSSach.Name = "tlpDSSach";
            tlpDSSach.RowCount = 1;
            tlpDSSach.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDSSach.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDSSach.Size = new Size(570, 48);
            tlpDSSach.TabIndex = 22;
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
            // dtpNgayLap
            // 
            dtpNgayLap.Enabled = false;
            dtpNgayLap.Location = new Point(738, 30);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(457, 31);
            dtpNgayLap.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(631, 34);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 13;
            label6.Text = "Ngày lập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 34);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 13;
            label3.Text = "Mã hóa đơn";
            // 
            // cbMaKH
            // 
            cbMaKH.FormattingEnabled = true;
            cbMaKH.Location = new Point(179, 83);
            cbMaKH.Name = "cbMaKH";
            cbMaKH.Size = new Size(116, 31);
            cbMaKH.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(218, 227, 229);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.SlateGray;
            txtEmail.Location = new Point(738, 83);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(457, 31);
            txtEmail.TabIndex = 14;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(631, 87);
            label7.Name = "label7";
            label7.Size = new Size(60, 23);
            label7.TabIndex = 13;
            label7.Text = "Email";
            // 
            // txtDienThoai
            // 
            txtDienThoai.BackColor = Color.FromArgb(218, 227, 229);
            txtDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtDienThoai.ForeColor = Color.SlateGray;
            txtDienThoai.Location = new Point(179, 189);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(305, 31);
            txtDienThoai.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDiaChi.BackColor = Color.FromArgb(218, 227, 229);
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.ForeColor = Color.SlateGray;
            txtDiaChi.Location = new Point(179, 136);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(1016, 31);
            txtDiaChi.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 193);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 13;
            label1.Text = "Điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 140);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 13;
            label5.Text = "Địa chỉ";
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(218, 227, 229);
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.ForeColor = Color.SlateGray;
            txtTen.Location = new Point(301, 83);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(215, 31);
            txtTen.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 87);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 13;
            label4.Text = "Tên khách hàng";
            // 
            // txtMa
            // 
            txtMa.BackColor = Color.FromArgb(218, 227, 229);
            txtMa.BorderStyle = BorderStyle.FixedSingle;
            txtMa.ForeColor = Color.SlateGray;
            txtMa.Location = new Point(179, 30);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(257, 31);
            txtMa.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(187, 209, 234);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dgvChon);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 464);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn sách thêm vào hóa đơn";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.BackColor = Color.FromArgb(218, 227, 229);
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.ForeColor = Color.SlateGray;
            txtTimKiem.Location = new Point(95, 37);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(454, 29);
            txtTimKiem.TabIndex = 14;
            txtTimKiem.Text = "Nhập tên sách bạn muốn tìm kiếm";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
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
            // dgvChon
            // 
            dgvChon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChon.Location = new Point(4, 84);
            dgvChon.Name = "dgvChon";
            dgvChon.RowHeadersWidth = 51;
            dgvChon.Size = new Size(547, 377);
            dgvChon.TabIndex = 13;
            // 
            // tlpControl
            // 
            tlpControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tlpControl.ColumnCount = 1;
            tlpControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpControl.Controls.Add(btnThemSach, 0, 0);
            tlpControl.Controls.Add(btnLoaiBoSach, 0, 1);
            tlpControl.Location = new Point(566, 3);
            tlpControl.Name = "tlpControl";
            tlpControl.RowCount = 2;
            tlpControl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpControl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpControl.Size = new Size(56, 464);
            tlpControl.TabIndex = 21;
            // 
            // btnThemSach
            // 
            btnThemSach.BackColor = Color.FromArgb(218, 227, 229);
            btnThemSach.Dock = DockStyle.Bottom;
            btnThemSach.FlatAppearance.BorderSize = 0;
            btnThemSach.FlatStyle = FlatStyle.Flat;
            btnThemSach.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnThemSach.Location = new Point(3, 175);
            btnThemSach.Name = "btnThemSach";
            btnThemSach.Size = new Size(50, 54);
            btnThemSach.TabIndex = 18;
            btnThemSach.Text = ">>";
            btnThemSach.UseVisualStyleBackColor = false;
            // 
            // btnLoaiBoSach
            // 
            btnLoaiBoSach.BackColor = Color.FromArgb(218, 227, 229);
            btnLoaiBoSach.Dock = DockStyle.Top;
            btnLoaiBoSach.FlatAppearance.BorderSize = 0;
            btnLoaiBoSach.FlatStyle = FlatStyle.Flat;
            btnLoaiBoSach.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnLoaiBoSach.Location = new Point(3, 235);
            btnLoaiBoSach.Name = "btnLoaiBoSach";
            btnLoaiBoSach.Size = new Size(50, 54);
            btnLoaiBoSach.TabIndex = 18;
            btnLoaiBoSach.Text = "<<";
            btnLoaiBoSach.UseVisualStyleBackColor = false;
            // 
            // tlpPhai
            // 
            tlpPhai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpPhai.ColumnCount = 1;
            tlpPhai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPhai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpPhai.Controls.Add(label9, 0, 0);
            tlpPhai.Controls.Add(dgvCTHD, 0, 1);
            tlpPhai.Location = new Point(628, 3);
            tlpPhai.Name = "tlpPhai";
            tlpPhai.RowCount = 2;
            tlpPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 5.371901F));
            tlpPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 94.6281F));
            tlpPhai.Size = new Size(577, 464);
            tlpPhai.TabIndex = 21;
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
            dgvCTHD.Size = new Size(571, 434);
            dgvCTHD.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.6334152F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.15378237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.2128029F));
            tableLayoutPanel1.Controls.Add(tlpPhai, 2, 0);
            tableLayoutPanel1.Controls.Add(tlpControl, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(2, 279);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1208, 470);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.FromArgb(217, 234, 248);
            btnIn.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnIn.ForeColor = Color.Black;
            btnIn.Image = Properties.Resources.n_icon_print;
            btnIn.Location = new Point(457, 29);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(84, 36);
            btnIn.TabIndex = 45;
            btnIn.Text = "     In";
            btnIn.TextAlign = ContentAlignment.MiddleRight;
            btnIn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // btnThem_KH
            // 
            btnThem_KH.BackColor = Color.FromArgb(217, 234, 248);
            btnThem_KH.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThem_KH.Image = Properties.Resources.n_icon_add;
            btnThem_KH.Location = new Point(533, 78);
            btnThem_KH.Name = "btnThem_KH";
            btnThem_KH.Size = new Size(84, 36);
            btnThem_KH.TabIndex = 44;
            btnThem_KH.Text = "Thêm";
            btnThem_KH.TextAlign = ContentAlignment.MiddleRight;
            btnThem_KH.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem_KH.UseVisualStyleBackColor = false;
            btnThem_KH.Click += btnThem_KH_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(161, 198, 234);
            ClientSize = new Size(1210, 751);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(gThongTin);
            Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHoaDon";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gThongTin.ResumeLayout(false);
            gThongTin.PerformLayout();
            tlpDSSach.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChon).EndInit();
            tlpControl.ResumeLayout(false);
            tlpPhai.ResumeLayout(false);
            tlpPhai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button btnAn;
        private Button btnPhong;
        private Button btnDong;
        private Button btnThu;
        private GroupBox gThongTin;
        private Label label3;
        private TextBox txtDiaChi;
        private Label label5;
        private Label label4;
        private TextBox txtMa;
        private TextBox txtDienThoai;
        private Label label1;
        private DateTimePicker dtpNgayLap;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private ComboBox cbMaKH;
        private TextBox txtTen;
        private GroupBox groupBox1;
        private TextBox txtTimKiem;
        private Label label8;
        private DataGridView dgvChon;
        private TableLayoutPanel tlpControl;
        private Button btnThemSach;
        private Button btnLoaiBoSach;
        private TableLayoutPanel tlpPhai;
        private Label label9;
        private DataGridView dgvCTHD;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tlpDSSach;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnIn;
        private Button btnThem_KH;
    }
}