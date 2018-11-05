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
        private int co = -1;
        private int dem = 0;
        Size s = new Size();
        Size sbtnKho = new Size();
        Size sKhachHang = new Size();
        Size sNhaCC = new Size();
        Size sQuanLyNV = new Size();
        Size sThongKe = new Size();

        public fmQuanLy()
        {
            InitializeComponent();
            KhoiTao();
        }

        public void KhoiTao()
        {
            sbtnKho = btnKho.Size;
            sKhachHang = btnCus.Size;
            sNhaCC = btnSup.Size;
            sQuanLyNV = btnEmp.Size;
            sThongKe = btnAna.Size;
        }

        private void tmrButon_Tick(object sender, EventArgs e)
        {
            Size s = new Size();
            
            if (dem < 7)
            {
                if (co == 0)
                {
                    s = btnKho.Size;
                    s.Height++;
                    s.Width++;
                    btnKho.Size = s;
                }
                if (co == 1)
                {
                    s = btnSup.Size;
                    s.Height++;
                    s.Width++;
                    btnSup.Size = s;
                }
                if (co == 2)
                {
                    s = btnEmp.Size;
                    s.Height++;
                    s.Width++;
                    btnEmp.Size = s;
                }
                if (co == 4)
                {
                    s = btnAna.Size;
                    s.Height++;
                    s.Width++;
                    btnAna.Size = s;
                }
                if (co == 5)
                {
                    s = btnCus.Size;
                    s.Height++;
                    s.Width++;
                    btnCus.Size = s;
                }

            }
            else
            {
                btnKho.Size = sbtnKho;
                btnCus.Size = sKhachHang;
                btnSup.Size = sNhaCC;
                btnEmp.Size = sQuanLyNV;
                btnAna.Size = sThongKe;
                tmrButon.Enabled = false;
                dem = 0;
            }
            dem++;
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            tmrButon.Enabled = true;
            co = 0;
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            tmrButon.Enabled = true;
            co = 5;
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            tmrButon.Enabled = true;
            co = 2;
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            tmrButon.Enabled = true;
            co = 1;
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            tmrButon.Enabled = true;
            co = 4;
        }

        private void btnAvar_Click(object sender, EventArgs e)
        {
            
            if (pnProfile.Size == new Size(367, 460))
            {   
                pnProfile.Size = new Size(246, 97);
                return;
            }
            pnProfile.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnProfile.Size = new Size(367, 460);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            fmDangNhap fm = new fmDangNhap();
            fm.Show();
            this.Hide();
        }
    }
}
