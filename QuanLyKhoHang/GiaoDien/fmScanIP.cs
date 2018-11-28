using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QuanLyKhoHang.GiaoDien
{
    public partial class fmScanIP : Form
    {
        public static bool flag = false;
        private List<string> lIPs = new List<string>();

        public fmScanIP()
        {
            InitializeComponent();
            mtbIP.ValidatingType = typeof(IPAddress);
            mtbSubnet.ValidatingType = typeof(IPAddress);
            if(QuanLyKhoHang.Properties.Settings.Default.Server == "" || QuanLyKhoHang.Properties.Settings.Default.Server == null) return;
            string[] temp = QuanLyKhoHang.Properties.Settings.Default.Server.Split('.');
            string temp2 = temp[2].Length == 3 ? temp[2] : temp[2]+=new string(' ',3 - temp[2].Length);         
            mtbIP.Text = string.Concat(temp[0].Length == 3 ? temp[0] : temp[0] += new string(' ', 3 - temp[0].Length),
                temp[1].Length == 3 ? temp[1] : temp[1] += new string(' ', 3 - temp[1].Length), 
                temp[2].Length == 3 ? temp[2] : temp[2] += new string(' ', 3 - temp[2].Length), 
                temp[3].Length == 3 ? temp[3] : temp[3] += new string(' ', 3 - temp[3].Length), ' ');
        }

        private List<string> GetIpAddressFromHostName()
        {
            List<string> lIPs = new List<string>();
            IPHostEntry IPs = Dns.GetHostEntry(Dns.GetHostName());
            lbNof.Text = "Đang lấy danh sách IP...\n";
            WaitNSeconds(2);
            foreach (IPAddress ip in IPs.AddressList)
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    lIPs.Add(ip.ToString().Trim());
                    lbNof.Text = lbNof.Text + "--> " + ip.ToString().Trim() +"\n";
                }
            return lIPs;
        }

        private void tryConnecting()
        {
            foreach (string s in lIPs)
            {
                lbNof.Text = lbNof.Text + "Đang thử kết nối tới " + s + "\n";
                BUS.DangNhapBUS.INSTANCE.setIP(s);
                WaitNSeconds(2);
                QuanLyKhoHang.Properties.Settings.Default.Server = s;
                if (BUS.DangNhapBUS.INSTANCE.IsServerConnected() == true)
                {
                    lbNof.Text = lbNof.Text + "--> Thành công!\nIP server là: " + s;
                    flag = true;
                    return;
                }
                lbNof.Text = lbNof.Text + " --> Thất bại!\n";
            }
            flag = false;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            lIPs = new List<string>();
            if (switchAuto.Value == true)        
                lIPs = GetIpAddressFromHostName();           
            else
                GetIPCanPing();
            MessageBox.Show("Hoàn thành!", "Lấy danh sách IP khả dụng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WaitNSeconds(int seconds)         //đợi trong seconds giây
        {
            if (seconds < 1) return;
            DateTime desired = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < desired)
            {
                Application.DoEvents();
            }
        }


        private void p_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;
            if (e.Reply.Status == IPStatus.Success)
            {
                lIPs.Add(ip);
                lbNof.Text = lbNof.Text + "--> " + ip + "\n";
            }
        }

        private void GetIPCanPing()
        {
            lbNof.Text = "Đang lấy danh sách IP...\n";
            WaitNSeconds(2);
            if (mtbSubnet.Text.Split('0').Length - 1 == 1)
            {
                for(int i = 1; i < 255; i++)
                {
                    Ping p = new Ping();
                    p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                    string temp = (mtbIP.Text.Trim().Substring(0, mtbIP.Text.Trim().LastIndexOf('.')+1) + i).Replace(" ",String.Empty);
                    p.SendAsync(temp, 100, temp);                  
                }
            }
            if(mtbSubnet.Text.Split('0').Length - 1 == 2)
            {
                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 1; j < 255; j++)
                    {
                        Ping p = new Ping();
                        p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                        string temp = (mtbIP.Text.Trim().Substring(0, mtbIP.Text.Trim().IndexOf('.', mtbIP.Text.IndexOf('.', mtbIP.Text.IndexOf('.') + 1)) + 1) + i + "." + j).Replace(" ", String.Empty);
                        p.SendAsync(temp, 100, temp);
                    }
                }
            }
            if (mtbSubnet.Text.Split('0').Length - 1 == 3)
            {
                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 0; j <= 255; j++)
                    {
                        for (int k = 1; k < 255; k++)
                        {
                            Ping p = new Ping();
                            p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                            string temp = (mtbIP.Text.Trim().Substring(0, mtbIP.Text.Trim().IndexOf('.') + 1) + i + "." + j + "." + k).Replace(" ", String.Empty);
                            p.SendAsync(temp, 100, temp);
                        }
                    }
                }
            }
            Console.WriteLine("Aaa");
        }

        private void mtbIP_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(mtbIP.Text.Trim().Substring(0, mtbIP.Text.Trim().IndexOf('.'))) < 128 && Convert.ToInt32(mtbIP.Text.Trim().Substring(0, mtbIP.Text.Trim().IndexOf('.'))) >= 1)
                mtbSubnet.Text = "2250  0  0";
            else if (Convert.ToInt32(mtbIP.Text.Trim().Substring(0, mtbIP.Text.Trim().IndexOf('.'))) < 192)
                mtbSubnet.Text = "2552550  0";
            else if (Convert.ToInt32(mtbIP.Text.Trim().Substring(0, mtbIP.Text.Trim().IndexOf('.'))) < 223)
                mtbSubnet.Text = "2552552550";
        }

        private void switchAuto_OnValueChange(object sender, EventArgs e)
        {
            if (switchAuto.Value == true)
            {
                mtbIP.Enabled = false;
                mtbSubnet.Enabled = false;
            }
            else
            {
                mtbIP.Enabled = true;
                mtbSubnet.Enabled = true;
            }
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            tryConnecting();
            if (flag == true) {
                if (MessageBox.Show("Thành công!\nBạn có muốn trở về giao diện đăng nhập?", "Kết nối thử", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    this.Close();
                btnTestConn.Enabled = false;
            }
            else
                MessageBox.Show("Không có địa chỉ IP nào kết nối thành công!", "Kết nối thử", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
