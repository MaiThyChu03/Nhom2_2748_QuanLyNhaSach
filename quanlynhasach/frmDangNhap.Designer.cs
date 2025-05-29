namespace quanlynhasach
{
    partial class frmDangNhap
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
            txtTenDN = new TextBox();
            label2 = new Label();
            lnTenDN = new Label();
            lbDangNhap = new Label();
            pDangNhap = new Panel();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnShow = new Label();
            btnHide = new Label();
            tlpDangNhap = new TableLayoutPanel();
            pDangNhap.SuspendLayout();
            tlpDangNhap.SuspendLayout();
            SuspendLayout();
            // 
            // txtTenDN
            // 
            txtTenDN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTenDN.BackColor = Color.FromArgb(218, 227, 229);
            txtTenDN.ImeMode = ImeMode.NoControl;
            txtTenDN.Location = new Point(177, 107);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(427, 31);
            txtTenDN.TabIndex = 0;
            txtTenDN.KeyPress += txtTenDN_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 199);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            // 
            // lnTenDN
            // 
            lnTenDN.AutoSize = true;
            lnTenDN.Location = new Point(34, 110);
            lnTenDN.Name = "lnTenDN";
            lnTenDN.Size = new Size(134, 23);
            lnTenDN.TabIndex = 5;
            lnTenDN.Text = "Tên đăng nhập";
            // 
            // lbDangNhap
            // 
            lbDangNhap.AutoSize = true;
            lbDangNhap.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbDangNhap.Location = new Point(244, 28);
            lbDangNhap.Name = "lbDangNhap";
            lbDangNhap.Size = new Size(169, 33);
            lbDangNhap.TabIndex = 3;
            lbDangNhap.Text = "ĐĂNG NHẬP";
            lbDangNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pDangNhap
            // 
            pDangNhap.Anchor = AnchorStyles.None;
            pDangNhap.BackColor = Color.FromArgb(187, 209, 234);
            pDangNhap.BackgroundImageLayout = ImageLayout.Center;
            pDangNhap.BorderStyle = BorderStyle.FixedSingle;
            pDangNhap.Controls.Add(txtMatKhau);
            pDangNhap.Controls.Add(btnDangNhap);
            pDangNhap.Controls.Add(txtTenDN);
            pDangNhap.Controls.Add(label2);
            pDangNhap.Controls.Add(lnTenDN);
            pDangNhap.Controls.Add(lbDangNhap);
            pDangNhap.Controls.Add(btnShow);
            pDangNhap.Controls.Add(btnHide);
            pDangNhap.Location = new Point(319, 181);
            pDangNhap.Name = "pDangNhap";
            pDangNhap.Size = new Size(626, 351);
            pDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMatKhau.BackColor = Color.FromArgb(218, 227, 229);
            txtMatKhau.ImeMode = ImeMode.NoControl;
            txtMatKhau.Location = new Point(174, 196);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(370, 31);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.KeyPress += txtMatKhau_KeyPress;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(161, 198, 234);
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDangNhap.Location = new Point(34, 275);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(567, 41);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnShow
            // 
            btnShow.AutoSize = true;
            btnShow.Image = Properties.Resources.show;
            btnShow.Location = new Point(557, 199);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(42, 23);
            btnShow.TabIndex = 3;
            btnShow.Text = "        ";
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.AutoSize = true;
            btnHide.Image = Properties.Resources.tt_hide;
            btnHide.Location = new Point(557, 199);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(42, 23);
            btnHide.TabIndex = 9;
            btnHide.Text = "        ";
            btnHide.Click += btnHide_Click;
            // 
            // tlpDangNhap
            // 
            tlpDangNhap.BackColor = Color.FromArgb(218, 227, 229);
            tlpDangNhap.ColumnCount = 3;
            tlpDangNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpDangNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDangNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpDangNhap.Controls.Add(pDangNhap, 1, 1);
            tlpDangNhap.Dock = DockStyle.Fill;
            tlpDangNhap.Location = new Point(0, 0);
            tlpDangNhap.Name = "tlpDangNhap";
            tlpDangNhap.RowCount = 3;
            tlpDangNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpDangNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDangNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpDangNhap.Size = new Size(1265, 715);
            tlpDangNhap.TabIndex = 1;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 715);
            Controls.Add(tlpDangNhap);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            pDangNhap.ResumeLayout(false);
            pDangNhap.PerformLayout();
            tlpDangNhap.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTenDN;
        private Label label2;
        private Label lnTenDN;
        private Label lbDangNhap;
        private Panel pDangNhap;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private TableLayoutPanel tlpDangNhap;
        private Label btnShow;
        private Label btnHide;
    }
}