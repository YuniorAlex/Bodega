using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Contracts;
using CapaDatos.Entities;
using CapaDatos.Repositories;
using CapaNegocios.ValueObjects;

namespace CapaNegocios.Models
{
    public class busuarioModel
    {
        private int idusuario;
        private string usuario;
        private string password;
        private int idrol;
        private int idpersona;
        private DateTime fechaadd;

        private IbusuarioRepository busuarioRepository;
        public EntityState State { private get; set; }

        //PROPIEDADES/MODELO DE VISTA/ VALIDAR DATOS
        public int Idusuario { get => idusuario; set => idusuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; } //PRIVADO?
        public int Idrol { get => idrol; set => idrol = value; }
        public int Idpersona { get => idpersona; set => idpersona = value; }
        public DateTime Fechaadd { get => fechaadd; set => fechaadd = value; }
    }
}
