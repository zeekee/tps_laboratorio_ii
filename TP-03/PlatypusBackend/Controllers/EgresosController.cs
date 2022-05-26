using System.Data;

namespace BackendPlatypus.Controllers
{
    public class EgresosController
    {
        public void InsertItem(string id, string ProveedorName, string TotalCash, string ProveedorCode)
        {
            string query = "INSERT INTO Egresos (idEgresos, ProveedorName, totalCash, Code) " +
                $"VALUES ('{id}', '{ProveedorName}', '{TotalCash}', '{ProveedorCode}');";

            SqlController.QuerySqlDataAdapter(query);
        }

        public DataTable Fill()
        {
            return SqlController.QuerySqlDataAdapter($"select * from Egresos"); //where created_at = {DateTime.Today.ToShortDateString()}
        }
    }
}
