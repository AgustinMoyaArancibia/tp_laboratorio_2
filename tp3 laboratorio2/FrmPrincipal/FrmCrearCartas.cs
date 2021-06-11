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
using Excepciones;

namespace FrmPrincipal
{
    public partial class FrmCrearCartas : Form
    {

        public List<Carta> miDeck;
        List<Carta> cartasDisponibles;
      
      
        public FrmCrearCartas()
        {
            InitializeComponent();
            miDeck = new List<Carta>();
            cartasDisponibles = new List<Carta>();
            

        }

        private void FrmCrearCartas_Load(object sender, EventArgs e)
        {
            


            rtbInfoMateriales.Text = FabricaPegasus.MostrarMaterialesFabrica();


            string ruta = AppDomain.CurrentDomain.BaseDirectory + "ListaCartas.xml"; //busco la direccion del archvio junto a su nombre
            Xml<List<Carta>> xml = new Xml<List<Carta>>(); //creo archivo xml
            xml.Leer(ruta, out cartasDisponibles); //leo
            this.gdvCartasPorCrear.DataSource = cartasDisponibles; //se lo paso al datagreed
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Carta carta = gdvCartasPorCrear.CurrentRow.DataBoundItem as Carta; // obtengo la fila seleccionada y la convierto en carta




            if (carta.Madera <= FabricaPegasus.Madera && carta.PorcentajeTinta <= FabricaPegasus.PorcentajeTinta && carta.Carton <= FabricaPegasus.Carton)
            {



                FabricaPegasus.Madera -= carta.Madera;
                FabricaPegasus.PorcentajeTinta -= carta.PorcentajeTinta;
                FabricaPegasus.Carton -= carta.Carton;

                carta.Stock++;
                //foreach (Carta item in cartasDisponibles)
                //{
                //    item.Stock += 1;
                //}
            }
            else 
            {
                MessageBox.Show("compre mas materiales para seguir reponiendo stock");
            }

                rtbInfoMateriales.Text = FabricaPegasus.MostrarMaterialesFabrica();
                this.gdvCartasPorCrear.DataSource = cartasDisponibles; //se lo paso al datagreed
                
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.frmFabricaPegasus.Show();
            this.Close();

            
        }

        private void btnComprarMateriales_Click(object sender, EventArgs e)
        {

            FabricaPegasus.Carton += 3;
            FabricaPegasus.PorcentajeTinta += 3;
            FabricaPegasus.Madera += 3;
            rtbInfoMateriales.Text = FabricaPegasus.MostrarMaterialesFabrica();


        }
    }
}
