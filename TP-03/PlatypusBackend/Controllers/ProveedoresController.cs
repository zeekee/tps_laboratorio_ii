using BackendPlatypus.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

        public IList<Proveedores> GetAll()
        {
            List<Proveedores> proveedores = new List<Proveedores>();

            SqlController.OpenConnection();
            SqlDataReader result = SqlController.QueryExecuteReader($"SELECT * FROM proveedores");
            while(result.Read())
            {
                Proveedores proveedor = new();

                proveedor.Id = int.Parse(result["Id"].ToString());
                proveedor.Name = result["Name"].ToString();
                proveedor.Address = result["Address"].ToString();
                proveedor.NumberOne = float.Parse(result["NumberOne"].ToString());
                proveedor.NumberTwo = float.Parse(result["NumberTwo"].ToString());
                proveedor.Email = result["Email"].ToString();
                proveedor.ContactName = result["ContactName"].ToString();
                proveedor.TotalMoneyPaid = float.Parse(result["TotalMoneyPaid"].ToString());

                proveedores.Add(proveedor);
            }
            if (result != null)
            {
                ((IDisposable)result).Dispose();
            }
            SqlController.CloseConnection();

            return proveedores;
        }
    }
}
