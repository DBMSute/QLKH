using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.GiaoDien
{
    public partial class fmPhieuXuat : Form
    {
        private bool flagSave = false;
        public static string tempCD = null;
        public fmPhieuXuat()
        {
            InitializeComponent();
            pnMidL2.Location = new Point(-1190, 110);
            Init();
            tmrClock.Start();
        }

        public void Init()
        {
            try
            {
                TENKHO.DataSource = BUS.KhoBUS.INSTANCE.loadDataTen();
                TENKH.DataSource = BUS.KhachHangBUS.INSTANCE.loadDataTen();
                TENSP.DataSource = BUS.SanPhamBUS.INSTANCE.loadDataTen();
                tmrClock.Start();
                BUS.PhieuXuatBUS.INSTANCE.loadData(dtgvPX);
                dtgvPX.CurrentCell = dtgvPX[0, 0];
                dtgvPX_CellClick(null, null);
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadDataCTPX(DataGridViewCellEventArgs e)
        {
            dtgvPX.Visible = false;
            dtgvPX.Size = new Size(0, 0);
            tmrSlide.Start();
            dtgvCTPX.Visible = true;
            lbPXName.Text = dtgvPX.Rows[e.RowIndex].Cells[0].Value.ToString();
            BUS.ChiTietPhieuXuatBUS.INSTANCE.loadData(dtgvCTPX, lbPXName.Text);
            flagSave = false;
            lbPX.Text = "Chi Tiết Phiếu Xuất";
            btnCPTXSave.BackColor = Color.SeaGreen;
            if (btnDone.Enabled == false)
            {
                dtgvCTPX.ReadOnly = true;
                btnCTPXAdd.Enabled = false;
                btnCTPXDelete.Enabled = false;
                btnCPTXSave.Enabled = false;
            }
            else
            {
                dtgvCTPX.ReadOnly = false;
                btnCTPXAdd.Enabled = true;
                btnCTPXDelete.Enabled = true;
                btnCPTXSave.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPXAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Mọi dữ liệu được tạo tự động.\nBạn có chắc muốn thêm phiếu nhập này?", "Thêm dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            BUS.PhieuXuatBUS.INSTANCE.Insert();
            BUS.PhieuXuatBUS.INSTANCE.loadData(dtgvPX);
            dtgvPX.CurrentCell = dtgvPX[0, Convert.ToInt32((dtgvPX.RowCount - 1).ToString())];
            dtgvPX_CellClick(null, null);
        }

        private void btnPXDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                BUS.PhieuXuatBUS.INSTANCE.Delete(dtgvPX.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Đã xóa!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BUS.PhieuXuatBUS.INSTANCE.loadData(dtgvPX);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.PhieuXuatBUS.INSTANCE.loadData(dtgvPX);
            }
        }

        private void btnPXReload_Click(object sender, EventArgs e)
        {
            BUS.PhieuXuatBUS.INSTANCE.loadData(dtgvPX);
            dtgvPX.CurrentCell = dtgvPX[0, 0];
            dtgvPX_CellClick(null, null);
        }

        private void btnPXPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã phiếu", typeof(string));
            dt.Columns.Add("Ngày tạo", typeof(string));
            dt.Columns.Add("Trạng thái", typeof(string));
            foreach (DataGridViewRow row in dtgvPX.Rows)
            {
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = row.Cells[0].Value.ToString();
                dr[1] = row.Cells[1].Value.ToString();
                dr[2] = row.Cells[2].Value.ToString() == "1" ? "Xong" : "Chưa thanh toán";
                dt.Rows.Add(dr);
            }
            new QuanLyKhoHang.Report.fmReport(dt, "DANH SÁCH PHIẾU XUẤT", "Poon Nguyễn").ShowDialog();
        }

        private void tbPXSearch_TextChanged(object sender, EventArgs e)
        {
            BUS.PhieuXuatBUS.INSTANCE.searchByKeyword(dtgvPX, tbPXSearch.Text.Trim());
        }

        private void switchStatus_OnValueChange(object sender, EventArgs e)
        {
            BUS.PhieuXuatBUS.INSTANCE.searchByStatus(dtgvPX, Convert.ToInt32(switchStatus.Value));
        }

        private void dtpkStart_ValueChanged(object sender, EventArgs e)
        {
            BUS.PhieuXuatBUS.INSTANCE.searchByBetweenDate(dtgvPX, dtpkStart.Value.ToString().Trim(), dtpkStart.Value.ToString().Trim());
        }

        private void dtpkFinish_ValueChanged(object sender, EventArgs e)
        {
            BUS.PhieuXuatBUS.INSTANCE.searchByBetweenDate(dtgvPX, dtpkStart.Value.ToString().Trim(), dtpkFinish.Value.ToString().Trim());
        }

        private void dtgvPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BUS.ChiTietPhieuXuatBUS.INSTANCE.loadData(dtgvCTPX, dtgvPX.CurrentRow.Cells[0].Value.ToString());
            loadTongQuan(dtgvCTPX);
            if (dtgvPX.CurrentRow.Cells[2].Value.ToString() == "1")
            {
                btnDone.Enabled = false;
                btnDone.BackColor = Color.Gray;
            }
            else
            {
                btnDone.Enabled = true;
                btnDone.BackColor = Color.SeaGreen;
            }
        }

        private void tbPXSearch_Enter(object sender, EventArgs e)
        {
            if (tbPXSearch.Text == "Tìm kiếm...")
                tbPXSearch.Text = "";
        }

        private void tbPXSearch_Leave(object sender, EventArgs e)
        {
            if (tbPXSearch.Text == "")
            {
                tbPXSearch.Text = "Tìm kiếm...";
                BUS.PhieuXuatBUS.INSTANCE.loadData(dtgvPX);
            }
        }

        private void tmrSlide2_Tick(object sender, EventArgs e)
        {
            int X, Y;
            if (pnMidL2.Location.X <= -1190)
            {
                if (pnMidL.Location.X == 10)
                {
                    dtgvPX.Size = new Size(721, 430);
                    tmrSlide2.Stop();
                    return;
                }
                X = pnMidL.Location.X;
                Y = pnMidL.Location.Y;
                pnMidL.Location = new Point(X + 200, Y);
                pnMidR.Location = new Point(pnMidR.Location.X - 100, pnMidR.Location.Y);
            }
            else
            {
                X = pnMidL2.Location.X;
                Y = pnMidL2.Location.Y;
                pnMidL2.Location = new Point(X - 200, Y);
            }
        }

        private void tmrSlide_Tick(object sender, EventArgs e)
        {
            int X, Y;
            if (pnMidL.Location.X <= -1190)
            {
                if (pnMidL2.Location.X == 10)
                {
                    dtgvCTPX.Size = new Size(1040, 430);
                    tmrSlide.Stop();
                    return;
                }
                X = pnMidL2.Location.X;
                Y = pnMidL2.Location.Y;
                pnMidL2.Location = new Point(X + 200, Y);
            }
            else
            {

                X = pnMidL.Location.X;
                Y = pnMidL.Location.Y;
                pnMidL.Location = new Point(X - 200, Y);
                pnMidR.Location = new Point(pnMidR.Location.X + 100, pnMidR.Location.Y);
            }
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCTPXAdd_Click(object sender, EventArgs e)
        {
            BUS.ChiTietPhieuXuatBUS.INSTANCE.Insert(dtgvCTPX, lbPXName.Text);
            dtgvCTPX.CurrentCell = dtgvCTPX[1, 0];
            flagSave = true;
        }

        private void btnCTPXDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                BUS.ChiTietPhieuXuatBUS.INSTANCE.Delete(lbPXName.Text, dtgvCTPX.CurrentRow.Cells[1].Value.ToString());
                MessageBox.Show("Đã xóa!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BUS.ChiTietPhieuXuatBUS.INSTANCE.loadData(dtgvCTPX, lbPXName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BUS.SanPhamBUS.INSTANCE.loadData(dtgvCTPX, lbPXName.Text);
            }
        }

        private void btnCPTXSave_Click(object sender, EventArgs e)
        {
            btnCPTXSave.Focus();
            try
            {
                if (btnCPTXSave.BackColor == Color.SeaGreen)
                {
                    MessageBox.Show("Không có gì mới để lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (flagSave == true)
                {
                    BUS.ChiTietPhieuXuatBUS.INSTANCE.saveInsert(dtgvCTPX, lbPXName.Text);
                    BUS.ChiTietPhieuXuatBUS.INSTANCE.loadData(dtgvCTPX, lbPXName.Text);
                    MessageBox.Show("Đã lưu!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCPTXSave.BackColor = Color.SeaGreen;
                }
                else
                {
                    MessageBox.Show("Sửa dữ liệu không khả dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BUS.ChiTietPhieuXuatBUS.INSTANCE.loadData(dtgvCTPX, lbPXName.Text);
                    btnCPTXSave.BackColor = Color.SeaGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Contains("Object reference") == true ? "Dữ liệu thêm vào không được rỗng!" : (
                    ex.Message.Contains("PRIMARY KEY") == true ? "Dữ liệu thêm vào đã tồn tại!" : ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtgvCTPX.CurrentCell = dtgvCTPX[1, 0];
                btnCPTXSave.BackColor = Color.SeaGreen;
            }
        }

        private void btnCTPXPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên sản phẩm", typeof(string));
            dt.Columns.Add("Kho", typeof(string));
            dt.Columns.Add("Khách hàng", typeof(string));
            dt.Columns.Add("Loại sản phẩm", typeof(string));
            dt.Columns.Add("Đơn giá", typeof(string));
            dt.Columns.Add("Số lượng", typeof(string));
            dt.Columns.Add("Tổng", typeof(string));
            foreach (DataGridViewRow row in dtgvCTPX.Rows)
            {
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = row.Cells[1].Value.ToString();
                dr[1] = row.Cells[4].Value.ToString();
                dr[2] = row.Cells[2].Value.ToString();
                dr[3] = row.Cells[3].Value.ToString();
                dr[4] = row.Cells[5].Value.ToString();
                dr[5] = row.Cells[6].Value.ToString();
                dr[6] = row.Cells[7].Value.ToString() + " " + row.Cells[8].Value.ToString();
                dt.Rows.Add(dr);
            }
            new QuanLyKhoHang.Report.fmReport(dt, "CHI TIẾT PHIẾU XUẤT " + lbPXName.Text.ToString(), "Poon Nguyễn").ShowDialog();
        }

        private void dtgvPX_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                loadDataCTPX(e);
                tempCD = dtgvPX.CurrentRow.Cells[1].Value.ToString();
                return;
            }
            MessageBox.Show("Vui lòng chọn chính xác phiếu xuất muốn xem!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            dtgvCTPX.Visible = false;
            dtgvCTPX.Size = new Size(0, 0);
            tmrSlide2.Start();
            dtgvPX.Visible = true;
            lbPX.Text = "Phiếu Xuất";
            Init();
        }

        private void loadTongQuan(DataGridView dgv)
        {

            double tongvnd = 0, tongusd = 0, tongeur = 0;
            int slKH = 0, slSP = 0, slKho = 0, slLSP = 0, tongSP = 0;

            tongvnd = dgv.Rows.Cast<DataGridViewRow>()
                .Where(dv => dv.Cells["DVTIENTE"].Value.ToString() == "VND")
                .Sum(s => Convert.ToInt32(s.Cells["TONG"].Value));
            tongusd = dgv.Rows.Cast<DataGridViewRow>()
                .Where(dv => dv.Cells["DVTIENTE"].Value.ToString() == "USD")
                .Sum(s => Convert.ToInt32(s.Cells["TONG"].Value));
            tongeur = dgv.Rows.Cast<DataGridViewRow>()
                .Where(dv => dv.Cells["DVTIENTE"].Value.ToString() == "EUR")
                .Sum(s => Convert.ToInt32(s.Cells["TONG"].Value));
            lbDataInfoTong.Text = tongvnd.ToString("C", CultureInfo.CreateSpecificCulture("vi-VN")) + " | " + tongusd.ToString("C", CultureInfo.CreateSpecificCulture("en-US")) + " | " + tongeur.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));

            tongSP = dgv.Rows.Cast<DataGridViewRow>()
                .Sum(s => Convert.ToInt32(s.Cells["SL"].Value));
            lbDataInfoSumSP.Text = tongSP.ToString();

            slKho = dgv.Rows.Cast<DataGridViewRow>()
                .GroupBy(k => k.Cells["TENKHO"].Value.ToString())
                .Count();
            lbDataInfoNumKho.Text = slKho.ToString();

            slKH = dgv.Rows.Cast<DataGridViewRow>()
                .GroupBy(k => k.Cells["TENKH"].Value.ToString())
                .Count();
            lbDataInfoNumKH.Text = slKH.ToString();

            slSP = dgv.Rows.Cast<DataGridViewRow>()
                .GroupBy(k => k.Cells["TENSP"].Value.ToString())
                .Count();
            lbDataInfoNumSP.Text = slSP.ToString();

            slLSP = dgv.Rows.Cast<DataGridViewRow>()
                .GroupBy(k => k.Cells["TENLSP"].Value.ToString())
                .Count();
            lbDataInfoNumLSP.Text = slLSP.ToString();

        }

        private void tbCTPXSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (switchItemPrice.Value == false)
                    BUS.ChiTietPhieuXuatBUS.INSTANCE.searchByKeyword(dtgvCTPX, tbCTPXSearch.Text);
                else
                    BUS.ChiTietPhieuXuatBUS.INSTANCE.searchByPrice(dtgvCTPX, tbCTPXSearch.Text != "" ? Convert.ToInt32(tbCTPXSearch.Text) : 0);
            }
            catch (Exception)
            {
                MessageBox.Show("Từ khóa tìm kiếm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void switchItemPrice_Click(object sender, EventArgs e)
        {
            
        }

        private void switchItemOpe_Click(object sender, EventArgs e)
        {

        }

        private void numItemSL_ValueChanged(object sender, EventArgs e)
        {
            BUS.ChiTietPhieuXuatBUS.INSTANCE.searchByAmount(dtgvCTPX, (int)numItemSL.Value, switchItemOpe.Value);
        }

        private void tbCTPXSearch_Enter(object sender, EventArgs e)
        {
            if (tbCTPXSearch.Text == "Tìm kiếm...")
                tbCTPXSearch.Text = "";
        }

        private void tbCTPXSearch_Leave(object sender, EventArgs e)
        {
            if (tbCTPXSearch.Text == "")
            {
                tbCTPXSearch.Text = "Tìm kiếm...";
                BUS.ChiTietPhieuXuatBUS.INSTANCE.loadData(dtgvCTPX, lbPXName.Text);
            }
        }

        private void dtgvCTPX_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnCPTXSave.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thanh toán phiếu xuất '" + dtgvPX.CurrentRow.Cells[0].Value.ToString() + "'?\n\n" +
                "Chú ý: Một khi đã thanh toán thành công thì không thể phục hồi!", "Thanh toán phiếu xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            BUS.PhieuXuatBUS.INSTANCE.saveEdit(dtgvPX.CurrentRow.Cells[0].Value.ToString(), 1);
            BUS.PhieuXuatBUS.INSTANCE.loadData(dtgvPX);
            dtgvPX.CurrentCell = dtgvPX[0, 0];
            dtgvPX_CellClick(null, null);
        }
    }
}
