using System;
using System.Text;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        readonly EMarca Marca;
        readonly string Chasis;
        readonly ConsoleColor Color;

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        public ETamanio Tamanio { get; }

        public Vehiculo(EMarca marca, string chasis, ConsoleColor color, ETamanio tamanio)
        {
            Marca = marca;
            Chasis = chasis;
            Color = color;
            Tamanio = tamanio;
        }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CHASIS: {p.Chasis}\r");
            sb.AppendLine($"MARCA : {p.Marca}\r");
            sb.AppendLine($"COLOR : {p.Color}\r");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Chasis == v2.Chasis;
        }

        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return v1.Chasis == v2.Chasis;
        }

        public enum EMarca
        {
            Chevrolet, 
            Ford, 
            Renault, 
            Toyota, 
            BMW, 
            Honda, 
            HarleyDavidson
        }

        public enum ETamanio
        {
            Chico, 
            Mediano, 
            Grande
        }
    }
}
