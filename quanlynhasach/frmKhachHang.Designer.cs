namespace quanlynhasach
{
    partial class frmKhachHang
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
            txtEmail = new TextBox();
            label7 = new Label();
            txtDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            label1 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            txtTen = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tlpTimKiem = new TableLayoutPanel();
            txtTimKiem = new TextBox();
            cbTimKiem = new ComboBox();
            btnXoa = new Button();
            btnSua = new Button();
            button1 = new Button();
            lbControl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnThem = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            tlpDSSach = new TableLayoutPanel();
            dgv = new DataGridView();
            gThongTin.SuspendLayout();
            tlpTimKiem.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tlpDSSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // gThongTin
            // 
            gThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gThongTin.Controls.Add(txtEmail);
            gThongTin.Controls.Add(label7);
            gThongTin.Controls.Add(txtDienThoai);
            gThongTin.Controls.Add(txtDiaChi);
            gThongTin.Controls.Add(label1);
            gThongTin.Controls.Add(label5);
            gThongTin.Controls.Add(textBox1);
            gThongTin.Controls.Add(txtTen);
            gThongTin.Controls.Add(label3);
            gThongTin.Controls.Add(label4);
            gThongTin.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            gThongTin.Location = new Point(6, 112);
            gThongTin.Name = "gThongTin";
            gThongTin.Size = new Size(1016, 180);
            gThongTin.TabIndex = 27;
            gThongTin.TabStop = false;
            gThongTin.Text = "Thông tin";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(218, 227, 229);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.SlateGray;
            txtEmail.Location = new Point(698, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(312, 31);
            txtEmail.TabIndex = 19;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(551, 130);
            label7.Name = "label7";
            label7.Size = new Size(60, 23);
            label7.TabIndex = 15;
            label7.Text = "Email";
            // 
            // txtDienThoai
            // 
            txtDienThoai.BackColor = Color.FromArgb(218, 227, 229);
            txtDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtDienThoai.ForeColor = Color.SlateGray;
            txtDienThoai.Location = new Point(154, 128);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(275, 31);
            txtDienThoai.TabIndex = 20;
            txtDienThoai.KeyPress += txtDienThoai_KeyPress;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDiaChi.BackColor = Color.FromArgb(218, 227, 229);
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.ForeColor = Color.SlateGray;
            txtDiaChi.Location = new Point(154, 80);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(856, 31);
            txtDiaChi.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 132);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 16;
            label1.Text = "Điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 84);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 17;
            label5.Text = "Địa chỉ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(218, 227, 229);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.SlateGray;
            textBox1.Location = new Point(154, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 31);
            textBox1.TabIndex = 22;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(218, 227, 229);
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.ForeColor = Color.SlateGray;
            txtTen.Location = new Point(698, 28);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(312, 31);
            txtTen.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 36);
            label3.Name = "label3";
            label3.Size = new Size(137, 23);
            label3.TabIndex = 18;
            label3.Text = "Mã khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(550, 32);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 18;
            label4.Text = "Tên khách hàng";
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
            tlpTimKiem.Location = new Point(157, 61);
            tlpTimKiem.Name = "tlpTimKiem";
            tlpTimKiem.RowCount = 1;
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTimKiem.Size = new Size(864, 35);
            tlpTimKiem.TabIndex = 23;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.BackColor = Color.FromArgb(218, 227, 229);
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.ForeColor = Color.SlateGray;
            txtTimKiem.Location = new Point(192, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(669, 29);
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
            cbTimKiem.Size = new Size(183, 29);
            cbTimKiem.TabIndex = 3;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(217, 234, 248);
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.Image = Properties.Resources.tt_xoa;
            btnXoa.Location = new Point(469, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(111, 36);
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
            btnSua.Location = new Point(312, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(151, 36);
            btnSua.TabIndex = 8;
            btnSua.Text = "     Chỉnh sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 234, 248);
            button1.Dock = DockStyle.Fill;
            button1.Image = Properties.Resources.tt_reset;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(145, 36);
            button1.TabIndex = 9;
            button1.Text = "     Làm mới";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // lbControl
            // 
            lbControl.Anchor = AnchorStyles.Left;
            lbControl.AutoSize = true;
            lbControl.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbControl.ForeColor = Color.FromArgb(4, 8, 15);
            lbControl.Location = new Point(3, 7);
            lbControl.Name = "lbControl";
            lbControl.Size = new Size(343, 33);
            lbControl.TabIndex = 8;
            lbControl.Text = "DANH SÁCH KHÁCH HÀNG";
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
            tableLayoutPanel1.Location = new Point(379, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(583, 42);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(217, 234, 248);
            btnThem.Dock = DockStyle.Fill;
            btnThem.Image = Properties.Resources.tt_them;
            btnThem.Location = new Point(154, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(152, 36);
            btnThem.TabIndex = 8;
            btnThem.Text = "     Thêm mới";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 22;
            label2.Text = "Tra cứu theo:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.lb_Next;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 48);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // tlpDSSach
            // 
            tlpDSSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpDSSach.ColumnCount = 2;
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.96373F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.03627F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpDSSach.Controls.Add(lbControl, 0, 0);
            tlpDSSach.Controls.Add(tableLayoutPanel1, 1, 0);
            tlpDSSach.Location = new Point(59, 3);
            tlpDSSach.Name = "tlpDSSach";
            tlpDSSach.RowCount = 1;
            tlpDSSach.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDSSach.Size = new Size(965, 48);
            tlpDSSach.TabIndex = 25;
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(5, 298);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1019, 411);
            dgv.TabIndex = 24;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 209, 234);
            ClientSize = new Size(1028, 713);
            Controls.Add(gThongTin);
            Controls.Add(tlpTimKiem);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(tlpDSSach);
            Controls.Add(dgv);
            Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            gThongTin.ResumeLayout(false);
            gThongTin.PerformLayout();
            tlpTimKiem.ResumeLayout(false);
            tlpTimKiem.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tlpDSSach.ResumeLayout(false);
            tlpDSSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gThongTin;
        private TableLayoutPanel tlpTimKiem;
        private TextBox txtTimKiem;
        private ComboBox cbTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button button1;
        private Label lbControl;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnThem;
        private Label label2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tlpDSSach;
        private DataGridView dgv;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private Label label1;
        private Label label5;
        private TextBox txtTen;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
    }
}