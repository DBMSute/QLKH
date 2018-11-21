using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PhieuNhapBUS
    {
        private static PhieuNhapBUS instance;
        public static PhieuNhapBUS INSTANCE
        {
            get
            {
                if (instance == null) return new PhieuNhapBUS();
                return instance;
            }
        }

        public void loadData(DataGridView dgv)
        {
            dgv.DataSource = DAO.PhieuNhapDAO.INSTANCE.loadData();
        }

        public void searchByKeyword(DataGridView dgv, string keyword)
        {
            dgv.DataSource = DAO.PhieuNhapDAO.INSTANCE.searchByKeyword(keyword);
        }

        public void searchByStatus(DataGridView dgv, int status)
        {
            dgv.DataSource = DAO.PhieuNhapDAO.INSTANCE.searchByStatus(status);
        }

        public void searchByBetweenDate(DataGridView dgv, string start, string finish)
        {
            dgv.DataSource = DAO.PhieuNhapDAO.INSTANCE.searchByBetweenDate(start, finish);
        }

        public void Delete(string id)
        {
            DAO.PhieuNhapDAO.INSTANCE.Delete(id);
        }

        public void Insert()
        { 
            DAO.PhieuNhapDAO.INSTANCE.Insert();
        }

        public void saveEdit(string id, int trangthai)
        {      
            DAO.PhieuNhapDAO.INSTANCE.saveEdit(id, trangthai);
        }
    }
}
