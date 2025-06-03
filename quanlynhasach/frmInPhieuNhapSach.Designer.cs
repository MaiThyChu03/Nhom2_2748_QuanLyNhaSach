namespace quanlynhasach
{
    partial class frmInPhieuNhapSach
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
            txtMaPN = new TextBox();
            label4 = new Label();
            dgvInPhieuNhapSach = new DataGridView();
            dtpNgayNhap = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInPhieuNhapSach).BeginInit();
            SuspendLayout();
            // 
            // txtMaPN
            // 
            txtMaPN.Location = new Point(102, 7);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.ReadOnly = true;
            txtMaPN.Size = new Size(62, 27);
            txtMaPN.TabIndex = 16;
            txtMaPN.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 14);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 15;
            label4.Text = "Mã PN";
            // 
            // dgvInPhieuNhapSach
            // 
            dgvInPhieuNhapSach.AllowUserToAddRows = false;
            dgvInPhieuNhapSach.AllowUserToDeleteRows = false;
            dgvInPhieuNhapSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInPhieuNhapSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInPhieuNhapSach.Location = new Point(12, 119);
            dgvInPhieuNhapSach.Name = "dgvInPhieuNhapSach";
            dgvInPhieuNhapSach.ReadOnly = true;
            dgvInPhieuNhapSach.RowHeadersWidth = 51;
            dgvInPhieuNhapSach.Size = new Size(882, 324);
            dgvInPhieuNhapSach.TabIndex = 14;
            dgvInPhieuNhapSach.TabStop = false;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Enabled = false;
            dtpNgayNhap.Location = new Point(348, 71);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(250, 27);
            dtpNgayNhap.TabIndex = 13;
            dtpNgayNhap.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 75);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 11;
            label3.Text = "Ngày Lập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(387, 14);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 9;
            label1.Text = "Phiếu Nhập Sách";
            // 
            // frmInPhieuNhapSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 460);
            Controls.Add(txtMaPN);
            Controls.Add(label4);
            Controls.Add(dgvInPhieuNhapSach);
            Controls.Add(dtpNgayNhap);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmInPhieuNhapSach";
            Text = "frmInPhieuNhapSach";
            ((System.ComponentModel.ISupportInitialize)dgvInPhieuNhapSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaPN;
        private Label label4;
        private DataGridView dgvInPhieuNhapSach;
        private DateTimePicker dtpNgayNhap;
        private Label label3;
        private Label label1;
    }
}