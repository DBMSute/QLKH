using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace BUS
{
    public class SanPhamBUS
    {
        private static SanPhamBUS instance;
        public static SanPhamBUS Instance
        {
            get
            {
                if (instance == null) return new SanPhamBUS();
                return instance;
            }
        }

        public void loadData(DataGridView dgv, string id)
        {
            dgv.DataSource = DAO.SanPhamDAO.Instace.loadData(id);
        }

        public void Insert(DataGridView dgv, string id)
        {
            dgv.DataSource = DAO.SanPhamDAO.Instace.Insert(id);
        }

        public void saveInsert(DataGridView dgv, string idkho)
        {
            DTO.SanPham sp = new DTO.SanPham();
            sp = new DTO.SanPham(
                    dgv.Rows[0].Cells[1].Value.ToString().Trim(),
                    dgv.Rows[0].Cells[2].Value.ToString().Trim(),
                    idkho,
                    Convert.ToInt32(dgv.Rows[0].Cells[4].Value),
                    Convert.ToDouble(dgv.Rows[0].Cells[6].Value),
                    dgv.Rows[0].Cells[5].Value.ToString().Trim());

            DAO.SanPhamDAO.Instace.saveInsert(sp);
        }

        public void saveEdit(DataGridView dgv)
        {
            List<DTO.SanPham> lSanPham = new List<DTO.SanPham>();
            DTO.SanPham sp = new DTO.SanPham();

            foreach (DataGridViewRow dr in dgv.Rows)
            {
                sp = new DTO.SanPham(
                    dr.Cells[0].Value.ToString().Trim(),
                    dr.Cells[1].Value.ToString().Trim(),
                    dr.Cells[2].Value.ToString().Trim(),
                    dr.Cells[3].Value.ToString().Trim(),
                    Convert.ToInt32(dr.Cells[4].Value),
                    Convert.ToDouble(dr.Cells[6].Value),
                    dr.Cells[5].Value.ToString().Trim());
                lSanPham.Add(sp);
            }
            DAO.SanPhamDAO.Instace.saveEdit(lSanPham);
        }

        public void Delete(string id)
        {
            DAO.SanPhamDAO.Instace.Delete(id);
        }

        public void searchByKeyword(DataGridView dgv, string keyword, string idkho)
        {
            dgv.DataSource = DAO.SanPhamDAO.Instace.searchByKeyword(keyword, idkho);
        }

        public void searchByNum(DataGridView dgv, int num, bool comp, string idkho)
        {
            int compTemp = (comp == true) ? 1 : 0;
            dgv.DataSource = DAO.SanPhamDAO.Instace.searchByNum(num, compTemp, idkho);
        }
    }
}