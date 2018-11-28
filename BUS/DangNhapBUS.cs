using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DangNhapBUS
    {
        private static DangNhapBUS instance;
        public static DangNhapBUS INSTANCE
        {
            get
            {
                if (instance == null) return new DangNhapBUS();
                return instance;
            }
        }

        public void setIP(string ip)
        {
            DAO.DataConn.INSTANCE.setIP(ip);
        }

        public bool IsServerConnected()
        {
            return DAO.DataConn.INSTANCE.IsServerConnected();
        }
    }
}
