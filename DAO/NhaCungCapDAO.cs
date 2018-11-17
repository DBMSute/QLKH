using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
   public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;
        public static NhaCungCapDAO INSTANCE
        {
            get
            {
                if (instance == null) return new NhaCungCapDAO();
                return instance;
            }
        }
        public List<DTO.NhaCungCap> loadData()
        {
            List<DTO.NhaCungCap> lNcc = new List<DTO.NhaCungCap>();
            string str = "SELECT * FROM VI_NhaCungCap_LoadData";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string diaChi = item["dchi"].ToString();
                string sdt = item["sdt"].ToString();
                string qGia = item["qGia"].ToString();
                DTO.NhaCungCap ncc = new DTO.NhaCungCap(id, ten, diaChi, sdt, qGia);
                lNcc.Add(ncc);
            }
            return lNcc;
        }
        public List<DTO.NhaCungCap> searchByKeyword(string keyword)
        {
            List<DTO.NhaCungCap> lNcc = new List<DTO.NhaCungCap>();
            string str = "SELECT * FROM dbo.FN_NhaCungCap_SearchByKeyword(N'" + keyword + "')";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string diaChi = item["dchi"].ToString();
                string sdt = item["sdt"].ToString();
                string qGia = item["qGia"].ToString();
                DTO.NhaCungCap ncc = new DTO.NhaCungCap(id, ten, diaChi, sdt, qGia);
                lNcc.Add(ncc);
            }
            return lNcc;
        }
        public List<DTO.NhaCungCap> Insert()
        {
            List<DTO.NhaCungCap> lNcc = new List<DTO.NhaCungCap>();
            DTO.NhaCungCap n = new DTO.NhaCungCap();
            lNcc.Add(n);
            string str = "SELECT * FROM dbo.VI_NhaCungCap_LoadData";
            DataTable data = DataConn.INSTANCE.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string diaChi = item["dchi"].ToString();
                string sdt = item["sdt"].ToString();
                string qGia = item["qGia"].ToString();
                DTO.NhaCungCap ncc = new DTO.NhaCungCap(id, ten, diaChi, sdt, qGia);
                lNcc.Add(ncc);
            }
            return lNcc;
        }

        public void saveInsert(DTO.NhaCungCap ncc)
        {
            string str = "EXEC sp_Insert_NhaCungCap @ten=N'" + ncc.TEN + "'," +
                         "@dchi=N'" + ncc.DIACHI + "'," +
                         "@sdt='" + ncc.SODT + "'," +
                         "@qGia=N'" + ncc.QGIA + "'";
            DataConn.INSTANCE.ExecuteQueryTable(str);
        }

        public void saveEdit(List<DTO.NhaCungCap> lNcc)
        {
            for (int i = 0; i < lNcc.Count; i++)
            {
                string str = "EXEC sp_Update_NhaCungCap @id='" + lNcc[i].ID + "'," +
                             "@ten=N'" + lNcc[i].TEN + "'," +
                             "@dchi=N'" + lNcc[i].DIACHI + "'," +
                             "@sdt='" + lNcc[i].SODT + "'," +
                             "@qGia=N'" + lNcc[i].QGIA + "'";
                DataConn.INSTANCE.ExecuteQueryTable(str);
            }
        }

       public void Delete(string id)
       {
           string str = "EXEC sp_Delete_KhachHang  @id='" + id + "'";
           DataConn.INSTANCE.ExecuteQueryTable(str);
       }
    }
}
