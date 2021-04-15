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

namespace MiCalculadora
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            
            if(this.cmbOperaciones.SelectedItem == null )// si el item elegido es null , queda fijado el +
            {
                this.cmbOperaciones.Text = "+";
            }
            else 
            {
                resultado = Operar(this.txtNumeroUno.Text, this.txtNumeroDos.Text, this.cmbOperaciones.SelectedItem.ToString());
            }


            this.lblRestultado.Text = resultado.ToString(); // asigno el resultado en el label resultado
;        }

        public static double Operar(string numero1, string numero2,string operador) 
        {
            double resultado = 0;

            Numero num1 = new Numero(numero1); //creo numero1 con el numero dado 
            Numero num2 = new Numero(numero2);

            resultado = Calculadora.Operar(num1, num2, operador); // llamo a metodo operar desde entidades

            return resultado;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // cierro todo
        }
    }
}
