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
        //public string connStr = @"Server=tcp:c601.database.windows.net,1433;
        //                        Initial Catalog=FinalProject;
        //                        Persist Security Info=False;
        //                        User ID=poonnguyen295;Password=Poon13579;
        //                        MultipleActiveResultSets=False;
        //                        Encrypt=True;
        //                        TrustServerCertificate=False;
        //                        Connection Timeout=300;";
                                
        public DataTable ExecuteQueryTable(string QuerySql)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                SqlCommand comm = new SqlCommand(QuerySql, sqlConn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comm;
                da.Fill(data);
                sqlConn.Close();
            }
            return data;
        }

        public string ExecuteQueryScalar(string QuerySql)
        {
            string data = null;
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {      
                SqlCommand comm = new SqlCommand(QuerySql, sqlConn);
                sqlConn.Open();
                string temp = comm.ExecuteScalar().ToString();
                if (temp == "System.Byte[]")
                {
                    data = Encoding.ASCII.GetString((byte[])comm.ExecuteScalar());
                    sqlConn.Close();
                    return data;
                }         
                data = comm.ExecuteScalar().ToString();
                sqlConn.Close();
            }
            return data;
        }

        public string ExecuteQueryScalar(string QuerySql, string id, byte[] bytes, string type) //type là biến tham chiếu trong SQL
        {     
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                SqlCommand comm = new SqlCommand(QuerySql, sqlConn);
                sqlConn.Open();
                comm.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlbytes = new SqlParameter(type, SqlDbType.VarBinary);
                SqlParameter sqlid = new SqlParameter("@id", SqlDbType.VarChar);
                comm.Parameters.Add(sqlbytes).Value = bytes;
                comm.Parameters.Add(sqlid).Value = id;
                comm.ExecuteScalar();
                sqlConn.Close();
            }
            return "";
        }
    }
    
}
