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
        public static string tentk = "";
        public fmDangNhap()
        {
            InitializeComponent();
            tbACC.Text = QuanLyKhoHang.Properties.Settings.Default.UserName;
            tbPW.Text = QuanLyKhoHang.Properties.Settings.Default.UserPassword;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BUS.TaiKhoanBUS.Instace.checkAccount(tbACC.Text, tbPW.Text) == false)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tentk = tbACC.Text;
            if (cbRemember.Checked == true)
            {
                QuanLyKhoHang.Properties.Settings.Default.UserName = tbACC.Text;
                QuanLyKhoHang.Properties.Settings.Default.UserPassword = tbPW.Text;
                QuanLyKhoHang.Properties.Settings.Default.Save();
            }
            else
            {
                QuanLyKhoHang.Properties.Settings.Default.UserName = null;
                QuanLyKhoHang.Properties.Settings.Default.UserPassword = null;
                QuanLyKhoHang.Properties.Settings.Default.Save();
            }
            BUS.TaiKhoanBUS.Instace.updateLastLogin(tentk);
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
                new fmQuanLy().Show();

                this.Hide();
            }
        }
    }
}
