using System;
using System.Data;
using System.Data.SqlClient;

namespace ConectionSQL
{
    public class ConnectionDB
    {
        const string sqlName = "DESKTOP-7MMV0ST\\SQLEXPRESS"; // Cambiar por el nombre de su servidor
        const string dbName = "PlatypusDB"; // Cambiar por nombre de la base que se vaya a usar

        string stringConnection = $"Data Source={sqlName};Initial Catalog={dbName}; Integrated Security=True";
        public SqlConnection connectDB = new SqlConnection();

        public ConnectionDB()
        {
            connectDB.ConnectionString = stringConnection;
        }

        public string Open()
        {
            //TODO Logear en lugar de escribir en la consola
            try
            {
                connectDB.Open();
                Console.WriteLine("Conexion abierta");
                return "Ok";
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al abrir la base de datos: {e.Message}");
                return "Error";
            }
        }

        public DataTable QuerySqlDataAdapter(string query)
        {
            DataTable table = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, connectDB);
                SqlDataAdapter data = new SqlDataAdapter(command);
                data.Fill(table);
            }
            catch (Exception ex) { }

            return table;
        }

        public SqlDataReader QueryExecuteReader(string query, int paramValue)
        {
            SqlCommand command = new SqlCommand(query, connectDB);
            command.Parameters.AddWithValue("@0", paramValue);
            SqlDataReader reader = command.ExecuteReader();
            command.Parameters.Clear();

            return reader;
        }

        public SqlDataReader QueryExecuteReader(string query)
        {
            SqlCommand command = new SqlCommand(query, connectDB);
            SqlDataReader reader = command.ExecuteReader();
            command.Parameters.Clear();
            return reader;
        }

        public int QueryExecuteNonQuery(string query)
        {
            int result = 0;
            try
            {
                SqlCommand command = new SqlCommand(query, connectDB);
                result = command.ExecuteNonQuery();
            }
            catch { }

            return result;
        }

        public void Close()
        {
            connectDB.Close();
        }
    }
}
