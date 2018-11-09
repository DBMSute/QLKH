using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;
        public static SanPhamDAO Instace
        {
            get
            {
                if (instance == null) return new SanPhamDAO();
                return instance;
            }
        }

        public List<SanPham> loadData(string idkho)
        {
            List<SanPham> spDAO = new List<SanPham>();
            string str = "SELECT * FROM dbo.FN_Kho_GetItemByKho('" + idkho + "')";
            DataTable data =  DataConn.Instance.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string idloai = item["idloai"].ToString();
                string lsp = item["lsp"].ToString();
                string kho = item["kho"].ToString();
                int soluong = (int)item["soluong"];
                double dongia = Convert.ToDouble(item["dongia"]);
                string dvtiente = item["dvitiente"].ToString();
                string tinhtrang = (Convert.ToBoolean(item["tinhtrang"]) == true) ? "Còn hàng" : "Hết hàng";
                SanPham sp = new SanPham(id, ten, idloai, lsp, kho, soluong, dongia, dvtiente, tinhtrang);
                spDAO.Add(sp);
            }
            return spDAO;
        }

        public void Save(List<SanPham> lSanPham)
        {
            string str = "EXEC dbo.sp_Insert_SanPham @ten = N'" + lSanPham[0].TEN + "'," +
                         "@idloai = '" + lSanPham[0].IDLoai + "'," +
                         "@idkho = '" + lSanPham[0].IDKho + "'," +
                         "@sl = " + lSanPham[0].SOLUONG + "," +
                         "@dvtiente = N'" + lSanPham[0].DONVITINH + "'," +
                         "@dongia = " + lSanPham[0].DONGIA;
            DataConn.Instance.ExecuteQueryTable(str);
        }

        public List<SanPham> Insert(string idkho)
        {
            List<SanPham> spDAO = new List<SanPham>();
            SanPham s = new SanPham();
            spDAO.Add(s);
            string str = "SELECT * FROM dbo.FN_Kho_GetItemByKho('" + idkho + "')";
            DataTable data = DataConn.Instance.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string idloai = item["idloai"].ToString();
                string lsp = item["lsp"].ToString();
                string kho = item["kho"].ToString();
                int soluong = (int)item["soluong"];
                double dongia = Convert.ToDouble(item["dongia"]);
                string dvtiente = item["dvitiente"].ToString();
                string tinhtrang = (Convert.ToBoolean(item["tinhtrang"]) == true) ? "Còn hàng" : "Hết hàng";
                SanPham sp = new SanPham(id, ten, idloai, lsp, kho, soluong, dongia, dvtiente, tinhtrang);
                spDAO.Add(sp);
            }
            return spDAO;
        }

        public void SaveInsert(List<SanPham> lSanPham)
        {
            string str = "EXEC dbo.sp_Insert_SanPham @ten = N'" + lSanPham[0].TEN + "'," +
                         "@idloai = '" + lSanPham[0].IDLoai + "'," +
                         "@idkho = '" + lSanPham[0].IDKho + "'," +
                         "@sl = " + lSanPham[0].SOLUONG + "," +
                         "@dvtiente = N'" + lSanPham[0].DONVITINH + "'," +
                         "@dongia = " + lSanPham[0].DONGIA;
            DataConn.Instance.ExecuteQueryTable(str);
        }

        public void SaveEdit(List<SanPham> lSanPham)
        {
            for (int i = 0; i < lSanPham.Count; i++)
            {

                string str = "EXEC dbo.sp_Update_SanPham @id = '" + lSanPham[i].ID + "'," +
                             "@idloai = '" + lSanPham[i].IDLoai + "'," +
                             "@idkho = '" + lSanPham[i].IDKho + "'," +
                             "@sl = " + lSanPham[i].SOLUONG + "," +
                             "@dvtiente = N'" + lSanPham[i].DONVITINH + "'," +
                             "@dongia = " + lSanPham[i].DONGIA;
                DataConn.Instance.ExecuteQueryTable(str);
            }
        }
    }
}
