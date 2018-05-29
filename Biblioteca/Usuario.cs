using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string birth_day { get; set; }
        public string phone_number { get; set; }
        public string rut { get; set; }
        public string fullName
        {
            get { return string.Format("{0} {1}", name, last_name); }
        }
    }
}
