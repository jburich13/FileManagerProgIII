﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        //VARIABLES
        private string filePath = "D:"; //el path de busqueda
        private bool esArch = false; //para saber si es carpeta o arch
        private string elemSeleccionado = ""; //Guarda el nombre del elem seleccionado
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            pathBox.Text = filePath; //pone el texto del path en el TextBox
            cargarArchivosyCarpetas(); //Funcion que carga los archivos y las carpetas

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
            string tempPathArch="";
            FileAttributes archAttr ;
            try
            {
                if (esArch)
                {
                    tempPathArch = filePath + "/" + elemSeleccionado; //Se toma la ruta completa
                    FileInfo detallesArch = new FileInfo(tempPathArch); //Se crea un FileInfo para tener los detalles
                    fileName.Text = detallesArch.Name; //Se setea el nombre del archivo
                    fileType.Text = detallesArch.Extension; //Se setea la extension
                    archAttr = File.GetAttributes(tempPathArch); //Se guardan los atributos
                }
                else
                {
                    archAttr = File.GetAttributes(filePath);
                }

                if((archAttr & FileAttributes.Directory) == FileAttributes.Directory) //Si es un directorio
                {
                    listaArch = new DirectoryInfo(filePath); 
                    FileInfo[] archivos = listaArch.GetFiles(); //se traen los archivos
                    DirectoryInfo[] carpetas = listaArch.GetDirectories(); //Se traen las carpetas
                    listView1.Items.Clear(); //Se limpia lo que estaba antes
                    for (int i = 0; i < archivos.Length; i++)
                    {
                        listView1.Items.Add(archivos[i].Name,0); //Se agrega los archivos
                    }

                    for (int i = 0; i < carpetas.Length; i++)
                    {
                        listView1.Items.Add(carpetas[i].Name,7);//Se agrega los files
                    }
                }
                else
                {
                    fileName.Text = this.elemSeleccionado;
                }
            }
            catch (Exception e)
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
            FileAttributes caracArch = File.GetAttributes(filePath +"/"+ elemSeleccionado);
            if ((caracArch & FileAttributes.Directory) == FileAttributes.Directory)
            {
                esArch = false;
                pathBox.Text = filePath + "/" + elemSeleccionado;
            }
            else
            {
                esArch = true;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            cargar();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = pathBox.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.esArch = false;
                pathBox.Text = path;
            }
            catch(Exception es)
            {

            }
        }
    }
}
