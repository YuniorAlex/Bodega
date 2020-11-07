using CapaComun.Enumeraciones;
using CapaComun.Eventos;
using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CNRol : CNBase
    {
        #region Variables
        private Tarea _tarea;
        private CERol _entidad;
        private List<CERol> _lista;
        private readonly BackgroundWorker _bwProcesar;
        public event ListadoEventHandler<CERol> CargarInformacion;
        public event EntidadEventHandler<CERol> CargarEntidad;
        #endregion

        #region Constructores
        public CNRol()
        {
            _bwProcesar = new BackgroundWorker();
            _bwProcesar.DoWork += _bwProcesar_DoWork;
            _bwProcesar.RunWorkerCompleted += _bwProcesar_RunWorkerCompleted;
        }
        #endregion

        #region Inicializadores           
        public void Iniciar(Tarea tarea)
        {
            _tarea = tarea;
            _entidad = new CERol();
        }
        #endregion

        #region Agregaciones
        public void AgregarParametros(CERol dtoConceptoPlastico)
        {
            this._entidad = dtoConceptoPlastico;
        }
        public void AgregarIdRol(int dato)
        {
            if (_entidad == null)
            {
                OnMensajeAlerta("Posible problema encontrado", "La aplicación no se ha iniciado correctamente");
                return;
            }
            _entidad.idrol = dato;
        }
        public void AgregarRol(string dato)
        {
            if (_entidad == null)
            {
                OnMensajeAlerta("Posible problema encontrado", "La aplicación no se ha iniciado correctamente");
                return;
            }
            _entidad.rol = dato;
        }
        #endregion

        #region Métodos
        public void Procesar()
        {
            if (!_bwProcesar.IsBusy)
                _bwProcesar.RunWorkerAsync(new Tuple<Tarea, CERol>(_tarea, _entidad));
            else
                _bwProcesar.CancelAsync();
        }
        private bool Validar(Tarea tarea, CERol _entidad)
        {
            switch (tarea)
            {
                case Tarea.Registrar:
                case Tarea.Modificar:
                    {
                        if (_entidad != null)
                        {
                            string msjAlerta = "";
                            if (_entidad.idrol == 0)
                            {
                                msjAlerta += "\n• Id Rol";
                            }
                            if (String.IsNullOrEmpty(_entidad.rol))
                            {
                                msjAlerta += "\n• Rol";
                            }
                        }
                        else
                        {
                            OnMensajeAlerta("Mensaje del Sistema", "Revise nuevamente la información ingresada para continuar");
                            return false;
                        }
                    }
                    break;
            }
            return true;
        }
        #endregion

        #region Eventos
        private void _bwProcesar_DoWork(object sender, DoWorkEventArgs e)
        {
            var origen = (Tuple<Tarea, CERol>)e.Argument;
            if (!Validar(origen.Item1, origen.Item2))
            {
                e.Result = new Resultado<CERol>() { Hubo_Error = true };
                return;
            }

            switch (origen.Item1)
            {
                case Tarea.Listar:
                    e.Result = new DAORol().Listar(origen.Item2);
                    break;

            }
        }

        private void _bwProcesar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var resultado = (Resultado<CERol>)e.Result;
            if (resultado.Hubo_Error)
            {
                if (!String.IsNullOrEmpty(resultado.Mensaje_Error))
                    OnMensajeAlerta("Mensaje de Sistema", resultado.Mensaje_Error);
            }
            else
            {
                switch (_tarea)
                {
                    case Tarea.Registrar:
                    case Tarea.Modificar:
                    case Tarea.Eliminar:
                        OnReiniciarProceso();
                        OnMensajeInformacion("Mantenimiento de Impuesto Plastico", "Proceso exitoso");
                        OnNotificacionTermino();
                        break;
                    case Tarea.Listar:
                        _lista = resultado.Lista_Binding.ToList();
                        OnCargarInformacion(_lista);
                        break;

                }
            }
        }
        #endregion

        #region Virtuales
        private void OnCargarInformacion(IEnumerable<CERol> dato)
        {
            ListadoEventArgs<CERol> e = new ListadoEventArgs<CERol>(dato);
            if (CargarInformacion != null)
                CargarInformacion(this, e);
        }
        private void OnCargarEntidad(CERol dato)
        {
            EntidadEventArgs<CERol> e = new EntidadEventArgs<CERol>(dato);
            if (CargarEntidad != null)
                CargarEntidad(this, e);
        }
        #endregion
    }
}
