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
    public partial class FormAutomotores : Form
    {
        public FormAutomotores()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormAreas());
        }

        private void btnAsistenciaAutom_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormAsistenciaAutomo());
        }

        private void btnTareasAutom_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormTareasAutomo());
        }

        private void btnAsistenciaInsti_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormInstitucionAutomo());
        }
    }
}
