using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBomberos2
{
    public partial class FormTareasAutomo : Form
    {
        public FormTareasAutomo()
        {
            InitializeComponent();
        }

        private void btnVolverAutomo_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormAutomotores());
        }

        private void FormTareasAutomo_Load(object sender, EventArgs e)
        {

        }
    }
}
