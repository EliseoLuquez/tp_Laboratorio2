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
    public partial class FormCalculadora : Form
    {
		int flagBin = 0;
		int flagDcmal = 0;

		/// <summary>
		/// 
		/// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
			Close();
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void BtnOperar_Click(object sender, EventArgs e)
        {
			double resultado;
			string aux;
			if(txtNumero1.Text == string.Empty || txtNumero2.Text == string.Empty)
			{
				MessageBox.Show("Debe ingresar los datos para operar");
			}
			else
			{
				
				aux = cmbOperador.Text;
				resultado = Operar(txtNumero1.Text, txtNumero2.Text, aux);
				lblReesultado.Text = resultado.ToString();
				flagBin = 1;
			}
        }

		/// <summary>
		/// 
		/// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.lblReesultado.Text = string.Empty;
			this.cmbOperador.SelectedItem = 0;
			flagDcmal = 0;
			flagBin = 0;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="numero1"></param>
		/// <param name="numero2"></param>
		/// <param name="operador"></param>
		/// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
			double resultado = 0;
			Numero num1 = new Numero(numero1);
			Numero num2 = new Numero(numero2);
			
			resultado = Calculadora.Operar(num1, num2, operador);
			return resultado;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnABinario_Click(object sender, EventArgs e)
		{
			if(flagBin == 1)
			{
				double binario = 0;
				if(double.TryParse(lblReesultado.Text, out binario))
				{
					lblReesultado.Text = Numero.DecimalBinario(binario);
					flagDcmal = 1;
					flagBin = 0;
				}
			}
			else
			{
				MessageBox.Show("Valor Invalido");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnADecimal_Click(object sender, EventArgs e)
		{
			if(flagDcmal == 1)
			{
				double binario = 0;
				if (double.TryParse(lblReesultado.Text, out binario))
				{
					lblReesultado.Text = Numero.BinarioDecimal(lblReesultado.Text);
					flagBin = 1;
					flagDcmal = 0;
				}
			}
			else
			{
				MessageBox.Show("Valor Invalido");
			}
		}

		
	}
}
