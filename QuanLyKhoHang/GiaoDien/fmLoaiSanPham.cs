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
    public partial class fmLoaiSanPham : Form
    {
        private bool flagSave = false;
        public fmLoaiSanPham()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            try
            {
                tmrClock.Start();
                btnLSPSave.color = btnLSPSave.BackColor = Color.SeaGreen;
                btnLSPSave.colorActive = Color.MediumSeaGreen;
                BUS.LoaiSanPhamBUS.INSTANCE.loadData(dtgvLSP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLSPAdd_Click(object sender, EventArgs e)
        {
            BUS.LoaiSanPhamBUS.INSTANCE.Insert(dtgvLSP);
            dtgvLSP.CurrentCell = dtgvLSP[1, 0];
            flagSave = true;
        }

        private void btnLSPDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                BUS.LoaiSanPhamBUS.INSTANCE.Delete(dtgvLSP.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Đã xóa!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BUS.LoaiSanPhamBUS.INSTANCE.loadData(dtgvLSP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Contains("REFERENCE") == true ? "Loại này còn tồn tại sản phẩm!" : ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.LoaiSanPhamBUS.INSTANCE.loadData(dtgvLSP);
            }
        }

        private void btnLSPSave_Click(object sender, EventArgs e)
        {
            btnLSPSave.Focus();
            try
            {
                if (btnLSPSave.color == Color.SeaGreen)
                {
                    MessageBox.Show("Không có gì mới để lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (flagSave == true)
                {
                    BUS.LoaiSanPhamBUS.INSTANCE.saveInsert(dtgvLSP);
                    BUS.LoaiSanPhamBUS.INSTANCE.loadData(dtgvLSP);
                    MessageBox.Show("Đã lưu!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLSPSave.color = btnLSPSave.BackColor = Color.SeaGreen;
                    btnLSPSave.colorActive = Color.MediumSeaGreen;
                    flagSave = false;
                }
                else
                {
                    BUS.LoaiSanPhamBUS.INSTANCE.saveEdit(dtgvLSP);
                    BUS.LoaiSanPhamBUS.INSTANCE.loadData(dtgvLSP);
                    MessageBox.Show("Đã Sửa!", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLSPSave.color = btnLSPSave.BackColor = Color.SeaGreen;
                    btnLSPSave.colorActive = Color.MediumSeaGreen;
                }
            }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.LoaiSanPhamBUS.INSTANCE.loadData(dtgvLSP);
                btnLSPSave.color = btnLSPSave.BackColor = Color.SeaGreen;
                btnLSPSave.colorActive = Color.MediumSeaGreen;
            }
        }

        private void btnLSPPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã loại", typeof(string));
            dt.Columns.Add("Tên loại", typeof(string));
            dt.Columns.Add("Mô tả", typeof(string));
            foreach (DataGridViewRow row in dtgvLSP.Rows)
            {
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = row.Cells[0].Value.ToString();
                dr[1] = row.Cells[1].Value.ToString();
                dr[2] = row.Cells[2].Value.ToString();
                dt.Rows.Add(dr);
            }
            new QuanLyKhoHang.Report.fmReport(dt, "DANH SÁCH LOẠI SẢN PHẨM", "Poon Nguyễn").ShowDialog();
        }

        private void dtgvLSP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnLSPSave.color = btnLSPSave.BackColor = Color.FromArgb(192, 0, 0);
            btnLSPSave.colorActive = Color.Red;
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void tbLSPSearch_Leave(object sender, EventArgs e)
        {
            if (tbLSPSearch.Text == "")
            {
                tbLSPSearch.Text = "Tìm kiếm...";
                BUS.LoaiSanPhamBUS.INSTANCE.loadData(dtgvLSP);
            }
        }

        private void tbLSPSearch_Enter(object sender, EventArgs e)
        {
            if (tbLSPSearch.Text == "Tìm kiếm...")
                tbLSPSearch.Text = "";
        }

        private void tbLSPSearch_TextChanged(object sender, EventArgs e)
        {
            BUS.LoaiSanPhamBUS.INSTANCE.searchByKeyword(dtgvLSP, tbLSPSearch.Text.Trim());
        }
    }
}
