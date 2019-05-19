using System;
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
			if (operador != "+" && operador != "-" && operador != "/" && operador != "*")
			{
				return operador = "+";
			}
			else
			{
				return operador;
			}
		}

		public static double Operar(Numero num1, Numero num2, string operador)
		{
			string aux;
			aux = ValidarOperador(operador);
            double resultado = 0;
			if (aux == "+" )
			{
                resultado = num1 + num2;
				
			}
            else if(aux == "-")
            {
                resultado = num1 - num2;
               
            }
            else if (aux == "*")
            {
                resultado = num1 * num2;
               
            }
            else if (aux == "/")
            {
                resultado = num1 / num2;  
            }

            return resultado;
        }
	}
}
