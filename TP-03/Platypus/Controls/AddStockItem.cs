using BackendPlatypus;
using System;
using System.Windows.Forms;

namespace FrontendPlatypus.Controls
{
    public partial class AddStockItem : UserControl
    {
        StockController stockController = new StockController();

        public AddStockItem()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO Antes de crear un nuevo item, revisar si el id no existe.

            stockController.InsertItem(textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text, textBox6.Text, textBox7.Text);
        }
    }
}
