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
    public partial class FormPrincipal : Form
    {
        
        public FormPrincipal()
        {
            InitializeComponent();
        }
        public class Formulario : FormUsuario
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario frm = new Formulario();
            frm.Show();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro de cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //DISEÑO DE LA ALERTA
                Application.Exit();
            }
            else{
                //DISEÑO ALERTA
            }
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
            
        }
        private void btnproducto_Click(object sender, EventArgs e)
        {
            FormProducto frm = new FormProducto();
            frm.FormClosed += new FormClosedEventHandler(mostrarInicioAlCerrarForm);
            AbrirFormInPanel(frm);
        }
        private void mostrarInicio()
        {
            AbrirFormInPanel(new FormInicio());
        }
        private void mostrarInicioAlCerrarForm(object sender, FormClosedEventArgs e)
        {
            mostrarInicio();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            mostrarInicio();
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            FormVenta frm = new FormVenta();
            frm.FormClosed += new FormClosedEventHandler(mostrarInicioAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.FormClosed += new FormClosedEventHandler(mostrarInicioAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            FormProveedor frm = new FormProveedor();
            frm.FormClosed += new FormClosedEventHandler(mostrarInicioAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btncompra_Click(object sender, EventArgs e)
        {
            FormCompra frm = new FormCompra();
            frm.FormClosed += new FormClosedEventHandler(mostrarInicioAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            FormEmpleado frm = new FormEmpleado();
            frm.FormClosed += new FormClosedEventHandler(mostrarInicioAlCerrarForm);
            AbrirFormInPanel(frm);
        }
    }
}
