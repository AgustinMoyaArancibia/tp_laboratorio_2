using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Trampa : Carta
    {
        private EtipoTrampa tipoTrampa;

        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Trampa()
        {

        }

        /// <summary>
        /// constructor con parametros
        /// </summary>
        /// <param name="nombreCarta"></param>
        /// <param name="descripcionEfecto"></param>
        /// <param name="efecto"></param>
        /// <param name="stock"></param>
        /// <param name="porcentajeTinta"></param>
        /// <param name="madera"></param>
        /// <param name="carton"></param>
        /// <param name="tipoTrampa"></param>
        public Trampa(string nombreCarta, string descripcionEfecto, bool efecto, int stock, int porcentajeTinta, int madera, int carton, EtipoTrampa tipoTrampa) : base(nombreCarta, descripcionEfecto, efecto, stock, porcentajeTinta, madera, carton)
        {
            this.tipoTrampa = tipoTrampa;
        }


        /// <summary>
        /// obtiene y escribe el tipo de trampa
        /// </summary>
        public EtipoTrampa TipoTrampa { get { return this.tipoTrampa; } set => tipoTrampa = value; }

        /// <summary>
        /// obtiene y escribe el stock
        /// </summary>
        public override int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }


        /// <summary>
        /// muestra la informacion de tramoa
        /// </summary>
        /// <returns></returns>
        public override string InformacionCarta()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.InformacionCarta());
            sb.AppendLine($"tipo de trampa {this.TipoTrampa}");

            return sb.ToString();

        }

    }
}
