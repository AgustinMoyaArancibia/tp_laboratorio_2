using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;
namespace Entidades
{
    public static class FabricaPegasus
    {



        static int porcentajeTinta;
        static int madera;
        static int carton;
        static List<Carta> cartas;
        static List<Carta> deck;


        /// <summary>
        /// constructo por defecto estico
        /// </summary>
        static FabricaPegasus()
        {
            cartas = new List<Carta>();



            deck = new List<Carta>();


            string ruta = AppDomain.CurrentDomain.BaseDirectory + "ListaCartas.xml"; //busco la direccion del archvio junto a su nombre
            Xml<List<Carta>> xml = new Xml<List<Carta>>(); //creo archivo xml
            xml.Leer(ruta, out cartas); //leo

            string ruta1 = AppDomain.CurrentDomain.BaseDirectory + "MisCartas.xml"; //busco la direccion del archvio junto a su nombre
            Xml<List<Carta>> xml1 = new Xml<List<Carta>>(); //creo archivo xml
            xml1.Leer(ruta1, out deck); //leo


        }

        /// <summary>
        ///  /// <summary>
        /// propiedad,  obtiene y escribe la tinta de la carta 
        /// </summary>
        public static int PorcentajeTinta { get => porcentajeTinta; set => porcentajeTinta = value; }

        /// <summary>
        /// propiedad,  obtiene y escribe la madera de la carta 
        /// </summary>
        public static int Madera { get => madera; set => madera = value; }


        /// <summary>
        /// propiedad,  obtiene y escribe el carton de la carta 
        /// </summary>
        public static int Carton { get => carton; set => carton = value; }

        /// <summary>
        /// obtiene la lista de cartas 
        /// </summary>
        public static List<Carta> Cartas { get => cartas; set => cartas = value; }

        /// <summary>
        /// obtiene la lista de cartas 
        /// </summary>
        public static List<Carta> Deck { get => deck; set => deck = value; }

        //hacer actualizar de nuevo


        /// <summary>
        /// muestra los materiales de la fabrica
        /// </summary>
        /// <returns>un objeto a string</returns>
        public static string MostrarMaterialesFabrica()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"tinta: {PorcentajeTinta} ");
            sb.AppendLine($"madera: {Madera}");
            sb.AppendLine($"carton: {Carton}");

            return sb.ToString();

        }

        /// <summary>
        /// actualizo los items de la carta 
        /// </summary>
        /// <returns>lista actualizada</returns>
        public static List<Carta> ActualizarCartas()
        {

            List<Carta> auxCartas = new List<Carta>();
            foreach (Carta item in FabricaPegasus.Cartas)
            {
                auxCartas.Add(item);
            }

            return Cartas = auxCartas;
        }


        /// <summary>
        /// actualizo los items de la carta 
        /// </summary>
        /// <returns>lista actualizada</returns>
        public static List<Carta> ActualizarMisCartas()
        {

            List<Carta> auxCartas = new List<Carta>();
            foreach (Carta item in deck)
            {
                auxCartas.Add(item);
            }

            return deck = auxCartas;
        }


        /// <summary>
        /// muestra las cartas compradas 
        /// </summary>
        /// <returns>un ibjeto string </returns>
        public static string MostrarCompras()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Carta item in deck)
            {
                sb.AppendLine(item.NombreCarta);
            }

            return sb.ToString();
        }



        /// <summary>
        /// guarda los materiales en un archivo de texto
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns>true si pudo , false si no</returns>
        public static bool GuardarMaterialesTxt(string ruta)
        {

            Texto texto = new Texto();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"cantidad de carton disponible: {carton}");
            sb.AppendLine($"Cantidad de tinta disponible: {PorcentajeTinta}");
            sb.AppendLine($"Cantidad de madera: {madera}");
            sb.AppendLine($"{DateTime.Now}");


            return texto.Guardar(ruta, sb.ToString());
        }


        /// <summary>
        /// lee el archivo de materiales
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns>devuelve los datos en string </returns>
        public static string LeerMaterialesTxt(string ruta)
        {
            string datos;
            Texto auxTexto = new Texto();

            auxTexto.Leer(ruta, out datos);

            return datos;
        }



    }
}
