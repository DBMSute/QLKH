using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class MatKhauCuDAO
    {
       private static MatKhauCuDAO instance;
       public static MatKhauCuDAO Instace
        {
            get
            {
                if (instance == null) return new MatKhauCuDAO();
                return instance;
            }
        }
    }
}
