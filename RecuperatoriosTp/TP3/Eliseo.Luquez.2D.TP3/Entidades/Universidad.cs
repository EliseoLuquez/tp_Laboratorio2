using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;
using System.Xml;
using System.Xml.Serialization;
using Entidades_Abstractas;
using Archivos;

namespace Entidades
{
    [Serializable]
	public class Universidad
	{
        /// <summary>
        /// 
        /// </summary>
		public enum EClases
		{
			Programacion,
			Laboratorio,
			Legislacion,
			SPD
		}

		private List<Alumno> alumnos;
		private List<Jornada> jornadas;
		private List<Profesor> profesores;

        /// <summary>
        /// 
        /// </summary>
		public List<Alumno> Alumno
		{
			get { return alumnos; }
			set { alumnos = value; }
		}

        /// <summary>
        /// 
        /// </summary>
		public List<Profesor> Instructores
		{
			get { return profesores; }
			set { profesores = value; }
		}

        /// <summary>
        /// 
        /// </summary>
		public List<Jornada> Jornadas
		{
			get { return jornadas; }
			set { jornadas = value; }
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
		public Jornada this[int i]    // Indexador de Jornadas
		{
			get { return jornadas[i]; }
			set { this.jornadas.Add(value); }
		}

        /// <summary>
        /// 
        /// </summary>
		public Universidad()
		{
			this.alumnos = new List<Alumno>();
			this.profesores = new List<Profesor>();
			this.jornadas = new List<Jornada>();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="g"></param>
		/// <param name="a"></param>
		/// <returns></returns>
		public static bool operator ==(Universidad g, Alumno a)
		{
			foreach(Alumno aAux in g.alumnos)
			{
				if(aAux == a)
				{
                    return true;
				}
			}
			return false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="g"></param>
		/// <param name="a"></param>
		/// <returns></returns>
		public static bool operator !=(Universidad g, Alumno a)
		{
			return !(g == a);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="g"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		public static bool operator ==(Universidad g, Profesor i)
		{
			foreach (Profesor pAux in g.profesores)
			{
				if (pAux == i)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="g"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		public static bool operator !=(Universidad g, Profesor i)
		{
			return !(g == i);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="u"></param>
		/// <param name="clase"></param>
		/// <returns></returns>
		public static Profesor operator ==(Universidad u, EClases clase)
		{
			foreach (Profesor p in u.profesores)
			{
				if(p == clase)
				{
					return p;
				}
			}
			
			throw new SinProfesorException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="u"></param>
		/// <param name="clase"></param>
		/// <returns></returns>
		public static Profesor operator !=(Universidad u, EClases clase)
		{
			foreach (Profesor p in u.Instructores)
			{
				if (p != clase)
				{
					return p;
				}
			}
			throw new SinProfesorException();	
		}

		/// <summary>
		/// Genera una Jornada al agregar una clase a una Universidad, asigna Profesor para la clase
		/// y alumnos que la toman
		/// </summary>
		/// <param name="g"></param>
		/// <param name="clase"></param>
		/// <returns></returns>
		public static Universidad operator +(Universidad g, EClases clase)
		{
            Profesor profesor = (g == clase);//Me trae al primer profesor disponible
            Jornada jornada = new Jornada(clase, profesor);//Creo la Jornada			
            jornada.Alumnos = g.alumnos;
			g.Jornadas.Add(jornada);//Agrego la jornada a la lista de jornadas

			return g;    
        }

		/// <summary>
		/// Agrega un Profesor, validando que no este previamente cargado
		/// </summary>
		/// <param name="u"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		public static Universidad operator +(Universidad u, Profesor i)
		{
			if(u != i)
			{
				u.profesores.Add(i);
			}
			return u;
		}

		/// <summary>
		/// Agrega un Alumno, validando que no este previamente cargado
		/// </summary>
		/// <param name="u"></param>
		/// <param name="a"></param>
		/// <returns></returns>
		public static Universidad operator +(Universidad u, Alumno a)
		{
			if (u != a)
			{
				u.alumnos.Add(a);
                return u;
            }

			throw new AlumnoRepetidoException();
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
		private string MostrarDatos(Universidad uni)
		{
			//*MostrarDatos será privado y de clase. Los datos del Universidad se harán públicos mediante ToString
			StringBuilder sb = new StringBuilder();			
			foreach (Jornada jornada in uni.jornadas)
			{
				sb.AppendLine(jornada.ToString());
			}
			return sb.ToString();
		}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		public override string ToString()
		{
			return this.MostrarDatos(this);
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
		public static bool Guardar(Universidad uni)
		{
            bool guardar = false;
            Xml<Universidad> xml = new Xml<Universidad>();
            string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                ".\\Universidad.xml";
            if(xml.Guardar(archivo, uni))
            {
                guardar = true;
            }
			return guardar;
		}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		public static Universidad Leer()
		{
			Xml<Universidad> xml = new Xml<Universidad>();
			Universidad uni = new Universidad();
			string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +".\\Universidad.xml";
			xml.Leer(archivo, out uni);

			return uni;
		}

	}
}
