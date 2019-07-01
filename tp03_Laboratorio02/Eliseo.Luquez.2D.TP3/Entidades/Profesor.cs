using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Abstractas;

namespace Entidades
{
    [Serializable]
    public sealed class Profesor : Universitario
	{
		private Queue<Universidad.EClases> claseDelDia;
		private static Random random;

        /// <summary>
        /// 
        /// </summary>
		static Profesor()
		{
			random = new Random();
		}

        /// <summary>
        /// 
        /// </summary>
		private Profesor()
		{
			
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
		public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
			: base(id, nombre,
			apellido, dni, nacionalidad)
		{
			this.claseDelDia = new Queue<Universidad.EClases>();
			this._randomClases();
			this._randomClases();
		}

        /// <summary>
        /// 
        /// </summary>
		private void _randomClases()
		{
			this.claseDelDia.Enqueue((Universidad.EClases)random.Next(3));
		}
		
		//  Un Profesor será igual a un EClase si da esa clase.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
		public static bool operator ==(Profesor i, Universidad.EClases clase)
		{
			return i.claseDelDia.Contains(clase);
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
		public static bool operator !=(Profesor i, Universidad.EClases clase)
		{
			return !(i == clase);
		}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		protected override string ParticiparEnClase()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("CLASES DEL DIA: ");
			foreach (Universidad.EClases clases in this.claseDelDia)
			{
				sb.AppendLine(clases.ToString());
			}
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
		protected override string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
			sb.AppendLine(this.ParticiparEnClase());

			return sb.ToString();
		}




	}
}
