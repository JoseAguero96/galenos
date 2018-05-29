using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Flurl.Http;
using Biblioteca;
using Newtonsoft.Json;

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
                //Session["cliente"] = result;
                var userjson = conexion.ejecutarLlamada("GET", "users/" + result, "", "");
                Usuario user = JsonConvert.DeserializeObject<Usuario>(userjson);
                Session["user_id"] = user.id;
                Session["user_username"] = user.username;
                Session["user_email"] = user.email;
                Session["user_fullname"] = user.fullName;
                Session["user_phone"] = user.phone_number;
                Session["user_rut"] = user.rut;




            }
            lblMen.Text = result.ToString();
        }
    }
}