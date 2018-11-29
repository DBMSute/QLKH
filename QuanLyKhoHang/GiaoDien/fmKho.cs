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
    public partial class fmKho : Form
    {
        public bool flagSave = false; //true - lưu add, false - lưu sửa
        private string idkho = null;
        private int cpbValue = 0;
        private int row = -1;

        public fmKho()
        {
            InitializeComponent();
            Init();
            tmrClock.Start();
            if (fmQuanLy.sID != "TK000") btnWareAdd.Enabled = false;
        }

        private void Init()
        {   
            MNG.DataSource = BUS.KhoBUS.INSTANCE.loadDataMNG();
            BUS.KhoBUS.INSTANCE.loadData(dtgvKho, QuanLyKhoHang.GiaoDien.fmQuanLy.sID);
            TENLOAI.DataSource = BUS.LoaiSanPhamBUS.INSTANCE.loadDataTen();
            btnWareSave.color = btnWareSave.BackColor = Color.SeaGreen;
            btnWareSave.colorActive = Color.MediumSeaGreen;
        }

        private void loadDataWare(DataGridViewCellEventArgs e)
        {
            tmrSlide.Start();
            lbKhoName.Text = dtgvKho.Rows[e.RowIndex].Cells[1].Value.ToString();
            idkho = dtgvKho.Rows[e.RowIndex].Cells[0].Value.ToString();
            cpbValue = Convert.ToInt32((int)dtgvKho.Rows[e.RowIndex].Cells[5].Value * 100 / (int)dtgvKho.Rows[e.RowIndex].Cells[4].Value);
        }
     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtgvKho.CellDoubleClick -= dtgvWare_CellDoubleClick;
            BUS.KhoBUS.INSTANCE.Insert(dtgvKho);
            dtgvKho.CurrentCell = dtgvKho[1, 0];
            flagSave = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new fmQuanLy().Show();
        }

        private void tmrSlide_Tick(object sender, EventArgs e)
        {
            if (pnMidR.Location.X < 1160)
            {
                pnMidR.Location = new Point(pnMidR.Location.X + 50, pnMidR.Location.Y);
                return;
            }
            if(dtgvKho.Location.X > -890)
            {
                dtgvKho.Location = new Point(dtgvKho.Location.X - 100, dtgvKho.Location.Y);
                return;
            }
            if (pnMidL.Size.Width <= 1040)
            {
                pnMidL.Size = new Size(pnMidL.Size.Width + 50, pnMidL.Size.Height);
                if(pnMidL.Size.Width == 1040)
                {
                    pnMidL.Size = new Size(1060, pnMidL.Size.Height);
                    return;
                }
                return;
            }
            if(lbListKho.Location.Y > -30)
            {
                lbListKho.Location = new Point(lbListKho.Location.X, lbListKho.Location.Y - 10);
                return;
            }
            if(dtgvItem.Location.X != 10)
            {
                dtgvItem.Location = new Point(dtgvItem.Location.X + 100, dtgvItem.Location.Y);
                return;
            }
            if (btnback.Location.Y < 10 )
            {
                btnback.Location = new Point(btnback.Location.X, btnback.Location.Y + 10);
                return;
            }
            if (lbKhoName.Location.Y < 10)
            {
                lbKhoName.Location = new Point(lbKhoName.Location.X, lbKhoName.Location.Y + 10);
                return;
            }
            if (tbItemSearch.Location.Y < 10)
            {
                tbItemSearch.Location = new Point(tbItemSearch.Location.X, tbItemSearch.Location.Y + 10);
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
            BUS.SanPhamBUS.INSTANCE.loadData(dtgvItem, idkho);
            loadTongQuan(row);
            tmrSlide.Stop();
        }

        private void tmrSlide2_Tick(object sender, EventArgs e)
        {

            if (dtgvItem.Location.X != -1090)
            {
                dtgvItem.Location = new Point(dtgvItem.Location.X - 100, dtgvItem.Location.Y);
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
            if (tbItemSearch.Location.Y > -40)
            {
                tbItemSearch.Location = new Point(tbItemSearch.Location.X, tbItemSearch.Location.Y - 10);
                return;
            }
            if (lbKhoName.Location.Y > -60)
            {
                lbKhoName.Location = new Point(lbKhoName.Location.X, lbKhoName.Location.Y - 10);
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
            if (dtgvKho.Location.X < 10)
            {
                dtgvKho.Location = new Point(dtgvKho.Location.X + 100, dtgvKho.Location.Y);
                return;
            }
            
            if (lbListKho.Location.Y < 10)
            {
                lbListKho.Location = new Point(lbListKho.Location.X, lbListKho.Location.Y + 10);
                return;
            }
            loadTongQuan(-1);
            BUS.KhoBUS.INSTANCE.loadData(dtgvKho, fmQuanLy.sID);
            tmrSlide2.Stop();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            tmrSlide2.Start();
            tbItemSearch.Text = "Tìm kiếm...";
            numItemSL.Value = 0;
        }

        private void dtgvWare_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                loadDataWare(e);
                btnItemSave.BackColor = Color.SeaGreen;
                row = e.RowIndex;
                return;
            }
            MessageBox.Show("Vui lòng chọn chính xác kho muốn xem!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void loadTongQuan(int row)
        {
            if (row < 0) 
            {
                cpbValue = 0;
                tmrCPB.Start();
                lbDataInfoTenKho.Text = "NULL";
                lbDataInfoDiaChi.Text = "NULL";
                lbDataInfoQuanLi.Text = "NULL";
                lbDataInfoSLHang.Text = "NULL";
                return;
            }
            updateCPBValue();
            lbDataInfoTenKho.Text = dtgvKho.Rows[row].Cells[1].Value.ToString();
            lbDataInfoDiaChi.Text = dtgvKho.Rows[row].Cells[2].Value.ToString();
            lbDataInfoQuanLi.Text = dtgvKho.Rows[row].Cells[3].Value.ToString();
            lbDataInfoSLHang.Text = dtgvKho.Rows[row].Cells[5].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnWareSave.Focus();
            try
            {
                if (btnWareSave.color == Color.SeaGreen)
                {
                    MessageBox.Show("Không có gì mới để lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (flagSave == true)
                {
                    BUS.KhoBUS.INSTANCE.saveInsert(dtgvKho);
                    BUS.KhoBUS.INSTANCE.loadData(dtgvKho, QuanLyKhoHang.GiaoDien.fmQuanLy.sID);
                    MessageBox.Show("Đã lưu!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnWareSave.color = btnWareSave.BackColor = Color.SeaGreen;
                    btnWareSave.colorActive = Color.MediumSeaGreen;
                    flagSave = false;
                }
                else
                {
                    BUS.KhoBUS.INSTANCE.saveEdit(dtgvKho);
                    BUS.KhoBUS.INSTANCE.loadData(dtgvKho, QuanLyKhoHang.GiaoDien.fmQuanLy.sID);
                    MessageBox.Show("Đã Sửa!", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnWareSave.color = btnWareSave.BackColor = Color.SeaGreen;
                    btnWareSave.colorActive = Color.MediumSeaGreen;
                    flagSave = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.KhoBUS.INSTANCE.loadData(dtgvKho, QuanLyKhoHang.GiaoDien.fmQuanLy.sID);
                btnWareSave.color = btnWareSave.BackColor = Color.SeaGreen;
                btnWareSave.colorActive = Color.MediumSeaGreen;
            }
            dtgvKho.CellDoubleClick += dtgvWare_CellDoubleClick;
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            BUS.SanPhamBUS.INSTANCE.Insert(dtgvItem, idkho);
            dtgvItem.CurrentCell = dtgvItem[1, 0];
            flagSave = true;
        }

        private void btnItemSave_Click(object sender, EventArgs e)
        {
            btnItemSave.Focus();
            try
            {
                if (btnItemSave.BackColor == Color.SeaGreen)
                {
                    MessageBox.Show("Không có gì mới để lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (flagSave == true)
                {
                    BUS.SanPhamBUS.INSTANCE.saveInsert(dtgvItem, idkho);
                    BUS.SanPhamBUS.INSTANCE.loadData(dtgvItem, idkho);
                    MessageBox.Show("Đã lưu!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateCPBValue();
                    btnItemSave.BackColor = Color.SeaGreen;                 
                    flagSave = false;
                }
                else
                {
                    BUS.SanPhamBUS.INSTANCE.saveEdit(dtgvItem);
                    BUS.SanPhamBUS.INSTANCE.loadData(dtgvItem, idkho);
                    MessageBox.Show("Đã Sửa!", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnItemSave.BackColor = Color.SeaGreen;
                    updateCPBValue();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                BUS.SanPhamBUS.INSTANCE.loadData(dtgvItem, idkho);
                btnItemSave.BackColor = Color.SeaGreen;
            }
        }

        public void updateCPBValue()
        {
            BUS.KhoBUS.INSTANCE.loadData(dtgvKho, QuanLyKhoHang.GiaoDien.fmQuanLy.sID);
            foreach (DataGridViewRow dr in dtgvKho.Rows)
                if (dr.Cells[0].FormattedValue.ToString() == idkho)
                {
                    cpbValue = Convert.ToInt32(dr.Cells[5].Value) * 100 / Convert.ToInt32(dr.Cells[4].Value);
                    tmrCPB.Start();
                }
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                BUS.SanPhamBUS.INSTANCE.Delete(dtgvItem.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Đã xóa!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateCPBValue();
                BUS.SanPhamBUS.INSTANCE.loadData(dtgvItem, idkho);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa sản phẩm thất bại!\n" + ex.Message, "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.SanPhamBUS.INSTANCE.loadData(dtgvItem, idkho);
            }
        }

        private void tbItemSearch_TextChanged(object sender, EventArgs e)
        {
            BUS.SanPhamBUS.INSTANCE.searchByKeyword(dtgvItem, tbItemSearch.Text.Trim(), idkho);
        }

        private void tbItemSearch_Enter(object sender, EventArgs e)
        {
            if (tbItemSearch.Text == "Tìm kiếm...")
                tbItemSearch.Text = "";
        }

        private void tmrCPB_Tick(object sender, EventArgs e)
        {
            if (cpbSucChua.Value == cpbValue)
            {
                tmrCPB.Stop();
                return;
            }
            if (cpbSucChua.Value < cpbValue)
            {
                if (cpbSucChua.Value == 50)
                    cpbSucChua.ProgressColor = Color.Yellow;
                if (cpbSucChua.Value == 75)
                    cpbSucChua.ProgressColor = Color.Red;
                if (cpbSucChua.Value < 50)
                    cpbSucChua.ProgressColor = Color.SeaGreen;
                cpbSucChua.Value++;
                return;
            }
            if(cpbSucChua.Value > cpbValue)
            {
                if (cpbSucChua.Value == 50)
                    cpbSucChua.ProgressColor = Color.Yellow;
                if (cpbSucChua.Value == 75)
                    cpbSucChua.ProgressColor = Color.Red;
                if (cpbSucChua.Value < 50)
                    cpbSucChua.ProgressColor = Color.SeaGreen;
                cpbSucChua.Value--;
                return;
            }
        }

        private void numItemSL_ValueChanged(object sender, EventArgs e)
        {
            BUS.SanPhamBUS.INSTANCE.searchByNum(dtgvItem, (int)numItemSL.Value, switchItemOpe.Value, idkho);
        }

        private void switchItemOpe_Click(object sender, EventArgs e)
        {
            BUS.SanPhamBUS.INSTANCE.searchByNum(dtgvItem, (int)numItemSL.Value, switchItemOpe.Value, idkho);
        }

        private void tbWareSearch_TextChanged(object sender, EventArgs e)
        {
            BUS.KhoBUS.INSTANCE.searchByKeyword(dtgvKho, tbWareSearch.Text.Trim());
        }

        private void btnWareDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                BUS.KhoBUS.INSTANCE.Delete(dtgvKho.CurrentRow.Cells[0].Value.ToString());              
                MessageBox.Show("Đã xóa!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BUS.KhoBUS.INSTANCE.loadData(dtgvKho, QuanLyKhoHang.GiaoDien.fmQuanLy.sID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Contains("REFERENCE") == true ? "Trong kho còn sản phẩm!" : ex.Message, "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                BUS.KhoBUS.INSTANCE.loadData(dtgvKho, QuanLyKhoHang.GiaoDien.fmQuanLy.sID);
            }
        }

        private void btnWarePrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã kho", typeof(string));
            dt.Columns.Add("Tên kho", typeof(string));
            dt.Columns.Add("Địa chỉ", typeof(string));
            dt.Columns.Add("Quản lý", typeof(string));
            dt.Columns.Add("Sức chứa", typeof(string));
            dt.Columns.Add("Số lượng hàng", typeof(string));
            foreach (DataGridViewRow row in dtgvKho.Rows)
            {
                DataRow dr;
                dr = dt.NewRow();
                for(int i = 0; i < row.Cells.Count; i++)
                {
                    dr[i] = row.Cells[i].Value.ToString();
                }
                dt.Rows.Add(dr);
            }
            new QuanLyKhoHang.Report.fmReport(dt,"DANH SÁCH KHO HÀNG", "Poon Nguyễn").ShowDialog();
        }

        private void numWare_ValueChanged(object sender, EventArgs e)
        {
            BUS.KhoBUS.INSTANCE.searchByNum(dtgvKho, (int)numWare.Value, SwitchWareLonBe.Value, switchWareSucChuaSL.Value);
        }

        private void SwitchWareLonBe_Click(object sender, EventArgs e)
        {
            BUS.KhoBUS.INSTANCE.searchByNum(dtgvKho, (int)numWare.Value, SwitchWareLonBe.Value, switchWareSucChuaSL.Value);
        }

        private void switchWareSucChuaSL_Click(object sender, EventArgs e)
        {
            BUS.KhoBUS.INSTANCE.searchByNum(dtgvKho, (int)numWare.Value, SwitchWareLonBe.Value, switchWareSucChuaSL.Value);
        }

        private void tbWareSearch_Enter(object sender, EventArgs e)
        {
            if (tbWareSearch.Text == "Tìm kiếm...")
                tbWareSearch.Text = "";
        }

        private void tbWareSearch_Leave(object sender, EventArgs e)
        {
            if (tbWareSearch.Text == "")
            {
                tbWareSearch.Text = "Tìm kiếm...";
                BUS.KhoBUS.INSTANCE.loadData(dtgvKho, QuanLyKhoHang.GiaoDien.fmQuanLy.sID);
            }
        }

        private void tbItemSearch_Leave(object sender, EventArgs e)
        {
            if (tbItemSearch.Text == "")
            {
                tbItemSearch.Text = "Tìm kiếm...";
                BUS.SanPhamBUS.INSTANCE.loadData(dtgvItem, idkho);
            }
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void dtgvWare_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnWareSave.color = btnWareSave.BackColor = Color.FromArgb(192, 0, 0);
            btnWareSave.colorActive = Color.Red;
        }

        private void dtgvItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnItemSave.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void btnItemPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sản phẩm", typeof(string));
            dt.Columns.Add("Tên sản phẩm", typeof(string));
            dt.Columns.Add("Loại sản phẩm", typeof(string));
            dt.Columns.Add("Số lượng", typeof(string));
            dt.Columns.Add("Đơn giá", typeof(string));
            foreach (DataGridViewRow row in dtgvItem.Rows)
            {
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = row.Cells[0].Value.ToString();
                dr[1] = row.Cells[1].Value.ToString();
                dr[2] = row.Cells[2].Value.ToString();
                dr[3] = row.Cells[4].Value.ToString();
                dr[4] = row.Cells[6].Value.ToString() +" "+ row.Cells[5].Value.ToString();
                dt.Rows.Add(dr);
            }
            new QuanLyKhoHang.Report.fmReport(dt, "DANH SÁCH SẢN PHẨM " +lbKhoName.Text.ToString().ToUpper(), QuanLyKhoHang.GiaoDien.fmQuanLy.sName).ShowDialog();
        }
    }
}
