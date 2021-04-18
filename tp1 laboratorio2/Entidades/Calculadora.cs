using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public static class Calculadora
    {
       /// <summary>
       /// valida el operador dado por el usuario 
       /// </summary>
       /// <param name="operador" operador dado por el usuario></param>
       /// <returns>regresa el operador en stirng sino su valor por defecto "+"</returns>
       private static string ValidarOperador(char operador) 
        {
            string auxOperador = "+";

            if(auxOperador == "+" || auxOperador == "-"|| auxOperador == "/" || auxOperador == "*")
            {
                auxOperador = operador.ToString();
            }

            return auxOperador;
        }

        /// <summary>
        /// segun lo que elija el usuario se hara la operacion pedida
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>regresa el resultado de la opercion , sino cero</returns>
        public static double Operar(Numero num1, Numero num2, string operador) 
        {
            double resultado = 0;

            string auxOperador;

            auxOperador = ValidarOperador(Convert.ToChar(operador)   );

            switch (auxOperador)
            {
                case "+":
                    resultado = num1 + num2; //aca uso las sobrecargar de operadores
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }
    }
}
