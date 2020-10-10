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
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text=="USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
            }
                
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text=="")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.White;
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text=="CONTRASEÑA")
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.LightGray;
                txtcontraseña.UseSystemPasswordChar = true;

            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text=="")
            {
                txtcontraseña.Text = "CONTRASEÑA";
                txtcontraseña.ForeColor = Color.White;
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBienvenida bienvenida = new FormBienvenida();
            bienvenida.ShowDialog();
            FormPrincipal principal = new FormPrincipal();
            principal.ShowDialog();
        }
    }
}
