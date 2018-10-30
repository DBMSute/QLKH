using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class NhaCungCapDAO
    {
       private static NhaCungCapDAO instance;
       public static NhaCungCapDAO Instace
        {
            get
            {
                if (instance == null) return new NhaCungCapDAO();
                return instance;
            }
        }
    }
}
