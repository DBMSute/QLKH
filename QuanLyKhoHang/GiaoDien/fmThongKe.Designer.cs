namespace QuanLyKhoHang.GiaoDien
{
    partial class fmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmThongKe));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnMidL = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.switchStatus = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.tbEmpSearch = new System.Windows.Forms.TextBox();
            this.btnEmpChangePW = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEmpSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEmpAdd = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEmpDel = new Bunifu.Framework.UI.BunifuTileButton();
            this.openAVT = new System.Windows.Forms.OpenFileDialog();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbClock = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbNhaCC = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbChartName = new System.Windows.Forms.Label();
            this.pnMidL.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMidL
            // 
            this.pnMidL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnMidL.Controls.Add(this.lbChartName);
            this.pnMidL.Controls.Add(this.chartDoanhThu);
            this.pnMidL.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMidL.Location = new System.Drawing.Point(10, 110);
            this.pnMidL.Name = "pnMidL";
            this.pnMidL.Size = new System.Drawing.Size(1060, 500);
            this.pnMidL.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.switchStatus);
            this.panel2.Controls.Add(this.tbEmpSearch);
            this.panel2.Controls.Add(this.btnEmpChangePW);
            this.panel2.Controls.Add(this.btnEmpSave);
            this.panel2.Controls.Add(this.btnEmpAdd);
            this.panel2.Controls.Add(this.btnEmpDel);
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 100);
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
            // 
            // btnEmpChangePW
            // 
            this.btnEmpChangePW.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEmpChangePW.color = System.Drawing.Color.SeaGreen;
            this.btnEmpChangePW.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnEmpChangePW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpChangePW.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.btnEmpChangePW.ForeColor = System.Drawing.Color.White;
            this.btnEmpChangePW.Image = global::QuanLyKhoHang.Properties.Resources.password;
            this.btnEmpChangePW.ImagePosition = 10;
            this.btnEmpChangePW.ImageZoom = 50;
            this.btnEmpChangePW.LabelPosition = 30;
            this.btnEmpChangePW.LabelText = "Đổi MK";
            this.btnEmpChangePW.Location = new System.Drawing.Point(656, 10);
            this.btnEmpChangePW.Margin = new System.Windows.Forms.Padding(5);
            this.btnEmpChangePW.Name = "btnEmpChangePW";
            this.btnEmpChangePW.Size = new System.Drawing.Size(85, 85);
            this.btnEmpChangePW.TabIndex = 9;
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
            // 
            // openAVT
            // 
            this.openAVT.FileName = "openAVT";
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
            this.lbNhaCC.Size = new System.Drawing.Size(387, 94);
            this.lbNhaCC.TabIndex = 0;
            this.lbNhaCC.Text = "Thống Kê";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.bunifuGradientPanel1.TabIndex = 9;
            // 
            // chartDoanhThu
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend2);
            this.chartDoanhThu.Location = new System.Drawing.Point(10, 50);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDoanhThu.Series.Add(series2);
            this.chartDoanhThu.Size = new System.Drawing.Size(1040, 440);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "chart1";
            // 
            // lbChartName
            // 
            this.lbChartName.AutoSize = true;
            this.lbChartName.BackColor = System.Drawing.Color.Transparent;
            this.lbChartName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbChartName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChartName.ForeColor = System.Drawing.Color.White;
            this.lbChartName.Location = new System.Drawing.Point(274, 14);
            this.lbChartName.Name = "lbChartName";
            this.lbChartName.Size = new System.Drawing.Size(138, 30);
            this.lbChartName.TabIndex = 14;
            this.lbChartName.Text = "Doanh thu";
            // 
            // fmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmThongKe";
            this.pnMidL.ResumeLayout(false);
            this.pnMidL.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMidL;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchStatus;
        private System.Windows.Forms.TextBox tbEmpSearch;
        private Bunifu.Framework.UI.BunifuTileButton btnEmpChangePW;
        private Bunifu.Framework.UI.BunifuTileButton btnEmpSave;
        private Bunifu.Framework.UI.BunifuTileButton btnEmpAdd;
        private Bunifu.Framework.UI.BunifuTileButton btnEmpDel;
        private System.Windows.Forms.OpenFileDialog openAVT;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbClock;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Label lbNhaCC;
        private System.Windows.Forms.Timer tmrClock;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbChartName;
    }
}