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
    public partial class fmNhaCC : Form
    {
        private bool flagSave = false;
        public fmNhaCC()
        {
            InitializeComponent();
            tmrClock.Start();
            BUS.NhaCungCapBUS.INSTANCE.loadData(dtgvSup);
            btnSupSave.color = btnSupSave.BackColor = Color.SeaGreen;
            btnSupSave.colorActive = Color.MediumSeaGreen;
        }

        private void btnSupAdd_Click(object sender, EventArgs e)
        {
            BUS.KhachHangBUS.INSTANCE.Insert(dtgvSup);
            dtgvSup.CurrentCell = dtgvSup[1, 0];
            flagSave = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSupDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                BUS.KhachHangBUS.INSTANCE.Delete(dtgvSup.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Đã xóa!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BUS.KhachHangBUS.INSTANCE.loadData(dtgvSup);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.KhachHangBUS.INSTANCE.loadData(dtgvSup);
            }
        }

        private void btnSupSave_Click(object sender, EventArgs e)
        {
            btnSupSave.Focus();
            try
            {
                if (btnSupSave.color == Color.SeaGreen)
                {
                    MessageBox.Show("Không có gì mới để lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (flagSave == true)
                {
                    BUS.KhachHangBUS.INSTANCE.saveInsert(dtgvSup);
                    BUS.KhachHangBUS.INSTANCE.loadData(dtgvSup);
                    MessageBox.Show("Đã lưu!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSupSave.color = dtgvSup.BackColor = Color.SeaGreen;
                    btnSupSave.colorActive = Color.MediumSeaGreen;
                    flagSave = false;
                }
                else
                {
                    BUS.KhachHangBUS.INSTANCE.saveEdit(dtgvSup);
                    BUS.KhachHangBUS.INSTANCE.loadData(dtgvSup);
                    MessageBox.Show("Đã Sửa!", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSupSave.color = btnSupSave.BackColor = Color.SeaGreen;
                    btnSupSave.colorActive = Color.MediumSeaGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.KhachHangBUS.INSTANCE.loadData(dtgvSup);
            }
        }

        private void btnSupPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhà CC", typeof(string));
            dt.Columns.Add("Tên nhà CC", typeof(string));
            dt.Columns.Add("Địa chỉ", typeof(string));
            dt.Columns.Add("Số điện thoại", typeof(string));
            dt.Columns.Add("Quốc gia", typeof(string));
            foreach (DataGridViewRow row in dtgvSup.Rows)
            {
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = row.Cells[0].Value.ToString();
                dr[1] = row.Cells[1].Value.ToString();
                dr[2] = row.Cells[2].Value.ToString();
                dr[3] = row.Cells[3].Value.ToString();
                dr[4] = row.Cells[4].Value.ToString();
                dt.Rows.Add(dr);
            }
            new QuanLyKhoHang.Report.fmReport(dt, "DANH SÁCH NHÀ CUNG CẤP", "Poon Nguyễn").ShowDialog();
        }

        private void dtgvSup_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSupSave.color = btnSupSave.BackColor = Color.FromArgb(192, 0, 0);
            btnSupSave.colorActive = Color.Red;
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void tbSupSearch_Enter(object sender, EventArgs e)
        {
            if (tbSupSearch.Text == "Tìm kiếm...")
                tbSupSearch.Text = "";
        }

        private void tbSupSearch_Leave(object sender, EventArgs e)
        {
            if (tbSupSearch.Text == "")
            {
                tbSupSearch.Text = "Tìm kiếm...";
                BUS.KhachHangBUS.INSTANCE.loadData(dtgvSup);
            }
        }

        private void tbSupSearch_TextChanged(object sender, EventArgs e)
        {
            BUS.NhaCungCapBUS.INSTANCE.searchByKeyword(dtgvSup, tbSupSearch.Text);
        }
    }
}
