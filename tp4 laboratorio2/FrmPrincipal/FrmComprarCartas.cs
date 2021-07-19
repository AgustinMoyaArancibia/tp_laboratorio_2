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
    public partial class FrmComprarCartas : Form
    {

        public event delGuardar GuardarEnFrmComprarCartas;
        public FrmComprarCartas()
        {
            InitializeComponent();
           
        }



        private void FrmComprarCarta_Load(object sender, EventArgs e)
        {
          

            this.dtgCartas.DataSource = FabricaPegasus.Cartas; //se lo paso al datagreed
        
            this.richTextBox1.Text = FabricaPegasus.LeerCarta();
            GuardarEnFrmComprarCartas -= FabricaPegasus.GuardarTodo;
            GuardarEnFrmComprarCartas += FabricaPegasus.GuardarTodo;
        }

        private void btnMostrarCarta_Click(object sender, EventArgs e)
        {

            lbImage.ImageIndex = dtgCartas.CurrentCell.RowIndex; // igualo el indice del label  con la list de imagenes
            Carta carta = dtgCartas.CurrentRow.DataBoundItem as Carta; // convierto el item elejido en carta                               
            rtbInfoCartas.Text = carta.InformacionCarta(); //muestro la info del item conventido en un richtexbox
        }

        private void btnAgregarCarta(object sender, EventArgs e)
        {
            //bool pudo = false; Persona.InformaCajero -= Archivo.Guardar;
           
            

            try
            {
                if(GuardarEnFrmComprarCartas != null) 
                {
                   
                    Carta carta = dtgCartas.CurrentRow.DataBoundItem as Carta; // obtengo la fila seleccionada y la convierto en carta
                    if (carta.Stock > 0)
                    {
                        FabricaPegasus.Deck.Add(carta);
                        carta.Stock--;
                        MessageBox.Show("se agrego la carta a tu deck");


                        this.GuardarEnFrmComprarCartas.Invoke();
                        FabricaPegasus.InsertarCarta(carta);
                        this.richTextBox1.Text = FabricaPegasus.LeerCarta();
                        this.dtgCartas.DataSource = FabricaPegasus.ActualizarCartas();

                        //FabricaPegasus.GuardarTodo();
                       

                    }
                    else if (carta.Stock == 0)
                    {
                        MessageBox.Show("no hay stock");
                    }
                }
              
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }




        }



        private void btnSalirGuardar(object sender, EventArgs e) //guardar
        {
   

            this.Close();

            Program.frmFabricaPegasus.Show();


        }

        private void FrmComprarCartas_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("volver al menu?", "elija", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true; //cancelo la directiva del salir
            }
            else
            {
                Program.frmFabricaPegasus.Show();
              
            }
        }
    }
}
