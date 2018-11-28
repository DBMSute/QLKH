using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyKhoHang.GiaoDien
{
    public partial class fmThongKe : Form
    {
        private int isLast = 0;
        private int typeSum = 0;
        private bool flagChart = true;
        private bool flagSlide = false;

        public fmThongKe()
        {
            InitializeComponent();
            btnDoanhSo_Click(null, null);
            tmrClock.Start();
        }

        public void displayChartThongKe(DataTable dtVND, DataTable dtUSD, DataTable dtEUR)
        {
            try
            {
                btnError.Size = new Size(910, 440);
                if (flagChart == true)
                {
                    btnError.Visible = false;
                    double max = 0;
                    if (dtUSD.Rows.Count > 0)
                    {
                        max = Convert.ToDouble(dtUSD.Rows[0][1]);
                        foreach (DataRow dr in dtUSD.Rows)
                            if (max < Convert.ToDouble(dr[1])) max = Convert.ToDouble(dr[1]);
                    }
                    if (dtEUR.Rows.Count > 0)
                    {
                        max = Convert.ToDouble(dtEUR.Rows[0][1]);
                        foreach (DataRow dr in dtEUR.Rows)
                            if (max < Convert.ToDouble(dr[1])) max = Convert.ToDouble(dr[1]);
                    }
                    if (dtVND.Rows.Count > 0)
                    {
                        max = Convert.ToDouble(dtVND.Rows[0][1]);
                        foreach (DataRow dr in dtVND.Rows)
                            if (max < Convert.ToDouble(dr[1])) max = Convert.ToDouble(dr[1]);
                    }
                    if (max == 0) throw new Exception();
                    if (chartThongKe.ChartAreas[0].AxisY.Maximum < max) chartThongKe.ChartAreas[0].AxisY.Maximum = (Convert.ToInt32((max.ToString().Substring(0, 1))) + 1) * Math.Pow(10, Convert.ToInt32(max.ToString().Length) - 1);
                    chartThongKe.Series.Clear();
                    chartThongKe.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    chartThongKe.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
                    chartThongKe.Series.Add(new Series());
                    chartThongKe.Series.Add(new Series());
                    chartThongKe.Series.Add(new Series());
                    chartThongKe.Series[0].LegendText = "VND";
                    chartThongKe.Series[1].LegendText = "USD";
                    chartThongKe.Series[2].LegendText = "EUR";
                    chartThongKe.Series[0].ChartType = SeriesChartType.Column;
                    chartThongKe.Series[1].ChartType = SeriesChartType.Column;
                    chartThongKe.Series[2].ChartType = SeriesChartType.Column;
                    chartThongKe.Series[0].IsValueShownAsLabel = true;
                    chartThongKe.Series[1].IsValueShownAsLabel = true;
                    chartThongKe.Series[2].IsValueShownAsLabel = true;
                    foreach (DataRow dr in dtVND.Rows)
                        chartThongKe.Series[0].Points.AddXY(dtVND.Rows[dtVND.Rows.IndexOf(dr)][0].ToString(), dtVND.Rows[dtVND.Rows.IndexOf(dr)][1]);
                    foreach (DataRow dr in dtUSD.Rows)
                        chartThongKe.Series[1].Points.AddXY(dtUSD.Rows[dtUSD.Rows.IndexOf(dr)][0].ToString(), dtUSD.Rows[dtUSD.Rows.IndexOf(dr)][1]);
                    foreach (DataRow dr in dtEUR.Rows)
                        chartThongKe.Series[2].Points.AddXY(dtEUR.Rows[dtEUR.Rows.IndexOf(dr)][0].ToString(), dtEUR.Rows[dtEUR.Rows.IndexOf(dr)][1]);

                }
                else
                {
                    btnError.Visible = false;
                    double max = 0;
                    if (dtUSD.Rows.Count > 0)
                    {
                        max = Convert.ToDouble(dtUSD.Rows[0][1]);
                        foreach (DataRow dr in dtUSD.Rows)
                            if (max < Convert.ToDouble(dr[1])) max = Convert.ToDouble(dr[1]);
                    }

                    if (dtEUR.Rows.Count > 0)
                    {
                        max = Convert.ToDouble(dtEUR.Rows[0][1]);
                        foreach (DataRow dr in dtEUR.Rows)
                            if (max < Convert.ToDouble(dr[1])) max = Convert.ToDouble(dr[1]);
                    }
                    if (dtVND.Rows.Count > 0)
                    {
                        max = Convert.ToDouble(dtVND.Rows[0][1]);
                        foreach (DataRow dr in dtVND.Rows)
                            if (max < Convert.ToDouble(dr[1])) max = Convert.ToDouble(dr[1]);
                    }
                    if (max == 0) throw new Exception();
                    if (chartThongKe.ChartAreas[0].AxisY.Maximum < max) chartThongKe.ChartAreas[0].AxisY.Maximum = (Convert.ToInt32((max.ToString().Substring(0, 1))) + 1) * Math.Pow(10, Convert.ToInt32(max.ToString().Length) - 1);
                    chartThongKe.Series.Clear();
                    chartThongKe.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    chartThongKe.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                    chartThongKe.Series.Add(new Series());
                    chartThongKe.Series.Add(new Series());
                    chartThongKe.Series.Add(new Series());
                    chartThongKe.Series[0].LegendText = "VND";
                    chartThongKe.Series[1].LegendText = "USD";
                    chartThongKe.Series[2].LegendText = "EUR";
                    chartThongKe.Series[0].ChartType = SeriesChartType.Line;
                    chartThongKe.Series[1].ChartType = SeriesChartType.Line;
                    chartThongKe.Series[2].ChartType = SeriesChartType.Line;
                    chartThongKe.Series[0].IsValueShownAsLabel = true;
                    chartThongKe.Series[1].IsValueShownAsLabel = true;
                    chartThongKe.Series[2].IsValueShownAsLabel = true;
                    chartThongKe.Series[0].BorderWidth = 3;
                    chartThongKe.Series[1].BorderWidth = 3;
                    chartThongKe.Series[2].BorderWidth = 3;
                    chartThongKe.Series[0].MarkerStyle = MarkerStyle.Circle;
                    chartThongKe.Series[1].MarkerStyle = MarkerStyle.Circle;
                    chartThongKe.Series[2].MarkerStyle = MarkerStyle.Circle;
                    chartThongKe.Series[0].MarkerSize = 7;
                    chartThongKe.Series[1].MarkerSize = 7;
                    chartThongKe.Series[2].MarkerSize = 7;
                    foreach (DataRow dr in dtVND.Rows)
                        chartThongKe.Series[0].Points.AddXY(dtVND.Rows[dtVND.Rows.IndexOf(dr)][0].ToString(), dtVND.Rows[dtVND.Rows.IndexOf(dr)][1]);
                    foreach (DataRow dr in dtUSD.Rows)
                        chartThongKe.Series[1].Points.AddXY(dtUSD.Rows[dtUSD.Rows.IndexOf(dr)][0].ToString(), dtUSD.Rows[dtUSD.Rows.IndexOf(dr)][1]);
                    foreach (DataRow dr in dtEUR.Rows)
                        chartThongKe.Series[2].Points.AddXY(dtEUR.Rows[dtEUR.Rows.IndexOf(dr)][0].ToString(), dtEUR.Rows[dtEUR.Rows.IndexOf(dr)][1]);
                }
            }
            catch (Exception)
            {
                btnError.Visible = true;
            }
        }

        public void displayChartRank(DataTable dtVND, DataTable dtUSD, DataTable dtEUR)
        {
            btnError.Size = new Size(1040, 440);
            try
            {
                chartRank.ResetAutoValues();
                btnError.Visible = false;
                double max = 0;
                if (dtUSD.Rows.Count > 0)
                {
                    max = Convert.ToDouble(dtUSD.Rows[0][2]);
                    foreach (DataRow dr in dtUSD.Rows)
                        if (max < Convert.ToDouble(dr[2])) max = Convert.ToDouble(dr[2]);
                }
                if (dtEUR.Rows.Count > 0)
                {
                    max = Convert.ToDouble(dtEUR.Rows[0][2]);
                    foreach (DataRow dr in dtEUR.Rows)
                        if (max < Convert.ToDouble(dr[2])) max = Convert.ToDouble(dr[2]);
                }
                if (dtVND.Rows.Count > 0)
                {
                    max = Convert.ToDouble(dtVND.Rows[0][2]);
                    foreach (DataRow dr in dtVND.Rows)
                        if (max < Convert.ToDouble(dr[2])) max = Convert.ToDouble(dr[2]);
                }
                if (max == 0) throw new Exception();
                if (chartRank.ChartAreas[0].AxisX.Maximum < max) chartRank.ChartAreas[0].AxisX.Maximum = (Convert.ToInt32((max.ToString().Substring(0, 1))) + 1) * Math.Pow(10, Convert.ToInt32(max.ToString().Length) - 1);
                chartRank.Series.Clear();
                chartRank.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartRank.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
                chartRank.Series.Add(new Series());
                chartRank.Series.Add(new Series());
                chartRank.Series.Add(new Series());
                chartRank.Series[0].LegendText = "VND";
                chartRank.Series[1].LegendText = "USD";
                chartRank.Series[2].LegendText = "EUR";
                chartRank.Series[0].ChartType = SeriesChartType.Bar;
                chartRank.Series[1].ChartType = SeriesChartType.Bar;
                chartRank.Series[2].ChartType = SeriesChartType.Bar;
                chartRank.Series[0].IsValueShownAsLabel = true;
                chartRank.Series[1].IsValueShownAsLabel = true;
                chartRank.Series[2].IsValueShownAsLabel = true;
                foreach (DataRow dr in dtVND.Rows)
                    chartRank.Series[0].Points.AddXY(dtVND.Rows[dtVND.Rows.IndexOf(dr)][1].ToString(), dtVND.Rows[dtVND.Rows.IndexOf(dr)][2]);
                foreach (DataRow dr in dtUSD.Rows)
                    chartRank.Series[1].Points.AddXY(dtUSD.Rows[dtUSD.Rows.IndexOf(dr)][1].ToString(), dtUSD.Rows[dtUSD.Rows.IndexOf(dr)][2]);
                foreach (DataRow dr in dtEUR.Rows)
                    chartRank.Series[2].Points.AddXY(dtEUR.Rows[dtEUR.Rows.IndexOf(dr)][1].ToString(), dtEUR.Rows[dtEUR.Rows.IndexOf(dr)][2]);
            }
            catch (Exception)
            {
                btnError.Visible = true;
            }
        }

        public void displayChartRank(DataTable dt)
        {
            try
            {
                chartRank.ResetAutoValues();
                btnError.Visible = false;
                double max = 0;
                if (dt.Rows.Count > 0)
                {
                    max = Convert.ToDouble(dt.Rows[0][2]);
                    foreach (DataRow dr in dt.Rows)
                        if (max < Convert.ToDouble(dr[2])) max = Convert.ToDouble(dr[2]);
                }
                if (max == 0) throw new Exception();
                if (chartRank.ChartAreas[0].AxisX.Maximum < max) chartRank.ChartAreas[0].AxisX.Maximum = (Convert.ToInt32((max.ToString().Substring(0, 1))) + 1) * Math.Pow(10, Convert.ToInt32(max.ToString().Length) - 1);
                chartRank.Series.Clear();
                chartRank.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartRank.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
                chartRank.Series.Add(new Series());
                chartRank.Series[0].ChartType = SeriesChartType.Bar;
                chartRank.Series[0].IsValueShownAsLabel = true;

                chartRank.Series[0].IsVisibleInLegend = false;

                foreach (DataRow dr in dt.Rows)
                    chartRank.Series[0].Points.AddXY(dt.Rows[dt.Rows.IndexOf(dr)][1], dt.Rows[dt.Rows.IndexOf(dr)][2].ToString());
            }
            catch (Exception)
            {
                btnError.Visible = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new fmQuanLy().Show();
        }

        private void btnByDate_Click(object sender, EventArgs e)
        {
            if (flagChart == true)
            {
                chartThongKe.ChartAreas[0].AxisY.Maximum = 0;
                displayChartThongKe(BUS.ThongKeBUS.INSTANCE.chartDoanhSo("VND", 0, isLast, typeSum),
                    BUS.ThongKeBUS.INSTANCE.chartDoanhSo("USD", 0, isLast, typeSum),
                    BUS.ThongKeBUS.INSTANCE.chartDoanhSo("EUR", 0, isLast, typeSum));
            }
            else
            {
                chartThongKe.ChartAreas[0].AxisY.Maximum = 0;
                displayChartThongKe(BUS.ThongKeBUS.INSTANCE.chartDoanhThu("VND", 0, isLast, typeSum),
                    BUS.ThongKeBUS.INSTANCE.chartDoanhThu("USD", 0, isLast, typeSum),
                    BUS.ThongKeBUS.INSTANCE.chartDoanhThu("EUR", 0, isLast, typeSum));
            }
        }

        private void btnByHour_Click(object sender, EventArgs e)
        {
            if (flagChart == true)
            {
                chartThongKe.ChartAreas[0].AxisY.Maximum = 0;
                displayChartThongKe(BUS.ThongKeBUS.INSTANCE.chartDoanhSo("VND", 1, isLast, typeSum),
                    BUS.ThongKeBUS.INSTANCE.chartDoanhSo("USD", 1, isLast, typeSum),
                    BUS.ThongKeBUS.INSTANCE.chartDoanhSo("EUR", 1, isLast, typeSum));
            }
            else
            {
                chartThongKe.ChartAreas[0].AxisY.Maximum = 0;
                displayChartThongKe(BUS.ThongKeBUS.INSTANCE.chartDoanhThu("VND", 1, isLast, typeSum),
                    BUS.ThongKeBUS.INSTANCE.chartDoanhThu("USD", 1, isLast, typeSum),
                    BUS.ThongKeBUS.INSTANCE.chartDoanhThu("EUR", 1, isLast, typeSum));
            }
        }

        private void btnByDay_Click(object sender, EventArgs e)
        {
            if (flagChart == true)
            {
                chartThongKe.ChartAreas[0].AxisY.Maximum = 0;
                displayChartThongKe(BUS.ThongKeBUS.INSTANCE.chartDoanhSo("VND", 2, isLast, typeSum),
                    BUS.ThongKeBUS.INSTANCE.chartDoanhSo("USD", 2, isLast, typeSum),
                    BUS.ThongKeBUS.INSTANCE.chartDoanhSo("EUR", 2, isLast, typeSum));
            }
            else
            {
                chartThongKe.ChartAreas[0].AxisY.Maximum = 0;
                displayChartThongKe(BUS.ThongKeBUS.INSTANCE.chartDoanhThu("VND", 2, isLast, typeSum),
                    BUS.ThongKeBUS.INSTANCE.chartDoanhThu("USD", 2, isLast, typeSum),
                    BUS.ThongKeBUS.INSTANCE.chartDoanhThu("EUR", 2, isLast, typeSum));
            }
        }

        private void cbbDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flagSlide == false)
                if (flagChart == true)
                {
                    lbChartName.Text = "Doanh số " + cbbDateType.Text.ToLower() + ":";
                    lbDoanhSo.Location = new Point(lbChartName.Size.Width + 10, lbDoanhSo.Location.Y);
                    isLast = cbbDateType.Text.Contains("qua") || cbbDateType.Text.Contains("trước") ? 1 : 0;
                    typeSum = cbbDateType.Text.Contains("Hôm") ? 1 : 0;
                    lbDoanhSo.Text = BUS.ThongKeBUS.INSTANCE.doanhSo("VND", isLast, typeSum).ToString("C", CultureInfo.CreateSpecificCulture("vn-VN")) +
                        " | " + BUS.ThongKeBUS.INSTANCE.doanhSo("USD", isLast, typeSum).ToString("C", CultureInfo.CreateSpecificCulture("en-US")) +
                        " | " + BUS.ThongKeBUS.INSTANCE.doanhSo("EUR", isLast, typeSum).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                    btnByDate_Click(null, null);
                }
                else
                {
                    lbChartName.Text = "Doanh thu " + cbbDateType.Text.ToLower() + ":";
                    lbDoanhSo.Location = new Point(lbChartName.Size.Width + 10, lbDoanhSo.Location.Y);
                    isLast = cbbDateType.Text.Contains("qua") || cbbDateType.Text.Contains("trước") ? 1 : 0;
                    typeSum = cbbDateType.Text.Contains("Hôm") ? 1 : 0;
                    lbDoanhSo.Text = BUS.ThongKeBUS.INSTANCE.doanhThu("VND", isLast, typeSum).ToString("C", CultureInfo.CreateSpecificCulture("vn-VN")) +
                        " | " + BUS.ThongKeBUS.INSTANCE.doanhThu("USD", isLast, typeSum).ToString("C", CultureInfo.CreateSpecificCulture("en-US")) +
                        " | " + BUS.ThongKeBUS.INSTANCE.doanhThu("EUR", isLast, typeSum).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                    btnByDate_Click(null, null);
                }
            else
            {
                lbChartName.Text = "TOP 10 hàng hóa bán chạy " + cbbDateType.Text.ToLower();
                cbbTypeChart.Location = new Point(lbChartName.Size.Width + 10, cbbTypeChart.Location.Y);
                isLast = cbbDateType.Text.Contains("qua") || cbbDateType.Text.Contains("trước") ? 1 : 0;
                typeSum = cbbDateType.Text.Contains("Hôm") ? 1 : 0;
                cbbTypeChart_SelectedIndexChanged(null, null);

            }
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            flagChart = false;
            cbbDateType_SelectedIndexChanged(null, null);
        }

        private void btnDoanhSo_Click(object sender, EventArgs e)
        {
            flagChart = true;
            cbbDateType_SelectedIndexChanged(null, null);
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void cbbTypeChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeChart.Text.Contains("Theo doanh thu"))
            {
                displayChartRank(BUS.ThongKeBUS.INSTANCE.chartTop10SellDoanhThu("VND", isLast, typeSum), BUS.ThongKeBUS.INSTANCE.chartTop10SellDoanhThu("USD", isLast, typeSum), BUS.ThongKeBUS.INSTANCE.chartTop10SellDoanhThu("EUR", isLast, typeSum));
            }
            else
            {
                displayChartRank(BUS.ThongKeBUS.INSTANCE.chartTop10SellSL(isLast, typeSum));
            }
        }

        private void tmrSlide_Tick(object sender, EventArgs e)
        {
            btnError.Visible = false;
            if (flagSlide == true)
            {

                if (btnDoanhSo.Location.X < 1120)
                {
                    btnDoanhSo.Location = new Point(btnDoanhSo.Location.X + 50, btnDoanhSo.Location.Y);
                    return;
                }
                if (btnDoanhThu.Location.X < 1120)
                {
                    btnDoanhThu.Location = new Point(btnDoanhThu.Location.X + 50, btnDoanhThu.Location.Y);
                    return;
                }
                if (btnByDate.Location.X < 1120)
                {
                    btnByDate.Location = new Point(btnByDate.Location.X + 50, btnByDate.Location.Y);
                    return;
                }
                if (btnByHour.Location.X < 1120)
                {
                    btnByHour.Location = new Point(btnByHour.Location.X + 50, btnByHour.Location.Y);
                    return;
                }
                if (btnByDay.Location.X < 1120)
                {
                    btnByDay.Location = new Point(btnByDay.Location.X + 50, btnByDay.Location.Y);
                    return;
                }
                while (chartThongKe.Location.X != -1090)
                {
                    chartThongKe.Location = new Point(chartThongKe.Location.X - 50, chartThongKe.Location.Y);
                    return;
                }
                if (lbDoanhSo.Location.Y > -32)
                {
                    lbDoanhSo.Location = new Point(lbDoanhSo.Location.X, lbDoanhSo.Location.Y - 10);
                    return;
                }

                while (chartRank.Location.X != 10)
                {
                    chartRank.Location = new Point(chartRank.Location.X + 50, chartRank.Location.Y);
                    return;
                }
                if (cbbTypeChart.Location.Y < 8)
                {
                    lbChartName.Text = "TOP 10 hàng hóa bán chạy " + cbbDateType.Text.ToLower();
                    cbbTypeChart.Location = new Point(lbChartName.Size.Width + 10, cbbTypeChart.Location.Y + 10);
                    return;
                }


                tmrSlide.Stop();
                cbbTypeChart_SelectedIndexChanged(null, null);
                return;

            }
            else
            {
                while (chartRank.Location.X != -1090)
                {
                    chartRank.Location = new Point(chartRank.Location.X - 50, chartRank.Location.Y);
                    return;
                }

                if (cbbTypeChart.Location.Y > -32)
                {
                    cbbTypeChart.Location = new Point(lbChartName.Size.Width + 10, cbbTypeChart.Location.Y - 10);
                    return;
                }
                while (chartThongKe.Location.X != 10)
                {
                    chartThongKe.Location = new Point(chartThongKe.Location.X + 50, chartThongKe.Location.Y);
                    return;
                }
                if (btnDoanhSo.Location.X > 920)
                {
                    btnDoanhSo.Location = new Point(btnDoanhSo.Location.X - 50, btnDoanhSo.Location.Y);
                    return;
                }
                if (btnDoanhThu.Location.X > 920)
                {
                    btnDoanhThu.Location = new Point(btnDoanhThu.Location.X - 50, btnDoanhThu.Location.Y);
                    return;
                }
                if (btnByDate.Location.X > 920)
                {
                    btnByDate.Location = new Point(btnByDate.Location.X - 50, btnByDate.Location.Y);
                    return;
                }
                if (btnByHour.Location.X > 920)
                {
                    btnByHour.Location = new Point(btnByHour.Location.X - 50, btnByHour.Location.Y);
                    return;
                }
                if (btnByDay.Location.X > 920)
                {
                    btnByDay.Location = new Point(btnByDay.Location.X - 50, btnByDay.Location.Y);
                    return;
                }
                if (lbDoanhSo.Location.Y < 8)
                {
                    lbChartName.Text = "Doanh số " + cbbDateType.Text.ToLower() + ":";
                    lbDoanhSo.Location = new Point(lbChartName.Location.X + lbChartName.Size.Width, lbDoanhSo.Location.Y + 10);
                    return;
                }

                tmrSlide.Stop();
                btnDoanhSo_Click(null, null);
                return;

            }
        
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            flagSlide = true;
            tmrSlide.Start();           
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            flagSlide = false;
            tmrSlide.Start();
            
        }
    }
}
