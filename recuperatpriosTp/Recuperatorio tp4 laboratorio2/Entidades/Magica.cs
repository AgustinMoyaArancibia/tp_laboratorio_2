using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Magica : Carta
    {

        private EtipoMagia tipoMagia;


        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Magica()
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
        /// <param name="tipoMagia"></param>
        public Magica(string nombreCarta, string descripcionEfecto, bool efecto, int stock, int porcentajeTinta, int madera, int carton, EtipoMagia tipoMagia) : base(nombreCarta, descripcionEfecto, efecto, stock, porcentajeTinta, madera, carton)
        {
            this.tipoMagia = tipoMagia;
        }


        /// <summary>
        /// propiedad , obtiene y escribe el tipo de magia
        /// </summary>
        public EtipoMagia TipoMagia { get { return this.tipoMagia; } set => tipoMagia = value; }

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
        /// muestra la informacion de la clase magica
        /// </summary>
        /// <returns>objeto a string </returns>
        public override string InformacionCarta()
        {

        StringBuilder sb = new StringBuilder();

         sb.AppendLine(base.InformacionCarta());
            sb.AppendLine($"tipo de magia {this.TipoMagia}");
          
            return sb.ToString();

        }
    }
}
