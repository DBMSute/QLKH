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
    public partial class fmInputIP : Form
    {
        public fmInputIP()
        {
            InitializeComponent();
            mtbIP.ValidatingType = typeof(System.Net.IPAddress);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                BUS.DangNhapBUS.INSTANCE.setIP(mtbIP.Text.Trim().Replace(" ", string.Empty));
                if (BUS.DangNhapBUS.INSTANCE.IsServerConnected() == false) throw new Exception();
                QuanLyKhoHang.Properties.Settings.Default.Server = mtbIP.Text.Replace(" ", string.Empty);
                MessageBox.Show("Click OK để trở lại giao diện đăng nhập!", "Kết nối thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra lại IP server", "Kết nối thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
