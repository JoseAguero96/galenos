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

                foreach (Medico item in medicos)
                {
                    var area = conexion.ejecutarLlamada("GET", "areas/" + item.area_id, "", "");

                    JObject jObject = JObject.Parse(area);
                    JToken nombreArea = jObject["nombre"];

                    item.nombre_area = nombreArea.ToString();
                }

                gvmedicos.DataSource = medicos;
                gvmedicos.DataBind();
            }


            
            

        }

        protected void gvmedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numero = gvmedicos.SelectedIndex;
            string nombre = gvmedicos.Rows[numero].Cells[2].Text.ToString();
            string area = gvmedicos.Rows[numero].Cells[3].Text;
            txtnombre.Text = nombre;

            string textoOriginal = area;

            string textResultado = Regex.Replace(textoOriginal, @"[^a-zA-z0-9 ]+", "");
            

            txtarea.Text = textResultado.ToString(); ;
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