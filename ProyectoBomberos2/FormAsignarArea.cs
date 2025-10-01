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
    public partial class FormAsignarArea : Form
    {
        public FormAsignarArea()
        {
            InitializeComponent();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormAdministracion());
        }

        private void FormAsignarArea_Load(object sender, EventArgs e)
        {

        }

        
    }
}
