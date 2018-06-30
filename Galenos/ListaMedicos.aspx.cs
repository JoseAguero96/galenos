using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Galenos
{
    public partial class ListaMedicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //toma valor de la session con los medicos, para una variable de tipo lista.
            List<Medico> medicos = Session["listaMedicos"] as List<Medico>;
            ConexionApi conexion = new ConexionApi();
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

                
            }


            
            

        }

        protected void gvmedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numero = gvmedicos.SelectedIndex;
            string nombre = gvmedicos.Rows[numero].Cells[2].Text.ToString();
            string area = gvmedicos.Rows[numero].Cells[3].Text;
            string idMedico = gvmedicos.Rows[numero].Cells[1].Text.ToString();


            //txtNombre
            string textoOriginal1 = nombre;
            string textResultado1 = Regex.Replace(textoOriginal1, @"[^a-zA-z0-9 ]+", "");
            txtnombre.Text = textResultado1.Replace("237", "í");
            string nombreNormal1 = txtnombre.Text;
            txtnombre.Text = nombreNormal1.Replace("225", "á");
            //txtarea.Text = textResultado.ToString(); ;
            //txtArea
            string textoOriginal = area;
            string textResultado = Regex.Replace(textoOriginal, @"[^a-zA-z0-9 ]+", "");
            txtarea.Text = textResultado.Replace("237","í");
            string nombreNormal = txtarea.Text;
            txtarea.Text = nombreNormal.Replace("225;","á"); 
            //txtarea.Text = textResultado.ToString(); ;
            Session["Medico_id"] = idMedico;
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