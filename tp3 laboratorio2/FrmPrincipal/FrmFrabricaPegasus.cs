using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace FrmPrincipal
{
    public partial class FrmFabricaPegasus : Form
    {

        

        public FrmFabricaPegasus()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FabricaPegasus fabricaPegasus = new FabricaPegasus(0,0,0);



            //bool pudo;
            //pudo = cartasDisponibles + new Monstruo("mago oscuro", "el mas grande de los magos en cuanto ataque y defensa", false, 3, 3, 3, 3, EAtributo.oscuridad, ENivel.sieteEstrella, Etipo.lanzador_de_conjuros, 2500, 2000, false);
            //pudo = cartasDisponibles + new Monstruo("heroe elemental neos", "¡Un nuevo HÉROE Elemental ha llegado desde el Neo Espacio! Cuando inicia una Fusión de Contacto con un Neo Espacial sus desconocidos poderes son liberados.", false, 3, 3, 3, 3, EAtributo.luz, ENivel.sieteEstrella, Etipo.guerrero, 2500, 2000, false);
            //pudo = cartasDisponibles + new Monstruo("Caballero Sin Cabeza", "El espíritu maldito de un caballero acusado falsamente que vaga en busca de la verdad y la justicia.", false, 3, 3, 3, 3, EAtributo.tierra, ENivel.cuatroEstrella, Etipo.demonio, 1450, 1700, false);
            //pudo = cartasDisponibles + new Monstruo("Dragón Fantasma Espiral", "el mas grande de los magos en cuanto ataque y defensa", false, 3, 3, 3, 3, EAtributo.agua, ENivel.ochoEstrella, Etipo.wyrm, 2900, 2900, false);
            //pudo = cartasDisponibles + new Monstruo("Dragón Blanco de Ojos Azules", "Este legendario dragón es una poderosa máquina de destrucción. Virtualmente invencible, muy pocos se han enfrentado a esta impresionante criatura y han vivido para contarlo.", false, 10, 3, 3, 3, EAtributo.luz, ENivel.ochoEstrella, Etipo.dragon, 3000, 2500, false);
            //pudo = cartasDisponibles + new Monstruo("Chica Maga Oscura", "Gana 300 ATK por cada Mago Oscuro o Mago del Caos Negro en el Cementerio.", true, 3, 3, 3, 3, EAtributo.oscuridad, ENivel.seisEstrella, Etipo.lanzador_de_conjuros, 2000, 1700, false);
            //pudo = cartasDisponibles + new Monstruo("Yubel", "Esta carta no puede ser destruida en batalla. No recibes daño de batalla de batallas en las que esté involucrada esta carta. Antes del cálculo de daño, cuando esta carta en Posición de Ataque boca arriba es atacada por un monstruo de tu adversario: inflige daño a tu adversario igual al ATK de ese monstruo. Durante tu End Phase: Sacrifica 1 monstruo o destruye esta carta. Cuando esta carta es destruida, excepto por su propio efecto: su dueño puede Invocar de Modo Especial, desde su mano, Deck o Cementerio, 1 Yubel - Terror Encarnado", true, 10, 3, 3, 3, EAtributo.oscuridad, ENivel.diezEstrella, Etipo.demonio, 0, 0, false);
            //pudo = cartasDisponibles + new Monstruo("Ciber Dragón", "Si sólo tu adversario controla monstruos, puedes Invocar esta carta de Modo Especial (desde tu mano).", true, 10, 3, 3, 3, EAtributo.luz, ENivel.cincoEstrella, Etipo.maquina, 2100, 1600, false);
            //pudo = cartasDisponibles + new Monstruo("Dragón Ciber Final", "Ciber Dragón + Ciber Dragón + Ciber DragónUna Invocación por Fusión de esta carta sólo puede hacerse con los Materiales de Fusión listados arriba. Si esta carta ataca a un monstruo en Posición de Defensa, inflige daño de batalla de penetración.", true, 10, 3, 3, 3, EAtributo.luz, ENivel.diezEstrella, Etipo.maquina, 4000, 2800, true);
            //pudo = cartasDisponibles + new Monstruo("Dragoon Oscuro de Ojos Rojos", "Mago Oscuro + Dragón Negro de Ojos Rojos o 1 Monstruo de Efecto DragónNo puede ser destruido por efectos de cartas. Ningún jugador puede seleccionar esta carta con efectos de cartas. Durante tu Main Phase: puedes destruir 1 monstruo que controle tu adversario y, si lo haces, inflige daño a tu adversario igual al ATK original de ese monstruo. Puedes usar este efecto hasta tantas veces por turno como la cantidad de Monstruos Normales usados como Material de Fusión para esta carta. Una vez por turno, cuando es activada una carta o efecto (Efecto Rápido): puedes descartar 1 carta; niega la activación y, si lo haces, destruye esa carta y, si haces eso, esta carta gana 1000 ATK.", true, 10, 3, 3, 3, EAtributo.oscuridad, ENivel.ochoEstrella, Etipo.lanzador_de_conjuros, 3000, 2500, true);
            //pudo = cartasDisponibles + new Magica("mostruo renacido", "invoca especialmente un monstruo desde cualquier cementerio", true, 10, 3, 3, 3, EtipoMagia.normal);
            //pudo = cartasDisponibles + new Trampa("agujero trampa", "cuando tu adversario invoca de modo normal o por volteo un monstruo con 1000 atk o mas , selecciona ese monstruo y destruye ese objetivo", true, 10, 3, 3, 3, EtipoTrampa.normal);

            //if (pudo == false)
            //{
            //    MessageBox.Show("no se pudo añadir la carta");
            //}
            //this.dtgCartas.DataSource = cartasDisponibles;


            //try
            //{


            //    string ruta = AppDomain.CurrentDomain.BaseDirectory + "ListaCartas.xml";



                //using (XmlTextWriter auxWriter = new XmlTextWriter(ruta, Encoding.UTF8))
                //{


                //    XmlSerializer auxEscritor = new XmlSerializer((typeof(List<Carta>)));


                //    auxEscritor.Serialize(auxWriter, cartasDisponibles);


                //}

            //    using (XmlTextReader reader = new XmlTextReader(ruta))
            //    {
            //        //Utilizo un objeto de tipo XmlSerializer para deserializar la lista genérica.
            //        XmlSerializer ser = new XmlSerializer((typeof(List<Carta>)));

            //        //   Deserializo
            //        cartasDisponibles = (List<Carta>)ser.Deserialize(reader);


            //        this.dtgCartas.DataSource = cartasDisponibles;
            //    }

            //}


            //catch (Exception)
            //{
            //    throw;
            //}

            //}

            //try
            //{


            //    string ruta;

            //    ruta = AppDomain.CurrentDomain.BaseDirectory + "ListaCartas.xml";

            //    using (StreamWriter auxSw = new StreamWriter(ruta)) 
            //    {
            //        foreach (Carta item in cartasDisponibles)
            //        {
            //            auxSw.WriteLine(string.Format(" {0} , {1},{2},{3} ",item.NombreCarta.ToString(),item.DescropcionEfecto.ToString(), item.DescropcionEfecto.ToString(), item.Stock.ToString()));

            //        }

            //    }

            //    using (StreamReader auzSr = new StreamReader(ruta)) 
            //    {
            //        string lineaLeida = string.Empty;

            //        while ((lineaLeida = auzSr.ReadLine()) != null)
            //        {

            //        }



            //    }

            //}
            //catch (Exception)
            //{
            //    throw;

            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
         FrmCrearCartas frmCrear = new FrmCrearCartas();
           
            frmCrear.Show();
            this.Hide();
         
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCrearDeck frmCrearDeck = new FrmCrearDeck();

            frmCrearDeck.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //private void btnMostrarCarta_Click_1(object sender, EventArgs e)
        //{


        //    label1.ImageIndex = dtgCartas.CurrentCell.RowIndex; // igualo el indice del label  con la list de imagenes
        //    Carta carta = dtgCartas.CurrentRow.DataBoundItem as Carta; // convierto el item elejido en carta                               
        //    rtbInfoCartas.Text = carta.InformacionCarta(); //muestro la info del item conventido en un richtexbox

        //}

        //private void rtbInfoCartas_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private List<Carta> ActualizarMiDeck()
        //{
        //    List<Carta> deck = new List<Carta>();

        //    foreach (Carta item in miDeck)
        //    {
        //        deck.Add(item);
        //    }

        //    return miDeck = deck;
        //}

        //private void btnAgregarDeck_Click(object sender, EventArgs e)
        //{
        //    Carta carta = dtgCartas.CurrentRow.DataBoundItem as Carta; // obtengo la fila seleccionada y la convierto en carta

        //    //DataGridViewRow fila = new DataGridViewRow();
        //    //fila.CreateCells(dtvMiDeck);


        //    if (miDeck + carta)
        //    {

        //        carta.Stock--;
        //        MessageBox.Show("se agrego la carta a tu deck");


        //    }
        //    else if (carta.Stock == 0)
        //    {
        //        MessageBox.Show("no hay stock");
        //    }
        //    ActualizarMiDeck();
        //    dtvMiDeck.DataSource = miDeck;



        //}


        //private void dtvMiDeck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnReponerStock_Click(object sender, EventArgs e)
        //{
        //    foreach (Carta item in cartasDisponibles)
        //    {
        //        item.Stock += 3;
        //    }
        //    //Monstruo carta = null;

        //    //carta.Stock++;
        //}
    }

}