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
    public class DAORol: DAOBase
    {
        public Resultado<CERol> Listar(CERol dto)
        {
            Resultado<CEUsuario> Result = new Resultado<CEUsuario>();
            this._parametersValues = new DynamicParameters();

            this.QueryText = "USP_T_LISTAR_ROL";
            this.QueryType = CommandType.StoredProcedure;

            var _result = this.Listar<CERol>(this.QueryText, param: ParametersValues, commandType: this.QueryType, commandTimeout: 800000);

            if (_result.Hubo_Error)
            {
                _result.Mensaje_Error = "Se encontró un error al Listar Rol";
                return _result;
            }
            else
            {
                _result.Entidad2 = dto;
            }

            return _result;
        }
    }
}
