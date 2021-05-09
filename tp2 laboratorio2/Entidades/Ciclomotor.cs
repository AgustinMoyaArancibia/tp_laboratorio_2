using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// constructor con parametros
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) :base(chasis,marca,color)
        {
        }

        /// <summary>
        /// propiedad get
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio 
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        /// <summary>
        /// metodo que muestra los parametros
        /// </summary>
        /// <returns>objeto string  </returns>
        public override  string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(string.Format(base.Mostrar()));
            sb.AppendLine(string.Format("TAMAÑO : {0}", this.Tamanio));
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
