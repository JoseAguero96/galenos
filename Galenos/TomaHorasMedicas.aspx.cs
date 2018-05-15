﻿using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Galenos
{
    public partial class TomaHorasMedicas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHoraMedico_Click(object sender, EventArgs e)
        {
            lblMensaje1.Text = "";
            txtNombreMedico.Text = "";
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnPorArea_Click(object sender, EventArgs e)
        {
            lblMensaje2.Text = "";
            ddlArea.SelectedIndex = 0;
            MultiView1.ActiveViewIndex = 2;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombreMedico.Text == "")
            {
                lblMensaje1.Text = "Apellido de medico Obligatorio*";
            }
            else
            {
                string nombreMedico = txtNombreMedico.Text;
                var response = "http://apigalenos.herokuapp.com/medicos/buscar_por_nombre"
                       .PostUrlEncodedAsync(new { nombre = nombreMedico })
                       .ReceiveJson();
                try
                {
                    string result = response.Result.ToString();
                    if (result != "false")
                    {
                        lblMensaje1.Text = response.Result.ToString();
                        Session["Medicos"] = result;
                    }
                    else
                    {
                        if (result == null)
                        {
                            lblMensaje1.Text = "No se encontró el Medico buscado.";
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    lblMensaje1.Text = "Servicio inhabilitado, intente más tarde o vaya a la posta jeje salu2.";
                }
                
                if (txtNombreMedico.Text == "Matias")
                {
                    MultiView1.ActiveViewIndex = 0;
                }


            }
        }

        protected void btnBuscarArea_Click(object sender, EventArgs e)
        {
            if (ddlArea.SelectedIndex == 0)
            {
                lblMensaje2.Text = "Debe seleccionar un Area.";
            }
            else
            {
                int area = ddlArea.SelectedIndex;
                var response = "http://192.168.43.210:3000/buscar-area/"
                       .PostUrlEncodedAsync(new { Area = area })
                       .ReceiveJson();
                string result = response.Result.ToString();
                if (result != "false")
                {
                    Session["Medicos"] = result;
                }

                lblMensaje1.Text = response.Result.ToString();

            }
        }

        
    }
}