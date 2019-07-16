using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades_Abstractas;
using Archivos;

namespace Entidades
{
    [Serializable]
	public class Jornada
	{
		private List<Alumno> alumnos;
		private Universidad.EClases clase;
		private Profesor instructor;

        /// <summary>
        /// 
        /// </summary>
		public List<Alumno> Alumnos
		{
			get { return alumnos; }
			set
            {
                foreach (Alumno alumno in value)
                {
                    if(this == alumno)
                    {
                        this.alumnos.Add(alumno);
                    }
                }
            }
		}

        /// <summary>
        /// 
        /// </summary>
		public Universidad.EClases Clase
		{
			get { return clase; }
			set { clase = value; }
		}

        /// <summary>
        /// 
        /// </summary>
		public Profesor Instructor
		{
			get { return instructor; }
			set { instructor = value; }
		}

        /// <summary>
        /// 
        /// </summary>
		private Jornada()
		{
			this.alumnos = new List<Alumno>();
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
		public Jornada(Universidad.EClases clase, Profesor instructor) : this()
		{
			this.clase = clase;
			this.instructor = instructor;
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
		public static bool operator ==(Jornada j, Alumno a)
		{
			if (a == j.clase)
			{
				return true;
			}
      	
			return false;
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
		public static bool operator !=(Jornada j, Alumno a)
		{
			return !(j == a);
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
		public static Jornada operator +(Jornada j, Alumno a)
		{
			if(j != a)
			{
				j.alumnos.Add(a);
			}
			return j;
		}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA:");
            sb.AppendLine("CLASE DE " + this.Clase + " POR " + this.Instructor.ToString());
			sb.AppendLine("ALUMNOS:");
			foreach (Alumno alumno in this.Alumnos)
			{
				sb.Append(alumno.ToString());
			}
            sb.AppendLine("<------------------------------>");
            return sb.ToString();
		}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		public static string Leer()
		{
            string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Jornada.txt";
            Texto texto = new Texto();
            texto.Leer(archivo, out string dato);
            
			return dato;
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
		public static bool Guardar(Jornada jornada)
		{
            bool guardar = false;
            string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Jornada.txt";
            Texto texto = new Texto();
            if(texto.Guardar(archivo, jornada.ToString()))
            {
                guardar = true;
            }
            return guardar;
		}



	}
}
