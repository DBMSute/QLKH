using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class ChiTietPhieuXuatBUS
    {
        private static ChiTietPhieuXuatBUS instance;
        public static ChiTietPhieuXuatBUS INSTANCE
        {
            get
            {
                if (instance == null) return new ChiTietPhieuXuatBUS();
                return instance;
            }
        }

        public void loadData(DataGridView dgv, string id)
        {
            dgv.DataSource = DAO.ChiTietPhieuXuatDAO.INSTANCE.loadData(id);
        }

        public void saveInsert(DataGridView dgv, string idpn)
        {
            DTO.ChiTietPhieuXuat ctpx = new DTO.ChiTietPhieuXuat();
            ctpx = new DTO.ChiTietPhieuXuat(
                    idpn,
                    dgv.Rows[0].Cells[1].Value.ToString().Trim(),
                    dgv.Rows[0].Cells[4].Value.ToString().Trim(),
                    dgv.Rows[0].Cells[2].Value.ToString().Trim(),
                    Convert.ToDouble(dgv.Rows[0].Cells[5].Value),
                    Convert.ToInt32(dgv.Rows[0].Cells[6].Value),
                    dgv.Rows[0].Cells[8].Value.ToString().Trim());
            DAO.ChiTietPhieuXuatDAO.INSTANCE.saveInsert(ctpx, idpn);
        }

        public void Insert(DataGridView dgv, string id)
        {
            dgv.DataSource = DAO.ChiTietPhieuXuatDAO.INSTANCE.Insert(id);
        }

        public void Delete(string idpn, string tensp)
        {
            DAO.ChiTietPhieuXuatDAO.INSTANCE.Delete(idpn, tensp);
        }

        public void searchByKeyword(DataGridView dgv, string keyword)
        {
            dgv.DataSource = DAO.ChiTietPhieuXuatDAO.INSTANCE.searchByKeyword(keyword);
        }

        public void searchByAmount(DataGridView dgv, int num, bool comp)
        {
            int tempComp = comp == true ? 1 : 0;
            dgv.DataSource = DAO.ChiTietPhieuXuatDAO.INSTANCE.searchByAmount(num, tempComp);
        }

        public void searchByPrice(DataGridView dgv, int num)
        {
            dgv.DataSource = DAO.ChiTietPhieuXuatDAO.INSTANCE.searchByPrice(num);
        }
    }
}
