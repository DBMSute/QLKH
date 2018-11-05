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
            this.tmrButon = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAna = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSup = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEmp = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pnProfile = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbDataLG = new System.Windows.Forms.Label();
            this.lbDataDOB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDataLN = new System.Windows.Forms.Label();
            this.lbDataFN = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbLastLogin = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnAvar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbPosition = new System.Windows.Forms.Label();
            this.btnKho = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCus = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.pnProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvar)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrButon
            // 
            this.tmrButon.Interval = 3;
            this.tmrButon.Tick += new System.EventHandler(this.tmrButon_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pnProfile);
            this.panel1.Controls.Add(this.btnKho);
            this.panel1.Controls.Add(this.btnSup);
            this.panel1.Controls.Add(this.btnAna);
            this.panel1.Controls.Add(this.btnEmp);
            this.panel1.Controls.Add(this.btnCus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 547);
            this.panel1.TabIndex = 7;
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
            this.btnSup.Size = new System.Drawing.Size(407, 160);
            this.btnSup.TabIndex = 20;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
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
            // pnProfile
            // 
            this.pnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnProfile.Controls.Add(this.btnSave);
            this.pnProfile.Controls.Add(this.btnEdit);
            this.pnProfile.Controls.Add(this.lbDataLG);
            this.pnProfile.Controls.Add(this.lbDataDOB);
            this.pnProfile.Controls.Add(this.label2);
            this.pnProfile.Controls.Add(this.lbDataLN);
            this.pnProfile.Controls.Add(this.lbDataFN);
            this.pnProfile.Controls.Add(this.lbAddress);
            this.pnProfile.Controls.Add(this.lbLastLogin);
            this.pnProfile.Controls.Add(this.lbDateOfBirth);
            this.pnProfile.Controls.Add(this.lbLastName);
            this.pnProfile.Controls.Add(this.lbFirstName);
            this.pnProfile.Controls.Add(this.lbName);
            this.pnProfile.Controls.Add(this.btnAvar);
            this.pnProfile.Controls.Add(this.lbPosition);
            this.pnProfile.Location = new System.Drawing.Point(32, 12);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.Size = new System.Drawing.Size(246, 97);
            this.pnProfile.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(196, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 48);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(42, 382);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 48);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // lbDataLG
            // 
            this.lbDataLG.AutoSize = true;
            this.lbDataLG.BackColor = System.Drawing.Color.Transparent;
            this.lbDataLG.Font = new System.Drawing.Font("Century Gothic", 16.75F);
            this.lbDataLG.ForeColor = System.Drawing.Color.White;
            this.lbDataLG.Location = new System.Drawing.Point(181, 329);
            this.lbDataLG.Name = "lbDataLG";
            this.lbDataLG.Size = new System.Drawing.Size(55, 27);
            this.lbDataLG.TabIndex = 17;
            this.lbDataLG.Text = "Null";
            // 
            // lbDataDOB
            // 
            this.lbDataDOB.AutoSize = true;
            this.lbDataDOB.BackColor = System.Drawing.Color.Transparent;
            this.lbDataDOB.Font = new System.Drawing.Font("Century Gothic", 16.75F);
            this.lbDataDOB.ForeColor = System.Drawing.Color.White;
            this.lbDataDOB.Location = new System.Drawing.Point(181, 279);
            this.lbDataDOB.Name = "lbDataDOB";
            this.lbDataDOB.Size = new System.Drawing.Size(55, 27);
            this.lbDataDOB.TabIndex = 16;
            this.lbDataDOB.Text = "Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(181, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Null";
            // 
            // lbDataLN
            // 
            this.lbDataLN.AutoSize = true;
            this.lbDataLN.BackColor = System.Drawing.Color.Transparent;
            this.lbDataLN.Font = new System.Drawing.Font("Century Gothic", 16.75F);
            this.lbDataLN.ForeColor = System.Drawing.Color.White;
            this.lbDataLN.Location = new System.Drawing.Point(181, 179);
            this.lbDataLN.Name = "lbDataLN";
            this.lbDataLN.Size = new System.Drawing.Size(55, 27);
            this.lbDataLN.TabIndex = 14;
            this.lbDataLN.Text = "Null";
            // 
            // lbDataFN
            // 
            this.lbDataFN.AutoSize = true;
            this.lbDataFN.BackColor = System.Drawing.Color.Transparent;
            this.lbDataFN.Font = new System.Drawing.Font("Century Gothic", 16.75F);
            this.lbDataFN.ForeColor = System.Drawing.Color.White;
            this.lbDataFN.Location = new System.Drawing.Point(181, 129);
            this.lbDataFN.Name = "lbDataFN";
            this.lbDataFN.Size = new System.Drawing.Size(55, 27);
            this.lbDataFN.TabIndex = 13;
            this.lbDataFN.Text = "Null";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbAddress.Font = new System.Drawing.Font("Century Gothic", 16.75F);
            this.lbAddress.ForeColor = System.Drawing.Color.White;
            this.lbAddress.Location = new System.Drawing.Point(16, 279);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(107, 27);
            this.lbAddress.TabIndex = 12;
            this.lbAddress.Text = "Address:";
            // 
            // lbLastLogin
            // 
            this.lbLastLogin.AutoSize = true;
            this.lbLastLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLastLogin.Font = new System.Drawing.Font("Century Gothic", 16.75F);
            this.lbLastLogin.ForeColor = System.Drawing.Color.White;
            this.lbLastLogin.Location = new System.Drawing.Point(16, 329);
            this.lbLastLogin.Name = "lbLastLogin";
            this.lbLastLogin.Size = new System.Drawing.Size(124, 27);
            this.lbLastLogin.TabIndex = 11;
            this.lbLastLogin.Text = "Last login:";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Century Gothic", 16.75F);
            this.lbDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.lbDateOfBirth.Location = new System.Drawing.Point(16, 229);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(159, 27);
            this.lbDateOfBirth.TabIndex = 10;
            this.lbDateOfBirth.Text = "Date of birth:";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.BackColor = System.Drawing.Color.Transparent;
            this.lbLastName.Font = new System.Drawing.Font("Century Gothic", 16.75F);
            this.lbLastName.ForeColor = System.Drawing.Color.White;
            this.lbLastName.Location = new System.Drawing.Point(16, 179);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(135, 27);
            this.lbLastName.TabIndex = 9;
            this.lbLastName.Text = "Last name:";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lbFirstName.Font = new System.Drawing.Font("Century Gothic", 16.75F);
            this.lbFirstName.ForeColor = System.Drawing.Color.White;
            this.lbFirstName.Location = new System.Drawing.Point(16, 129);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(132, 27);
            this.lbFirstName.TabIndex = 8;
            this.lbFirstName.Text = "First name:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(95, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(102, 44);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Ly Ly";
            // 
            // btnAvar
            // 
            this.btnAvar.BackColor = System.Drawing.Color.Transparent;
            this.btnAvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAvar.Image = global::QuanLyKhoHang.Properties.Resources.avt;
            this.btnAvar.ImageActive = null;
            this.btnAvar.Location = new System.Drawing.Point(9, 16);
            this.btnAvar.Name = "btnAvar";
            this.btnAvar.Size = new System.Drawing.Size(70, 70);
            this.btnAvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAvar.TabIndex = 5;
            this.btnAvar.TabStop = false;
            this.btnAvar.Zoom = 10;
            this.btnAvar.Click += new System.EventHandler(this.btnAvar_Click);
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.BackColor = System.Drawing.Color.Transparent;
            this.lbPosition.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.ForeColor = System.Drawing.Color.White;
            this.lbPosition.Location = new System.Drawing.Point(101, 60);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(96, 22);
            this.lbPosition.TabIndex = 7;
            this.lbPosition.Text = "Manager";
            // 
            // btnKho
            // 
            this.btnKho.BackColor = System.Drawing.Color.SeaGreen;
            this.btnKho.color = System.Drawing.Color.SeaGreen;
            this.btnKho.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKho.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.btnKho.ForeColor = System.Drawing.Color.White;
            this.btnKho.Image = ((System.Drawing.Image)(resources.GetObject("btnKho.Image")));
            this.btnKho.ImagePosition = 20;
            this.btnKho.ImageZoom = 40;
            this.btnKho.LabelPosition = 51;
            this.btnKho.LabelText = "Kho";
            this.btnKho.Location = new System.Drawing.Point(111, 158);
            this.btnKho.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(190, 160);
            this.btnKho.TabIndex = 17;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
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
            this.btnCus.LabelText = "Khách Hàng";
            this.btnCus.Location = new System.Drawing.Point(328, 158);
            this.btnCus.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(190, 160);
            this.btnCus.TabIndex = 18;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // fmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 547);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmQuanLy2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.pnProfile.ResumeLayout(false);
            this.pnProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnAvar;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Timer tmrButon;
        private System.Windows.Forms.Panel pnProfile;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbLastLogin;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbDataLG;
        private System.Windows.Forms.Label lbDataDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDataLN;
        private System.Windows.Forms.Label lbDataFN;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox btnExit;
        private Bunifu.Framework.UI.BunifuTileButton btnKho;
        private Bunifu.Framework.UI.BunifuTileButton btnEmp;
        private Bunifu.Framework.UI.BunifuTileButton btnCus;
        private Bunifu.Framework.UI.BunifuTileButton btnAna;
        private Bunifu.Framework.UI.BunifuTileButton btnSup;
    }
}