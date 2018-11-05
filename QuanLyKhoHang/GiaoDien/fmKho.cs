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
    public partial class fmKhoHang : Form
    {
        private bool isKho = true;
        public fmKhoHang()
        {
            InitializeComponent();
        }

        //Xem hang hoac kho
        //kho      
        private void btnKho_Click(object sender, EventArgs e)
        {
            btnKho.BackColor = Color.FromArgb(254, 141, 0);
            btnHang.BackColor = Color.FromArgb(157, 87, 2);
            isKho = true;
        }
        //Hang
        private void btnHang_Click(object sender, EventArgs e)
        {
            btnHang.BackColor = Color.FromArgb(254, 141, 0);
            btnKho.BackColor = Color.FromArgb(157, 87, 2);
            isKho = false;
        }
        //

        //Tim Kiem
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                //BUS.KhoBUS.Instace.timKiem(dtgvKho, txtTimKiem.Text);
            }
            catch
            {

            }
        }

        //Them
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        //Xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        //Sua
        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        //In
        private void btnIn_Click(object sender, EventArgs e)
        {

        }
       
        //Reload
        private void btnReload_Click(object sender, EventArgs e)
        {

        }

        //Quyen Truy Cap
        private void btnQuyenTruyCap_Click(object sender, EventArgs e)
        {

        }

        private void fmKhoHang_Load(object sender, EventArgs e)
        {
           //BUS.KhoBUS.Instace.loadData(dtgvKho);
        }

       
    }
}
