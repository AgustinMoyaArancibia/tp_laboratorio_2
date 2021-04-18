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
        /// Valida si el dato es del tipo numero y lo asigna a numero
        /// </summary>
        public string SetNumero { set => numero = ValidarNumero(value); }

        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// constructor con parametro
        /// </summary>
        /// <param name="numero"> parametro del tipo double</param>
        public Numero(double numero) : this() //sobrecargar del constructor por defecto
        {
            this.numero = numero;
        }

        /// <summary>
        /// constructor con parametros
        /// </summary>
        /// <param name="numero">parametro del tipo string</param>
        public Numero(string numero)
        {
            this.SetNumero = numero;
        }


        /// <summary>
        /// valida si es un numero
        /// </summary>
        /// <param name="strNumero">parametros del tipo string</param>
        /// <returns>regresa el numero , sino cero</returns>
        private double ValidarNumero(string strNumero) 
        {
            double numeroRetornado;

            if(!double.TryParse(strNumero,out numeroRetornado)) //! niego y si no funciona de vuevo cero
            {
                numeroRetornado = 0;
            }

            return numeroRetornado;
        }

        /// <summary>
        /// suma dos objetos del tipo Numero
        /// </summary>
        /// <param name="numero1">objeto del tipo Numero</param>
        /// <param name="numero2">objeto del tipo Numero</param>
        /// <returns>el resultado de la suma de los elementros</returns>
        public static double operator +(Numero numero1, Numero numero2)
        {
            return numero1.numero + numero2.numero;
        }

        /// <summary>
        /// resta dos objetos del tipo Numero
        /// </summary>
        /// <param name="numero1">objeto del tipo Numero</param>
        /// <param name="numero2">objeto del tipo Numero</param>
        /// <returns>resultado de la resta de los elementos</returns>
        public static double operator -(Numero numero1, Numero numero2)
        {
            return numero1.numero - numero2.numero;
        }


        /// <summary>
        /// multiplica dos objetos del tipo Numero
        /// </summary>
        /// <param name="numero1">objeto del tipo Numero</param>
        /// <param name="numero2">objeto del tipo Numero</param>
        /// <returns>resultado de la multiplicacion de los elementos</returns>
        public static double operator *(Numero numero1, Numero numero2) 
        {
            return numero1.numero * numero2.numero;
        }

        /// <summary>
        /// divede dos objetos del tipo Numero
        /// </summary>
        /// <param name="numero1">objeto del tipo Numero</param>
        /// <param name="numero2">objeto del tipo Numero</param>
        /// <returns>resultado de la division de los elementos , si numero2 es cero regresar minvalue</returns>
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
        /// <param name="binario">parametro string</param>
        /// <returns>numero decimal en string</returns>
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
                        acumulador = acumulador+ Math.Pow(2, i);
                    }

                }

                resultado = acumulador.ToString();
            }


            return resultado;
        }

        /// <summary>
        /// Recibe un numero decimal y lo transforma en binario
        /// </summary>
        /// <param name="numero">parametro  numero decimal double</param>
        /// <returns>Numero binario  string</returns>
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
        /// <param name="numero">parametro numero decimal  string</param>
        /// <returns>Numero binario  string</returns>
        public static string DecimalBinario(string numero)
        {
            string resultado = "Valor invalido";
            double auxNumeroIngresado;

            if (double.TryParse(numero, out auxNumeroIngresado)) //convierte el numero string a double, ya que nos estamos manejando con strings
            {
                resultado = DecimalBinario(auxNumeroIngresado);// con el numero en double llamamos al metodo que recible el double
            }

            return resultado;
        }

        /// <summary>
        /// Valida si el elemento recibido  es un numero binario
        /// </summary>
        /// <param name="binario">Numero binario  string</param>
        /// <returns>True si es un numero binario, false si no lo es</returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = true;
            char[] array = binario.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != '0' && array[i] != '1')// si el numero no contiene ceros y unos regresa false
                { 
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }
    }
}

