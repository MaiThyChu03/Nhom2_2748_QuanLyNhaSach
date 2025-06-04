namespace quanlynhasach
{
    partial class frmCauHinh
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
            label2 = new Label();
            btnDong = new Button();
            panel2 = new Panel();
            btnMacDinh = new Button();
            btnLuu = new Button();
            checkQD2_2 = new CheckBox();
            checkQD2_1 = new CheckBox();
            checkQD1_2 = new CheckBox();
            checkQD1_1 = new CheckBox();
            nQD2_2 = new NumericUpDown();
            nQD2_1 = new NumericUpDown();
            nQD1_2 = new NumericUpDown();
            nQD1_1 = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nQD2_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nQD2_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nQD1_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nQD1_1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(80, 125, 188);
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(btnAn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnDong);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 29);
            panel1.TabIndex = 5;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnAn
            // 
            btnAn.Anchor = AnchorStyles.Right;
            btnAn.FlatAppearance.BorderSize = 0;
            btnAn.FlatStyle = FlatStyle.Flat;
            btnAn.Image = Properties.Resources.nav_hide;
            btnAn.Location = new Point(694, 0);
            btnAn.Name = "btnAn";
            btnAn.Size = new Size(33, 25);
            btnAn.TabIndex = 13;
            btnAn.UseVisualStyleBackColor = true;
            btnAn.Click += btnAn_Click;
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
            label2.Size = new Size(115, 20);
            label2.TabIndex = 2;
            label2.Text = "       CẤU HÌNH";
            label2.UseWaitCursor = true;
            // 
            // btnDong
            // 
            btnDong.Anchor = AnchorStyles.Right;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Image = Properties.Resources.nav_exit;
            btnDong.Location = new Point(727, -2);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(33, 28);
            btnDong.TabIndex = 14;
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(218, 227, 229);
            panel2.Controls.Add(btnMacDinh);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(checkQD2_2);
            panel2.Controls.Add(checkQD2_1);
            panel2.Controls.Add(checkQD1_2);
            panel2.Controls.Add(checkQD1_1);
            panel2.Controls.Add(nQD2_2);
            panel2.Controls.Add(nQD2_1);
            panel2.Controls.Add(nQD1_2);
            panel2.Controls.Add(nQD1_1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(4, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(757, 336);
            panel2.TabIndex = 6;
            // 
            // btnMacDinh
            // 
            btnMacDinh.BackColor = Color.FromArgb(217, 234, 248);
            btnMacDinh.Image = Properties.Resources.n_icon_default;
            btnMacDinh.Location = new Point(406, 267);
            btnMacDinh.Name = "btnMacDinh";
            btnMacDinh.Size = new Size(156, 36);
            btnMacDinh.TabIndex = 9;
            btnMacDinh.Text = "     Mặc định";
            btnMacDinh.TextAlign = ContentAlignment.MiddleRight;
            btnMacDinh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMacDinh.UseVisualStyleBackColor = false;
            btnMacDinh.Click += btnMacDinh_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(217, 234, 248);
            btnLuu.Image = Properties.Resources.n_icon_save;
            btnLuu.Location = new Point(593, 267);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(118, 36);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "     Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // checkQD2_2
            // 
            checkQD2_2.AutoSize = true;
            checkQD2_2.Location = new Point(618, 204);
            checkQD2_2.Name = "checkQD2_2";
            checkQD2_2.Size = new Size(102, 27);
            checkQD2_2.TabIndex = 2;
            checkQD2_2.Text = "Áp dụng";
            checkQD2_2.UseVisualStyleBackColor = true;
            // 
            // checkQD2_1
            // 
            checkQD2_1.AutoSize = true;
            checkQD2_1.Location = new Point(618, 150);
            checkQD2_1.Name = "checkQD2_1";
            checkQD2_1.Size = new Size(102, 27);
            checkQD2_1.TabIndex = 2;
            checkQD2_1.Text = "Áp dụng";
            checkQD2_1.UseVisualStyleBackColor = true;
            // 
            // checkQD1_2
            // 
            checkQD1_2.AutoSize = true;
            checkQD1_2.Location = new Point(618, 96);
            checkQD1_2.Name = "checkQD1_2";
            checkQD1_2.Size = new Size(102, 27);
            checkQD1_2.TabIndex = 2;
            checkQD1_2.Text = "Áp dụng";
            checkQD1_2.UseVisualStyleBackColor = true;
            // 
            // checkQD1_1
            // 
            checkQD1_1.AutoSize = true;
            checkQD1_1.Location = new Point(618, 42);
            checkQD1_1.Name = "checkQD1_1";
            checkQD1_1.Size = new Size(102, 27);
            checkQD1_1.TabIndex = 2;
            checkQD1_1.Text = "Áp dụng";
            checkQD1_1.UseVisualStyleBackColor = true;
            // 
            // nQD2_2
            // 
            nQD2_2.Location = new Point(406, 202);
            nQD2_2.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            nQD2_2.Name = "nQD2_2";
            nQD2_2.Size = new Size(171, 31);
            nQD2_2.TabIndex = 1;
            nQD2_2.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // nQD2_1
            // 
            nQD2_1.Location = new Point(406, 148);
            nQD2_1.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            nQD2_1.Name = "nQD2_1";
            nQD2_1.Size = new Size(171, 31);
            nQD2_1.TabIndex = 1;
            // 
            // nQD1_2
            // 
            nQD1_2.Location = new Point(406, 94);
            nQD1_2.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nQD1_2.Minimum = new decimal(new int[] { 300, 0, 0, 0 });
            nQD1_2.Name = "nQD1_2";
            nQD1_2.Size = new Size(171, 31);
            nQD1_2.TabIndex = 1;
            nQD1_2.Value = new decimal(new int[] { 300, 0, 0, 0 });
            // 
            // nQD1_1
            // 
            nQD1_1.Location = new Point(406, 40);
            nQD1_1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nQD1_1.Minimum = new decimal(new int[] { 150, 0, 0, 0 });
            nQD1_1.Name = "nQD1_1";
            nQD1_1.Size = new Size(171, 31);
            nQD1_1.TabIndex = 1;
            nQD1_1.Value = new decimal(new int[] { 150, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 206);
            label5.Name = "label5";
            label5.Size = new Size(334, 23);
            label5.TabIndex = 0;
            label5.Text = "QĐ02: Lượng tồn tối thiểu sau khi bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 152);
            label4.Name = "label4";
            label4.Size = new Size(206, 23);
            label4.TabIndex = 0;
            label4.Text = "QĐ02: Số tiền nợ tối đa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 98);
            label3.Name = "label3";
            label3.Size = new Size(363, 23);
            label3.TabIndex = 0;
            label3.Text = "QĐ01: Lượng tồn tối thiểu trước khi nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 44);
            label1.Name = "label1";
            label1.Size = new Size(266, 23);
            label1.TabIndex = 0;
            label1.Text = "QĐ01: Số lượng nhập tối thiểu";
            // 
            // frmCauHinh
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 125, 188);
            ClientSize = new Size(765, 370);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmCauHinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCauHinh";
            Load += frmCauHinh_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nQD2_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nQD2_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nQD1_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nQD1_1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button btnAn;
        private Button btnDong;
        private Panel panel2;
        private CheckBox checkQD2_2;
        private CheckBox checkQD2_1;
        private CheckBox checkQD1_2;
        private CheckBox checkQD1_1;
        private NumericUpDown nQD2_2;
        private NumericUpDown nQD2_1;
        private NumericUpDown nQD1_2;
        private NumericUpDown nQD1_1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnMacDinh;
        private Button btnLuu;
    }
}