using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileManagerProgIII
{
    public partial class CrearArchivo : Form
    {
        string nombre;
        string directorio = Form1.pathF2;
        public CrearArchivo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botón Crear
            try
            {
                nombre = textBox1.Text;
                File.Create(directorio + @"\" + nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Agregar Datos" + ex.Message);
            }
            this.Close();
        }

        private void CrearArchivo_Load(object sender, EventArgs e)
        {
            textBox2.Text = Form1.pathF2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
