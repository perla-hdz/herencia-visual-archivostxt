using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Herencia_Visual
{
    public partial class Registro : Herencia_Visual.FormBase
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {

        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter escribir = new System.IO.StreamWriter(@"C:\Users\Licenciaturas\Downloads\Herencia_Visual\Herencia_Visual\archivos\Registroalumnos.txt", true);
            try
            {
                escribir.WriteLine("Nombre del alumno: " + textBox1.Text);
                escribir.WriteLine("Usuario: " + textBox2.Text);
                escribir.WriteLine("Código / password: " + textBox3.Text);
                escribir.WriteLine("\n");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            escribir.Close();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m1 = new Menu();
            this.Hide();
            m1.Show();
        }
    }
}
