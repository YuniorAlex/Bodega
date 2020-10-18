using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms.Seguridad
{
    public partial class FormEditarUsuario : Form
    {
        public FormEditarUsuario()
        {
            InitializeComponent();
        }

        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
            InicializarContraseñaEditarControl();
        }
        private void CargarDatosUsuario()
        {
            //VISTA MOSTRAMOS LOS DATOS DE LA CLASE UsuarioCache
            //lblusuario.Text = UsuarioCache.Usuario;
            //lblapellidos.Text = UsuarioCache.Apellidos;
            //lblnombres.Text = UsuarioCache.Nombres;
            //lblcorreo.Text = UsuarioCache.Correo;
            //lblcargo.Text = UsuarioCache.Cargo;

            //EDITAR PANEL
            //txtusuario.Text = UsuarioCache.Usuario;
            //txtapellidos.Text = UsuarioCache.Apellidos;
            //txtnombres.Text = UsuarioCache.Nombres;
            //txtcorreo.Text = UsuarioCache.Correo;
            //txtcontraseña.Text = UsuarioCache.Contraseña;
            //txtconfirmarcontraseña.Text = UsuarioCache.Contraseña;
            //txtcontraseñaactual.Text = "";
        }
        private void InicializarContraseñaEditarControl()
        {
            linkLabeleditar.Text = "Editar";
            txtcontraseña.Enabled = false;
            txtcontraseña.UseSystemPasswordChar = true;
            txtconfirmarcontraseña.Enabled = false;
            txtconfirmarcontraseña.UseSystemPasswordChar = true;
        }
        private void reiniciar()
        {
            CargarDatosUsuario();
            InicializarContraseñaEditarControl();
        }

        private void linkLabeleditarperfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            paneleditardatos.Visible = true;
            CargarDatosUsuario();
        }

        private void linkLabeleditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabeleditar.Text == "Editar")
            {
                linkLabeleditar.Text = "Cancelar";
                txtcontraseña.Enabled = true;
                txtcontraseña.Text = "";
                txtconfirmarcontraseña.Enabled = true;
                txtconfirmarcontraseña.Text = "";
            }
            else if(linkLabeleditar.Text=="Cancelar"){
                reiniciar();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtcontraseña.Text.Length >= 5)
            {
                if (txtcontraseña.Text == txtconfirmarcontraseña.Text)
                {
                    /*USUARIOCACHE ES UNA CLASE COMUN DONDE GUARDA LOS DATOS DEL USUARIO MIENTRAS ESTE EN FUNCIONAMIENTO DEL SISTEMA,
                     USUARIO ES LA CLASE O ENTIDAD USUARIO*/
                    //if (txtcontraseñaactual.Text == UsuarioCache.Contraseña)
                    //{
                    //    var modeloUsuario = new Usuario(idUsuario: UsuarioCache.idUsuario,
                    //                                    Usuario: txtusuario.Text,
                    //                                    Contraseña: txtcontraseña.Text,
                    //                                    Apellidos: txtapellidos.Text,
                    //                                    Nombres: txtnombres.Text,
                    //                                    Carco: null,
                    //                                    Correo: txtcorreo.Text);
                    //    var result = modeloUsuario.editarPerfilUsuario();
                    //    MessageBox.Show(result);
                    //    reiniciar();
                    //    paneleditardatos.Visible = false;

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Contraseña actual incorrecta.");
                    //}
                }
                else
                {
                    MessageBox.Show("La contraseña no coinciden, intente nuevamente.");
                }
            }
            else
            {
                MessageBox.Show("La contraseña debe de tener como minimo 5 caracteres.");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            paneleditardatos.Visible = false;
            reiniciar();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
