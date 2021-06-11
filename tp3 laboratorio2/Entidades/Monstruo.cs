using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Monstruo : Carta
    {
        private EAtributo atributo;
        private ENivel nivel;
        private Etipo tipo;
        private int ataque;
        private int defensa;
        private bool fusion;

        public Monstruo()
        {

        }
        public Monstruo(string nombreCarta, string descripcionEfecto, bool efecto, int stock,int tinta , int madera , int carton, EAtributo atributo, ENivel nivel, Etipo tipo, int ataque, int defensa, bool fusion) : base(nombreCarta, descripcionEfecto, efecto, stock, tinta,  madera, carton)
        {
            this.atributo = atributo;
            this.nivel = nivel;
            this.tipo = tipo;
            this.ataque = ataque;
            this.defensa = defensa;
            this.fusion = fusion;
        }

        public EAtributo Atributo { get { return this.atributo; } set { this.atributo = value; } }
        public ENivel Nivel { get { return this.nivel; } set { this.nivel = value; } }

        public Etipo Tipo { get { return this.tipo; } set { this.tipo = value; } }

        public int Ataque
        {
            get
            {
                if (this.ataque >= 0)
                {
                    return this.ataque;
                }
                else
                {
                    return -1;
                }
            }

            set { this.ataque = value; }
        }

        public int Defensa
        {
            get
            {
                if (this.defensa >= 0)
                {
                    return this.defensa;
                }
                else
                {
                    return -1;
                }
            }
            set { this.defensa = value; }
        }

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
            sb.AppendLine($"su atributo es: {this.Atributo}");
            switch (this.Nivel)
            {
                case ENivel.unaEstrella:
                    sb.AppendLine("nivel *");
                    break;
                case ENivel.dosEstrella:
                    sb.AppendLine("nivel **");
                    break;
                case ENivel.tresEstrella:
                    sb.AppendLine("nivel ***");
                    break;
                case ENivel.cuatroEstrella:
                    sb.AppendLine("nivel ****");
                    break;
                case ENivel.cincoEstrella:
                    sb.AppendLine("nivel *****");
                    break;
                case ENivel.seisEstrella:
                    sb.AppendLine("nivel ******");
                    break;
                case ENivel.sieteEstrella:
                    sb.AppendLine("nivel *******");
                    break;
                case ENivel.ochoEstrella:
                    sb.AppendLine("nivel ********");
                    break;
                case ENivel.nueveEstrella:
                    sb.AppendLine("nivel *********");
                    break;
                case ENivel.diezEstrella:
                    sb.AppendLine("nivel **********");
                    break;
                case ENivel.onceEstrella:
                    sb.AppendLine("nivel ***********");
                    break;
                case ENivel.doceEstrella:
                    sb.AppendLine("nivel ************");
                    break;

            }
            sb.AppendLine($"su tipo es: {this.Tipo}");
            sb.AppendLine($"su ataque es: {this.Ataque}");
            sb.AppendLine($"su defensa es: {this.Defensa}");
            if (this.fusion == true)
            {

                sb.AppendLine("fusion");
            }

            return sb.ToString();
        }




    }
}
