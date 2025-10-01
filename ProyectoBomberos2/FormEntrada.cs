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
    public partial class FormEntrada : Form
    {
        public FormEntrada()
        {
            InitializeComponent();
           
        }

        private void FormEntrada_Load(object sender, EventArgs e)
        {
            Reloj.Start();
            Reloj_Tick(sender, e);
            lblFecha.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }
        private void Reloj_Tick(object sender, EventArgs e)
        {
           lblHora.Text=DateTime.Now.ToString("HH:mm");
        }

        private void btnFirmarEntrada_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = (FormPrincipal)this.ParentForm;
            principal.AbrirFormularios(new FormInicio());
        }
    }
}
