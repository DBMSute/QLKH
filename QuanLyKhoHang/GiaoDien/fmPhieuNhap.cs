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
            pnMidL2.Location = new Point(-1190, 110);            
            Init();
            tmrClock.Start();
        }

        public void Init()
        {
            try
            {
                TENKHO.DataSource = BUS.KhoBUS.INSTANCE.loadDataTen();
                TENNCC.DataSource = BUS.NhaCungCapBUS.INSTANCE.loadDataTen();
                TENSP.DataSource = BUS.SanPhamBUS.INSTANCE.loadDataTen();
                tmrClock.Start();
                BUS.PhieuNhapBUS.INSTANCE.loadData(dtgvPN);
                dtgvPN.CurrentCell = dtgvPN[0, 0];
                dtgvPN_CellClick(null, null);
            }
            catch (Exception ex)
            {   
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadDataCTPN(DataGridViewCellEventArgs e)
        {
            dtgvPN.Visible = false;
            dtgvPN.Size = new Size(0, 0);
            tmrSlide.Start();
            dtgvCTPN.Visible = true;
            lbPNName.Text = dtgvPN.Rows[e.RowIndex].Cells[0].Value.ToString();
            BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, lbPNName.Text);
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
            BUS.PhieuNhapBUS.INSTANCE.Insert();
            BUS.PhieuNhapBUS.INSTANCE.loadData(dtgvPN);
            dtgvPN.CurrentCell = dtgvPN[0, Convert.ToInt32((dtgvPN.RowCount-1).ToString())];
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
                BUS.PhieuNhapBUS.INSTANCE.loadData(dtgvPN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.PhieuNhapBUS.INSTANCE.loadData(dtgvPN);
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
            BUS.PhieuNhapBUS.INSTANCE.searchByKeyword(dtgvPN, tbPNSearch.Text.Trim());
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
                BUS.PhieuNhapBUS.INSTANCE.loadData(dtgvPN);
            }
        }

        private void switchStatus_OnValueChange(object sender, EventArgs e)
        {
            BUS.PhieuNhapBUS.INSTANCE.searchByStatus(dtgvPN, Convert.ToInt32(switchStatus.Value));
        }

        private void dtpkFinish_ValueChanged(object sender, EventArgs e)
        {
            BUS.PhieuNhapBUS.INSTANCE.searchByBetweenDate(dtgvPN, dtpkStart.Value.ToString().Trim(), dtpkFinish.Value.ToString().Trim());
        }

        private void dtpkStart_ValueChanged(object sender, EventArgs e)
        {
            BUS.PhieuNhapBUS.INSTANCE.searchByBetweenDate(dtgvPN, dtpkStart.Value.ToString().Trim(), dtpkFinish.Value.ToString().Trim());
        }

        private void dtgvPN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                loadDataCTPN(e);
                tempCD = dtgvPN.CurrentRow.Cells[1].Value.ToString();
                return;
            }
            MessageBox.Show("Vui lòng chọn chính xác phiếu nhập muốn xem!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tmrSlide_Tick(object sender, EventArgs e)
        {
            int X, Y;
            if (pnMidL.Location.X <= -1190)
            {
                if (pnMidL2.Location.X == 10)
                {
                    dtgvCTPN.Size = new Size(1040, 430);
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

        private void tmrSlide2_Tick(object sender, EventArgs e)
        {
            int X, Y;
            if (pnMidL2.Location.X <= -1190)
            {
                if (pnMidL.Location.X == 10)
                {
                    dtgvPN.Size = new Size(721, 430);
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

        private void btnback_Click(object sender, EventArgs e)
        {
            dtgvCTPN.Visible = false;
            dtgvCTPN.Size = new Size(0, 0);
            tmrSlide2.Start();
            dtgvPN.Visible = true;
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
                BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, lbPNName.Text);
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
                    BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, lbPNName.Text);
                    MessageBox.Show("Đã lưu!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCPTNSave.BackColor = Color.SeaGreen;
                }
                else
                {
                    MessageBox.Show("Sửa dữ liệu không khả dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, lbPNName.Text);
                    btnCPTNSave.BackColor = Color.SeaGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Contains("Object reference") == true ? "Dữ liệu thêm vào không được rỗng!" :(
                    ex.Message.Contains("PRIMARY KEY") == true ? "Dữ liệu thêm vào đã tồn tại!" : ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, lbPNName.Text);
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
        }

        private void dtgvPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, dtgvPN.CurrentRow.Cells[0].Value.ToString());
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
            BUS.PhieuNhapBUS.INSTANCE.loadData(dtgvPN);
            dtgvPN.CurrentCell = dtgvPN[0, 0];
            dtgvPN_CellClick(null, null);
        }

        private void btnPNReload_Click(object sender, EventArgs e)
        {
            BUS.PhieuNhapBUS.INSTANCE.loadData(dtgvPN);
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
                    BUS.ChiTietPhieuNhapBUS.INSTANCE.searchByKeyword(dtgvCTPN, tbCTPNSearch.Text);
                else
                    BUS.ChiTietPhieuNhapBUS.INSTANCE.searchByPrice(dtgvCTPN, tbCTPNSearch.Text != "" ? Convert.ToInt32(tbCTPNSearch.Text) : 0);
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
                BUS.ChiTietPhieuNhapBUS.INSTANCE.loadData(dtgvCTPN, lbPNName.Text);
            }
        }

        private void numItemSL_ValueChanged(object sender, EventArgs e)
        {
            BUS.ChiTietPhieuNhapBUS.INSTANCE.searchByAmount(dtgvCTPN, (int)numItemSL.Value, switchItemOpe.Value);
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
