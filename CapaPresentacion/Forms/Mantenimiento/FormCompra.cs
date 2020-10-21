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
    public partial class FormCompra : Form
    {
        public FormCompra()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
            FormBuscarProveedor frm = new FormBuscarProveedor();
            frm.ShowDialog();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            FormBuscarProducto frm = new FormBuscarProducto();
            frm.ShowDialog();
        }
    }
}
