using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Entidades;
using Excepciones;
using Archivos;
namespace TestUnitarios
{
    [TestClass]
    public class TestTP
    {
        /// <summary>
        /// analiza si se agergo una carta a la lista 
        /// </summary>
        [TestMethod]
        public void AgregaLista()
        {



            List<Carta> cartas = new List<Carta>();
            Monstruo carta1 = new Monstruo("mago oscuro", "el mas grande de los magos en cuanto ataque y defensa", false, 2, 3, 3, 3, EAtributo.oscuridad, ENivel.sieteEstrella, Etipo.lanzador_de_conjuros, 2500, 2000, false);



            bool pudo = false;

            pudo = cartas + carta1;


            Assert.IsTrue(pudo);
        }

        /// <summary>
        /// analiza si guardo archivo 
        /// </summary>
        [TestMethod]
        public void GuardeArchivo()
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "ListaCartasTest1.xml"; //directorio + nombre archivo


            List<Carta> cartasTest1 = new List<Carta>
            {  new Trampa("agujero trampa", "cuando tu adversario invoca de modo normal o por volteo un monstruo con 1000 atk o mas , selecciona ese monstruo y destruye ese objetivo", true, 10, 3, 3, 3, EtipoTrampa.normal),
               new Magica("mostruo renacido", "invoca especialmente un monstruo desde cualquier cementerio", true, 10, 3, 3, 3, EtipoMagia.normal),
               new Monstruo("Dragón Ciber Final", "Ciber Dragón + Ciber Dragón + Ciber DragónUna Invocación por Fusión de esta carta sólo puede hacerse con los Materiales de Fusión listados arriba. Si esta carta ataca a un monstruo en Posición de Defensa, inflige daño de batalla de penetración.", true, 10, 3, 3, 3, EAtributo.luz, ENivel.diezEstrella, Etipo.maquina, 4000, 2800, true)
            };

            List<Carta> cartasLeidas = new List<Carta>();
            Xml<List<Carta>> xmlTest1 = new Xml<List<Carta>>(); //creo archivo xml

            xmlTest1.Guardar(ruta, cartasTest1);
            xmlTest1.Leer(ruta, out cartasLeidas);

           Assert.AreEqual(cartasTest1.Count, cartasLeidas.Count); // si hay la misma cantidadd de objetos guardados
       

        }

    }
}