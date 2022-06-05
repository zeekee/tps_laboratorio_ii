using BackendPlatypus.Interfaces;
using BackendPlatypus.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace BackendPlatypus
{
    public class StockController : IController<Stock>
    {
        ProveedoresController proveedoresController = new ProveedoresController();

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

        private Stock SetStock(SqlDataReader result)
        {
            Stock stock = new();

            stock.Id = int.Parse(result["Id"].ToString());
            stock.Name = result["Name"].ToString();
            stock.Brand = result["Brand"].ToString();
            stock.Price = float.Parse(result["Price"].ToString());
            stock.Amount = float.Parse(result["Amount"].ToString());
            stock.IdProveedor = int.Parse(result["IdProveedor"].ToString());
            stock.Discount = float.Parse(result["Discount"].ToString());
            stock.PriceWithDiscount = CalculatePriceWithDiscount(stock.Price, stock.Discount);

            return stock;
        }

        public IList<string> GetProveedoreesName()
        {
            List<string> proveedoresNames = new();
            proveedoresNames.AddRange(proveedoresController.GetAll().Select(x => x.Name));
            return proveedoresNames;
        }

        public string GetProveedorName(int id)
        {
            return proveedoresController.GetAll().FirstOrDefault(x => x.Id == id).Name;
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

        public IList<Stock> GetAll()
        {
            List<Stock> stocks = new List<Stock>();

            SqlController.OpenConnection();
            SqlDataReader result = SqlController.QueryExecuteReader($"SELECT * FROM Stock");
            while (result.Read())
            {
                stocks.Add(SetStock(result));
            }
            if (result != null)
            {
                ((IDisposable)result).Dispose();
            }
            SqlController.CloseConnection();

            return stocks;
        }

        public void DeleteItem(string id)
        {
            SqlController.QuerySqlDataAdapter($"DELETE FROM Stock WHERE id = '{id}'");
        }

        public void UpdateItem(string id, string Name, string Brand, string Price, string Stock, string Supplier, string Discount)
        {
            int supplierId = proveedoresController.GetAll().FirstOrDefault(x => x.Name == Supplier).Id;

            string query = "UPDATE stock " +
                $"SET Name = '{Name}', Brand = '{Brand}', Price = '{Price}', Amount = '{Stock}', IdProveedor = '{supplierId}', Discount = '{Discount}'" +
                $"WHERE id = {id};";

            SqlController.QuerySqlDataAdapter(query);
        }

        public void InsertItem(string Name, string Brand, string Price, string Stock, string Supplier, string Discount)
        {
            int supplierId = proveedoresController.GetAll().FirstOrDefault(x => x.Name == Supplier).Id;

            string query = "INSERT INTO stock (Name, Brand, Price, Amount, IdProveedor, Discount)" +
                $"VALUES ('{Name}', '{Brand}', '{Price}', '{Stock}', '{supplierId}', '{Discount}');";

            SqlController.QuerySqlDataAdapter(query);
        }

        public Stock GetProduct(int idStock)
        {
            Stock stock;
            SqlController.OpenConnection();
            SqlDataReader result = SqlController.QueryExecuteReader($"SELECT * FROM Stock WHERE Id = @0", idStock);
            if (result.Read())
            {
                stock = SetStock(result);
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
