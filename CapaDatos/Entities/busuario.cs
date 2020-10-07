using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entities
{
    public class busuario
    {
        public int idusuario { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public int idrol { get; set; }
        public int idpersona { get; set; }
        public DateTime fechaadd { get; set; }
    }
}
