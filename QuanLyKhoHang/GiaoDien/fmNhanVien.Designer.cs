namespace QuanLyKhoHang.GiaoDien
{
    partial class fmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmNhanVien));
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbClock = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbNhaCC = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnMidR = new System.Windows.Forms.Panel();
            this.lbLG = new System.Windows.Forms.Label();
            this.pnLG = new System.Windows.Forms.Panel();
            this.lbDataLG = new System.Windows.Forms.Label();
            this.lbADD = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.pnADD = new System.Windows.Forms.Panel();
            this.btnEditADD = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbDataADD = new System.Windows.Forms.Label();
            this.pnDataDOB = new System.Windows.Forms.Panel();
            this.btnDOB = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbDataDOB = new System.Windows.Forms.Label();
            this.lbLN = new System.Windows.Forms.Label();
            this.pnDataLN = new System.Windows.Forms.Panel();
            this.btnEditLN = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbDataLN = new System.Windows.Forms.Label();
            this.lbFN = new System.Windows.Forms.Label();
            this.pnDataFN = new System.Windows.Forms.Panel();
            this.lbDataFN = new System.Windows.Forms.Label();
            this.btnEditFN = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnAVT = new System.Windows.Forms.Panel();
            this.pnName = new System.Windows.Forms.Panel();
            this.switchTinhTrang = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.lbDataPosition = new System.Windows.Forms.Label();
            this.pnMidL = new System.Windows.Forms.Panel();
            this.dtgvEmp = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.switchStatus = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.tbEmpSearch = new System.Windows.Forms.TextBox();
            this.btnCusPrint = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEmpSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEmpAdd = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEmpDel = new Bunifu.Framework.UI.BunifuTileButton();
            this.openAVT = new System.Windows.Forms.OpenFileDialog();
            this.TINHTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTLOGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOVATENDEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVT = new System.Windows.Forms.DataGridViewImageColumn();
            this.PASSWD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATEDAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.pnMidR.SuspendLayout();
            this.pnLG.SuspendLayout();
            this.pnADD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditADD)).BeginInit();
            this.pnDataDOB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDOB)).BeginInit();
            this.pnDataLN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditLN)).BeginInit();
            this.pnDataFN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditFN)).BeginInit();
            this.pnAVT.SuspendLayout();
            this.pnName.SuspendLayout();
            this.pnMidL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmp)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.pnTop;
            this.DragControl.Vertical = true;
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
            this.lbClock.TabIndex = 13;
            this.lbClock.Text = "Clock";
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
            this.lbNhaCC.Size = new System.Drawing.Size(440, 94);
            this.lbNhaCC.TabIndex = 0;
            this.lbNhaCC.Text = "Nhân Viên";
            // 
            // tmrClock
            // 
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pnMidR);
            this.bunifuGradientPanel1.Controls.Add(this.pnMidL);
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
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
            this.pnMidR.Controls.Add(this.lbLG);
            this.pnMidR.Controls.Add(this.pnLG);
            this.pnMidR.Controls.Add(this.lbADD);
            this.pnMidR.Controls.Add(this.lbDOB);
            this.pnMidR.Controls.Add(this.pnADD);
            this.pnMidR.Controls.Add(this.pnDataDOB);
            this.pnMidR.Controls.Add(this.lbLN);
            this.pnMidR.Controls.Add(this.pnDataLN);
            this.pnMidR.Controls.Add(this.lbFN);
            this.pnMidR.Controls.Add(this.pnDataFN);
            this.pnMidR.Controls.Add(this.pnAVT);
            this.pnMidR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMidR.Location = new System.Drawing.Point(757, 110);
            this.pnMidR.Name = "pnMidR";
            this.pnMidR.Size = new System.Drawing.Size(310, 600);
            this.pnMidR.TabIndex = 7;
            // 
            // lbLG
            // 
            this.lbLG.AutoSize = true;
            this.lbLG.BackColor = System.Drawing.Color.SeaGreen;
            this.lbLG.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLG.ForeColor = System.Drawing.Color.White;
            this.lbLG.Location = new System.Drawing.Point(10, 534);
            this.lbLG.Name = "lbLG";
            this.lbLG.Size = new System.Drawing.Size(193, 23);
            this.lbLG.TabIndex = 18;
            this.lbLG.Text = "Đăng nhập lần cuối";
            // 
            // pnLG
            // 
            this.pnLG.Controls.Add(this.lbDataLG);
            this.pnLG.Location = new System.Drawing.Point(0, 549);
            this.pnLG.Name = "pnLG";
            this.pnLG.Size = new System.Drawing.Size(310, 45);
            this.pnLG.TabIndex = 19;
            // 
            // lbDataLG
            // 
            this.lbDataLG.AutoSize = true;
            this.lbDataLG.BackColor = System.Drawing.Color.Transparent;
            this.lbDataLG.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataLG.ForeColor = System.Drawing.Color.White;
            this.lbDataLG.Location = new System.Drawing.Point(17, 16);
            this.lbDataLG.Name = "lbDataLG";
            this.lbDataLG.Size = new System.Drawing.Size(56, 23);
            this.lbDataLG.TabIndex = 2;
            this.lbDataLG.Text = "NULL";
            // 
            // lbADD
            // 
            this.lbADD.AutoSize = true;
            this.lbADD.BackColor = System.Drawing.Color.SeaGreen;
            this.lbADD.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lbADD.ForeColor = System.Drawing.Color.White;
            this.lbADD.Location = new System.Drawing.Point(11, 464);
            this.lbADD.Name = "lbADD";
            this.lbADD.Size = new System.Drawing.Size(79, 23);
            this.lbADD.TabIndex = 16;
            this.lbADD.Text = "Địa chỉ";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.BackColor = System.Drawing.Color.SeaGreen;
            this.lbDOB.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lbDOB.ForeColor = System.Drawing.Color.White;
            this.lbDOB.Location = new System.Drawing.Point(10, 394);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(104, 23);
            this.lbDOB.TabIndex = 14;
            this.lbDOB.Text = "Ngày sinh";
            // 
            // pnADD
            // 
            this.pnADD.Controls.Add(this.btnEditADD);
            this.pnADD.Controls.Add(this.lbDataADD);
            this.pnADD.Location = new System.Drawing.Point(1, 479);
            this.pnADD.Name = "pnADD";
            this.pnADD.Size = new System.Drawing.Size(310, 45);
            this.pnADD.TabIndex = 17;
            // 
            // btnEditADD
            // 
            this.btnEditADD.BackColor = System.Drawing.Color.Transparent;
            this.btnEditADD.Image = global::QuanLyKhoHang.Properties.Resources.edit;
            this.btnEditADD.ImageActive = null;
            this.btnEditADD.Location = new System.Drawing.Point(283, 16);
            this.btnEditADD.Name = "btnEditADD";
            this.btnEditADD.Size = new System.Drawing.Size(23, 23);
            this.btnEditADD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditADD.TabIndex = 23;
            this.btnEditADD.TabStop = false;
            this.btnEditADD.Zoom = 10;
            this.btnEditADD.Click += new System.EventHandler(this.btnEditADD_Click);
            // 
            // lbDataADD
            // 
            this.lbDataADD.AutoSize = true;
            this.lbDataADD.BackColor = System.Drawing.Color.Transparent;
            this.lbDataADD.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataADD.ForeColor = System.Drawing.Color.White;
            this.lbDataADD.Location = new System.Drawing.Point(17, 16);
            this.lbDataADD.Name = "lbDataADD";
            this.lbDataADD.Size = new System.Drawing.Size(56, 23);
            this.lbDataADD.TabIndex = 2;
            this.lbDataADD.Text = "NULL";
            // 
            // pnDataDOB
            // 
            this.pnDataDOB.Controls.Add(this.btnDOB);
            this.pnDataDOB.Controls.Add(this.lbDataDOB);
            this.pnDataDOB.Location = new System.Drawing.Point(0, 409);
            this.pnDataDOB.Name = "pnDataDOB";
            this.pnDataDOB.Size = new System.Drawing.Size(310, 45);
            this.pnDataDOB.TabIndex = 15;
            // 
            // btnDOB
            // 
            this.btnDOB.BackColor = System.Drawing.Color.Transparent;
            this.btnDOB.Image = global::QuanLyKhoHang.Properties.Resources.edit;
            this.btnDOB.ImageActive = null;
            this.btnDOB.Location = new System.Drawing.Point(284, 16);
            this.btnDOB.Name = "btnDOB";
            this.btnDOB.Size = new System.Drawing.Size(23, 23);
            this.btnDOB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDOB.TabIndex = 22;
            this.btnDOB.TabStop = false;
            this.btnDOB.Zoom = 10;
            this.btnDOB.Click += new System.EventHandler(this.btnDOB_Click);
            // 
            // lbDataDOB
            // 
            this.lbDataDOB.AutoSize = true;
            this.lbDataDOB.BackColor = System.Drawing.Color.Transparent;
            this.lbDataDOB.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataDOB.ForeColor = System.Drawing.Color.White;
            this.lbDataDOB.Location = new System.Drawing.Point(17, 16);
            this.lbDataDOB.Name = "lbDataDOB";
            this.lbDataDOB.Size = new System.Drawing.Size(56, 23);
            this.lbDataDOB.TabIndex = 2;
            this.lbDataDOB.Text = "NULL";
            // 
            // lbLN
            // 
            this.lbLN.AutoSize = true;
            this.lbLN.BackColor = System.Drawing.Color.SeaGreen;
            this.lbLN.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lbLN.ForeColor = System.Drawing.Color.White;
            this.lbLN.Location = new System.Drawing.Point(10, 324);
            this.lbLN.Name = "lbLN";
            this.lbLN.Size = new System.Drawing.Size(152, 23);
            this.lbLN.TabIndex = 12;
            this.lbLN.Text = "Họ và tên đệm";
            // 
            // pnDataLN
            // 
            this.pnDataLN.Controls.Add(this.btnEditLN);
            this.pnDataLN.Controls.Add(this.lbDataLN);
            this.pnDataLN.Location = new System.Drawing.Point(0, 339);
            this.pnDataLN.Name = "pnDataLN";
            this.pnDataLN.Size = new System.Drawing.Size(310, 45);
            this.pnDataLN.TabIndex = 13;
            // 
            // btnEditLN
            // 
            this.btnEditLN.BackColor = System.Drawing.Color.Transparent;
            this.btnEditLN.Image = global::QuanLyKhoHang.Properties.Resources.edit;
            this.btnEditLN.ImageActive = null;
            this.btnEditLN.Location = new System.Drawing.Point(284, 16);
            this.btnEditLN.Name = "btnEditLN";
            this.btnEditLN.Size = new System.Drawing.Size(23, 23);
            this.btnEditLN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditLN.TabIndex = 21;
            this.btnEditLN.TabStop = false;
            this.btnEditLN.Zoom = 10;
            this.btnEditLN.Click += new System.EventHandler(this.btnEditLN_Click);
            // 
            // lbDataLN
            // 
            this.lbDataLN.AutoSize = true;
            this.lbDataLN.BackColor = System.Drawing.Color.Transparent;
            this.lbDataLN.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataLN.ForeColor = System.Drawing.Color.White;
            this.lbDataLN.Location = new System.Drawing.Point(17, 16);
            this.lbDataLN.Name = "lbDataLN";
            this.lbDataLN.Size = new System.Drawing.Size(56, 23);
            this.lbDataLN.TabIndex = 1;
            this.lbDataLN.Text = "NULL";
            // 
            // lbFN
            // 
            this.lbFN.AutoSize = true;
            this.lbFN.BackColor = System.Drawing.Color.SeaGreen;
            this.lbFN.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lbFN.ForeColor = System.Drawing.Color.White;
            this.lbFN.Location = new System.Drawing.Point(10, 254);
            this.lbFN.Name = "lbFN";
            this.lbFN.Size = new System.Drawing.Size(43, 23);
            this.lbFN.TabIndex = 8;
            this.lbFN.Text = "Tên";
            // 
            // pnDataFN
            // 
            this.pnDataFN.Controls.Add(this.lbDataFN);
            this.pnDataFN.Controls.Add(this.btnEditFN);
            this.pnDataFN.Location = new System.Drawing.Point(0, 269);
            this.pnDataFN.Name = "pnDataFN";
            this.pnDataFN.Size = new System.Drawing.Size(310, 45);
            this.pnDataFN.TabIndex = 11;
            // 
            // lbDataFN
            // 
            this.lbDataFN.AutoSize = true;
            this.lbDataFN.BackColor = System.Drawing.Color.Transparent;
            this.lbDataFN.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataFN.ForeColor = System.Drawing.Color.White;
            this.lbDataFN.Location = new System.Drawing.Point(17, 16);
            this.lbDataFN.Name = "lbDataFN";
            this.lbDataFN.Size = new System.Drawing.Size(56, 23);
            this.lbDataFN.TabIndex = 0;
            this.lbDataFN.Text = "NULL";
            // 
            // btnEditFN
            // 
            this.btnEditFN.BackColor = System.Drawing.Color.Transparent;
            this.btnEditFN.Image = global::QuanLyKhoHang.Properties.Resources.edit;
            this.btnEditFN.ImageActive = null;
            this.btnEditFN.Location = new System.Drawing.Point(284, 16);
            this.btnEditFN.Name = "btnEditFN";
            this.btnEditFN.Size = new System.Drawing.Size(23, 23);
            this.btnEditFN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditFN.TabIndex = 20;
            this.btnEditFN.TabStop = false;
            this.btnEditFN.Zoom = 10;
            this.btnEditFN.Click += new System.EventHandler(this.btnEditFN_Click);
            // 
            // pnAVT
            // 
            this.pnAVT.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.erroravt;
            this.pnAVT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnAVT.Controls.Add(this.pnName);
            this.pnAVT.Location = new System.Drawing.Point(-85, -10);
            this.pnAVT.Name = "pnAVT";
            this.pnAVT.Size = new System.Drawing.Size(480, 250);
            this.pnAVT.TabIndex = 5;
            this.pnAVT.Click += new System.EventHandler(this.pnAVT_Click);
            // 
            // pnName
            // 
            this.pnName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnName.Controls.Add(this.switchTinhTrang);
            this.pnName.Controls.Add(this.lbDataPosition);
            this.pnName.Controls.Add(this.cbPosition);
            this.pnName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnName.Location = new System.Drawing.Point(0, 200);
            this.pnName.Name = "pnName";
            this.pnName.Size = new System.Drawing.Size(480, 50);
            this.pnName.TabIndex = 0;
            // 
            // switchTinhTrang
            // 
            this.switchTinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.switchTinhTrang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchTinhTrang.BackgroundImage")));
            this.switchTinhTrang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchTinhTrang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchTinhTrang.Location = new System.Drawing.Point(346, 16);
            this.switchTinhTrang.Name = "switchTinhTrang";
            this.switchTinhTrang.OffColor = System.Drawing.Color.Gray;
            this.switchTinhTrang.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.switchTinhTrang.Size = new System.Drawing.Size(35, 20);
            this.switchTinhTrang.TabIndex = 4;
            this.switchTinhTrang.Value = true;
            this.switchTinhTrang.OnValueChange += new System.EventHandler(this.switchTinhTrang_OnValueChange);
            // 
            // lbDataPosition
            // 
            this.lbDataPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDataPosition.BackColor = System.Drawing.Color.Transparent;
            this.lbDataPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDataPosition.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataPosition.ForeColor = System.Drawing.Color.White;
            this.lbDataPosition.Location = new System.Drawing.Point(88, 0);
            this.lbDataPosition.Name = "lbDataPosition";
            this.lbDataPosition.Size = new System.Drawing.Size(232, 50);
            this.lbDataPosition.TabIndex = 3;
            this.lbDataPosition.Text = "NULL";
            this.lbDataPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnMidL
            // 
            this.pnMidL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnMidL.Controls.Add(this.dtgvEmp);
            this.pnMidL.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMidL.Location = new System.Drawing.Point(10, 110);
            this.pnMidL.Name = "pnMidL";
            this.pnMidL.Size = new System.Drawing.Size(740, 500);
            this.pnMidL.TabIndex = 5;
            // 
            // dtgvEmp
            // 
            this.dtgvEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEmp.BackgroundColor = System.Drawing.Color.White;
            this.dtgvEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TENTK,
            this.CREATEDAY,
            this.PASSWD,
            this.AVT,
            this.HOVATENDEM,
            this.TEN,
            this.NGAYSINH,
            this.DIACHI,
            this.LASTLOGIN,
            this.PERS,
            this.TINHTRANG});
            this.dtgvEmp.Location = new System.Drawing.Point(10, 10);
            this.dtgvEmp.Name = "dtgvEmp";
            this.dtgvEmp.Size = new System.Drawing.Size(721, 480);
            this.dtgvEmp.TabIndex = 2;
            this.dtgvEmp.TabStop = false;
            this.dtgvEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEmp_CellClick);
            this.dtgvEmp.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEmp_CellValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.switchStatus);
            this.panel2.Controls.Add(this.tbEmpSearch);
            this.panel2.Controls.Add(this.btnCusPrint);
            this.panel2.Controls.Add(this.btnEmpSave);
            this.panel2.Controls.Add(this.btnEmpAdd);
            this.panel2.Controls.Add(this.btnEmpDel);
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 100);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 21);
            this.label1.TabIndex = 101;
            this.label1.Text = "Tình trạng (Hoạt động | Bị Khóa)";
            // 
            // switchStatus
            // 
            this.switchStatus.BackColor = System.Drawing.Color.Transparent;
            this.switchStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchStatus.BackgroundImage")));
            this.switchStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchStatus.Location = new System.Drawing.Point(26, 63);
            this.switchStatus.Name = "switchStatus";
            this.switchStatus.OffColor = System.Drawing.Color.Gray;
            this.switchStatus.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.switchStatus.Size = new System.Drawing.Size(35, 20);
            this.switchStatus.TabIndex = 100;
            this.switchStatus.Value = true;
            this.switchStatus.OnValueChange += new System.EventHandler(this.switchStatus_OnValueChange);
            // 
            // tbEmpSearch
            // 
            this.tbEmpSearch.BackColor = System.Drawing.Color.White;
            this.tbEmpSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmpSearch.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbEmpSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.tbEmpSearch.Location = new System.Drawing.Point(20, 10);
            this.tbEmpSearch.Name = "tbEmpSearch";
            this.tbEmpSearch.Size = new System.Drawing.Size(307, 40);
            this.tbEmpSearch.TabIndex = 99;
            this.tbEmpSearch.Text = "Tìm kiếm...";
            this.tbEmpSearch.TextChanged += new System.EventHandler(this.tbEmpSearch_TextChanged);
            this.tbEmpSearch.Enter += new System.EventHandler(this.tbEmpSearch_Enter);
            this.tbEmpSearch.Leave += new System.EventHandler(this.tbEmpSearch_Leave);
            // 
            // btnCusPrint
            // 
            this.btnCusPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCusPrint.color = System.Drawing.Color.SeaGreen;
            this.btnCusPrint.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCusPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCusPrint.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.btnCusPrint.ForeColor = System.Drawing.Color.White;
            this.btnCusPrint.Image = global::QuanLyKhoHang.Properties.Resources.print;
            this.btnCusPrint.ImagePosition = 10;
            this.btnCusPrint.ImageZoom = 50;
            this.btnCusPrint.LabelPosition = 30;
            this.btnCusPrint.LabelText = "In";
            this.btnCusPrint.Location = new System.Drawing.Point(656, 10);
            this.btnCusPrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnCusPrint.Name = "btnCusPrint";
            this.btnCusPrint.Size = new System.Drawing.Size(85, 85);
            this.btnCusPrint.TabIndex = 9;
            // 
            // btnEmpSave
            // 
            this.btnEmpSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEmpSave.color = System.Drawing.Color.SeaGreen;
            this.btnEmpSave.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnEmpSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpSave.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpSave.ForeColor = System.Drawing.Color.White;
            this.btnEmpSave.Image = global::QuanLyKhoHang.Properties.Resources.save;
            this.btnEmpSave.ImagePosition = 10;
            this.btnEmpSave.ImageZoom = 50;
            this.btnEmpSave.LabelPosition = 30;
            this.btnEmpSave.LabelText = "Lưu";
            this.btnEmpSave.Location = new System.Drawing.Point(551, 10);
            this.btnEmpSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnEmpSave.Name = "btnEmpSave";
            this.btnEmpSave.Size = new System.Drawing.Size(85, 85);
            this.btnEmpSave.TabIndex = 10;
            this.btnEmpSave.Click += new System.EventHandler(this.btnEmpSave_Click);
            // 
            // btnEmpAdd
            // 
            this.btnEmpAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEmpAdd.color = System.Drawing.Color.SeaGreen;
            this.btnEmpAdd.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnEmpAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpAdd.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpAdd.ForeColor = System.Drawing.Color.White;
            this.btnEmpAdd.Image = global::QuanLyKhoHang.Properties.Resources.add;
            this.btnEmpAdd.ImagePosition = 10;
            this.btnEmpAdd.ImageZoom = 50;
            this.btnEmpAdd.LabelPosition = 30;
            this.btnEmpAdd.LabelText = "Thêm";
            this.btnEmpAdd.Location = new System.Drawing.Point(341, 10);
            this.btnEmpAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnEmpAdd.Name = "btnEmpAdd";
            this.btnEmpAdd.Size = new System.Drawing.Size(85, 85);
            this.btnEmpAdd.TabIndex = 7;
            this.btnEmpAdd.Click += new System.EventHandler(this.btnEmpAdd_Click);
            // 
            // btnEmpDel
            // 
            this.btnEmpDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEmpDel.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEmpDel.colorActive = System.Drawing.Color.Red;
            this.btnEmpDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpDel.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.btnEmpDel.ForeColor = System.Drawing.Color.White;
            this.btnEmpDel.Image = global::QuanLyKhoHang.Properties.Resources.delete;
            this.btnEmpDel.ImagePosition = 10;
            this.btnEmpDel.ImageZoom = 50;
            this.btnEmpDel.LabelPosition = 30;
            this.btnEmpDel.LabelText = "Xóa";
            this.btnEmpDel.Location = new System.Drawing.Point(446, 10);
            this.btnEmpDel.Margin = new System.Windows.Forms.Padding(5);
            this.btnEmpDel.Name = "btnEmpDel";
            this.btnEmpDel.Size = new System.Drawing.Size(85, 85);
            this.btnEmpDel.TabIndex = 8;
            this.btnEmpDel.Click += new System.EventHandler(this.btnEmpDel_Click);
            // 
            // openAVT
            // 
            this.openAVT.FileName = "openAVT";
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.DataPropertyName = "TINHTRANG";
            this.TINHTRANG.HeaderText = "Tình trạng";
            this.TINHTRANG.Name = "TINHTRANG";
            this.TINHTRANG.Visible = false;
            // 
            // PERS
            // 
            this.PERS.DataPropertyName = "PERS";
            this.PERS.HeaderText = "Chức vụ";
            this.PERS.Name = "PERS";
            this.PERS.Visible = false;
            // 
            // LASTLOGIN
            // 
            this.LASTLOGIN.DataPropertyName = "LASTLOGIN";
            this.LASTLOGIN.HeaderText = "Lần đăng nhập cuối";
            this.LASTLOGIN.Name = "LASTLOGIN";
            this.LASTLOGIN.Visible = false;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = false;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Visible = false;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "Tên";
            this.TEN.Name = "TEN";
            this.TEN.Visible = false;
            // 
            // HOVATENDEM
            // 
            this.HOVATENDEM.DataPropertyName = "HOVATENDEM";
            this.HOVATENDEM.HeaderText = "Họ và tên đệm";
            this.HOVATENDEM.Name = "HOVATENDEM";
            this.HOVATENDEM.Visible = false;
            // 
            // AVT
            // 
            this.AVT.DataPropertyName = "AVT";
            this.AVT.HeaderText = "Avatar";
            this.AVT.Name = "AVT";
            this.AVT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AVT.Visible = false;
            // 
            // PASSWD
            // 
            this.PASSWD.DataPropertyName = "PASSWD";
            this.PASSWD.HeaderText = "Mật khẩu";
            this.PASSWD.Name = "PASSWD";
            this.PASSWD.Visible = false;
            // 
            // CREATEDAY
            // 
            this.CREATEDAY.DataPropertyName = "CREATEDAY";
            this.CREATEDAY.HeaderText = "Ngày tạo tài khoản";
            this.CREATEDAY.Name = "CREATEDAY";
            this.CREATEDAY.ReadOnly = true;
            // 
            // TENTK
            // 
            this.TENTK.DataPropertyName = "TENTK";
            this.TENTK.HeaderText = "Tên tài khoản";
            this.TENTK.Name = "TENTK";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã nhân viên";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // cbPosition
            // 
            this.cbPosition.BackColor = System.Drawing.Color.SeaGreen;
            this.cbPosition.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.ForeColor = System.Drawing.Color.White;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbPosition.Location = new System.Drawing.Point(88, 4);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(252, 41);
            this.cbPosition.TabIndex = 5;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // fmNhanVien
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmNhanVien";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.pnMidR.ResumeLayout(false);
            this.pnMidR.PerformLayout();
            this.pnLG.ResumeLayout(false);
            this.pnLG.PerformLayout();
            this.pnADD.ResumeLayout(false);
            this.pnADD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditADD)).EndInit();
            this.pnDataDOB.ResumeLayout(false);
            this.pnDataDOB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDOB)).EndInit();
            this.pnDataLN.ResumeLayout(false);
            this.pnDataLN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditLN)).EndInit();
            this.pnDataFN.ResumeLayout(false);
            this.pnDataFN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditFN)).EndInit();
            this.pnAVT.ResumeLayout(false);
            this.pnName.ResumeLayout(false);
            this.pnMidL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNhaCC;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Panel pnMidL;
        private System.Windows.Forms.DataGridView dtgvEmp;
        private System.Windows.Forms.Panel pnTop;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel pnMidR;
        private Bunifu.Framework.UI.BunifuTileButton btnEmpSave;
        private Bunifu.Framework.UI.BunifuTileButton btnCusPrint;
        private Bunifu.Framework.UI.BunifuTileButton btnEmpDel;
        private Bunifu.Framework.UI.BunifuTileButton btnEmpAdd;
        private System.Windows.Forms.TextBox tbEmpSearch;
        private System.Windows.Forms.Label lbClock;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.Panel pnAVT;
        private System.Windows.Forms.Label lbDataPosition;
        private System.Windows.Forms.Panel pnName;
        private System.Windows.Forms.Label lbFN;
        private System.Windows.Forms.Panel pnDataFN;
        private System.Windows.Forms.Label lbLG;
        private System.Windows.Forms.Panel pnLG;
        private System.Windows.Forms.Label lbADD;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Panel pnADD;
        private System.Windows.Forms.Panel pnDataDOB;
        private System.Windows.Forms.Label lbLN;
        private System.Windows.Forms.Panel pnDataLN;
        private System.Windows.Forms.Label lbDataLG;
        private System.Windows.Forms.Label lbDataADD;
        private System.Windows.Forms.Label lbDataDOB;
        private System.Windows.Forms.Label lbDataLN;
        private System.Windows.Forms.Label lbDataFN;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchTinhTrang;
        private Bunifu.Framework.UI.BunifuImageButton btnEditADD;
        private Bunifu.Framework.UI.BunifuImageButton btnDOB;
        private Bunifu.Framework.UI.BunifuImageButton btnEditLN;
        private Bunifu.Framework.UI.BunifuImageButton btnEditFN;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.OpenFileDialog openAVT;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchStatus;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEDAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWD;
        private System.Windows.Forms.DataGridViewImageColumn AVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOVATENDEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTLOGIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINHTRANG;
    }
}