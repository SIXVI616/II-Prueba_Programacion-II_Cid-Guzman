using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace II_Prueba_Programacion_II_Cid_Guzman.CapaLogica
{
    public class TecnicosLogica
    {
        public static int AgregarTecnico(int tecnicoID, string nombre, string especialidad)
        {
            int retorno = 0;
            SqlConnection con = new SqlConnection();

            try
            {
                using (con = CapaLogica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Insert into tecnicos (tecnicoid, nombretec, especialidad) values (@tecnicoid, @nombretec, @especialidad)", con)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@tecnicoid", tecnicoID));
                    cmd.Parameters.Add(new SqlParameter("@nombretec", nombre));
                    cmd.Parameters.Add(new SqlParameter("@especialidad", especialidad));

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
        public static int ModificarTecnico(int tecnicoID, string nombre, string especialidad)
        {
            int retorno = 0;
            SqlConnection con = new SqlConnection();

            try
            {
                using (con = CapaLogica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("update tecnicos set nombretec = @nombretec, especialidad = @especialidad where tecnicoid = @tecnicoid", con)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@tecnicoid", tecnicoID));
                    cmd.Parameters.Add(new SqlParameter("@nombretec", nombre));
                    cmd.Parameters.Add(new SqlParameter("@especialidad", especialidad));

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
        public static int EliminarTecnico(int tecnicoID)
        {
            int retorno = 0;
            SqlConnection con = new SqlConnection();

            try
            {
                using (con = CapaLogica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Delete from tecnicos where tecnicoid = @tecnicoid", con)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@tecnicoid", tecnicoID));

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