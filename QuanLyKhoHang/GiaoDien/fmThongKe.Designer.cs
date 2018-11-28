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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.tmrSlide = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnBot = new System.Windows.Forms.Panel();
            this.btnRank = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTongQuan = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbClock = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbNhaCC = new System.Windows.Forms.Label();
            this.pnMid = new System.Windows.Forms.Panel();
            this.btnError = new Bunifu.Framework.UI.BunifuTileButton();
            this.cbbTypeChart = new System.Windows.Forms.ComboBox();
            this.chartRank = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnByDay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnByHour = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnByDate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbDoanhSo = new System.Windows.Forms.Label();
            this.cbbDateType = new System.Windows.Forms.ComboBox();
            this.lbChartName = new System.Windows.Forms.Label();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDoanhSo = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDoanhThu = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.pnBot.SuspendLayout();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.pnMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.pnTop;
            this.DragControl.Vertical = true;
            // 
            // tmrClock
            // 
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // tmrSlide
            // 
            this.tmrSlide.Interval = 1;
            this.tmrSlide.Tick += new System.EventHandler(this.tmrSlide_Tick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pnBot);
            this.bunifuGradientPanel1.Controls.Add(this.pnTop);
            this.bunifuGradientPanel1.Controls.Add(this.pnMid);
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
            // pnBot
            // 
            this.pnBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnBot.Controls.Add(this.btnRank);
            this.pnBot.Controls.Add(this.btnTongQuan);
            this.pnBot.Location = new System.Drawing.Point(0, 620);
            this.pnBot.Name = "pnBot";
            this.pnBot.Size = new System.Drawing.Size(1068, 100);
            this.pnBot.TabIndex = 4;
            // 
            // btnRank
            // 
            this.btnRank.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRank.color = System.Drawing.Color.SeaGreen;
            this.btnRank.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnRank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRank.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRank.ForeColor = System.Drawing.Color.White;
            this.btnRank.Image = global::QuanLyKhoHang.Properties.Resources.rank;
            this.btnRank.ImagePosition = 5;
            this.btnRank.ImageZoom = 40;
            this.btnRank.LabelPosition = 30;
            this.btnRank.LabelText = "Xếp hạng";
            this.btnRank.Location = new System.Drawing.Point(156, 10);
            this.btnRank.Margin = new System.Windows.Forms.Padding(5);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(130, 85);
            this.btnRank.TabIndex = 104;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTongQuan.color = System.Drawing.Color.SeaGreen;
            this.btnTongQuan.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnTongQuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTongQuan.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongQuan.ForeColor = System.Drawing.Color.White;
            this.btnTongQuan.Image = global::QuanLyKhoHang.Properties.Resources.tongquan;
            this.btnTongQuan.ImagePosition = 5;
            this.btnTongQuan.ImageZoom = 40;
            this.btnTongQuan.LabelPosition = 30;
            this.btnTongQuan.LabelText = "Tổng quan";
            this.btnTongQuan.Location = new System.Drawing.Point(10, 10);
            this.btnTongQuan.Margin = new System.Windows.Forms.Padding(5);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Size = new System.Drawing.Size(130, 85);
            this.btnTongQuan.TabIndex = 103;
            this.btnTongQuan.Click += new System.EventHandler(this.btnTongQuan_Click);
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
            // pnMid
            // 
            this.pnMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnMid.Controls.Add(this.btnError);
            this.pnMid.Controls.Add(this.cbbTypeChart);
            this.pnMid.Controls.Add(this.chartRank);
            this.pnMid.Controls.Add(this.btnByDay);
            this.pnMid.Controls.Add(this.btnByHour);
            this.pnMid.Controls.Add(this.btnByDate);
            this.pnMid.Controls.Add(this.lbDoanhSo);
            this.pnMid.Controls.Add(this.cbbDateType);
            this.pnMid.Controls.Add(this.lbChartName);
            this.pnMid.Controls.Add(this.chartThongKe);
            this.pnMid.Controls.Add(this.btnDoanhSo);
            this.pnMid.Controls.Add(this.btnDoanhThu);
            this.pnMid.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMid.Location = new System.Drawing.Point(10, 110);
            this.pnMid.Name = "pnMid";
            this.pnMid.Size = new System.Drawing.Size(1060, 500);
            this.pnMid.TabIndex = 5;
            // 
            // btnError
            // 
            this.btnError.BackColor = System.Drawing.Color.SeaGreen;
            this.btnError.color = System.Drawing.Color.SeaGreen;
            this.btnError.colorActive = System.Drawing.Color.SeaGreen;
            this.btnError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnError.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnError.ForeColor = System.Drawing.Color.White;
            this.btnError.Image = global::QuanLyKhoHang.Properties.Resources.error;
            this.btnError.ImagePosition = 100;
            this.btnError.ImageZoom = 15;
            this.btnError.LabelPosition = 175;
            this.btnError.LabelText = "Không có dữ liệu";
            this.btnError.Location = new System.Drawing.Point(10, 50);
            this.btnError.Margin = new System.Windows.Forms.Padding(6);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(910, 440);
            this.btnError.TabIndex = 102;
            this.btnError.Visible = false;
            // 
            // cbbTypeChart
            // 
            this.cbbTypeChart.BackColor = System.Drawing.Color.White;
            this.cbbTypeChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbTypeChart.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeChart.ForeColor = System.Drawing.Color.SeaGreen;
            this.cbbTypeChart.FormattingEnabled = true;
            this.cbbTypeChart.Items.AddRange(new object[] {
            "Theo doanh thu",
            "Theo số lượng"});
            this.cbbTypeChart.Location = new System.Drawing.Point(140, -32);
            this.cbbTypeChart.Name = "cbbTypeChart";
            this.cbbTypeChart.Size = new System.Drawing.Size(167, 32);
            this.cbbTypeChart.TabIndex = 103;
            this.cbbTypeChart.Text = "Theo doanh thu";
            this.cbbTypeChart.SelectedIndexChanged += new System.EventHandler(this.cbbTypeChart_SelectedIndexChanged);
            // 
            // chartRank
            // 
            this.chartRank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.chartRank.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartRank.Legends.Add(legend1);
            this.chartRank.Location = new System.Drawing.Point(-1090, 50);
            this.chartRank.Name = "chartRank";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRank.Series.Add(series1);
            this.chartRank.Size = new System.Drawing.Size(1040, 440);
            this.chartRank.TabIndex = 0;
            this.chartRank.Text = "Doanh số";
            // 
            // btnByDay
            // 
            this.btnByDay.Activecolor = System.Drawing.Color.White;
            this.btnByDay.BackColor = System.Drawing.Color.White;
            this.btnByDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnByDay.BorderRadius = 0;
            this.btnByDay.ButtonText = "Theo thứ";
            this.btnByDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnByDay.DisabledColor = System.Drawing.Color.Gray;
            this.btnByDay.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByDay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnByDay.Iconimage = null;
            this.btnByDay.Iconimage_right = null;
            this.btnByDay.Iconimage_right_Selected = null;
            this.btnByDay.Iconimage_Selected = null;
            this.btnByDay.IconMarginLeft = 0;
            this.btnByDay.IconMarginRight = 0;
            this.btnByDay.IconRightVisible = true;
            this.btnByDay.IconRightZoom = 0D;
            this.btnByDay.IconVisible = true;
            this.btnByDay.IconZoom = 90D;
            this.btnByDay.IsTab = false;
            this.btnByDay.Location = new System.Drawing.Point(920, 420);
            this.btnByDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnByDay.Name = "btnByDay";
            this.btnByDay.Normalcolor = System.Drawing.Color.White;
            this.btnByDay.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btnByDay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnByDay.selected = false;
            this.btnByDay.Size = new System.Drawing.Size(130, 70);
            this.btnByDay.TabIndex = 19;
            this.btnByDay.Text = "Theo thứ";
            this.btnByDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnByDay.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnByDay.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByDay.Click += new System.EventHandler(this.btnByDay_Click);
            // 
            // btnByHour
            // 
            this.btnByHour.Activecolor = System.Drawing.Color.White;
            this.btnByHour.BackColor = System.Drawing.Color.White;
            this.btnByHour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnByHour.BorderRadius = 0;
            this.btnByHour.ButtonText = "Theo giờ";
            this.btnByHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnByHour.DisabledColor = System.Drawing.Color.Gray;
            this.btnByHour.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByHour.Iconcolor = System.Drawing.Color.Transparent;
            this.btnByHour.Iconimage = null;
            this.btnByHour.Iconimage_right = null;
            this.btnByHour.Iconimage_right_Selected = null;
            this.btnByHour.Iconimage_Selected = null;
            this.btnByHour.IconMarginLeft = 0;
            this.btnByHour.IconMarginRight = 0;
            this.btnByHour.IconRightVisible = true;
            this.btnByHour.IconRightZoom = 0D;
            this.btnByHour.IconVisible = true;
            this.btnByHour.IconZoom = 90D;
            this.btnByHour.IsTab = false;
            this.btnByHour.Location = new System.Drawing.Point(920, 342);
            this.btnByHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnByHour.Name = "btnByHour";
            this.btnByHour.Normalcolor = System.Drawing.Color.White;
            this.btnByHour.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btnByHour.OnHoverTextColor = System.Drawing.Color.White;
            this.btnByHour.selected = false;
            this.btnByHour.Size = new System.Drawing.Size(130, 70);
            this.btnByHour.TabIndex = 18;
            this.btnByHour.Text = "Theo giờ";
            this.btnByHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnByHour.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnByHour.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByHour.Click += new System.EventHandler(this.btnByHour_Click);
            // 
            // btnByDate
            // 
            this.btnByDate.Activecolor = System.Drawing.Color.White;
            this.btnByDate.BackColor = System.Drawing.Color.White;
            this.btnByDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnByDate.BorderRadius = 0;
            this.btnByDate.ButtonText = "Theo ngày";
            this.btnByDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnByDate.DisabledColor = System.Drawing.Color.Gray;
            this.btnByDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByDate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnByDate.Iconimage = null;
            this.btnByDate.Iconimage_right = null;
            this.btnByDate.Iconimage_right_Selected = null;
            this.btnByDate.Iconimage_Selected = null;
            this.btnByDate.IconMarginLeft = 0;
            this.btnByDate.IconMarginRight = 0;
            this.btnByDate.IconRightVisible = true;
            this.btnByDate.IconRightZoom = 0D;
            this.btnByDate.IconVisible = true;
            this.btnByDate.IconZoom = 90D;
            this.btnByDate.IsTab = false;
            this.btnByDate.Location = new System.Drawing.Point(920, 264);
            this.btnByDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnByDate.Name = "btnByDate";
            this.btnByDate.Normalcolor = System.Drawing.Color.White;
            this.btnByDate.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btnByDate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnByDate.selected = false;
            this.btnByDate.Size = new System.Drawing.Size(130, 70);
            this.btnByDate.TabIndex = 17;
            this.btnByDate.Text = "Theo ngày";
            this.btnByDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnByDate.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnByDate.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByDate.Click += new System.EventHandler(this.btnByDate_Click);
            // 
            // lbDoanhSo
            // 
            this.lbDoanhSo.AutoSize = true;
            this.lbDoanhSo.BackColor = System.Drawing.Color.Transparent;
            this.lbDoanhSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDoanhSo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanhSo.ForeColor = System.Drawing.Color.Gold;
            this.lbDoanhSo.Location = new System.Drawing.Point(140, 8);
            this.lbDoanhSo.Name = "lbDoanhSo";
            this.lbDoanhSo.Size = new System.Drawing.Size(63, 32);
            this.lbDoanhSo.TabIndex = 16;
            this.lbDoanhSo.Text = "Null";
            // 
            // cbbDateType
            // 
            this.cbbDateType.BackColor = System.Drawing.Color.White;
            this.cbbDateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbDateType.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDateType.ForeColor = System.Drawing.Color.SeaGreen;
            this.cbbDateType.FormattingEnabled = true;
            this.cbbDateType.Items.AddRange(new object[] {
            "Hôm nay",
            "Hôm qua",
            "Tháng này",
            "Tháng trước"});
            this.cbbDateType.Location = new System.Drawing.Point(920, 9);
            this.cbbDateType.Name = "cbbDateType";
            this.cbbDateType.Size = new System.Drawing.Size(130, 32);
            this.cbbDateType.TabIndex = 15;
            this.cbbDateType.Text = "Hôm nay";
            this.cbbDateType.SelectedIndexChanged += new System.EventHandler(this.cbbDateType_SelectedIndexChanged);
            // 
            // lbChartName
            // 
            this.lbChartName.AutoSize = true;
            this.lbChartName.BackColor = System.Drawing.Color.Transparent;
            this.lbChartName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbChartName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChartName.ForeColor = System.Drawing.Color.White;
            this.lbChartName.Location = new System.Drawing.Point(10, 10);
            this.lbChartName.Name = "lbChartName";
            this.lbChartName.Size = new System.Drawing.Size(124, 30);
            this.lbChartName.TabIndex = 14;
            this.lbChartName.Text = "Doanh số";
            // 
            // chartThongKe
            // 
            this.chartThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea2.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend2);
            this.chartThongKe.Location = new System.Drawing.Point(10, 50);
            this.chartThongKe.Name = "chartThongKe";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartThongKe.Series.Add(series2);
            this.chartThongKe.Size = new System.Drawing.Size(910, 440);
            this.chartThongKe.TabIndex = 0;
            this.chartThongKe.Text = "Doanh số";
            // 
            // btnDoanhSo
            // 
            this.btnDoanhSo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDoanhSo.color = System.Drawing.Color.SeaGreen;
            this.btnDoanhSo.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnDoanhSo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoanhSo.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhSo.ForeColor = System.Drawing.Color.White;
            this.btnDoanhSo.Image = global::QuanLyKhoHang.Properties.Resources.cash;
            this.btnDoanhSo.ImagePosition = 5;
            this.btnDoanhSo.ImageZoom = 40;
            this.btnDoanhSo.LabelPosition = 30;
            this.btnDoanhSo.LabelText = "Doanh số";
            this.btnDoanhSo.Location = new System.Drawing.Point(920, 50);
            this.btnDoanhSo.Margin = new System.Windows.Forms.Padding(5);
            this.btnDoanhSo.Name = "btnDoanhSo";
            this.btnDoanhSo.Size = new System.Drawing.Size(130, 85);
            this.btnDoanhSo.TabIndex = 7;
            this.btnDoanhSo.Click += new System.EventHandler(this.btnDoanhSo_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDoanhThu.color = System.Drawing.Color.SeaGreen;
            this.btnDoanhThu.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoanhThu.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnDoanhThu.Image = global::QuanLyKhoHang.Properties.Resources.revenue;
            this.btnDoanhThu.ImagePosition = 5;
            this.btnDoanhThu.ImageZoom = 40;
            this.btnDoanhThu.LabelPosition = 30;
            this.btnDoanhThu.LabelText = "Doanh thu";
            this.btnDoanhThu.Location = new System.Drawing.Point(920, 145);
            this.btnDoanhThu.Margin = new System.Windows.Forms.Padding(5);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(130, 85);
            this.btnDoanhThu.TabIndex = 8;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
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
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.pnBot.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.pnMid.ResumeLayout(false);
            this.pnMid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.Panel pnBot;
        private Bunifu.Framework.UI.BunifuTileButton btnDoanhSo;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbClock;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Label lbNhaCC;
        private System.Windows.Forms.Timer tmrClock;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbChartName;
        private Bunifu.Framework.UI.BunifuFlatButton btnByDate;
        private System.Windows.Forms.Label lbDoanhSo;
        private System.Windows.Forms.ComboBox cbbDateType;
        private Bunifu.Framework.UI.BunifuFlatButton btnByDay;
        private Bunifu.Framework.UI.BunifuFlatButton btnByHour;
        private Bunifu.Framework.UI.BunifuTileButton btnError;
        private Bunifu.Framework.UI.BunifuTileButton btnDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRank;
        private System.Windows.Forms.ComboBox cbbTypeChart;
        private Bunifu.Framework.UI.BunifuTileButton btnTongQuan;
        private Bunifu.Framework.UI.BunifuTileButton btnRank;
        private System.Windows.Forms.Timer tmrSlide;
    }
}