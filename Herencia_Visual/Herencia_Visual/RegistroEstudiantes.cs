using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Herencia_Visual
{
    public partial class RegistroEstudiantes : Herencia_Visual.Registro
    {
        public RegistroEstudiantes()
        {
            InitializeComponent();
        }

        private void RegistroEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
           
        }

        private void RegistroEstudiantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
