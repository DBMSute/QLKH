using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
  public  class LoaiSanPhamDAO
    {
        private static LoaiSanPhamDAO instance;
        public static LoaiSanPhamDAO INSTANCE
        {
            get
            {
                if (instance == null) return new LoaiSanPhamDAO();
                return instance;
            }
        }

        public List<LoaiSanPham> loadData()
        {
            List<LoaiSanPham> lLoaiSP = new List<LoaiSanPham>();
            string str = "SELECT * FROM VI_LoaiSanPham_LoadData";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach(DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string mota = item["mota"].ToString();
                LoaiSanPham lsp = new LoaiSanPham(id, ten, mota);
                lLoaiSP.Add(lsp);
            }
            return lLoaiSP;
        }

        public List<LoaiSanPham> Insert()
        {
            List<LoaiSanPham> lLSP = new List<LoaiSanPham>();
            LoaiSanPham lsp = new LoaiSanPham();
            lLSP.Add(lsp);
            string str = "SELECT * FROM VI_LoaiSanPham_LoadData";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string mota = item["mota"].ToString();
                lsp = new LoaiSanPham(id, ten, mota);
                lLSP.Add(lsp);
            }
            return lLSP;
        }

        public List<LoaiSanPham> searchByKeyword(string keyword)
        {
            List<LoaiSanPham> lLSP = new List<LoaiSanPham>();
            string str = "SELECT * FROM dbo.FN_LoaiSanPham_SearchByKeyword(N'" + keyword + "')";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string mota = item["mota"].ToString();
                LoaiSanPham lsp = new LoaiSanPham(id, ten, mota);
                lLSP.Add(lsp);
            }
            return lLSP;
        }

        public void saveInsert(LoaiSanPham lsp)
        {
            string str = "EXEC dbo.sp_Insert_LoaiSanPham @ten = N'" + lsp.TEN + "'," +
                         "@mota = N'" + lsp.MOTA + "'";
            DataConn.INSTANCE.ExecuteQueryTable(str);
        }

        public void saveEdit(List<LoaiSanPham> lLSP)
        {
            for (int i = 0; i < lLSP.Count; i++)
            {
                string str = "EXEC dbo.sp_Update_LoaiSanPham @id = '" + lLSP[i].ID + "', " +
                             "@ten = N'" + lLSP[i].TEN + "'," +
                             "@mota = N'" + lLSP[i].MOTA + "'";
                DataConn.INSTANCE.ExecuteQueryTable(str);
            }
        }

        public void Delete(string id)
        {
            string str = "EXEC dbo.sp_Delete_LoaiSanPham @id = '" + id + "'";
            DataConn.INSTANCE.ExecuteQueryTable(str);
        }
    }
}
