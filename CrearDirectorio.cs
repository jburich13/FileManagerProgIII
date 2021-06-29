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
        Form1 f1 = new Form1();
        string nombre;
        string directorio;
        
        public CrearDirectorio()
        {
            InitializeComponent();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botón Crear
            try
            {
                Directory.CreateDirectory(directorio + "/" + nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Agregar Datos" + ex.Message);
            }
        }
        public void LoadData()
        {
            nombre = textBox1.Text;
            ///////////////////////////////////////////////////////
            directorio = "a";

            textBox2.Text = directorio;
            
        }
    }
}
