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

        public fmKho()
        {
            InitializeComponent();
            Init();
            tmrClock.Start();
        }

        private void Init()
        {
            MNG.DataSource = BUS.KhoBUS.INSTANCE.loadDataMNG();
            BUS.KhoBUS.INSTANCE.loadData(dtgvKho);
            pnMidL2.Location = new Point(-1190, 110);
            TENLOAI.DataSource = BUS.LoaiSanPhamBUS.INSTANCE.loadDataTen();
            btnWareSave.color = btnWareSave.BackColor = Color.SeaGreen;
            btnWareSave.colorActive = Color.MediumSeaGreen;
        }

        private void loadDataWare(DataGridViewCellEventArgs e)
        {
            dtgvKho.Visible = false;
            dtgvKho.Size = new Size(0, 0);
            tmrSlide.Start();
            dtgvItem.Visible = true;
            lbKhoName.Text = dtgvKho.Rows[e.RowIndex].Cells[1].Value.ToString();
            idkho = dtgvKho.Rows[e.RowIndex].Cells[0].Value.ToString();
            BUS.SanPhamBUS.INSTANCE.loadData(dtgvItem, dtgvKho.Rows[e.RowIndex].Cells[0].Value.ToString());
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
            Application.Exit();
            //this.Hide();
            //new fmQuanLy().Show();
        }

        private void tmrSlide_Tick(object sender, EventArgs e)
        {
            int X, Y;
            if (pnMidL.Location.X <= -1190)
            {
                if (pnMidL2.Location.X == 10)
                {
                    dtgvItem.Size = new Size(1040, 430);                  
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
                    dtgvKho.Size = new Size(721, 430);
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
            dtgvItem.Visible = false;
            dtgvItem.Size = new Size(0, 0);
            tmrSlide2.Start();
            loadTongQuan(null);
            dtgvKho.Visible = true;
            BUS.KhoBUS.INSTANCE.loadData(dtgvKho);
            tbItemSearch.Text = "Tìm kiếm...";
            numItemSL.Value = 0;
        }

        private void dtgvWare_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                loadDataWare(e);
                btnItemSave.BackColor = Color.SeaGreen;
                loadTongQuan(e);
                return;
            }
            MessageBox.Show("Vui lòng chọn chính xác kho muốn xem!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void loadTongQuan(DataGridViewCellEventArgs e)
        {
            if(e == null)
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
            lbDataInfoTenKho.Text = dtgvKho[1, e.RowIndex].Value.ToString();
            lbDataInfoDiaChi.Text = dtgvKho[2, e.RowIndex].Value.ToString();
            lbDataInfoQuanLi.Text = dtgvKho[3, e.RowIndex].Value.ToString();
            lbDataInfoSLHang.Text = dtgvKho[5, e.RowIndex].Value.ToString();
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
                    BUS.KhoBUS.INSTANCE.loadData(dtgvKho);
                    MessageBox.Show("Đã lưu!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnWareSave.color = btnWareSave.BackColor = Color.SeaGreen;
                    btnWareSave.colorActive = Color.MediumSeaGreen;
                    flagSave = false;
                }
                else
                {
                    BUS.KhoBUS.INSTANCE.saveEdit(dtgvKho);
                    BUS.KhoBUS.INSTANCE.loadData(dtgvKho);
                    MessageBox.Show("Đã Sửa!", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnWareSave.color = btnWareSave.BackColor = Color.SeaGreen;
                    btnWareSave.colorActive = Color.MediumSeaGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.KhoBUS.INSTANCE.loadData(dtgvKho);
                btnWareSave.color = btnWareSave.BackColor = Color.SeaGreen;
                btnWareSave.colorActive = Color.MediumSeaGreen;
            }
            dtgvKho.CellDoubleClick += dtgvWare_CellDoubleClick;
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            BUS.SanPhamBUS.INSTANCE.Insert(dtgvItem, dtgvKho.Rows[dtgvKho.CurrentCell.RowIndex].Cells[0].Value.ToString());
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
            BUS.KhoBUS.INSTANCE.loadData(dtgvKho);
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
                MessageBox.Show(ex.Message);
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
                BUS.KhoBUS.INSTANCE.loadData(dtgvKho);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Contains("REFERENCE") == true ? "Trong kho còn sản phẩm!" : ex.Message, "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                BUS.KhoBUS.INSTANCE.loadData(dtgvKho);
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
                BUS.KhoBUS.INSTANCE.loadData(dtgvKho);
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
            new QuanLyKhoHang.Report.fmReport(dt, "DANH SÁCH SẢN PHẨM " +lbKhoName.Text.ToString().ToUpper(), "Poon Nguyễn").ShowDialog();
        }
    }
}
