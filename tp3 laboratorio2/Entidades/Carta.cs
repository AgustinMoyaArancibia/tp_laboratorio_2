using System;
using System.Collections.Generic;
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

        public Carta()
        {

        }
        protected Carta(string nombreCarta, string descripcionEfecto, bool efecto, int stock)
        {
            this.NombreCarta = nombreCarta;
            this.descripcionEfecto = descripcionEfecto;
            this.Efecto = efecto;
            this.stock = stock;
        }


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

        public string NombreCarta { get => nombreCarta; set => nombreCarta = value; }
        public string DescropcionEfecto { get => descripcionEfecto; set => descripcionEfecto = value; }
        public bool Efecto { get => efecto; set => efecto = value; }
        public int PorcentajeTinta { get => porcentajeTinta; set => porcentajeTinta = value; }
        public int Madera { get => madera; set => madera = value; }
        public int Carton { get => carton; set => carton = value; }

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

        public static bool operator +(List<Carta> miDeck, Carta carta)
        {
            if (carta.Stock > 0)
            {
                miDeck.Add(carta);
                return true;

            }
            return false;
        }

        public static bool operator -(List<Carta> miDeck, Carta carta)
        {

            miDeck.Remove(carta);
            return true;



        }


        public static bool operator ==(List<Carta> miDeck, Carta carta)
        {
            foreach (Carta item in miDeck)
            {
                if (item.GetType() == carta.GetType() && item.NombreCarta == carta.NombreCarta)
                {
                    miDeck.Remove(carta);
                    return true;

                }
            }


            return false;

        }

        public static bool operator !=(List<Carta> miDeck, Carta carta)
        {
            return !(miDeck == carta);
        }
    }
}