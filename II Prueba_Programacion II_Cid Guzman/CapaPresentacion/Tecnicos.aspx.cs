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
    public partial class Tecnicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM tecnicos", con))
            {
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    GridView2.DataSource = rdr;
                    GridView2.DataBind();
                }
            }
        }
        protected void bAgregar_Click1(object sender, EventArgs e)
        {
            if (CapaLogica.TecnicosLogica.AgregarTecnico(int.Parse(tbTecnicoID.Text), tbNombreT.Text, tbEspecialidad.Text) > 0)
            {
                lMensaje.Text = "Tecnico agregado.";
                LlenarGrid();
            }
            else
            {
                lMensaje.Text = "No se pudo agregar al tecnico.";
            }
        }

        protected void bBorrar_Click(object sender, EventArgs e)
        {
            if (CapaLogica.TecnicosLogica.EliminarTecnico(int.Parse(tbTecnicoID.Text)) > 0)
            {
                lMensaje.Text = "Tecnico eliminado.";
                LlenarGrid();
            }
            else
            {
                lMensaje.Text = "No se pudo eliminar al tecnico.";
            }
        }

        protected void bModificar_Click(object sender, EventArgs e)
        {
            if (CapaLogica.TecnicosLogica.ModificarTecnico(int.Parse(tbTecnicoID.Text), tbNombreT.Text, tbEspecialidad.Text) > 0)
            {
                lMensaje.Text = "Tecnico modificado.";
                LlenarGrid();
            }
            else
            {
                lMensaje.Text = "No se pudo modificar al tecnico.";
            }
        }
    }
}