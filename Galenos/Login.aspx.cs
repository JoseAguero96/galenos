using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Flurl.Http;
using Biblioteca;

namespace Galenos
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ConexionApi conexion = new ConexionApi();
            
            string rut = txtRut.Text;
            string pass = txtPassword.Text;
            var json = new { rut = rut, password = pass };
            var result = conexion.ejecutarLlamada("POST", "logear", "", json);

            if (result != "false")
            {
                Session["cliente"] = result;
            }
            lblMen.Text = result.ToString();
        }
    }
}