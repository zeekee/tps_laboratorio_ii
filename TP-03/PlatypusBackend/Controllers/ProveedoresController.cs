using System.Data;

namespace BackendPlatypus
{
    public class ProveedoresController
    {
        public DataTable Search(string id, string description)
        {
            string query;

            if (id != string.Empty)
            {
                query = $"select * from Proveedores where code = {id}";
            }
            else
            {
                query = $"select * from Proveedores where Name like '%{description}%' or Address like '%{description}%' or ContactName like '%{description}%'"; ;
            }

            return SqlController.QuerySqlDataAdapter(query);
        }

        public DataTable Fill()
        {
            return SqlController.QuerySqlDataAdapter($"select * from Proveedores");
        }

        public void DeleteItem(string id)
        {
            SqlController.QuerySqlDataAdapter($"DELETE FROM Proveedores WHERE Code = '{id}'");
        }

        public void UpdateItem(string id, string Name, string Address, string NumberOne, string NumberTwo, string Email, string ContactName, string TotalMoneyPaid)
        {
            string query = "UPDATE Proveedores " +
                $"SET Name = '{Name}', Address = '{Address}', NumberOne = '{NumberOne}', NumberTwo = '{NumberTwo}', Email = '{Email}', ContactName = '{ContactName}', TotalMoneyPaid = '{TotalMoneyPaid}'" +
                $"WHERE Code = {id};";

            SqlController.QuerySqlDataAdapter(query);
        }

        public void InsertItem(string id, string Name, string Address, string NumberOne, string NumberTwo, string Email, string ContactName, string TotalMoneyPaid)
        {
            string query = "INSERT INTO Proveedores " +
                $"VALUES ('{id}', '{Name}', '{Address}', '{NumberOne}', '{NumberTwo}', '{Email}', '{ContactName}', '{TotalMoneyPaid}');";

            SqlController.QuerySqlDataAdapter(query);
        }
    }
}
