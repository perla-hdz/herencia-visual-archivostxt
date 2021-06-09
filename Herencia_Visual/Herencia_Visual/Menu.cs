using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Herencia_Visual
{
    public partial class Menu : Herencia_Visual.FormBase
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroEstudiantes estudiante = new RegistroEstudiantes();
            this.Hide();
            estudiante.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroDocente docente = new RegistroDocente();
            this.Hide();
            docente.Show();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes);
            {
                this.Close();
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader leer = new System.IO.StreamReader(@"C:\Users\Licenciaturas\Downloads\Herencia_Visual\Herencia_Visual\archivos\Registroalumnos.txt");
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    //richTextBox1.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
