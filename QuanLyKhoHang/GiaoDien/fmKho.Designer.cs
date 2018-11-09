namespace QuanLyKhoHang.GiaoDien
{
    partial class fmKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmKho));
            this.pnMidR = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnPrint = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDel = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuTileButton();
            this.lbNhaCC = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.btnback = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnMidL = new System.Windows.Forms.Panel();
            this.dtgvWare = new System.Windows.Forms.DataGridView();
            this.pnTop = new System.Windows.Forms.Panel();
            this.tmrSlide = new System.Windows.Forms.Timer(this.components);
            this.pnMidL2 = new System.Windows.Forms.Panel();
            this.dtgvWare2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tmrSlide2 = new System.Windows.Forms.Timer(this.components);
            this.pnBackground = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAIKHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOIHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnMidR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.pnMidL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWare)).BeginInit();
            this.pnTop.SuspendLayout();
            this.pnMidL2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWare2)).BeginInit();
            this.pnBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMidR
            // 
            this.pnMidR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnMidR.Controls.Add(this.tbSearch);
            this.pnMidR.Controls.Add(this.pbSearch);
            this.pnMidR.Controls.Add(this.btnSave);
            this.pnMidR.Controls.Add(this.btnPrint);
            this.pnMidR.Controls.Add(this.btnDel);
            this.pnMidR.Controls.Add(this.btnAdd);
            this.pnMidR.Location = new System.Drawing.Point(757, 110);
            this.pnMidR.Name = "pnMidR";
            this.pnMidR.Size = new System.Drawing.Size(310, 500);
            this.pnMidR.TabIndex = 6;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.tbSearch.Location = new System.Drawing.Point(10, 10);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(244, 40);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.Text = "Search...";
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.pbSearch.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.search;
            this.pbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSearch.Location = new System.Drawing.Point(260, 10);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(40, 40);
            this.pbSearch.TabIndex = 5;
            this.pbSearch.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.color = System.Drawing.Color.SeaGreen;
            this.btnSave.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::QuanLyKhoHang.Properties.Resources.save;
            this.btnSave.ImagePosition = 25;
            this.btnSave.ImageZoom = 40;
            this.btnSave.LabelPosition = 51;
            this.btnSave.LabelText = "Save";
            this.btnSave.Location = new System.Drawing.Point(165, 342);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 135);
            this.btnSave.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.color = System.Drawing.Color.SeaGreen;
            this.btnPrint.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::QuanLyKhoHang.Properties.Resources.print;
            this.btnPrint.ImagePosition = 25;
            this.btnPrint.ImageZoom = 40;
            this.btnPrint.LabelPosition = 50;
            this.btnPrint.LabelText = "Print";
            this.btnPrint.Location = new System.Drawing.Point(10, 342);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(135, 135);
            this.btnPrint.TabIndex = 2;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDel.color = System.Drawing.Color.SeaGreen;
            this.btnDel.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Image = global::QuanLyKhoHang.Properties.Resources.delete;
            this.btnDel.ImagePosition = 25;
            this.btnDel.ImageZoom = 40;
            this.btnDel.LabelPosition = 50;
            this.btnDel.LabelText = "Delete";
            this.btnDel.Location = new System.Drawing.Point(165, 183);
            this.btnDel.Margin = new System.Windows.Forms.Padding(6);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(135, 135);
            this.btnDel.TabIndex = 1;
            this.btnDel.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.color = System.Drawing.Color.SeaGreen;
            this.btnAdd.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::QuanLyKhoHang.Properties.Resources.add;
            this.btnAdd.ImagePosition = 25;
            this.btnAdd.ImageZoom = 40;
            this.btnAdd.LabelPosition = 50;
            this.btnAdd.LabelText = "Add";
            this.btnAdd.Location = new System.Drawing.Point(10, 183);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 135);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbNhaCC
            // 
            this.lbNhaCC.AutoSize = true;
            this.lbNhaCC.BackColor = System.Drawing.Color.Transparent;
            this.lbNhaCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNhaCC.Font = new System.Drawing.Font("Century Gothic", 59F);
            this.lbNhaCC.ForeColor = System.Drawing.Color.White;
            this.lbNhaCC.Location = new System.Drawing.Point(68, 4);
            this.lbNhaCC.Name = "lbNhaCC";
            this.lbNhaCC.Size = new System.Drawing.Size(473, 94);
            this.lbNhaCC.TabIndex = 0;
            this.lbNhaCC.Text = "Warehouse";
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 3;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 4;
            this.bunifuCircleProgressbar1.LineThickness = 3;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(658, -2);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(7);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(100, 100);
            this.bunifuCircleProgressbar1.TabIndex = 1;
            this.bunifuCircleProgressbar1.Value = 25;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.Image = global::QuanLyKhoHang.Properties.Resources.back;
            this.btnback.ImageActive = null;
            this.btnback.Location = new System.Drawing.Point(12, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(40, 40);
            this.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnback.TabIndex = 3;
            this.btnback.TabStop = false;
            this.btnback.Zoom = 10;
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
            // pnMidL
            // 
            this.pnMidL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnMidL.Controls.Add(this.dtgvWare);
            this.pnMidL.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMidL.Location = new System.Drawing.Point(10, 110);
            this.pnMidL.Name = "pnMidL";
            this.pnMidL.Size = new System.Drawing.Size(740, 500);
            this.pnMidL.TabIndex = 5;
            // 
            // dtgvWare
            // 
            this.dtgvWare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvWare.BackgroundColor = System.Drawing.Color.White;
            this.dtgvWare.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvWare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvWare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TEN,
            this.DIACHI,
            this.TAIKHOAN,
            this.GIOIHAN});
            this.dtgvWare.Location = new System.Drawing.Point(10, 60);
            this.dtgvWare.Name = "dtgvWare";
            this.dtgvWare.Size = new System.Drawing.Size(721, 430);
            this.dtgvWare.TabIndex = 2;
            this.dtgvWare.TabStop = false;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnTop.Controls.Add(this.btnback);
            this.pnTop.Controls.Add(this.btnExit);
            this.pnTop.Controls.Add(this.lbNhaCC);
            this.pnTop.Controls.Add(this.bunifuCircleProgressbar1);
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1080, 100);
            this.pnTop.TabIndex = 3;
            // 
            // tmrSlide
            // 
            this.tmrSlide.Interval = 4;
            this.tmrSlide.Tick += new System.EventHandler(this.tmrSlide_Tick);
            // 
            // pnMidL2
            // 
            this.pnMidL2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnMidL2.Controls.Add(this.dtgvWare2);
            this.pnMidL2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMidL2.Location = new System.Drawing.Point(-990, 110);
            this.pnMidL2.Name = "pnMidL2";
            this.pnMidL2.Size = new System.Drawing.Size(740, 500);
            this.pnMidL2.TabIndex = 6;
            // 
            // dtgvWare2
            // 
            this.dtgvWare2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvWare2.BackgroundColor = System.Drawing.Color.White;
            this.dtgvWare2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvWare2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvWare2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.dtgvWare2.Location = new System.Drawing.Point(10, 60);
            this.dtgvWare2.Name = "dtgvWare2";
            this.dtgvWare2.Size = new System.Drawing.Size(0, 0);
            this.dtgvWare2.TabIndex = 2;
            this.dtgvWare2.TabStop = false;
            this.dtgvWare2.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhà CC";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TEN";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn3.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TAIKHOAN";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quản lý";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "TINHTRANG";
            this.dataGridViewCheckBoxColumn1.FalseValue = "FALSE";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Tình trạng";
            this.dataGridViewCheckBoxColumn1.IndeterminateValue = "null";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.TrueValue = "TRUE";
            // 
            // tmrSlide2
            // 
            this.tmrSlide2.Interval = 4;
            this.tmrSlide2.Tick += new System.EventHandler(this.tmrSlide2_Tick);
            // 
            // pnBackground
            // 
            this.pnBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnBackground.BackgroundImage")));
            this.pnBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBackground.Controls.Add(this.pnMidL2);
            this.pnBackground.Controls.Add(this.pnTop);
            this.pnBackground.Controls.Add(this.pnMidL);
            this.pnBackground.Controls.Add(this.pnMidR);
            this.pnBackground.Controls.Add(this.panel2);
            this.pnBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackground.GradientBottomLeft = System.Drawing.Color.Navy;
            this.pnBackground.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.pnBackground.GradientTopLeft = System.Drawing.Color.SeaGreen;
            this.pnBackground.GradientTopRight = System.Drawing.Color.Red;
            this.pnBackground.Location = new System.Drawing.Point(0, 0);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Quality = 20;
            this.pnBackground.Size = new System.Drawing.Size(1080, 720);
            this.pnBackground.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 100);
            this.panel2.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã nhà CC";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "Tên";
            this.TEN.Name = "TEN";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // TAIKHOAN
            // 
            this.TAIKHOAN.DataPropertyName = "TAIKHOAN";
            this.TAIKHOAN.HeaderText = "Quản lý";
            this.TAIKHOAN.Name = "TAIKHOAN";
            // 
            // GIOIHAN
            // 
            this.GIOIHAN.DataPropertyName = "GIOIHAN";
            this.GIOIHAN.HeaderText = "Sức chứa";
            this.GIOIHAN.Name = "GIOIHAN";
            // 
            // fmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pnBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmKhoHang";
            this.pnMidR.ResumeLayout(false);
            this.pnMidR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.pnMidL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWare)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnMidL2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWare2)).EndInit();
            this.pnBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMidR;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox pbSearch;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private Bunifu.Framework.UI.BunifuTileButton btnPrint;
        private Bunifu.Framework.UI.BunifuTileButton btnDel;
        private Bunifu.Framework.UI.BunifuTileButton btnAdd;
        private System.Windows.Forms.Label lbNhaCC;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private Bunifu.Framework.UI.BunifuImageButton btnback;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Panel pnMidL;
        private System.Windows.Forms.DataGridView dtgvWare;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Timer tmrSlide;
        private System.Windows.Forms.Panel pnMidL2;
        private System.Windows.Forms.DataGridView dtgvWare2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Timer tmrSlide2;
        private Bunifu.Framework.UI.BunifuGradientPanel pnBackground;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAIKHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOIHAN;
    }
}