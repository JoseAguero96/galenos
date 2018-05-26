using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
using Newtonsoft.Json;

namespace Galenos
{
    public partial class TomaHorasMedicas : System.Web.UI.Page
    {
        #region Carga Inicial de la Pagina
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Boton buscar por nombre de medico
        protected void btnHoraMedico_Click(object sender, EventArgs e)
        {
            lblMensaje1.Text = "";
            txtNombreMedico.Text = "";
            MultiView1.ActiveViewIndex = 1;
        }
        #endregion


        #region Boton buscar por Area de medico
        protected void btnPorArea_Click(object sender, EventArgs e)
        {
            lblMensaje2.Text = "";
            ddlArea.SelectedIndex = 0;
            MultiView1.ActiveViewIndex = 2;
        }
        #endregion


        #region Boton buscar dentro de busqueda por nombre Medico
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombreMedico.Text == "" )
            {
                lblMensaje1.Text = "Apellido de medico Obligatorio*";
            }
            else
            {
                string nombreMedico = txtNombreMedico.Text;
                ConexionApi conexion = new ConexionApi();

                try
                {
                    //comentario para pruebas
                    var json = conexion.ejecutarLlamada("GET", "buscar_por_nombre?nombre="+nombreMedico, "", null);
                    List<Medico> medicos = new List<Medico>();
                    medicos = JsonConvert.DeserializeObject<List<Medico>>(json);
                    Session["listaMedicos"] = medicos;
                    Response.Redirect("ListaMedicos.aspx");
                    

                    


                    /*if (json != null)
                    {
                        Medico medi = JsonConvert.DeserializeObject<Medico>(json);
                        Session["Medico_id"] = medi.id;
                        Session["Medico_nombre"] = medi.nombre;
                        Session["Medico_area"] = medi.area_id;
                        Response.Redirect("TomaHora.aspx");
                    }
                    */
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                    lblMensaje1.Text = "Servicio inhabilitado, intente más tarde o vaya a la posta jeje salu2.";
                }
                
                

            }
        }
        #endregion

        #region Boton buscar dentro de busqueda por area
        protected void btnBuscarArea_Click(object sender, EventArgs e)
        {
            if (ddlArea.SelectedIndex == 0)
            {
                lblMensaje2.Text = "Debe seleccionar un Area.";
            }
            else
            {

                string nombreMedico = txtNombreMedico.Text;
                ConexionApi conexion = new ConexionApi();

                try
                {
                    var json = conexion.ejecutarLlamada("GET", "buscar_por_area?area=" + ddlArea.SelectedIndex, "", null);
                    List<Medico> medicos = new List<Medico>();
                    medicos = JsonConvert.DeserializeObject<List<Medico>>(json);
                    Session["listaMedicos"] = medicos;
                    Response.Redirect("ListaMedicos.aspx");


                    //int area = ddlArea.SelectedIndex;
                    //var response = "http://192.168.43.210:3000/buscar-area/"
                    //       .PostUrlEncodedAsync(new { Area = area })
                    //       .ReceiveJson();
                    //string result = response.Result.ToString();
                    //if (result != "false")
                    //{
                    //    Session["Medicos"] = result;
                    //}

                    //lblMensaje2.Text = response.Result.ToString();
                }
                catch (Exception)
                {
                    lblMensaje2.Text = "Servicio inhabilitado, intente más tarde o vaya a la posta jeje salu2.";
                }
                

            }
        }
        #endregion

    }
}