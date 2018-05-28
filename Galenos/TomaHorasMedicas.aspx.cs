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
using Newtonsoft.Json.Linq;

namespace Galenos
{
    public partial class TomaHorasMedicas : System.Web.UI.Page
    {
        
        #region Carga Inicial de la Pagina
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarAreas();
            }

        }

        private void cargarAreas()
        {
            ConexionApi conexion = new ConexionApi();
            ddlArea.DataSource = JArray.Parse(conexion.ejecutarLlamada("GET", "areas", "", ""));
            ddlArea.DataTextField = "nombre";
            ddlArea.DataValueField = "id";
            ddlArea.DataBind();


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
            MultiView1.ActiveViewIndex = 2;
        }
        #endregion


        #region Boton buscar dentro de busqueda por nombre Medico
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombreMedico.Text == "")
            {
                lblMensaje1.Text = "Apellido de medico Obligatorio*";
            }
            else
            {
                string nombreMedico = txtNombreMedico.Text;
                ConexionApi conexion = new ConexionApi();

                try
                {
                    //traer los datos del medico
                    var json = conexion.ejecutarLlamada("GET", "buscar_por_nombre?nombre=" + nombreMedico, "", null);
                    List<Medico> medicos = new List<Medico>();
                    medicos = JsonConvert.DeserializeObject<List<Medico>>(json);
                    Session[string.Format("listaMedicos")] = medicos;
                    Response.Redirect("ListaMedicos.aspx");

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
            if (ddlArea.SelectedIndex == -1)
            {
                lblMensaje2.Text = "Debe seleccionar un Area.";
            }
            else
            {


                ConexionApi conexion = new ConexionApi();

                try
                {
                    var json = conexion.ejecutarLlamada("GET", "buscar_por_area?area_id=" + ddlArea.SelectedValue, "", null);
                    List<Medico> medicos = new List<Medico>();
                    medicos = JsonConvert.DeserializeObject<List<Medico>>(json);
                    Session["listaMedicos"] = medicos;
                    Response.Redirect("ListaMedicos.aspx");

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