using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
   public class ChiTietPhieuXuatDAO
    {
        private static ChiTietPhieuXuatDAO instance;
        public static ChiTietPhieuXuatDAO INSTANCE
        {
            get
            {
                if (instance == null) return new ChiTietPhieuXuatDAO();
                return instance;
            }
        }

        public List<ChiTietPhieuXuat> loadData(string idpx, string idEmp)
        {
            List<ChiTietPhieuXuat> lCTPX = new List<ChiTietPhieuXuat>();
            string str;
            if (idEmp == "TK000")
                str = "SELECT * FROM dbo.VI_ChiTietPhieuXuat_LoadData WHERE idpx = '" + idpx + "'";
            else
                str = "SELECT * FROM dbo.FN_ChiTietPhieuXuat_LoadDataByIdTk('" + idEmp + "') WHERE idpx ='" + idpx + "'";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string idpn = item["idpx"].ToString();
                string tensp = item["tensp"].ToString();
                string tenkh = item["tenkh"].ToString();
                string tenlsp = item["tenlsp"].ToString();
                string tenkho = item["tenkho"].ToString();
                double dongia = Convert.ToDouble(item["dongia"]);
                int soluong = Convert.ToInt32(item["sl"]);
                double tong = Convert.ToDouble(item["tongtien"]);
                string dvtiente = item["dvitiente"].ToString();
                ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat(idpn, tensp, tenkh, tenlsp, tenkho, dongia, soluong, tong, dvtiente);
                lCTPX.Add(ctpx);
            }
            return lCTPX;
        }

        public List<ChiTietPhieuXuat> searchByKeyword(string keyword)
        {
            List<ChiTietPhieuXuat> lCTPX = new List<ChiTietPhieuXuat>();
            string str = "SELECT * FROM FN_ChiTietPhieuXuat_SearchByKeyword(N'" + keyword + "')";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string idpn = item["idpx"].ToString();
                string tensp = item["tensp"].ToString();
                string tenkh = item["tenkh"].ToString();
                string tenlsp = item["tenlsp"].ToString();
                string tenkho = item["tenkho"].ToString();
                double dongia = Convert.ToDouble(item["dongia"]);
                int soluong = Convert.ToInt32(item["sl"]);
                double tong = Convert.ToDouble(item["tong"]);
                string dvtiente = item["dvitiente"].ToString();
                ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat(idpn, tensp, tenkh, tenlsp, tenkho, dongia, soluong, tong, dvtiente);
                lCTPX.Add(ctpx);
            }
            return lCTPX;
        }

        public List<ChiTietPhieuXuat> searchByAmount(int num, int comp)
        {
            List<ChiTietPhieuXuat> lCTPX = new List<ChiTietPhieuXuat>();
            string str = "SELECT * FROM FN_ChiTietPhieuXuat_SearchByAmount(" + num + "," + comp + ")";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string idpn = item["idpx"].ToString();
                string tensp = item["tensp"].ToString();
                string tenkh = item["tenkh"].ToString();
                string tenlsp = item["tenlsp"].ToString();
                string tenkho = item["tenkho"].ToString();
                double dongia = Convert.ToDouble(item["dongia"]);
                int soluong = Convert.ToInt32(item["sl"]);
                double tong = Convert.ToDouble(item["tong"]);
                string dvtiente = item["dvitiente"].ToString();
                ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat(idpn, tensp, tenkh, tenlsp, tenkho, dongia, soluong, tong, dvtiente);
                lCTPX.Add(ctpx);
            }
            return lCTPX;
        }

        public List<ChiTietPhieuXuat> searchByPrice(int num)
        {
            List<ChiTietPhieuXuat> lCTPX = new List<ChiTietPhieuXuat>();
            string str = "SELECT * FROM FN_ChiTietPhieuXuat_SearchByPrice(" + num + ")";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string idpn = item["idpx"].ToString();
                string tensp = item["tensp"].ToString();
                string tenkh = item["tenkh"].ToString();
                string tenlsp = item["tenlsp"].ToString();
                string tenkho = item["tenkho"].ToString();
                double dongia = Convert.ToDouble(item["dongia"]);
                int soluong = Convert.ToInt32(item["sl"]);
                double tong = Convert.ToDouble(item["tong"]);
                string dvtiente = item["dvitiente"].ToString();
                ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat(idpn, tensp, tenkh, tenlsp, tenkho, dongia, soluong, tong, dvtiente);
                lCTPX.Add(ctpx);
            }
            return lCTPX;
        }

        public void saveInsert(ChiTietPhieuXuat ctpx, string idpn)
        {
            string str = "EXEC dbo.sp_Insert_CTPX @idpx = '" + ctpx.IDPN + "'," +
                         "@tensp = N'" + ctpx.TENSP + "'," +
                         "@tenkho = N'" + ctpx.TENKHO + "'," +
                         "@tenkh = N'" + ctpx.TENKH + "'," +
                         "@sl = " + ctpx.SOLUONG;
            DataConn.INSTANCE.ExecuteQueryTable(str);
        }

        public List<ChiTietPhieuXuat> Insert(string id)
        {
            List<ChiTietPhieuXuat> lCTPX = new List<ChiTietPhieuXuat>();
            ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat();
            lCTPX.Add(ctpx);
            string str = "SELECT * FROM dbo.VI_ChiTietPhieuXuat_LoadData WHERE idpx = '" + id + "'";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string idpn = item["idpx"].ToString();
                string tensp = item["tensp"].ToString();
                string tenkh = item["tenkh"].ToString();
                string tenlsp = item["tenlsp"].ToString();
                string tenkho = item["tenkho"].ToString();
                double dongia = Convert.ToDouble(item["dongia"]);
                int soluong = Convert.ToInt32(item["sl"]);
                double tong = Convert.ToDouble(item["tongtien"]);
                string dvtiente = item["dvitiente"].ToString();
                ctpx = new ChiTietPhieuXuat(idpn, tensp, tenkh, tenlsp, tenkho, dongia, soluong, tong, dvtiente);
                lCTPX.Add(ctpx);
            }
            return lCTPX;
        }

        public void Delete(string idpn, string tensp)
        {
            string str = "EXEC dbo.sp_Delete_CTPX @idpx = '" + idpn + "'," +
                         "@tensp = N'" + tensp + "'";
            DataConn.INSTANCE.ExecuteQueryTable(str);
        }

    }
}
