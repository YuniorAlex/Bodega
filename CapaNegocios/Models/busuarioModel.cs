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
        private int idusuario;
        private string usuario;
        private string password;
        private int idrol;
        private int idpersona;
        private DateTime fechaadd;

        private  IbusuarioRepository busuarioRepository;
        public EntityState State { private get; set; }

        //PROPIEDADES/MODELO DE VISTA/ VALIDAR DATOS
        public int Idusuario { get => idusuario; set => idusuario = value; }
        [Required(ErrorMessage ="El Campo es requerido")]
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; } //PRIVADO?
        public int Idrol { get => idrol; set => idrol = value; }
        public int Idpersona { get => idpersona; set => idpersona = value; }
        public DateTime Fechaadd { get => fechaadd; set => fechaadd = value; }

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
                    Idusuario = item.idusuario,
                    Usuario = item.usuario,
                    Password = item.password,
                    Idrol = item.idrol,
                    Idpersona = item.idpersona,
                    Fechaadd = item.fechaadd
                });
            }
            return listbusuario;
        }
    }
    
}
