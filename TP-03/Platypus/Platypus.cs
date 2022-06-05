using BackendPlatypus;
using FrontendPlatypus;
using System;
using System.Windows.Forms;

namespace Platypus_2
{
    public partial class Platypus : Form
    {
        public Platypus()
        {
            InitializeComponent();
            label4.Text = SqlController.OpenConnection();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            homeControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            homeControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            VentasForm ventas = new();
            ventas.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            EgresosForm egresos = new();
            egresos.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            StockForm stock = new();
            stock.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            ProveedoresForm proveedores = new();
            proveedores.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            confirmExit1.BringToFront();
        }
    }
}
