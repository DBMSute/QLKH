using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class PhieuXuatDAO
    {
        private static PhieuXuatDAO instance;
        public static PhieuXuatDAO Instace
        {
            get
            {
                if (instance == null) return new PhieuXuatDAO();
                return instance;
            }
        }
    }
}
