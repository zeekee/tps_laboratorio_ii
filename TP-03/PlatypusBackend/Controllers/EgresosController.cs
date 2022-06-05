using BackendPlatypus.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BackendPlatypus.Controllers
{
    public class EgresosController
    {
        ProveedoresController proveedoresController = new ProveedoresController();

        public IList<string> GetProveedoresName()
        {
            List<string> proveedoresNames = new();
            proveedoresNames.AddRange(proveedoresController.GetAll().Select(x => x.Name));
            return proveedoresNames;
        }

        public void Insert(string totalCash, int idProveedor)
        {
            string query = "INSERT INTO Egresos (TotalCash, IdProveedor) " +
                $"VALUES ('{totalCash}', '{idProveedor}');";

            SqlController.QuerySqlDataAdapter(query);
        }

        public void InsertItem(string totalCash, string proveedorName)
        {
            Proveedores proveedor = proveedoresController.GetAll().FirstOrDefault(x => x.Name == proveedorName);
            Insert(totalCash, proveedor.Id);
        }

        public DataTable Fill()
        {
            return SqlController.QuerySqlDataAdapter($"select * from Egresos where created_at = '{DateTime.Now.ToString("yyyy/MM/dd")}'");
        }

        public float AddTotal(DataGridView dgv)
        {
            float sum = 0;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                sum += float.Parse(dgv.Rows[i].Cells[1].Value.ToString());
            }
            return sum;
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
                        file.WriteLine($"Total Cash: {item.Cells[1].Value}");
                        file.WriteLine($"Id Proveedor: {item.Cells[2].Value}");
                        file.WriteLine($"Pagado el: {item.Cells[3].Value}");
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
