namespace QuanLyKhoHang.GiaoDien
{
    partial class fmQuanLy
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
            this.components = new System.ComponentModel.Container();
            this.tm1 = new System.Windows.Forms.Timer(this.components);
            this.lbThongKe = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.lbQuanLyNV = new System.Windows.Forms.Label();
            this.lbNCC = new System.Windows.Forms.Label();
            this.lbKhoHang = new System.Windows.Forms.Label();
            this.pcbKhachHang = new System.Windows.Forms.PictureBox();
            this.pcbKho = new System.Windows.Forms.PictureBox();
            this.pcbThongKe = new System.Windows.Forms.PictureBox();
            this.pcbNhaCC = new System.Windows.Forms.PictureBox();
            this.pcbQuanLyNhanVien = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNhaCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQuanLyNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tm1
            // 
            this.tm1.Interval = 30;
            this.tm1.Tick += new System.EventHandler(this.tm1_Tick);
            // 
            // lbThongKe
            // 
            this.lbThongKe.AutoSize = true;
            this.lbThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.lbThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongKe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbThongKe.Location = new System.Drawing.Point(464, 318);
            this.lbThongKe.Name = "lbThongKe";
            this.lbThongKe.Size = new System.Drawing.Size(119, 32);
            this.lbThongKe.TabIndex = 13;
            this.lbThongKe.Text = "Thống Kê";
            this.lbThongKe.Click += new System.EventHandler(this.lbThongKe_Click);
            this.lbThongKe.MouseHover += new System.EventHandler(this.lbThongKe_MouseHover);
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(51)))), ((int)(((byte)(141)))));
            this.lbKhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachHang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbKhachHang.Location = new System.Drawing.Point(155, 318);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(148, 32);
            this.lbKhachHang.TabIndex = 12;
            this.lbKhachHang.Text = "Khách Hàng";
            this.lbKhachHang.Click += new System.EventHandler(this.lbKhachHang_Click);
            this.lbKhachHang.MouseHover += new System.EventHandler(this.lbKhachHang_MouseHover);
            // 
            // lbQuanLyNV
            // 
            this.lbQuanLyNV.AutoSize = true;
            this.lbQuanLyNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.lbQuanLyNV.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLyNV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbQuanLyNV.Location = new System.Drawing.Point(517, 138);
            this.lbQuanLyNV.Name = "lbQuanLyNV";
            this.lbQuanLyNV.Size = new System.Drawing.Size(129, 64);
            this.lbQuanLyNV.TabIndex = 10;
            this.lbQuanLyNV.Text = " Quản Lý \r\nNhân Viên";
            this.lbQuanLyNV.Click += new System.EventHandler(this.lbQuanLyNV_Click);
            this.lbQuanLyNV.MouseHover += new System.EventHandler(this.lbQuanLyNV_MouseHover);
            // 
            // lbNCC
            // 
            this.lbNCC.AutoSize = true;
            this.lbNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.lbNCC.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNCC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNCC.Location = new System.Drawing.Point(298, 153);
            this.lbNCC.Name = "lbNCC";
            this.lbNCC.Size = new System.Drawing.Size(173, 32);
            this.lbNCC.TabIndex = 9;
            this.lbNCC.Text = "Nhà Cung Cấp";
            this.lbNCC.Click += new System.EventHandler(this.lbNCC_Click);
            this.lbNCC.MouseHover += new System.EventHandler(this.lbNCC_MouseHover);
            // 
            // lbKhoHang
            // 
            this.lbKhoHang.AutoSize = true;
            this.lbKhoHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(59)))), ((int)(((byte)(1)))));
            this.lbKhoHang.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoHang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbKhoHang.Location = new System.Drawing.Point(122, 153);
            this.lbKhoHang.Name = "lbKhoHang";
            this.lbKhoHang.Size = new System.Drawing.Size(124, 32);
            this.lbKhoHang.TabIndex = 8;
            this.lbKhoHang.Text = "Kho Hàng";
            this.lbKhoHang.Click += new System.EventHandler(this.lbKhoHang_Click);
            this.lbKhoHang.MouseHover += new System.EventHandler(this.lbKhoHang_MouseHover);
            // 
            // pcbKhachHang
            // 
            this.pcbKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(51)))), ((int)(((byte)(141)))));
            this.pcbKhachHang.Location = new System.Drawing.Point(85, 257);
            this.pcbKhachHang.Name = "pcbKhachHang";
            this.pcbKhachHang.Size = new System.Drawing.Size(286, 160);
            this.pcbKhachHang.TabIndex = 7;
            this.pcbKhachHang.TabStop = false;
            this.pcbKhachHang.Click += new System.EventHandler(this.pcbKhachHang_Click);
            this.pcbKhachHang.MouseLeave += new System.EventHandler(this.pcbKhachHang_MouseLeave);
            this.pcbKhachHang.MouseHover += new System.EventHandler(this.pcbKhachHang_MouseHover);
            // 
            // pcbKho
            // 
            this.pcbKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(59)))), ((int)(((byte)(1)))));
            this.pcbKho.Location = new System.Drawing.Point(86, 84);
            this.pcbKho.Name = "pcbKho";
            this.pcbKho.Size = new System.Drawing.Size(190, 160);
            this.pcbKho.TabIndex = 6;
            this.pcbKho.TabStop = false;
            this.pcbKho.Click += new System.EventHandler(this.pcbKho_Click);
            this.pcbKho.MouseLeave += new System.EventHandler(this.pcbKho_MouseLeave);
            this.pcbKho.MouseHover += new System.EventHandler(this.pcbKho_MouseHover);
            // 
            // pcbThongKe
            // 
            this.pcbThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.pcbThongKe.Location = new System.Drawing.Point(380, 257);
            this.pcbThongKe.Name = "pcbThongKe";
            this.pcbThongKe.Size = new System.Drawing.Size(288, 160);
            this.pcbThongKe.TabIndex = 3;
            this.pcbThongKe.TabStop = false;
            this.pcbThongKe.Click += new System.EventHandler(this.pcbThongKe_Click);
            this.pcbThongKe.MouseLeave += new System.EventHandler(this.pcbThongKe_MouseLeave);
            this.pcbThongKe.MouseHover += new System.EventHandler(this.pcbThongKe_MouseHover);
            // 
            // pcbNhaCC
            // 
            this.pcbNhaCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.pcbNhaCC.Location = new System.Drawing.Point(289, 84);
            this.pcbNhaCC.Name = "pcbNhaCC";
            this.pcbNhaCC.Size = new System.Drawing.Size(190, 160);
            this.pcbNhaCC.TabIndex = 1;
            this.pcbNhaCC.TabStop = false;
            this.pcbNhaCC.Click += new System.EventHandler(this.pcbNhaCC_Click);
            this.pcbNhaCC.MouseLeave += new System.EventHandler(this.pcbNhaCC_MouseLeave);
            this.pcbNhaCC.MouseHover += new System.EventHandler(this.pcbNhaCC_MouseHover);
            // 
            // pcbQuanLyNhanVien
            // 
            this.pcbQuanLyNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.pcbQuanLyNhanVien.Location = new System.Drawing.Point(492, 84);
            this.pcbQuanLyNhanVien.Name = "pcbQuanLyNhanVien";
            this.pcbQuanLyNhanVien.Size = new System.Drawing.Size(176, 160);
            this.pcbQuanLyNhanVien.TabIndex = 4;
            this.pcbQuanLyNhanVien.TabStop = false;
            this.pcbQuanLyNhanVien.Click += new System.EventHandler(this.pcbQuanLyNhanVien_Click);
            this.pcbQuanLyNhanVien.MouseLeave += new System.EventHandler(this.pcbQuanLyNhanVien_MouseLeave);
            this.pcbQuanLyNhanVien.MouseHover += new System.EventHandler(this.pcbQuanLyNhanVien_MouseHover);
            // 
            // fmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.large_modern_warehouse_theme_blur_background_1385_1615;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 492);
            this.Controls.Add(this.lbNCC);
            this.Controls.Add(this.lbThongKe);
            this.Controls.Add(this.lbKhachHang);
            this.Controls.Add(this.pcbNhaCC);
            this.Controls.Add(this.lbQuanLyNV);
            this.Controls.Add(this.pcbQuanLyNhanVien);
            this.Controls.Add(this.pcbThongKe);
            this.Controls.Add(this.lbKhoHang);
            this.Controls.Add(this.pcbKho);
            this.Controls.Add(this.pcbKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmQuanLy";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pcbKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNhaCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQuanLyNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbNhaCC;
        private System.Windows.Forms.PictureBox pcbThongKe;
        private System.Windows.Forms.PictureBox pcbQuanLyNhanVien;
        private System.Windows.Forms.PictureBox pcbKhachHang;
        private System.Windows.Forms.PictureBox pcbKho;
        private System.Windows.Forms.Timer tm1;
        private System.Windows.Forms.Label lbKhoHang;
        private System.Windows.Forms.Label lbNCC;
        private System.Windows.Forms.Label lbQuanLyNV;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label lbThongKe;
    }
}

