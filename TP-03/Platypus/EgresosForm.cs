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
    }
}
