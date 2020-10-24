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
    public class CNUsuario : CNBase
    {
        #region Propiedades
        private Tarea _tarea;
        private TipoMovimiento _tipomov;
        private CEUsuario _entidad;
        private List<CEUsuario> _lista;

        private BackgroundWorker _bwProcesar;
        public event ListadoEventHandler<CEUsuario> CargarInformacion;
        public event EntidadEventHandler<CEUsuario> CargarEntidad;
        #endregion

        #region Agregaciones
        public void AgregarParametros(CEUsuario ceUsuario)
        {
            this._entidad = ceUsuario;
        }
        public void AgregarUsuario(string dato)
        {
            if (_entidad == null)
            {
                OnMensajeAlerta("Posible problema encontrado", "La aplicación no se ha iniciado correctamente");
                return;
            }
            _entidad.usuario = dato;
        }
        public void AgregarPassword(string dato)
        {
            if (_entidad == null)
            {
                OnMensajeAlerta("Posible problema encontrado", "La aplicación no se ha iniciado correctamente");
                return;
            }
            _entidad.password = dato;
        }
        public void AgregarNombres(string dato)
        {
            if (_entidad == null)
            {
                OnMensajeAlerta("Posible problema encontrado", "La aplicación no se ha iniciado correctamente");
                return;
            }
            _entidad.nombres = dato;
        }
        public void AgregarApaterno(string dato)
        {
            if (_entidad == null)
            {
                OnMensajeAlerta("Posible problema encontrado", "La aplicación no se ha iniciado correctamente");
                return;
            }
            _entidad.apaterno = dato;
        }
        public void AgregarAmaterno(string dato)
        {
            if (_entidad == null)
            {
                OnMensajeAlerta("Posible problema encontrado", "La aplicación no se ha iniciado correctamente");
                return;
            }
            _entidad.amaterno = dato;
        }
        public void AgregarDni(string dato)
        {
            if (_entidad == null)
            {
                OnMensajeAlerta("Posible problema encontrado", "La aplicación no se ha iniciado correctamente");
                return;
            }
            _entidad.dni = dato;
        }
        public void AgregarCorreo(string dato)
        {
            if (_entidad == null)
            {
                OnMensajeAlerta("Posible problema encontrado", "La aplicación no se ha iniciado correctamente");
                return;
            }
            _entidad.correo = dato;
        }
        public void AgregarDireccion(string dato)
        {
            if (_entidad == null)
            {
                OnMensajeAlerta("Posible problema encontrado", "La aplicación no se ha iniciado correctamente");
                return;
            }
            _entidad.direccion = dato;
        }
        public void AgregarRol(int dato)
        {
            if (_entidad == null)
            {
                OnMensajeAlerta("Posible problema encontrado", "La aplicación no se ha iniciado correctamente");
                return;
            }
            _entidad.idrol = dato;
        }
        public void AgregarEstado(bool dato)
        {
            if (_entidad == null)
            {
                OnMensajeAlerta("Posible problema encontrado", "La aplicación no se ha iniciado correctamente");
                return;
            }
            _entidad.estado = dato;
        }
        #endregion

        #region Constructores
        public CNUsuario()
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
            _entidad = new CEUsuario();
        }
        #endregion

        #region Metodos
        public void Procesar()
        {
            if (!_bwProcesar.IsBusy)
                _bwProcesar.RunWorkerAsync(new Tuple<Tarea, CEUsuario>(_tarea, _entidad));
            else
                _bwProcesar.CancelAsync();
        }
        private bool Validar(Tarea tarea, CEUsuario _entidad)
        {
            switch (tarea)
            {
                case Tarea.Registrar:
                case Tarea.Modificar:
                    {
                        if (_entidad != null)
                        {
                            string msgAlerta = "";
                            if (tarea == Tarea.Modificar && String.IsNullOrEmpty(_entidad.idusuario))
                            {
                                msgAlerta += "\n• Id Cliente";
                            }

                            if (!string.IsNullOrEmpty(msgAlerta))
                            {
                                msgAlerta = "No ha ingresar los siguientes campos: \n" + msgAlerta;
                                OnMensajeAlerta("Mensaje de Sistema", msgAlerta);
                                return false;
                            }
                        }
                        else
                        {
                            OnMensajeAlerta("Mensaje de Sistema ", "Revise nuevamente la información ingresada para continuar.");
                            return false;
                        }
                    }
                    break;
                case Tarea.Eliminar:
                case Tarea.Seleccionar:
                    {

                        if (_entidad != null)
                        {
                            if (string.IsNullOrEmpty(_entidad.idusuario))
                            {
                                OnMensajeAlerta("Mensaje del Sistema", "Seleccione información a eliminar");
                                return false;
                            }
                        }
                        else
                        {
                            OnMensajeAlerta("Mensaje del Sistema", "Revise nuevamente la información ingresada para continuar");
                            return false;
                        }
                        break;


                    }

                case Tarea.Consultar:
                    break;
                default:
                    break;
            }
            return true;

        }
        #endregion

        #region Eventos

        private void _bwProcesar_DoWork(object sender, DoWorkEventArgs e)
        {

            var origen = (Tuple<Tarea, CEUsuario>)e.Argument;

            if (!Validar(origen.Item1, origen.Item2))
            {
                e.Result = new Resultado<CEUsuario>() { Hubo_Error = true };
                return;
            }

            switch (origen.Item1)
            {
                case Tarea.Registrar:
                    e.Result = new DAOUsuario().Insertar(origen.Item2);
                    break;
                    //case Tarea.Modificar:
                    //    e.Result = Procesar_Modificar_Cliente(origen.Item3);
                    //break;
                    //case Tarea.Eliminar:
                    //    e.Result = new DaobjCliente().Eliminar(origen.Item3);
                    //    break;
                    //case Tarea.Seleccionar:
                    //    switch (origen.Item2)
                    //    {
                    //        case TipoMovimiento.Cliente:
                    //            e.Result = new DaobjCliente().Seleccionar_Un_Cliente_Nro_Nombre_Cliente(origen.Item3);
                    //            break;
                    //        case TipoMovimiento.LineaCredito:
                    //            e.Result = new DaobjCliente().SQLServer_Consultar_VentaCuenta_x_Pagar(origen.Item3);
                    //            break;
                    //        default:
                    //            e.Result = new DaobjCliente().Seleccionar_un_cliente(origen.Item3);
                    //            break;
                    //    }
                    //    break;
                    //case Tarea.Consultar:
                    //    e.Result = new DaobjCliente().Listar(origen.Item3);
                    //    break;

            }
        }
        private void _bwProcesar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var resultado = (Resultado<CEUsuario>)e.Result;

            if (resultado.Hubo_Error)
            {
                if (!String.IsNullOrEmpty(resultado.Mensaje_Error))
                    OnMensajeAlerta("Mensaje de Sistema", resultado.Mensaje_Error.ToString());
            }
            else
            {
                switch (_tarea)
                {
                    case Tarea.Registrar:
                    case Tarea.Modificar:
                    case Tarea.Eliminar:
                        OnReiniciarProceso();
                        OnMensajeInformacion("Manetenimiento de Usuario", "Proceso exitoso");
                        OnNotificacionTermino();
                        break;
                    //case Tarea.Seleccionar:
                    //    switch (_tipomov)
                    //    {
                    //        case TipoMovimiento.LineaCredito:
                    //            OnEntidadCargada(resultado.Entidad2);
                    //            break;
                    //        default:
                    //            _entidad = (DtoCliente)resultado.Entidad2;
                    //            OnEntidadCargada(_entidad);
                    //            break;
                    //    }
                    //    break;
                    //case Tarea.Consultar:
                    //    {
                    //        switch (_tipoMov)
                    //        {
                    //            case TipoMovimiento.Habilitados:
                    //                _lista = resultado.Lista_Binding.ToList();
                    //                var _resultadolista = _lista.Where(x => x.Estado.Equals(true));
                    //                OnCargarInformacion(_resultadolista);
                    //                break;
                    //            default:
                    //                _lista = resultado.Lista_Binding.ToList();
                    //                OnCargarInformacion(_lista);
                    //                break;
                    //        }
                    //    }
                    //    break;

                    default:
                        break;
                }

            }
        }

        #endregion
    }
}
