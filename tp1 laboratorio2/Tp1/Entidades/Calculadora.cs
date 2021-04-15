﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public static class Calculadora
    {

       private static string ValidarOperador(char operador) 
        {
            string auxOperador = "+";

            if(auxOperador == "+" || auxOperador == "-"|| auxOperador == "/" || auxOperador == "*")
            {
                auxOperador = operador.ToString();
            }

            return auxOperador;
        }

        public static double Operar(Numero num1, Numero num2, string operador) 
        {
            double resultado = 0;

            string auxOperador;

            auxOperador = ValidarOperador(Convert.ToChar(operador)   );

            switch (auxOperador)
            {
                case "+":
                    resultado = num1 + num2;
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
