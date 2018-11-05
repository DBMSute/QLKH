namespace QuanLyKhoHang.GiaoDien
{
    partial class fmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDangNhap));
            this.lb1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbLogin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbRemember = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbRemember = new Bunifu.Framework.UI.BunifuCheckbox();
            this.pnRight = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.tbACC = new System.Windows.Forms.TextBox();
            this.cpLoading = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.tmrLoading = new System.Windows.Forms.Timer(this.components);
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lb1.ForeColor = System.Drawing.Color.White;
            this.lb1.Location = new System.Drawing.Point(231, 167);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(116, 21);
            this.lb1.TabIndex = 7;
            this.lb1.Text = "Who are you?";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Century Gothic", 50F);
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(3, 18);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(351, 81);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Welcome";
            // 
            // lbRemember
            // 
            this.lbRemember.AutoSize = true;
            this.lbRemember.BackColor = System.Drawing.Color.Transparent;
            this.lbRemember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemember.ForeColor = System.Drawing.Color.White;
            this.lbRemember.Location = new System.Drawing.Point(251, 306);
            this.lbRemember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRemember.Name = "lbRemember";
            this.lbRemember.Size = new System.Drawing.Size(96, 21);
            this.lbRemember.TabIndex = 7;
            this.lbRemember.Text = "Remember";
            // 
            // cbRemember
            // 
            this.cbRemember.BackColor = System.Drawing.Color.Black;
            this.cbRemember.ChechedOffColor = System.Drawing.Color.Black;
            this.cbRemember.Checked = true;
            this.cbRemember.CheckedOnColor = System.Drawing.Color.Black;
            this.cbRemember.ForeColor = System.Drawing.Color.White;
            this.cbRemember.Location = new System.Drawing.Point(226, 307);
            this.cbRemember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(20, 20);
            this.cbRemember.TabIndex = 7;
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnRight.Controls.Add(this.btnExit);
            this.pnRight.Controls.Add(this.btnLogin);
            this.pnRight.Controls.Add(this.pictureBox2);
            this.pnRight.Controls.Add(this.pictureBox1);
            this.pnRight.Controls.Add(this.tbPW);
            this.pnRight.Controls.Add(this.tbACC);
            this.pnRight.Controls.Add(this.lb1);
            this.pnRight.Controls.Add(this.lbLogin);
            this.pnRight.Controls.Add(this.lbRemember);
            this.pnRight.Controls.Add(this.cbRemember);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(506, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(398, 447);
            this.pnRight.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.ActiveBorderThickness = 1;
            this.btnExit.ActiveCornerRadius = 1;
            this.btnExit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.ActiveForecolor = System.Drawing.Color.White;
            this.btnExit.ActiveLineColor = System.Drawing.Color.White;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.ButtonText = "Exit";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IdleBorderThickness = 1;
            this.btnExit.IdleCornerRadius = 1;
            this.btnExit.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnExit.IdleForecolor = System.Drawing.Color.White;
            this.btnExit.IdleLineColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(207, 343);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 63);
            this.btnExit.TabIndex = 21;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 1;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.White;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 1;
            this.btnLogin.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnLogin.IdleForecolor = System.Drawing.Color.White;
            this.btnLogin.IdleLineColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(51, 343);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 63);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.user;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(51, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.password;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(51, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tbPW
            // 
            this.tbPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPW.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPW.Location = new System.Drawing.Point(97, 259);
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(250, 34);
            this.tbPW.TabIndex = 9;
            // 
            // tbACC
            // 
            this.tbACC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbACC.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbACC.Location = new System.Drawing.Point(97, 201);
            this.tbACC.Name = "tbACC";
            this.tbACC.Size = new System.Drawing.Size(250, 34);
            this.tbACC.TabIndex = 8;
            // 
            // cpLoading
            // 
            this.cpLoading.animated = false;
            this.cpLoading.animationIterval = 5;
            this.cpLoading.animationSpeed = 1;
            this.cpLoading.BackColor = System.Drawing.Color.Transparent;
            this.cpLoading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpLoading.BackgroundImage")));
            this.cpLoading.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpLoading.ForeColor = System.Drawing.Color.White;
            this.cpLoading.LabelVisible = true;
            this.cpLoading.LineProgressThickness = 7;
            this.cpLoading.LineThickness = 5;
            this.cpLoading.Location = new System.Drawing.Point(142, 125);
            this.cpLoading.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cpLoading.MaxValue = 100;
            this.cpLoading.Name = "cpLoading";
            this.cpLoading.ProgressBackColor = System.Drawing.Color.White;
            this.cpLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpLoading.Size = new System.Drawing.Size(213, 213);
            this.cpLoading.TabIndex = 8;
            this.cpLoading.Value = 0;
            this.cpLoading.Visible = false;
            // 
            // tmrLoading
            // 
            this.tmrLoading.Interval = 1;
            this.tmrLoading.Tick += new System.EventHandler(this.tmrLoading_Tick);
            // 
            // fmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 447);
            this.Controls.Add(this.cpLoading);
            this.Controls.Add(this.pnRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmDangNhap";
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lb1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel lbRemember;
        private Bunifu.Framework.UI.BunifuCheckbox cbRemember;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.TextBox tbACC;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpLoading;
        private System.Windows.Forms.Timer tmrLoading;
    }
}