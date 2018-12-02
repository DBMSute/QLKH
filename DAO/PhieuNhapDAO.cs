using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class PhieuNhapDAO
    {
        private static PhieuNhapDAO instance;
        public static PhieuNhapDAO INSTANCE
        {
            get
            {
                if (instance == null) return new PhieuNhapDAO();
                return instance;
            }
        }

        public List<PhieuNhap> loadData(string idEmp)
        {
            List<PhieuNhap> lPN = new List<PhieuNhap>();
            DateTime date = new DateTime();
            string str;
            if (idEmp == "TK000")
                str = "SELECT * FROM dbo.VI_PhieuNhap_LoadData";
            else
                str = "SELECT * FROM dbo.FN_PhieuNhap_LoadDataByQuanLy('" + idEmp + "')";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                date = (DateTime)item["ngaygio"];
                string ngaygio = date.ToString("G", new System.Globalization.CultureInfo("es-ES"));
                int trangthai = Convert.ToInt32(item["trangthai"]);
                string taikhoan = item["taikhoan"].ToString();
                PhieuNhap pn = new PhieuNhap(id, ngaygio, trangthai, taikhoan);
                lPN.Add(pn);
            }
            return lPN;
        }

        public void Insert(string idEmp)
        {
            string str = "EXEC dbo.sp_Insert_PhieuNhap @idtk = '" + idEmp + "'";
            DataConn.INSTANCE.ExecuteQueryTable(str);
        }

        public List<PhieuNhap> searchByKeyword(string keyword, string idEmp)
        {
            DateTime date = new DateTime();
            List<PhieuNhap> lPN = new List<PhieuNhap>();
            string str = "SELECT * FROM dbo.FN_PhieuNhap_SearchByKeyword(N'" + keyword + "', '" + idEmp + "')";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                date = (DateTime)item["ngaygio"];
                string ngaygio = date.ToString("G", new System.Globalization.CultureInfo("es-ES"));
                int trangthai = Convert.ToInt32(item["trangthai"]);
                string taikhoan = item["taikhoan"].ToString();
                PhieuNhap pn = new PhieuNhap(id, ngaygio, trangthai, taikhoan);
                lPN.Add(pn);
            }
            return lPN;
        }

        public List<PhieuNhap> searchByStatus(int status, string idEmp)
        {
            DateTime date = new DateTime();
            List<PhieuNhap> lPN = new List<PhieuNhap>();
            string str = "SELECT * FROM dbo.FN_PhieuNhap_SearchByStatus(" + status + ", '" + idEmp + "')";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                date = (DateTime)item["ngaygio"];
                string ngaygio = date.ToString("G", new System.Globalization.CultureInfo("es-ES"));
                int trangthai = Convert.ToInt32(item["trangthai"]);
                string taikhoan = item["taikhoan"].ToString();
                PhieuNhap pn = new PhieuNhap(id, ngaygio, trangthai, taikhoan);
                lPN.Add(pn);
            }
            return lPN;
        }

        public List<PhieuNhap> searchByBetweenDate(string start, string finish, string idEmp)
        {
            DateTime date = new DateTime();
            List<PhieuNhap> lPN = new List<PhieuNhap>();
            string str = "SELECT * FROM dbo.FN_PhieuNhap_SearchByBetweenDate('" + start + "', '" + finish + "', '" + idEmp + "')";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                date = (DateTime)item["ngaygio"];
                string ngaygio = date.ToString("G", new System.Globalization.CultureInfo("es-ES"));
                int trangthai = Convert.ToInt32(item["trangthai"]);
                string taikhoan = item["taikhoan"].ToString();
                PhieuNhap pn = new PhieuNhap(id, ngaygio, trangthai, taikhoan);
                lPN.Add(pn);
            }
            return lPN;
        }

        public void saveEdit(string id, int trangthai)
        {
            string str = "EXEC dbo.sp_Update_PhieuNhap @id = '" + id + "', " +
                         "@trangthai = " + trangthai;
            DataConn.INSTANCE.ExecuteQueryTable(str);
        }

        public void Delete(string id)
        {
            string str = "EXEC dbo.sp_Delete_PhieuNhap @id = '" + id + "'";
            DataConn.INSTANCE.ExecuteQueryTable(str);
        }
    }
}
