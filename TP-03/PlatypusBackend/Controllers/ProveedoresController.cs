using BackendPlatypus.Interfaces;
using BackendPlatypus.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace BackendPlatypus
{
    public class ProveedoresController : IController<Proveedores>
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
            SqlController.QuerySqlDataAdapter($"DELETE FROM Proveedores WHERE Id = '{id}'");
        }

        public void UpdateItem(string id, string Name, string Address, string NumberOne, string NumberTwo, string Email, string ContactName)
        {
            string query = "UPDATE Proveedores " +
                $"SET Name = '{Name}', Address = '{Address}', NumberOne = '{NumberOne}', NumberTwo = '{NumberTwo}', Email = '{Email}', ContactName = '{ContactName}'" +
                $"WHERE Id = {id};";

            SqlController.QuerySqlDataAdapter(query);
        }

        public void InsertItem(string Name, string Address, string NumberOne, string NumberTwo, string Email, string ContactName)
        {
            string query = "INSERT INTO Proveedores (Name, Address, NumberOne, NumberTwo, Email, ContactName)" +
                $"VALUES ('{Name}', '{Address}', '{NumberOne}', '{NumberTwo}', '{Email}', '{ContactName}');";

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

                proveedores.Add(proveedor);
            }
            if (result != null)
            {
                ((IDisposable)result).Dispose();
            }
            SqlController.CloseConnection();

            return proveedores;
        }

        public void ExportFile(SaveFileDialog saveFileDialog, DataGridView dataGridView)
        {
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Save an Text File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                StreamWriter file = new(saveFileDialog.FileName);
                try
                {
                    foreach (DataGridViewRow item in dataGridView.Rows)
                    {
                        file.WriteLine($"Name: {item.Cells[1].Value}");
                        file.WriteLine($"Address: {item.Cells[2].Value}");
                        file.WriteLine($"Number: {item.Cells[3].Value}");
                        file.WriteLine($"Email: {item.Cells[5].Value}");
                        file.WriteLine($"Contact Name: {item.Cells[6].Value}");
                        file.WriteLine("------------------------------------------------");
                    }

                    file.Close();
                    MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    file.Close();
                }
            }
        }
    }
}
