using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Monstruo))]
    [XmlInclude(typeof(Magica))]
    [XmlInclude(typeof(Trampa))]
    public abstract class Carta
    {

        protected string nombreCarta;
        protected string descripcionEfecto;
        protected bool efecto;
        protected int stock;

        private int porcentajeTinta;
        private int madera;
        private int carton;


        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Carta()
        {

        }
        /// <summary>
        /// constructor parametrizado
        /// </summary>
        /// <param name="nombreCarta"></param>
        /// <param name="descripcionEfecto"></param>
        /// <param name="efecto"></param>
        /// <param name="stock"></param>
        protected Carta(string nombreCarta, string descripcionEfecto, bool efecto, int stock)
        {
            this.NombreCarta = nombreCarta;
            this.descripcionEfecto = descripcionEfecto;
            this.Efecto = efecto;
            this.stock = stock;
        }

        /// <summary>
        /// constructor parametrizado con una sobrecargar
        /// </summary>
        /// <param name="nombreCarta"></param>
        /// <param name="descripcionEfecto"></param>
        /// <param name="efecto"></param>
        /// <param name="stock"></param>
        /// <param name="porcentajeTinta"></param>
        /// <param name="madera"></param>
        /// <param name="carton"></param>
        protected Carta(string nombreCarta, string descripcionEfecto, bool efecto, int stock, int porcentajeTinta, int madera, int carton) : this(nombreCarta, descripcionEfecto, efecto, stock)
        {
            this.NombreCarta = nombreCarta;
            this.descripcionEfecto = descripcionEfecto;
            this.Efecto = efecto;
            this.stock = stock;
            this.PorcentajeTinta = porcentajeTinta;
            this.Madera = madera;
            this.Carton = carton;
        }


        /// <summary>
        /// propiedad Stock
        /// </summary>
        public virtual int Stock
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
        /// propiedad, obtiene y escribe el nombre de la carta 
        /// </summary>
        public string NombreCarta { get => nombreCarta; set => nombreCarta = value; }

        /// <summary>
        /// propiedad,  obtiene y escribe la descricion de la carta 
        /// </summary>
        public string DescropcionEfecto { get => descripcionEfecto; set => descripcionEfecto = value; }


        /// <summary>
        /// propiedad,  obtiene y escribe el efecto de la carta 
        /// </summary>
        public bool Efecto { get => efecto; set => efecto = value; }

        /// <summary>
        /// propiedad,  obtiene y escribe la tinta de la carta 
        /// </summary>
        public int PorcentajeTinta { get => porcentajeTinta; set => porcentajeTinta = value; }

        /// <summary>
        /// propiedad,  obtiene y escribe la madera de la carta 
        /// </summary>
        public int Madera { get => madera; set => madera = value; }

        /// <summary>
        /// propiedad,  obtiene y escribe el carton de la carta 
        /// </summary>
        public int Carton { get => carton; set => carton = value; }


      

        /// <summary>
        /// muestra la informacion de la carta
        /// </summary>
        /// <returns> regresa un objeto string </returns>
        public virtual string InformacionCarta()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("*********************************************");
            sb.AppendLine($"\nNombre: {this.NombreCarta} ");


            if (this.Efecto)
            {
                sb.AppendFormat("\nefecto");
            }
            else
            {
                sb.AppendFormat("\ndescripcion");
            }
            sb.Append($"\n{this.DescropcionEfecto} \n");
            sb.AppendLine($"stock {this.Stock} ");
            sb.AppendLine($"tinta {this.PorcentajeTinta} ");
            sb.AppendLine($"madera {this.Madera} ");
            sb.AppendLine($"carton {this.Carton} ");
            return sb.ToString();
        }


        /// <summary>
        /// sobrecargar de + , añade una carta a una lista 
        /// </summary>
        /// <param name="miDeck"></param>
        /// <param name="carta"></param>
        /// <returns>true si pudo añadir , false si no</returns>
        public static bool operator +(List<Carta> miDeck, Carta carta)
        {
            if (carta.Stock > 0)
            {
                miDeck.Add(carta);
                return true;

            }
            return false;
        }



    }
}