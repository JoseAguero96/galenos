using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Galenos
{
    public partial class TomaHora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarView();
        }

        private void CargarView()
        {
            lblNombre.Text = (string)(Session["Medico_nombre"]);
            lblApellido.Text = (string)(Session["Medico_Apellido"]);
            lblArea.Text = (string)(Session["Medico_area"]);
        }

        protected void calendario_SelectionChanged(object sender, EventArgs e)
        {
            if (calendario.SelectedDate <= DateTime.Now)
            {
                lblerror.Text = "La fecha no puede ser menor o igual al día de hoy.";
                lblhoras.Visible = false;
                lblhoras.Enabled = false;
                ddlHoras.Visible = false;
                ddlHoras.Enabled = false;
                lblmsg.Visible = false;
                lblFecha.Visible = false;
            }
            else
            {
                lblerror.Text = "";
                DateTime fecha = Convert.ToDateTime(calendario.SelectedDate);
                string cadenafecha = fecha.ToString("dddd d 'de' MMMM 'del' yyyy");
                lblFecha.Text = string.Format(cadenafecha);
                Session["fecha_hora"] = lblFecha.Text;
                lblhoras.Visible = true;
                lblhoras.Enabled = true;
                ddlHoras.Visible = true;
                ddlHoras.Enabled = true;
                lblmsg.Visible = true;
                lblFecha.Visible = true;
            }
        }

        protected void ddlHoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selectedindex = valor escrito en el dropdown
            //selectedvalue = valor dentro del dropdown
            Session["hora_reserva_string"] = ddlHoras.SelectedValue.ToString();
            // valor del dropdown
            //Session["hora_reserva_int"] = ddlHoras.SelectedIndex.ToString();
            Response.Redirect("RegistroDeHora.aspx");
        }
    }
}