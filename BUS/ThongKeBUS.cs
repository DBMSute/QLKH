using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongKeBUS
    {
        private static ThongKeBUS instance;
        public static ThongKeBUS INSTANCE
        {
            get
            {
                if (instance == null) return new ThongKeBUS();
                return instance;
            }
        }

        public double doanhSo(string typeCur, int isLast, int typeSum)
        {
            return DAO.ThongKeDAO.INSTANCE.doanhSo(typeCur, isLast, typeSum);
        }

        public DataTable chartDoanhSo(string typeCur, int type, int isLast, int typeSum)
        {
            return DAO.ThongKeDAO.INSTANCE.chartDoanhSo(typeCur, type, isLast, typeSum);
        }

        public double doanhThu(string typeCur, int isLast, int typeSum)
        {
            return DAO.ThongKeDAO.INSTANCE.doanhThu(typeCur, isLast, typeSum);
        }

        public DataTable chartDoanhThu(string typeCur, int type, int isLast, int typeSum)
        {
            return DAO.ThongKeDAO.INSTANCE.chartDoanhThu(typeCur, type, isLast, typeSum);
        }

        public DataTable chartTop10SellSL(int isLast, int typeSum)
        {
            return DAO.ThongKeDAO.INSTANCE.chartTop10SellSL(isLast, typeSum);
        }

        public DataTable chartTop10SellDoanhThu(string typeCur, int isLast, int typeSum)
        {
            return DAO.ThongKeDAO.INSTANCE.chartTop10SellDoanhThu(typeCur, isLast, typeSum);
        }
    }
}
