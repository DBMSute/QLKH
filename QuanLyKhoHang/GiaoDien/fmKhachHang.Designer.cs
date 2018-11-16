namespace QuanLyKhoHang.GiaoDien
{
    partial class fmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmKhachHang));
            this.pnMidR = new System.Windows.Forms.Panel();
            this.btnCusSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCusPrint = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCusDel = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCusAdd = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbCusSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvCus = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SODT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnMidL = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbNhaCC = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbClock = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.pnMidR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCus)).BeginInit();
            this.pnMidL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.pnTop.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMidR
            // 
            this.pnMidR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnMidR.Controls.Add(this.btnCusSave);
            this.pnMidR.Controls.Add(this.btnCusPrint);
            this.pnMidR.Controls.Add(this.btnCusDel);
            this.pnMidR.Controls.Add(this.btnCusAdd);
            this.pnMidR.Controls.Add(this.tbCusSearch);
            this.pnMidR.Location = new System.Drawing.Point(757, 110);
            this.pnMidR.Name = "pnMidR";
            this.pnMidR.Size = new System.Drawing.Size(310, 500);
            this.pnMidR.TabIndex = 6;
            // 
            // btnCusSave
            // 
            this.btnCusSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCusSave.color = System.Drawing.Color.SeaGreen;
            this.btnCusSave.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCusSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCusSave.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnCusSave.ForeColor = System.Drawing.Color.White;
            this.btnCusSave.Image = global::QuanLyKhoHang.Properties.Resources.save;
            this.btnCusSave.ImagePosition = 25;
            this.btnCusSave.ImageZoom = 40;
            this.btnCusSave.LabelPosition = 51;
            this.btnCusSave.LabelText = "Lưu";
            this.btnCusSave.Location = new System.Drawing.Point(10, 341);
            this.btnCusSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnCusSave.Name = "btnCusSave";
            this.btnCusSave.Size = new System.Drawing.Size(135, 135);
            this.btnCusSave.TabIndex = 10;
            this.btnCusSave.Click += new System.EventHandler(this.btnCusSave_Click);
            // 
            // btnCusPrint
            // 
            this.btnCusPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCusPrint.color = System.Drawing.Color.SeaGreen;
            this.btnCusPrint.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCusPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCusPrint.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnCusPrint.ForeColor = System.Drawing.Color.White;
            this.btnCusPrint.Image = global::QuanLyKhoHang.Properties.Resources.print;
            this.btnCusPrint.ImagePosition = 25;
            this.btnCusPrint.ImageZoom = 40;
            this.btnCusPrint.LabelPosition = 50;
            this.btnCusPrint.LabelText = "In";
            this.btnCusPrint.Location = new System.Drawing.Point(165, 341);
            this.btnCusPrint.Margin = new System.Windows.Forms.Padding(6);
            this.btnCusPrint.Name = "btnCusPrint";
            this.btnCusPrint.Size = new System.Drawing.Size(135, 135);
            this.btnCusPrint.TabIndex = 9;
            this.btnCusPrint.Click += new System.EventHandler(this.btnCusPrint_Click);
            // 
            // btnCusDel
            // 
            this.btnCusDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCusDel.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCusDel.colorActive = System.Drawing.Color.Red;
            this.btnCusDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCusDel.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnCusDel.ForeColor = System.Drawing.Color.White;
            this.btnCusDel.Image = global::QuanLyKhoHang.Properties.Resources.delete;
            this.btnCusDel.ImagePosition = 25;
            this.btnCusDel.ImageZoom = 40;
            this.btnCusDel.LabelPosition = 50;
            this.btnCusDel.LabelText = "Xóa";
            this.btnCusDel.Location = new System.Drawing.Point(165, 182);
            this.btnCusDel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCusDel.Name = "btnCusDel";
            this.btnCusDel.Size = new System.Drawing.Size(135, 135);
            this.btnCusDel.TabIndex = 8;
            this.btnCusDel.Click += new System.EventHandler(this.btnCusDel_Click);
            // 
            // btnCusAdd
            // 
            this.btnCusAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCusAdd.color = System.Drawing.Color.SeaGreen;
            this.btnCusAdd.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCusAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCusAdd.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnCusAdd.ForeColor = System.Drawing.Color.White;
            this.btnCusAdd.Image = global::QuanLyKhoHang.Properties.Resources.add;
            this.btnCusAdd.ImagePosition = 25;
            this.btnCusAdd.ImageZoom = 40;
            this.btnCusAdd.LabelPosition = 50;
            this.btnCusAdd.LabelText = "Thêm";
            this.btnCusAdd.Location = new System.Drawing.Point(10, 182);
            this.btnCusAdd.Margin = new System.Windows.Forms.Padding(7);
            this.btnCusAdd.Name = "btnCusAdd";
            this.btnCusAdd.Size = new System.Drawing.Size(135, 135);
            this.btnCusAdd.TabIndex = 7;
            this.btnCusAdd.Click += new System.EventHandler(this.btnCusAdd_Click);
            // 
            // tbCusSearch
            // 
            this.tbCusSearch.BackColor = System.Drawing.Color.White;
            this.tbCusSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCusSearch.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbCusSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.tbCusSearch.Location = new System.Drawing.Point(10, 10);
            this.tbCusSearch.Name = "tbCusSearch";
            this.tbCusSearch.Size = new System.Drawing.Size(290, 40);
            this.tbCusSearch.TabIndex = 99;
            this.tbCusSearch.Text = "Tìm kiếm...";
            this.tbCusSearch.TextChanged += new System.EventHandler(this.tbWareSearch_TextChanged);
            this.tbCusSearch.Enter += new System.EventHandler(this.tbCusSearch_Enter);
            this.tbCusSearch.Leave += new System.EventHandler(this.tbCusSearch_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 100);
            this.panel2.TabIndex = 4;
            // 
            // dtgvCus
            // 
            this.dtgvCus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCus.BackgroundColor = System.Drawing.Color.White;
            this.dtgvCus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TEN,
            this.SODT,
            this.DIACHI});
            this.dtgvCus.Location = new System.Drawing.Point(10, 10);
            this.dtgvCus.Name = "dtgvCus";
            this.dtgvCus.Size = new System.Drawing.Size(721, 480);
            this.dtgvCus.TabIndex = 2;
            this.dtgvCus.TabStop = false;
            this.dtgvCus.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCus_CellValueChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã khách hàng";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "Tên";
            this.TEN.Name = "TEN";
            // 
            // SODT
            // 
            this.SODT.DataPropertyName = "SODT";
            this.SODT.HeaderText = "Số điện thoại";
            this.SODT.Name = "SODT";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bạc Liêu",
            "Bắc Cạn",
            "Bắc Giang",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Dương",
            "Bình Định",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Cần Thơ",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Đồng Nai",
            "Đồng Tháp",
            "Đồng Tháp",
            "Điện Biên",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hòa Bình",
            "Hậu Giang",
            "Hưng Yên",
            "Hồ Chí Minh",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lào Cai",
            "Lạng Sơn",
            "Lâm Đồng",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DIACHI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pnMidL
            // 
            this.pnMidL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnMidL.Controls.Add(this.dtgvCus);
            this.pnMidL.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMidL.Location = new System.Drawing.Point(10, 110);
            this.pnMidL.Name = "pnMidL";
            this.pnMidL.Size = new System.Drawing.Size(740, 500);
            this.pnMidL.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Image = global::QuanLyKhoHang.Properties.Resources.exit;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1028, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbNhaCC
            // 
            this.lbNhaCC.AutoSize = true;
            this.lbNhaCC.BackColor = System.Drawing.Color.Transparent;
            this.lbNhaCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNhaCC.Font = new System.Drawing.Font("Century Gothic", 59F);
            this.lbNhaCC.ForeColor = System.Drawing.Color.White;
            this.lbNhaCC.Location = new System.Drawing.Point(10, 0);
            this.lbNhaCC.Name = "lbNhaCC";
            this.lbNhaCC.Size = new System.Drawing.Size(519, 94);
            this.lbNhaCC.TabIndex = 0;
            this.lbNhaCC.Text = "Khách Hàng";
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnTop.Controls.Add(this.lbClock);
            this.pnTop.Controls.Add(this.btnExit);
            this.pnTop.Controls.Add(this.lbNhaCC);
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1080, 100);
            this.pnTop.TabIndex = 3;
            // 
            // lbClock
            // 
            this.lbClock.AutoSize = true;
            this.lbClock.BackColor = System.Drawing.Color.Transparent;
            this.lbClock.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.ForeColor = System.Drawing.Color.White;
            this.lbClock.Location = new System.Drawing.Point(951, 61);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(93, 33);
            this.lbClock.TabIndex = 12;
            this.lbClock.Text = "Clock";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
            this.bunifuGradientPanel1.Controls.Add(this.pnMidR);
            this.bunifuGradientPanel1.Controls.Add(this.pnTop);
            this.bunifuGradientPanel1.Controls.Add(this.pnMidL);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1080, 720);
            this.bunifuGradientPanel1.TabIndex = 7;
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // fmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmKhachHang";
            this.Text = "fmKhachHang";
            this.pnMidR.ResumeLayout(false);
            this.pnMidR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCus)).EndInit();
            this.pnMidL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMidR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvCus;
        private System.Windows.Forms.Panel pnMidL;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Label lbNhaCC;
        private System.Windows.Forms.Panel pnTop;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.TextBox tbCusSearch;
        private Bunifu.Framework.UI.BunifuTileButton btnCusSave;
        private Bunifu.Framework.UI.BunifuTileButton btnCusPrint;
        private Bunifu.Framework.UI.BunifuTileButton btnCusDel;
        private Bunifu.Framework.UI.BunifuTileButton btnCusAdd;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SODT;
        private System.Windows.Forms.DataGridViewComboBoxColumn DIACHI;
    }
}