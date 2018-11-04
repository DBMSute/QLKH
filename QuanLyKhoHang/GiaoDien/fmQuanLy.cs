using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.GiaoDien
{
    public partial class fmQuanLy : Form
    {
        //Cap Phat
        private  int co = -1;
        private  int dem = 0;
        Size sKho = new Size();
        Size sKhachHang = new Size();
        Size sNhaCC = new Size();
        Size sQuanLyNV = new Size();
        Size sThongKe = new Size();
        Size s = new Size();
        
        public fmQuanLy()
        {
            InitializeComponent();
            KhoiTao();
        }

        //Luu Kich co cu
        void KhoiTao()
        {
            sKho = pcbKho.Size;
            sKhachHang = pcbKhachHang.Size;
            sNhaCC = pcbNhaCC.Size;
            sQuanLyNV = pcbQuanLyNhanVien.Size;
            sThongKe = pcbThongKe.Size;
        }

        //Timer
        private void tm1_Tick(object sender, EventArgs e)
        {
            if (dem < 7)
            {
                if (co == 0)
                {
                    s = pcbKho.Size;
                    s.Height++;
                    s.Width++;
                    pcbKho.Size = s;
                }
                if (co == 1)
                {
                    s = pcbNhaCC.Size;
                    s.Height++;
                    s.Width++;
                    pcbNhaCC.Size = s;
                }
                if (co == 2)
                {
                    s = pcbQuanLyNhanVien.Size;
                    s.Height++;
                    s.Width++;
                    pcbQuanLyNhanVien.Size = s;
                }
                if (co == 4)
                {
                    s = pcbThongKe.Size;
                    s.Height++;
                    s.Width++;
                    pcbThongKe.Size = s;
                }
                if (co == 5)
                {
                    s = pcbKhachHang.Size;
                    s.Height++;
                    s.Width++;
                    pcbKhachHang.Size = s;
                }

            }
            else
            {
                pcbKho.Size = sKho;
                pcbKhachHang.Size = sKhachHang;
                pcbNhaCC.Size = sNhaCC;
                pcbQuanLyNhanVien.Size = sQuanLyNV;
                pcbThongKe.Size = sThongKe;
                tm1.Enabled = false;
                dem = 0;
            }
            dem++;
        }



        //Kho
        private void pcbKho_Click(object sender, EventArgs e)
        {
            tm1.Enabled = true;
            co = 0;
        }
        private void lbKhoHang_Click(object sender, EventArgs e)
        {
            tm1.Enabled = true;
            co = 0;
        }
        private void lbKhoHang_MouseHover(object sender, EventArgs e)
        {
            pcbKho.BackColor = Color.FromArgb(230, 125, 86);
            lbKhoHang.BackColor = Color.FromArgb(230, 125, 86);
        }
        private void pcbKho_MouseHover(object sender, EventArgs e)
        {
            pcbKho.BackColor = Color.FromArgb(230, 125, 86);
            lbKhoHang.BackColor = Color.FromArgb(230, 125, 86);
        }     
        private void pcbKho_MouseLeave(object sender, EventArgs e)
        {
            pcbKho.BackColor = Color.FromArgb(216, 59, 1);
            lbKhoHang.BackColor = Color.FromArgb(216, 59, 1);
        }




        //NCC
        private void pcbNhaCC_Click(object sender, EventArgs e)
        {
            tm1.Enabled = true;
            co = 1;
        }
        private void lbNCC_Click(object sender, EventArgs e)
        {
            tm1.Enabled = true;
            co = 1;
        }
        private void pcbNhaCC_MouseHover(object sender, EventArgs e)
        {
            pcbNhaCC.BackColor = Color.FromArgb(8, 190, 242);
            lbNCC.BackColor = Color.FromArgb(8, 190, 242);
        }
        private void lbNCC_MouseHover(object sender, EventArgs e)
        {
            pcbNhaCC.BackColor = Color.FromArgb(8, 190, 242);
            lbNCC.BackColor = Color.FromArgb(8, 190, 242);
        }
        private void pcbNhaCC_MouseLeave(object sender, EventArgs e)
        {
            pcbNhaCC.BackColor = Color.FromArgb(11, 126, 217);
            lbNCC.BackColor = Color.FromArgb(11, 126, 217);
        }     
       



        //QuanLy
        private void pcbQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            tm1.Enabled = true;
            co = 2;
        }
        private void lbQuanLyNV_Click(object sender, EventArgs e)
        {
            tm1.Enabled = true;
            co = 2;
        }
        private void pcbQuanLyNhanVien_MouseHover(object sender, EventArgs e)
        {
            pcbQuanLyNhanVien.BackColor = Color.FromArgb(237, 132, 14);
            lbQuanLyNV.BackColor = Color.FromArgb(237, 132, 14);
        }
        private void lbQuanLyNV_MouseHover(object sender, EventArgs e)
        {
            pcbQuanLyNhanVien.BackColor = Color.FromArgb(237, 132, 14);
            lbQuanLyNV.BackColor = Color.FromArgb(237, 132, 14);
        }
        private void pcbQuanLyNhanVien_MouseLeave(object sender, EventArgs e)
        {
            pcbQuanLyNhanVien.BackColor = Color.FromArgb(255, 185, 0);
            lbQuanLyNV.BackColor = Color.FromArgb(255, 185, 0);
        }     
      



        //Thong Ke
        private void pcbThongKe_Click(object sender, EventArgs e)
        {
            tm1.Enabled = true;
            co = 4;
        }
        private void lbThongKe_Click(object sender, EventArgs e)
        {
            tm1.Enabled = true;
            co = 4;
        }
        private void pcbThongKe_MouseHover(object sender, EventArgs e)
        {
            pcbThongKe.BackColor = Color.FromArgb(120,82, 164);
            lbThongKe.BackColor = Color.FromArgb(120, 82, 164);
        }      
        private void lbThongKe_MouseHover(object sender, EventArgs e)
        {
            pcbThongKe.BackColor = Color.FromArgb(120, 82, 164);
            lbThongKe.BackColor =Color.FromArgb(120, 82, 164);
        }
        private void pcbThongKe_MouseLeave(object sender, EventArgs e)
        {
            pcbThongKe.BackColor = Color.FromArgb(92, 45, 145);
            lbThongKe.BackColor = Color.FromArgb(92, 45, 145);
        }   



        //Khach Hang
        private void pcbKhachHang_Click(object sender, EventArgs e)
        {
            tm1.Enabled = true;
            co = 5;
        }
        private void lbKhachHang_Click(object sender, EventArgs e)
        {
            tm1.Enabled = true;
            co = 5;
        }
        private void pcbKhachHang_MouseHover(object sender, EventArgs e)
        {
            pcbKhachHang.BackColor = Color.FromArgb(120, 82, 164);
            lbKhachHang.BackColor = Color.FromArgb(120, 82, 164);
        }
        private void lbKhachHang_MouseHover(object sender, EventArgs e)
        {
            pcbKhachHang.BackColor = Color.FromArgb(120, 82, 164);
            lbKhachHang.BackColor = Color.FromArgb(120, 82, 164);
        }
        private void pcbKhachHang_MouseLeave(object sender, EventArgs e)
        {
            pcbKhachHang.BackColor = Color.FromArgb(94, 51, 141);
            lbKhachHang.BackColor = Color.FromArgb(94, 51, 141);
        }

        
      
    
        

        
    }
}
