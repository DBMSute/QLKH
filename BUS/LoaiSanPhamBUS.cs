using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class LoaiSanPhamBUS
    {
        private static LoaiSanPhamBUS instance;
        public static LoaiSanPhamBUS INSTANCE
        {
            get
            {
                if (instance == null) return new LoaiSanPhamBUS();
                return instance;
            }
        }

        public List<string> loadDataTen()
        {
            List<string> lten = new List<string>();
            foreach (DTO.LoaiSanPham lsp in DAO.LoaiSanPhamDAO.INSTANCE.loadData())
            {
                lten.Add(lsp.TEN);
            }
            return lten;
        }

        public void loadData(DataGridView dgv)
        {
            dgv.DataSource = DAO.LoaiSanPhamDAO.INSTANCE.loadData();
        }

        public void searchByKeyword(DataGridView dgv, string keyword)
        {
            dgv.DataSource = DAO.LoaiSanPhamDAO.INSTANCE.searchByKeyword(keyword);
        }

        public void Insert(DataGridView dgv)
        {
            dgv.DataSource = DAO.LoaiSanPhamDAO.INSTANCE.Insert();
        }

        public void Delete(string id)
        {
            DAO.LoaiSanPhamDAO.INSTANCE.Delete(id);
        }

        public void saveInsert(DataGridView dgv)
        {
            DTO.LoaiSanPham lsp = new DTO.LoaiSanPham();
            lsp = new DTO.LoaiSanPham(
                    dgv.Rows[0].Cells[1].Value.ToString().Trim(),
                    dgv.Rows[0].Cells[2].Value.ToString().Trim());
            DAO.LoaiSanPhamDAO.INSTANCE.saveInsert(lsp);
        }

        public void saveEdit(DataGridView dgv)
        {
            List<DTO.LoaiSanPham> lLSP = new List<DTO.LoaiSanPham>();
            DTO.LoaiSanPham lsp = new DTO.LoaiSanPham();

            foreach (DataGridViewRow dr in dgv.Rows)
            {
                lsp = new DTO.LoaiSanPham(
                    dr.Cells[0].Value.ToString().Trim(),
                    dr.Cells[1].Value.ToString().Trim(),
                    dr.Cells[2].Value.ToString().Trim());
                lLSP.Add(lsp);
            }
            DAO.LoaiSanPhamDAO.INSTANCE.saveEdit(lLSP);
        }
    }
}
