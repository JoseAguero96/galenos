using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;

namespace Galenos
{
    public partial class RegistroDeHora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
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
            lblrutpaciente.Text = Session["user_rut"].ToString();
            lblnombrepaciente.Text = Session["user_fullname"].ToString();



        }

        protected void btnReserva_Click(object sender, EventArgs e)
        {
            //guardar reserva en la base de datos
            int id_medico = int.Parse(Session["Medico_id"].ToString());
            int id_usuario = int.Parse(Session["user_id"].ToString());
            var fecha = Session["fecha_hora_datetime"];
            var Hora = Session["hora_reserva_string"];

            try
            {
                ConexionApi conexion = new ConexionApi();
                var json = new { idMedico = id_medico, idUsuario = id_usuario,fechaReserva = fecha, horaReserva = Hora };
                var result = conexion.ejecutarLlamada("POST", "registrar_hora", "", json);
                MultiView1.ActiveViewIndex = 1;


            }
            catch (Exception)
            {
                //Muestra Mensaje
            }

        }

        protected void btnAceptar0_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}