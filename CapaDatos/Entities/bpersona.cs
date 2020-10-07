using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entities
{
    public class bpersona
    {
        public int idpersona { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string correo { get; set; }
        public string sexo { get; set; }
        public string direccion { get; set; }
        public DateTime fechaadd { get; set; }
    }
}
