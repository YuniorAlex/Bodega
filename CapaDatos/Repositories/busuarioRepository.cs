using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Contracts;
using CapaDatos.Entities;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Repositories
{
    //IMPLEMENTAR LA SUPERCLASE MAESTRO Y LA INTERFACE REPOSITORIO DE USUARIO
    public class busuarioRepository : MasterRepository, IbusuarioRepository
    {
        //CAMPOS
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        //PROPIEDADES
        //en este caso no usamos por ahora

        //CONSTRUCTOR
        public busuarioRepository()
        {
            selectAll = "SELECT idusuario, usuario, password,rol,apellido+' '+nombre as persona, busuario.fechaadd " +
                        "FROM busuario " +
                        "INNER JOIN brol ON brol.idrol = busuario.idrol " +
                        "INNER JOIN bpersona ON bpersona.idpersona = busuario.idpersona";

            insert = "INSERT INTO busuario VALUES(@usuario,@password,@idrol,@idpersona,@fechaadd)";
            update = "UPDATE busuario SET usuario=@usuario,password=@password,idrol=@idrol,idpersona=@idpersona,fechaadd=@fechaadd WHERE idusuario=@idusuario";
            delete = "DELETE FROM busuario WHERE idusuario=@idusuario";
        }

        //METODOS, COMPORTAMIENTOS
        public int Add(busuario entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@usuario",entity.usuario));
            parameters.Add(new SqlParameter("@password", entity.password));
            parameters.Add(new SqlParameter("@idrol", entity.idrol));
            parameters.Add(new SqlParameter("@idpersona", entity.idpersona));
            parameters.Add(new SqlParameter("@fechaadd", entity.fechaadd));
            return ExecuteNonQuery(insert);
        }

        public int Edit(busuario entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idusuario", entity.idusuario));
            parameters.Add(new SqlParameter("@usuario", entity.usuario));
            parameters.Add(new SqlParameter("@password", entity.password));
            parameters.Add(new SqlParameter("@idrol", entity.idrol));
            parameters.Add(new SqlParameter("@idpersona", entity.idpersona));
            parameters.Add(new SqlParameter("@fechaadd", entity.fechaadd));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<busuario> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listUsuario = new List<busuario>();
            foreach(DataRow item in tableResult.Rows)
            {
                listUsuario.Add(new busuario
                {
                    idusuario = item[0].ToString(),
                    usuario = item[1].ToString(),
                    password = item[2].ToString(),
                    idrol = item[3].ToString(),
                    idpersona=item[4].ToString(),
                    fechaadd= item[5].ToString()
                });
            }
            return listUsuario;
        }

        public int Remove(string idusuario)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idusuario", idusuario));
            return ExecuteNonQuery(delete);
        }
    }
}
