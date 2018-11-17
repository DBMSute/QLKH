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
    public partial class fmInputPW : Form
    {
        public static string opw = null;
        public static string npw = null;
        public fmInputPW()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbNewPW.Text != tbCfmPW.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            opw = tbOldPW.Text;
            npw = tbNewPW.Text;
            this.Close();
        }
    }
}
