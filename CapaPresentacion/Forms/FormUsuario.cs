using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios.Models;
using CapaNegocios.ValueObjects;

namespace CapaPresentacion.Forms
{
    public partial class FormUsuario : Form
    {
        private busuarioModel busuario = new busuarioModel();
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            Listbusurio();
        }
        private void Listbusurio()
        {
            try
            {
                dataGridView1.DataSource = busuario.GetAll();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
