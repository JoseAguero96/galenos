using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
using Newtonsoft.Json.Linq;

namespace Galenos
{
    public partial class Profesionales : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            ConexionApi conexion = new ConexionApi();
            //traer los datos del medico
            var json = conexion.ejecutarLlamada("GET", "medicos" + "", "", null);
            List<Medico> medicos = new List<Medico>();
            medicos = JsonConvert.DeserializeObject<List<Medico>>(json);


            foreach (Medico item in medicos)
            {
                var area = conexion.ejecutarLlamada("GET", "areas/" + item.area_id, "", "");

                JObject jObject = JObject.Parse(area);
                JToken nombreArea = jObject["nombre"];

                item.nombre_area = nombreArea.ToString();
            }

            gvmedicos.DataSource = medicos;
            gvmedicos.DataBind();
        }
    }
}