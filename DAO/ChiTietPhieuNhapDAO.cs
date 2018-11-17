using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class ChiTietPhieuNhapDAO
    {
        private static ChiTietPhieuNhapDAO instance;
        public static ChiTietPhieuNhapDAO INSTANCE
        {
            get
            {
                if (instance == null) return new ChiTietPhieuNhapDAO();
                return instance;
            }
        }
    }
}
