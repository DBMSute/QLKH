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
        private string id = null;
        public fmInputPW(string temp)
        {
            InitializeComponent();
            id = temp;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNewPW.Text != tbCfmPW.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận không đúng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(tbNewPW.Text == string.Empty)
                {
                    MessageBox.Show("Mật khẩu không được rỗng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BUS.TaiKhoanBUS.INSTANCE.updatePW(id, tbOldPW.Text, tbNewPW.Text);
                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thay đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
