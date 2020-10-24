using CapaComun.Enumeraciones;
using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.Forms.Filtro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormUsuario : Form
    {
        #region Variables
        private CNUsuario _cnUsuario;
        private Tarea _tarea;

        #endregion

        #region Constructores
        public FormUsuario(Tarea tarea)
        {
            InitializeComponent();
            _tarea = tarea;
            _cnUsuario = new CNUsuario();
            _cnUsuario.MensajeAlerta += _cnUsuario_MensajeAlerta;
            _cnUsuario.MensajeError += _cnUsuario_MensajeError;
            _cnUsuario.MensajeInformacion += _cnUsuario_MensajeInformacion;
            _cnUsuario.NotificacionTermino += _cnUsuario_NotificacionTermino;
            _cnUsuario.CargarEntidad += _cnUsuario_CargarEntidad;
        }

       
        #endregion

        #region Metodos
        private void Procesar_Informacion()
        {
            _cnUsuario.Iniciar(_tarea);
            _cnUsuario.AgregarUsuario(txt_Usuario.Text);
            _cnUsuario.AgregarPassword(txt_pass.Text);
            _cnUsuario.AgregarNombres(txt_Nombres.Text);
            _cnUsuario.AgregarApaterno(txt_Apaterno.Text);
            _cnUsuario.AgregarAmaterno(txt_Amaterno.Text);
            _cnUsuario.AgregarDni(txt_Dni.Text);
            _cnUsuario.AgregarCorreo(txt_Correo.Text);
            _cnUsuario.AgregarDireccion(txt_Direccion.Text);
            _cnUsuario.AgregarRol(Convert.ToInt32(cbx_Rol.SelectedIndex));
            _cnUsuario.AgregarEstado(Convert.ToBoolean(cbx_Estado.SelectedIndex));
            _cnUsuario.Procesar();
        }
        #endregion

        #region Eventos
        private void _cnUsuario_MensajeAlerta(object sender, CapaComun.Eventos.MensajeEventArgs e)
        {
            MessageBox.Show(e.Detalle, e.Titulo, MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
        }
        private void _cnUsuario_MensajeError(object sender, CapaComun.Eventos.MensajeEventArgs e)
        {
            MessageBox.Show(e.Detalle, e.Titulo, MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
        }
        private void _cnUsuario_MensajeInformacion(object sender, CapaComun.Eventos.MensajeEventArgs e)
        {
            MessageBox.Show(e.Detalle, e.Titulo, MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
        private void _cnUsuario_CargarEntidad(object sender, CapaComun.Eventos.EntidadEventArgs<CEUsuario> e)
        {
            
        }
        private void _cnUsuario_NotificacionTermino(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Procesar_Informacion();
        }

        #endregion

    }
}
