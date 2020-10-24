using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun.Eventos
{
    public delegate void ListadoEventHandler<T>(object sender, ListadoEventArgs<T> e);
    public class ListadoEventArgs<T> : EventArgs
    {
        public IEnumerable<T> Lista { get; set; }
        public DataTable dataTable { get; set; }
        public string Texto { get; set; }
        public object Dato { get; set; }
        public Dictionary<string, string> Datos { get; set; }

        public ListadoEventArgs(IEnumerable<T> lista)
        {
            Lista = lista;
        }
        public ListadoEventArgs(DataTable _dataTable)
        {
            dataTable = _dataTable;
        }

        public ListadoEventArgs(IEnumerable<T> lista, string texto)
        {
            Lista = lista;
            Texto = texto;
        }
        public ListadoEventArgs(IEnumerable<T> lista, object dato)
        {
            Lista = lista;
            Dato = dato;
        }
        public ListadoEventArgs(IEnumerable<T> lista, Dictionary<string, string> datos)
        {
            Lista = lista;
            Datos = datos;
        }
    }
}
