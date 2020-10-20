using CapaPresentacion.Forms.Mantenimiento;
using CapaPresentacion.Forms.Seguridad;
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
            PersonalizarDiseño();
        }
        #region MENU-DESPLEGABLE
        private void PersonalizarDiseño()
        {
            panelventasubmenudesplegable.Visible = false;
            panelcomprasmenudesplegable.Visible = false;
            panelaccesossubmenudesplegable.Visible = false;
            panelconfiguracionmenudeplegable.Visible = false;
            //..
        }
        private void OcultarSubMenu()
        {
            if (panelventasubmenudesplegable.Visible == true)
                panelventasubmenudesplegable.Visible = false;
            if (panelcomprasmenudesplegable.Visible == true)
                panelcomprasmenudesplegable.Visible = false;
            if (panelaccesossubmenudesplegable.Visible == true)
                panelaccesossubmenudesplegable.Visible = false;
            if (panelconfiguracionmenudeplegable.Visible == true)
                panelconfiguracionmenudeplegable.Visible = false;
        }
        private void MostarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible==false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion
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
            if(MessageBox.Show("¿Esta seguro de cerrar aplicación?", "Cerrar Aplicación", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
        #region MENU-DESPLEGABLE
        private void btnproducto_Click(object sender, EventArgs e)
        {
                FormProducto frm = new FormProducto();
                frm.FormClosed += new FormClosedEventHandler(mostrarInicioAlCerrarForm);
                AbrirFormInPanel(frm);
            
        }

        private void buttonventadesplegable_Click(object sender, EventArgs e)
        {
            MostarSubMenu(panelventasubmenudesplegable);
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.FormClosed += new FormClosedEventHandler(mostrarInicioAlCerrarForm);
            AbrirFormInPanel(frm);
            OcultarSubMenu();
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            FormVenta frm = new FormVenta();
            frm.FormClosed += new FormClosedEventHandler(mostrarInicioAlCerrarForm);
            AbrirFormInPanel(frm);
            OcultarSubMenu();
        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            FormProveedor frm = new FormProveedor();
            frm.FormClosed += new FormClosedEventHandler(mostrarInicioAlCerrarForm);
            AbrirFormInPanel(frm);
            OcultarSubMenu();
        }

        private void btncompra_Click(object sender, EventArgs e)
        {
            FormCompra frm = new FormCompra();
            frm.FormClosed += new FormClosedEventHandler(mostrarInicioAlCerrarForm);
            AbrirFormInPanel(frm);
            OcultarSubMenu();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario frm = new FormUsuario();
            frm.FormClosed += new FormClosedEventHandler(mostrarInicioAlCerrarForm);
            AbrirFormInPanel(frm);
            OcultarSubMenu();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            FormReporte frm = new FormReporte();
            frm.FormClosed += new FormClosedEventHandler(mostrarInicioAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btngrafico_Click(object sender, EventArgs e)
        {
            FormGrafico frm = new FormGrafico();
            frm.FormClosed += new FormClosedEventHandler(mostrarInicioAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btncompradesplegable_Click(object sender, EventArgs e)
        {
            MostarSubMenu(panelcomprasmenudesplegable);
        }

        private void buttonaccesodesplegable_Click(object sender, EventArgs e)
        {
            MostarSubMenu(panelaccesossubmenudesplegable);
        }
        
        private void linkLabelmiperfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormEditarUsuario frm = new FormEditarUsuario();
            frm.ShowDialog();
        }

        private void btnconfiguracion_Click(object sender, EventArgs e)
        {
            MostarSubMenu(panelconfiguracionmenudeplegable);
        }

        private void btnpventa_Click(object sender, EventArgs e)
        {
            FormPuntoVenta frm = new FormPuntoVenta();
            frm.ShowDialog();
            OcultarSubMenu();
        }

        private void btnalmacen_Click(object sender, EventArgs e)
        {
            FormAlmacen frm = new FormAlmacen();
            frm.ShowDialog();
            OcultarSubMenu();
        }
        #endregion

        private void btntalonario_Click(object sender, EventArgs e)
        {
            FormTalonario frm = new FormTalonario();
            frm.ShowDialog();
            OcultarSubMenu();
        }
    }
}
