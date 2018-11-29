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

namespace QuanLyKhoHang.GiaoDien
{
    public partial class fmInsertEmp : Form
    { 
        public fmInsertEmp()
        {
            InitializeComponent();
            if (fmQuanLy.sID != "TK000")
            {
                rbEmp.Checked = true;
                rbManager.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbTenTK.Text == "" || tbPW.Text == "" || tbCPW.Text == "" || tbLN.Text == "" || tbFN.Text == "" || tbADD.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tbPW.Text != tbCPW.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int tempPers = rbManager.Checked == true ? 2 : 3;
                int tempTinhTrang = rbActive.Checked == true ? 1 : 0;
                BUS.NhanVienBUS.INSTANCE.Insert(tbTenTK.Text, tbPW.Text, null, tbLN.Text, tbFN.Text, dtimeDOB.Value.ToString(), tbADD.Text, tempPers, tempTinhTrang, fmQuanLy.sID == "TK000" ? "TK000" : fmQuanLy.sID);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
