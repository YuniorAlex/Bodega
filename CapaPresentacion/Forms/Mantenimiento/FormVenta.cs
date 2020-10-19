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
    public partial class FormVenta : Form
    {
        public FormVenta()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            FormBuscarCliente frm = new FormBuscarCliente();
            frm.ShowDialog();
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            FormBuscarProducto frm = new FormBuscarProducto();
            frm.ShowDialog();
        }
    }
}
