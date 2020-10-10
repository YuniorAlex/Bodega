using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
     public class EntityBase
    {
        public string Usuario_Registro { get; set; }
        public string Usuario_Modificacion { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public DateTime? Fecha_Modificacion { get; set; }
    }
}
