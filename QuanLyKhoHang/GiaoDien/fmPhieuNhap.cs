using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QuanLyKhoHang.GiaoDien
{
    public partial class fmPhieuNhap : Form
    {
        private bool flagSave = false;
        public static string tempCD = null;
        public fmPhieuNhap()
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
                TENNCC.DataSource = BUS.NhaCungCapBUS.INSTANCE.loadDataTen();
                TENLSP.DataSource = BUS.LoaiSanPhamBUS.INSTANCE.loadDataTen();
                tmrClock.Start();
                BUS.PhieuNhapBUS.INSTANCE.loadData(dtgvPN, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
                if (dtgvPN.Rows.Count > 0)
                {
                    dtgvPN.CurrentCell = dtgvPN[0, 0];
                    dtgvPN_CellClick(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadDataCTPN(DataGridViewCellEventArgs e)
        {
            tmrSlide.Start();
            lbPNName.Text = dtgvPN.Rows[e.RowIndex].Cells[0].Value.ToString();
            BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, lbPNName.Text, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            flagSave = false;
            lbPN.Text = "Chi Tiết Phiếu Nhập";
            btnCPTNSave.BackColor = Color.SeaGreen;
            if (btnDone.Enabled == false)
            {
                dtgvCTPN.ReadOnly = true;
                btnCTPNAdd.Enabled = false;
                btnCTPNDelete.Enabled = false;
                btnCPTNSave.Enabled = false;
            }
            else
            {
                dtgvCTPN.ReadOnly = false;
                btnCTPNAdd.Enabled = true;
                btnCTPNDelete.Enabled = true;
                btnCPTNSave.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new fmQuanLy().Show();
        }

        private void btnPNAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Mọi dữ liệu được tạo tự động.\nBạn có chắc muốn thêm phiếu nhập này?", "Thêm dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            BUS.PhieuNhapBUS.INSTANCE.Insert(fmQuanLy.sID);
            BUS.PhieuNhapBUS.INSTANCE.loadData(dtgvPN, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            dtgvPN.CurrentCell = dtgvPN[0, Convert.ToInt32((dtgvPN.RowCount - 1).ToString())];
            dtgvPN_CellClick(null, null);
        }

        private void btnPNDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                BUS.PhieuNhapBUS.INSTANCE.Delete(dtgvPN.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Đã xóa!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BUS.PhieuNhapBUS.INSTANCE.loadData(dtgvPN, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.PhieuNhapBUS.INSTANCE.loadData(dtgvPN, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            }
        }

        private void btnPNPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã phiếu", typeof(string));
            dt.Columns.Add("Ngày tạo", typeof(string));
            dt.Columns.Add("Trạng thái", typeof(string));
            foreach (DataGridViewRow row in dtgvPN.Rows)
            {
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = row.Cells[0].Value.ToString();
                dr[1] = row.Cells[1].Value.ToString();
                dr[2] = row.Cells[2].Value.ToString() == "1" ? "Xong" : "Chưa thanh toán";
                dt.Rows.Add(dr);
            }
            new QuanLyKhoHang.Report.fmReport(dt, "DANH SÁCH PHIẾU NHẬP", "Poon Nguyễn").ShowDialog();
        }

        private void tbPNSearch_TextChanged(object sender, EventArgs e)
        {
            BUS.PhieuNhapBUS.INSTANCE.searchByKeyword(dtgvPN, tbPNSearch.Text.Trim(), fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
        }

        private void tbPNSearch_Enter(object sender, EventArgs e)
        {
            if (tbPNSearch.Text == "Tìm kiếm...")
                tbPNSearch.Text = "";
        }

        private void tbPNSearch_Leave(object sender, EventArgs e)
        {
            if (tbPNSearch.Text == "")
            {
                tbPNSearch.Text = "Tìm kiếm...";
                BUS.PhieuNhapBUS.INSTANCE.loadData(dtgvPN, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            }
        }

        private void switchStatus_OnValueChange(object sender, EventArgs e)
        {
            BUS.PhieuNhapBUS.INSTANCE.searchByStatus(dtgvPN, Convert.ToInt32(switchStatus.Value), fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
        }

        private void dtpkFinish_ValueChanged(object sender, EventArgs e)
        {
            BUS.PhieuNhapBUS.INSTANCE.searchByBetweenDate(dtgvPN, dtpkStart.Value.ToString().Trim(), dtpkFinish.Value.ToString().Trim(), fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
        }

        private void dtpkStart_ValueChanged(object sender, EventArgs e)
        {
            BUS.PhieuNhapBUS.INSTANCE.searchByBetweenDate(dtgvPN, dtpkStart.Value.ToString().Trim(), dtpkFinish.Value.ToString().Trim(), fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
        }

        private void dtgvPN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.Enabled = false;
                loadDataCTPN(e);
                tempCD = dtgvPN.CurrentRow.Cells[1].Value.ToString();
                return;
            }
            MessageBox.Show("Vui lòng chọn chính xác phiếu nhập muốn xem!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tmrSlide_Tick(object sender, EventArgs e)
        {
            if (pnMidR.Location.X < 1160)
            {
                pnMidR.Location = new Point(pnMidR.Location.X + 50, pnMidR.Location.Y);
                return;
            }
            if (dtgvPN.Location.X > -890)
            {
                dtgvPN.Location = new Point(dtgvPN.Location.X - 100, dtgvPN.Location.Y);
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
            if (lbListPN.Location.Y > -40)
            {
                lbListPN.Location = new Point(lbListPN.Location.X, lbListPN.Location.Y - 10);
                return;
            }
            if(btnDone.Location.Y > -40)
            {
                btnDone.Location = new Point(btnDone.Location.X, btnDone.Location.Y - 10);
                return;
            }
            if (dtgvCTPN.Location.X != 10)
            {
                dtgvCTPN.Location = new Point(dtgvCTPN.Location.X + 100, dtgvCTPN.Location.Y);
                return;
            }
            if (btnback.Location.Y < 10)
            {
                btnback.Location = new Point(btnback.Location.X, btnback.Location.Y + 10);
                return;
            }
            if (lbPNName.Location.Y < 10)
            {
                lbPNName.Location = new Point(lbPNName.Location.X, lbPNName.Location.Y + 10);
                return;
            }
            if (tbCTPNSearch.Location.Y < 10)
            {
                tbCTPNSearch.Location = new Point(tbCTPNSearch.Location.X, tbCTPNSearch.Location.Y + 10);
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
            BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, lbPNName.Text, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            tmrSlide.Stop();
            this.Enabled = true;
        }

        private void tmrSlide2_Tick(object sender, EventArgs e)
        {
            if (dtgvCTPN.Location.X != -1090)
            {
                dtgvCTPN.Location = new Point(dtgvCTPN.Location.X - 100, dtgvCTPN.Location.Y);
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
            if (tbCTPNSearch.Location.Y > -40)
            {
                tbCTPNSearch.Location = new Point(tbCTPNSearch.Location.X, tbCTPNSearch.Location.Y - 10);
                return;
            }
            
            if (lbPNName.Location.Y > -60)
            {
                lbPNName.Location = new Point(lbPNName.Location.X, lbPNName.Location.Y - 10);
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
            if (dtgvPN.Location.X < 10)
            {
                dtgvPN.Location = new Point(dtgvPN.Location.X + 100, dtgvPN.Location.Y);
                return;
            }

            if (lbListPN.Location.Y < 10)
            {
                lbListPN.Location = new Point(lbListPN.Location.X, lbListPN.Location.Y + 10);
                return;
            }
            if (btnDone.Location.Y < 10)
            {
                btnDone.Location = new Point(btnDone.Location.X, btnDone.Location.Y + 10);
                return;
            }
            BUS.PhieuNhapBUS.INSTANCE.loadData(dtgvPN, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            tmrSlide2.Stop();
            this.Enabled = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            tmrSlide2.Start();
            lbPN.Text = "Phiếu Nhập";
            Init();
        }

        private void btnCTPNAdd_Click(object sender, EventArgs e)
        {
            BUS.ChiTietPhieuNhapBUS.INSTANCE.Insert(dtgvCTPN, lbPNName.Text);
            dtgvCTPN.CurrentCell = dtgvCTPN[1, 0];
            flagSave = true;
        }

        private void btnCTPNDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                BUS.ChiTietPhieuNhapBUS.INSTANCE.Delete(lbPNName.Text, dtgvCTPN.CurrentRow.Cells[1].Value.ToString());
                MessageBox.Show("Đã xóa!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, lbPNName.Text, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
                loadTongQuan(dtgvCTPN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BUS.SanPhamBUS.INSTANCE.loadData(dtgvCTPN, lbPNName.Text);
            }
        }

        private void btnCPTNSave_Click(object sender, EventArgs e)
        {
            btnCPTNSave.Focus();
            try
            {
                if (btnCPTNSave.BackColor == Color.SeaGreen)
                {
                    MessageBox.Show("Không có gì mới để lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (flagSave == true)
                {
                    BUS.ChiTietPhieuNhapBUS.INSTANCE.saveInsert(dtgvCTPN, lbPNName.Text);
                    BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, lbPNName.Text, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
                    MessageBox.Show("Đã lưu!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCPTNSave.BackColor = Color.SeaGreen;
                    loadTongQuan(dtgvCTPN);
                }
                else
                {
                    MessageBox.Show("Sửa dữ liệu không khả dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, lbPNName.Text, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
                    btnCPTNSave.BackColor = Color.SeaGreen;
                    loadTongQuan(dtgvCTPN);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Contains("Object reference") == true ? "Dữ liệu thêm vào không được rỗng!" :(
                    ex.Message.Contains("PRIMARY KEY") == true ? "Dữ liệu thêm vào đã tồn tại!" : ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, lbPNName.Text, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
                btnCPTNSave.BackColor = Color.SeaGreen;
            }
        }

        private void btnCTPNPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên sản phẩm", typeof(string));
            dt.Columns.Add("Kho", typeof(string));
            dt.Columns.Add("Nhà cung cấp", typeof(string));
            dt.Columns.Add("Loại sản phẩm", typeof(string));
            dt.Columns.Add("Đơn giá", typeof(string));
            dt.Columns.Add("Số lượng", typeof(string));
            dt.Columns.Add("Tổng", typeof(string));
            foreach (DataGridViewRow row in dtgvCTPN.Rows)
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
            new QuanLyKhoHang.Report.fmReport(dt, "CHI TIẾT PHIẾU NHẬP " + lbPNName.Text.ToString(), "Poon Nguyễn").ShowDialog();
        }

        private void dtgvCTPN_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnCPTNSave.BackColor = Color.FromArgb(192, 0, 0);
            if (flagSave == true)
                if ((e.ColumnIndex == 5 && dtgvCTPN.CurrentRow.Cells[6].Value.ToString() != "0") || (e.ColumnIndex == 6 && dtgvCTPN.CurrentRow.Cells[5].Value.ToString() != "0"))
                    dtgvCTPN.CurrentRow.Cells[7].Value = Convert.ToInt32(dtgvCTPN.CurrentRow.Cells[6].Value.ToString()) * Convert.ToDecimal(dtgvCTPN.CurrentRow.Cells[5].Value.ToString());
        }

        private void dtgvPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, dtgvPN.CurrentRow.Cells[0].Value.ToString(), fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            loadTongQuan(dtgvCTPN);
            if (dtgvPN.CurrentRow.Cells[2].Value.ToString() == "1")
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

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thanh toán phiếu nhập '" + dtgvPN.CurrentRow.Cells[0].Value.ToString()+"' ?\n" +
                "Chú ý: Một khi đã thanh toán thành công thì không thể phục hồi!", "Thanh toán phiếu nhập", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            BUS.PhieuNhapBUS.INSTANCE.saveEdit(dtgvPN.CurrentRow.Cells[0].Value.ToString(), 1);
            BUS.PhieuNhapBUS.INSTANCE.loadData(dtgvPN, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            dtgvPN.CurrentCell = dtgvPN[0, 0];
            dtgvPN_CellClick(null, null);
        }

        private void btnPNReload_Click(object sender, EventArgs e)
        {
            BUS.PhieuNhapBUS.INSTANCE.loadData(dtgvPN, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            dtgvPN.CurrentCell = dtgvPN[0, 0];
            dtgvPN_CellClick(null, null);

        }

        private void loadTongQuan(DataGridView dgv) {

            double tongvnd = 0, tongusd = 0, tongeur = 0;
            int slNCC = 0, slSP = 0, slKho = 0, slLSP = 0, tongSP = 0;

            tongvnd = dgv.Rows.Cast<DataGridViewRow>()
                .Where(dv => dv.Cells["DVTIENTE"].Value.ToString() == "VND")
                .Sum(s => Convert.ToInt32(s.Cells["TONG"].Value));
            tongusd = dgv.Rows.Cast<DataGridViewRow>()
                .Where(dv => dv.Cells["DVTIENTE"].Value.ToString() == "USD")
                .Sum(s => Convert.ToInt32(s.Cells["TONG"].Value));
            tongeur = dgv.Rows.Cast<DataGridViewRow>()
                .Where(dv => dv.Cells["DVTIENTE"].Value.ToString() == "EUR")
                .Sum(s => Convert.ToInt32(s.Cells["TONG"].Value));
            lbDataInfoTong.Text = tongvnd.ToString("C",CultureInfo.CreateSpecificCulture("vi-VN")) + " | " + tongusd.ToString("C", CultureInfo.CreateSpecificCulture("en-US")) + " | " + tongeur.ToString("C",CultureInfo.CreateSpecificCulture("fr-FR"));

            tongSP = dgv.Rows.Cast<DataGridViewRow>()
                .Sum(s => Convert.ToInt32(s.Cells["SL"].Value));
            lbDataInfoSumSP.Text = tongSP.ToString();

            slKho = dgv.Rows.Cast<DataGridViewRow>()
                .GroupBy(k => k.Cells["TENKHO"].Value.ToString())
                .Count();
            lbDataInfoNumKho.Text = slKho.ToString();

            slNCC = dgv.Rows.Cast<DataGridViewRow>()
                .GroupBy(k => k.Cells["TENNCC"].Value.ToString())
                .Count();
            lbDataInfoNumNCC.Text = slNCC.ToString();

            slSP = dgv.Rows.Cast<DataGridViewRow>()
                .GroupBy(k => k.Cells["TENSP"].Value.ToString())
                .Count();
            lbDataInfoNumSP.Text = slSP.ToString();

            slLSP = dgv.Rows.Cast<DataGridViewRow>()
                .GroupBy(k => k.Cells["TENLSP"].Value.ToString())
                .Count();
            lbDataInfoNumLSP.Text = slLSP.ToString();

        }

        private void tbCTPNSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (switchItemPrice.Value == false)
                    BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, lbPNName.Text, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
                else
                    BUS.ChiTietPhieuNhapBUS.INSTANCE.searchByPrice(dtgvCTPN, lbPNName.Text, tbCTPNSearch.Text != "" ? Convert.ToInt32(tbCTPNSearch.Text) : 0, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            }
            catch ( Exception)
            {
                MessageBox.Show("Từ khóa tìm kiếm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbCTPNSearch_Enter(object sender, EventArgs e)
        {
            if (tbCTPNSearch.Text == "Tìm kiếm...")
                tbCTPNSearch.Text = "";
        }

        private void tbCTPNSearch_Leave(object sender, EventArgs e)
        {
            if (tbCTPNSearch.Text == "")
            {
                tbCTPNSearch.Text = "Tìm kiếm...";
                BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, lbPNName.Text, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
            }
        }

        private void numItemSL_ValueChanged(object sender, EventArgs e)
        {
            BUS.ChiTietPhieuNhapBUS.INSTANCE.searchByAmount(dtgvCTPN, lbPNName.Text, (int)numItemSL.Value, switchItemOpe.Value, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void switchItemOpe_Click(object sender, EventArgs e)
        {
            if(switchItemOpe.Value == true)
            BUS.ChiTietPhieuNhapBUS.INSTANCE.searchByAmount(dtgvCTPN, lbPNName.Text, (int)numItemSL.Value, switchItemOpe.Value, fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
        }

        private void switchItemPrice_Click(object sender, EventArgs e)
        {
            if (switchItemPrice.Value == true)
                try
                {
                    int n = 0;
                    BUS.ChiTietPhieuNhapBUS.INSTANCE.searchByPrice(dtgvCTPN, lbPNName.Text, int.TryParse(tbCTPNSearch.Text, out n) ? n : throw new Exception(), fmQuanLy.sPosition == "Quản trị tối cao" || fmQuanLy.sPosition == "Quản lý" ? fmQuanLy.sID : fmQuanLy.sIDQuanLy);
                }
                catch (Exception)
                {
                    MessageBox.Show("Từ khóa tìm kiếm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    switchItemPrice.Value = false;
                    tbCTPNSearch.Focus();
                }
        }
    }
}
