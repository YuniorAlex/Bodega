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
    public partial class FormProveedor : Form
    {
        public FormProveedor()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FormProveedorAgregar frm = new FormProveedorAgregar();
            frm.ShowDialog();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FormProveedorEditar frm = new FormProveedorEditar();
            /*if(dataGridViewProducto.SelectedRows.Count>0)
            {
                //frm.textid.Text = dataGridViewProducto.CurrentRow.Cells[0].Value.ToString();
                //HACER IGUAL PARA LOS DEMAS CAMPOS*/
            frm.ShowDialog();
            /*}
            else
            {
                MessageBox.Show("Debe seleccionar fila!");
            }*/
        }
    }
}
