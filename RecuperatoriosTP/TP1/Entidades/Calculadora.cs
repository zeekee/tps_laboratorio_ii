namespace Entidades
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            if (operador.Equals('+') || operador.Equals('-') || operador.Equals('*') || operador.Equals('/'))
            {
                return operador;
            }
            else
            {
                return '+';
            }
        }

        public static double Operar(Operando num1, Operando num2, char operador)
        {
            Operando operando = new();
            double resultado = 0;

            switch (ValidarOperador(operador))
            {
                case '+':
                    resultado = operando.OperadorSuma(num1, num2);
                    break;
                case '-':
                    resultado = operando.OperadorResta(num1, num2);
                    break;
                case '*':
                    resultado = operando.OperadorMultiplicacion(num1, num2);
                    break;
                case '/':
                    resultado = operando.OperadorDivision(num1, num2);
                    break;
            }

            return resultado;
        }
    }
}
