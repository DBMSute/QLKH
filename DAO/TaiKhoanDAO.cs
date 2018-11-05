using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAO
{
   public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null) return new TaiKhoanDAO();
                return instance;
            }
        }

       public int Check(string tenTk,string passwd)
        {
           
            string str = "select * from TaiKhoan where tentk='"+tenTk+"' and passwd='"+passwd
               + "'";
            DataTable dt= DataConn.Instance.ExecuteQuery(str);
            if (dt.Rows.Count < 1)
                return -1;
            int pers = int.Parse(dt.Rows[0]["pers"].ToString());
            return pers;            
        }
    }
}
