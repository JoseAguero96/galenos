using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConexionApi conexion = new ConexionApi();
            var result = conexion.ejecutarLlamada("PUT", "/medicos/15", "", new { apellido = "Don wea" });
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
