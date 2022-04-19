using System;
using System.Text;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        public Suv(EMarca marca, string chasis, ConsoleColor color)
           : base(marca, chasis, color, ETamanio.Grande)
        {
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {Tamanio}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
