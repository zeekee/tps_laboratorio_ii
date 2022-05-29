using BackendPlatypus.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BackendPlatypus
{
    public class StockController
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

        public DataTable Search(string id, string description)
        {
            string query;

            if (id != string.Empty)
            {
                query = $"select * from Stock where code = {id}";
            }
            else
            {
                query = $"select * from Stock where Name like '%{description}%' or Brand like '%{description}%' or Supplier like '%{description}%'"; ;
            }

            return SqlController.QuerySqlDataAdapter(query);
        }

        public DataTable Fill()
        {
            return SqlController.QuerySqlDataAdapter($"select * from Stock");
        }

        public void DeleteItem(string id)
        {
            SqlController.QuerySqlDataAdapter($"DELETE FROM Stock WHERE id = '{id}'");
        }

        public void UpdateItem(string id, string Name, string Brand, string Price, string Stock, string Supplier, string Discount)
        {
            string query = "UPDATE stock " +
                $"SET Name = '{Name}', Brand = '{Brand}', Price = '{Price}', Amount = '{Stock}', IdProveedor = '{Supplier}', Discount = '{Discount}'" +
                $"WHERE id = {id};";

            SqlController.QuerySqlDataAdapter(query);
        }

        public void InsertItem(string id, string Name, string Brand, string Price, string Stock, string Supplier, string Discount)
        {
            string query = "INSERT INTO stock " +
                $"VALUES ('{id}', '{Name}', '{Brand}', '{Price}', '{Stock}', '{Supplier}', '{Discount}');";

            SqlController.QuerySqlDataAdapter(query);
        }

        public Stock GetProduct(int idStock)
        {
            Stock stock = new();
            SqlController.OpenConnection();
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
            SqlController.CloseConnection();

            return stock;
        }
    }
}
