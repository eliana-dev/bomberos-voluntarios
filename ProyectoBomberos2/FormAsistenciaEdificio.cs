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
    public partial class FormAsistenciaEdificio : Form
    {
        public FormAsistenciaEdificio()
        {
            InitializeComponent();
        }

        private void FormAsistenciaEdificio_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverEdificio_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormEdificio());
        }
    }
}
