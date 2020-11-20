using CapaEntidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DAOUsuario : DAOBase
    {
        public Resultado<CEUsuario> Insertar(CEUsuario dto)
        {
           
            Resultado<CEUsuario> Result = new Resultado<CEUsuario>();
            this._parametersValues = new DynamicParameters();
            this._parametersValues.Add("@USUARIO", dto.usuario);
            this._parametersValues.Add("@PASSWORD", dto.password);
            this._parametersValues.Add("@NOMBRES", dto.nombres);
            this._parametersValues.Add("@APATERNO", dto.apaterno);
            this._parametersValues.Add("@AMATERNO", dto.amaterno);
            this._parametersValues.Add("@DNI", dto.dni);
            this._parametersValues.Add("@CORREO", dto.correo);
            this._parametersValues.Add("@DIRECCION", dto.direccion);
            this._parametersValues.Add("@ID_ROL", dto.idrol);
            this._parametersValues.Add("@ESTADO", dto.estado);
            this._parametersValues.Add("@USUARIO_REGISTRO", dto.Usuario_Registro);
            this._parametersValues.Add("@MENSAJE_RESULTADO", null,DbType.String,ParameterDirection.Output,-1);

            this.QueryText = "DBO.USP_T_USUARIO_INSERTAR";
                this.QueryType = CommandType.StoredProcedure;

            var _result = this.Insertar<CEUsuario>();

            if (_result.Hubo_Error)
            {
                if (!string.IsNullOrEmpty(this.ParametersValues.Get<string>("@MENSAJE_RESULTADO")))
                {
                    _result.Mensaje_Error = this.ParametersValues.Get<string>("@MENSAJE_RESULTADO");
                    //_result.Tipo_Mensaje = TipoMensaje.Alert;
                }
                else
                {
                    _result.Mensaje_Error = !string.IsNullOrEmpty(_result.Mensaje_Error) ? _result.Mensaje_Error : "Error al insertar Cliente";
                }
            }
            else
            {
                _result.Entidad2 = dto;
            }

            return _result;
        }
    }
}
