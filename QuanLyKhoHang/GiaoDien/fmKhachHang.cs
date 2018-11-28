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
    public partial class fmKhachHang : Form
    {
        private static bool flagSave = false;
        public fmKhachHang()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            try
            {
                tmrClock.Start();
                btnCusSave.color = btnCusSave.BackColor = Color.SeaGreen;
                btnCusSave.colorActive = Color.MediumSeaGreen;
                BUS.KhachHangBUS.INSTANCE.loadData(dtgvCus);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new fmQuanLy().Show();
        }

        private void tbWareSearch_TextChanged(object sender, EventArgs e)
        {
            BUS.KhachHangBUS.INSTANCE.searchByKeyword(dtgvCus, tbCusSearch.Text.Trim());
        }

        private void tbCusSearch_Enter(object sender, EventArgs e)
        {
            if (tbCusSearch.Text == "Tìm kiếm...")
                tbCusSearch.Text = "";
        }

        private void tbCusSearch_Leave(object sender, EventArgs e)
        {
            if (tbCusSearch.Text == "")
            {
                tbCusSearch.Text = "Tìm kiếm...";
                BUS.KhachHangBUS.INSTANCE.loadData(dtgvCus);
            }
        }

        private void btnCusAdd_Click(object sender, EventArgs e)
        {
            BUS.KhachHangBUS.INSTANCE.Insert(dtgvCus);
            dtgvCus.CurrentCell = dtgvCus[1, 0];
            flagSave = true;
        }

        private void btnCusDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                BUS.KhachHangBUS.INSTANCE.Delete(dtgvCus.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Đã xóa!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BUS.KhachHangBUS.INSTANCE.loadData(dtgvCus);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                BUS.KhachHangBUS.INSTANCE.loadData(dtgvCus);
            }
        }

        private void btnCusSave_Click(object sender, EventArgs e)
        {
            btnCusSave.Focus();
            try
            {
                if (btnCusSave.color == Color.SeaGreen)
                {
                    MessageBox.Show("Không có gì mới để lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (flagSave == true)
                {
                    BUS.KhachHangBUS.INSTANCE.saveInsert(dtgvCus);
                    BUS.KhachHangBUS.INSTANCE.loadData(dtgvCus);
                    MessageBox.Show("Đã lưu!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCusSave.color = btnCusSave.BackColor = Color.SeaGreen;
                    btnCusSave.colorActive = Color.MediumSeaGreen;
                    flagSave = false;
                }
                else
                {
                    BUS.KhachHangBUS.INSTANCE.saveEdit(dtgvCus);
                    BUS.KhachHangBUS.INSTANCE.loadData(dtgvCus);
                    MessageBox.Show("Đã Sửa!", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCusSave.color = btnCusSave.BackColor = Color.SeaGreen;
                    btnCusSave.colorActive = Color.MediumSeaGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.KhachHangBUS.INSTANCE.loadData(dtgvCus);
                btnCusSave.color = btnCusSave.BackColor = Color.SeaGreen;
                btnCusSave.colorActive = Color.MediumSeaGreen;
            }
        }

        private void btnCusPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã khách hàng", typeof(string));
            dt.Columns.Add("Tên khách hàng", typeof(string));
            dt.Columns.Add("Số điện thoại", typeof(string));
            dt.Columns.Add("Địa chỉ", typeof(string));
            foreach (DataGridViewRow row in dtgvCus.Rows)
            {
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = row.Cells[0].Value.ToString();
                dr[1] = row.Cells[1].Value.ToString();
                dr[2] = row.Cells[2].Value.ToString();
                dr[3] = row.Cells[3].Value.ToString();
                dt.Rows.Add(dr);
            }
            new QuanLyKhoHang.Report.fmReport(dt, "DANH SÁCH KHÁCH HÀNG", "Poon Nguyễn").ShowDialog();
        }

        private void dtgvCus_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnCusSave.color = btnCusSave.BackColor = Color.FromArgb(192, 0, 0);
            btnCusSave.colorActive = Color.Red;
        }
    }
}
