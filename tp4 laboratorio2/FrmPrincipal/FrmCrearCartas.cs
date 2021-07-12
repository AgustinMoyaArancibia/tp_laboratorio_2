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
using System.Threading;

namespace FrmPrincipal
{
    public partial class FrmCrearCartas : Form
    {

        public event delAumentar AumentoStock;
        Thread hiloMostrarMateriales;

        public FrmCrearCartas()
        {
            InitializeComponent();
            hiloMostrarMateriales = new Thread(AumentarStock);

        }

        private void FrmCrearCartas_Load(object sender, EventArgs e)
        {


            rtbInfoMateriales.Text = FabricaPegasus.MostrarMaterialesFabrica(); // muestro los materiales disponibles traidos del xml

            this.gdvCartasPorCrear.DataSource = FabricaPegasus.Cartas; //paso al datagrid la lista de cartas disponibles

            string rutaTxt = AppDomain.CurrentDomain.BaseDirectory + "MisMateriales.txt"; //leo lista de materiales usados la ultima vez usado en texto
            rtbInfoCompras.Text = FabricaPegasus.LeerMaterialesTxt(rutaTxt);
        }

        private void btnReponesStock_Click(object sender, EventArgs e)
        {
            try
            {
                Carta carta = gdvCartasPorCrear.CurrentRow.DataBoundItem as Carta; // obtengo la fila seleccionada y la convierto en carta

                if (carta.Madera <= FabricaPegasus.ListaMateriales[1] && carta.PorcentajeTinta <= FabricaPegasus.ListaMateriales[0] && carta.Carton <= FabricaPegasus.ListaMateriales[2])
                {

                    FabricaPegasus.ListaMateriales[0] -= carta.PorcentajeTinta;
                    FabricaPegasus.ListaMateriales[1] -= carta.Madera;
                    FabricaPegasus.ListaMateriales[2] -= carta.Carton;


                    carta.Stock++;

                }
                else
                {
                    MessageBox.Show("compre mas materiales para seguir reponiendo stock");
                }

                FabricaPegasus.GuardarTodo();
                rtbInfoMateriales.Text = FabricaPegasus.MostrarMaterialesFabrica();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

          


        }

        private void btnSalirguardar_Click(object sender, EventArgs e)
        {

           
            CerrarHiloMateriales();
            this.Close();
            Program.frmFabricaPegasus.Show();


        }

        private void btnComprarMateriales_Click(object sender, EventArgs e)
        {
            try
            {
            hiloMostrarMateriales.Start();

            }
            catch (Exception)
            {

                MessageBox.Show("Ya mando a comprar , no inche");
            }

        }


        public void AumentarStock()
        {
            while (FabricaPegasus.ListaMateriales[0] < 100 && FabricaPegasus.ListaMateriales[1] < 100 && FabricaPegasus.ListaMateriales[2] < 100)
            {
                FabricaPegasus.ListaMateriales[0] += 3;
                FabricaPegasus.ListaMateriales[1] += 3;
                FabricaPegasus.ListaMateriales[2] += 3;

                
                if (rtbInfoMateriales.InvokeRequired)
                {
                    rtbInfoMateriales.BeginInvoke((MethodInvoker)delegate ()
                   {
                       rtbInfoMateriales.Text = FabricaPegasus.MostrarMaterialesFabrica();

                       FabricaPegasus.GuardarTodo();
                   }
                    );
                }
                else
                {
                    rtbInfoMateriales.Text = FabricaPegasus.MostrarMaterialesFabrica();
                 
                  FabricaPegasus.GuardarTodo();
                }
                Thread.Sleep(6000);

            }
            if ((FabricaPegasus.ListaMateriales[0] > 100 && FabricaPegasus.ListaMateriales[1] > 100 && FabricaPegasus.ListaMateriales[2] > 100))
            {
                MessageBox.Show("suficientes materiales por hoy, Compre otro dia");

            }
        }

      

        public void CerrarHiloMateriales() 
        {
            if (hiloMostrarMateriales.IsAlive)
            {
                hiloMostrarMateriales.Abort();
            }
        }

        private void lblMateriales_Click(object sender, EventArgs e)
        {

        }
    }
}
