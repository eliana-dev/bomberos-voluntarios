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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormularios(new FormInicio());

        }
        
       
        
        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            
            AbrirFormularios(new FormAcceso());
        }

        public void AbrirFormularios(Form formInterno) {
            panelContenido.Controls.Clear();

            formInterno.TopLevel = false;
            formInterno.FormBorderStyle = FormBorderStyle.None;
            formInterno.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(formInterno);
            panelContenido.Tag = formInterno;
            formInterno.Show();
        } 
    }

}
