using Microsoft.VisualBasic;
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
    public partial class fmNhanVien : Form
    {


        public fmNhanVien()
        {
            InitializeComponent();

            BUS.NhanVienBUS.INSTANCE.loadData(dtgvEmp);
            tmrClock.Start();
            loadData(0);
            btnEmpSave.color = Color.SeaGreen;
            btnEmpSave.colorActive = Color.MediumSeaGreen;
        }

        public void loadData(int row)
        {
            BUS.NhanVienBUS.INSTANCE.loadData(dtgvEmp);
            dtgvEmp.CurrentCell = dtgvEmp[0, row];
            dtgvEmp_CellClick(null, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbDataFN.Text = dtgvEmp.Rows[dtgvEmp.CurrentCell.RowIndex].Cells[5].Value.ToString();
            lbDataLN.Text = dtgvEmp.Rows[dtgvEmp.CurrentCell.RowIndex].Cells[4].Value.ToString();
            lbDataDOB.Text = dtgvEmp.Rows[dtgvEmp.CurrentCell.RowIndex].Cells[8].Value.ToString();
            lbDataADD.Text = dtgvEmp.Rows[dtgvEmp.CurrentCell.RowIndex].Cells[6].Value.ToString();
            lbDataLG.Text = dtgvEmp.Rows[dtgvEmp.CurrentCell.RowIndex].Cells[7].Value.ToString();
            pnAVT.BackgroundImage = (byte[])dtgvEmp.Rows[dtgvEmp.CurrentCell.RowIndex].Cells[3].Value == null ? QuanLyKhoHang.Properties.Resources.erroravt : Image.FromStream(new MemoryStream((byte[])dtgvEmp.Rows[dtgvEmp.CurrentCell.RowIndex].Cells[3].Value));
            lbDataPosition.Text = (int)dtgvEmp.Rows[dtgvEmp.CurrentCell.RowIndex].Cells[10].Value == 1 ? "Quản trị tối cao" : ((int)dtgvEmp.Rows[dtgvEmp.CurrentCell.RowIndex].Cells[10].Value == 2 ? "Quản lý" : "Nhân viên");
            switchTinhTrang.Value = (int)dtgvEmp.Rows[dtgvEmp.CurrentCell.RowIndex].Cells[11].Value == 1 ? true : false;
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            new fmInsertEmp().ShowDialog();
            BUS.NhanVienBUS.INSTANCE.loadData(dtgvEmp);
        }

        private void btnEmpDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                BUS.NhanVienBUS.INSTANCE.Delete(dtgvEmp.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Đã xóa!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BUS.NhanVienBUS.INSTANCE.loadData(dtgvEmp);
                loadData(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Contains("REFERENCE") == true ? "Tài khoản đang quản lý một kho nào đó!" : ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.NhanVienBUS.INSTANCE.loadData(dtgvEmp);
            }
        }

        private void btnEmpSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnEmpSave.color == Color.SeaGreen)
                {
                    MessageBox.Show("Không có gì mới để lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc muốn lưu?", "Lưu dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                BUS.NhanVienBUS.INSTANCE.saveEdit(dtgvEmp);
                MessageBox.Show("Lưu thành công!", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEmpSave.color = Color.SeaGreen;
                btnEmpSave.colorActive = Color.MediumSeaGreen;
            }   catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnAVT_Click(object sender, EventArgs e)
        {
            try
            {
                openAVT = new OpenFileDialog();
                openAVT.ShowDialog();

                if (openAVT.OpenFile() != null)
                {
                    BUS.TaiKhoanBUS.INSTANCE.updateAvatar(dtgvEmp.Rows[dtgvEmp.CurrentCell.RowIndex].Cells[0].Value.ToString(), openAVT.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadData(dtgvEmp.CurrentRow.Index);
        }

        private void btnEditFN_Click(object sender, EventArgs e)
        {
            string temp = Interaction.InputBox("Nhập tên\nChú ý: Không chấp nhận giá trị 'NULL'", "Input", null);
            if (temp == "") return;
            dtgvEmp.CurrentRow.Cells[5].Value = lbDataFN.Text = temp;
        }

        private void btnEditLN_Click(object sender, EventArgs e)
        {
            string temp = Interaction.InputBox("Nhập họ và tên đệm\nChú ý: Không chấp nhận giá trị 'NULL'", "Input", null);
            if (temp == "") return;
            dtgvEmp.CurrentRow.Cells[4].Value = lbDataLN.Text = temp;
        }

        private void btnDOB_Click(object sender, EventArgs e)
        {
            fmInputDateTime fm = new fmInputDateTime();
            fm.ShowDialog();
            lbDataDOB.Text = fmInputDateTime.datetimepicked;
            if (lbDataDOB.Text == "")
            {   
                MessageBox.Show("Ngày không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbDataDOB.Text = dtgvEmp.CurrentRow.Cells[8].Value.ToString();
                return;
            }
            dtgvEmp.CurrentRow.Cells[8].Value = fmInputDateTime.datetimepicked;
        }

        private void btnEditADD_Click(object sender, EventArgs e)
        {
            string temp = Interaction.InputBox("Nhập tên\nChú ý: Không chấp nhận giá trị 'NULL'", "Input", null);
            if (temp == "") return;
            dtgvEmp.CurrentRow.Cells[6].Value = lbDataFN.Text = temp;
        }

        private void switchTinhTrang_OnValueChange(object sender, EventArgs e)
        {
            if (switchTinhTrang.Value == true)
                dtgvEmp.Rows[dtgvEmp.CurrentCell.RowIndex].Cells[11].Value = 1;
            else
                dtgvEmp.Rows[dtgvEmp.CurrentCell.RowIndex].Cells[11].Value = 0;
        }

        private void tbEmpSearch_Enter(object sender, EventArgs e)
        {
            if (tbEmpSearch.Text == "Tìm kiếm...")
                tbEmpSearch.Text = "";
        }

        private void tbEmpSearch_Leave(object sender, EventArgs e)
        {
            if (tbEmpSearch.Text == "")
            {
                tbEmpSearch.Text = "Tìm kiếm...";
                BUS.NhanVienBUS.INSTANCE.loadData(dtgvEmp);
            }
        }

        private void tbEmpSearch_TextChanged(object sender, EventArgs e)
        {
            BUS.NhanVienBUS.INSTANCE.searchByKeyword(dtgvEmp, tbEmpSearch.Text, switchStatus.Value == true ? 1 : 0);
        }

        private void switchStatus_OnValueChange(object sender, EventArgs e)
        {
            BUS.NhanVienBUS.INSTANCE.searchByKeyword(dtgvEmp, tbEmpSearch.Text, switchStatus.Value == true ? 1 : 0);
        }

        private void dtgvEmp_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnEmpSave.color = Color.FromArgb(192, 0, 0);
            btnEmpSave.colorActive = Color.Red;
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDataPosition.Text = cbPosition.Text;
            dtgvEmp.Rows[dtgvEmp.CurrentCell.RowIndex].Cells[10].Value = lbDataPosition.Text == "Quản lý" ? 2 : 3;
        }

        private void btnEmpChangePW_Click(object sender, EventArgs e)
        {
            try
            {
                new fmInputPW().ShowDialog();
                if (fmInputPW.npw == null) return;
                BUS.TaiKhoanBUS.INSTANCE.updatePW(dtgvEmp.CurrentRow.Cells[0].Value.ToString(), fmInputPW.opw, fmInputPW.npw);
                MessageBox.Show("Đổi mật khẩu thành công!", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgvEmp_CellClick(null, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
