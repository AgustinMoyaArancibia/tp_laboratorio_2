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




        }



        private void btnCreacionCartas_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmCrearCartas frmCrearCartas = new FrmCrearCartas();
            frmCrearCartas.Show();


        }

        private void btnCreacionDeck_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmComprarCartas frmCrearCartas = new FrmComprarCartas();
            frmCrearCartas.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFabricaPegasus_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea salir?", "elija", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true; //cancelo la directiva del salir
            }
        }
    }


}