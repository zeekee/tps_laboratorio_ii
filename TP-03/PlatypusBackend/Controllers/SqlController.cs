using ConectionSQL;
using System.Data;
using System.Data.SqlClient;

namespace BackendPlatypus
{
    public static class SqlController
    {
        static ConnectionDB connectionDB = new ConnectionDB();

        public static string OpenConnection()
        {
            return connectionDB.Open();
        }

        public static void CloseConnection()
        {
            connectionDB.Close();
        }

        public static DataTable QuerySqlDataAdapter(string query)
        {
            OpenConnection();
            DataTable dt = connectionDB.QuerySqlDataAdapter(query);
            CloseConnection();
            return dt;
        }

        public static SqlDataReader QueryExecuteReader(string query, int paramValue)
        {
            SqlDataReader dr = connectionDB.QueryExecuteReader(query, paramValue);
            return dr;
        }

        public static SqlDataReader QueryExecuteReader(string query)
        {
            SqlDataReader dr = connectionDB.QueryExecuteReader(query);
            return dr;
        }

        public static int QueryExecuteNonQuery(string query)
        {
            OpenConnection();
            int result = connectionDB.QueryExecuteNonQuery(query);
            OpenConnection();
            return result;
        }
    }
}
