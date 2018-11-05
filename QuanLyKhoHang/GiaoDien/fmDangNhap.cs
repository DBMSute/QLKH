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
    public partial class fmDangNhap : Form
    {
        public fmDangNhap()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cpLoading.Visible = true;
            pnRight.Enabled = false;
            tmrLoading.Start();
           
            
        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            cpLoading.animated = true;
            if(cpLoading.Value < 100)
            {
                cpLoading.Value++;
            }
            if (cpLoading.Value == 100)
            {
                tmrLoading.Stop();
                fmQuanLy2 fm = new fmQuanLy2();
                fm.Show();
                this.Hide();
            }
        }
    }
}
