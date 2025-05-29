namespace quanlynhasach
{
    partial class frmBaoCaoCongNo
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
            label1 = new Label();
            tlpDSSach = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            dtp = new DateTimePicker();
            dgv = new DataGridView();
            btnIn = new Button();
            tlpDSSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.FromArgb(4, 8, 15);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(957, 48);
            label1.TabIndex = 8;
            label1.Text = "BÁO CÁO CÔNG NỢ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpDSSach
            // 
            tlpDSSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpDSSach.ColumnCount = 1;
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.99999F));
            tlpDSSach.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpDSSach.Controls.Add(label1, 0, 0);
            tlpDSSach.Location = new Point(61, 8);
            tlpDSSach.Name = "tlpDSSach";
            tlpDSSach.RowCount = 1;
            tlpDSSach.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDSSach.Size = new Size(963, 48);
            tlpDSSach.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.lb_Next;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 42);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 23;
            label2.Text = "Tháng";
            // 
            // dtp
            // 
            dtp.Location = new Point(82, 78);
            dtp.Name = "dtp";
            dtp.Size = new Size(289, 29);
            dtp.TabIndex = 24;
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(4, 137);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1019, 572);
            dgv.TabIndex = 38;
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.FromArgb(217, 234, 248);
            btnIn.ForeColor = Color.Black;
            btnIn.Image = Properties.Resources.n_icon_print;
            btnIn.Location = new Point(422, 74);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(130, 36);
            btnIn.TabIndex = 39;
            btnIn.Text = "     In";
            btnIn.TextAlign = ContentAlignment.MiddleRight;
            btnIn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIn.UseVisualStyleBackColor = false;
            // 
            // frmBaoCaoCongNo
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 209, 234);
            ClientSize = new Size(1028, 713);
            Controls.Add(pictureBox1);
            Controls.Add(btnIn);
            Controls.Add(dgv);
            Controls.Add(dtp);
            Controls.Add(label2);
            Controls.Add(tlpDSSach);
            Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ForeColor = Color.FromArgb(187, 209, 234);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmBaoCaoCongNo";
            Text = "frmBaoCaoCongNo";
            tlpDSSach.ResumeLayout(false);
            tlpDSSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tlpDSSach;
        private PictureBox pictureBox1;
        private Label label2;
        private DateTimePicker dtp;
        private DataGridView dgv;
        private Button btnIn;
    }
}