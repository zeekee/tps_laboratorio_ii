using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            cmbOperador.DataSource = new List<string> { string.Empty, "+", "-", "*", "/" };
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new(numero1);
            Operando num2 = new(numero2);

            return Calculadora.Operar(num1, num2, operador[0]);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {lblResultado.Text}");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.Text = string.Empty;
            lblResultado.Text = "0";
        }

        private void btnConvertBinario_Click(object sender, EventArgs e)
        {
            Operando operando = new();
            lblResultado.Text = operando.DecimalBinario(lblResultado.Text);
        }

        private void btnConvertDecimal_Click(object sender, EventArgs e)
        {
            Operando operando = new();
            lblResultado.Text = operando.BinarioDecimal(lblResultado.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
