using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;
namespace Entidades
{


    public delegate void delAumentar();

    public static class FabricaPegasus
    {


        static int porcentajeTinta;
        static int madera;
        static int carton;
        static List<Carta> cartas;
        static List<Carta> deck;
        static List<int> listaMateriales;
       
        static SqlCommand comando;
        static SqlConnection conexion;


        /// <summary>
        /// constructo por defecto estico
        /// </summary>
        static FabricaPegasus()
        {
            cartas = new List<Carta>();
            ListaMateriales = new List<int> { 0, 0, 0 };
            deck = new List<Carta>();
            FabricaPegasus.LeerTodo();

            comando = new SqlCommand();
            conexion = new SqlConnection("Data Source = localhost; DataBase = MisCartas; Trusted_Connection = True;");
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
        public static List<int> ListaMateriales { get => listaMateriales; set => listaMateriales = value; }

        //hacer actualizar de nuevo


        /// <summary>
        /// muestra los materiales de la fabrica
        /// </summary>
        /// <returns>un objeto a string</returns>
        public static string MostrarMaterialesFabrica()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"tinta: {FabricaPegasus.listaMateriales[0]} ");
            sb.AppendLine($"madera: {FabricaPegasus.listaMateriales[1]}");
            sb.AppendLine($"carton: {FabricaPegasus.listaMateriales[2]}");


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
        /// guarda los materiales en un archivo de texto
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns>true si pudo , false si no</returns>
        public static bool GuardarMaterialesTxt(string ruta)
        {

            Texto texto = new Texto();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de tinta comprado: {FabricaPegasus.listaMateriales[0]}");
            sb.AppendLine($"Cantidad de madera comprado: {FabricaPegasus.listaMateriales[1]}");
            sb.AppendLine($"cantidad de carton comprado: {FabricaPegasus.listaMateriales[2]}");
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

        public static void LeerTodo()
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "ListaCartas.xml"; //busco la direccion del archvio junto a su nombre
            Xml<List<Carta>> xml = new Xml<List<Carta>>(); //creo archivo xml
            xml.Leer(ruta, out cartas); //leo

            string ruta1 = AppDomain.CurrentDomain.BaseDirectory + "MisCartas.xml"; //busco la direccion del archvio junto a su nombre
            Xml<List<Carta>> xml1 = new Xml<List<Carta>>(); //creo archivo xml
            xml1.Leer(ruta1, out deck); //leo

            string ruta2 = AppDomain.CurrentDomain.BaseDirectory + "MisMateriales.xml"; //busco la direccion del archvio junto a su nombre
            Xml<List<int>> xml2 = new Xml<List<int>>(); //creo archivo xml
            xml2.Leer(ruta2, out listaMateriales); //leo
        }

        public static void GuardarTodo()
        {
            bool pudo;
            string ruta1 = AppDomain.CurrentDomain.BaseDirectory + "ListaCartas.xml"; //directorio + nombre archivo
            Xml<List<Carta>> xml1 = new Xml<List<Carta>>();
            pudo = xml1.Guardar(ruta1, FabricaPegasus.ActualizarCartas());

            string ruta2 = AppDomain.CurrentDomain.BaseDirectory + "MisMateriales.xml"; //directorio + nombre archivo
            Xml<List<int>> xml2 = new Xml<List<int>>();
            pudo = xml2.Guardar(ruta2, FabricaPegasus.ListaMateriales);

            string rutaTxt = AppDomain.CurrentDomain.BaseDirectory + "MisMateriales.txt"; //directorio + nombre archivo
            FabricaPegasus.GuardarMaterialesTxt(rutaTxt);

            string ruta3 = AppDomain.CurrentDomain.BaseDirectory + "MisCartas.xml"; //directorio + nombre archivo
            Xml<List<Carta>> xml3 = new Xml<List<Carta>>();
            pudo = xml3.Guardar(ruta3, FabricaPegasus.ActualizarMisCartas());

        }

        public static bool InsertarCarta(Carta carta) 
        {

            bool retorno = false;

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;


                comando.CommandText = "INSERT INTO ListaCartasTp4 ([Nombre],[Stock] ,[Descripcion] ,[TieneEfecto],[Tinta],[Madera] ,[Carton]  )"
                    + "VALUES (@nombre,@stock,@descripcion,@tieneEfecto,@tinta,@madera,@carton)";


                //comando.Parameters.AddWithValue("@Tipo", carta.GetType().ToString());
                comando.Parameters.AddWithValue("@nombre", carta.NombreCarta);
                comando.Parameters.AddWithValue("@stock", carta.Stock);
                comando.Parameters.AddWithValue("@descripcion", carta.DescropcionEfecto);
                comando.Parameters.AddWithValue("@tieneEfecto", carta.Efecto.ToString());
                comando.Parameters.AddWithValue("@tinta", carta.PorcentajeTinta);
                comando.Parameters.AddWithValue("@madera", carta.Madera);
                comando.Parameters.AddWithValue("@carton", carta.Madera);
                

                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception )
            {

                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();

                }
            }


            return retorno;

        }

        public static string LeerCarta()
        {
            try
            {
                string logs = string.Empty;

    

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;

                comando.CommandText = "SELECT Nombre  FROM ListaCartasTp4;";
                conexion.Open();

                SqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {

                    logs += $"{dataReader["Nombre"].ToString()}\n ";
                }
                return logs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

    }
}
