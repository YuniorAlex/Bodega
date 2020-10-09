using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Contracts;
using CapaDatos.Entities;
using CapaDatos.Repositories;
using CapaNegocios.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace CapaNegocios.Models
{
    public class busuarioModel
    {
        private string idusuario;
        private string usuario;
        private string password;
        private string idrol;
        private string idpersona;
        private string fechaadd;

        private  IbusuarioRepository busuarioRepository;
        public EntityState State { private get; set; }

        //PROPIEDADES/MODELO DE VISTA/ VALIDAR DATOS
        public string ID { get => idusuario; set => idusuario = value; }
        [Required(ErrorMessage ="El Campo es requerido")]
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; } //PRIVADO?
        public string Rol { get => idrol; set => idrol = value; }
        public string Persona { get => idpersona; set => idpersona = value; }
        public string Fecha { get => fechaadd; set => fechaadd = value; }

        public busuarioModel() {
            busuarioRepository = new busuarioRepository();
        }
        public string SaveChanges() {
            string message = null;
            try
            {
                var busuarioDataModel = new busuario();
                busuarioDataModel.idusuario = idusuario;
                busuarioDataModel.usuario = usuario;
                busuarioDataModel.password = password;
                busuarioDataModel.idrol = idrol;
                busuarioDataModel.idpersona = idpersona;
                busuarioDataModel.fechaadd = fechaadd;

                switch (State) {
                    case EntityState.Added:
                        //Ejecutar reglas comerciales o calculos
                        busuarioRepository.Add(busuarioDataModel);
                        message = "Se Rigistro Correctamente";
                        break;
                    case EntityState.Modified:
                        busuarioRepository.Edit(busuarioDataModel);
                        message = "Se Modifico Correctamente";
                        break;
                    case EntityState.Deleted:
                        busuarioRepository.Remove(idusuario);
                        message = "Se Elimino Correctamente";
                        break;
                }

            }
            catch(Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                    message = "Dato Diuplicado";
                else
                    message = ex.ToString();
            }
            return message;
        }
        public List<busuarioModel> GetAll()
        {
            var busuarioDataModel = busuarioRepository.GetAll();
            var listbusuario = new List<busuarioModel>();
            foreach (busuario item in busuarioDataModel)
            {
                listbusuario.Add(new busuarioModel
                {
                    ID = item.idusuario,
                    Usuario = item.usuario,
                    Password = item.password,
                    Rol = item.idrol,
                    Persona = item.idpersona,
                    Fecha = item.fechaadd
                });
            }
            return listbusuario;
        }
    }
    
}
