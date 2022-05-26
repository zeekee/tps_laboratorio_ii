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
            return connectionDB.QuerySqlDataAdapter(query);
        }

        public static SqlDataReader QueryExecuteReader(string query, int paramValue)
        {
            return connectionDB.QueryExecuteReader(query, paramValue);
        }

        public static int QueryExecuteNonQuery(string query)
        {
            return connectionDB.QueryExecuteNonQuery(query);
        }
    }
}
