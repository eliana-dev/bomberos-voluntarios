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
    public partial class FormTareasFurrieles : Form
    {
        public FormTareasFurrieles()
        {
            InitializeComponent();
        }

        private void btnVolverFurrieles_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormFurrieles());
        }
    }
}
