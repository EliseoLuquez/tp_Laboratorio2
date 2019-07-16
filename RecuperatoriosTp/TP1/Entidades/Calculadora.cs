﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Calculadora
    {
		private static string ValidarOperador(string operador)
		{
            switch (operador)
            {
                case "*":
                    return "*";
                case "/":
                    return "/";
                case "-":
                    return "-";
                default:
                    return "+";         
            }
		}

		public static double Operar(Numero num1, Numero num2, string operador)
		{
			string aux;
			aux = ValidarOperador(operador);
            double resultado = 0;
            switch (aux)
            {
                case "*":
                    resultado = num1 * num2;
                    return resultado;
                case "/":
                    resultado = num1 / num2;
                    return resultado;
                case "-":
                    resultado = num1 - num2;
                    return resultado;
                default:
                    resultado = num1 + num2;
                    return resultado;
            }
        }
	}
}
