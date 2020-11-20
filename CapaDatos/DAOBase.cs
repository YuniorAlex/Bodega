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
using CapaComun.Enumeraciones;

namespace CapaDatos
{
    public class DAOBase
    {
        public DAOBase()
        { 
        
        }

        
        protected IDbConnection _connection_Proveedor;

        private string _queryText = "";
        public string QueryText
        {
            get { return _queryText; }
            set { _queryText = value; }
        }
        public CommandType QueryType
        {
            get { return _queryType; }
            set { _queryType = value; }
        }
        public DynamicParameters _parametersValues = null;
        public DynamicParameters ParametersValues
        {
            get { return _parametersValues; }
            set { _parametersValues = value; }
        }
        public CommandType _queryType = CommandType.Text;
        

        //private IDbConnection connection()
        //{

        //    _connection = new SqlConnection();
        //    _connection.ConnectionString = "Data Source= DESKTOP\\SQLDESKTOP; Initial Catalog = BodegaBD; User ID = sa; Password =123321";

        //    //CONEXION RONY XD
        //    //_connection.ConnectionString = "Server=JRONY;Database=BodegaBD; User Id=sa; Password=123;";

        //    return _connection;
        //}
        private IDbConnection _connection
        {
            get {
                _connection_Proveedor = new SqlConnection();
                //_connection_Proveedor.ConnectionString = string.Format("Data Source = DESKTOP\\SQLDESKTOP; Initial Catalog = BodegaBD; User Id = sa; Password = 123321;");
                _connection_Proveedor.ConnectionString = string.Format("Data Source = DESKTOP-T7DQ6B1; Initial Catalog = BodegaBD; User Id = sa; Password = 12345;");
                return _connection_Proveedor;
            }
        }
       
        public Resultado<T> Insertar<T>()
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                if (_connection.Execute(_queryText, _parametersValues, commandType: _queryType) <= 0)
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
                var output = _connection.Query<T>(_queryText, _parametersValues, commandType: _queryType).Single();

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
                _connection.Execute(sql, param, commandType: commandType, commandTimeout: commandTimeout);
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
            Resultado<T> _Result = new Resultado<T>();

            try
            {
                SqlMapper.GridReader GridResult = _connection.QueryMultiple(sql, param, commandType: commandType, commandTimeout: commandTimeout);
            }
            catch (Exception ex)
            {
                _Result.Hubo_Error = true;
                _Result.Error = ex;
                _Result.Mensaje_Error = ex.Message;
            }

            return _Result;
        }
        public Resultado<T> Execute_SQL<T>(string sql, object param = null, CommandType? commandType = null, int? commandTimeout = null)
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                _connection.Query(sql, param, commandType: commandType, commandTimeout: commandTimeout);
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }

        public Resultado<T> Actualizar<T>()
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                if (_connection.Execute(_queryText, _parametersValues, commandType: _queryType) <= 0)
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
        public Resultado<T> Actualizar<T>(string sql, object param = null, CommandType? commandType = null, int? commandTimeout = null)
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                _connection.Execute(sql, param, commandType: commandType, commandTimeout: commandTimeout);
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Actualizar_Multiple<T>(string sql, object param = null, CommandType? commandType = null, int? commandTimeout = null)
        {
            Resultado<T> _Result = new Resultado<T>();

            try
            {
                SqlMapper.GridReader GridResult = _connection.QueryMultiple(sql, param, commandType: commandType, commandTimeout: commandTimeout);
            }
            catch (Exception ex)
            {
                _Result.Hubo_Error = true;
                _Result.Error = ex;
                _Result.Mensaje_Error = ex.Message;
            }

            return _Result;
        }

        public Resultado<T> Eliminar<T>()
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                if (_connection.Execute(_queryText, _parametersValues, commandType: _queryType) <= 0)
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
                _connection.Execute(sql, param, commandType: commandType, commandTimeout: commandTimeout);
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
            Resultado<T> _Result = new Resultado<T>();

            try
            {
                SqlMapper.GridReader GridResult = _connection.QueryMultiple(sql, param, commandType: commandType, commandTimeout: commandTimeout);
            }
            catch (Exception ex)
            {
                _Result.Hubo_Error = true;
                _Result.Error = ex;
                _Result.Mensaje_Error = ex.Message;
            }

            return _Result;
        }

        public Resultado<T> Consultar_Multiple<T, T2>(string sql, object param = null, CommandType? commandType = null, int? commandTimeout = null)
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                List<dynamic> ListaDinamica = new List<dynamic>();

                using (var Results = _connection.QueryMultiple(sql, param, null, commandTimeout, commandType))
                {
                    ListaDinamica.Add(Results.Read<T>().SingleOrDefault());
                    ListaDinamica.Add(Results.Read<T2>().SingleOrDefault());
                }

                _result.Lista_Dinamica = ListaDinamica.ToArray();
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Consultar_Multiple<T, T2, T3>(string sql, object param = null, CommandType? commandType = null, int? commandTimeout = null)
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                List<dynamic> ListaDinamica = new List<dynamic>();

                using (var Results = _connection.QueryMultiple(sql, param, null, commandTimeout, commandType))
                {
                    ListaDinamica.Add(Results.Read<T>().SingleOrDefault());
                    ListaDinamica.Add(Results.Read<T2>().SingleOrDefault());
                    ListaDinamica.Add(Results.Read<T3>().SingleOrDefault());
                }

                _result.Lista_Dinamica = ListaDinamica.ToArray();
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }
        public Resultado<T> Consultar_Multiple<T, T2, T3, T4>(string sql, object param = null, CommandType? commandType = null, int? commandTimeout = null)
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                List<dynamic> ListaDinamica = new List<dynamic>();

                using (var Results = _connection.QueryMultiple(sql, param, commandTimeout: commandTimeout, commandType: commandType))
                {
                    ListaDinamica.Add(Results.Read<T>().SingleOrDefault());
                    ListaDinamica.Add(Results.Read<T2>().SingleOrDefault());
                    ListaDinamica.Add(Results.Read<T3>().SingleOrDefault());
                    ListaDinamica.Add(Results.Read<T4>().SingleOrDefault());
                }

                _result.Lista_Dinamica = ListaDinamica.ToArray();
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = ex.Message;
            }
            return _result;
        }

        public Resultado<T> Listar<T>()
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T>(_queryText, _parametersValues, commandType: _queryType);
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
                var res = _connection.Query<T, T2, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType);
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
                var res = _connection.Query<T, T2, T3, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType);
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
                var res = _connection.Query<T, T2, T3, T4, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType);
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
                var res = _connection.Query<T, T2, T3, T4, T5, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType);
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
                var res = _connection.Query<T, T2, T3, T4, T5, T6, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType);
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

        public Resultado<T> Consultar<T>()
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T>(_queryText, _parametersValues, commandType: _queryType);
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
        public Resultado<T> Consultar<T>(string sql, object param = null, CommandType? commandType = null, int? commandTimeout = null)
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
        public Resultado<T> Consultar<T, T2>(Func<T, T2, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType);
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
        public Resultado<T> Consultar<T, T2, T3>(Func<T, T2, T3, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType);
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
        public Resultado<T> Consultar<T, T2, T3, T4>(Func<T, T2, T3, T4, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T4, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType);
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
        public Resultado<T> Consultar<T, T2, T3, T4, T5>(Func<T, T2, T3, T4, T5, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T4, T5, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType);
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
        public Resultado<T> Consultar<T, T2, T3, T4, T5, T6>(Func<T, T2, T3, T4, T5, T6, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T4, T5, T6, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType);
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
        public Resultado<T> Consultar<T>(string sql, object param = null, CommandType? commandType = null)
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T>(sql, param, commandType: commandType);
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

        public Resultado<T> Buscar<T>()
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T>(_queryText, _parametersValues, commandType: _queryType);
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
        public Resultado<T> Buscar<T, T2>(Func<T, T2, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType);
                _result.Lista_Binding = new BindingList<T>(res.ToList());
            }
            catch (Exception ex)
            {
                _result.Hubo_Error = true;
                _result.Error = ex;
                _result.Mensaje_Error = "No se pudo Consultar Usuario";
            }
            return _result;
        }
        public Resultado<T> Buscar<T, T2, T3>(Func<T, T2, T3, T> map, string SplitOn = "Id")
        {
            Resultado<T> _result = new Resultado<T>();

            try
            {
                var res = _connection.Query<T, T2, T3, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType);
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
                var res = _connection.Query<T, T2, T3, T4, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType);
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
                var res = _connection.Query<T, T2, T3, T4, T5, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType);
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
                var res = _connection.Query<T, T2, T3, T4, T5, T6, T>(_queryText, map, _parametersValues, splitOn: SplitOn, commandType: _queryType);
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
                var res = _connection.Query<dynamic>(_queryText, _parametersValues, commandType: _queryType);
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

    }
}