using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Abstractas
{
    [Serializable]
    public abstract class Universitario : Persona
	{
		private int legajo;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		protected virtual string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
			sb.Append("LEGAJO NUMERO: "+ this.legajo);
			return sb.ToString();
		}
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		protected abstract string ParticiparEnClase();

        /// <summary>
        /// 
        /// </summary>
		public Universitario()
		{
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
		public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
		{
			this.legajo = legajo;
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
		public static bool operator ==(Universitario pg1, Universitario pg2)
		{
			if (pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI)
			{
				return true;
			}
			return false;
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
		public static bool operator !=(Universitario pg1, Universitario pg2)
		{
			return !(pg1 == pg2);
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
		public override bool Equals(object obj)
		{
			if (obj is Universitario)
			{
				return true;
			}
			return false;
		}



	}
}

