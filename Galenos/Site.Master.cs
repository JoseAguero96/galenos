﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Galenos
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_fullname"] != null)
            {
                btnIngreso.Visible = false;
                btnRegistro.Visible = false;
                btnSalir.Visible = true;
                lblCliente.Text = (string)Session["user_fullname"];
            }else
            {
                btnSalir.Visible = false;
            }
            
        }

        protected void btnIngreso_Click(object sender, EventArgs e)
        {
            Server.Transfer("Login.aspx", true);
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Remove("user_id");
            Session.Remove("user_username");
            Session.Remove("user_email");
            Session.Remove("user_fullname");
            Session.Remove("user_phone");
            Session.Remove("user_rut");
            Response.Redirect("Inicio.aspx");
            
        }

       

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }
    }
}