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
    public partial class FormTaller : Form
    {
        public FormTaller()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormAreas());
        }

        private void btnAsistenciaTaller_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormAsistenciaTaller());
        }

        private void btnTareasTaller_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormTareasTaller());
        }

        private void btnAsistenciaInsti_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormInstitucionTaller());
        }
    }
}
