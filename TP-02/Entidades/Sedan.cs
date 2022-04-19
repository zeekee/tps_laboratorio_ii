using System;
using System.Text;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        private readonly ETipo Tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color, ETamanio.Mediano)
        {
            Tipo = ETipo.CuatroPuertas;
        }

        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(marca, chasis, color, ETamanio.Mediano)
        {
            Tipo = tipo;
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {Tamanio}");
            sb.AppendLine($"TIPO : {Tipo}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        public enum ETipo 
        { 
            CuatroPuertas, 
            CincoPuertas 
        }
    }
}
