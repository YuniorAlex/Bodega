using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEBase
    {
        public string Usuario_Registro { get; set; }

        public string Usuario_Modificacion { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public DateTime? Fecha_Modificacion { get; set; }

    }
}