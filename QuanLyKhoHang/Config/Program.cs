using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuanLyKhoHang.GiaoDien.fmDangNhap());
            //Application.Run(new QuanLyKhoHang.GiaoDien.fmNCC_TK_KH());
        }
    }
}
