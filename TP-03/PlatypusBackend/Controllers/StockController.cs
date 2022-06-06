using BackendPlatypus.Interfaces;
using BackendPlatypus.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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

        public void ExportJson(SaveFileDialog saveFileDialog, DataGridView dataGridView)
        {
            string serialize = JsonConvert.SerializeObject(GetAll());

            saveFileDialog.Filter = "Text File|*.json";
            saveFileDialog.Title = "Save an Text File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                StreamWriter file = new(saveFileDialog.FileName);
                try
                {
                    file.Write(serialize);
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

        public void ImportJson(OpenFileDialog openFileDialog, DataGridView dataGridView1)
        {
            bool exist = false;
            if (openFileDialog.FileName != "")
            {
                List<Stock> stockList = JsonConvert.DeserializeObject<List<Stock>>(File.ReadAllText(openFileDialog.FileName));

                foreach (Stock item in stockList)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[0].Value) == item.Id)
                        {
                            exist = true;
                            break;
                        }
                    }

                    if (!exist)
                    {
                        string query = "INSERT INTO stock (Name, Brand, Price, Amount, IdProveedor, Discount)" +
                                        $"VALUES ('{item.Name}', '{item.Brand}', '{item.Price}', '{item.Amount}', '{item.IdProveedor}', '{item.Discount}');";

                        SqlController.QuerySqlDataAdapter(query);
                    }
                }
            }
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
                        file.WriteLine($"Brand: {item.Cells[2].Value}");
                        file.WriteLine($"Price: {item.Cells[3].Value}");
                        file.WriteLine($"Amount: {item.Cells[4].Value}");
                        file.WriteLine($"IdProveedor: {item.Cells[5].Value}");
                        file.WriteLine($"Discount: {item.Cells[6].Value}");
                        file.WriteLine($"Price whit Discount: {item.Cells[7].Value}");
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
