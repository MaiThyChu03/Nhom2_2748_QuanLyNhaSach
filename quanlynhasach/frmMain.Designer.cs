namespace quanlynhasach
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pThanhDieuHuong = new Panel();
            lbTieuDe = new Label();
            lbDangXuat = new Label();
            btnAn = new Button();
            btnDong = new Button();
            btnPhong = new Button();
            btnThu = new Button();
            pMain = new Panel();
            pThanhDieuHuong.SuspendLayout();
            SuspendLayout();
            // 
            // pThanhDieuHuong
            // 
            pThanhDieuHuong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pThanhDieuHuong.BackColor = Color.FromArgb(80, 125, 188);
            pThanhDieuHuong.BackgroundImageLayout = ImageLayout.Center;
            pThanhDieuHuong.Controls.Add(lbTieuDe);
            pThanhDieuHuong.Controls.Add(lbDangXuat);
            pThanhDieuHuong.Controls.Add(btnAn);
            pThanhDieuHuong.Controls.Add(btnDong);
            pThanhDieuHuong.Controls.Add(btnPhong);
            pThanhDieuHuong.Controls.Add(btnThu);
            pThanhDieuHuong.Location = new Point(1, 0);
            pThanhDieuHuong.Name = "pThanhDieuHuong";
            pThanhDieuHuong.Size = new Size(1266, 31);
            pThanhDieuHuong.TabIndex = 1;
            pThanhDieuHuong.MouseDown += pThanhDieuHuong_MouseDown;
            // 
            // lbTieuDe
            // 
            lbTieuDe.AutoSize = true;
            lbTieuDe.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbTieuDe.ForeColor = Color.FromArgb(218, 227, 229);
            lbTieuDe.Image = Properties.Resources.logo;
            lbTieuDe.ImageAlign = ContentAlignment.MiddleLeft;
            lbTieuDe.Location = new Point(3, 6);
            lbTieuDe.Name = "lbTieuDe";
            lbTieuDe.Size = new Size(186, 20);
            lbTieuDe.TabIndex = 2;
            lbTieuDe.Text = "       QUẢN LÝ NHÀ SÁCH";
            // 
            // lbDangXuat
            // 
            lbDangXuat.Anchor = AnchorStyles.Right;
            lbDangXuat.AutoSize = true;
            lbDangXuat.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbDangXuat.ForeColor = Color.FromArgb(218, 227, 229);
            lbDangXuat.Location = new Point(1062, 5);
            lbDangXuat.Name = "lbDangXuat";
            lbDangXuat.Size = new Size(87, 20);
            lbDangXuat.TabIndex = 3;
            lbDangXuat.Text = "Đăng xuất?";
            lbDangXuat.Visible = false;
            lbDangXuat.DoubleClick += lbDangXuat_DoubleClick;
            // 
            // btnAn
            // 
            btnAn.Anchor = AnchorStyles.Right;
            btnAn.FlatAppearance.BorderSize = 0;
            btnAn.FlatStyle = FlatStyle.Flat;
            btnAn.Image = Properties.Resources.nav_hide;
            btnAn.Location = new Point(1152, 2);
            btnAn.Name = "btnAn";
            btnAn.Size = new Size(33, 25);
            btnAn.TabIndex = 1;
            btnAn.UseVisualStyleBackColor = true;
            btnAn.Click += btnAn_Click;
            // 
            // btnDong
            // 
            btnDong.Anchor = AnchorStyles.Right;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Image = Properties.Resources.nav_exit;
            btnDong.Location = new Point(1230, 0);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(33, 28);
            btnDong.TabIndex = 1;
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnPhong
            // 
            btnPhong.Anchor = AnchorStyles.Right;
            btnPhong.FlatAppearance.BorderSize = 0;
            btnPhong.FlatStyle = FlatStyle.Flat;
            btnPhong.Image = Properties.Resources.nav_max;
            btnPhong.Location = new Point(1191, 2);
            btnPhong.Name = "btnPhong";
            btnPhong.Size = new Size(33, 25);
            btnPhong.TabIndex = 1;
            btnPhong.UseVisualStyleBackColor = true;
            btnPhong.Click += btnPhong_Click;
            // 
            // btnThu
            // 
            btnThu.Anchor = AnchorStyles.Right;
            btnThu.FlatAppearance.BorderSize = 0;
            btnThu.FlatStyle = FlatStyle.Flat;
            btnThu.Image = Properties.Resources.nav_min;
            btnThu.Location = new Point(1191, 2);
            btnThu.Name = "btnThu";
            btnThu.Size = new Size(33, 25);
            btnThu.TabIndex = 1;
            btnThu.UseVisualStyleBackColor = true;
            btnThu.Click += btnThu_Click;
            // 
            // pMain
            // 
            pMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pMain.Location = new Point(1, 34);
            pMain.Name = "pMain";
            pMain.Size = new Size(1265, 710);
            pMain.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1266, 745);
            Controls.Add(pMain);
            Controls.Add(pThanhDieuHuong);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1266, 745);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            pThanhDieuHuong.ResumeLayout(false);
            pThanhDieuHuong.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pThanhDieuHuong;
        private Label lbTieuDe;
        private Button btnAn;
        private Button btnDong;
        private Button btnPhong;
        private Button btnThu;
        private Label lbDangXuat;
        private Panel pMain;
    }
}