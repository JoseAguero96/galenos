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

        public String encodePass(String pass){

            var pass_codificada = pass;
            pass_codificada = pass_codificada.Replace("a", "zsd");
            pass_codificada = pass_codificada.Replace("b", "yfd");
            pass_codificada = pass_codificada.Replace("c", "x222");
            pass_codificada = pass_codificada.Replace("d", "wa");
            pass_codificada = pass_codificada.Replace("e", "vg");
            pass_codificada = pass_codificada.Replace("f", "usdf");
            pass_codificada = pass_codificada.Replace("g", "tr12");
            pass_codificada = pass_codificada.Replace("h", "saskg");
            pass_codificada = pass_codificada.Replace("i", "reqyu");
            pass_codificada = pass_codificada.Replace("j", "qr76");
            pass_codificada = pass_codificada.Replace("k", "pgf");
            pass_codificada = pass_codificada.Replace("l", "_");
            pass_codificada = pass_codificada.Replace("m", "asd");
            pass_codificada = pass_codificada.Replace("n", "nerq");
            pass_codificada = pass_codificada.Replace("o", "lLL");
            pass_codificada = pass_codificada.Replace("p", "k34");
            pass_codificada = pass_codificada.Replace("q", "j7644");
            pass_codificada = pass_codificada.Replace("r", "i54");
            pass_codificada = pass_codificada.Replace("s", "h23");
            pass_codificada = pass_codificada.Replace("t", "g43");
            pass_codificada = pass_codificada.Replace("u", "f123");
            pass_codificada = pass_codificada.Replace("v", "e76");
            pass_codificada = pass_codificada.Replace("w", "d54");
            pass_codificada = pass_codificada.Replace("x", "c34");
            pass_codificada = pass_codificada.Replace("y", "b31");
            pass_codificada = pass_codificada.Replace("z", "a12");
            return pass_codificada;
        }

        public String ejecutarLlamada(String metodo, String a_consultar, String contenido, Object objeto)
        {
            String url = "http://apigalenos.herokuapp.com/";
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
