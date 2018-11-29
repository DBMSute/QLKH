namespace QuanLyKhoHang.GiaoDien
{
    partial class fmNhaCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmNhaCC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnMidR = new System.Windows.Forms.Panel();
            this.btnSupSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSupPrint = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSupDel = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSupAdd = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbSupSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnMidL = new System.Windows.Forms.Panel();
            this.dtgvSup = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SODT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbClock = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbNhaCC = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.pnMidR.SuspendLayout();
            this.pnMidL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSup)).BeginInit();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pnMidR);
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
            this.bunifuGradientPanel1.Controls.Add(this.pnMidL);
            this.bunifuGradientPanel1.Controls.Add(this.pnTop);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1080, 720);
            this.bunifuGradientPanel1.TabIndex = 8;
            // 
            // pnMidR
            // 
            this.pnMidR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnMidR.Controls.Add(this.btnSupSave);
            this.pnMidR.Controls.Add(this.btnSupPrint);
            this.pnMidR.Controls.Add(this.btnSupDel);
            this.pnMidR.Controls.Add(this.btnSupAdd);
            this.pnMidR.Controls.Add(this.tbSupSearch);
            this.pnMidR.Location = new System.Drawing.Point(757, 110);
            this.pnMidR.Name = "pnMidR";
            this.pnMidR.Size = new System.Drawing.Size(310, 500);
            this.pnMidR.TabIndex = 7;
            // 
            // btnSupSave
            // 
            this.btnSupSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSupSave.color = System.Drawing.Color.SeaGreen;
            this.btnSupSave.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnSupSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupSave.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnSupSave.ForeColor = System.Drawing.Color.White;
            this.btnSupSave.Image = global::QuanLyKhoHang.Properties.Resources.save;
            this.btnSupSave.ImagePosition = 25;
            this.btnSupSave.ImageZoom = 40;
            this.btnSupSave.LabelPosition = 51;
            this.btnSupSave.LabelText = "Lưu";
            this.btnSupSave.Location = new System.Drawing.Point(10, 341);
            this.btnSupSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSupSave.Name = "btnSupSave";
            this.btnSupSave.Size = new System.Drawing.Size(135, 135);
            this.btnSupSave.TabIndex = 10;
            this.btnSupSave.Click += new System.EventHandler(this.btnSupSave_Click);
            // 
            // btnSupPrint
            // 
            this.btnSupPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSupPrint.color = System.Drawing.Color.SeaGreen;
            this.btnSupPrint.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnSupPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupPrint.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnSupPrint.ForeColor = System.Drawing.Color.White;
            this.btnSupPrint.Image = global::QuanLyKhoHang.Properties.Resources.print;
            this.btnSupPrint.ImagePosition = 25;
            this.btnSupPrint.ImageZoom = 40;
            this.btnSupPrint.LabelPosition = 50;
            this.btnSupPrint.LabelText = "In";
            this.btnSupPrint.Location = new System.Drawing.Point(165, 341);
            this.btnSupPrint.Margin = new System.Windows.Forms.Padding(6);
            this.btnSupPrint.Name = "btnSupPrint";
            this.btnSupPrint.Size = new System.Drawing.Size(135, 135);
            this.btnSupPrint.TabIndex = 9;
            this.btnSupPrint.Click += new System.EventHandler(this.btnSupPrint_Click);
            // 
            // btnSupDel
            // 
            this.btnSupDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSupDel.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSupDel.colorActive = System.Drawing.Color.Red;
            this.btnSupDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupDel.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnSupDel.ForeColor = System.Drawing.Color.White;
            this.btnSupDel.Image = global::QuanLyKhoHang.Properties.Resources.delete;
            this.btnSupDel.ImagePosition = 25;
            this.btnSupDel.ImageZoom = 40;
            this.btnSupDel.LabelPosition = 50;
            this.btnSupDel.LabelText = "Xóa";
            this.btnSupDel.Location = new System.Drawing.Point(165, 182);
            this.btnSupDel.Margin = new System.Windows.Forms.Padding(6);
            this.btnSupDel.Name = "btnSupDel";
            this.btnSupDel.Size = new System.Drawing.Size(135, 135);
            this.btnSupDel.TabIndex = 8;
            this.btnSupDel.Click += new System.EventHandler(this.btnSupDel_Click);
            // 
            // btnSupAdd
            // 
            this.btnSupAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSupAdd.color = System.Drawing.Color.SeaGreen;
            this.btnSupAdd.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnSupAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupAdd.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnSupAdd.ForeColor = System.Drawing.Color.White;
            this.btnSupAdd.Image = global::QuanLyKhoHang.Properties.Resources.add;
            this.btnSupAdd.ImagePosition = 25;
            this.btnSupAdd.ImageZoom = 40;
            this.btnSupAdd.LabelPosition = 50;
            this.btnSupAdd.LabelText = "Thêm";
            this.btnSupAdd.Location = new System.Drawing.Point(10, 182);
            this.btnSupAdd.Margin = new System.Windows.Forms.Padding(7);
            this.btnSupAdd.Name = "btnSupAdd";
            this.btnSupAdd.Size = new System.Drawing.Size(135, 135);
            this.btnSupAdd.TabIndex = 7;
            this.btnSupAdd.Click += new System.EventHandler(this.btnSupAdd_Click);
            // 
            // tbSupSearch
            // 
            this.tbSupSearch.BackColor = System.Drawing.Color.White;
            this.tbSupSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSupSearch.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbSupSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.tbSupSearch.Location = new System.Drawing.Point(10, 10);
            this.tbSupSearch.Name = "tbSupSearch";
            this.tbSupSearch.Size = new System.Drawing.Size(290, 40);
            this.tbSupSearch.TabIndex = 99;
            this.tbSupSearch.Text = "Tìm kiếm...";
            this.tbSupSearch.TextChanged += new System.EventHandler(this.tbSupSearch_TextChanged);
            this.tbSupSearch.Enter += new System.EventHandler(this.tbSupSearch_Enter);
            this.tbSupSearch.Leave += new System.EventHandler(this.tbSupSearch_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 100);
            this.panel2.TabIndex = 1;
            // 
            // pnMidL
            // 
            this.pnMidL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnMidL.Controls.Add(this.dtgvSup);
            this.pnMidL.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMidL.Location = new System.Drawing.Point(10, 110);
            this.pnMidL.Name = "pnMidL";
            this.pnMidL.Size = new System.Drawing.Size(740, 500);
            this.pnMidL.TabIndex = 1;
            // 
            // dtgvSup
            // 
            this.dtgvSup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSup.BackgroundColor = System.Drawing.Color.White;
            this.dtgvSup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TEN,
            this.DIACHI,
            this.SODT,
            this.QGIA});
            this.dtgvSup.Location = new System.Drawing.Point(10, 10);
            this.dtgvSup.Name = "dtgvSup";
            this.dtgvSup.Size = new System.Drawing.Size(721, 480);
            this.dtgvSup.TabIndex = 2;
            this.dtgvSup.TabStop = false;
            this.dtgvSup.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSup_CellValueChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "Mã nhà CC";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.TEN.DefaultCellStyle = dataGridViewCellStyle2;
            this.TEN.HeaderText = "Tên";
            this.TEN.Name = "TEN";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.DIACHI.DefaultCellStyle = dataGridViewCellStyle3;
            this.DIACHI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // SODT
            // 
            this.SODT.DataPropertyName = "SODT";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.SODT.DefaultCellStyle = dataGridViewCellStyle4;
            this.SODT.HeaderText = "Số điện thoại";
            this.SODT.Name = "SODT";
            // 
            // QGIA
            // 
            this.QGIA.DataPropertyName = "QGIA";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.QGIA.DefaultCellStyle = dataGridViewCellStyle5;
            this.QGIA.HeaderText = "Quốc gia";
            this.QGIA.Name = "QGIA";
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnTop.Controls.Add(this.lbClock);
            this.pnTop.Controls.Add(this.btnExit);
            this.pnTop.Controls.Add(this.lbNhaCC);
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1080, 100);
            this.pnTop.TabIndex = 0;
            // 
            // lbClock
            // 
            this.lbClock.BackColor = System.Drawing.Color.Transparent;
            this.lbClock.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.ForeColor = System.Drawing.Color.White;
            this.lbClock.Location = new System.Drawing.Point(667, 61);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(400, 33);
            this.lbClock.TabIndex = 13;
            this.lbClock.Text = "Clock";
            this.lbClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lbNhaCC.BackColor = System.Drawing.Color.Transparent;
            this.lbNhaCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNhaCC.Font = new System.Drawing.Font("Century Gothic", 59F);
            this.lbNhaCC.ForeColor = System.Drawing.Color.White;
            this.lbNhaCC.Location = new System.Drawing.Point(10, 0);
            this.lbNhaCC.Name = "lbNhaCC";
            this.lbNhaCC.Size = new System.Drawing.Size(829, 94);
            this.lbNhaCC.TabIndex = 0;
            this.lbNhaCC.Text = "Nhà Cung Cấp";
            // 
            // fmNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fmNhaCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cung cấp";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.pnMidR.ResumeLayout(false);
            this.pnMidR.PerformLayout();
            this.pnMidL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSup)).EndInit();
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbNhaCC;
        private System.Windows.Forms.Panel pnMidL;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.DataGridView dtgvSup;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel pnMidR;
        private Bunifu.Framework.UI.BunifuTileButton btnSupSave;
        private Bunifu.Framework.UI.BunifuTileButton btnSupPrint;
        private Bunifu.Framework.UI.BunifuTileButton btnSupDel;
        private Bunifu.Framework.UI.BunifuTileButton btnSupAdd;
        private System.Windows.Forms.TextBox tbSupSearch;
        private System.Windows.Forms.Timer tmrClock;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewComboBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SODT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QGIA;
        private System.Windows.Forms.Label lbClock;
    }
}