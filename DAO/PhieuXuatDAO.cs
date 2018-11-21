using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
   public class PhieuXuatDAO
    {
        private static PhieuXuatDAO instance;
        public static PhieuXuatDAO INSTANCE
        {
            get
            {
                if (instance == null) return new PhieuXuatDAO();
                return instance;
            }
        }

        public List<PhieuXuat> loadData()
        {
            List<PhieuXuat> lPX = new List<PhieuXuat>();
            DateTime date = new DateTime();
            string str = "SELECT * FROM dbo.VI_PhieuXuat_LoadData";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                date = (DateTime)item["ngaygio"];
                string ngaygio = date.ToString("G", new System.Globalization.CultureInfo("es-ES"));
                int trangthai = Convert.ToInt32(item["trangthai"]);
                PhieuXuat px = new PhieuXuat(id, ngaygio, trangthai);
                lPX.Add(px);
            }
            return lPX;
        }

        public void Insert()
        {
            string str = "EXEC dbo.sp_Insert_PhieuXuat";
            DataConn.INSTANCE.ExecuteQueryTable(str);
        }

        public List<PhieuXuat> searchByKeyword(string keyword)
        {
            DateTime date = new DateTime();
            List<PhieuXuat> lPX = new List<PhieuXuat>();
            string str = "SELECT * FROM dbo.FN_PhieuXuat_SearchByKeyword(N'" + keyword + "')";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                date = (DateTime)item["ngaygio"];
                string ngaygio = date.ToString("G", new System.Globalization.CultureInfo("es-ES"));
                int trangthai = Convert.ToInt32(item["trangthai"]);
                PhieuXuat px = new PhieuXuat(id, ngaygio, trangthai);
                lPX.Add(px);
            }
            return lPX;
        }

        public List<PhieuXuat> searchByStatus(int status)
        {
            DateTime date = new DateTime();
            List<PhieuXuat> lPX = new List<PhieuXuat>();
            string str = "SELECT * FROM dbo.FN_PhieuXuat_SearchByStatus(" + status + ")";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                date = (DateTime)item["ngaygio"];
                string ngaygio = date.ToString("G", new System.Globalization.CultureInfo("es-ES"));
                int trangthai = Convert.ToInt32(item["trangthai"]);
                PhieuXuat px = new PhieuXuat(id, ngaygio, trangthai);
                lPX.Add(px);
            }
            return lPX;
        }

        public List<PhieuXuat> searchByBetweenDate(string start, string finish)
        {
            DateTime date = new DateTime();
            List<PhieuXuat> lPX = new List<PhieuXuat>();
            string str = "SELECT * FROM dbo.FN_PhieuXuat_SearchByBetweenDate('" + start + "', '" + finish + "')";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                date = (DateTime)item["ngaygio"];
                string ngaygio = date.ToString("G", new System.Globalization.CultureInfo("es-ES"));
                int trangthai = Convert.ToInt32(item["trangthai"]);
                PhieuXuat px = new PhieuXuat(id, ngaygio, trangthai);
                lPX.Add(px);
            }
            return lPX;
        }

        public void saveEdit(string id, int trangthai)
        {
            string str = "EXEC dbo.sp_Update_PhieuXuat @id = '" + id + "', " +
                         "@trangthai = " + trangthai;
            DataConn.INSTANCE.ExecuteQueryTable(str);
        }

        public void Delete(string id)
        {
            string str = "EXEC dbo.sp_Delete_PhieuXuat @id = '" + id + "'";
            DataConn.INSTANCE.ExecuteQueryTable(str);
        }
    }
}
