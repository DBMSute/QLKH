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
        private int co = -1;
        private int dem = 0;
        Size sbtnKho = new Size();
        Size sKhachHang = new Size();
        Size sNhaCC = new Size();
        Size sQuanLyNV = new Size();
        Size sThongKe = new Size();

        public fmQuanLy()
        {
            InitializeComponent();
            sbtnKho = btnKho.Size;
            sKhachHang = btnCus.Size;
            sNhaCC = btnSup.Size;
            sQuanLyNV = btnEmp.Size;
            sThongKe = btnAna.Size;
            loadData();
            pnProfile.Size = new Size(lbTenTK.Size.Width + 120, 97);
            btnExtend.Location = new Point(pnProfile.Size.Width - btnExtend.Size.Width, pnProfile.Size.Height - btnExtend.Size.Height);
        }

        private void tmrButon_Tick(object sender, EventArgs e)
        {
            Size s = new Size();        
            if (dem < 7)
            {
                if (co == 0)
                {
                    s = btnKho.Size;
                    s.Height++;
                    s.Width++;
                    btnKho.Size = s;
                }
                if (co == 1)
                {
                    s = btnSup.Size;
                    s.Height++;
                    s.Width++;
                    btnSup.Size = s;
                }
                if (co == 2)
                {
                    s = btnEmp.Size;
                    s.Height++;
                    s.Width++;
                    btnEmp.Size = s;
                }
                if (co == 4)
                {
                    s = btnAna.Size;
                    s.Height++;
                    s.Width++;
                    btnAna.Size = s;
                }
                if (co == 5)
                {
                    s = btnCus.Size;
                    s.Height++;
                    s.Width++;
                    btnCus.Size = s;
                }

            }
            else
            {
                btnKho.Size = sbtnKho;
                btnCus.Size = sKhachHang;
                btnSup.Size = sNhaCC;
                btnEmp.Size = sQuanLyNV;
                btnAna.Size = sThongKe;
                tmrButon.Enabled = false;
                dem = 0;
            }
            dem++;
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            tmrButon.Enabled = true;
            co = 0;
            new fmKho().Show();
            this.Hide();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            tmrButon.Enabled = true;
            co = 5;
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            tmrButon.Enabled = true;
            co = 2;
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            tmrButon.Enabled = true;
            co = 1;
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            tmrButon.Enabled = true;
            co = 4;
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
                MessageBox.Show("Avatar error!", "Opps...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExtend_Click(object sender, EventArgs e)
        {
            int W = lbTenTK.Size.Width + 120 < 430 ? 430 : lbTenTK.Size.Width + 120;
            if (pnProfile.Size == new Size(W, 460))
            {
                //pnProfile.Size = new Size(lbTenTK.Size.Width + 120, 97); //thu nhỏ         
                tmrExtend2.Start();
                return;
            }
            //pnProfile.BackColor = Color.FromArgb(150, 0, 0, 0);
            //pnProfile.Size = new Size(W, 460);//phóng to           
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
            int W = lbTenTK.Size.Width + 120 < 430 ? 430 : lbTenTK.Size.Width + 120;
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
            int W = lbTenTK.Size.Width + 120 < 430 ? 430 : lbTenTK.Size.Width + 120;
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
                BUS.TaiKhoanBUS.Instace.updatePW(lbDataID.Text, fmInputPW.opw, fmInputPW.npw);
                MessageBox.Show("Success!", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Password was existed!\n" + ex.Message, "Opps...", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Data is invalid!\n" + ex.Message, "Opps...", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Data is invalid!\n"+ex.Message,"Opps...",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                MessageBox.Show("Data is invalid!\n" + ex.Message, "Opps...", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Data is invalid!\n" + ex.Message, "Opps...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadData();
        }
    }
}
