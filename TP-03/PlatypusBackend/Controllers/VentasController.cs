using BackendPlatypus.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BackendPlatypus.Controllers
{
    public class VentasController
    {
        private float CalculatePriceWithDiscount(float price, float discount)
        {
            float finalPrice = price;

            if (discount != 0)
            {
                float priceDiscount = (price * discount) / 100;
                finalPrice -= priceDiscount;
            }

            return finalPrice;
        }

        public Stock Search(int idStock)
        {
            Stock stock = new();
            SqlDataReader result = SqlController.QueryExecuteReader($"SELECT * FROM Stock WHERE Id = @0", idStock);
            if (result.Read())
            {
                stock.Id = int.Parse(result["Id"].ToString());
                stock.Name = result["Name"].ToString();
                stock.Brand = result["Brand"].ToString();
                stock.Price = float.Parse(result["Price"].ToString());
                stock.Amount = float.Parse(result["Amount"].ToString());
                stock.IdProveedor = int.Parse(result["IdProveedor"].ToString());
                stock.Discount = float.Parse(result["Discount"].ToString());

                stock.PriceWithDiscount = CalculatePriceWithDiscount(stock.Price, stock.Discount);
            }
            else
            {
                stock = null;
            }

            if (result != null)
            {
                ((IDisposable)result).Dispose();
            }

            return stock;
        }

        public void FinalizeSale(string finalPrice)
        {
            string query = "INSERT INTO Ventas (TotalSale) " +
                $"VALUES ({finalPrice.Replace(',', '.')});";

            SqlController.QueryExecuteNonQuery(query);
        }
    }
}
