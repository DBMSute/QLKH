using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class KhachHangDAO
    {
       private static KhachHangDAO instance;
       public static KhachHangDAO Instace
        {
            get
            {
                if (instance == null) return new KhachHangDAO();
                return instance;
            }
        }
    }
}
