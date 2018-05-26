using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Galenos
{
    public partial class ListaMedicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //toma valor de la session con los medicos, para una variable de tipo lista.
            List<Medico> medicos = Session["listaMedicos"] as List<Medico>;

            if (medicos.Count == 0)
            {
                txtnombre.Visible = false;
                txtarea.Visible = false;
                lblseleccion.Visible = false;
                lblnombreM.Visible = false;
                Label2.Visible = false;
                btntomarhora.Visible = false;
                lblmensajito.Text = "No se encontró ningun medico";
                

            }
            else
            {
                foreach (Medico item in medicos)
                {

                    gvmedicos.DataSource = medicos;
                    gvmedicos.DataBind();

                }
            }


            
            

        }

        protected void gvmedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numero = gvmedicos.SelectedIndex;
            string nombre = gvmedicos.Rows[numero].Cells[2].Text.ToString();
            string area = gvmedicos.Rows[numero].Cells[4].Text;
            //lblprueba.Text = nombre;
            txtnombre.Text = nombre;
            txtarea.Text = area.ToString();
        }

        protected void btntomarhora_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {

            }
            else
            {
                Session["Medico_nombre"] = txtnombre.Text;
                Session["Medico_area"] = txtarea.Text;
                //Session["Medico_Apellido"] = txtApellido.text;
                Response.Redirect("TomaHora.aspx");
            }
        }
    }
}