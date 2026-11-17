using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace II_Prueba_Programacion_II_Cid_Guzman.CapaPresentacion
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM usuarios", con))
            {
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    GridView2.DataSource = rdr;
                    GridView2.DataBind();
                }
            }
        }

        protected void bAgregar_Click(object sender, EventArgs e)
        {
            if (CapaLogica.UsuariosLogica.AgregarUsuario(int.Parse(tbUsuarioID.Text), tbNombreU.Text, tbEmail.Text, tbTelefono.Text) > 0)
            {
                lMensaje.Text = "Usuario agregado.";
                LlenarGrid();
            }
            else
            {
                lMensaje.Text = "No se pudo agregar al usuario.";
            }
        }

        protected void bModificar_Click(object sender, EventArgs e)
        {
            if (CapaLogica.UsuariosLogica.ModificarUsuario(int.Parse(tbUsuarioID.Text), tbNombreU.Text, tbEmail.Text, tbTelefono.Text) > 0)
            {
                lMensaje.Text = "Usuario modificado.";
                LlenarGrid();
            }
            else
            {
                lMensaje.Text = "No se pudo modificar al usuario.";
            }
        }

        protected void bBorrar_Click(object sender, EventArgs e)
        {
            if (CapaLogica.UsuariosLogica.EliminarUsuario(int.Parse(tbUsuarioID.Text)) > 0)
            {
                lMensaje.Text = "Usuario eliminado.";
                LlenarGrid();
            }
            else
            {
                lMensaje.Text = "No se pudo eliminar al usuario.";
            }
        }
    }
}