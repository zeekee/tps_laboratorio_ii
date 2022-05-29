using System;
using System.Data;
using System.Data.SqlClient;

namespace ConectionSQL
{
    public class ConnectionDB //TODO: Agregar try catch a los accesos a la base de datos
    {
        const string sqlName = "DESKTOP-7MMV0ST\\SQLEXPRESS";
        const string dbName = "PlatypusDB";

        string stringConnection = $"Data Source={sqlName};Initial Catalog={dbName}; Integrated Security=True"; //TODO crear la base de datos si no existe desde el programa
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
            SqlCommand command = new SqlCommand(query, connectDB);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);

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
            SqlCommand command = new SqlCommand(query, connectDB);
            int result = command.ExecuteNonQuery();
            return result;
        }

        public void Close()
        {
            connectDB.Close();
        }
    }
}
