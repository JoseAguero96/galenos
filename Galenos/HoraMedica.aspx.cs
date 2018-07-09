using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
using Newtonsoft.Json;

namespace Galenos
{
    public partial class HoraMedica : System.Web.UI.Page
    {
        ConexionApi conexion = new ConexionApi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                MultiView1.ActiveViewIndex = 1;
                int usuario = int.Parse(Session["user_id"].ToString());
                List<Agenda> ls = new List<Agenda>();
                var json = conexion.ejecutarLlamada("GET", "agendas" + "", "", null);
                List<Agenda> agendas = new List<Agenda>();
                agendas = JsonConvert.DeserializeObject<List<Agenda>>(json);
                    foreach (Agenda item in agendas)
                    {
                    if (item.user_id == usuario)
                        {
                            string nombre_medico = "";
                            string nombre_area = "";
                            Agenda ag = new Agenda();
                            string nombre_usuario = buscarUsuario(item.user_id);

                            var json2 = conexion.ejecutarLlamada("GET", "medicos/" + item.medico_id, "", null);
                            Medico medicos = new Medico();
                            medicos = JsonConvert.DeserializeObject<Medico>(json2);
                            nombre_medico = medicos.nombrecompleto;
                            nombre_area = buscarArea(medicos.area_id);
                            ag.id = item.id;
                            ag.nombre_usuario = nombre_usuario;
                            ag.nombre_medico = nombre_medico;
                            ag.area_medico = nombre_area;
                            ag.day = item.day;
                            ag.hora = buscarHora(item.atention_module_id);

                            ls.Add(ag);
                        }
                    }
                    gvHoras.DataSource = ls;
                    gvHoras.DataBind();
            }
        }

        private string buscarHora(int atention_module_id)
        {
            var json = conexion.ejecutarLlamada("GET", "atention_modules/" + atention_module_id, "", null);
            Atencion at = new Atencion();
            at = JsonConvert.DeserializeObject<Atencion>(json);
            return at.start_time;
            
        }

        private string buscarArea(int area_id)
        {
            var json = conexion.ejecutarLlamada("GET", "areas/" + area_id, "", null);
            Area areas = new Area();
            areas = JsonConvert.DeserializeObject<Area>(json);
            return areas.nombre;
        }
        private string buscarUsuario(int user_id)
        {
            var json = conexion.ejecutarLlamada("GET", "users/" + user_id, "", null);
            Usuario usuarios = new Usuario();
            usuarios = JsonConvert.DeserializeObject<Usuario>(json);
            return usuarios.fullName;
        }

        protected void gvHoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numero = gvHoras.SelectedIndex;
            string paciente = gvHoras.Rows[numero].Cells[1].Text.ToString();
            string medico = gvHoras.Rows[numero].Cells[2].Text;
            string area = gvHoras.Rows[numero].Cells[3].Text.ToString();
            string fecha = gvHoras.Rows[numero].Cells[4].Text.ToString();
            string hora = gvHoras.Rows[numero].Cells[5].Text.ToString();
            string id = gvHoras.Rows[numero].Cells[6].Text.ToString();

            //txtPaciente
            string textoOriginal1 = paciente;
            string textResultado1 = Regex.Replace(textoOriginal1, @"[^a-zA-z0-9 ]+", "");
            txtPaciente.Text = textResultado1.Replace("237", "í");
            string nombreNormal1 = txtPaciente.Text;
            txtPaciente.Text = nombreNormal1.Replace("225", "á");
            //txtarea.Text = textResultado.ToString(); ;
            //txtMedico
            string textoOriginal = medico;
            string textResultado = Regex.Replace(textoOriginal, @"[^a-zA-z0-9 ]+", "");
            txtMedico.Text = textResultado.Replace("237", "í");
            string nombreNormal = txtMedico.Text;
            txtMedico.Text = nombreNormal.Replace("225", "á");
            //txtarea.Text = textResultado.ToString(); ;
            //txtArea
            string textoOrigina2 = area;
            string textResultado2 = Regex.Replace(textoOrigina2, @"[^a-zA-z0-9 ]+", "");
            txtArea.Text = textResultado2.Replace("237", "í");
            string nombreNorma2 = txtArea.Text;
            txtArea.Text = nombreNorma2.Replace("225", "á");
            //txtarea.Text = textResultado.ToString(); ;

            txtFecha.Text = fecha;
            txtHora.Text = hora;
        }

        protected void eliminarHora_Click(object sender, EventArgs e)
        {
            int numero = gvHoras.SelectedIndex;
            int id = int.Parse(gvHoras.Rows[numero].Cells[6].Text);
            var json = conexion.ejecutarLlamada("DELETE", "agendas/" + id, "", null);
            MultiView1.ActiveViewIndex = 0;


        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Response.Redirect("HoraMedica.aspx");
        }
    }







}