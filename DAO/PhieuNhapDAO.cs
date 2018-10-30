using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuNhapDAO
    {
        private static PhieuNhapDAO instance;
        public static PhieuNhapDAO Instace
        {
            get
            {
                if (instance == null) return new PhieuNhapDAO();
                return instance;
            }
        }
    }
}
