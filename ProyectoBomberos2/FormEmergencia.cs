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
    public partial class FormEmergencia : Form
    {
        public FormEmergencia()
        {
            InitializeComponent();
        }

        private void FormEmergencia_Load(object sender, EventArgs e)
        {
            reloj.Start();
            reloj_Tick(sender, e);
            lblFecha.Text = DateTime.Now.ToString("yyyy/MM/dd");
            
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
