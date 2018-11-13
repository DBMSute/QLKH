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
        public static LoaiSanPhamDAO Instace
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
            DataTable data = DataConn.Instance.ExecuteQueryTable(str);
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
    }
}
