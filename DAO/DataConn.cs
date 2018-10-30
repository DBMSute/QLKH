using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
   public class DataConn
    {
        private static DataConn instance;
        public static DataConn Instance
        {
            get
            {
                if (instance == null) return new DataConn();
                return instance;
            }
        }
        public string connStr = @"Data Source=localhost;Initial Catalog=DB1;Integrated Security=True";
        public DataTable ExecuteQuery(string QuerySql)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                SqlCommand comm = new SqlCommand(QuerySql, sqlConn);
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(data);
                sqlConn.Close();
            }
            return data;
        }
    }
}
