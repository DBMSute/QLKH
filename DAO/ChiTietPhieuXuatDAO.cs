using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class ChiTietPhieuXuatDAO
    {
        private static ChiTietPhieuXuatDAO instance;
        public static ChiTietPhieuXuatDAO Instace
        {
            get
            {
                if (instance == null) return new ChiTietPhieuXuatDAO();
                return instance;
            }
        }
    }
}
