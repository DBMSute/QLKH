using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;

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
            lbCurIP.Text = QuanLyKhoHang.Properties.Settings.Default.Server;
            BUS.DangNhapBUS.INSTANCE.setIP(lbCurIP.Text);
            try
            {
                File.Copy("CenturyGothic.TTF",
                 Path.Combine(Environment.GetFolderPath(SpecialFolder.Windows), "Fonts", "CenturyGothic.TTF"));
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts");
                key.SetValue("My Font Description", "CenturyGothic.TTF");
                key.Close();
                MessageBox.Show("Đã cài thành công font Century Gothic.\nNếu đây là lần đầu sử dụng, vui lòng dùng:\nTài khoản: admin\nMật khẩu: admin", "Chào mừng bạn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Refresh();
            }
            catch (Exception)
            {
                return;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            QuanLyKhoHang.Properties.Settings.Default.UserName = null;
            QuanLyKhoHang.Properties.Settings.Default.UserPassword = null;
            //QuanLyKhoHang.Properties.Settings.Default.Server = null;
            QuanLyKhoHang.Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PbLoading.Visible = true;
            fmScanIP.WaitNSeconds(2);
            try
            {
                if (BUS.TaiKhoanBUS.INSTANCE.checkAccount(tbACC.Text, tbPW.Text) == 2)
                {
                    MessageBox.Show("Tài khoản đang bị khóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PbLoading.Visible = false;
                    return;
                }
                if (BUS.TaiKhoanBUS.INSTANCE.checkAccount(tbACC.Text, tbPW.Text) == 0)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PbLoading.Visible = false;
                    return;
                }
                if (BUS.TaiKhoanBUS.INSTANCE.checkAccount(tbACC.Text, tbPW.Text) == -1)
                {
                    MessageBox.Show("Lỗi không xác định", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PbLoading.Visible = false;
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
                BUS.TaiKhoanBUS.INSTANCE.updateLastLogin(tentk);
                cpLoading.Visible = true;
                tmrLoading.Start();
                PbLoading.Visible = false;
                pnRight.Enabled = false;
            }catch(Exception)
            {
                PbLoading.Visible = false;
                if (MessageBox.Show("Kết nối máy chủ thất bại!\nBạn có muốn tìm kiếm IP server?", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                    == DialogResult.Yes)
                    new fmScanIP().ShowDialog();
                if (fmScanIP.flag == false)
                {
                    MessageBox.Show("Không tìm thấy IP server!\nVui lòng cài đặt bằng tay.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    new fmInputIP().ShowDialog();
                }
                lbCurIP.Text = QuanLyKhoHang.Properties.Settings.Default.Server;
            }
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

        private void pbHide_Click(object sender, EventArgs e)
        {
            if (tbPW.PasswordChar == '●')
            {
                tbPW.PasswordChar = '\0';
                pbHide.Image = QuanLyKhoHang.Properties.Resources.eyeclose;
            }
            else
            {
                tbPW.PasswordChar = '●';
                pbHide.Image = QuanLyKhoHang.Properties.Resources.tongquan;
            }
            tbPW.Refresh();
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                btnLogin_Click(null, null);
        }

        private void fmDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                btnLogin_Click(null, null);
        }
    }
}
