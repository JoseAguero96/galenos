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
            public int id { get; set; }
            public string nombre { get; set; }
            public string foto { get; set; }

        }

        static void Main(string[] args)
        {
            Medico medico = new Medico();
            medico.foto = "ninguna";
            medico.nombre = "PruebaPost";
            ConexionApi conexion = new ConexionApi();
            Console.WriteLine(conexion.ejecutarLlamada("POST","medicos","", medico));
            Console.ReadKey();
         }
    }
}
