using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Archivos
{
	[Serializable]
	public class Texto : IArchivo<string>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="archivo"></param>
		/// <param name="datos"></param>
		/// <returns></returns>
		public bool Guardar(string archivo, string datos)
		{
            bool aux = false;
			StreamWriter sw = new StreamWriter(archivo);
            try
            {
			    sw.WriteLine(datos);
                sw.Close();
                aux = true;

            }
            catch (Exception e)
            {
                throw new Exception("Error al Guardar archivo de texto" + e.Message, e);
            }
			return aux;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="archivo"></param>
		/// <param name="datos"></param>
		/// <returns></returns>
		public bool Leer(string archivo, out string datos)
		{
            bool aux =  false;
            StreamReader sr = new StreamReader(archivo);
            try
            {
                datos = sr.ReadToEnd();
                sr.Close();
                aux = true;                
            }
            catch (Exception e)
            {
                throw new Exception("Error al Leer archivo de texto" + e.Message, e);
            }
            return aux; 
        }
	}

	
}
