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
        public static SanPhamDAO INSTANCE
        {
            get
            {
                if (instance == null) return new SanPhamDAO();
                return instance;
            }
        }

        public List<SanPham> loadData(string idkho)
        {
            List<SanPham> lSanPham = new List<SanPham>();
            string str = "SELECT * FROM dbo.FN_Kho_GetItemByKho('" + idkho + "')";
            DataTable data =  DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string lsp = item["lsp"].ToString();
                string kho = item["kho"].ToString();
                int soluong = (int)item["soluong"];
                double dongia = Convert.ToDouble(item["dongia"]);
                string dvtiente = item["dvitiente"].ToString();
                string tinhtrang = (Convert.ToBoolean(item["tinhtrang"]) == true) ? "Còn hàng" : "Hết hàng";
                SanPham sp = new SanPham(id, ten, lsp, kho, soluong, dongia, dvtiente, tinhtrang);
                lSanPham.Add(sp);
            }
            return lSanPham;
        }

        public List<SanPham> loadData()
        {
            List<SanPham> lSanPham = new List<SanPham>();
            string str = "SELECT * FROM dbo.VI_SanPham_LoadData";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string lsp = item["lsp"].ToString();
                string kho = item["kho"].ToString();
                int soluong = (int)item["soluong"];
                double dongia = Convert.ToDouble(item["dongia"]);
                string dvtiente = item["dvitiente"].ToString();
                string tinhtrang = (Convert.ToBoolean(item["tinhtrang"]) == true) ? "Còn hàng" : "Hết hàng";
                SanPham sp = new SanPham(id, ten, lsp, kho, soluong, dongia, dvtiente, tinhtrang);
                lSanPham.Add(sp);
            }
            return lSanPham;
        }


        public List<SanPham> Insert(string idkho)
        {
            List<SanPham> lSanPham = new List<SanPham>();
            SanPham s = new SanPham();
            lSanPham.Add(s);
            string str = "SELECT * FROM dbo.FN_Kho_GetItemByKho('" + idkho + "')";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string lsp = item["lsp"].ToString();
                string kho = item["kho"].ToString();
                int soluong = (int)item["soluong"];
                double dongia = Convert.ToDouble(item["dongia"]);
                string dvtiente = item["dvitiente"].ToString();
                string tinhtrang = (Convert.ToBoolean(item["tinhtrang"]) == true) ? "Còn hàng" : "Hết hàng";
                SanPham sp = new SanPham(id, ten, lsp, kho, soluong, dongia, dvtiente, tinhtrang);
                lSanPham.Add(sp);
            }
            return lSanPham;
        }

        public void saveInsert(SanPham sp)
        {
            string str = "EXEC dbo.sp_Insert_SanPham @ten = N'" + sp.TEN + "'," +
                         "@tenloai = N'" + sp.TENLOAI + "'," +
                         "@idkho = '" + sp.IDKho + "'," +
                         "@sl = " + sp.SOLUONG + "," +
                         "@dvtiente = N'" + sp.DONVITINH + "'," +
                         "@dongia = " + sp.DONGIA;
            DataConn.INSTANCE.ExecuteQueryTable(str);
        }

        public void saveEdit(List<SanPham> lSanPham)
        {
            for (int i = 0; i < lSanPham.Count; i++)
            {
                string str = "EXEC dbo.sp_Update_SanPham " +
                             "@id = '" + lSanPham[i].ID + "'," +
                             "@ten = N'" + lSanPham[i].TEN + "'," +
                             "@tenloai = N'" + lSanPham[i].TENLOAI + "'," +
                             "@idkho = '" + lSanPham[i].IDKho + "'," +
                             "@sl = " + lSanPham[i].SOLUONG + "," +
                             "@dvtiente = N'" + lSanPham[i].DONVITINH + "'," +
                             "@dongia = " + lSanPham[i].DONGIA;
                DataConn.INSTANCE.ExecuteQueryTable(str);
            }
        }

        public void Delete(string id)
        {
            string str = "EXEC dbo.sp_Delete_SanPham @id = '" + id + "'";
            DataConn.INSTANCE.ExecuteQueryTable(str);
        }

        public List<SanPham> searchByKeyword(string keyword, string idkho)
        {
            List<SanPham> lSanPham = new List<SanPham>();
            string str = "SELECT * FROM dbo.FN_SanPham_SearchByKeyword(N'" + keyword + "', '" + idkho + "')";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string lsp = item["lsp"].ToString();
                string kho = item["kho"].ToString();
                int soluong = (int)item["soluong"];
                double dongia = Convert.ToDouble(item["dongia"]);
                string dvtiente = item["dvitiente"].ToString();
                string tinhtrang = (Convert.ToBoolean(item["tinhtrang"]) == true) ? "Còn hàng" : "Hết hàng";
                SanPham sp = new SanPham(id, ten, lsp, kho, soluong, dongia, dvtiente, tinhtrang);
                lSanPham.Add(sp);
            }
            return lSanPham;
        }

        public List<SanPham> searchByNum(int num, int comp, string idkho)
        {
            List<SanPham> lSanPham = new List<SanPham>();
            string str = "SELECT * FROM dbo.FN_SanPham_SearchByNum(" + num + ", " + comp + ", '" + idkho + "')";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string lsp = item["lsp"].ToString();
                string kho = item["kho"].ToString();
                int soluong = (int)item["soluong"];
                double dongia = Convert.ToDouble(item["dongia"]);
                string dvtiente = item["dvitiente"].ToString();
                string tinhtrang = (Convert.ToBoolean(item["tinhtrang"]) == true) ? "Còn hàng" : "Hết hàng";
                SanPham sp = new SanPham(id, ten, lsp, kho, soluong, dongia, dvtiente, tinhtrang);
                lSanPham.Add(sp);
            }
            return lSanPham;
        }
    }
}
