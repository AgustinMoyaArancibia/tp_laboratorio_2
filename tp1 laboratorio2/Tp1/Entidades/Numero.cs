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


        public static double operator +(Numero numero1, Numero numero2)
        {
            return numero1.numero + numero2.numero;
        }

        public static double operator -(Numero numero1, Numero numero2)
        {
            return numero1.numero - numero2.numero;
        }


        public static double operator *(Numero numero1, Numero numero2) 
        {
            return numero1.numero * numero2.numero;
        }

        public static double operator /(Numero numero1 , Numero numero2)
        {
            if(numero2.numero == 0) 
            {
                return double.MinValue;
            }
            else 
            {
                return numero1.numero / numero2.numero;
            }
        }

        /// <summary>
        /// Recibe un numero binario y lo transforma en decimal
        /// </summary>
        /// <param name="binario">parametro recibido en formato string</param>
        /// <returns>numero decimal en formato string</returns>
        public static string BinarioDecimal(string binario)
        {
            string resultado = "Valor invalido";
            double acumulador = 0;
            char[] array = binario.ToCharArray();
            Array.Reverse(array);

            if (EsBinario(binario))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '1')
                    {
                        acumulador += Math.Pow(2, i);
                    }

                }

                resultado = acumulador.ToString();
            }


            return resultado;
        }

        /// <summary>
        /// Recibe un numero decimal y lo transforma en binario
        /// </summary>
        /// <param name="numero">parametro recibido, numero decimal en formato double</param>
        /// <returns>Numero binario en formato string</returns>
        public static string DecimalBinario(double numero)
        {
            string resultado = "";
            int numeroEntero = (int)numero;

            if (numeroEntero > 0)
            {
                while (numeroEntero > 0)
                {
                    if (numeroEntero % 2 == 0)
                    {
                        resultado = "0" + resultado;

                    }
                    else
                    {
                        resultado = "1" + resultado;
                    }

                    numeroEntero = numeroEntero / 2;

                }
            }
            else
            {
                if (numeroEntero == 0)
                {
                    resultado = "0";

                }
                else
                {
                    resultado = "Valor invalido";
                }

            }

            return resultado;
        }

        /// <summary>
        /// Recibe un numero decimal y lo transforma en binario
        /// </summary>
        /// <param name="numero">parametro recibido, numero decimal en formato string</param>
        /// <returns>Numero binario en formato string</returns>
        public static string DecimalBinario(string numero)
        {
            string resultado = "Valor invalido";
            double auxNumeroIngresado;

            if (double.TryParse(numero, out auxNumeroIngresado))
            {
                resultado = DecimalBinario(auxNumeroIngresado);
            }

            return resultado;
        }

        /// <summary>
        /// Valida si el elemento recibido por parametro es un numero binario
        /// </summary>
        /// <param name="binario">Numero binario en formato string</param>
        /// <returns>True si es un numero binario, false si no lo es</returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = true;
            char[] array = binario.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != '0' && array[i] != '1')
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }
    }
}

