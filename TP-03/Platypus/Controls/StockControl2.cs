using BackendPlatypus;
using System;
using System.Windows.Forms;

namespace FrontendPlatypus.Controls
{
    public partial class StockControl2 : UserControl
    {
        StockController stockController = new StockController();

        public StockControl2()
        {
            InitializeComponent();
            dataGridView1.DataSource = stockController.Fill();
            dataGridView1.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReFillGrid()
        {
            dataGridView1.DataSource = stockController.Fill();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = stockController.Search(textBox2.Text,textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReFillGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stockController.DeleteItem(label5.Text);
            ReFillGrid();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            ReFillGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mostrar control que agrega nuevo item
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            label5.Text = row.Cells["Code"].Value.ToString();
            textBox3.Text = row.Cells["Name"].Value.ToString();
            textBox4.Text = row.Cells["Brand"].Value.ToString();
            textBox8.Text = row.Cells["Price"].Value.ToString();
            textBox5.Text = row.Cells["Stock"].Value.ToString();
            textBox6.Text = row.Cells["Supplier"].Value.ToString();
            textBox7.Text = row.Cells["Discount"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stockController.UpdateItem(label5.Text, textBox3.Text, textBox4.Text, textBox8.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            ReFillGrid();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            stockController.DeleteItem(label5.Text);
            ReFillGrid();
        }
    }
}
