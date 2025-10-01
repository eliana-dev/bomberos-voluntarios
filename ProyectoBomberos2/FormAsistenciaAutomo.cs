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
    public partial class FormAsistenciaAutomo : Form
    {
        public FormAsistenciaAutomo()
        {
            InitializeComponent();
        }

        private void btnVolverAutomo_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormAutomotores());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
