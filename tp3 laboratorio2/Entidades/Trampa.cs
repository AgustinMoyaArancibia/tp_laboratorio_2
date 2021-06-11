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

        public Trampa()
        {

        }
        public Trampa(string nombreCarta, string descripcionEfecto, bool efecto, int stock, int porcentajeTinta, int madera, int carton, EtipoTrampa tipoTrampa) : base(nombreCarta, descripcionEfecto, efecto, stock, porcentajeTinta, madera, carton)
        {
            this.tipoTrampa = tipoTrampa;
        }

        public EtipoTrampa TipoTrampa { get { return this.tipoTrampa; } set => tipoTrampa = value; }
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
            sb.AppendLine($"tipo de trampa {this.TipoTrampa}");

            return sb.ToString();

        }

    }
}
