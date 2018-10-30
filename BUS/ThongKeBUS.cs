using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class ThongKeBUS
    {
       private static ThongKeBUS instance;
       public static ThongKeBUS Instace
        {
            get
            {
                if (instance == null) return new ThongKeBUS();
                return instance;
            }
        }
    }
}
