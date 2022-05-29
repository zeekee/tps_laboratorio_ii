using BackendPlatypus;
using BackendPlatypus.Controllers;
using System;
using System.Windows.Forms;

namespace FrontendPlatypus.Forms
{
    public partial class AddStockItem : Form
    {
        StockController stockController = new StockController();
        EgresosController egresosController = new EgresosController();

        public AddStockItem()
        {
            InitializeComponent();
            comboBox1.DataSource = egresosController.GetProveedoresName();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stockController.InsertItem(textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text, comboBox1.Text, textBox7.Text);
            ClearInputs();
            MessageBox.Show("Articulo ingresado con éxito");
        }

        private void ClearInputs()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
