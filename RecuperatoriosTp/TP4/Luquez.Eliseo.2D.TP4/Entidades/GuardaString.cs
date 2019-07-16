using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GuardaString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            bool aux = false;
            StreamWriter sw = new StreamWriter(archivo);
            try
            {
                sw.WriteLine(texto);
                sw.Close();
                aux = true;

            }
            catch (Exception e)
            {
                throw new Exception("Error al Guardar archivo de texto" + e.Message, e);
            }
            return aux;
        }

    }
}
