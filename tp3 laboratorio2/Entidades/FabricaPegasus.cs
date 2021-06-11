using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class FabricaPegasus
    {



        static int porcentajeTinta;
        static int madera;
        static int carton;


        public static int PorcentajeTinta { get => porcentajeTinta; set => porcentajeTinta = value; }
        public static int Madera { get => madera; set => madera = value; }
        public static int Carton { get => carton; set => carton = value; }


        public static string MostrarMaterialesFabrica()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"tinta: {PorcentajeTinta} ");
            sb.AppendLine($"madera: {Madera}");
            sb.AppendLine($"carton: {Carton}");

            return sb.ToString();

        }


    }
}
