using BackendPlatypus.Models;

namespace BackendPlatypus.Controllers
{
    public class VentasController
    {
        StockController stockController = new StockController();

        public Stock Search(int idStock)
        {
            return stockController.GetProduct(idStock);
        }

        public void FinalizeSale(string finalPrice)
        {
            string query = "INSERT INTO Ventas (TotalSale) " +
                $"VALUES ({finalPrice.Replace(',', '.')});";


            SqlController.QueryExecuteNonQuery(query);
        }
    }
}
