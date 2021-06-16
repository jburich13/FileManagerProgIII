using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagerProgIII
{
    public partial class Form1 : Form
    {

        private string filePath = "D:";
        private bool esArch = false;
        private string elemSeleccionado = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            pathBox.Text = filePath;
            cargarArchivosyCarpetas();

        }

        public void cargar()
        {
            filePath = pathBox.Text;
            cargarArchivosyCarpetas();
            esArch = false;

        }

        public void cargarArchivosyCarpetas()
        {
            DirectoryInfo listaArch;
            try
            {
                
                listaArch = new DirectoryInfo("D:");
                Console.WriteLine(listaArch);
                FileInfo[] archivos = listaArch.GetFiles();
                DirectoryInfo[] carpetas = listaArch.GetDirectories();
                for(int i = 0; i < archivos.Length; i++)
                {
                    listView1.Items.Add(archivos[i].Name);

                }
                for (int i = 0; i < carpetas.Length; i++)
                {
                    listView1.Items.Add(carpetas[i].Name);

                }
            } catch(Exception e)
            {

            }

            

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            elemSeleccionado = e.Item.Text;
        }
    }
}
