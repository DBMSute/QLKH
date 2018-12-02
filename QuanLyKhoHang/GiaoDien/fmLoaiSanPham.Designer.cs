namespace QuanLyKhoHang.GiaoDien
{
    partial class fmLoaiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLoaiSanPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbClock = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbLSP = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnMidR = new System.Windows.Forms.Panel();
            this.btnLSPSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnLSPPrint = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnLSPDel = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnLSPAdd = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbLSPSearch = new System.Windows.Forms.TextBox();
            this.pnMidL = new System.Windows.Forms.Panel();
            this.dtgvLSP = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.pnMidR.SuspendLayout();
            this.pnMidL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLSP)).BeginInit();
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
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnTop.Controls.Add(this.lbClock);
            this.pnTop.Controls.Add(this.btnExit);
            this.pnTop.Controls.Add(this.lbLSP);
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1080, 100);
            this.pnTop.TabIndex = 3;
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
            // lbLSP
            // 
            this.lbLSP.AutoSize = true;
            this.lbLSP.BackColor = System.Drawing.Color.Transparent;
            this.lbLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLSP.Font = new System.Drawing.Font("Century Gothic", 59F);
            this.lbLSP.ForeColor = System.Drawing.Color.White;
            this.lbLSP.Location = new System.Drawing.Point(10, 0);
            this.lbLSP.Name = "lbLSP";
            this.lbLSP.Size = new System.Drawing.Size(577, 94);
            this.lbLSP.TabIndex = 0;
            this.lbLSP.Text = "Loại Sản Phẩm";
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1080, 722);
            this.bunifuGradientPanel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 100);
            this.panel2.TabIndex = 4;
            // 
            // pnMidR
            // 
            this.pnMidR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnMidR.Controls.Add(this.btnLSPSave);
            this.pnMidR.Controls.Add(this.btnLSPPrint);
            this.pnMidR.Controls.Add(this.btnLSPDel);
            this.pnMidR.Controls.Add(this.btnLSPAdd);
            this.pnMidR.Controls.Add(this.tbLSPSearch);
            this.pnMidR.Location = new System.Drawing.Point(757, 110);
            this.pnMidR.Name = "pnMidR";
            this.pnMidR.Size = new System.Drawing.Size(310, 500);
            this.pnMidR.TabIndex = 6;
            // 
            // btnLSPSave
            // 
            this.btnLSPSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLSPSave.color = System.Drawing.Color.SeaGreen;
            this.btnLSPSave.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnLSPSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLSPSave.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnLSPSave.ForeColor = System.Drawing.Color.White;
            this.btnLSPSave.Image = global::QuanLyKhoHang.Properties.Resources.save;
            this.btnLSPSave.ImagePosition = 25;
            this.btnLSPSave.ImageZoom = 40;
            this.btnLSPSave.LabelPosition = 51;
            this.btnLSPSave.LabelText = "Lưu";
            this.btnLSPSave.Location = new System.Drawing.Point(10, 341);
            this.btnLSPSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnLSPSave.Name = "btnLSPSave";
            this.btnLSPSave.Size = new System.Drawing.Size(135, 135);
            this.btnLSPSave.TabIndex = 10;
            this.btnLSPSave.Click += new System.EventHandler(this.btnLSPSave_Click);
            // 
            // btnLSPPrint
            // 
            this.btnLSPPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLSPPrint.color = System.Drawing.Color.SeaGreen;
            this.btnLSPPrint.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnLSPPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLSPPrint.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnLSPPrint.ForeColor = System.Drawing.Color.White;
            this.btnLSPPrint.Image = global::QuanLyKhoHang.Properties.Resources.print;
            this.btnLSPPrint.ImagePosition = 25;
            this.btnLSPPrint.ImageZoom = 40;
            this.btnLSPPrint.LabelPosition = 50;
            this.btnLSPPrint.LabelText = "In";
            this.btnLSPPrint.Location = new System.Drawing.Point(165, 341);
            this.btnLSPPrint.Margin = new System.Windows.Forms.Padding(6);
            this.btnLSPPrint.Name = "btnLSPPrint";
            this.btnLSPPrint.Size = new System.Drawing.Size(135, 135);
            this.btnLSPPrint.TabIndex = 9;
            this.btnLSPPrint.Click += new System.EventHandler(this.btnLSPPrint_Click);
            // 
            // btnLSPDel
            // 
            this.btnLSPDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLSPDel.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLSPDel.colorActive = System.Drawing.Color.Red;
            this.btnLSPDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLSPDel.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnLSPDel.ForeColor = System.Drawing.Color.White;
            this.btnLSPDel.Image = global::QuanLyKhoHang.Properties.Resources.delete;
            this.btnLSPDel.ImagePosition = 25;
            this.btnLSPDel.ImageZoom = 40;
            this.btnLSPDel.LabelPosition = 50;
            this.btnLSPDel.LabelText = "Xóa";
            this.btnLSPDel.Location = new System.Drawing.Point(165, 182);
            this.btnLSPDel.Margin = new System.Windows.Forms.Padding(6);
            this.btnLSPDel.Name = "btnLSPDel";
            this.btnLSPDel.Size = new System.Drawing.Size(135, 135);
            this.btnLSPDel.TabIndex = 8;
            this.btnLSPDel.Click += new System.EventHandler(this.btnLSPDel_Click);
            // 
            // btnLSPAdd
            // 
            this.btnLSPAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLSPAdd.color = System.Drawing.Color.SeaGreen;
            this.btnLSPAdd.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnLSPAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLSPAdd.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnLSPAdd.ForeColor = System.Drawing.Color.White;
            this.btnLSPAdd.Image = global::QuanLyKhoHang.Properties.Resources.add;
            this.btnLSPAdd.ImagePosition = 25;
            this.btnLSPAdd.ImageZoom = 40;
            this.btnLSPAdd.LabelPosition = 50;
            this.btnLSPAdd.LabelText = "Thêm";
            this.btnLSPAdd.Location = new System.Drawing.Point(10, 182);
            this.btnLSPAdd.Margin = new System.Windows.Forms.Padding(7);
            this.btnLSPAdd.Name = "btnLSPAdd";
            this.btnLSPAdd.Size = new System.Drawing.Size(135, 135);
            this.btnLSPAdd.TabIndex = 7;
            this.btnLSPAdd.Click += new System.EventHandler(this.btnLSPAdd_Click);
            // 
            // tbLSPSearch
            // 
            this.tbLSPSearch.BackColor = System.Drawing.Color.White;
            this.tbLSPSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLSPSearch.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbLSPSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.tbLSPSearch.Location = new System.Drawing.Point(10, 10);
            this.tbLSPSearch.Name = "tbLSPSearch";
            this.tbLSPSearch.Size = new System.Drawing.Size(290, 40);
            this.tbLSPSearch.TabIndex = 99;
            this.tbLSPSearch.Text = "Tìm kiếm...";
            this.tbLSPSearch.TextChanged += new System.EventHandler(this.tbLSPSearch_TextChanged);
            this.tbLSPSearch.Enter += new System.EventHandler(this.tbLSPSearch_Enter);
            this.tbLSPSearch.Leave += new System.EventHandler(this.tbLSPSearch_Leave);
            // 
            // pnMidL
            // 
            this.pnMidL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnMidL.Controls.Add(this.dtgvLSP);
            this.pnMidL.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMidL.Location = new System.Drawing.Point(10, 110);
            this.pnMidL.Name = "pnMidL";
            this.pnMidL.Size = new System.Drawing.Size(740, 500);
            this.pnMidL.TabIndex = 5;
            // 
            // dtgvLSP
            // 
            this.dtgvLSP.AllowUserToResizeColumns = false;
            this.dtgvLSP.AllowUserToResizeRows = false;
            this.dtgvLSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLSP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvLSP.BackgroundColor = System.Drawing.Color.White;
            this.dtgvLSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TEN,
            this.MOTA});
            this.dtgvLSP.Location = new System.Drawing.Point(10, 10);
            this.dtgvLSP.Name = "dtgvLSP";
            this.dtgvLSP.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLSP.Size = new System.Drawing.Size(721, 480);
            this.dtgvLSP.TabIndex = 2;
            this.dtgvLSP.TabStop = false;
            this.dtgvLSP.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLSP_CellValueChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "Mã loại sản phẩm";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.TEN.DefaultCellStyle = dataGridViewCellStyle2;
            this.TEN.HeaderText = "Tên loại";
            this.TEN.Name = "TEN";
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MOTA.DefaultCellStyle = dataGridViewCellStyle3;
            this.MOTA.HeaderText = "Mô tả";
            this.MOTA.Name = "MOTA";
            // 
            // fmLoaiSanPham
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1080, 722);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fmLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Sản Phẩm";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.pnMidR.ResumeLayout(false);
            this.pnMidR.PerformLayout();
            this.pnMidL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrClock;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Label lbLSP;
        private System.Windows.Forms.Panel pnMidL;
        private System.Windows.Forms.DataGridView dtgvLSP;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnMidR;
        private Bunifu.Framework.UI.BunifuTileButton btnLSPSave;
        private Bunifu.Framework.UI.BunifuTileButton btnLSPPrint;
        private Bunifu.Framework.UI.BunifuTileButton btnLSPDel;
        private Bunifu.Framework.UI.BunifuTileButton btnLSPAdd;
        private System.Windows.Forms.TextBox tbLSPSearch;
        private System.Windows.Forms.Panel pnTop;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.Label lbClock;
    }
}