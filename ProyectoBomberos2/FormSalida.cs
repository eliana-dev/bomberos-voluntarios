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
    public partial class FormSalida : Form
    {
        public FormSalida()
        {
            InitializeComponent();
        }

        private void FormSalida_Load(object sender, EventArgs e)
        {
            reloj.Start();
            reloj_Tick(sender, e);
           // lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblFecha.Text = DateTime.Now.ToString("yyyy/MM/dd");//al ponerlo en este formato podemos poner la fecha en sql como date y no habria problemas al enviarle lo escrito en el label
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btnFirmarSalida_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormInicio());
        }
    }
}
