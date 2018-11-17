using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<Kho> loadData()
        {
            List<Kho> lKho = new List<Kho>();
            string str = "SELECT * FROM dbo.VI_Kho_LoadData";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string diaChi = item["diachi"].ToString();
                string mng = item["manager"].ToString();
                int gioiHan = (int)item["gioihan"];
                int soLuongHang = (int)item["soluonghang"];
                Kho kh = new Kho(id, ten, diaChi, mng, gioiHan, soLuongHang);
                lKho.Add(kh);
            }
            return lKho;
        }
    }
}
