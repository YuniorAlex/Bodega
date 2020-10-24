using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun.Eventos
{
    public delegate void EntidadEventHandler<T>(object sender, EntidadEventArgs<T> e);
    public class EntidadEventArgs<T> : EventArgs
    {
        public T Entidad { get; set; }
        public object Dato { get; set; }

        public EntidadEventArgs(T entidad)
        {
            Entidad = entidad;
        }
        public EntidadEventArgs(T entidad, object dato)
        {
            Entidad = entidad;
            Dato = dato;
        }
    }
}
