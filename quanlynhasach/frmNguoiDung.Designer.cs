namespace quanlynhasach
{
    partial class frmNguoiDung
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
            label5 = new Label();
            gThongTin = new GroupBox();
            label6 = new Label();
            label3 = new Label();
            cbQuyen = new ComboBox();
            txtMatKhau = new TextBox();
            txtTen = new TextBox();
            label4 = new Label();
            txtMa = new TextBox();
            label2 = new Label();
            tlpTimKiem = new TableLayoutPanel();
            txtTimKiem = new TextBox();
            cbTimKiem = new ComboBox();
            pictureBox1 = new PictureBox();
            tlpDSSach = new TableLayoutPanel();
            lbControl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnXoa = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            dgv = new DataGridView();
            gThongTin.SuspendLayout();
            tlpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tlpDSSach.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(721, 79);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 13;
            label5.Text = "Mật khẩu";
            // 
            // gThongTin
            // 
            gThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gThongTin.Controls.Add(label6);
            gThongTin.Controls.Add(label3);
            gThongTin.Controls.Add(cbQuyen);
            gThongTin.Controls.Add(txtMatKhau);
            gThongTin.Controls.Add(label5);
            gThongTin.Controls.Add(txtTen);
            gThongTin.Controls.Add(label4);
            gThongTin.Controls.Add(txtMa);
            gThongTin.Location = new Point(6, 112);
            gThongTin.Name = "gThongTin";
            gThongTin.Size = new Size(1016, 118);
            gThongTin.TabIndex = 21;
            gThongTin.TabStop = false;
            gThongTin.Text = "Thông tin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 33);
            label6.Name = "label6";
            label6.Size = new Size(82, 17);
            label6.TabIndex = 13;
            label6.Text = "Phân quyền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 77);
            label3.Name = "label3";
            label3.Size = new Size(101, 17);
            label3.TabIndex = 13;
            label3.Text = "Mã người dùng";
            // 
            // cbQuyen
            // 
            cbQuyen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbQuyen.BackColor = Color.FromArgb(218, 227, 229);
            cbQuyen.FormattingEnabled = true;
            cbQuyen.Items.AddRange(new object[] { "QuanTri", "NhanVien" });
            cbQuyen.Location = new Point(151, 25);
            cbQuyen.Name = "cbQuyen";
            cbQuyen.Size = new Size(170, 24);
            cbQuyen.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.FromArgb(218, 227, 229);
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.ForeColor = Color.SlateGray;
            txtMatKhau.Location = new Point(817, 75);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(196, 24);
            txtMatKhau.TabIndex = 14;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(218, 227, 229);
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.ForeColor = Color.SlateGray;
            txtTen.Location = new Point(459, 75);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(232, 24);
            txtTen.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 79);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 13;
            label4.Text = "Họ và tên";
            // 
            // txtMa
            // 
            txtMa.BackColor = Color.FromArgb(218, 227, 229);
            txtMa.BorderStyle = BorderStyle.FixedSingle;
            txtMa.ForeColor = Color.SlateGray;
            txtMa.Location = new Point(151, 73);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(170, 24);
            txtMa.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 16;
            label2.Text = "Tra cứu theo:";
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
            tlpTimKiem.Location = new Point(157, 57);
            tlpTimKiem.Name = "tlpTimKiem";
            tlpTimKiem.RowCount = 1;
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTimKiem.Size = new Size(864, 35);
            tlpTimKiem.TabIndex = 17;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.BackColor = Color.FromArgb(218, 227, 229);
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.ForeColor = Color.SlateGray;
            txtTimKiem.Location = new Point(192, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(669, 24);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.Text = "Nhập thông tin bạn muốn tra cứu";
            // 
            // cbTimKiem
            // 
            cbTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbTimKiem.BackColor = Color.FromArgb(218, 227, 229);
            cbTimKiem.FormattingEnabled = true;
            cbTimKiem.Items.AddRange(new object[] { "QuanTri", "NhanVien" });
            cbTimKiem.Location = new Point(3, 3);
            cbTimKiem.Name = "cbTimKiem";
            cbTimKiem.Size = new Size(183, 24);
            cbTimKiem.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.lb_Next;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 48);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // tlpDSSach
            // 
            tlpDSSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpDSSach.ColumnCount = 2;
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.5906754F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.4093246F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpDSSach.Controls.Add(lbControl, 0, 0);
            tlpDSSach.Controls.Add(tableLayoutPanel1, 1, 0);
            tlpDSSach.Location = new Point(59, 3);
            tlpDSSach.Name = "tlpDSSach";
            tlpDSSach.RowCount = 1;
            tlpDSSach.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDSSach.Size = new Size(965, 48);
            tlpDSSach.TabIndex = 19;
            // 
            // lbControl
            // 
            lbControl.Anchor = AnchorStyles.Left;
            lbControl.AutoSize = true;
            lbControl.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbControl.ForeColor = Color.FromArgb(4, 8, 15);
            lbControl.Location = new Point(3, 11);
            lbControl.Name = "lbControl";
            lbControl.Size = new Size(273, 26);
            lbControl.TabIndex = 8;
            lbControl.Text = "DANH SÁCH NGƯỜI DÙNG";
            lbControl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9740257F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.11039F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9480515F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.8051949F));
            tableLayoutPanel1.Controls.Add(btnXoa, 3, 0);
            tableLayoutPanel1.Controls.Add(btnSua, 2, 0);
            tableLayoutPanel1.Controls.Add(btnLamMoi, 0, 0);
            tableLayoutPanel1.Controls.Add(btnThem, 1, 0);
            tableLayoutPanel1.Location = new Point(416, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(546, 42);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(217, 234, 248);
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.Image = Properties.Resources.tt_xoa;
            btnXoa.Location = new Point(440, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 36);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "     Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(217, 234, 248);
            btnSua.Dock = DockStyle.Fill;
            btnSua.Image = Properties.Resources.tt_sua;
            btnSua.Location = new Point(293, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(141, 36);
            btnSua.TabIndex = 8;
            btnSua.Text = "     Chỉnh sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(217, 234, 248);
            btnLamMoi.Dock = DockStyle.Fill;
            btnLamMoi.Image = Properties.Resources.tt_reset;
            btnLamMoi.Location = new Point(3, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(136, 36);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "     Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
            btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;

            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(217, 234, 248);
            btnThem.Dock = DockStyle.Fill;
            btnThem.Image = Properties.Resources.tt_them;
            btnThem.Location = new Point(145, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(142, 36);
            btnThem.TabIndex = 8;
            btnThem.Text = "     Thêm mới";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(5, 247);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1019, 462);
            dgv.TabIndex = 18;
            dgv.CellClick += dgv_CellClick;
            // 
            // frmNguoiDung
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 209, 234);
            ClientSize = new Size(1028, 713);
            Controls.Add(gThongTin);
            Controls.Add(label2);
            Controls.Add(tlpTimKiem);
            Controls.Add(pictureBox1);
            Controls.Add(tlpDSSach);
            Controls.Add(dgv);
            Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmNguoiDung";
            Text = "frmNguoiDung";
            gThongTin.ResumeLayout(false);
            gThongTin.PerformLayout();
            tlpTimKiem.ResumeLayout(false);
            tlpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tlpDSSach.ResumeLayout(false);
            tlpDSSach.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private GroupBox gThongTin;
        private Label label3;
        private TextBox txtMatKhau;
        private TextBox txtTen;
        private Label label4;
        private TextBox txtMa;
        private Label label2;
        private TableLayoutPanel tlpTimKiem;
        private TextBox txtTimKiem;
        private ComboBox cbTimKiem;
        private PictureBox pictureBox1;
        private TableLayoutPanel tlpDSSach;
        private Label lbControl;
        private DataGridView dgv;
        private Label label6;
        private ComboBox cbQuyen;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLamMoi;
        private Button btnThem;
    }
}