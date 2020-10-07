using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Repositories
{
    //CLASE ES GERENICO PARA TODOS LOS REPOSITORIOS QUE SE USE
    public abstract class MasterRepository:Repository
    {
        protected List<SqlParameter> parameters;

        protected int ExecuteNonQuery(string transactSql)
        {
            //ENCARGADO DE EJECUTAR COMANDOS NO CONSULTA (COMANDOS PARA INSERTAR, EDITAR Y ELIMINAR DATOS)
            using (var connection = GetConnection())
            {
                connection.Open();
                using ( var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSql;
                    command.CommandType = CommandType.Text;
                    foreach(SqlParameter item in parameters)
                    {
                        command.Parameters.Add(item);
                    }
                    int result = command.ExecuteNonQuery();
                    parameters.Clear();
                    return result;
                }
            }
        }
        protected DataTable ExecuteReader(string transactSql)
        {
            //ENCARGADO DE EJECUTAR METODOS DE CONSULTA PARA LEER FILAS DE TABLA Y MOSTRAR DATOS DE UNA TABLA
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSql;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }
                }
            }
        }

    }
}
