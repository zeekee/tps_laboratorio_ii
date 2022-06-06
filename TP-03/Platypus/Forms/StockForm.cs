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
            dataGridView1.DataSource = stockController.GetAll();
            dataGridView1.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comboBox1.DataSource = stockController.GetProveedoreesName();
        }

        private void ReFillGrid()
        {
            dataGridView1.DataSource = stockController.GetAll();
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

        private void button2_Click(object sender, EventArgs e)
        {
            stockController.ExportFile(saveFileDialog1, dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stockController.ExportJson(saveFileDialog1, dataGridView1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            stockController.ImportJson(openFileDialog1, dataGridView1);
            ReFillGrid();
        }

        private void textBoxDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(label1, "Solo numeros!");
                label1.Text = "Solo numeros!";
            }
            else
            {
                errorProvider1.SetError(label1, "");
                label1.Text = "";
            }
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(label6, "Solo numeros!");
                label6.Text = "Solo numeros!";
            }
            else
            {
                errorProvider1.SetError(label6, "");
                label6.Text = "";
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(label7, "Solo numeros!");
                label7.Text = "Solo numeros!";
            }
            else
            {
                errorProvider1.SetError(label7, "");
                label7.Text = "";
            }
        }
    }
}
