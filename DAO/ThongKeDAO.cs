using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongKeDAO
    {
        private static ThongKeDAO instance;
        public static ThongKeDAO INSTANCE
        {
            get
            {
                if (instance == null) return new ThongKeDAO();
                return instance;
            }
        }

        public DataTable chartDoanhSo(string typeCur, int type, int isLast, int typeSum)
        {
            string str = "SELECT * FROM dbo.FN_Chart_DoanhSo('" + typeCur + "'," + type + "," + isLast + "," + typeSum + ")";
            return DataConn.INSTANCE.ExecuteQueryTable(str);
        }

        public double doanhSo(string typeCur, int isLast, int typeSum)
        {
            string str = "SELECT dbo.FN_DoanhSo('" + typeCur + "'," + isLast + "," + typeSum + ")";
            return Convert.ToDouble(DataConn.INSTANCE.ExecuteQueryScalar(str));
        }

        public double doanhThu(string typeCur, int isLast, int typeSum)
        {
            string str = "SELECT dbo.FN_DoanhThu('" + typeCur + "'," + isLast + "," + typeSum + ")";
            return Convert.ToDouble(DataConn.INSTANCE.ExecuteQueryScalar(str));
        }

        public DataTable chartDoanhThu(string typeCur, int type, int isLast, int typeSum)
        {
            string str = "SELECT * FROM dbo.FN_Chart_DoanhThu('" + typeCur + "'," + type + "," + isLast + "," + typeSum + ")";
            return DataConn.INSTANCE.ExecuteQueryTable(str);
        }

        public DataTable chartTop10SellSL(int isLast, int typeSum)
        {
            string str = "SELECT * FROM dbo.FN_Top10Sell_SL(" + isLast + "," + typeSum + ") ORDER BY sValue ASC";
            return DataConn.INSTANCE.ExecuteQueryTable(str);
        }

        public DataTable chartTop10SellDoanhThu(string typeCur, int isLast, int typeSum)
        {
            string str = "SELECT * FROM dbo.FN_Top10Sell_DoanhThu('" + typeCur + "'," + isLast + "," + typeSum + ") ORDER BY sValue ASC";
            return DataConn.INSTANCE.ExecuteQueryTable(str);
        }
    }
}
