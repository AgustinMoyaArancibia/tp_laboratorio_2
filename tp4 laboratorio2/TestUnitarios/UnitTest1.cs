using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Entidades;
using Excepciones;
using Archivos;
namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
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
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "ListaCartasTest.xml"; //directorio + nombre archivo


            List<Carta> cartas = new List<Carta>();


            Xml<List<Carta>> xml = new Xml<List<Carta>>(); //creo archivo xml


            Assert.IsTrue(xml.Guardar(ruta, cartas));
           

        }

    }
}
