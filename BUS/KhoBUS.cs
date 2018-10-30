using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
   public class KhoBUS
    {
       private static KhoBUS instance;
       public static KhoBUS Instace
        {
            get
            {
                if (instance == null) return new KhoBUS();
                return instance;
            }
        }
       public void loadData(DataGridView dt)
       {
                dt.DataSource = DAO.KhoDAO.Instace.loadData();
       }
       public void timKiem(DataGridView dt,string strTimKiem)
       {
          dt.DataSource = DAO.KhoDAO.Instace.loadData(strTimKiem);
       }
       public bool themKho(string id,string ten,string diaChi,string taiKhoan,bool tinhTrang)
       {
         return  DAO.KhoDAO.Instace.themKho(id, ten, diaChi, taiKhoan, tinhTrang);       
       }
       public bool xoaKho(string id)
       {
           return DAO.KhoDAO.Instace.xoaKho(id);
       }
        public bool suaKho(string id,string ten,string diaChi,string taiKhoan,bool tinhTrang)
       {
           return DAO.KhoDAO.Instace.suaKho(id, ten, diaChi, taiKhoan, tinhTrang);   
       }
    }
}
