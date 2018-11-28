namespace QuanLyKhoHang.GiaoDien
{
    partial class fmScanIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmScanIP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNof = new System.Windows.Forms.RichTextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbSubnet = new System.Windows.Forms.MaskedTextBox();
            this.mtbIP = new System.Windows.Forms.MaskedTextBox();
            this.switchAuto = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lbNof);
            this.panel1.Location = new System.Drawing.Point(12, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 200);
            this.panel1.TabIndex = 0;
            // 
            // lbNof
            // 
            this.lbNof.BackColor = System.Drawing.Color.Black;
            this.lbNof.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbNof.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNof.ForeColor = System.Drawing.Color.White;
            this.lbNof.Location = new System.Drawing.Point(12, 12);
            this.lbNof.Name = "lbNof";
            this.lbNof.ReadOnly = true;
            this.lbNof.Size = new System.Drawing.Size(337, 177);
            this.lbNof.TabIndex = 4;
            this.lbNof.Text = "Chưa có danh sách IP...";
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.Location = new System.Drawing.Point(254, 106);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(118, 38);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "Lấy DS IP";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 40);
            this.label1.TabIndex = 23;
            this.label1.Text = "IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 40);
            this.label2.TabIndex = 25;
            this.label2.Text = "Subnet mask";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbSubnet
            // 
            this.mtbSubnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbSubnet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbSubnet.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbSubnet.ForeColor = System.Drawing.Color.White;
            this.mtbSubnet.Location = new System.Drawing.Point(165, 71);
            this.mtbSubnet.Mask = "###.###.###.###";
            this.mtbSubnet.Name = "mtbSubnet";
            this.mtbSubnet.ReadOnly = true;
            this.mtbSubnet.Size = new System.Drawing.Size(207, 25);
            this.mtbSubnet.TabIndex = 26;
            this.mtbSubnet.Text = "2552552550";
            // 
            // mtbIP
            // 
            this.mtbIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbIP.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbIP.ForeColor = System.Drawing.Color.White;
            this.mtbIP.Location = new System.Drawing.Point(165, 19);
            this.mtbIP.Mask = "###.###.###.###";
            this.mtbIP.Name = "mtbIP";
            this.mtbIP.Size = new System.Drawing.Size(207, 25);
            this.mtbIP.TabIndex = 24;
            this.mtbIP.Text = "1921680  1";
            this.mtbIP.Leave += new System.EventHandler(this.mtbIP_Leave);
            // 
            // switchAuto
            // 
            this.switchAuto.BackColor = System.Drawing.Color.Transparent;
            this.switchAuto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchAuto.BackgroundImage")));
            this.switchAuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchAuto.Location = new System.Drawing.Point(213, 124);
            this.switchAuto.Name = "switchAuto";
            this.switchAuto.OffColor = System.Drawing.Color.Gray;
            this.switchAuto.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.switchAuto.Size = new System.Drawing.Size(35, 20);
            this.switchAuto.TabIndex = 27;
            this.switchAuto.Value = false;
            this.switchAuto.OnValueChange += new System.EventHandler(this.switchAuto_OnValueChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(210, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Auto";
            // 
            // btnTestConn
            // 
            this.btnTestConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTestConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestConn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConn.ForeColor = System.Drawing.Color.White;
            this.btnTestConn.Location = new System.Drawing.Point(12, 106);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(118, 38);
            this.btnTestConn.TabIndex = 29;
            this.btnTestConn.Text = "Kết nối thử";
            this.btnTestConn.UseVisualStyleBackColor = false;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // fmScanIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnTestConn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.switchAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbSubnet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbIP);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmScanIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm IP server";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.RichTextBox lbNof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbSubnet;
        private System.Windows.Forms.MaskedTextBox mtbIP;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchAuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTestConn;
    }
}