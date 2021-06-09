using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Herencia_Visual
{
    public partial class RegistroDocente : Herencia_Visual.Registro
    {
        public RegistroDocente()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            
        }

        private void RegistroDocentes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
