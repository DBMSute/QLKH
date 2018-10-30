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
        public static KhoDAO Instace
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
                Kho kh = new Kho(id, ten,diaChi,taiKhoan,tinhTrang);
                khoDao.Add(kh);
            }
            return khoDao;
        }
       public List<Kho> loadData(string strTimKiem)
       {
           if (strTimKiem.Trim() == "")
               return loadData();
           List<Kho> khoDao = new List<Kho>();
           string str = "select * from Kho where id like '%"+strTimKiem.Trim()+"%' or ten like '%"+strTimKiem.Trim()
               +"%' or diachi like '%"+strTimKiem.Trim()+"%'";
               DataTable data = DataConn.Instance.ExecuteQuery(str);
               foreach (DataRow item in data.Rows)
               {
                   string id = item["id"].ToString();
                   string ten = item["ten"].ToString();
                   string diaChi = item["diachi"].ToString();
                   string taiKhoan = item["taikhoan"].ToString();
                   bool tinhTrang = (bool)item["tinhtrang"];
                   Kho kh = new Kho(id, ten, diaChi, taiKhoan, tinhTrang);
                   khoDao.Add(kh);
               }     
           return khoDao;
       }
       public bool themKho(string id, string ten, string diaChi,string taiKhoan, bool tinhTrang)
       {
           try
           {
               string query = "insert into Kho(MaKho, TenKho) values('" + id + "', N'" + ten + "',N'" + diaChi + "'," + taiKhoan+"," + tinhTrang + ")";
               DataTable data = DataConn.Instance.ExecuteQuery(query);
           }
           catch (SqlException e)
           {
               return false;
           }
           return true;
       }
       public bool xoaKho(string id)
       {
           try
           {
               string query = "delete from Kho where id='" + id+"';";
               DataTable data = DataConn.Instance.ExecuteQuery(query);
           }
           catch (SqlException e)
           {
               return false;
           }
           return true;
       }
       public bool suaKho(string id, string ten, string diaChi, string taiKhoan, bool tinhTrang)
       {
           string queryStr = "select * from Kho where id='" + id + "'";
           DataTable data = DataConn.Instance.ExecuteQuery(queryStr);
           if (data.Rows.Count == 0)
               return false;
           try
           {
               queryStr = "update Kho set id = '" + id.Trim() + "',ten = N'" + ten.Trim() + "',N'" + diaChi + "'," + tinhTrang + "where id = '" + id.Trim() + "'";
               data = DataConn.Instance.ExecuteQuery(queryStr);
           }
           catch(SqlException e)
           {
               return false;
           }
           return true;
       }
    }
}
