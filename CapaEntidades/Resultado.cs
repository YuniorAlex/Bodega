using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CapaEntidades
{
    public class Resultado<T>
    {
        public List<T> Lista_Dapper { get; set; }
        public BindingList<T> Lista_Binding { get; set; }
        public dynamic Dato { get; set; }
        public dynamic[] Lista_Dinamica { get; set; }
        public T Entidad2 { get; set; }

        public Dictionary<string, string> Dictionary { get; set; }
        public DataTable dataTable { get; set; }

        public string Mensaje_Error { get; set; }

        public int? Codigo_Error { get; set; }
        public bool Notificacion { get; set; }
        public bool Hubo_Error { get; set; }
        public bool Proceso_Cancelado { get; set; }
        public Exception Error { get; set; }
    }
}
