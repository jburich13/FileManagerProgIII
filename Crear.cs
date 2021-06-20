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
    public partial class Crear : Form
    {
        private string direccion = "";
        public Crear()
        {
            InitializeComponent();
        }
        public Crear(string dir)
        {
            direccion = dir;
            InitializeComponent();
        }

        //creacion del archivo
        private void button1_Click(object sender, EventArgs e)
        {
            String nombreArchivo, direccionArchivo, extesionArchivo;
            
            extesionArchivo = "";
            Boolean correcto = false;
            
            if (comboBox_extension.SelectedIndex != -1)
            {
                extesionArchivo = comboBox_extension.Items[comboBox_extension.SelectedIndex].ToString();
                correcto = true;
            }
            else
            {
                MessageBox.Show("No ha Seleccionado una Extensión!");
            }
            nombreArchivo = textBox_nombre.Text;
            direccionArchivo = textBox_direccion.Text;
           
            if (correcto)
            {
                //REALIZAR LA CREACION DEL ARCHIVO
                string dir = direccionArchivo+"/"+nombreArchivo+extesionArchivo;
                File.Create(dir);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha creado el archivo, seleccione correctamente los campos!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void Crear_Load(object sender, EventArgs e)
        {
            textBox_direccion.Text = direccion;            
        }

        private void textBox_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
