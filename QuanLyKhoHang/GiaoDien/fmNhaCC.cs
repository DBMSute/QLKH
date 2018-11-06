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
    public partial class fmNhaCC : Form
    {
        public fmNhaCC()
        {
            InitializeComponent();
            BUS.NhaCungCapBUS.Instance.loadData(dtgvSup);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BUS.NhaCungCapBUS.Instance.Them(dtgvSup);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BUS.NhaCungCapBUS.Instance.LuuThem(dtgvSup);
        }
    }
}
