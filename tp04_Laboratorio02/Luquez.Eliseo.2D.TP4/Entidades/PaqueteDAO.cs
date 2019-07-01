using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static  PaqueteDAO()
        {
             
        }

        public static bool Insertar(Paquete p)
        {
            try
            {
                conexion = new SqlConnection("Data Source=[ELI-PC];Initial Catalog =[correo-sp-2017]; " +
                "Integrated Security = True");
                comando = new SqlCommand(string.Format("Insert into dbo.Paquetes values ('{0}', " +
                    "'{1}', '{2}');", p.DireccionEntrega, p.TrackingID, "Luquez.Eliseo"), conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar paquete", e);
            }
        
        }

    }
}
