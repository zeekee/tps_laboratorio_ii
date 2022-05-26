using BackendPlatypus;
using System;
using System.Windows.Forms;

namespace Platypus_2
{
    public partial class ProveedoresControl : UserControl
    {
        ProveedoresController proveedoresController = new ProveedoresController();

        public ProveedoresControl()
        {
            InitializeComponent();
            dataGridView1.DataSource = proveedoresController.Fill();
            dataGridView1.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReFillGrid()
        {
            dataGridView1.DataSource = proveedoresController.Fill();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReFillGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            label5.Text = row.Cells["Code"].Value.ToString();
            textBox3.Text = row.Cells["Name"].Value.ToString();
            textBox4.Text = row.Cells["Address"].Value.ToString();
            textBox5.Text = row.Cells["NumberOne"].Value.ToString();
            textBox6.Text = row.Cells["NumberTwo"].Value.ToString();
            textBox7.Text = row.Cells["ContactName"].Value.ToString();
            textBox8.Text = row.Cells["Email"].Value.ToString();
            label7.Text = row.Cells["TotalMoneyPaid"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            proveedoresController.UpdateItem(label5.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox8.Text, textBox7.Text, label7.Text);
            ReFillGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proveedoresController.DeleteItem(label5.Text);
            ReFillGrid();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = proveedoresController.Search(textBox2.Text, textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agregar nuevo
        }
    }
}
