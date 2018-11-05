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
            List<KhachHang> lKh = new List<KhachHang>();
            string str = "select * from KhachHang";
            DataTable data = DataConn.Instance.ExecuteQuery(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string sdt = item["sdt"].ToString();
                string dChi = item["dchi"].ToString();
                KhachHang kh = new KhachHang(id, ten, sdt, dChi);
                lKh.Add(kh);
            }
            return lKh;
        }
        public List<KhachHang> Them()
        {
            List<KhachHang> lKh = new List<KhachHang>();
            KhachHang k = new KhachHang();
            lKh.Add(k);
            string str = "select * from KhachHang";
            DataTable data = DataConn.Instance.ExecuteQuery(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string sdt = item["sdt"].ToString();
                string dChi = item["dchi"].ToString();
                KhachHang kh = new KhachHang(id, ten, sdt, dChi);
                lKh.Add(kh);
            }
            return lKh;
        }
        public List<KhachHang> timKiem(string strTimKiem)
        {
            List<KhachHang> lKh = new List<KhachHang>();
            string str = "select * from KhachHang where id like N'%" + strTimKiem.Trim() + "%' or ten like N'%" + strTimKiem.Trim()
               + "%' or dchi like N'%" + strTimKiem.Trim() + "%'";
            DataTable data = DataConn.Instance.ExecuteQuery(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string sdt = item["sdt"].ToString();
                string dChi = item["dchi"].ToString();
                KhachHang kh = new KhachHang(id, ten, sdt, dChi);
                lKh.Add(kh);
            }
            return lKh;
        }
        public void LuuThem(List<KhachHang> lKh)
        {
            string str = "exec sp_Insert_KhachHang @ten=N'"+lKh[0].ten+"',@sdt='"+lKh[0].soDT+
                "',@dchi=N'"+lKh[0].diaChi+"'";
            DataConn.Instance.ExecuteQuery(str);
        }
        public void LuuSua(List<KhachHang> lKh)
        {
            for (int i = 0; i < lKh.Count; i++)
            {
                string str = "exec sp_Update_KhachHang @id='" + lKh[i].id + "',@ten=N'" + lKh[i].ten + "',@sdt='" + lKh[i].soDT +
                "',@dchi=N'" + lKh[i].diaChi + "'";
                DataConn.Instance.ExecuteQuery(str);
            }
        }
     
      public void Xoa(string id)
        {
            string str = "delete from  KhachHang where id='" + id + "'";
            DataConn.Instance.ExecuteQuery(str);
        }
    }
}
