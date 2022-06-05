using BackendPlatypus;
using System;
using System.Windows.Forms;

namespace FrontendPlatypus
{
    public partial class StockForm : Form
    {
        StockController stockController = new StockController();

        public StockForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = stockController.Fill();
            dataGridView1.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comboBox1.DataSource = stockController.GetProveedoreesName();
        }

        private void ReFillGrid()
        {
            dataGridView1.DataSource = stockController.Fill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != string.Empty)
            {
                stockController.InsertItem(textBoxName.Text, textBoxBrand.Text, textBoxPrice.Text, textBoxAmount.Text, comboBox1.Text, textBoxDiscount.Text);
            }
            ReFillGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            label5.Text = row.Cells["Id"].Value.ToString();
            textBoxName.Text = row.Cells["Name"].Value.ToString();
            textBoxBrand.Text = row.Cells["Brand"].Value.ToString();
            textBoxPrice.Text = row.Cells["Price"].Value.ToString();
            textBoxAmount.Text = row.Cells["Amount"].Value.ToString();
            textBoxDiscount.Text = row.Cells["Discount"].Value.ToString();
            comboBox1.Text = stockController.GetProveedorName(Convert.ToInt32(row.Cells["IdProveedor"].Value));
        }

        private void ClearFields()
        {
            label5.Text = "";
            textBoxName.Text = "";
            textBoxBrand.Text = "";
            textBoxPrice.Text = "";
            textBoxAmount.Text = "";
            comboBox1.Text = "";
            textBoxDiscount.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label5.Text != "-" && label5.Text != string.Empty)
            {
                stockController.UpdateItem(label5.Text, textBoxName.Text, textBoxBrand.Text, textBoxPrice.Text, textBoxAmount.Text, comboBox1.Text, textBoxDiscount.Text);
                ReFillGrid();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label5.Text != "-" && label5.Text != string.Empty)
            {
                stockController.DeleteItem(label5.Text);
                ClearFields();
                ReFillGrid();
            }
        }
    }
}
