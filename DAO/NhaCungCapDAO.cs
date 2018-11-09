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
        public static NhaCungCapDAO Instance
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
            string str = "select * from VI_NhaCungCap_LoadData";
            DataTable data = DataConn.Instance.ExecuteQueryTable(str);
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
        public List<DTO.NhaCungCap> timKiem(string strTimKiem)
        {
            List<DTO.NhaCungCap> lNcc = new List<DTO.NhaCungCap>();
            string str = "select * from NhaCungCap where id like N'%" + strTimKiem.Trim() + "%' or ten like N'%" + strTimKiem.Trim()
               + "%' or dchi like N'%" + strTimKiem.Trim() + "%'";
            DataTable data = DataConn.Instance.ExecuteQueryTable(str);
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
       public List<DTO.NhaCungCap> Them()
        {
            List<DTO.NhaCungCap> lNcc = new List<DTO.NhaCungCap>();
            DTO.NhaCungCap n = new DTO.NhaCungCap();
            lNcc.Add(n);
            string str = "select * from NhaCungCap";
            DataTable data = DataConn.Instance.ExecuteQueryTable(str);
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
       public void LuuThem(List<DTO.NhaCungCap> lNcc)
       {
           string str = "exec sp_Insert_NhaCungCap @ten=N'" + lNcc[0].ten + "',@dchi=N'" + 
               lNcc[0].diaChi + "',@sdt='" + lNcc[0].soDT +
               "',@qGia=N'" + lNcc[0].qGia+"'";
           DataConn.Instance.ExecuteQueryTable(str);
       }
       public void LuuSua(List<DTO.NhaCungCap> lNcc)
       {
           for(int i=0;i<lNcc.Count;i++)
           {
               string str = "exec sp_Update_NhaCungCap @id='" + lNcc[i].id + "' ,@ten=N'" + lNcc[i].ten + "',@dchi=N'" +
               lNcc[i].diaChi + "',@sdt='" + lNcc[i].soDT +
               "',@qGia=N'" + lNcc[i].qGia+"'";
               DataConn.Instance.ExecuteQueryTable(str);
           }
       }
       public void Xoa(string id)
       {
           string str = "exec sp_Delete_KhachHang  @id='" + id + "'";
           DataConn.Instance.ExecuteQueryTable(str);
       }
    }
}
