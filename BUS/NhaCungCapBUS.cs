using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class NhaCungCapBUS
    {
       private static NhaCungCapBUS instance;
       public static NhaCungCapBUS Instace
        {
            get
            {
                if (instance == null) return new NhaCungCapBUS();
                return instance;
            }
        }
    }
}
