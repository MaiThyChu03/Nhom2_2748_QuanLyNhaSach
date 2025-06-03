namespace quanlynhasach
{
    partial class frmInHoaDon
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
            label2 = new Label();
            label3 = new Label();
            txtTen = new TextBox();
            dtpNgayLap = new DateTimePicker();
            dgvInHoaDon = new DataGridView();
            label4 = new Label();
            txtMaHD = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvInHoaDon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 0;
            label1.Text = "Hóa đơn bán Sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 70);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên Khách Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 70);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày Lập";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(177, 64);
            txtTen.Name = "txtTen";
            txtTen.ReadOnly = true;
            txtTen.Size = new Size(166, 27);
            txtTen.TabIndex = 3;
            txtTen.TabStop = false;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Enabled = false;
            dtpNgayLap.Location = new Point(528, 66);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(250, 27);
            dtpNgayLap.TabIndex = 5;
            dtpNgayLap.TabStop = false;
            // 
            // dgvInHoaDon
            // 
            dgvInHoaDon.AllowUserToAddRows = false;
            dgvInHoaDon.AllowUserToDeleteRows = false;
            dgvInHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInHoaDon.Location = new Point(12, 114);
            dgvInHoaDon.Name = "dgvInHoaDon";
            dgvInHoaDon.ReadOnly = true;
            dgvInHoaDon.RowHeadersWidth = 51;
            dgvInHoaDon.Size = new Size(847, 324);
            dgvInHoaDon.TabIndex = 6;
            dgvInHoaDon.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 9);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 7;
            label4.Text = "Mã HD";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(83, 2);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.ReadOnly = true;
            txtMaHD.Size = new Size(62, 27);
            txtMaHD.TabIndex = 8;
            txtMaHD.TabStop = false;
            // 
            // frmInHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 450);
            Controls.Add(txtMaHD);
            Controls.Add(label4);
            Controls.Add(dgvInHoaDon);
            Controls.Add(dtpNgayLap);
            Controls.Add(txtTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmInHoaDon";
            Text = "frmInHoaDon";
            ((System.ComponentModel.ISupportInitialize)dgvInHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTen;
        private DateTimePicker dtpNgayLap;
        private DataGridView dgvInHoaDon;
        private Label label4;
        private TextBox txtMaHD;
    }
}