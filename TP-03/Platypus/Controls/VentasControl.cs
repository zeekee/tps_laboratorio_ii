using BackendPlatypus.Controllers;
using BackendPlatypus.Models;
using System;
using System.Windows.Forms;

namespace Platypus_2
{
    public partial class VentasControl : UserControl
    {
        VentasController ventasController = new VentasController();

        public VentasControl()
        {
            InitializeComponent();
            scannerPanel.Hide();
            searchPanel.Show();
            multiplePanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchPanel.Hide();
            multiplePanel.Hide();
            scannerPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scannerPanel.Hide();
            searchPanel.Show();
            multiplePanel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stock productSearch = new Stock();

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                productSearch = ventasController.Search(int.Parse(textBox1.Text));
            }
            else
            {
                productSearch = null;
            }

            if (productSearch != null)
            {
                labelCode.Text = productSearch.Id.ToString();
                labelDescription.Text = productSearch.Name.ToString();
                labelBrand.Text = productSearch.Brand.ToString();
                labelAmount.Text = productSearch.Amount.ToString();
                labelSupplier.Text = productSearch.IdProveedor.ToString();
                labelDiscount.Text = productSearch.Discount.ToString();
                labelPrice.Text = productSearch.Price.ToString();
                labelPriceDiscount.Text = productSearch.PriceWithDiscount.ToString();
            }
            else
            {
                ClearProduct();
                MessageBox.Show("No existe un articulo con el codigo ingresado.");
            }
        }

        private void ClearProduct()
        {
            labelCode.Text = "-";
            labelDescription.Text = "-";
            labelBrand.Text = "-";
            labelAmount.Text = "-";
            labelSupplier.Text = "-";
            labelDiscount.Text = "-";
            labelPrice.Text = "-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (labelCode.Text != "-")
            {
                dataGridViewVenta.Rows.Add(labelCode.Text, labelDescription.Text, labelDiscount.Text, labelPrice.Text, labelPriceDiscount.Text);
            }
        }

        private void dataGridViewVenta_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateFinalPrice();

        }

        private void dataGridViewVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateFinalPrice();
        }

        private void UpdateFinalPrice()
        {
            float finalPrice = 0;
            foreach (DataGridViewRow row in dataGridViewVenta.Rows)
            {
                finalPrice += float.Parse(row.Cells[4].Value.ToString());
            }
            labelTotal.Text = finalPrice.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewVenta.Rows.Count != 0)
                {
                    ventasController.FinalizeSale(labelTotal.Text);
                    dataGridViewVenta.Rows.Clear();
                    ClearProduct();
                    MessageBox.Show("La venta finalizo con exito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error con la venta. {ex}");
            }
        }
    }
}
