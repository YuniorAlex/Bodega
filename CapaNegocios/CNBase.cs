using System;
using CapaComun.Eventos;
using CapaComun.Enumeraciones;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CNBase
    {
        #region Variables y propiedades

        public event EventHandler ReiniciarProceso;
        public event MensajeEventHandler MensajeAlerta;
        public event MensajeEventHandler MensajeError;
        public event MensajeEventHandler MensajeStatus;
        public event MensajeEventHandler MensajeInformacion;
        public event EventHandler NotificacionTermino;
        public event EventHandler Consulta_Async_Termino;
        public event EventHandler NotificacionCancelacion;
        public event EventHandler ImprimirDocumento;
        public event MensajeEventHandler MensajeDecision;

        public event EventHandler ShowPreLoad;
        public event EventHandler HidePreLoad;

        #endregion

        #region Virtuales

        public void OnReiniciarProceso()
        {
            EventArgs e = new EventArgs();
            if (ReiniciarProceso != null)
                ReiniciarProceso(this, e);
        }

        public void OnMensajeAlerta(string titulo, string detalle)
        {
            if (MensajeAlerta == null)
                return;

            MensajeEventArgs e = new MensajeEventArgs(titulo, detalle, MessageBoxIcon.Warning);
            MensajeAlerta(this, e);
        }

        public void OnMensajeError(string titulo, string detalle)
        {
            if (MensajeError == null)
                return;

            MensajeEventArgs e = new MensajeEventArgs(titulo, detalle, MessageBoxIcon.Error);
            MensajeError(this, e);

        }

        public void OnMensajeInformacion(string titulo, string detalle)
        {
            if (MensajeInformacion == null)
                return;

            MensajeEventArgs e = new MensajeEventArgs(titulo, detalle, MessageBoxIcon.Information);
            MensajeInformacion(this, e);
        }


        public int OnMensajeDecision(string titulo, string detalle, int opcion)
        {
            if (MensajeAlerta == null)
                return 0;

            MensajeEventArgs e = new MensajeEventArgs(titulo, detalle, opcion, MessageBoxIcon.Warning);
            e.Opcion = opcion;
            MensajeDecision(this, e);

            return e.Opcion;
        }
        public void OnMensajeStatus(string titulo, string detalle)
        {
            if (MensajeStatus == null)
                return;

            MensajeEventArgs e = new MensajeEventArgs(titulo, detalle, MessageBoxIcon.Information);
            MensajeStatus(this, e);
        }

        #endregion

        #region Métodos
        public void OnNotificacionTermino()
        {
            if (NotificacionTermino != null)
                NotificacionTermino(this, new EventArgs());
        }


        public void OnNotificacionCancelacion()
        {
            if (NotificacionCancelacion != null)
                NotificacionCancelacion(this, new EventArgs());
        }
        public void OnImprimirDocumento()
        {
            if (ImprimirDocumento != null)
                ImprimirDocumento(this, new EventArgs());
        }
        public void OnConsulta_Async_Termino()
        {
            if (Consulta_Async_Termino != null)
                Consulta_Async_Termino(this, new EventArgs());
        }
        #endregion

        #region Eventos
        protected virtual void OnShowPreLoad()
        {
            EventArgs e = new EventArgs();
            if (ShowPreLoad != null)
            {
                ShowPreLoad(null, e);
            }
        }
        protected virtual void OnHidePreLoad()
        {
            EventArgs e = new EventArgs();
            if (HidePreLoad != null)
            {
                HidePreLoad(null, e);
            }
        }
        #endregion
    }
}