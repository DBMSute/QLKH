using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace QuanLyKhoHang.GiaoDien
{
    public partial class fmQuanLy : Form
    {
        public static string sName = null;

        public fmQuanLy()
        {
            InitializeComponent();
            loadData();
            pnProfile.Size = new Size(lbTenTK.Size.Width + 120, 97);
            btnExtend.Location = new Point(pnProfile.Size.Width - btnExtend.Size.Width, pnProfile.Size.Height - btnExtend.Size.Height);
            sName = lbDataLN.Text + " " + lbDataFN.Text;
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            
            new fmKho().Show();
            this.Hide();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {

        }

        private void btnEmp_Click(object sender, EventArgs e)
        {

        }

        private void btnSup_Click(object sender, EventArgs e)
        {
  
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
      
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            new fmDangNhap().Show();
            this.Hide();
        }



        private void loadData()
        {
            BUS.TaiKhoanBUS.Instace.loadData(fmDangNhap.tentk, lbDataID, btnAVT, lbTenTK, lbDataLN, lbDataFN, lbDataDOB, lbDataAD, lbDataLG, lbDataCD, lbPosition, lbDataST);
            if (btnAVT.Image == null)
            {
                btnAVT.Image = QuanLyKhoHang.Properties.Resources.erroravt;
                MessageBox.Show("Avartar lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExtend_Click(object sender, EventArgs e)
        {
            int W = lbTenTK.Size.Width + 120 < 500 ? 500 : lbTenTK.Size.Width + 120;
            if (pnProfile.Size == new Size(W, 460))
            {        
                tmrExtend2.Start();
                return;
            }  
            tmrExtend.Start();
        }

        private void btnAVT_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAVT = new OpenFileDialog();
                ofdAVT.ShowDialog();

                if (ofdAVT.OpenFile() != null)
                {
                    BUS.TaiKhoanBUS.Instace.updateAvatar(lbDataID.Text, ofdAVT.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadData();
        }

        private void tmrExtend_Tick(object sender, EventArgs e) //phóng to
        {
            int H = pnProfile.Size.Height;
            int W = lbTenTK.Size.Width + 120 < 500 ? 500 : lbTenTK.Size.Width + 120;
            if (pnProfile.Size.Height >= 460)
            {
                pnProfile.Size = new Size(W, 460);          
                btnExtend.Image = QuanLyKhoHang.Properties.Resources.uparrow;
                tmrExtend.Stop();
            }else
            pnProfile.Size = new Size(W, H + 20);
            btnExtend.Location = new Point(pnProfile.Size.Width - btnExtend.Size.Width, pnProfile.Size.Height - btnExtend.Size.Height);
        }

        private void tmrExtend2_Tick(object sender, EventArgs e) //thu nhỏ
        {
            int W = lbTenTK.Size.Width + 120 < 500 ? 500 : lbTenTK.Size.Width + 120;
            int H = pnProfile.Size.Height;
            if (pnProfile.Size.Height <= 97)
            {
                pnProfile.Size = new Size(lbTenTK.Size.Width + 120, 97);
                btnExtend.Image = QuanLyKhoHang.Properties.Resources.downarrow;
                tmrExtend2.Stop();
            }else
            pnProfile.Size = new Size(W, H - 20);
            btnExtend.Location = new Point(pnProfile.Size.Width - btnExtend.Size.Width, pnProfile.Size.Height - btnExtend.Size.Height);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                fmInputPW fm = new fmInputPW();
                fm.ShowDialog();
                if(fmInputPW.npw == null)
                    return;
                BUS.TaiKhoanBUS.Instace.updatePW(lbDataID.Text, fmInputPW.opw, fmInputPW.npw);
                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thay đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadData();
        }

        private void btnEditFN_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = Interaction.InputBox("Input your first name...\nNote: Data must not null!", "Input", null);
                if (temp == "") return;
                BUS.TaiKhoanBUS.Instace.updateInfo(lbDataID.Text, lbDataLN.Text, temp, lbDataDOB.Text, lbDataAD.Text, lbPosition.Text, lbDataST.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadData();
        }

        private void btnEditLN_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = Interaction.InputBox("Input your last name...\nNote: Data must not null!", "Input", null);
                BUS.TaiKhoanBUS.Instace.updateInfo(lbDataID.Text, temp, lbDataFN.Text, lbDataDOB.Text, lbDataAD.Text, lbPosition.Text, lbDataST.Text);
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadData();
        }

        private void btnEditDOB_Click(object sender, EventArgs e)
        {
            try
            {
                fmInputDateTime fm = new fmInputDateTime();
                fm.ShowDialog();
                BUS.TaiKhoanBUS.Instace.updateInfo(lbDataID.Text, lbDataLN.Text, lbDataFN.Text, fmInputDateTime.datetimepicked, lbDataAD.Text, lbPosition.Text, lbDataST.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadData();
        }

        private void btnEditAD_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = Interaction.InputBox("Input yours address..\nNote: Data must not null!", "Input", null);
                if (temp == "") return;
                BUS.TaiKhoanBUS.Instace.updateInfo(lbDataID.Text, lbDataLN.Text, lbDataFN.Text, lbDataDOB.Text, temp, lbPosition.Text, lbDataST.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadData();
        }
    }
}
