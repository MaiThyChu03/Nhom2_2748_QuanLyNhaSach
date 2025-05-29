namespace quanlynhasach
{
    partial class frmThem
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pNav = new Panel();
            panel1 = new Panel();
            btnDong = new Button();
            lbThem = new Label();
            btnAn = new Button();
            pForm = new Panel();
            tableLayoutPanel1.SuspendLayout();
            pNav.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(pNav, 0, 0);
            tableLayoutPanel1.Controls.Add(pForm, 0, 1);
            tableLayoutPanel1.Location = new Point(-2, -2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.01355028F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 94.98645F));
            tableLayoutPanel1.Size = new Size(1032, 754);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pNav
            // 
            pNav.Controls.Add(panel1);
            pNav.Dock = DockStyle.Fill;
            pNav.Location = new Point(3, 3);
            pNav.Name = "pNav";
            pNav.Size = new Size(1026, 31);
            pNav.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 125, 188);
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(lbThem);
            panel1.Controls.Add(btnAn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 31);
            panel1.TabIndex = 5;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnDong
            // 
            btnDong.Anchor = AnchorStyles.Right;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Image = Properties.Resources.nav_exit;
            btnDong.Location = new Point(992, 2);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(33, 28);
            btnDong.TabIndex = 18;
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // lbThem
            // 
            lbThem.AutoSize = true;
            lbThem.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbThem.ForeColor = Color.FromArgb(218, 227, 229);
            lbThem.Image = Properties.Resources.logo;
            lbThem.ImageAlign = ContentAlignment.MiddleLeft;
            lbThem.Location = new Point(3, 6);
            lbThem.Name = "lbThem";
            lbThem.Size = new Size(46, 20);
            lbThem.TabIndex = 2;
            lbThem.Text = "       ...";
            lbThem.UseWaitCursor = true;
            // 
            // btnAn
            // 
            btnAn.Anchor = AnchorStyles.Right;
            btnAn.FlatAppearance.BorderSize = 0;
            btnAn.FlatStyle = FlatStyle.Flat;
            btnAn.Image = Properties.Resources.nav_hide;
            btnAn.Location = new Point(947, 4);
            btnAn.Name = "btnAn";
            btnAn.Size = new Size(33, 25);
            btnAn.TabIndex = 17;
            btnAn.UseVisualStyleBackColor = true;
            btnAn.Click += btnAn_Click;
            // 
            // pForm
            // 
            pForm.Location = new Point(3, 40);
            pForm.Name = "pForm";
            pForm.Size = new Size(1026, 711);
            pForm.TabIndex = 7;
            // 
            // frmThem
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1028, 751);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmThem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThem";
            tableLayoutPanel1.ResumeLayout(false);
            pNav.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lbThem;
        private Panel pNav;
        private Button btnDong;
        private Button btnAn;
        private Panel pForm;
    }
}