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
        public static string sPosition = null;
        public static string sIDQuanLy = null;
        
        public fmQuanLy()
        {
            InitializeComponent();
            loadData();
            pnProfile.Size = new Size(lbTenTK.Size.Width + 120, 97);
            btnExtend.Location = new Point(pnProfile.Size.Width - btnExtend.Size.Width, pnProfile.Size.Height - btnExtend.Size.Height);
            sName = lbDataLN.Text + " " + lbDataFN.Text;
            sID = lbDataID.Text;
            sPosition = lbPosition.Text;
            tmrClock.Start();
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
            Label temp = new Label();
            BUS.TaiKhoanBUS.INSTANCE.loadData(fmDangNhap.tentk, lbDataID, btnAVT, lbTenTK, lbDataLN, lbDataFN, lbDataDOB, lbDataAD, lbDataLG, lbDataCD, lbPosition, lbDataST, temp, lbDataQuanLy);
            if (lbDataQuanLy.Text == " ") lbDataQuanLy.Text = "Bạn là trùm rồi :3";
            sIDQuanLy = temp.Text;
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
            lbAddress.Visible = true;
            lbCD.Visible = true;
            lbDataAD.Visible = true;
            lbDataCD.Visible = true;
            lbDataDOB.Visible = true;
            lbDataFN.Visible = true;
            lbDataID.Visible = true;
            lbDataLG.Visible = true;
            lbDataLN.Visible = true;
            lbDataQuanLy.Visible = true;
            lbDataST.Visible = true;
            lbDateOfBirth.Visible = true;
            lbFirstName.Visible = true;
            lbID.Visible = true;
            lbLastLogin.Visible = true;
            lbLastName.Visible = true;
            lbQL.Visible = true;
            lbStatus.Visible = true;
            int H = pnProfile.Size.Height;
            int W = lbTenTK.Size.Width + 120 < 500 ? 500 : lbTenTK.Size.Width + 120;
            if (pnProfile.Size.Height >= 460)
            {
                pnProfile.Size = new Size(W, 460);
                btnExtend.Image = QuanLyKhoHang.Properties.Resources.uparrow;             
            }
            else
            {
                pnProfile.Size = new Size(W, H + 50);
                return;
            }
            if(lbID.Location.X < 44)
            {
                lbID.Location = new Point(lbID.Location.X + 50, lbID.Location.Y);
                return;
            }
            if (lbFirstName.Location.X < 44)
            {
                lbFirstName.Location = new Point(lbFirstName.Location.X + 50, lbFirstName.Location.Y);
                return;
            }
            if (lbLastName.Location.X < 44)
            {
                lbLastName.Location = new Point(lbLastName.Location.X + 50, lbLastName.Location.Y);
                return;
            }
            if (lbDateOfBirth.Location.X < 44)
            {
                lbDateOfBirth.Location = new Point(lbDateOfBirth.Location.X + 50, lbDateOfBirth.Location.Y);
                return;
            }
            if (lbAddress.Location.X < 44)
            {
                lbAddress.Location = new Point(lbAddress.Location.X + 50, lbAddress.Location.Y);
                return;
            }
            if (lbLastLogin.Location.X < 44)
            {
                lbLastLogin.Location = new Point(lbLastLogin.Location.X + 50, lbLastLogin.Location.Y);
                return;
            }
            if (lbStatus.Location.X < 44)
            {
                lbStatus.Location = new Point(lbStatus.Location.X + 50, lbStatus.Location.Y);
                return;
            }
            if (lbCD.Location.X < 44)
            {
                lbCD.Location = new Point(lbCD.Location.X + 50, lbCD.Location.Y);
                return;
            }
            if (lbQL.Location.X < 44)
            {
                lbQL.Location = new Point(lbQL.Location.X + 50, lbQL.Location.Y);
                return;
            }
            //-------LABEL
            if (lbDataID.Location.X > 243)
            {
                lbDataID.Location = new Point(lbDataID.Location.X - 30, lbDataID.Location.Y);
                return;
            }
            if (lbDataFN.Location.X > 243)
            {
                lbDataFN.Location = new Point(lbDataFN.Location.X - 30, lbDataFN.Location.Y);
                return;
            }
            if (lbDataLN.Location.X > 243)
            {
                lbDataLN.Location = new Point(lbDataLN.Location.X - 30, lbDataLN.Location.Y);
                return;
            }
            if (lbDataDOB.Location.X > 243)
            {
                lbDataDOB.Location = new Point(lbDataDOB.Location.X - 30, lbDataDOB.Location.Y);
                return;
            }
            if (lbDataAD.Location.X > 243)
            {
                lbDataAD.Location = new Point(lbDataAD.Location.X - 30, lbDataAD.Location.Y);
                return;
            }
            if (lbDataLG.Location.X > 243)
            {
                lbDataLG.Location = new Point(lbDataLG.Location.X - 30, lbDataLG.Location.Y);
                return;
            }
            if (lbDataST.Location.X > 243)
            {
                lbDataST.Location = new Point(lbDataST.Location.X - 30, lbDataST.Location.Y);
                return;
            }
            if (lbDataCD.Location.X > 243)
            {
                lbDataCD.Location = new Point(lbDataCD.Location.X - 30, lbDataCD.Location.Y);
                return;
            }
            if (lbDataQuanLy.Location.X > 243)
            {
                lbDataQuanLy.Location = new Point(lbDataQuanLy.Location.X - 30, lbDataQuanLy.Location.Y);
                return;
            }
            //-----Data
            if(btnEditFN.Location.X < 10)
            {
                btnEditFN.Location = new Point(btnEditFN.Location.X + 20, btnEditFN.Location.Y);
                return;
            }
            if (btnEditLN.Location.X < 10)
            {
                btnEditLN.Location = new Point(btnEditLN.Location.X + 20, btnEditLN.Location.Y);
                return;
            }
            if (btnEditDOB.Location.X < 10)
            {
                btnEditDOB.Location = new Point(btnEditDOB.Location.X + 20, btnEditDOB.Location.Y);
                return;
            }
            if (btnEditAD.Location.X < 10)
            {
                btnEditAD.Location = new Point(btnEditAD.Location.X + 20, btnEditAD.Location.Y);
                return;
            }

            //---button
            if(btnEditPW.Location.Y > 395)
            {
                btnEditPW.Location = new Point(btnEditPW.Location.X, btnEditPW.Location.Y - 40);
                return;
            }

            btnExtend.Location = new Point(pnProfile.Size.Width - btnExtend.Size.Width, pnProfile.Size.Height - btnExtend.Size.Height);
            tmrExtend.Stop();
        }

        private void tmrExtend2_Tick(object sender, EventArgs e) //thu nhỏ
        {
            //-----Data
            if (btnEditFN.Location.X > -210)
            {
                btnEditFN.Location = new Point(btnEditFN.Location.X - 20, btnEditFN.Location.Y);
                return;
            }
            if (btnEditLN.Location.X > -210)
            {
                btnEditLN.Location = new Point(btnEditLN.Location.X - 20, btnEditLN.Location.Y);
                return;
            }
            if (btnEditDOB.Location.X > -210)
            {
                btnEditDOB.Location = new Point(btnEditDOB.Location.X - 20, btnEditDOB.Location.Y);
                return;
            }
            if (btnEditAD.Location.X > -210)
            {
                btnEditAD.Location = new Point(btnEditAD.Location.X - 20, btnEditAD.Location.Y);
                return;
            }
            //---label
            if (lbID.Location.X > -206)
            {
                lbID.Location = new Point(lbID.Location.X - 50, lbID.Location.Y);
                return;
            }
            if (lbFirstName.Location.X > -206)
            {
                lbFirstName.Location = new Point(lbFirstName.Location.X - 50, lbFirstName.Location.Y);
                return;
            }
            if (lbLastName.Location.X > -206)
            {
                lbLastName.Location = new Point(lbLastName.Location.X - 50, lbLastName.Location.Y);
                return;
            }
            if (lbDateOfBirth.Location.X > -206)
            {
                lbDateOfBirth.Location = new Point(lbDateOfBirth.Location.X - 50, lbDateOfBirth.Location.Y);
                return;
            }
            if (lbAddress.Location.X > -206)
            {
                lbAddress.Location = new Point(lbAddress.Location.X - 50, lbAddress.Location.Y);
                return;
            }
            if (lbLastLogin.Location.X > -206)
            {
                lbLastLogin.Location = new Point(lbLastLogin.Location.X - 50, lbLastLogin.Location.Y);
                return;
            }
            if (lbStatus.Location.X > -206)
            {
                lbStatus.Location = new Point(lbStatus.Location.X - 50, lbStatus.Location.Y);
                return;
            }
            if (lbCD.Location.X > -206)
            {
                lbCD.Location = new Point(lbCD.Location.X - 50, lbCD.Location.Y);
                return;
            }
            if (lbQL.Location.X > -206)
            {
                lbQL.Location = new Point(lbQL.Location.X - 50, lbQL.Location.Y);
                return;
            }
            //-------LABEL DATA
            if (lbDataID.Location.X < 543)
            {
                lbDataID.Location = new Point(lbDataID.Location.X + 40, lbDataID.Location.Y);
                return;
            }
            if (lbDataFN.Location.X < 543)
            {
                lbDataFN.Location = new Point(lbDataFN.Location.X + 40, lbDataFN.Location.Y);
                return;
            }
            if (lbDataLN.Location.X < 543)
            {
                lbDataLN.Location = new Point(lbDataLN.Location.X + 40, lbDataLN.Location.Y);
                return;
            }
            if (lbDataDOB.Location.X < 543)
            {
                lbDataDOB.Location = new Point(lbDataDOB.Location.X + 40, lbDataDOB.Location.Y);
                return;
            }
            if (lbDataAD.Location.X < 543)
            {
                lbDataAD.Location = new Point(lbDataAD.Location.X + 40, lbDataAD.Location.Y);
                return;
            }
            if (lbDataLG.Location.X < 543)
            {
                lbDataLG.Location = new Point(lbDataLG.Location.X + 40, lbDataLG.Location.Y);
                return;
            }
            if (lbDataST.Location.X < 543)
            {
                lbDataST.Location = new Point(lbDataST.Location.X + 40, lbDataST.Location.Y);
                return;
            }
            if (lbDataCD.Location.X < 543)
            {
                lbDataCD.Location = new Point(lbDataCD.Location.X + 40, lbDataCD.Location.Y);
                return;
            }
            if (lbDataQuanLy.Location.X < 543)
            {
                lbDataQuanLy.Location = new Point(lbDataQuanLy.Location.X + 40, lbDataQuanLy.Location.Y);
                return;
            }
            

            //---button PW
            if (btnEditPW.Location.Y < 595)
            {
                btnEditPW.Location = new Point(btnEditPW.Location.X, btnEditPW.Location.Y + 40);
                return;
            }

            lbAddress.Visible = false;
            lbCD.Visible = false;
            lbDataAD.Visible = false;
            lbDataCD.Visible = false;
            lbDataDOB.Visible = false;
            lbDataFN.Visible = false;
            lbDataID.Visible = false;
            lbDataLG.Visible = false;
            lbDataLN.Visible = false;
            lbDataQuanLy.Visible = false;
            lbDataST.Visible = false; 
            lbDateOfBirth.Visible = false;
            lbFirstName.Visible = false;
            lbID.Visible = false; 
            lbLastLogin.Visible = false;
            lbLastName.Visible = false; 
            lbQL.Visible = false;
            lbStatus.Visible = false;

            int W = lbTenTK.Size.Width + 120 < 500 ? 500 : lbTenTK.Size.Width + 120;
            int H = pnProfile.Size.Height;
            if (pnProfile.Size.Height <= 97)
            {               
                btnExtend.Image = QuanLyKhoHang.Properties.Resources.downarrow;
                pnProfile.Size = new Size(lbTenTK.Size.Width + 120, 97);
            }
            else
            {            
                pnProfile.Size = new Size(W, H - 50);
                return;
            }
            btnExtend.Location = new Point(pnProfile.Size.Width - btnExtend.Size.Width, pnProfile.Size.Height - btnExtend.Size.Height);
            tmrExtend2.Stop();
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

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
