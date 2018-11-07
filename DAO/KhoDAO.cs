using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
   public class KhoDAO
    {
         private static KhoDAO instance;
        public static KhoDAO Instance
        {
            get
            {
                if (instance == null) return new KhoDAO();
                return instance;
            }
        }
       public List<Kho> loadData()
        {
            List<Kho> khoDao = new List<Kho>();
            string str = "select * from Kho";
            DataTable data = DataConn.Instance.ExecuteQuery(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string diaChi = item["diachi"].ToString();
                string taiKhoan = item["taikhoan"].ToString();
                bool tinhTrang = (bool)item["tinhtrang"];
                Kho kh = new Kho(id,ten,diaChi,taiKhoan,tinhTrang);
                khoDao.Add(kh);
            }
            return khoDao;
        }
       public List<Kho> timKiem( string strTimKiem)
       {
           if (strTimKiem.Trim() == "")
               return loadData();
           List<Kho> khoDao = new List<Kho>();
           string str = "select * from Kho where id like N'%"+strTimKiem.Trim()+"%' or ten like N'%"+strTimKiem.Trim()
               +"%' or diachi like N'%"+strTimKiem.Trim()+"%'";
               DataTable data = DataConn.Instance.ExecuteQuery(str);
               foreach (DataRow item in data.Rows)
               {
                   string id = item["id"].ToString();
                   string ten = item["ten"].ToString();
                   string diaChi = item["diachi"].ToString();
                   string taiKhoan = item["taikhoan"].ToString();
                   bool tinhTrang = (bool)item["tinhtrang"];
                   Kho kh = new Kho( id,ten, diaChi, taiKhoan, tinhTrang);
                   khoDao.Add(kh);
               }     
           return khoDao;
       }
       public void LuuThem(List<Kho> lKho)
       {
               string str = "";          
               if (lKho[0].tinhTrang)
                   str = "exec sp_Insert_Kho @ten=N'" + lKho[0].ten + "', @dchi=N'" + lKho[0].diaChi + "', @tk='" + lKho[0].taiKhoan + "', @tinhtrang=1";
               else
                   str = "exec sp_Insert_Kho @ten=N'" + lKho[0].ten + "', @dchi=N'" + lKho[0].diaChi + "', @tk='" + lKho[0].taiKhoan + "', @tinhtrang=0";
           
         DataConn.Instance.ExecuteQuery(str);
       }
       public void LuuSua(List<Kho> lKho)
       {
           for (int i = 0; i < lKho.Count; i++)
           {
               string str = "";
               if (lKho[i].tinhTrang)
                   str = "exec  sp_Update_Kho @id='"+lKho[i].id +"', @ten=N'" + lKho[i].ten + "', @dchi=N'" + lKho[i].diaChi + "', @tinhtrang=1";
               else
                   str = "exec  sp_Update_Kho @id='" +lKho[i].id + "', @ten=N'" + lKho[i].ten + "', @dchi=N'" + lKho[i].diaChi + "', @tinhtrang=0";
               DataConn.Instance.ExecuteQuery(str);
           }
       }
       public List<Kho> themKho()
       {
           List<Kho> khoDao = new List<Kho>();
           Kho k = new Kho();
           khoDao.Add(k);
           string str = "select * from Kho";
           DataTable data = DataConn.Instance.ExecuteQuery(str);
           foreach (DataRow item in data.Rows)
           {
               string id = item["id"].ToString();
               string ten = item["ten"].ToString();
               string diaChi = item["diachi"].ToString();
               string taiKhoan = item["taikhoan"].ToString();
               bool tinhTrang = (bool)item["tinhtrang"];
               Kho kh = new Kho(id,ten, diaChi, taiKhoan, tinhTrang);
               khoDao.Add(kh);
           }      
           return khoDao;
       }
       public void xoaKho(string id)
       {
           string str = "exec sp_Delete_KhachHang  @id='" + id + "'";
           DataConn.Instance.ExecuteQuery(str);
       }
    }

}

