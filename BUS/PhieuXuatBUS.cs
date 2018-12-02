using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PhieuXuatBUS
    {
        private static PhieuXuatBUS instance;
        public static PhieuXuatBUS INSTANCE
        {
            get
            {
                if (instance == null) return new PhieuXuatBUS();
                return instance;
            }
        }

        public void loadData(DataGridView dgv, string idEmp)
        {
            dgv.DataSource = DAO.PhieuXuatDAO.INSTANCE.loadData(idEmp);
        }

        public void searchByKeyword(DataGridView dgv, string keyword, string idEmp)
        {
            dgv.DataSource = DAO.PhieuXuatDAO.INSTANCE.searchByKeyword(keyword, idEmp);
        }

        public void searchByStatus(DataGridView dgv, int status, string idEmp)
        {
            dgv.DataSource = DAO.PhieuXuatDAO.INSTANCE.searchByStatus(status, idEmp);
        }

        public void searchByBetweenDate(DataGridView dgv, string start, string finish, string idEmp)
        {
            dgv.DataSource = DAO.PhieuXuatDAO.INSTANCE.searchByBetweenDate(start, finish, idEmp);
        }

        public void Delete(string id)
        {
            DAO.PhieuXuatDAO.INSTANCE.Delete(id);
        }

        public void Insert(string idEmp)
        {
            DAO.PhieuXuatDAO.INSTANCE.Insert(idEmp);
        }

        public void saveEdit(string id, int trangthai)
        {
            DAO.PhieuXuatDAO.INSTANCE.saveEdit(id, trangthai);
        }
    }
}
