using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
  public  class KhachHangDAO
    {
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null) return new KhachHangDAO();
                return instance;
            }
        }

        public List<KhachHang>loadData()
        {
            List<KhachHang> lKH = new List<KhachHang>();
            string str = "SELECT * FROM VI_KhachHang_LoadData";
            DataTable data = DataConn.Instance.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string sdt = item["sdt"].ToString();
                string dChi = item["dchi"].ToString();
                KhachHang kh = new KhachHang(id, ten, sdt, dChi);
                lKH.Add(kh);
            }
            return lKH;
        }

        public List<KhachHang> Insert()
        {
            List<KhachHang> lKH = new List<KhachHang>();
            KhachHang kh = new KhachHang();
            lKH.Add(kh);
            string str = "SELECT * FROM VI_KhachHang_LoadData";
            DataTable data = DataConn.Instance.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string sdt = item["sdt"].ToString();
                string dChi = item["dchi"].ToString();
                kh = new KhachHang(id, ten, sdt, dChi);
                lKH.Add(kh);
            }
            return lKH;
        }

        public List<KhachHang> searchByKeyword(string keyword)
        {
            List<KhachHang> lKH = new List<KhachHang>();
            string str = "SELECT * FROM dbo.FN_KhachHang_SearchByKeyword(N'" + keyword + "')";
            DataTable data = DataConn.Instance.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string sdt = item["sdt"].ToString();
                string dChi = item["dchi"].ToString();
                KhachHang kh = new KhachHang(id, ten, sdt, dChi);
                lKH.Add(kh);
            }
            return lKH;
        }

        public void saveInsert(KhachHang kh)
        {
            string str = "EXEC dbo.sp_Insert_KhachHang @ten = N'" + kh.TEN + "'," +
                         "@sdt = '" + kh.SODT + "'," +
                         "@dchi = N'" + kh.DIACHI + "'";
            DataConn.Instance.ExecuteQueryTable(str);
        }

        public void saveEdit(List<KhachHang> lKH)
        {
            for (int i = 0; i < lKH.Count; i++)
            {
                string str = "EXEC dbo.sp_Update_KhachHang @id = '" + lKH[i].ID + "', " +
                             "@ten = N'" + lKH[i].TEN + "'," +
                             "@sdt = '" + lKH[i].SODT + "'," +
                             "@dchi = N'" + lKH[i].DIACHI + "'";
                DataConn.Instance.ExecuteQueryTable(str);
            }
        }

        public void Delete(string id)
        {
            string str = "EXEC dbo.sp_Delete_KhachHang @id = '" + id + "'";
            DataConn.Instance.ExecuteQueryTable(str);
        }
    }
}
