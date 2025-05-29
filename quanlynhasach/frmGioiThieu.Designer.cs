namespace quanlynhasach
{
    partial class frmGioiThieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGioiThieu));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            lbGioiThieu = new Label();
            lbGioiThieu_TieuDe = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(80, 125, 188);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-38, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 11);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(32, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 145);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.bookmark;
            button1.Location = new Point(17, 11);
            button1.Name = "button1";
            button1.Size = new Size(107, 153);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // lbGioiThieu
            // 
            lbGioiThieu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbGioiThieu.AutoSize = true;
            lbGioiThieu.Location = new Point(30, 268);
            lbGioiThieu.Name = "lbGioiThieu";
            lbGioiThieu.Size = new Size(497, 189);
            lbGioiThieu.TabIndex = 2;
            lbGioiThieu.Text = resources.GetString("lbGioiThieu.Text");
            // 
            // lbGioiThieu_TieuDe
            // 
            lbGioiThieu_TieuDe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbGioiThieu_TieuDe.AutoSize = true;
            lbGioiThieu_TieuDe.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbGioiThieu_TieuDe.Location = new Point(30, 217);
            lbGioiThieu_TieuDe.Name = "lbGioiThieu_TieuDe";
            lbGioiThieu_TieuDe.Size = new Size(533, 33);
            lbGioiThieu_TieuDe.TabIndex = 3;
            lbGioiThieu_TieuDe.Text = "Phần mềm quản lý nhà sách thông minh ";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackgroundImage = Properties.Resources.img;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(409, 337);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(530, 312);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // frmGioiThieu
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 227, 229);
            ClientSize = new Size(951, 661);
            Controls.Add(pictureBox2);
            Controls.Add(lbGioiThieu_TieuDe);
            Controls.Add(lbGioiThieu);
            Controls.Add(button1);
            Controls.Add(panel1);
            Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmGioiThieu";
            Text = "frmStart";
            Load += frmStart_Load;
            Resize += frmStart_Resize;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label lbGioiThieu;
        private Label lbGioiThieu_TieuDe;
        private PictureBox pictureBox2;
    }
}