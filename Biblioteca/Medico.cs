using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Medico
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string foto { get; set; }
        public int area_id { get; set; }
        public string nombre_area { get; set; }
        public string nombrecompleto
        {
            get { return string.Format("{0} {1}", nombre, apellido); }
        }

    }
}
