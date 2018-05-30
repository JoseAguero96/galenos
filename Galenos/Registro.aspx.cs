using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
using Newtonsoft.Json.Linq;

namespace Galenos
{
    public partial class Registro : System.Web.UI.Page
    {
        ConexionApi conexion = new ConexionApi();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensajeInicial.Text = "";
            DropDownList1.DataSource = JArray.Parse(conexion.ejecutarLlamada("GET", "previsions", "", ""));
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:57785/Inicio.aspx");
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nom = txtNombre.Text;
            string apellido = txtApellido.Text;
            string pass1 = txtContrasenia1.Text;
            string pass2 = txtContrasenia2.Text;
            string rut = txtRut.Text;
            var radioNo = rbNo.Checked;
            var radioSi = rbSi.Checked;
            var prevision = DropDownList1.SelectedValue;
            lblMensaje.Text = "";

            if(pass1 == pass2)
            {
                try
                {
                    var jsonObject = new { nombre = nom, apellido = apellido, contrasenia = pass1, pass2 = pass2, rut = rut, prevision = prevision, radioNo = radioNo, radioSi = radioSi };
                    
                    string result = conexion.ejecutarLlamada("POST", "registrar_usuario", "", jsonObject);
                    if (result != "false")
                    {
                        Response.Redirect("Login.aspx");
                    }
                    lblMen.Text = "true";
                }
                catch (Exception ex)
                {
                    lblMen.Text = "ERROR 404";
                    
                }
            }
            else
            {
                lblMensaje.Text = "Las contraseñas no son Identicas";
            }
            



            
        }
    }
}