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
        public Crear()
        {
            InitializeComponent();
        }


        //creacion del archivo
        private void button1_Click(object sender, EventArgs e)
        {
            String nombreArchivo, direccionArchivo, extesionArchivo, discoArchivo;
            discoArchivo = "";extesionArchivo = "";
            Boolean correcto = false;
            if (comboBox_disco.SelectedIndex != -1)
            {
                discoArchivo = comboBox_disco.Items[comboBox_disco.SelectedIndex].ToString();
                correcto = true;
            }else
            {
                MessageBox.Show("No ha Seleccionado un Disco!");
            }
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
                string dir = discoArchivo+direccionArchivo+"/"+nombreArchivo+extesionArchivo;
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
        public void cargarDiscos()
        {
            DriveInfo[] discosInfo = DriveInfo.GetDrives();
            foreach (DriveInfo d in discosInfo)
            {
                comboBox_disco.Items.Add(d.Name);
            }
        }

        private void Crear_Load(object sender, EventArgs e)
        {
            cargarDiscos();
        }

        private void textBox_direccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
