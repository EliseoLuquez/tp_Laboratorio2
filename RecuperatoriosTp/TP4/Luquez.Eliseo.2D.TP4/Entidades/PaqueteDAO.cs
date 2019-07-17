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
            conexion = new SqlConnection(Properties.Settings.Default.correo_sp_2017ConnectionString);
            //conexion = new SqlConnection("Data Source=[ELI-PC];Initial Catalog =[correo-sp-2017]; " +
            //"Integrated Security = True");
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        public static bool Insertar(Paquete p)
        {
            try
            {
                comando.CommandText = "INSERT INTO dbo.Paquetes (direccionentrega,trackingId,alumno) VALUES('" +
                        p.DireccionEntrega + "','" + p.TrackingID + "', 'Luquez.Eliseo')";
                comando.Connection.Open();
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
