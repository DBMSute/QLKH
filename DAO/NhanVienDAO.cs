using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null) return new NhanVienDAO();
                return instance;
            }
        }

        public List<TaiKhoan> loadData()
        {
            List<TaiKhoan> lTK = new List<TaiKhoan>();
            DateTime date = new DateTime();
            string str = "SELECT * FROM dbo.VI_TaiKhoan_LoadDataExceptAdmin"; //gọi Function
            DataTable data = DataConn.Instance.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string tentk = item["tentk"].ToString();
                string pw = BitConverter.ToString((byte[])item["passwd"]);
                byte[] avt;
                if (item["avt"].ToString() == "")
                    avt = null;
                else
                    avt = (byte[])item["avt"];
                string hovatendem = item["hovatendem"].ToString();
                string ten = item["ten"].ToString();
                date = (DateTime)item["ngaysinh"];
                string ngaysinh = date.ToString("d", new System.Globalization.CultureInfo("es-ES"));
                string diachi = item["diachi"].ToString();
                string lastlogin;
                if (item["lastlogin"].ToString() == "")
                    lastlogin = "";
                else
                {
                    date = (DateTime)item["lastlogin"];
                    lastlogin = date.ToString("G", new System.Globalization.CultureInfo("es-ES"));
                }
                date = (DateTime)item["createday"];
                string createdate = date.ToString("d", new System.Globalization.CultureInfo("es-ES"));
                int tinhtrang = Convert.ToInt32(item["tinhtrang"]);
                int pers = Convert.ToInt32(item["pers"]);
                TaiKhoan tk = new TaiKhoan(id, tentk, pw, avt, hovatendem, ten, ngaysinh, diachi, lastlogin, createdate, pers, tinhtrang);
                lTK.Add(tk);
            }
            return lTK;
        }

        public void Insert(TaiKhoan tk)
        {
            string tempAVT = tk.AVT == null ? "NULL" : tk.AVT.ToString();
            string str = "EXEC dbo.sp_Insert_TaiKhoan @tentk = '" + tk.TENTK + "'," +
                         "@pw = '" + tk.PASSWD + "'," +
                         "@avt = " + tempAVT + "," +
                         "@hovatendem = N'" + tk.HOVATENDEM + "'," +
                         "@ten = N'" + tk.TEN + "'," +
                         "@ngaysinh = '" + tk.NGAYSINH + "'," +
                         "@diachi = N'" + tk.DIACHI + "'," +
                         "@per = " + tk.PERS + "," +
                         "@tinhtrang = " + tk.TINHTRANG.ToString();
            DataConn.Instance.ExecuteQueryTable(str);
        }

        public void saveEdit(List<TaiKhoan> lNV)
        {
            for (int i = 0; i < lNV.Count; i++)
            {
                string str = "EXEC dbo.sp_Update_TaiKhoan_Info @id = '" + lNV[i].ID + "'," +
                             "@hovatendem = N'" + lNV[i].HOVATENDEM + "'," +
                             "@ten = N'" + lNV[i].TEN + "'," +
                             "@ngaysinh = '" + lNV[i].NGAYSINH + "'," +
                             "@diachi = N'" + lNV[i].DIACHI + "'," +
                             "@per = " + lNV[i].PERS + "," +
                             "@tinhtrang = " + lNV[i].TINHTRANG;
                DataConn.Instance.ExecuteQueryTable(str);
            }
        }

        public void Delete(string id)
        {
            string str = "EXEC dbo.sp_Delete_TaiKhoan @id = '" + id + "'";
            DataConn.Instance.ExecuteQueryTable(str);
        }

        public List<TaiKhoan> searchByKeyword(string keyword, int status)
        {
            DateTime date = new DateTime();
            List<TaiKhoan> lTK = new List<TaiKhoan>();
            string str = "SELECT * FROM dbo.FN_TaiKhoan_SearchByKeyword(N'" + keyword + "'," + status + ")";
            DataTable data = DataConn.Instance.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string tentk = item["tentk"].ToString();
                string pw = BitConverter.ToString((byte[])item["passwd"]);
                byte[] avt;
                if (item["avt"].ToString() == "")
                    avt = null;
                else
                    avt = (byte[])item["avt"];
                string hovatendem = item["hovatendem"].ToString();
                string ten = item["ten"].ToString();
                date = (DateTime)item["ngaysinh"];
                string ngaysinh = date.ToString("d", new System.Globalization.CultureInfo("es-ES"));
                string diachi = item["diachi"].ToString();
                string lastlogin;
                if (item["lastlogin"].ToString() == "")
                    lastlogin = "";
                else
                {
                    date = (DateTime)item["lastlogin"];
                    lastlogin = date.ToString("G", new System.Globalization.CultureInfo("es-ES"));
                }
                date = (DateTime)item["createday"];
                string createdate = date.ToString("d", new System.Globalization.CultureInfo("es-ES"));
                int tinhtrang = Convert.ToInt32(item["tinhtrang"]);
                int pers = Convert.ToInt32(item["pers"]);
                TaiKhoan tk = new TaiKhoan(id, tentk, pw, avt, hovatendem, ten, ngaysinh, diachi, lastlogin, createdate, pers, tinhtrang);
                lTK.Add(tk);
            }
            return lTK;
        }
    }
}
