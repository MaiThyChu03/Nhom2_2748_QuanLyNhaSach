namespace quanlynhasach
{
    partial class frmDoiMK
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
            btnAn = new Button();
            btnDong = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMatKhauCu = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtRe_MatKhauMoi = new TextBox();
            txtTenDN = new TextBox();
            cbHien = new CheckBox();
            btnLuu = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(80, 125, 188);
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(btnAn);
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 29);
            panel1.TabIndex = 6;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnAn
            // 
            btnAn.Anchor = AnchorStyles.Right;
            btnAn.FlatAppearance.BorderSize = 0;
            btnAn.FlatStyle = FlatStyle.Flat;
            btnAn.Image = Properties.Resources.nav_hide;
            btnAn.Location = new Point(487, 2);
            btnAn.Name = "btnAn";
            btnAn.Size = new Size(33, 25);
            btnAn.TabIndex = 21;
            btnAn.UseVisualStyleBackColor = true;
            btnAn.Click += btnAn_Click;
            // 
            // btnDong
            // 
            btnDong.Anchor = AnchorStyles.Right;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Image = Properties.Resources.nav_exit;
            btnDong.Location = new Point(520, 0);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(33, 28);
            btnDong.TabIndex = 22;
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
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
            label2.Size = new Size(152, 20);
            label2.TabIndex = 2;
            label2.Text = "       ĐỔI MẬT KHẨU";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(206, 23);
            label1.TabIndex = 7;
            label1.Text = "Nhập lại tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 7;
            label3.Text = "Mật khẩu cũ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 159);
            label4.Name = "label4";
            label4.Size = new Size(128, 23);
            label4.TabIndex = 7;
            label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 211);
            label5.Name = "label5";
            label5.Size = new Size(204, 23);
            label5.TabIndex = 7;
            label5.Text = "Nhập lại mật khẩu mới";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMatKhauCu.BackColor = Color.FromArgb(218, 227, 229);
            txtMatKhauCu.ImeMode = ImeMode.NoControl;
            txtMatKhauCu.Location = new Point(253, 99);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.PasswordChar = '*';
            txtMatKhauCu.Size = new Size(293, 31);
            txtMatKhauCu.TabIndex = 16;
            txtMatKhauCu.KeyPress += txtMatKhauCu_KeyPress;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMatKhauMoi.BackColor = Color.FromArgb(218, 227, 229);
            txtMatKhauMoi.ImeMode = ImeMode.NoControl;
            txtMatKhauMoi.Location = new Point(253, 151);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '*';
            txtMatKhauMoi.Size = new Size(293, 31);
            txtMatKhauMoi.TabIndex = 17;
            txtMatKhauMoi.KeyPress += txtMatKhauMoi_KeyPress;
            // 
            // txtRe_MatKhauMoi
            // 
            txtRe_MatKhauMoi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtRe_MatKhauMoi.BackColor = Color.FromArgb(218, 227, 229);
            txtRe_MatKhauMoi.ImeMode = ImeMode.NoControl;
            txtRe_MatKhauMoi.Location = new Point(253, 208);
            txtRe_MatKhauMoi.Name = "txtRe_MatKhauMoi";
            txtRe_MatKhauMoi.PasswordChar = '*';
            txtRe_MatKhauMoi.Size = new Size(293, 31);
            txtRe_MatKhauMoi.TabIndex = 18;
            txtRe_MatKhauMoi.KeyPress += txtRe_MatKhauMoi_KeyPress;
            // 
            // txtTenDN
            // 
            txtTenDN.BackColor = Color.FromArgb(218, 227, 229);
            txtTenDN.BorderStyle = BorderStyle.FixedSingle;
            txtTenDN.ForeColor = Color.SlateGray;
            txtTenDN.Location = new Point(253, 53);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(293, 31);
            txtTenDN.TabIndex = 15;
            txtTenDN.KeyPress += txtTenDN_KeyPress;
            // 
            // cbHien
            // 
            cbHien.AutoSize = true;
            cbHien.Location = new Point(254, 260);
            cbHien.Name = "cbHien";
            cbHien.Size = new Size(185, 27);
            cbHien.TabIndex = 19;
            cbHien.Text = "Hiển thị mật khẩu";
            cbHien.UseVisualStyleBackColor = true;
            cbHien.CheckedChanged += cbHien_CheckedChanged;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(161, 198, 234);
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLuu.Location = new Point(11, 311);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(534, 46);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Lưu thay đổi";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // frmDoiMK
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 227, 229);
            ClientSize = new Size(558, 365);
            Controls.Add(btnLuu);
            Controls.Add(cbHien);
            Controls.Add(txtTenDN);
            Controls.Add(txtRe_MatKhauMoi);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtMatKhauCu);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDoiMK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDoiMK";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button btnAn;
        private Button btnDong;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMatKhauCu;
        private TextBox txtMatKhauMoi;
        private TextBox txtRe_MatKhauMoi;
        private TextBox txtTenDN;
        private CheckBox cbHien;
        private Button btnLuu;
    }
}