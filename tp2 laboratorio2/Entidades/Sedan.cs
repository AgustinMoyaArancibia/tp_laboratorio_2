using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// constructor con parametros
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color ): base(chasis, marca, color)
        {
            
        }

        /// <summary>
        /// construsctor con parametros 
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color , ETipo tipo):this(marca,chasis,color)
        {
            this.tipo = ETipo.CuatroPuertas;
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// pripiedad get
        /// </summary>
        protected override ETamanio Tamanio 
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        /// <summary>
        /// metodo que muestra los parametros
        /// </summary>
        /// <returns>objeto string  </returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(string.Format(base.Mostrar()));
            sb.AppendLine(string.Format("TAMAÑO : {0}", this.Tamanio));
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
