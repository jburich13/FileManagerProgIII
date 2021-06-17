using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FileManagerProgIII
{
    public partial class CrearArchivos : Form
    {
        string pathArchivo = @"";
        public CrearArchivos()
        {
            InitializeComponent();
        }


        public void cargarDiscos()
        {
            DriveInfo[] discosInfo = DriveInfo.GetDrives();
            foreach(DriveInfo d in discosInfo)
            {
                comboBoxDisco.Items.Add(d.Name);
            }
         
        }

        public void agregarDiscoAlPath()
        {
            if (comboBoxDisco.SelectedIndex != -1)
            {
                pathArchivo = comboBoxDisco.Items[comboBoxDisco.SelectedIndex].ToString();
            }
            else MessageBox.Show("Usted no selecciono ningun disco");
            
        }

        public void agregarDireccionAlPath()
        {
            pathArchivo = pathArchivo + textBoxDireccion.Text;
        }
        public void agregarNombreDelArchivoAlPath()
        {
            pathArchivo = pathArchivo+ @"\" + textBoxNombreDelArchivo.Text;

        }
        public void agregarExtensionAlPath()
        {
            pathArchivo = pathArchivo +"."+ textBoxExtension.Text;
        }


        private void CrearArchivos_Load(object sender, EventArgs e)
        {
            cargarDiscos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptarCrearArchivos_Click(object sender, EventArgs e)
        {
            agregarDiscoAlPath();
            agregarDireccionAlPath();
            agregarNombreDelArchivoAlPath();
            agregarExtensionAlPath();
            try
            {
                File.Create(pathArchivo);
                MessageBox.Show("Archivo creado en la ruta: " + pathArchivo);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Algo no funciono: " + exc.Message);
            }
            
           
        }

        private void buttonCancelarCrearAchivos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
