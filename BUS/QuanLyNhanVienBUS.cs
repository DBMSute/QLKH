using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class QuanLyNhanVienBUS
    {
       private static QuanLyNhanVienBUS instance;
       public static QuanLyNhanVienBUS Instace
        {
            get
            {
                if (instance == null) return new QuanLyNhanVienBUS();
                return instance;
            }
        }
    }
}
