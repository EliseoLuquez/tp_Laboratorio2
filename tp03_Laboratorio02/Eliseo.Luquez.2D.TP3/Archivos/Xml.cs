using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace Archivos
{
    public class Xml<T>: IArchivo<T>
    {
		public bool Guardar(string archivo, T datos)
		{
			bool guardar = false;
			XmlTextWriter writer;
			XmlSerializer serializer;
            try
            {
				writer = new XmlTextWriter(archivo, Encoding.UTF8);
				serializer = new XmlSerializer(typeof(T));
				serializer.Serialize(writer, datos);
				writer.Close();
                guardar = true;
            }
            catch (Exception e)
            {
                throw e;
            }			
	    	return guardar;
		}

		public bool Leer(string archivo, out T datos)
		{
            bool leer = false;
            XmlTextReader sw; 
            XmlSerializer serializer;
            try
            {
                sw = new XmlTextReader(archivo);
                serializer = new XmlSerializer(typeof(T));
                datos = (T)serializer.Deserialize(sw);
                leer = true;
			    sw.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
			return leer;
		}


	}
}
