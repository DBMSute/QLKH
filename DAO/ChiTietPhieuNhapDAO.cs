using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
   public class ChiTietPhieuNhapDAO
    {
        private static ChiTietPhieuNhapDAO instance;
        public static ChiTietPhieuNhapDAO INSTANCE
        {
            get
            {
                if (instance == null) return new ChiTietPhieuNhapDAO();
                return instance;
            }
        }

        public List<ChiTietPhieuNhap> loadData(string id)
        {
            List<ChiTietPhieuNhap> lCTPN = new List<ChiTietPhieuNhap>();
            string str = "SELECT * FROM dbo.VI_ChiTietPhieuNhap_LoadData WHERE idpn = '" + id + "'";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string idpn = item["idpn"].ToString();
                string tensp = item["tensp"].ToString();
                string tenncc = item["tenncc"].ToString();
                string tenlsp = item["tenlsp"].ToString();
                string tenkho = item["tenkho"].ToString();
                double dongia = Convert.ToDouble(item["dongia"]);
                int soluong = Convert.ToInt32(item["sl"]);
                double tong = Convert.ToDouble(item["tong"]);
                string dvtiente = item["dvitiente"].ToString();
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap(idpn, tensp, tenncc, tenlsp, tenkho, dongia, soluong, tong, dvtiente);
                lCTPN.Add(ctpn);
            }
            return lCTPN;
        }

        public List<ChiTietPhieuNhap> searchByKeyword(string keyword)
        {
            List<ChiTietPhieuNhap> lCTPN = new List<ChiTietPhieuNhap>();
            string str = "SELECT * FROM FN_ChiTietPhieuNhap_SearchByKeyword(N'" + keyword + "')";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string idpn = item["idpn"].ToString();
                string tensp = item["tensp"].ToString();
                string tenncc = item["tenncc"].ToString();
                string tenlsp = item["tenlsp"].ToString();
                string tenkho = item["tenkho"].ToString();
                double dongia = Convert.ToDouble(item["dongia"]);
                int soluong = Convert.ToInt32(item["sl"]);
                double tong = Convert.ToDouble(item["tong"]);
                string dvtiente = item["dvitiente"].ToString();
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap(idpn, tensp, tenncc, tenlsp, tenkho, dongia, soluong, tong, dvtiente);
                lCTPN.Add(ctpn);
            }
            return lCTPN;
        }

        public List<ChiTietPhieuNhap> searchByAmount(int num, int comp)
        {
            List<ChiTietPhieuNhap> lCTPN = new List<ChiTietPhieuNhap>();
            string str = "SELECT * FROM FN_ChiTietPhieuNhap_SearchByAmount(" + num + "," + comp + ")";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string idpn = item["idpn"].ToString();
                string tensp = item["tensp"].ToString();
                string tenncc = item["tenncc"].ToString();
                string tenlsp = item["tenlsp"].ToString();
                string tenkho = item["tenkho"].ToString();
                double dongia = Convert.ToDouble(item["dongia"]);
                int soluong = Convert.ToInt32(item["sl"]);
                double tong = Convert.ToDouble(item["tong"]);
                string dvtiente = item["dvitiente"].ToString();
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap(idpn, tensp, tenncc, tenlsp, tenkho, dongia, soluong, tong, dvtiente);
                lCTPN.Add(ctpn);
            }
            return lCTPN;
        }

        public List<ChiTietPhieuNhap> searchByPrice(int num)
        {
            List<ChiTietPhieuNhap> lCTPN = new List<ChiTietPhieuNhap>();
            string str = "SELECT * FROM FN_ChiTietPhieuNhap_SearchByPrice(" + num + ")";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string idpn = item["idpn"].ToString();
                string tensp = item["tensp"].ToString();
                string tenncc = item["tenncc"].ToString();
                string tenlsp = item["tenlsp"].ToString();
                string tenkho = item["tenkho"].ToString();
                double dongia = Convert.ToDouble(item["dongia"]);
                int soluong = Convert.ToInt32(item["sl"]);
                double tong = Convert.ToDouble(item["tong"]);
                string dvtiente = item["dvitiente"].ToString();
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap(idpn, tensp, tenncc, tenlsp, tenkho, dongia, soluong, tong, dvtiente);
                lCTPN.Add(ctpn);
            }
            return lCTPN;
        }

        public void saveInsert(ChiTietPhieuNhap ctpn, string idpn)
        {
            string str = "EXEC dbo.sp_Insert_CTPN @idpn = '" + ctpn.IDPN + "'," +
                         "@tensp = N'" + ctpn.TENSP + "'," +
                         "@tenloai = N'" + ctpn.TENLSP + "'," +
                         "@tenkho = N'" + ctpn.TENKHO + "'," +
                         "@tenncc = N'" + ctpn.TENNCC + "'," +
                         "@dongia = " + ctpn.DONGIA + "," +
                         "@sl = " + ctpn.SOLUONG + "," +
                         "@dvtiente = N'" + ctpn.DVTIENTE + "'";
            DataConn.INSTANCE.ExecuteQueryTable(str);
        }

        public List<ChiTietPhieuNhap> Insert(string id)
        {
            List<ChiTietPhieuNhap> lCTPN = new List<ChiTietPhieuNhap>();
            ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
            lCTPN.Add(ctpn);
            string str = "SELECT * FROM dbo.VI_ChiTietPhieuNhap_LoadData WHERE idpn = '" + id + "'";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string idpn = item["idpn"].ToString();
                string tensp = item["tensp"].ToString();
                string tenncc = item["tenncc"].ToString();
                string tenlsp = item["tenlsp"].ToString();
                string tenkho = item["tenkho"].ToString();
                double dongia = Convert.ToDouble(item["dongia"]);
                int soluong = Convert.ToInt32(item["sl"]);
                double tong = Convert.ToDouble(item["tong"]);
                string dvtiente = item["dvitiente"].ToString();
                ctpn = new ChiTietPhieuNhap(idpn, tensp, tenncc, tenlsp, tenkho, dongia, soluong, tong, dvtiente);
                lCTPN.Add(ctpn);
            }
            return lCTPN;
        }
    
        public void Delete(string idpn, string tensp)
        {
            string str = "EXEC dbo.sp_Delete_CTPN @idpn = '" + idpn + "'," +
                         "@tensp = N'" + tensp + "'";
            DataConn.INSTANCE.ExecuteQueryTable(str);
        }
    }
}
