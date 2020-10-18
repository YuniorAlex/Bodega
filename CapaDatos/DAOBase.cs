using CapaEntidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CapaDatos
{
    public class DAOBase
    {

        protected IDbConnection _connection;

        public string _queryText = "";
        public DynamicParameters _parametersValues = null;
        public CommandType _queryType = CommandType.Text;
        private int _commandTimeout = 600000;

        private IDbConnection connection()
        {

            _connection = new SqlConnection();
            //_connection.ConnectionString = "Data Source= DESKTOP\\SQLDESKTOP; Initial Catalog = IMM; User ID = sa; Password =123321";

            //CONEXION RONY XD
            _connection.ConnectionString = "Server=JRONY;Database=BodegaBD; User Id=sa; Password=123;";

            return _connection;
        }
        #region INSERTAR

        public Resultado<T> Insertar<T>()
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                if (_connection.Execute(_queryText, _parametersValues, commandType: _queryType, commandTimeout: _commandTimeout) <= 0)
                    _result.Hubo_Error = true;
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Insertar<T>(bool isOuput)
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var output = _connection.Query<T>(_queryText, _parametersValues, commandType: _queryType, commandTimeout: _commandTimeout).Single();

                if (output == null)
                {
                    _result.Hubo_Error = true;
                }
                else
                {
                    _result.Dato = output;
                }
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }

            return _result;
        }
        public Resultado<T> Insertar<T>(string sql, object param = null, CommandType? commandType = null, int? commandTimeout = null)
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                if (_connection.Execute(sql, param, commandType: commandType, commandTimeout: commandTimeout) <= 0)
                    _result.Hubo_Error = true;
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Insertar_Multiple<T>(string sql, object param = null, CommandType? commandType = null, int? commandTimeout = null)
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                SqlMapper.GridReader GridResult = _connection.QueryMultiple(sql, param, commandType: commandType, commandTimeout: commandTimeout);
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }

            return _result;
        }

        #endregion

        #region MODIFICAR

        public Resultado<T> Modificar<T>()
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                if (_connection.Execute(_queryText, _parametersValues, commandType: _queryType, commandTimeout: _commandTimeout) <= 0)
                    _result.Hubo_Error = true;
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Modificar<T>(string sql, object param = null, CommandType? commandType = null, int? commandTimeout = null)
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                if (_connection.Execute(sql, param, commandType: commandType, commandTimeout: commandTimeout) <= 0)
                    _result.Hubo_Error = true;
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Modificar_Multiple<T>(string sql, object param = null, CommandType? commandType = null, int? commandTimeout = null)
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                SqlMapper.GridReader GridResult = _connection.QueryMultiple(sql, param, commandType: commandType, commandTimeout: commandTimeout);
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }

            return _result;
        }

        #endregion

        #region ELIMINAR

        public Resultado<T> Eliminar<T>()
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                if (_connection.Execute(_queryText, _parametersValues, commandType: _queryType, commandTimeout: _commandTimeout) <= 0)
                    _result.Hubo_Error = true;
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Eliminar<T>(string sql, object param = null, CommandType? commandType = null, int? commandTimeout = null)
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                if (_connection.Execute(sql, param, commandType: commandType, commandTimeout: commandTimeout) <= 0)
                    _result.Hubo_Error = true;
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Eliminar_Multiple<T>(string sql, object param = null, CommandType? commandType = null, int? commandTimeout = null)
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                SqlMapper.GridReader GridResult = _connection.QueryMultiple(sql, param, commandType: commandType, commandTimeout: commandTimeout);
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }

            return _result;
        }

        #endregion

        #region LISTAR INFORMATION

        public Resultado<T> Listar<T>()
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T>(_queryText, _parametersValues, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Lista_Binding = new BindingList<T>(res.ToList());
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Listar<T, T2>(Func<T, T2, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Lista_Binding = new BindingList<T>(res.ToList());
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Listar<T, T2, T3>(Func<T, T2, T3, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Lista_Binding = new BindingList<T>(res.ToList());
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Listar<T, T2, T3, T4>(Func<T, T2, T3, T4, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T4, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Lista_Binding = new BindingList<T>(res.ToList());
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;

        }
        public Resultado<T> Listar<T, T2, T3, T4, T5>(Func<T, T2, T3, T4, T5, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T4, T5, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Lista_Binding = new BindingList<T>(res.ToList());
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;

        }
        public Resultado<T> Listar<T, T2, T3, T4, T5, T6>(Func<T, T2, T3, T4, T5, T6, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T4, T5, T6, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Lista_Binding = new BindingList<T>(res.ToList());
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;

        }
        public Resultado<T> Listar<T>(string sql, object param = null, CommandType? commandType = null, int? commandTimeout = null)
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T>(sql, param, commandType: commandType, commandTimeout: commandTimeout);
                _result.Lista_Binding = new BindingList<T>(res.ToList());
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }


        #endregion

        #region OBTENER UN DATO

        public Resultado<T> Obtener<T>()
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T>(_queryText, _parametersValues, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Entidad2 = res.SingleOrDefault();
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Obtener<T>(string sql, object param = null, CommandType? commandType = null, int? commandTimeout = null)
        {
            Resultado<T> _result = new Resultado<T>();
            try
            {
                var res = _connection.Query<T>(sql, param, commandType: commandType, commandTimeout: commandTimeout);
                _result.Entidad2 = res.SingleOrDefault();
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Obtener<T, T2>(Func<T, T2, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Entidad2 = res.SingleOrDefault();
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Obtener<T, T2, T3>(Func<T, T2, T3, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Entidad2 = res.SingleOrDefault();
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Obtener<T, T2, T3, T4>(Func<T, T2, T3, T4, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T4, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Entidad2 = res.SingleOrDefault();
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;

        }
        public Resultado<T> Obtener<T, T2, T3, T4, T5>(Func<T, T2, T3, T4, T5, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T4, T5, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Entidad2 = res.SingleOrDefault();
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;

        }
        public Resultado<T> Obtener<T, T2, T3, T4, T5, T6>(Func<T, T2, T3, T4, T5, T6, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T4, T5, T6, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Entidad2 = res.SingleOrDefault();
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;

        }
        public Resultado<T> Obtener<T>(string sql, object param = null, CommandType? commandType = null)
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T>(sql, param, commandType: commandType, commandTimeout: _commandTimeout);
                _result.Entidad2 = res.SingleOrDefault();
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }


        #endregion

        #region BUSCAR INFORMATION

        public Resultado<T> Buscar<T, T2>(Func<T, T2, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Lista_Binding = new BindingList<T>(res.ToList());
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Buscar<T, T2, T3>(Func<T, T2, T3, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Lista_Binding = new BindingList<T>(res.ToList());
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Buscar<T, T2, T3, T4>(Func<T, T2, T3, T4, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T4, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Lista_Binding = new BindingList<T>(res.ToList());
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Buscar<T, T2, T3, T4, T5>(Func<T, T2, T3, T4, T5, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T4, T5, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Lista_Binding = new BindingList<T>(res.ToList());
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Buscar<T, T2, T3, T4, T5, T6>(Func<T, T2, T3, T4, T5, T6, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T4, T5, T6, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType, commandTimeout: _commandTimeout);
                _result.Lista_Binding = new BindingList<T>(res.ToList());
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Buscar<T>(ref dynamic retornar, bool ValidarDtoOk = true, string MsgValidar = null)
        {
            Resultado<T> _result = new Resultado<T>();

            if (!ValidarDtoOk)
            {
                _result.Hubo_Error = true;
                _result.Mensaje_Error = MsgValidar;
                return _result;
            }

            try
            {
                var res = _connection.Query<dynamic>(_queryText, _parametersValues, commandType: _queryType, commandTimeout: _commandTimeout);
                retornar = res.First();
                _result.Dato = res.First();
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }


        #endregion
    }
}