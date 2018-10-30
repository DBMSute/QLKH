using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;
        public static SanPhamDAO Instace
        {
            get
            {
                if (instance == null) return new SanPhamDAO();
                return instance;
            }
        }
    }
}
