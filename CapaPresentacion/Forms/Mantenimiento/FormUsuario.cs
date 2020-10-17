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
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            FormUsuarioAgregar frm = new FormUsuarioAgregar();
            frm.ShowDialog();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
