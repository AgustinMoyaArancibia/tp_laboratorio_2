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

      
        /// <summary>
        /// boton operar , realiza el llamado al metodo de operaciones y valida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOperar_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            
            if(this.cmbOperaciones.SelectedItem == null )// si no elige ningun item , queda fijado el +
            {
                this.cmbOperaciones.Text = "+";
            }
            else 
            {
                resultado = Operar(this.txtNumeroUno.Text, this.txtNumeroDos.Text, this.cmbOperaciones.SelectedItem.ToString());
            }
            //llamo al metodo operar que en el metodo mas abajo llama a operar de la clase calclulador

            this.lblRestultado.Text = resultado.ToString(); // asigno el resultado en el label resultado
;        }

        /// <summary>
        /// crea dos objetos del tipo numero y llama al metodo operar desde Calculadora
        /// </summary>
        /// <param name="numero1"> elemento creado de Numero</param>
        /// <param name="numero2">elemento creado de Numero</param>
        /// <param name="operador">operador usado + - / * </param>
        /// <returns></returns>
        public static double Operar(string numero1, string numero2,string operador) 
        {
            double resultado = 0;

            Numero num1 = new Numero(numero1); //creo numero1 con el numero dado 
            Numero num2 = new Numero(numero2);

            resultado = Calculadora.Operar(num1, num2, operador); // llamo a metodo operar desde entidades

            return resultado;
        }

        /// <summary>
        /// cierra la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // cierro todo
        }

        /// <summary>
        /// reseteo los valores , (limpiar)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumeroUno.Clear();
            this.txtNumeroDos.Clear();
            this.cmbOperaciones.ResetText();
            this.cmbOperaciones.Text = null;
            this.lblRestultado.Text = "resultado";
        }

        /// <summary>
        /// llamo al metodo DecimalBinario para convertir nmero en binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbinario_Click(object sender, EventArgs e)
        {
            if(this.lblRestultado.Text != "resultado") 
            {
              this.lblRestultado.Text = Numero.DecimalBinario(this.lblRestultado.Text);
            }
            
        }

        /// <summary>
        /// llamo al metodo BinarioDecimal para convertir el numero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdecimal_Click(object sender, EventArgs e)
        {
            if(this.lblRestultado.Text != "resultado" || this.lblRestultado.Text != "valor invalido")
            {
                this.lblRestultado.Text = Numero.BinarioDecimal(this.lblRestultado.Text);
            }
        }
    }
}
