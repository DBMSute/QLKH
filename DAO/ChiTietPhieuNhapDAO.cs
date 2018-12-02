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

        public List<ChiTietPhieuNhap> loadData(string sidpn, string idEmp)
        {
            List<ChiTietPhieuNhap> lCTPN = new List<ChiTietPhieuNhap>();
            string str;
            if (idEmp == "TK000")
                str = "SELECT * FROM dbo.VI_ChiTietPhieuNhap_LoadData WHERE idpn = '" + sidpn + "'";
            else
                str = "SELECT * FROM dbo.FN_ChiTietPhieuNhap_LoadDataByIdTk('" + idEmp + "') WHERE idpn ='" + sidpn + "'";
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

        public List<ChiTietPhieuNhap> searchByKeyword(string id, string keyword, string idEmp)
        {
            List<ChiTietPhieuNhap> lCTPN = new List<ChiTietPhieuNhap>();
            string str = "SELECT * FROM FN_ChiTietPhieuNhap_SearchByKeyword('" + id + "', N'" + keyword + "', '" + idEmp + "')";
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

        public List<ChiTietPhieuNhap> searchByAmount(string id, int num, int comp, string idEmp)
        {
            List<ChiTietPhieuNhap> lCTPN = new List<ChiTietPhieuNhap>();
            string str = "SELECT * FROM FN_ChiTietPhieuNhap_SearchByAmount('" + id + "', " + num + "," + comp + ", '" + idEmp + "')";
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

        public List<ChiTietPhieuNhap> searchByPrice(string id, int num, string idEmp)
        {
            List<ChiTietPhieuNhap> lCTPN = new List<ChiTietPhieuNhap>();
            string str = "SELECT * FROM FN_ChiTietPhieuNhap_SearchByPrice('" + id + "'," + num + ",'" + idEmp + "')";
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
