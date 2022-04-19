using System;
using System.Text;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color, ETamanio.Chico)
        {
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {Tamanio}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
