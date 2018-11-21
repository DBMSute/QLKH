    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class NhaCungCapBUS
    {
        private static NhaCungCapBUS instance;
        public static NhaCungCapBUS INSTANCE
        {
            get
            {
                if (instance == null) return new NhaCungCapBUS();
                return instance;
            }
        }
        public void loadData(DataGridView dgv)
        {
            dgv.DataSource = DAO.NhaCungCapDAO.INSTANCE.loadData();
        }
        public void searchByKeyword(DataGridView dgv, string keyword)
        {
            dgv.DataSource = DAO.NhaCungCapDAO.INSTANCE.searchByKeyword(keyword);
        }

        public void Insert(DataGridView dgv)
        {
            dgv.DataSource = DAO.NhaCungCapDAO.INSTANCE.Insert();
        }
        public void saveInsert(DataGridView dgv)
        {
            DTO.NhaCungCap ncc = new DTO.NhaCungCap();
            ncc = new DTO.NhaCungCap(
                dgv.Rows[0].Cells[1].Value.ToString().Trim(),
                dgv.Rows[0].Cells[2].Value.ToString().Trim(),
                dgv.Rows[0].Cells[3].Value.ToString().Trim(),
                dgv.Rows[0].Cells[4].Value.ToString().Trim());
            DAO.NhaCungCapDAO.INSTANCE.saveInsert(ncc);
        }

        public void Delete(DataGridView dgv, string id)
        {
            DAO.NhaCungCapDAO.INSTANCE.Delete(id);
        }

        public void saveEdit(DataGridView dgv)
        {
            List<DTO.NhaCungCap> lncc = new List<DTO.NhaCungCap>();

            foreach (DataGridViewRow dr in dgv.Rows)
            {
                DTO.NhaCungCap ncc = new DTO.NhaCungCap(
                    dr.Cells[0].Value.ToString().Trim(), 
                    dr.Cells[1].Value.ToString().Trim(),
                    dr.Cells[2].Value.ToString().Trim(), 
                    dr.Cells[3].Value.ToString().Trim(), 
                    dr.Cells[4].Value.ToString().Trim());
                lncc.Add(ncc);
            }
            DAO.NhaCungCapDAO.INSTANCE.saveEdit(lncc);
        }

        public List<string> loadDataTen()
        {
            List<string> lten = new List<string>();
            foreach (DTO.NhaCungCap ncc in DAO.NhaCungCapDAO.INSTANCE.loadData())
            {
                lten.Add(ncc.TEN);
            }
            return lten;
        }
    }
}
