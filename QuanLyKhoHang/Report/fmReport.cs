using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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

namespace QuanLyKhoHang.Report
{
    public partial class fmReport : Form
    {

        public fmReport(DataTable dt, string title, string author)
        {
            InitializeComponent();
            if (title.Contains("KHO HÀNG"))
            {
                crKho rp = new crKho();
                rp.SetDataSource(dt);
                rp.SetParameterValue("ReportTitle", title);
                rp.SetParameterValue("PrintDate", "Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy"));
                rp.SetParameterValue("Author", "Người in: " + author);
                crvReport.ReportSource = rp;
                return;
            }
            else if (title.Contains("SẢN PHẨM"))
            {
                crSanPham rp = new crSanPham();
                rp.SetDataSource(dt);
                rp.SetParameterValue("ReportTitle", title);
                rp.SetParameterValue("PrintDate", "Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy"));
                rp.SetParameterValue("Author", "Người in: " + author);
                crvReport.ReportSource = rp;
                return;
            }
            else if (title.Contains("NHÀ CUNG CẤP"))
            {
                crNCC rp = new crNCC();
                rp.SetDataSource(dt);
                rp.SetParameterValue("ReportTitle", title);
                rp.SetParameterValue("PrintDate", "Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy"));
                rp.SetParameterValue("Author", "Người in: " + author);
                crvReport.ReportSource = rp;
                return;
            }
            else if (title.Contains("KHÁCH HÀNG"))
            {
                crKhachHang rp = new crKhachHang();
                rp.SetDataSource(dt);
                rp.SetParameterValue("ReportTitle", title);
                rp.SetParameterValue("PrintDate", "Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy"));
                rp.SetParameterValue("Author", "Người in: " + author);
                crvReport.ReportSource = rp;
                return;
            }
            else if (title.Contains("LOẠI"))
            {
                crLoaiSanPham rp = new crLoaiSanPham();
                rp.SetDataSource(dt);
                rp.SetParameterValue("ReportTitle", title);
                rp.SetParameterValue("PrintDate", "Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy"));
                rp.SetParameterValue("Author", "Người in: " + author);
                crvReport.ReportSource = rp;
                return;
            }
            else if (title.Contains("SÁCH PHIẾU NHẬP"))
            {
                crPhieuNhapXuat rp = new crPhieuNhapXuat();
                rp.SetDataSource(dt);
                rp.SetParameterValue("ReportTitle", title);
                rp.SetParameterValue("PrintDate", "Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy"));
                rp.SetParameterValue("Author", "Người in: " + author);
                crvReport.ReportSource = rp;
                return;
            }
            else if (title.Contains("PN"))
            {
                crChiTietPhieuNhap rp = new crChiTietPhieuNhap();
                rp.SetDataSource(dt);
                rp.SetParameterValue("ReportTitle", title);
                int tongvnd = dt.Rows.Cast<DataRow>()
                .Where(dv => dv[6].ToString().Contains("VND"))
                .Sum(s => Convert.ToInt32(s[6].ToString().Remove(s[6].ToString().Length-3,3).Trim()));
                int tongusd = dt.Rows.Cast<DataRow>()
                    .Where(dv => dv[6].ToString().Contains("USD"))
                    .Sum(s => Convert.ToInt32(s[6].ToString().Remove(s[6].ToString().Length-3, 3).Trim()));
                int tongeur = dt.Rows.Cast<DataRow>()
                    .Where(dv => dv[6].ToString().Contains("EUR"))
                    .Sum(s => Convert.ToInt32(s[6].ToString().Remove(s[6].ToString().Length-3, 3).Trim()));
                rp.SetParameterValue("Sum", tongvnd.ToString("C", CultureInfo.CreateSpecificCulture("vi-VN")) + " | " + tongusd.ToString("C", CultureInfo.CreateSpecificCulture("en-US")) + " | " + tongeur.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR")));
                rp.SetParameterValue("CreateDate", "Ngày tạo phiếu: " +QuanLyKhoHang.GiaoDien.fmPhieuNhap.tempCD);
                rp.SetParameterValue("PrintDate", "Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy"));
                rp.SetParameterValue("Author", "Người in: " + author);
                crvReport.ReportSource = rp;
                return;
            }
            else if (title.Contains("SÁCH PHIẾU XUẤT"))
            {
                crPhieuNhapXuat rp = new crPhieuNhapXuat();
                rp.SetDataSource(dt);
                rp.SetParameterValue("ReportTitle", title);
                rp.SetParameterValue("PrintDate", "Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy"));
                rp.SetParameterValue("Author", "Người in: " + author);
                crvReport.ReportSource = rp;
                return;
            }
            else if (title.Contains("PX"))
            {
                crChiTietPhieuXuat rp = new crChiTietPhieuXuat();
                rp.SetDataSource(dt);
                rp.SetParameterValue("ReportTitle", title);
                int tongvnd = dt.Rows.Cast<DataRow>()
                .Where(dv => dv[6].ToString().Contains("VND"))
                .Sum(s => Convert.ToInt32(s[6].ToString().Remove(s[6].ToString().Length - 3, 3).Trim()));
                int tongusd = dt.Rows.Cast<DataRow>()
                    .Where(dv => dv[6].ToString().Contains("USD"))
                    .Sum(s => Convert.ToInt32(s[6].ToString().Remove(s[6].ToString().Length - 3, 3).Trim()));
                int tongeur = dt.Rows.Cast<DataRow>()
                    .Where(dv => dv[6].ToString().Contains("EUR"))
                    .Sum(s => Convert.ToInt32(s[6].ToString().Remove(s[6].ToString().Length - 3, 3).Trim()));
                rp.SetParameterValue("Sum", tongvnd.ToString("C", CultureInfo.CreateSpecificCulture("vi-VN")) + " | " + tongusd.ToString("C", CultureInfo.CreateSpecificCulture("en-US")) + " | " + tongeur.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR")));
                rp.SetParameterValue("CreateDate", "Ngày tạo phiếu: " + QuanLyKhoHang.GiaoDien.fmPhieuXuat.tempCD);
                rp.SetParameterValue("PrintDate", "Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy"));
                rp.SetParameterValue("Author", "Người in: " + author);
                crvReport.ReportSource = rp;
                return;
            }

            crvReport.Refresh();
        }
    }
}
