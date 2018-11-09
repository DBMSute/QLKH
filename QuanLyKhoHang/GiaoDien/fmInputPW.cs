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
            if (tbNewPW.Text.Length < 8)
            {
                MessageBox.Show("Password must greater than 8 characters!", "Opps...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbNewPW.Text != tbCfmPW.Text)
            {
                MessageBox.Show("Confirm password not like new password!", "Opps...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            opw = tbOldPW.Text;
            npw = tbNewPW.Text;
            this.Close();
        }
    }
}
