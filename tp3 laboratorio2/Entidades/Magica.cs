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

        public Magica()
        {

        }
        public Magica(string nombreCarta, string descripcionEfecto, bool efecto, int stock, int porcentajeTinta, int madera, int carton, EtipoMagia tipoMagia) : base(nombreCarta, descripcionEfecto, efecto, stock, porcentajeTinta, madera, carton)
        {
            this.tipoMagia = tipoMagia;
        }

        public EtipoMagia TipoMagia { get { return this.tipoMagia; } set => tipoMagia = value; }
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

        public override string InformacionCarta()
        {

        StringBuilder sb = new StringBuilder();

         sb.AppendLine(base.InformacionCarta());
            sb.AppendLine($"tipo de magia {this.TipoMagia}");
          
            return sb.ToString();

        }
    }
}
