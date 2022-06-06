using BackendPlatypus.Controllers;
using System;
using System.Windows.Forms;


namespace FrontendPlatypus
{
    public partial class EgresosForm : Form
    {
        EgresosController egresosController = new EgresosController();

        public EgresosForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = egresosController.Fill();
            labelTotal.Text = egresosController.AddTotal(dataGridView1).ToString();
            comboBox1.DataSource = egresosController.GetProveedoresName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            egresosController.InsertItem(textBox2.Text, comboBox1.Text);
            dataGridView1.DataSource = egresosController.Fill();
            labelTotal.Text = egresosController.AddTotal(dataGridView1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            egresosController.ExportFile(saveFileDialog1, dataGridView1); 
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(label2, "Solo numeros!");
                label2.Text = "Solo numeros!";
            }
            else
            {
                errorProvider1.SetError(label2, "");
                label2.Text = "";
            }
        }
    }
}
