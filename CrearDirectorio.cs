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
    public partial class CrearDirectorio : Form
    {
        string nombre;
        string directorio = Form1.pathF2;
        
        public CrearDirectorio()
        {
            InitializeComponent();
            textBox2.Text = directorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botón Crear
            try
            {
                nombre = textBox1.Text;
                Directory.CreateDirectory(directorio + @"\" + nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Agregar Datos" + ex.Message);
            }
            this.Close();
        }

        private void CrearDirectorio_Load(object sender, EventArgs e)
        {
            textBox2.Text = Form1.pathF2;
        }
    }
}
