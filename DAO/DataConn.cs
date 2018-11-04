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
        public string connStr = @"Data Source=localhost;Initial Catalog=FinalProject;Integrated Security=True";
        /*public string connStr = @"Server=tcp:c601.database.windows.net,1433;
                                Initial Catalog=FinalProject;
                                Persist Security Info=False;
                                User ID=datnt;Password=Dat13579;
                                MultipleActiveResultSets=False;
                                Encrypt=True;
                                TrustServerCertificate=False;
                                Connection Timeout=300;";
                                */
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
