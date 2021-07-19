using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Archivos;
using Excepciones;
namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Moya.Agustin.2D.TP3";

            
            List<Carta> cartas = new List<Carta>();


            Monstruo carta1 = new Monstruo("mago oscuro", "el mas grande de los magos en cuanto ataque y defensa", false, 2, 3, 3, 3, EAtributo.oscuridad, ENivel.sieteEstrella, Etipo.lanzador_de_conjuros, 2500, 2000, false);
            Magica carta2 = new Magica("De-Fusión", "Selecciona 1 Monstruo de Fusión en el Campo; devuelve ese objetivo al Deck Extra y después, si todos los Materiales de Fusión que fueron utilizados en su Invocación por Fusión están en tu Cementerio, puedes Invocar todos ellos de Modo Especial.", true, 3, 3, 3, 3, EtipoMagia.rapida);
            Trampa carta3 = new Trampa("Tablero del Destino", "Cuando esta carta y todas las 4 cartas Mensaje Espiritual con nombres diferentes son situadas en tu Campo, ganas el Duelo. Una vez por turno, durante la End Phase de tu adversario: pon boca arriba, desde tu mano o Deck, 1 carta Mensaje Espiritual en tu Zona de Magia y Trampas, en el orden adecuado de I, N, A, y L. Cuando cualquier carta Mensaje Espiritual o Tablero del Destino que controles deje el Campo, manda al Cementerio todas las cartas Mensaje Espiritual y Tablero del Destino que controles.", true, 5, 3, 3, 3, EtipoTrampa.continua);



            Console.WriteLine("\nprueba de sobrecarga del +  \n");
            try
            {
                if (cartas + carta1)
                {
                    Console.WriteLine($"Carta cargada con exito {carta1.NombreCarta}");
                }
                if (cartas + carta2)
                {
                    Console.WriteLine($"Carta2 cargada con exito {carta2.NombreCarta}");
                }
                if (cartas + carta3)
                {
                    Console.WriteLine($"Carta3 cargada con exito {carta3.NombreCarta}");
                }
            }
            catch (Exception e )
            {

                Console.WriteLine(e.Message); 
            }


            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\n prueba de mostrar informacion \n");
            try
            {
                foreach (Carta item in cartas)
                {
                    Console.WriteLine(item.InformacionCarta());
                }

            }
            catch (Exception e )
            {

                Console.WriteLine(e.Message);
            }


            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("se guarda y se lee xml\n");

            try
            {
                
                string ruta = AppDomain.CurrentDomain.BaseDirectory + "ListaCartasTest.xml"; //directorio + nombre archivo
                Xml<List<Carta>> xml1 = new Xml<List<Carta>>();
                if( xml1.Guardar(ruta, cartas)) 
                {
                    Console.WriteLine("xmlTest guardado");
                }

            }
            catch (Exception  )
            {
                throw new Exception("no se guardo el archivo");
           
            }

            try
            {

                string ruta = AppDomain.CurrentDomain.BaseDirectory + "ListaCartasTest.xml"; //busco la direccion del archvio junto a su nombre
                Xml<List<Carta>> xml = new Xml<List<Carta>>(); //creo archivo xml
                if(xml.Leer(ruta, out cartas)) //leo
                {
                    Console.WriteLine("se leyo el archivo xml correctamente");
                }

            }
            catch (Exception)
            {
                throw new Exception("no se pudo leer  el archivo");
             
            }


            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("\n prueba de mostrar informacion desde xml \n");
            try
            {
                foreach (Carta item in cartas)
                {
                    Console.WriteLine(item.InformacionCarta());
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }



            Console.ReadKey();

        }
    }
}
