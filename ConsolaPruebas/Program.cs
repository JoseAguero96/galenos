using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace ConsolaPruebas
{
    class Program
    {
        public partial class Medico
        {
            public int? id { get; set; }
            public string nombre { get; set; }
            public string area_id { get; set; }
            public string foto { get; set; }

        }

        static void Main(string[] args)
        {
            Medico medico = new Medico();
            medico.id = 10019;
            medico.foto = "ninguna";
            medico.nombre = "lE maTIAS sE LA COMÉ atravesé";
            medico.area_id = "10003";
            ConexionApi conexion = new ConexionApi();
            Console.WriteLine(conexion.ejecutarLlamada("DELETE","medicos/10019","", medico));
            Console.ReadKey();
         }
    }
}
