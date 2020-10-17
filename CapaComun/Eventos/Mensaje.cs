using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun.Eventos
{
    public delegate void MensajeEventHandler(object sender, MensajeEventArgs e);
    public class MensajeEventArgs : EventArgs
    {
        public string Titulo { get; set; }
        public string Detalle { get; set; }
        public Enumeraciones.MessageBoxIcon Icono { get; set; }

        public int Opcion { get; set; }

        public MensajeEventArgs(string titulo, string detalle, Enumeraciones.MessageBoxIcon icono)
        {
            Titulo = titulo;
            Detalle = detalle;
            Icono = icono;
        }

        public MensajeEventArgs(string titulo, Enumeraciones.MessageBoxIcon icono)
        {
            Titulo = titulo;
            Detalle = string.Empty;
            Icono = icono;
        }
        public MensajeEventArgs(string titulo, string detalle, int opcion, Enumeraciones.MessageBoxIcon icono)
        {
            Titulo = titulo;
            Detalle = detalle;
            Opcion = Opcion;
            Icono = icono;
        }
    }
}