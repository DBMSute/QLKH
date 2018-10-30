using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
   public class KhachHangBUS
    {
       private static KhachHangBUS instance;
       public static KhachHangBUS Instace
        {
            get
            {
                if (instance == null) return new KhachHangBUS();
                return instance;
            }
        }
    }
}
