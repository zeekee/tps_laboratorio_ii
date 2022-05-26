using System.Data;

namespace BackendPlatypus
{
    public class StockController
    {
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
            SqlController.QuerySqlDataAdapter($"DELETE FROM Stock WHERE Code = '{id}'");
        }

        public void UpdateItem(string id, string Name, string Brand, string Price, string Stock, string Supplier, string Discount)
        {
            string query = "UPDATE stock " +
                $"SET Name = '{Name}', Brand = '{Brand}', Price = '{Price}', Stock = '{Stock}', Supplier = '{Supplier}', Discount = '{Discount}'" +
                $"WHERE Code = {id};";

            SqlController.QuerySqlDataAdapter(query);
        }

        public void InsertItem(string id, string Name, string Brand, string Price, string Stock, string Supplier, string Discount)
        {
            string query = "INSERT INTO stock " +
                $"VALUES ('{id}', '{Name}', '{Brand}', '{Price}', '{Stock}', '{Supplier}', '{Discount}');";

            SqlController.QuerySqlDataAdapter(query);
        }
    }
}
