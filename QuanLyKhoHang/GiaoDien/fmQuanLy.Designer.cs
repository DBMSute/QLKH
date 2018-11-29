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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmQuanLy));
            this.pnMain = new System.Windows.Forms.Panel();
            this.ofdAVT = new System.Windows.Forms.OpenFileDialog();
            this.tmrExtend = new System.Windows.Forms.Timer(this.components);
            this.tmrExtend2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbClock = new System.Windows.Forms.Label();
            this.btnOutput = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnProfile = new System.Windows.Forms.Panel();
            this.btnEditAD = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEditDOB = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEditLN = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEditFN = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbDataCD = new System.Windows.Forms.Label();
            this.lbCD = new System.Windows.Forms.Label();
            this.lbDataST = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbDataID = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnEditPW = new System.Windows.Forms.Button();
            this.btnExtend = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbDataLG = new System.Windows.Forms.Label();
            this.lbDataAD = new System.Windows.Forms.Label();
            this.lbDataDOB = new System.Windows.Forms.Label();
            this.lbDataLN = new System.Windows.Forms.Label();
            this.lbDataFN = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbLastLogin = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbTenTK = new System.Windows.Forms.Label();
            this.btnAVT = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbPosition = new System.Windows.Forms.Label();
            this.btnSup = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnKho = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnAna = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEmp = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnCus = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnInput = new Bunifu.Framework.UI.BunifuTileButton();
            this.lbQL = new System.Windows.Forms.Label();
            this.lbDataQuanLy = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.pnProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditLN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditFN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExtend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Controls.Add(this.bunifuGradientPanel1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(840, 800);
            this.pnMain.TabIndex = 7;
            // 
            // ofdAVT
            // 
            this.ofdAVT.FileName = "ofdAVT";
            this.ofdAVT.Filter = "JPG files | *.jpg";
            this.ofdAVT.Title = "Open Avatar File";
            // 
            // tmrExtend
            // 
            this.tmrExtend.Interval = 1;
            this.tmrExtend.Tick += new System.EventHandler(this.tmrExtend_Tick);
            // 
            // tmrExtend2
            // 
            this.tmrExtend2.Interval = 1;
            this.tmrExtend2.Tick += new System.EventHandler(this.tmrExtend2_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // tmrClock
            // 
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnOutput);
            this.bunifuGradientPanel1.Controls.Add(this.pnProfile);
            this.bunifuGradientPanel1.Controls.Add(this.btnSup);
            this.bunifuGradientPanel1.Controls.Add(this.btnKho);
            this.bunifuGradientPanel1.Controls.Add(this.btnAna);
            this.bunifuGradientPanel1.Controls.Add(this.btnEmp);
            this.bunifuGradientPanel1.Controls.Add(this.btnExit);
            this.bunifuGradientPanel1.Controls.Add(this.btnCus);
            this.bunifuGradientPanel1.Controls.Add(this.btnInput);
            this.bunifuGradientPanel1.Controls.Add(this.lbClock);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(840, 800);
            this.bunifuGradientPanel1.TabIndex = 22;
            // 
            // lbClock
            // 
            this.lbClock.BackColor = System.Drawing.Color.Transparent;
            this.lbClock.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.ForeColor = System.Drawing.Color.White;
            this.lbClock.Location = new System.Drawing.Point(428, 45);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(400, 33);
            this.lbClock.TabIndex = 13;
            this.lbClock.Text = "Clock";
            this.lbClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOutput
            // 
            this.btnOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(139)))), ((int)(((byte)(42)))));
            this.btnOutput.color = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(139)))), ((int)(((byte)(42)))));
            this.btnOutput.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(149)))), ((int)(((byte)(52)))));
            this.btnOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutput.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOutput.Image = global::QuanLyKhoHang.Properties.Resources.output;
            this.btnOutput.ImagePosition = 20;
            this.btnOutput.ImageZoom = 20;
            this.btnOutput.LabelPosition = 51;
            this.btnOutput.LabelText = "Xuất hàng";
            this.btnOutput.Location = new System.Drawing.Point(333, 546);
            this.btnOutput.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(407, 160);
            this.btnOutput.TabIndex = 23;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // pnProfile
            // 
            this.pnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnProfile.Controls.Add(this.lbDataQuanLy);
            this.pnProfile.Controls.Add(this.lbQL);
            this.pnProfile.Controls.Add(this.btnEditAD);
            this.pnProfile.Controls.Add(this.btnEditDOB);
            this.pnProfile.Controls.Add(this.btnEditLN);
            this.pnProfile.Controls.Add(this.btnEditFN);
            this.pnProfile.Controls.Add(this.lbDataCD);
            this.pnProfile.Controls.Add(this.lbCD);
            this.pnProfile.Controls.Add(this.lbDataST);
            this.pnProfile.Controls.Add(this.lbStatus);
            this.pnProfile.Controls.Add(this.lbDataID);
            this.pnProfile.Controls.Add(this.lbID);
            this.pnProfile.Controls.Add(this.btnEditPW);
            this.pnProfile.Controls.Add(this.btnExtend);
            this.pnProfile.Controls.Add(this.lbDataLG);
            this.pnProfile.Controls.Add(this.lbDataAD);
            this.pnProfile.Controls.Add(this.lbDataDOB);
            this.pnProfile.Controls.Add(this.lbDataLN);
            this.pnProfile.Controls.Add(this.lbDataFN);
            this.pnProfile.Controls.Add(this.lbAddress);
            this.pnProfile.Controls.Add(this.lbLastLogin);
            this.pnProfile.Controls.Add(this.lbDateOfBirth);
            this.pnProfile.Controls.Add(this.lbLastName);
            this.pnProfile.Controls.Add(this.lbFirstName);
            this.pnProfile.Controls.Add(this.lbTenTK);
            this.pnProfile.Controls.Add(this.btnAVT);
            this.pnProfile.Controls.Add(this.lbPosition);
            this.pnProfile.Location = new System.Drawing.Point(32, 12);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.Size = new System.Drawing.Size(379, 460);
            this.pnProfile.TabIndex = 9;
            // 
            // btnEditAD
            // 
            this.btnEditAD.BackColor = System.Drawing.Color.Transparent;
            this.btnEditAD.Image = global::QuanLyKhoHang.Properties.Resources.edit;
            this.btnEditAD.ImageActive = null;
            this.btnEditAD.Location = new System.Drawing.Point(-210, 238);
            this.btnEditAD.Name = "btnEditAD";
            this.btnEditAD.Size = new System.Drawing.Size(20, 20);
            this.btnEditAD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditAD.TabIndex = 31;
            this.btnEditAD.TabStop = false;
            this.btnEditAD.Zoom = 10;
            this.btnEditAD.Click += new System.EventHandler(this.btnEditAD_Click);
            // 
            // btnEditDOB
            // 
            this.btnEditDOB.BackColor = System.Drawing.Color.Transparent;
            this.btnEditDOB.Image = global::QuanLyKhoHang.Properties.Resources.edit;
            this.btnEditDOB.ImageActive = null;
            this.btnEditDOB.Location = new System.Drawing.Point(-210, 208);
            this.btnEditDOB.Name = "btnEditDOB";
            this.btnEditDOB.Size = new System.Drawing.Size(20, 20);
            this.btnEditDOB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditDOB.TabIndex = 30;
            this.btnEditDOB.TabStop = false;
            this.btnEditDOB.Zoom = 10;
            this.btnEditDOB.Click += new System.EventHandler(this.btnEditDOB_Click);
            // 
            // btnEditLN
            // 
            this.btnEditLN.BackColor = System.Drawing.Color.Transparent;
            this.btnEditLN.Image = global::QuanLyKhoHang.Properties.Resources.edit;
            this.btnEditLN.ImageActive = null;
            this.btnEditLN.Location = new System.Drawing.Point(-210, 178);
            this.btnEditLN.Name = "btnEditLN";
            this.btnEditLN.Size = new System.Drawing.Size(20, 20);
            this.btnEditLN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditLN.TabIndex = 29;
            this.btnEditLN.TabStop = false;
            this.btnEditLN.Zoom = 10;
            this.btnEditLN.Click += new System.EventHandler(this.btnEditLN_Click);
            // 
            // btnEditFN
            // 
            this.btnEditFN.BackColor = System.Drawing.Color.Transparent;
            this.btnEditFN.Image = global::QuanLyKhoHang.Properties.Resources.edit;
            this.btnEditFN.ImageActive = null;
            this.btnEditFN.Location = new System.Drawing.Point(-210, 148);
            this.btnEditFN.Name = "btnEditFN";
            this.btnEditFN.Size = new System.Drawing.Size(20, 20);
            this.btnEditFN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditFN.TabIndex = 23;
            this.btnEditFN.TabStop = false;
            this.btnEditFN.Zoom = 10;
            this.btnEditFN.Click += new System.EventHandler(this.btnEditFN_Click);
            // 
            // lbDataCD
            // 
            this.lbDataCD.AutoSize = true;
            this.lbDataCD.BackColor = System.Drawing.Color.Transparent;
            this.lbDataCD.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbDataCD.ForeColor = System.Drawing.Color.White;
            this.lbDataCD.Location = new System.Drawing.Point(543, 324);
            this.lbDataCD.Name = "lbDataCD";
            this.lbDataCD.Size = new System.Drawing.Size(49, 24);
            this.lbDataCD.TabIndex = 27;
            this.lbDataCD.Text = "Null";
            // 
            // lbCD
            // 
            this.lbCD.AutoSize = true;
            this.lbCD.BackColor = System.Drawing.Color.Transparent;
            this.lbCD.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbCD.ForeColor = System.Drawing.Color.White;
            this.lbCD.Location = new System.Drawing.Point(-206, 324);
            this.lbCD.Name = "lbCD";
            this.lbCD.Size = new System.Drawing.Size(204, 24);
            this.lbCD.TabIndex = 26;
            this.lbCD.Text = "Ngày tạo tài khoản:";
            // 
            // lbDataST
            // 
            this.lbDataST.AutoSize = true;
            this.lbDataST.BackColor = System.Drawing.Color.Transparent;
            this.lbDataST.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbDataST.ForeColor = System.Drawing.Color.White;
            this.lbDataST.Location = new System.Drawing.Point(543, 294);
            this.lbDataST.Name = "lbDataST";
            this.lbDataST.Size = new System.Drawing.Size(49, 24);
            this.lbDataST.TabIndex = 25;
            this.lbDataST.Text = "Null";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(-206, 294);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(109, 24);
            this.lbStatus.TabIndex = 24;
            this.lbStatus.Text = "Trạng thái:";
            // 
            // lbDataID
            // 
            this.lbDataID.AutoSize = true;
            this.lbDataID.BackColor = System.Drawing.Color.Transparent;
            this.lbDataID.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbDataID.ForeColor = System.Drawing.Color.White;
            this.lbDataID.Location = new System.Drawing.Point(543, 114);
            this.lbDataID.Name = "lbDataID";
            this.lbDataID.Size = new System.Drawing.Size(49, 24);
            this.lbDataID.TabIndex = 23;
            this.lbDataID.Text = "Null";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(-206, 114);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(36, 24);
            this.lbID.TabIndex = 22;
            this.lbID.Text = "ID:";
            // 
            // btnEditPW
            // 
            this.btnEditPW.BackColor = System.Drawing.Color.Transparent;
            this.btnEditPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPW.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.btnEditPW.ForeColor = System.Drawing.Color.White;
            this.btnEditPW.Location = new System.Drawing.Point(38, 595);
            this.btnEditPW.Name = "btnEditPW";
            this.btnEditPW.Size = new System.Drawing.Size(164, 48);
            this.btnEditPW.TabIndex = 20;
            this.btnEditPW.Text = "Đổi mật khẩu";
            this.btnEditPW.UseVisualStyleBackColor = false;
            this.btnEditPW.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExtend
            // 
            this.btnExtend.BackColor = System.Drawing.Color.Transparent;
            this.btnExtend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExtend.Image = global::QuanLyKhoHang.Properties.Resources.downarrow;
            this.btnExtend.ImageActive = null;
            this.btnExtend.Location = new System.Drawing.Point(265, 65);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(35, 35);
            this.btnExtend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExtend.TabIndex = 28;
            this.btnExtend.TabStop = false;
            this.btnExtend.Zoom = 20;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // lbDataLG
            // 
            this.lbDataLG.AutoSize = true;
            this.lbDataLG.BackColor = System.Drawing.Color.Transparent;
            this.lbDataLG.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbDataLG.ForeColor = System.Drawing.Color.White;
            this.lbDataLG.Location = new System.Drawing.Point(543, 264);
            this.lbDataLG.Name = "lbDataLG";
            this.lbDataLG.Size = new System.Drawing.Size(49, 24);
            this.lbDataLG.TabIndex = 17;
            this.lbDataLG.Text = "Null";
            // 
            // lbDataAD
            // 
            this.lbDataAD.AutoSize = true;
            this.lbDataAD.BackColor = System.Drawing.Color.Transparent;
            this.lbDataAD.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbDataAD.ForeColor = System.Drawing.Color.White;
            this.lbDataAD.Location = new System.Drawing.Point(543, 234);
            this.lbDataAD.Name = "lbDataAD";
            this.lbDataAD.Size = new System.Drawing.Size(49, 24);
            this.lbDataAD.TabIndex = 16;
            this.lbDataAD.Text = "Null";
            // 
            // lbDataDOB
            // 
            this.lbDataDOB.AutoSize = true;
            this.lbDataDOB.BackColor = System.Drawing.Color.Transparent;
            this.lbDataDOB.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbDataDOB.ForeColor = System.Drawing.Color.White;
            this.lbDataDOB.Location = new System.Drawing.Point(543, 204);
            this.lbDataDOB.Name = "lbDataDOB";
            this.lbDataDOB.Size = new System.Drawing.Size(49, 24);
            this.lbDataDOB.TabIndex = 15;
            this.lbDataDOB.Text = "Null";
            // 
            // lbDataLN
            // 
            this.lbDataLN.AutoSize = true;
            this.lbDataLN.BackColor = System.Drawing.Color.Transparent;
            this.lbDataLN.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbDataLN.ForeColor = System.Drawing.Color.White;
            this.lbDataLN.Location = new System.Drawing.Point(543, 174);
            this.lbDataLN.Name = "lbDataLN";
            this.lbDataLN.Size = new System.Drawing.Size(49, 24);
            this.lbDataLN.TabIndex = 14;
            this.lbDataLN.Text = "Null";
            // 
            // lbDataFN
            // 
            this.lbDataFN.AutoSize = true;
            this.lbDataFN.BackColor = System.Drawing.Color.Transparent;
            this.lbDataFN.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbDataFN.ForeColor = System.Drawing.Color.White;
            this.lbDataFN.Location = new System.Drawing.Point(543, 144);
            this.lbDataFN.Name = "lbDataFN";
            this.lbDataFN.Size = new System.Drawing.Size(49, 24);
            this.lbDataFN.TabIndex = 13;
            this.lbDataFN.Text = "Null";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbAddress.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbAddress.ForeColor = System.Drawing.Color.White;
            this.lbAddress.Location = new System.Drawing.Point(-206, 234);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(87, 24);
            this.lbAddress.TabIndex = 12;
            this.lbAddress.Text = "Địa chỉ:";
            // 
            // lbLastLogin
            // 
            this.lbLastLogin.AutoSize = true;
            this.lbLastLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLastLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbLastLogin.ForeColor = System.Drawing.Color.White;
            this.lbLastLogin.Location = new System.Drawing.Point(-206, 264);
            this.lbLastLogin.Name = "lbLastLogin";
            this.lbLastLogin.Size = new System.Drawing.Size(129, 24);
            this.lbLastLogin.TabIndex = 11;
            this.lbLastLogin.Text = "ĐN lần cuối:";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.lbDateOfBirth.Location = new System.Drawing.Point(-206, 204);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(113, 24);
            this.lbDateOfBirth.TabIndex = 10;
            this.lbDateOfBirth.Text = "Ngày sinh:";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.BackColor = System.Drawing.Color.Transparent;
            this.lbLastName.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbLastName.ForeColor = System.Drawing.Color.White;
            this.lbLastName.Location = new System.Drawing.Point(-206, 174);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(165, 24);
            this.lbLastName.TabIndex = 9;
            this.lbLastName.Text = "Họ và tên đệm:";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lbFirstName.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbFirstName.ForeColor = System.Drawing.Color.White;
            this.lbFirstName.Location = new System.Drawing.Point(-206, 144);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(50, 24);
            this.lbFirstName.TabIndex = 8;
            this.lbFirstName.Text = "Tên:";
            // 
            // lbTenTK
            // 
            this.lbTenTK.AutoSize = true;
            this.lbTenTK.BackColor = System.Drawing.Color.Transparent;
            this.lbTenTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTenTK.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTK.ForeColor = System.Drawing.Color.White;
            this.lbTenTK.Location = new System.Drawing.Point(110, 16);
            this.lbTenTK.Name = "lbTenTK";
            this.lbTenTK.Size = new System.Drawing.Size(87, 44);
            this.lbTenTK.TabIndex = 6;
            this.lbTenTK.Text = "Null";
            // 
            // btnAVT
            // 
            this.btnAVT.BackColor = System.Drawing.Color.Transparent;
            this.btnAVT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAVT.Image = global::QuanLyKhoHang.Properties.Resources.erroravt;
            this.btnAVT.ImageActive = null;
            this.btnAVT.Location = new System.Drawing.Point(20, 10);
            this.btnAVT.Name = "btnAVT";
            this.btnAVT.Size = new System.Drawing.Size(85, 84);
            this.btnAVT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAVT.TabIndex = 5;
            this.btnAVT.TabStop = false;
            this.btnAVT.Zoom = 10;
            this.btnAVT.Click += new System.EventHandler(this.btnAVT_Click);
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.BackColor = System.Drawing.Color.Transparent;
            this.lbPosition.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.ForeColor = System.Drawing.Color.White;
            this.lbPosition.Location = new System.Drawing.Point(120, 60);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(42, 22);
            this.lbPosition.TabIndex = 7;
            this.lbPosition.Text = "Null";
            // 
            // btnSup
            // 
            this.btnSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(135)))), ((int)(((byte)(219)))));
            this.btnSup.color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(135)))), ((int)(((byte)(219)))));
            this.btnSup.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(155)))), ((int)(((byte)(239)))));
            this.btnSup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSup.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnSup.ForeColor = System.Drawing.Color.White;
            this.btnSup.Image = global::QuanLyKhoHang.Properties.Resources.supplier;
            this.btnSup.ImagePosition = 20;
            this.btnSup.ImageZoom = 20;
            this.btnSup.LabelPosition = 51;
            this.btnSup.LabelText = "Nhà cung cấp";
            this.btnSup.Location = new System.Drawing.Point(111, 352);
            this.btnSup.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(412, 160);
            this.btnSup.TabIndex = 20;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnKho
            // 
            this.btnKho.BackColor = System.Drawing.Color.SeaGreen;
            this.btnKho.color = System.Drawing.Color.SeaGreen;
            this.btnKho.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKho.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnKho.ForeColor = System.Drawing.Color.White;
            this.btnKho.Image = global::QuanLyKhoHang.Properties.Resources.warehouse;
            this.btnKho.ImagePosition = 20;
            this.btnKho.ImageZoom = 50;
            this.btnKho.LabelPosition = 51;
            this.btnKho.LabelText = "Kho hàng";
            this.btnKho.Location = new System.Drawing.Point(111, 158);
            this.btnKho.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(190, 160);
            this.btnKho.TabIndex = 17;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnAna
            // 
            this.btnAna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(81)))), ((int)(((byte)(27)))));
            this.btnAna.color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(81)))), ((int)(((byte)(27)))));
            this.btnAna.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(111)))), ((int)(((byte)(57)))));
            this.btnAna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAna.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnAna.ForeColor = System.Drawing.Color.White;
            this.btnAna.Image = global::QuanLyKhoHang.Properties.Resources.analytics;
            this.btnAna.ImagePosition = 20;
            this.btnAna.ImageZoom = 40;
            this.btnAna.LabelPosition = 51;
            this.btnAna.LabelText = "Thống kê";
            this.btnAna.Location = new System.Drawing.Point(550, 352);
            this.btnAna.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(190, 160);
            this.btnAna.TabIndex = 21;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(49)))), ((int)(((byte)(163)))));
            this.btnEmp.color = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(49)))), ((int)(((byte)(163)))));
            this.btnEmp.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmp.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnEmp.ForeColor = System.Drawing.Color.White;
            this.btnEmp.Image = global::QuanLyKhoHang.Properties.Resources.emp;
            this.btnEmp.ImagePosition = 20;
            this.btnEmp.ImageZoom = 40;
            this.btnEmp.LabelPosition = 51;
            this.btnEmp.LabelText = "Nhân viên";
            this.btnEmp.Location = new System.Drawing.Point(550, 158);
            this.btnEmp.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(190, 160);
            this.btnEmp.TabIndex = 19;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(798, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 16;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCus
            // 
            this.btnCus.BackColor = System.Drawing.Color.Maroon;
            this.btnCus.color = System.Drawing.Color.Maroon;
            this.btnCus.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCus.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnCus.ForeColor = System.Drawing.Color.White;
            this.btnCus.Image = global::QuanLyKhoHang.Properties.Resources.customer;
            this.btnCus.ImagePosition = 20;
            this.btnCus.ImageZoom = 40;
            this.btnCus.LabelPosition = 51;
            this.btnCus.LabelText = "Khách hàng";
            this.btnCus.Location = new System.Drawing.Point(333, 158);
            this.btnCus.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(190, 160);
            this.btnCus.TabIndex = 18;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInput.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInput.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInput.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnInput.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInput.Image = global::QuanLyKhoHang.Properties.Resources.input;
            this.btnInput.ImagePosition = 20;
            this.btnInput.ImageZoom = 42;
            this.btnInput.LabelPosition = 51;
            this.btnInput.LabelText = "Nhập hàng";
            this.btnInput.Location = new System.Drawing.Point(111, 546);
            this.btnInput.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(190, 160);
            this.btnInput.TabIndex = 22;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // lbQL
            // 
            this.lbQL.AutoSize = true;
            this.lbQL.BackColor = System.Drawing.Color.Transparent;
            this.lbQL.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbQL.ForeColor = System.Drawing.Color.White;
            this.lbQL.Location = new System.Drawing.Point(-206, 357);
            this.lbQL.Name = "lbQL";
            this.lbQL.Size = new System.Drawing.Size(91, 24);
            this.lbQL.TabIndex = 32;
            this.lbQL.Text = "Quản lý:";
            // 
            // lbDataQuanLy
            // 
            this.lbDataQuanLy.AutoSize = true;
            this.lbDataQuanLy.BackColor = System.Drawing.Color.Transparent;
            this.lbDataQuanLy.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbDataQuanLy.ForeColor = System.Drawing.Color.White;
            this.lbDataQuanLy.Location = new System.Drawing.Point(543, 357);
            this.lbDataQuanLy.Name = "lbDataQuanLy";
            this.lbDataQuanLy.Size = new System.Drawing.Size(49, 24);
            this.lbDataQuanLy.TabIndex = 33;
            this.lbDataQuanLy.Text = "Null";
            // 
            // fmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 800);
            this.Controls.Add(this.pnMain);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.pnMain.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.pnProfile.ResumeLayout(false);
            this.pnProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditLN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditFN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExtend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnAVT;
        private System.Windows.Forms.Label lbTenTK;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Panel pnProfile;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbLastLogin;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbDataLG;
        private System.Windows.Forms.Label lbDataAD;
        private System.Windows.Forms.Label lbDataDOB;
        private System.Windows.Forms.Label lbDataLN;
        private System.Windows.Forms.Label lbDataFN;
        private System.Windows.Forms.Button btnEditPW;
        private System.Windows.Forms.PictureBox btnExit;
        private Bunifu.Framework.UI.BunifuTileButton btnKho;
        private Bunifu.Framework.UI.BunifuTileButton btnEmp;
        private Bunifu.Framework.UI.BunifuTileButton btnCus;
        private Bunifu.Framework.UI.BunifuTileButton btnAna;
        private Bunifu.Framework.UI.BunifuTileButton btnSup;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.OpenFileDialog ofdAVT;
        private System.Windows.Forms.Label lbDataID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbDataST;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbDataCD;
        private System.Windows.Forms.Label lbCD;
        private Bunifu.Framework.UI.BunifuTileButton btnInput;
        private Bunifu.Framework.UI.BunifuImageButton btnExtend;
        private System.Windows.Forms.Timer tmrExtend;
        private System.Windows.Forms.Timer tmrExtend2;
        private Bunifu.Framework.UI.BunifuImageButton btnEditAD;
        private Bunifu.Framework.UI.BunifuImageButton btnEditDOB;
        private Bunifu.Framework.UI.BunifuImageButton btnEditLN;
        private Bunifu.Framework.UI.BunifuImageButton btnEditFN;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuTileButton btnOutput;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Label lbDataQuanLy;
        private System.Windows.Forms.Label lbQL;
    }
}