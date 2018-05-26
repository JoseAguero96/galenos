using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Galenos
{
    public partial class RegistroDeHora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Setear valor en blanco 
            lblNombre.Text = string.Empty;
            lblApellido.Text = string.Empty;
            lblFecha.Text = string.Empty;
            lblHora.Text = string.Empty;
            lblArea.Text = string.Empty;

            //poner valores de la sessión
            lblNombre.Text = Session["Medico_nombre"].ToString();
            //lblApellido.Text = Session["Medico_apellido"].ToString();
            lblFecha.Text = Session["fecha_hora"].ToString();
            lblHora.Text = Session["hora_reserva_string"].ToString();
            lblArea.Text = Session["Medico_area"].ToString();
            //lblrutdelPaciente.Text = Session["rut_cliente"].ToString();
            //falta recuperar datos
            //lblnombrepaciente.Text = Session["rut_cliente"].ToString();



        }

        protected void btnReserva_Click(object sender, EventArgs e)
        {
            //guardar reserva en la base de datos
        }
    }
}