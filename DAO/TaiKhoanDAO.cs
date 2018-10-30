using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class TaiKhoanDAO
    {
       private static TaiKhoanDAO instance;
       public static TaiKhoanDAO Instace
        {
            get
            {
                if (instance == null) return new TaiKhoanDAO();
                return instance;
            }
        }
    }
}
