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
using Archivos;
namespace FrmPrincipal
{
    public partial class FrmCrearDeck : Form
    {
        public List<Carta> miDeck;
        List<Carta> cartasDisponibles;

        public FrmCrearDeck()
        {
            InitializeComponent();
            miDeck = new List<Carta>();
            cartasDisponibles = new List<Carta>();
        }



        private void FrmCrearDeck_Load(object sender, EventArgs e)
        {

            string rutaDeck = AppDomain.CurrentDomain.BaseDirectory + "MiDeck.xml";
            Xml<List<Carta>> xml = new Xml<List<Carta>>();

            xml.Leer(rutaDeck, out miDeck);
            this.dtvMiDeck.DataSource = miDeck;


            string ruta = AppDomain.CurrentDomain.BaseDirectory + "ListaCartas.xml"; //busco la direccion del archvio junto a su nombre
         
            xml.Leer(ruta, out cartasDisponibles); //leo
            this.dtgCartas.DataSource = cartasDisponibles; //se lo paso al datagreed
 

        }

        private void btnMostrarCarta_Click(object sender, EventArgs e)
        {

            lbImage.ImageIndex = dtgCartas.CurrentCell.RowIndex; // igualo el indice del label  con la list de imagenes
            Carta carta = dtgCartas.CurrentRow.DataBoundItem as Carta; // convierto el item elejido en carta                               
            rtbInfoCartas.Text = carta.InformacionCarta(); //muestro la info del item conventido en un richtexbox
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Carta carta = dtgCartas.CurrentRow.DataBoundItem as Carta; // obtengo la fila seleccionada y la convierto en carta


            if (miDeck + carta)
            {

                carta.Stock--;
                MessageBox.Show("se agrego la carta a tu deck");


            }
            else if (carta.Stock == 0)
            {
                MessageBox.Show("no hay stock");
            }
            ActualizarMiDeck();
            dtvMiDeck.DataSource = miDeck;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmFabricaPegasus frmFabricaPegasus = new FrmFabricaPegasus();

            frmFabricaPegasus.Show();

        }

        private List<Carta> ActualizarMiDeck()
        {
            List<Carta> deck = new List<Carta>();

            foreach (Carta item in miDeck)
            {
                deck.Add(item);
            }

            return miDeck = deck;
        }

        private void button3_Click_1(object sender, EventArgs e) //guardar
        {
            bool pudo = false;

            string ruta = AppDomain.CurrentDomain.BaseDirectory + "MiDeck.xml"; //directorio + nombre archivo
            Xml<List<Carta>> xml = new Xml<List<Carta>>();

            pudo = xml.Guardar(ruta, miDeck);

            this.Close();

            Program.frmFabricaPegasus.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carta carta = dtvMiDeck.CurrentRow.DataBoundItem as Carta; // obtengo la fila seleccionada y la convierto en carta


            if (miDeck - carta)
            {

                carta.Stock++;
                MessageBox.Show("se quito la carta del deck");


            }
            else if (carta is null)
            {
                MessageBox.Show("no se pudo quitar la carta");
            }

            ActualizarMiDeck();
            dtvMiDeck.DataSource = miDeck;
        }
    }
}
