using BackendPlatypus;
using System;
using System.Windows.Forms;

namespace FrontendPlatypus
{
    public partial class ProveedoresForm : Form
    {
        ProveedoresController proveedoresController = new ProveedoresController();

        public ProveedoresForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = proveedoresController.GetAll();
            dataGridView1.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReFillGrid()
        {
            dataGridView1.DataSource = proveedoresController.Fill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != string.Empty)
            {
                proveedoresController.InsertItem(textBoxName.Text, textBox4.Text, textBoxTel1.Text, textBoxTel2.Text, textBoxEmail.Text, textBoxContact.Text);
            }
            ReFillGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            proveedoresController.UpdateItem(label5.Text, textBoxName.Text, textBox4.Text, textBoxTel1.Text, textBoxTel2.Text, textBoxEmail.Text, textBoxContact.Text);
            ReFillGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proveedoresController.DeleteItem(label5.Text);
            ReFillGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            label5.Text = row.Cells["Id"].Value.ToString();
            textBoxName.Text = row.Cells["Name"].Value.ToString();
            textBox4.Text = row.Cells["Address"].Value.ToString();
            textBoxTel1.Text = row.Cells["NumberOne"].Value.ToString();
            textBoxTel2.Text = row.Cells["NumberTwo"].Value.ToString();
            textBoxEmail.Text = row.Cells["ContactName"].Value.ToString();
            textBoxContact.Text = row.Cells["Email"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            proveedoresController.ExportFile(saveFileDialog1, dataGridView1);
        }
    }
}
