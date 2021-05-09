using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }


        /// <summary>
        /// constructor con parametros
        /// </summary>
        /// <param name="chasis"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        public Vehiculo(string chasis, EMarca marca , ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;

        }


        /// <summary>
        /// metodo que muestra los parametros
        /// </summary>
        /// <returns>objeto string  </returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("CHASIS: {0}\r\n", this.chasis));
            sb.AppendLine(string.Format("MARCA : {0}\r\n", this.marca));
            sb.AppendLine(string.Format("COLOR : {0}\r\n", this.color));
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        public static explicit operator string(Vehiculo p)
        {
            return p.Mostrar();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns> true si son iguales sino flase</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if(v1.chasis == v2.chasis) 
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>si son diferente true sino false</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }
    }
}
