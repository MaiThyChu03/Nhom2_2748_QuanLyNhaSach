namespace quanlynhasach
{
    partial class frmThuTien
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
            gThongTin = new GroupBox();
            btnIn = new Button();
            btnThem_KH = new Button();
            tlpDSSach = new TableLayoutPanel();
            btnXoa = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            nSoLuong = new NumericUpDown();
            dtpNgayLap = new DateTimePicker();
            label6 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label8 = new Label();
            label4 = new Label();
            txtMa = new TextBox();
            dgv = new DataGridView();
            cbMaKH = new ComboBox();
            txtTen = new TextBox();
            gThongTin.SuspendLayout();
            tlpDSSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // gThongTin
            // 
            gThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gThongTin.Controls.Add(cbMaKH);
            gThongTin.Controls.Add(txtTen);
            gThongTin.Controls.Add(btnIn);
            gThongTin.Controls.Add(btnThem_KH);
            gThongTin.Controls.Add(tlpDSSach);
            gThongTin.Controls.Add(nSoLuong);
            gThongTin.Controls.Add(dtpNgayLap);
            gThongTin.Controls.Add(label6);
            gThongTin.Controls.Add(label3);
            gThongTin.Controls.Add(txtEmail);
            gThongTin.Controls.Add(label7);
            gThongTin.Controls.Add(txtDienThoai);
            gThongTin.Controls.Add(txtDiaChi);
            gThongTin.Controls.Add(label1);
            gThongTin.Controls.Add(label5);
            gThongTin.Controls.Add(label8);
            gThongTin.Controls.Add(label4);
            gThongTin.Controls.Add(txtMa);
            gThongTin.Location = new Point(5, 2);
            gThongTin.Name = "gThongTin";
            gThongTin.Size = new Size(1201, 251);
            gThongTin.TabIndex = 21;
            gThongTin.TabStop = false;
            gThongTin.Text = "Thông tin";
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.FromArgb(217, 234, 248);
            btnIn.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnIn.ForeColor = Color.Black;
            btnIn.Image = Properties.Resources.n_icon_print;
            btnIn.Location = new Point(461, 67);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(84, 36);
            btnIn.TabIndex = 43;
            btnIn.Text = "     In";
            btnIn.TextAlign = ContentAlignment.MiddleRight;
            btnIn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIn.UseVisualStyleBackColor = false;
            // 
            // btnThem_KH
            // 
            btnThem_KH.BackColor = Color.FromArgb(217, 234, 248);
            btnThem_KH.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThem_KH.Image = Properties.Resources.n_icon_add;
            btnThem_KH.Location = new Point(511, 111);
            btnThem_KH.Name = "btnThem_KH";
            btnThem_KH.Size = new Size(84, 36);
            btnThem_KH.TabIndex = 29;
            btnThem_KH.Text = "Thêm";
            btnThem_KH.TextAlign = ContentAlignment.MiddleRight;
            btnThem_KH.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem_KH.UseVisualStyleBackColor = false;
            btnThem_KH.Click += btnThem_KH_Click;
            // 
            // tlpDSSach
            // 
            tlpDSSach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tlpDSSach.ColumnCount = 4;
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9740257F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.11039F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9480515F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.8051949F));
            tlpDSSach.Controls.Add(btnXoa, 3, 0);
            tlpDSSach.Controls.Add(btnSua, 2, 0);
            tlpDSSach.Controls.Add(btnLamMoi, 0, 0);
            tlpDSSach.Controls.Add(btnThem, 1, 0);
            tlpDSSach.Location = new Point(649, 18);
            tlpDSSach.Name = "tlpDSSach";
            tlpDSSach.RowCount = 1;
            tlpDSSach.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDSSach.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDSSach.Size = new Size(546, 48);
            tlpDSSach.TabIndex = 19;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(217, 234, 248);
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.Image = Properties.Resources.tt_xoa;
            btnXoa.Location = new Point(440, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 42);
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
            btnSua.Location = new Point(293, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(141, 42);
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
            btnLamMoi.Size = new Size(136, 42);
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
            btnThem.Location = new Point(145, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(142, 42);
            btnThem.TabIndex = 8;
            btnThem.Text = "     Thêm mới";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            // 
            // nSoLuong
            // 
            nSoLuong.Location = new Point(792, 116);
            nSoLuong.Name = "nSoLuong";
            nSoLuong.Size = new Size(170, 29);
            nSoLuong.TabIndex = 16;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Enabled = false;
            dtpNgayLap.Location = new Point(158, 24);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(285, 29);
            dtpNgayLap.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 30);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 13;
            label6.Text = "Ngày thu tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 75);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 13;
            label3.Text = "Mã phiếu thu";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(218, 227, 229);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.SlateGray;
            txtEmail.Location = new Point(792, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 29);
            txtEmail.TabIndex = 14;
            txtEmail.KeyPress += txtDienThoai_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(649, 210);
            label7.Name = "label7";
            label7.Size = new Size(54, 21);
            label7.TabIndex = 13;
            label7.Text = "Email";
            // 
            // txtDienThoai
            // 
            txtDienThoai.BackColor = Color.FromArgb(218, 227, 229);
            txtDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtDienThoai.ForeColor = Color.SlateGray;
            txtDienThoai.Location = new Point(158, 208);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(285, 29);
            txtDienThoai.TabIndex = 14;
            txtDienThoai.KeyPress += txtDienThoai_KeyPress;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDiaChi.BackColor = Color.FromArgb(218, 227, 229);
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.ForeColor = Color.SlateGray;
            txtDiaChi.Location = new Point(158, 163);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(1034, 29);
            txtDiaChi.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 212);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 13;
            label1.Text = "Điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 167);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 13;
            label5.Text = "Địa chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(649, 120);
            label8.Name = "label8";
            label8.Size = new Size(93, 21);
            label8.TabIndex = 13;
            label8.Text = "Số tiền thu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 120);
            label4.Name = "label4";
            label4.Size = new Size(131, 21);
            label4.TabIndex = 13;
            label4.Text = "Tên khách hàng";
            // 
            // txtMa
            // 
            txtMa.BackColor = Color.FromArgb(218, 227, 229);
            txtMa.BorderStyle = BorderStyle.FixedSingle;
            txtMa.ForeColor = Color.SlateGray;
            txtMa.Location = new Point(158, 71);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(285, 29);
            txtMa.TabIndex = 14;
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(4, 269);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1202, 479);
            dgv.TabIndex = 22;
            // 
            // cbMaKH
            // 
            cbMaKH.FormattingEnabled = true;
            cbMaKH.Location = new Point(158, 116);
            cbMaKH.Name = "cbMaKH";
            cbMaKH.Size = new Size(116, 29);
            cbMaKH.TabIndex = 44;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(218, 227, 229);
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.ForeColor = Color.SlateGray;
            txtTen.Location = new Point(280, 116);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(225, 29);
            txtTen.TabIndex = 45;
            // 
            // frmThuTien
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 209, 234);
            ClientSize = new Size(1210, 751);
            Controls.Add(dgv);
            Controls.Add(gThongTin);
            Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmThuTien";
            Text = "frmThuTien";
            Load += frmThuTien_Load;
            gThongTin.ResumeLayout(false);
            gThongTin.PerformLayout();
            tlpDSSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gThongTin;
        private NumericUpDown nSoLuong;
        private DateTimePicker dtpNgayLap;
        private Label label6;
        private Label label3;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private Label label1;
        private Label label5;
        private Label label8;
        private Label label4;
        private TextBox txtMa;
        private TableLayoutPanel tlpDSSach;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgv;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnThem_KH;
        private Button btnIn;
        private ComboBox cbMaKH;
        private TextBox txtTen;
    }
}