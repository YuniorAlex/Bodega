using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEUsuario : CEBase
    {
        //public string Nom_Usuario { get; set; }
        //public string Pass_Usuario { get; set; }
        //public byte[] Hash_Pass_Usu { get; set; }
        //public string Nombre_Completo { get; set; }
         
           public string idusuario{get; set;}
           public string usuario  {get; set;}
           public string password {get; set;}
           public string nombres { get; set; }
           public string apaterno { get; set; }
           public string amaterno { get; set; }
           public string dni { get; set; }
           public string correo { get; set; }
           public string direccion { get; set; }
           public int idrol    {get; set;}
           public bool estado { get; set; }
    }
}
