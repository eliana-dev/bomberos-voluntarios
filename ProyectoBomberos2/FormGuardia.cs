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
    public partial class FormGuardia : Form
    {
        public FormGuardia()
        {
            InitializeComponent();
        }
        
          
        private void btnTareaGuardia_Click(object sender, EventArgs e)
        {

            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormTareasGuardia());
        }

        private void btnAsistenciaGuardia_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormAsistenciaGuardia()); 
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormAreas());
        }

        private void btnAsistenciaInsti_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormInstitucionEdificio());
        }

 
    }
}
