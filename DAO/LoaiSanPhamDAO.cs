using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class LoaiSanPhamDAO
    {
        private static LoaiSanPhamDAO instance;
        public static LoaiSanPhamDAO Instace
        {
            get
            {
                if (instance == null) return new LoaiSanPhamDAO();
                return instance;
            }
        }
    }
}
