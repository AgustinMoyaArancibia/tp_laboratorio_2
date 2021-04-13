using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;


        /// <summary>
        /// Valida el dato recibido y lo asigna a numero
        /// </summary>
        public string SetNumero { set => numero = ValidarNumero(value); }

       



        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero) : this()
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            this.SetNumero = numero;
        }



        private double ValidarNumero(string strNumero) 
        {
            double numeroRetornado;

            if(!double.TryParse(strNumero,out numeroRetornado)) //! niego y si no funciona de vuevo cero
            {
                numeroRetornado = 0;
            }

            return numeroRetornado;
        }






    }
}
