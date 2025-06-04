namespace quanlynhasach
{
    partial class frmSach
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
            btnThem_TL = new Button();
            btnThem_TG = new Button();
            numSoLuong = new NumericUpDown();
            label5 = new Label();
            cbTacGia = new ComboBox();
            cbTheLoai = new ComboBox();
            label7 = new Label();
            label1 = new Label();
            txtMa = new TextBox();
            txtTen = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnThem = new Button();
            lbControl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnXoa = new Button();
            btnSua = new Button();
            button1 = new Button();
            txtTimKiem = new TextBox();
            cbTimKiem = new ComboBox();
            tlpTimKiem = new TableLayoutPanel();
            tlpDSSach = new TableLayoutPanel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dgvSach = new DataGridView();
            gThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tlpTimKiem.SuspendLayout();
            tlpDSSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            SuspendLayout();
            // 
            // gThongTin
            // 
            gThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gThongTin.Controls.Add(btnThem_TL);
            gThongTin.Controls.Add(btnThem_TG);
            gThongTin.Controls.Add(numSoLuong);
            gThongTin.Controls.Add(label5);
            gThongTin.Controls.Add(cbTacGia);
            gThongTin.Controls.Add(cbTheLoai);
            gThongTin.Controls.Add(label7);
            gThongTin.Controls.Add(label1);
            gThongTin.Controls.Add(txtMa);
            gThongTin.Controls.Add(txtTen);
            gThongTin.Controls.Add(label3);
            gThongTin.Controls.Add(label4);
            gThongTin.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            gThongTin.Location = new Point(6, 112);
            gThongTin.Name = "gThongTin";
            gThongTin.Size = new Size(1016, 180);
            gThongTin.TabIndex = 33;
            gThongTin.TabStop = false;
            gThongTin.Text = "Thông tin";
            // 
            // btnThem_TL
            // 
            btnThem_TL.BackColor = Color.FromArgb(217, 234, 248);
            btnThem_TL.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThem_TL.Image = Properties.Resources.n_icon_add;
            btnThem_TL.Location = new Point(924, 30);
            btnThem_TL.Name = "btnThem_TL";
            btnThem_TL.Size = new Size(84, 36);
            btnThem_TL.TabIndex = 28;
            btnThem_TL.Text = "Thêm";
            btnThem_TL.TextAlign = ContentAlignment.MiddleRight;
            btnThem_TL.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem_TL.UseVisualStyleBackColor = false;
            btnThem_TL.Click += btnThem_TL_Click;
            // 
            // btnThem_TG
            // 
            btnThem_TG.BackColor = Color.FromArgb(217, 234, 248);
            btnThem_TG.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThem_TG.Image = Properties.Resources.n_icon_add;
            btnThem_TG.Location = new Point(924, 81);
            btnThem_TG.Name = "btnThem_TG";
            btnThem_TG.Size = new Size(84, 36);
            btnThem_TG.TabIndex = 28;
            btnThem_TG.Text = "Thêm";
            btnThem_TG.TextAlign = ContentAlignment.MiddleRight;
            btnThem_TG.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem_TG.UseVisualStyleBackColor = false;
            btnThem_TG.Click += btnThem_TG_Click;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(122, 136);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(171, 31);
            numSoLuong.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 142);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 26;
            label5.Text = "Số lượng";
            // 
            // cbTacGia
            // 
            cbTacGia.FormattingEnabled = true;
            cbTacGia.Location = new Point(647, 84);
            cbTacGia.Name = "cbTacGia";
            cbTacGia.Size = new Size(263, 31);
            cbTacGia.TabIndex = 23;
            // 
            // cbTheLoai
            // 
            cbTheLoai.FormattingEnabled = true;
            cbTheLoai.Location = new Point(647, 32);
            cbTheLoai.Name = "cbTheLoai";
            cbTheLoai.Size = new Size(263, 31);
            cbTheLoai.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(542, 89);
            label7.Name = "label7";
            label7.Size = new Size(69, 23);
            label7.TabIndex = 15;
            label7.Text = "Tác giả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(542, 41);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 16;
            label1.Text = "Thể loại";
            // 
            // txtMa
            // 
            txtMa.BackColor = Color.FromArgb(218, 227, 229);
            txtMa.BorderStyle = BorderStyle.FixedSingle;
            txtMa.ForeColor = Color.SlateGray;
            txtMa.Location = new Point(122, 32);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(275, 31);
            txtMa.TabIndex = 22;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(218, 227, 229);
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.ForeColor = Color.SlateGray;
            txtTen.Location = new Point(122, 84);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(274, 31);
            txtTen.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 41);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 18;
            label3.Text = "Mã sách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 89);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 18;
            label4.Text = "Tên sách";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(217, 234, 248);
            btnThem.Dock = DockStyle.Fill;
            btnThem.Image = Properties.Resources.tt_them;
            btnThem.Location = new Point(155, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(152, 36);
            btnThem.TabIndex = 8;
            btnThem.Text = "     Thêm mới";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lbControl
            // 
            lbControl.Anchor = AnchorStyles.Left;
            lbControl.AutoSize = true;
            lbControl.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbControl.ForeColor = Color.FromArgb(4, 8, 15);
            lbControl.Location = new Point(3, 7);
            lbControl.Name = "lbControl";
            lbControl.Size = new Size(237, 33);
            lbControl.TabIndex = 8;
            lbControl.Text = "DANH SÁCH SÁCH";
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
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnThem, 1, 0);
            tableLayoutPanel1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tableLayoutPanel1.Location = new Point(377, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(585, 42);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(217, 234, 248);
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.Image = Properties.Resources.tt_xoa;
            btnXoa.Location = new Point(470, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 36);
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
            btnSua.Location = new Point(313, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(151, 36);
            btnSua.TabIndex = 8;
            btnSua.Text = "     Chỉnh sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 234, 248);
            button1.Dock = DockStyle.Fill;
            button1.Image = Properties.Resources.tt_reset;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(146, 36);
            button1.TabIndex = 9;
            button1.Text = "     Làm mới";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnLamMoi_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.BackColor = Color.FromArgb(218, 227, 229);
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.ForeColor = Color.SlateGray;
            txtTimKiem.Location = new Point(198, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(692, 29);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.Text = "Nhập thông tin bạn muốn tra cứu";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // cbTimKiem
            // 
            cbTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbTimKiem.BackColor = Color.FromArgb(218, 227, 229);
            cbTimKiem.FormattingEnabled = true;
            cbTimKiem.Items.AddRange(new object[] { "Tên sách", "Mã sách", "Thể loại", "Tác giả" });
            cbTimKiem.Location = new Point(3, 3);
            cbTimKiem.Name = "cbTimKiem";
            cbTimKiem.Size = new Size(189, 29);
            cbTimKiem.TabIndex = 3;
            cbTimKiem.SelectedIndexChanged += cbTimKiem_SelectedIndexChanged;
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
            tlpTimKiem.Location = new Point(128, 61);
            tlpTimKiem.Name = "tlpTimKiem";
            tlpTimKiem.RowCount = 1;
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTimKiem.Size = new Size(893, 35);
            tlpTimKiem.TabIndex = 29;
            // 
            // tlpDSSach
            // 
            tlpDSSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpDSSach.ColumnCount = 2;
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.7564774F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.2435226F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpDSSach.Controls.Add(lbControl, 0, 0);
            tlpDSSach.Controls.Add(tableLayoutPanel1, 1, 0);
            tlpDSSach.Location = new Point(59, 3);
            tlpDSSach.Name = "tlpDSSach";
            tlpDSSach.RowCount = 1;
            tlpDSSach.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDSSach.Size = new Size(965, 48);
            tlpDSSach.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 28;
            label2.Text = "Tra cứu theo:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.lb_Next;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 48);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // dgvSach
            // 
            dgvSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(5, 298);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(1019, 411);
            dgvSach.TabIndex = 30;
            dgvSach.CellClick += dgvSach_CellClick;
            dgvSach.CellContentClick += dgvSach_CellClick;
            // 
            // frmSach
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(187, 209, 234);
            ClientSize = new Size(1028, 713);
            Controls.Add(gThongTin);
            Controls.Add(tlpTimKiem);
            Controls.Add(tlpDSSach);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dgvSach);
            Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmSach";
            Text = "frmSach";
            Load += frmSach_Load;
            Click += frmSach_Click;
            gThongTin.ResumeLayout(false);
            gThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tlpTimKiem.ResumeLayout(false);
            tlpTimKiem.PerformLayout();
            tlpDSSach.ResumeLayout(false);
            tlpDSSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gThongTin;
        private Label label7;
        private Label label1;
        private TextBox txtMa;
        private TextBox txtTen;
        private Label label3;
        private Label label4;
        private Button btnThem;
        private Label lbControl;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnXoa;
        private Button btnSua;
        private Button button1;
        private TextBox txtTimKiem;
        private ComboBox cbTimKiem;
        private TableLayoutPanel tlpTimKiem;
        private TableLayoutPanel tlpDSSach;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dgvSach;
        private ComboBox cbTacGia;
        private ComboBox cbTheLoai;
        private NumericUpDown numSoLuong;
        private Label label5;
        private Button btnThem_TL;
        private Button btnThem_TG;
    }
}