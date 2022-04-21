using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        private readonly List<Vehiculo> Vehiculos = new List<Vehiculo>();
        private readonly int EspacioDisponible;

        public Taller(int espacioDisponible)
        {
            EspacioDisponible = espacioDisponible;
        }

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"
        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Tenemos {taller.Vehiculos.Count} lugares ocupados de un total de {taller.EspacioDisponible} disponibles");
            sb.AppendLine("");
            foreach (Vehiculo vehiculo in taller.Vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Camioneta:
                        if (vehiculo.Tamanio == Vehiculo.ETamanio.Grande)
                        {
                            sb.AppendLine(vehiculo.Mostrar());
                        }
                        break;
                    case ETipo.Moto:
                        if (vehiculo.Tamanio == Vehiculo.ETamanio.Chico)
                        {
                            sb.AppendLine(vehiculo.Mostrar());
                        }
                        break;
                    case ETipo.Automovil:
                        if (vehiculo.Tamanio == Vehiculo.ETamanio.Mediano)
                        {
                            sb.AppendLine(vehiculo.Mostrar());
                        }
                        break;
                    default:
                        sb.AppendLine(vehiculo.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculoParam">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculoParam)
        {
            foreach (Vehiculo vehiculo in taller.Vehiculos)
            {
                if (vehiculo == vehiculoParam)
                {
                    return taller;
                }
            }

            if (taller.Vehiculos.Count < taller.EspacioDisponible)
            {
                taller.Vehiculos.Add(vehiculoParam);
            }

            return taller;
        }

        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculoParam">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculoParam)
        {
            foreach (Vehiculo vehiculo in taller.Vehiculos)
            {
                if (vehiculo == vehiculoParam)
                {
                    taller.Vehiculos.Remove(vehiculo);
                    break;
                }
            }

            return taller;
        }
        #endregion

        public enum ETipo
        {
            Moto, 
            Automovil, 
            Camioneta, 
            Todos
        }
    }
}
