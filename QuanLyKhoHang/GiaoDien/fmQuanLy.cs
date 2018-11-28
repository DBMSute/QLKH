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
        public static string sID = null;
        
        public fmQuanLy()
        {
            InitializeComponent();
            loadData();
            pnProfile.Size = new Size(lbTenTK.Size.Width + 120, 97);
            btnExtend.Location = new Point(pnProfile.Size.Width - btnExtend.Size.Width, pnProfile.Size.Height - btnExtend.Size.Height);
            sName = lbDataLN.Text + " " + lbDataFN.Text;
            sID = lbDataID.Text;
            if (lbPosition.Text == "Quản trị tối cao")
            {
                return;
            }
            else if(lbPosition.Text == "Quản lý")
            {
                btnAna.Enabled = false;
                btnCus.Enabled = false;
                btnSup.Enabled = false;
            }
            else
            {
                btnAna.Enabled = false;
                btnCus.Enabled = false;
                btnSup.Enabled = false;
                btnKho.Enabled = false;
                btnEmp.Enabled = false;
            }
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            
            new fmKho().Show();
            this.Close();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            new fmKhachHang().Show();
            this.Hide();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            new fmNhanVien().Show();
            this.Hide();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            new fmNhaCC().Show();
            this.Hide();
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            new fmThongKe().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            new fmDangNhap().Show();
            this.Close();
        }



        private void loadData()
        {
            BUS.TaiKhoanBUS.INSTANCE.loadData(fmDangNhap.tentk, lbDataID, btnAVT, lbTenTK, lbDataLN, lbDataFN, lbDataDOB, lbDataAD, lbDataLG, lbDataCD, lbPosition, lbDataST);
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
                    BUS.TaiKhoanBUS.INSTANCE.updateAvatar(lbDataID.Text, ofdAVT.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Contains("Index was outside")?"Cập nhật Avatar thất bại!":ex.Message, "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            new fmInputPW(lbDataID.Text).ShowDialog(); 
            loadData();
        }

        private void btnEditFN_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = Interaction.InputBox("Nhập tên của bạn...\nChú ý: Dữ liệu không được rỗng!", "Đổi tên", null);
                if (temp == "") return;
                BUS.TaiKhoanBUS.INSTANCE.updateInfo(lbDataID.Text, lbDataLN.Text, temp, lbDataDOB.Text, lbDataAD.Text, lbPosition.Text, lbDataST.Text);
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
                string temp = Interaction.InputBox("Nhập họ và tên đệm của bạn...\nChú ý: Dữ liệu không được rỗng!", "Đổi họ và tên đệm", null);
                BUS.TaiKhoanBUS.INSTANCE.updateInfo(lbDataID.Text, temp, lbDataFN.Text, lbDataDOB.Text, lbDataAD.Text, lbPosition.Text, lbDataST.Text);
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
                BUS.TaiKhoanBUS.INSTANCE.updateInfo(lbDataID.Text, lbDataLN.Text, lbDataFN.Text, fmInputDateTime.datetimepicked, lbDataAD.Text, lbPosition.Text, lbDataST.Text);
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
                string temp = Interaction.InputBox("Nhập địa chỉ...\nChú ý: Dữ liệu không được rỗng", "Đổi địa chỉ", null);
                if (temp == "") return;
                BUS.TaiKhoanBUS.INSTANCE.updateInfo(lbDataID.Text, lbDataLN.Text, lbDataFN.Text, lbDataDOB.Text, temp, lbPosition.Text, lbDataST.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadData();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            new fmPhieuNhap().Show();
            this.Close();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            new fmPhieuXuat().Show();
            this.Close();
        }
    }
}
