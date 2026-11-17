using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace II_Prueba_Programacion_II_Cid_Guzman.CapaLogica
{
    public class UsuariosLogica
    {
        public static int AgregarUsuario(int usuarioID, string nombre, string correoElectronico, string telefono)
        {
            int retorno = 0;
            SqlConnection con = new SqlConnection();

            try
            {
                using (con = CapaLogica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Insert into usuarios (usuarioid, nombreus, correoelectronico, telefono) values (@usuarioid, @nombreus, @correoelectronico, @telefono)", con)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@usuarioid", usuarioID));
                    cmd.Parameters.Add(new SqlParameter("@nombreus", nombre));
                    cmd.Parameters.Add(new SqlParameter("@correoelectronico", correoElectronico));
                    cmd.Parameters.Add(new SqlParameter("@telefono", telefono));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                con.Close();
            }

            return retorno;
        }
        public static int ModificarUsuario(int usuarioID, string nombre, string correoElectronico, string telefono)
        {
            int retorno = 0;
            SqlConnection con = new SqlConnection();

            try
            {
                using (con = CapaLogica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("update usuarios set nombreus = @nombreus, correoelectronico = @correoelectronico, telefono = @telefono where usuarioid = @usuarioid", con)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@usuarioid", usuarioID));
                    cmd.Parameters.Add(new SqlParameter("@nombreus", nombre));
                    cmd.Parameters.Add(new SqlParameter("@correoelectronico", correoElectronico));
                    cmd.Parameters.Add(new SqlParameter("@telefono", telefono));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                con.Close();
            }

            return retorno;
        }
        public static int EliminarUsuario(int usuarioID)
        {
            int retorno = 0;
            SqlConnection con = new SqlConnection();

            try
            {
                using (con = CapaLogica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Delete from usuarios where usuarioid = @usuarioid", con)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@usuarioid", usuarioID));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                con.Close();
            }

            return retorno;
        }
    }
}