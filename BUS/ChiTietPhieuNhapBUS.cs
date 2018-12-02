using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        private static ChiTietPhieuNhapBUS instance;
        public static ChiTietPhieuNhapBUS INSTANCE
        {
            get
            {
                if (instance == null) return new ChiTietPhieuNhapBUS();
                return instance;
            }
        }

        public void loadData(DataGridView dgv, string idpn, string idEmp)
        {
            dgv.DataSource = DAO.ChiTietPhieuNhapDAO.INSTANCE.loadData(idpn, idEmp);
        }

        public void saveInsert(DataGridView dgv, string idpn)
        {
            DTO.ChiTietPhieuNhap ctpn = new DTO.ChiTietPhieuNhap();
            ctpn = new DTO.ChiTietPhieuNhap(
                    idpn,
                    dgv.Rows[0].Cells[1].Value.ToString().Trim(),
                    dgv.Rows[0].Cells[3].Value.ToString().Trim(),
                    dgv.Rows[0].Cells[4].Value.ToString().Trim(),
                    dgv.Rows[0].Cells[2].Value.ToString().Trim(),
                    Convert.ToDouble(dgv.Rows[0].Cells[5].Value),
                    Convert.ToInt32(dgv.Rows[0].Cells[6].Value),
                    dgv.Rows[0].Cells[8].Value.ToString().Trim());
            DAO.ChiTietPhieuNhapDAO.INSTANCE.saveInsert(ctpn, idpn);
        }

        public void Insert(DataGridView dgv, string id)
        {
            dgv.DataSource = DAO.ChiTietPhieuNhapDAO.INSTANCE.Insert(id);
        }

        public void Delete(string idpn, string tensp)
        {
            DAO.ChiTietPhieuNhapDAO.INSTANCE.Delete(idpn, tensp);
        }

        public void searchByKeyword(DataGridView dgv, string idpn, string keyword, string idEmp)
        {
            dgv.DataSource = DAO.ChiTietPhieuNhapDAO.INSTANCE.searchByKeyword(idpn, keyword, idEmp);
        }

        public void searchByAmount(DataGridView dgv, string idpn, int num, bool comp, string idEmp)
        {
            int tempComp = comp == true ? 1 : 0;
            dgv.DataSource = DAO.ChiTietPhieuNhapDAO.INSTANCE.searchByAmount(idpn, num, tempComp, idEmp);
        }

        public void searchByPrice(DataGridView dgv, string idpn, int num, string idEmp)
        {
            dgv.DataSource = DAO.ChiTietPhieuNhapDAO.INSTANCE.searchByPrice(idpn, num, idEmp);
        }
    }
}
