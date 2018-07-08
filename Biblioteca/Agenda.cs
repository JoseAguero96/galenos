using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Agenda
    {
        //{"id":1,"medico_id":5,"atention_module_id":2,"created_at":"2018-06-05T05:10:01.083Z","updated_at":"2018-06-05T05:10:01.083Z","user_id":1,"day":"06/06/18"}
        public int id { get; set; }
        public int medico_id { get; set; }
        public int atention_module_id { get; set; }
        public int user_id { get; set; }
        public string day { get; set; }
        public string nombre_medico { get; set; }
        public string area_medico { get; set; }
        public string nombre_usuario { get; set; }
        public string hora { get; set; }
    }
}
