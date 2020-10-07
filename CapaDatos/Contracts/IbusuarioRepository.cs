using CapaDatos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contracts
{
    public interface IbusuarioRepository:IGenericRepository<busuario>
    {
        //OTROS METODOS
        //REPORTES DE USUARIOS
        //IEnumerable<busuario> GetUsuario(); MOSTRAR LOS USUARIOS
    }
}
