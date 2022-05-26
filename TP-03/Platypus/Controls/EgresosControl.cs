using BackendPlatypus;
using BackendPlatypus.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Platypus_2
{
    public partial class EgresosControl : UserControl
    {
        ProveedoresController proveedoresController = new ProveedoresController();
        EgresosController egresosController = new EgresosController(); 

        public EgresosControl()
        {
            InitializeComponent();
            label5.Text = ""; //Sumar todos los egresos del dia y mostrarlos en este label


            dataGridView1.DataSource = egresosController.Fill();
            List<string> proveedoresNames = new List<string>
            {
                "Seleccione un proveedor",
            };

            //Agregar todos los proveedores al combobox

            comboBox1.DataSource = proveedoresNames;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            egresosController.InsertItem("2", comboBox1.Text, textBox2.Text, "1");
            dataGridView1.DataSource = egresosController.Fill();
        }
    }
}
