using System;
using System.Linq;

namespace Entidades
{
    public class Operando
    {
        private const string ValorInvalido = "Valor inválido";
        private double numero;

        public string Numero { set { numero = ValidarOperando(value); } }

        public Operando()
        {
            numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        private double ValidarOperando(string strNumero)
        {
            string fixNumero = strNumero.Replace('.', ',');
            return double.TryParse(fixNumero, out numero) ? numero : 0;
        }

        private bool EsBinario(string binario)
        {
            return !binario.Any(c => c != '0' && c != '1' && c != '.');
        }

        private string ObtenerValorEnteroAbsoluto(string numero)
        {
            if (numero == "Valor inválido")
            {
                numero = "0";
            }

            try
            {
                decimal truncateNumber = Math.Truncate(Convert.ToDecimal(numero));
                return Math.Abs(truncateNumber).ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }

        public string BinarioDecimal(string binario)
        {
            string resultado;

            if (!string.IsNullOrWhiteSpace(binario) && EsBinario(binario))
            {
                resultado = Convert.ToInt32(ObtenerValorEnteroAbsoluto(binario), 2).ToString();
            }
            else
            {
                resultado = ValorInvalido;
            }

            return resultado;
        }

        public string DecimalBinario(string numero)
        {
            string resultado;

            if (!numero.Equals(double.MinValue.ToString()) && Int32.TryParse(ObtenerValorEnteroAbsoluto(numero), out int num))
            {
                resultado = Convert.ToString(num, 2);
            }
            else
            {
                resultado = ValorInvalido;
            }

            return resultado;
        }

        public string DecimalBinario(double numero)
        {
            string resultado;

            try
            {
                resultado = Convert.ToString((int)numero, 2);
            }
            catch
            {
                resultado = ValorInvalido;
            }

            return resultado;
        }

        public double OperadorSuma(Operando numeroUno, Operando numeroDos)
        {
            return numeroUno.numero + numeroDos.numero;
        }

        public double OperadorResta(Operando numeroUno, Operando numeroDos)
        {
            return numeroUno.numero - numeroDos.numero;
        }

        public double OperadorMultiplicacion(Operando numeroUno, Operando numeroDos)
        {
            return numeroUno.numero * numeroDos.numero;
        }

        public double OperadorDivision(Operando numeroUno, Operando numeroDos)
        {
            return numeroDos.numero != 0 ? numeroUno.numero / numeroDos.numero : double.MinValue;
        }
    }
}
