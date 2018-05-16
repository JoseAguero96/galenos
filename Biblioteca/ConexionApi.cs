using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Biblioteca
{
    public class ConexionApi
    {
        public String ejecutarLlamada(String metodo, String a_consultar, String contenido, Object objeto)
        {
            String url = "http://192.168.43.167:3000/";
            String responseString = "";
            HttpResponseMessage response;
            HttpClient http = new HttpClient();
            


            switch (metodo)
            {
                case "POST":
                    //necesita objeto
                    var jsonpost = new JavaScriptSerializer().Serialize(objeto);
                    StringContent queryString = new StringContent(jsonpost, Encoding.UTF8, "application/json");

                    response = http.PostAsync(url + a_consultar, queryString).Result;
                    var responseContent = response.Content;
                    responseString = responseContent.ReadAsStringAsync().Result;
                    return responseString;

                case "GET":
                    //para todos es el nombre del modelo en plural
                    //para uno es lo mismo que el anterior agregandole el id del consultado EJ: "medicos/1
                    response = http.GetAsync(url + a_consultar).Result;
                    responseContent = response.Content;
                    responseString = responseContent.ReadAsStringAsync().Result;
                    return responseString;

                case "PUT":
                    //necesita objeto
                    var jsonput = new JavaScriptSerializer().Serialize(objeto);
                    var httpContent = new StringContent(jsonput, Encoding.UTF8, "application/json");
                    response = http.PutAsync(url + a_consultar, httpContent).Result;
                    responseContent = response.Content;
                    responseString = responseContent.ReadAsStringAsync().Result;
                    return responseString;

                case "DELETE":
                    //lo mismo que el GET de a 1
                    response = http.DeleteAsync(url + a_consultar).Result;
                    responseContent = response.Content;
                    responseString = responseContent.ReadAsStringAsync().Result;
                    return responseString;

                default:
                    return "Nada";
            }
        }
    }
}
