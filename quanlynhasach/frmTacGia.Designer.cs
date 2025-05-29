namespace quanlynhasach
{
    partial class frmTacGia
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
            label3 = new Label();
            txtGhiChu = new TextBox();
            txtTen = new TextBox();
            label4 = new Label();
            txtMa = new TextBox();
            dgv = new DataGridView();
            tlpTimKiem = new TableLayoutPanel();
            txtTimKiem = new TextBox();
            cbTimKiem = new ComboBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lbControl = new Label();
            tlpDSSach = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnXoa = new Button();
            btnSua = new Button();
            button1 = new Button();
            btnThem = new Button();
            gThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            tlpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tlpDSSach.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(530, 55);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 13;
            label5.Text = "Ghi chú";
            // 
            // gThongTin
            // 
            gThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gThongTin.Controls.Add(label3);
            gThongTin.Controls.Add(txtGhiChu);
            gThongTin.Controls.Add(label5);
            gThongTin.Controls.Add(txtTen);
            gThongTin.Controls.Add(label4);
            gThongTin.Controls.Add(txtMa);
            gThongTin.Location = new Point(5, 120);
            gThongTin.Name = "gThongTin";
            gThongTin.Size = new Size(1016, 119);
            gThongTin.TabIndex = 21;
            gThongTin.TabStop = false;
            gThongTin.Text = "Thông tin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 32);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 13;
            label3.Text = "Mã tác giả";
            // 
            // txtGhiChu
            // 
            txtGhiChu.BackColor = Color.FromArgb(218, 227, 229);
            txtGhiChu.BorderStyle = BorderStyle.FixedSingle;
            txtGhiChu.ForeColor = Color.SlateGray;
            txtGhiChu.Location = new Point(604, 28);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(406, 76);
            txtGhiChu.TabIndex = 14;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(218, 227, 229);
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.ForeColor = Color.SlateGray;
            txtTen.Location = new Point(131, 75);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(239, 29);
            txtTen.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 79);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 13;
            label4.Text = "Tên tác giả";
            // 
            // txtMa
            // 
            txtMa.BackColor = Color.FromArgb(218, 227, 229);
            txtMa.BorderStyle = BorderStyle.FixedSingle;
            txtMa.ForeColor = Color.SlateGray;
            txtMa.Location = new Point(131, 28);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(239, 29);
            txtMa.TabIndex = 14;
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(5, 245);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1019, 464);
            dgv.TabIndex = 18;
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
            tlpTimKiem.Location = new Point(136, 63);
            tlpTimKiem.Name = "tlpTimKiem";
            tlpTimKiem.RowCount = 1;
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTimKiem.Size = new Size(885, 35);
            tlpTimKiem.TabIndex = 34;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.BackColor = Color.FromArgb(218, 227, 229);
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.ForeColor = Color.SlateGray;
            txtTimKiem.Location = new Point(196, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(686, 29);
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
            cbTimKiem.Size = new Size(187, 29);
            cbTimKiem.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 33;
            label2.Text = "Tra cứu theo:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.lb_Next;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 48);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // lbControl
            // 
            lbControl.Anchor = AnchorStyles.Left;
            lbControl.AutoSize = true;
            lbControl.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbControl.ForeColor = Color.FromArgb(4, 8, 15);
            lbControl.Location = new Point(3, 7);
            lbControl.Name = "lbControl";
            lbControl.Size = new Size(270, 33);
            lbControl.TabIndex = 8;
            lbControl.Text = "DANH SÁCH TÁC GIẢ";
            lbControl.TextAlign = ContentAlignment.MiddleLeft;
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
            tlpDSSach.Location = new Point(59, 5);
            tlpDSSach.Name = "tlpDSSach";
            tlpDSSach.RowCount = 1;
            tlpDSSach.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDSSach.Size = new Size(965, 48);
            tlpDSSach.TabIndex = 35;
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
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 234, 248);
            button1.Dock = DockStyle.Fill;
            button1.Image = Properties.Resources.tt_reset;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(136, 36);
            button1.TabIndex = 9;
            button1.Text = "     Làm mới";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
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
            // 
            // frmTacGia
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 209, 234);
            ClientSize = new Size(1028, 713);
            Controls.Add(tlpTimKiem);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(tlpDSSach);
            Controls.Add(gThongTin);
            Controls.Add(dgv);
            Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmTacGia";
            Text = "frmTacGia";
            Load += frmTacGia_Load;
            gThongTin.ResumeLayout(false);
            gThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            tlpTimKiem.ResumeLayout(false);
            tlpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tlpDSSach.ResumeLayout(false);
            tlpDSSach.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private GroupBox gThongTin;
        private Label label3;
        private TextBox txtGhiChu;
        private TextBox txtTen;
        private Label label4;
        private TextBox txtMa;
        private DataGridView dgv;
        private TableLayoutPanel tlpTimKiem;
        private TextBox txtTimKiem;
        private ComboBox cbTimKiem;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lbControl;
        private TableLayoutPanel tlpDSSach;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnXoa;
        private Button btnSua;
        private Button button1;
        private Button btnThem;
    }
}