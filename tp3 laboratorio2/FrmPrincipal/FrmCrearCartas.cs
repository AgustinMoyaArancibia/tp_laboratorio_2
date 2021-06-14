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



        public FrmCrearCartas()
        {
            InitializeComponent();
          

        }

        private void FrmCrearCartas_Load(object sender, EventArgs e)
        {
            

            rtbInfoMateriales.Text = FabricaPegasus.MostrarMaterialesFabrica();
          
            this.gdvCartasPorCrear.DataSource = FabricaPegasus.Cartas; //se lo paso al datagreed

            string rutaTxt = AppDomain.CurrentDomain.BaseDirectory + "MisMateriales.txt";
            rtbInfoCompras.Text = FabricaPegasus.LeerMaterialesTxt(rutaTxt);
        }

        private void btnReponesStock_Click(object sender, EventArgs e)
        {
            Carta carta = gdvCartasPorCrear.CurrentRow.DataBoundItem as Carta; // obtengo la fila seleccionada y la convierto en carta




            if (carta.Madera <= FabricaPegasus.Madera && carta.PorcentajeTinta <= FabricaPegasus.PorcentajeTinta && carta.Carton <= FabricaPegasus.Carton)
            {



                FabricaPegasus.Madera -= carta.Madera;
                FabricaPegasus.PorcentajeTinta -= carta.PorcentajeTinta;
                FabricaPegasus.Carton -= carta.Carton;

                carta.Stock++;
             
            }
            else
            {
                MessageBox.Show("compre mas materiales para seguir reponiendo stock");
            }

            rtbInfoMateriales.Text = FabricaPegasus.MostrarMaterialesFabrica();
            this.gdvCartasPorCrear.DataSource = FabricaPegasus.Cartas; //se lo paso al datagreed


        }

        private void btnSalirguardar_Click(object sender, EventArgs e)
        {
            bool pudo;
            string rutaTxt = AppDomain.CurrentDomain.BaseDirectory + "MisMateriales.txt"; //directorio + nombre archivo
            FabricaPegasus.GuardarMaterialesTxt(rutaTxt);

            string ruta1 = AppDomain.CurrentDomain.BaseDirectory + "ListaCartas.xml"; //directorio + nombre archivo
            Xml<List<Carta>> xml1 = new Xml<List<Carta>>();
            pudo = xml1.Guardar(ruta1, FabricaPegasus.ActualizarCartas());

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
