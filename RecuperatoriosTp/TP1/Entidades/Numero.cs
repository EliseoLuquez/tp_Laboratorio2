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
		/// 
		/// </summary>
		public Numero()
		{
			this.numero = 0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="strNumero"></param>
		public Numero(string strNumero)
		{
			this.SetNumero = strNumero;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="numero"></param>
		public Numero(double numero)
		{
			this.numero = numero;
		}

		/// <summary>
		/// 
		/// </summary>
		private string SetNumero
		{
			set { numero = this.ValidarNumero(value); }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="strNumero"></param>
		/// <returns></returns>
		private double ValidarNumero(string strNumero)
		{
			if(double.TryParse(strNumero, out double numero))
			{
				return numero;
			}
			return numero = 0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="binario"></param>
		/// <returns></returns>
		public  string BinarioDecimal(string binario)
		{
			double numero = 0;
            bool valor = false;
            string invalido = "Valor Invalido";
			for(int i = 1; i <= binario.Length; i++)
			{
                if (binario[i-1] == '0' || binario[i-1] == '1')
                {
				    numero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);	
                    valor = true;
                }
			}				
			return (valor ? numero.ToString() : invalido);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="binario"></param>
		/// <returns></returns>
		public string DecimalBinario(string numero)
		{

            bool valor = false;
            string retorno = "";
            int entero;
            if (double.TryParse(numero, out double resultado))
            {
                entero = Math.Abs((int)resultado);
                while (entero > 0)
                {
                    retorno = (entero % 2).ToString() + retorno;
                    entero = (int)entero / 2;

                }
                valor = true;
            }
            return (valor ? retorno.ToString() : retorno = "Valor Invalido");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="numero"></param>
		/// <returns></returns>
		public string DecimalBinario(double numero)
		{
			return DecimalBinario(numero.ToString());
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="numeroUno"></param>
		/// <param name="numeroDos"></param>
		/// <returns></returns>
		public static double operator +(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero + numeroDos.numero;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="numeroUno"></param>
		/// <param name="numeroDos"></param>
		/// <returns></returns>
        public static double operator -(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero - numeroDos.numero;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="numeroUno"></param>
		/// <param name="numeroDos"></param>
		/// <returns></returns>
        public static double operator /(Numero numeroUno, Numero numeroDos)
        {
			if(numeroDos.numero == 0)
			{
				return double.MinValue;
			}
			else
			{
				return numeroUno.numero / numeroDos.numero;
			}
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="numeroUno"></param>
		/// <param name="numeroDos"></param>
		/// <returns></returns>
        public static double operator *(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero * numeroDos.numero;
        }


    }
}
