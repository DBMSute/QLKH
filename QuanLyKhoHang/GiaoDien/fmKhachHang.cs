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
    public partial class fmKhachHang : Form
    {
        public fmKhachHang()
        {
            InitializeComponent();
            BUS.KhachHangBUS.Instance.loadData(dtgvCus);
        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BUS.KhachHangBUS.Instance.Them(dtgvCus);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BUS.KhachHangBUS.Instance.LuuThem(dtgvCus);
            BUS.KhachHangBUS.Instance.loadData(dtgvCus);
        }
    }
}
