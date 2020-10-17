using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEUsuario : CEBase
    {
        public string Nom_Usuario { get; set; }
        public string Pass_Usuario { get; set; }
        public byte[] Hash_Pass_Usu { get; set; }
        public string Nombre_Completo { get; set; }
    }
}
