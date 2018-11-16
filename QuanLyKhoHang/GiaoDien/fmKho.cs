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
        Bitmap bmp;

        public fmKho()
        {
            InitializeComponent();
            Init();
            tmrClock.Start();
        }

        private void Init()
        {
            MNG.DataSource = BUS.KhoBUS.Instance.loadDataMNG();
            BUS.KhoBUS.Instance.loadData(dtgvWare);
            pnMidL2.Location = new Point(-1190, 110);
            TENLOAI.DataSource = BUS.LoaiSanPhamBUS.Instance.loadDataTen();
            btnWareSave.color = btnWareSave.BackColor = Color.SeaGreen;
            btnWareSave.colorActive = Color.MediumSeaGreen;
        }

        private void loadDataWare(DataGridViewCellEventArgs e)
        {
            dtgvWare.Visible = false;
            dtgvWare.Size = new Size(0, 0);
            tmrSlide.Start();
            dtgvItem.Visible = true;
            lbKhoName.Text = dtgvWare.Rows[e.RowIndex].Cells[1].Value.ToString();
            idkho = dtgvWare.Rows[e.RowIndex].Cells[0].Value.ToString();
            BUS.SanPhamBUS.Instance.loadData(dtgvItem, dtgvWare.Rows[e.RowIndex].Cells[0].Value.ToString());
            cpbValue = Convert.ToInt32((int)dtgvWare.Rows[e.RowIndex].Cells[5].Value * 100 / (int)dtgvWare.Rows[e.RowIndex].Cells[4].Value);
        }
     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtgvWare.CellDoubleClick -= dtgvWare_CellDoubleClick;
            BUS.KhoBUS.Instance.Insert(dtgvWare);
            dtgvWare.CurrentCell = dtgvWare[1, 0];
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
                    dtgvWare.Size = new Size(721, 430);
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
            dtgvWare.Visible = true;
            BUS.KhoBUS.Instance.loadData(dtgvWare);
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
            lbDataInfoTenKho.Text = dtgvWare[1, e.RowIndex].Value.ToString();
            lbDataInfoDiaChi.Text = dtgvWare[2, e.RowIndex].Value.ToString();
            lbDataInfoQuanLi.Text = dtgvWare[3, e.RowIndex].Value.ToString();
            lbDataInfoSLHang.Text = dtgvWare[5, e.RowIndex].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnWareSave.Focus();
            try
            {
                if (flagSave == true)
                {
                    BUS.KhoBUS.Instance.saveInsert(dtgvWare);
                    BUS.KhoBUS.Instance.loadData(dtgvWare);
                    MessageBox.Show("Đã lưu!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnWareSave.color = btnWareSave.BackColor = Color.SeaGreen;
                    btnWareSave.colorActive = Color.MediumSeaGreen;
                    flagSave = false;
                }
                else
                {
                    BUS.KhoBUS.Instance.saveEdit(dtgvWare);
                    BUS.KhoBUS.Instance.loadData(dtgvWare);
                    MessageBox.Show("Đã Sửa!", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnWareSave.color = btnWareSave.BackColor = Color.SeaGreen;
                    btnWareSave.colorActive = Color.MediumSeaGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUS.KhoBUS.Instance.loadData(dtgvWare);
                btnWareSave.color = btnWareSave.BackColor = Color.SeaGreen;
                btnWareSave.colorActive = Color.MediumSeaGreen;
            }
            dtgvWare.CellDoubleClick += dtgvWare_CellDoubleClick;
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            BUS.SanPhamBUS.Instance.Insert(dtgvItem, dtgvWare.Rows[dtgvWare.CurrentCell.RowIndex].Cells[0].Value.ToString());
            dtgvItem.CurrentCell = dtgvItem[1, 0];
            flagSave = true;
        }

        private void btnItemSave_Click(object sender, EventArgs e)
        {
            btnItemSave.Focus();
            try
            {
                if (flagSave == true)
                {
                    BUS.SanPhamBUS.Instance.saveInsert(dtgvItem, idkho);
                    BUS.SanPhamBUS.Instance.loadData(dtgvItem, idkho);
                    MessageBox.Show("Đã lưu!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateCPBValue();
                    btnItemSave.BackColor = Color.SeaGreen;                 
                    flagSave = false;
                }
                else
                {
                    BUS.SanPhamBUS.Instance.saveEdit(dtgvItem);
                    BUS.SanPhamBUS.Instance.loadData(dtgvItem, idkho);
                    MessageBox.Show("Đã Sửa!", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnItemSave.BackColor = Color.SeaGreen;
                    updateCPBValue();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                BUS.SanPhamBUS.Instance.loadData(dtgvItem, idkho);
                btnItemSave.BackColor = Color.SeaGreen;
            }
        }

        public void updateCPBValue()
        {
            BUS.KhoBUS.Instance.loadData(dtgvWare);
            foreach (DataGridViewRow dr in dtgvWare.Rows)
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
                BUS.SanPhamBUS.Instance.Delete(dtgvItem.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Đã xóa!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateCPBValue();
                BUS.SanPhamBUS.Instance.loadData(dtgvItem, idkho);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BUS.SanPhamBUS.Instance.loadData(dtgvItem, idkho);
            }
        }

        private void tbItemSearch_TextChanged(object sender, EventArgs e)
        {
            BUS.SanPhamBUS.Instance.searchByKeyword(dtgvItem, tbItemSearch.Text.Trim(), idkho);
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
            BUS.SanPhamBUS.Instance.searchByNum(dtgvItem, (int)numItemSL.Value, switchItemOpe.Value, idkho);
        }

        private void switchItemOpe_Click(object sender, EventArgs e)
        {
            BUS.SanPhamBUS.Instance.searchByNum(dtgvItem, (int)numItemSL.Value, switchItemOpe.Value, idkho);
        }

        private void tbWareSearch_TextChanged(object sender, EventArgs e)
        {
            BUS.KhoBUS.Instance.searchByKeyword(dtgvWare, tbWareSearch.Text.Trim());
        }

        private void btnWareDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                BUS.KhoBUS.Instance.Delete(dtgvWare.CurrentRow.Cells[0].Value.ToString());              
                MessageBox.Show("Đã xóa!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BUS.KhoBUS.Instance.loadData(dtgvWare);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Contains("REFERENCE") == true ? "Trong kho còn sản phẩm" : ex.Message, "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                BUS.KhoBUS.Instance.loadData(dtgvWare);
            }
        }

        private void btnWarePrint_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(dtgvWare.Width, dtgvWare.Height);
            dtgvWare.DrawToBitmap(bmp, new Rectangle(0, 0, dtgvWare.Width, dtgvWare.Height));
            printWare.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1170);
            printPreviewDialog.ShowDialog();
        }

        private void numWare_ValueChanged(object sender, EventArgs e)
        {
            BUS.KhoBUS.Instance.searchByNum(dtgvWare, (int)numWare.Value, SwitchWareLonBe.Value, switchWareSucChuaSL.Value);
        }

        private void SwitchWareLonBe_Click(object sender, EventArgs e)
        {
            BUS.KhoBUS.Instance.searchByNum(dtgvWare, (int)numWare.Value, SwitchWareLonBe.Value, switchWareSucChuaSL.Value);
        }

        private void switchWareSucChuaSL_Click(object sender, EventArgs e)
        {
            BUS.KhoBUS.Instance.searchByNum(dtgvWare, (int)numWare.Value, SwitchWareLonBe.Value, switchWareSucChuaSL.Value);
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
                BUS.KhoBUS.Instance.loadData(dtgvWare);
            }
        }

        private void tbItemSearch_Leave(object sender, EventArgs e)
        {
            if (tbItemSearch.Text == "")
            {
                tbItemSearch.Text = "Tìm kiếm...";
                BUS.SanPhamBUS.Instance.loadData(dtgvItem, idkho);
            }
        }

        private void printWare_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(lbListKho.Text.ToUpper(), new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, (827 - lbListKho.Width) / 2, 100 );
            e.Graphics.DrawString("Thời gian: "+ DateTime.Now.ToString("d", new System.Globalization.CultureInfo("es-ES")), new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, (827 - dtgvWare.Width) / 2, 150);
            e.Graphics.DrawString("Người in: " + fmQuanLy.sName, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, ((827 - dtgvWare.Width) / 2) + 500, 150);
            e.Graphics.DrawImage(bmp, (827 - dtgvWare.Width) / 2, 300);
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
            btnWareSave.color = btnWareSave.BackColor = Color.FromArgb(192, 0, 0);
            btnWareSave.colorActive = Color.Red;
        }
    }
}
