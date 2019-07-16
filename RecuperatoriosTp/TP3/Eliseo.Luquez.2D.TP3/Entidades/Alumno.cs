using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Abstractas;

namespace Entidades
{
    [Serializable]
    public sealed class Alumno : Universitario
	{
		public enum EEstadoCuenta
		{
			AlDia,
			Deudor,
			Becado
		}

		private Universidad.EClases claseQueToma;
		private EEstadoCuenta estadoCuenta;

		public Alumno()
		{
		}

		public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad,
			Universidad.EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
		{
			this.claseQueToma = claseQueToma;
		}

		public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad,
			Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
		{
			this.estadoCuenta = estadoCuenta;
		}

        /// <summary>
        /// Un Alumno será igual a un EClase si toma esa clase y su estado de cuenta no es Deudor.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
		public static bool operator ==(Alumno a, Universidad.EClases clase)
		{        
			if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
			{
				return true;
			}
			return false;
		}

        /// <summary>
        /// Un Alumno será distinto a un EClase sólo si no toma esa clase.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
		public static bool operator !=(Alumno a, Universidad.EClases clase)
		{
            if(a.claseQueToma != clase)
            {
                return true;
            }
			return false;
		}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		protected override string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
			sb.AppendLine("\nESTADO DE CUENTA: " + this.estadoCuenta);
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
		}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		public override string ToString()
		{
			return this.MostrarDatos();
		}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		protected override string ParticiparEnClase()
		{
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("TOMA CLASE DE " + this.claseQueToma);
            return sb.ToString();
		}






	}


}
