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
            Init();
            tmrClock.Start();
        }

        public void Init()
        {
            try
            {
                TENKHO.DataSource = BUS.KhoBUS.INSTANCE.loadDataTen(fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
                TENKH.DataSource = BUS.KhachHangBUS.INSTANCE.loadDataTen();
                tmrClock.Start();
                BUS.PhieuXuatBUS.INSTANCE.loadData(dtgvPX, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
                dtgvPX.CurrentCell = dtgvPX[0, 0];
                dtgvPX_CellClick(null, null);
            }
            catch (Exception)
            {
            }
        }

        private void loadDataCTPX(DataGridViewCellEventArgs e)
        {
            tmrSlide.Start();
            lbPXName.Text = dtgvPX.Rows[e.RowIndex].Cells[0].Value.ToString();
            BUS.ChiTietPhieuXuatBUS.INSTANCE.loadData(dtgvCTPX, lbPXName.Text, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
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
            this.Close();
            new fmQuanLy().Show();
        }

        private void btnPXAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Mọi dữ liệu được tạo tự động.\nBạn có chắc muốn thêm phiếu nhập này?", "Thêm dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            BUS.PhieuXuatBUS.INSTANCE.Insert(fmQuanLy.sID);
            BUS.PhieuXuatBUS.INSTANCE.loadData(dtgvPX, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
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
                BUS.PhieuXuatBUS.INSTANCE.loadData(dtgvPX, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.PhieuXuatBUS.INSTANCE.loadData(dtgvPX, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            }
        }

        private void btnPXReload_Click(object sender, EventArgs e)
        {
            BUS.PhieuXuatBUS.INSTANCE.loadData(dtgvPX, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
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
            BUS.PhieuXuatBUS.INSTANCE.searchByKeyword(dtgvPX, tbPXSearch.Text.Trim(), fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
        }

        private void switchStatus_OnValueChange(object sender, EventArgs e)
        {
            BUS.PhieuXuatBUS.INSTANCE.searchByStatus(dtgvPX, Convert.ToInt32(switchStatus.Value), fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
        }

        private void dtpkStart_ValueChanged(object sender, EventArgs e)
        {
            BUS.PhieuXuatBUS.INSTANCE.searchByBetweenDate(dtgvPX, dtpkStart.Value.ToString().Trim(), dtpkStart.Value.ToString().Trim(), fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
        }

        private void dtpkFinish_ValueChanged(object sender, EventArgs e)
        {
            BUS.PhieuXuatBUS.INSTANCE.searchByBetweenDate(dtgvPX, dtpkStart.Value.ToString().Trim(), dtpkFinish.Value.ToString().Trim(), fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
        }

        private void dtgvPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BUS.ChiTietPhieuXuatBUS.INSTANCE.loadData(dtgvCTPX, dtgvPX.CurrentRow.Cells[0].Value.ToString(), fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
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
                BUS.PhieuXuatBUS.INSTANCE.loadData(dtgvPX, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            }
        }

        private void tmrSlide2_Tick(object sender, EventArgs e)
        {
            if (dtgvCTPX.Location.X != -1090)
            {
                dtgvCTPX.Location = new Point(dtgvCTPX.Location.X - 100, dtgvCTPX.Location.Y);
                return;
            }
            if (switchItemOpe.Location.Y > -40)
            {
                switchItemOpe.Location = new Point(switchItemOpe.Location.X, switchItemOpe.Location.Y - 10);
                return;
            }
            if (lbLonBe.Location.Y > -40)
            {
                lbLonBe.Location = new Point(lbLonBe.Location.X, lbLonBe.Location.Y - 10);
                return;
            }
            if (numItemSL.Location.Y > -40)
            {
                numItemSL.Location = new Point(numItemSL.Location.X, numItemSL.Location.Y - 10);
                return;
            }
            if (lbSL.Location.Y > -40)
            {
                lbSL.Location = new Point(lbSL.Location.X, lbSL.Location.Y - 10);
                return;
            }
            if (lbGiaTri.Location.Y > -40)
            {
                lbGiaTri.Location = new Point(lbGiaTri.Location.X, lbGiaTri.Location.Y - 10);
                return;
            }
            if (switchItemPrice.Location.Y > -30)
            {
                switchItemPrice.Location = new Point(switchItemPrice.Location.X, switchItemPrice.Location.Y - 10);
                return;
            }
            if (tbCTPXSearch.Location.Y > -40)
            {
                tbCTPXSearch.Location = new Point(tbCTPXSearch.Location.X, tbCTPXSearch.Location.Y - 10);
                return;
            }
            
            if (lbPXName.Location.Y > -60)
            {
                lbPXName.Location = new Point(lbPXName.Location.X, lbPXName.Location.Y - 10);
                return;
            }
            if (btnback.Location.Y > -40)
            {
                btnback.Location = new Point(btnback.Location.X, btnback.Location.Y - 10);
                return;
            }
            if (pnMidL.Size.Width > 740)
            {
                pnMidL.Size = new Size(pnMidL.Size.Width - 50, pnMidL.Size.Height);
                if (pnMidL.Size.Width == 760)
                {
                    pnMidL.Size = new Size(740, pnMidL.Size.Height);
                    return;
                }
                return;
            }

            if (pnMidR.Location.X > 760)
            {
                pnMidR.Location = new Point(pnMidR.Location.X - 50, pnMidR.Location.Y);
                return;
            }
            if (dtgvPX.Location.X < 10)
            {
                dtgvPX.Location = new Point(dtgvPX.Location.X + 100, dtgvPX.Location.Y);
                return;
            }

            if (lbListPX.Location.Y < 10)
            {
                lbListPX.Location = new Point(lbListPX.Location.X, lbListPX.Location.Y + 10);
                return;
            }
            if (btnDone.Location.Y < 10)
            {
                btnDone.Location = new Point(btnDone.Location.X, btnDone.Location.Y + 10);
                return;
            }
            BUS.PhieuXuatBUS.INSTANCE.loadData(dtgvPX, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            tmrSlide2.Stop();
            this.Enabled = true;
        }

        private void tmrSlide_Tick(object sender, EventArgs e)
        {
            if (pnMidR.Location.X < 1160)
            {
                pnMidR.Location = new Point(pnMidR.Location.X + 50, pnMidR.Location.Y);
                return;
            }
            if (dtgvPX.Location.X > -890)
            {
                dtgvPX.Location = new Point(dtgvPX.Location.X - 100, dtgvPX.Location.Y);
                return;
            }
            if (pnMidL.Size.Width <= 1040)
            {
                pnMidL.Size = new Size(pnMidL.Size.Width + 50, pnMidL.Size.Height);
                if (pnMidL.Size.Width == 1040)
                {
                    pnMidL.Size = new Size(1060, pnMidL.Size.Height);
                    return;
                }
                return;
            }
            if (lbListPX.Location.Y > -40)
            {
                lbListPX.Location = new Point(lbListPX.Location.X, lbListPX.Location.Y - 10);
                return;
            }
            if (btnDone.Location.Y > -40)
            {
                btnDone.Location = new Point(btnDone.Location.X, btnDone.Location.Y - 10);
                return;
            }
            if (dtgvCTPX.Location.X != 10)
            {
                dtgvCTPX.Location = new Point(dtgvCTPX.Location.X + 100, dtgvCTPX.Location.Y);
                return;
            }
            if (btnback.Location.Y < 10)
            {
                btnback.Location = new Point(btnback.Location.X, btnback.Location.Y + 10);
                return;
            }
            if (lbPXName.Location.Y < 10)
            {
                lbPXName.Location = new Point(lbPXName.Location.X, lbPXName.Location.Y + 10);
                return;
            }
            if (tbCTPXSearch.Location.Y < 10)
            {
                tbCTPXSearch.Location = new Point(tbCTPXSearch.Location.X, tbCTPXSearch.Location.Y + 10);
                return;
            }
            if (switchItemPrice.Location.Y < 30)
            {
                switchItemPrice.Location = new Point(switchItemPrice.Location.X, switchItemPrice.Location.Y + 10);
                return;
            }
            if (lbGiaTri.Location.Y < 10)
            {
                lbGiaTri.Location = new Point(lbGiaTri.Location.X, lbGiaTri.Location.Y + 10);
                return;
            }
            if (lbSL.Location.Y < 10)
            {
                lbSL.Location = new Point(lbSL.Location.X, lbSL.Location.Y + 10);
                return;
            }
            if (numItemSL.Location.Y < 10)
            {
                numItemSL.Location = new Point(numItemSL.Location.X, numItemSL.Location.Y + 10);
                return;
            }
            if (switchItemOpe.Location.Y < 30)
            {
                switchItemOpe.Location = new Point(switchItemOpe.Location.X, switchItemOpe.Location.Y + 10);
                return;
            }
            if (lbLonBe.Location.Y < 10)
            {
                lbLonBe.Location = new Point(lbLonBe.Location.X, lbLonBe.Location.Y + 10);
                return;
            }
            BUS.ChiTietPhieuXuatBUS.INSTANCE.loadData(dtgvCTPX, lbPXName.Text, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            tmrSlide.Stop();
            this.Enabled = true;
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
                BUS.ChiTietPhieuXuatBUS.INSTANCE.loadData(dtgvCTPX, lbPXName.Text, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
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
                    BUS.ChiTietPhieuXuatBUS.INSTANCE.loadData(dtgvCTPX, lbPXName.Text, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
                    MessageBox.Show("Đã lưu!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCPTXSave.BackColor = Color.SeaGreen;
                }
                else
                {
                    MessageBox.Show("Sửa dữ liệu không khả dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BUS.ChiTietPhieuXuatBUS.INSTANCE.loadData(dtgvCTPX, lbPXName.Text, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
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
                this.Enabled = false;
                loadDataCTPX(e);
                tempCD = dtgvPX.CurrentRow.Cells[1].Value.ToString();
                return;
            }
            MessageBox.Show("Vui lòng chọn chính xác phiếu xuất muốn xem!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            tmrSlide2.Start();
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
                    BUS.ChiTietPhieuXuatBUS.INSTANCE.searchByKeyword(dtgvCTPX, lbPXName.Text, tbCTPXSearch.Text, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
                else
                    BUS.ChiTietPhieuXuatBUS.INSTANCE.searchByPrice(dtgvCTPX, lbPXName.Text, tbCTPXSearch.Text != "" ? Convert.ToInt32(tbCTPXSearch.Text) : 0, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            }
            catch (Exception)
            {
                MessageBox.Show("Từ khóa tìm kiếm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void switchItemPrice_Click(object sender, EventArgs e)
        {
            if (switchItemPrice.Value == true)
                try
                {
                    int n = 0;
                    BUS.ChiTietPhieuXuatBUS.INSTANCE.searchByPrice(dtgvCTPX, lbPXName.Text, int.TryParse(tbCTPXSearch.Text, out n) ? n : throw new Exception(), fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
                }
                catch (Exception)
                {
                    MessageBox.Show("Từ khóa tìm kiếm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    switchItemPrice.Value = false;
                    tbCTPXSearch.Focus();
                }
        }

        private void switchItemOpe_Click(object sender, EventArgs e)
        {
            if(switchItemOpe.Value == true)
             BUS.ChiTietPhieuXuatBUS.INSTANCE.searchByAmount(dtgvCTPX, lbPXName.Text, (int)numItemSL.Value, switchItemOpe.Value, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
        }

        private void numItemSL_ValueChanged(object sender, EventArgs e)
        {
            BUS.ChiTietPhieuXuatBUS.INSTANCE.searchByAmount(dtgvCTPX, lbPXName.Text, (int)numItemSL.Value, switchItemOpe.Value, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
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
                BUS.ChiTietPhieuXuatBUS.INSTANCE.loadData(dtgvCTPX, lbPXName.Text, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
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
            BUS.PhieuXuatBUS.INSTANCE.loadData(dtgvPX, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            dtgvPX.CurrentCell = dtgvPX[0, 0];
            dtgvPX_CellClick(null, null);
        }

        private void dtgvCTPX_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgvCTPX.CurrentCell.ColumnIndex == 1 && btnDone.Enabled == true)
            { 
                new QuanLyKhoHang.GiaoDien.fmInputSanPham(dtgvCTPX.CurrentRow.Cells[4].Value.ToString()).ShowDialog();
                if (QuanLyKhoHang.GiaoDien.fmInputSanPham.sanpham == null) return;
                dtgvCTPX.CurrentCell.Value = QuanLyKhoHang.GiaoDien.fmInputSanPham.sanpham;
            }
        }
    }
}
