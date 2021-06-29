using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagerProgIII
{
    public partial class Form1 : Form
    {
        //VARIABLES
        private bool _darkModeFlag = false;

        public string _filePath; //el path de busqueda

        private bool _esArch = false; //para saber si es carpeta o arch
        private string _elemSeleccionado = ""; //Guarda el nombre del elem seleccionado
        
        //CONSTRUCTOR DEL FORM
        public Form1()
        {
            InitializeComponent();
            this.treeView1.NodeMouseClick +=
                new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
        }
        
        //EVENTO ONLOAD
        //Se ejecutan los metodos para traer los discos que hay en el sistema, como tambien se setea el textBox de la barra de menu
        private void Form1_Load(object sender, EventArgs e)
        {
            getDrives();
            toolStripTextBox1.Text = _filePath;
           
        }
        

        private void Cargar()
        {
            _filePath = toolStripTextBox1.Text;
            LoadArch_and_FilesListView1();
            _esArch = false;
        }

        private void iniciarApp()
        {
            string tempPathArch="";
            tempPathArch = removeBackLash(_filePath) + @"\" + _elemSeleccionado; //Se toma la ruta completa

            MessageBox.Show(tempPathArch);
            Process.Start(tempPathArch);
        }
        private void LoadArch_and_FilesListView1()
        {
            try
            {
                string tempPathArch="";
                FileAttributes archAttr ;
                if (_esArch)
                {
                    iniciarApp();
                    archAttr = File.GetAttributes(tempPathArch); //Se guardan los atributos
                    MessageBox.Show(archAttr.ToString());
                }
                else
                {
                    archAttr = File.GetAttributes(_filePath);
                }

                if((archAttr & FileAttributes.Directory) == FileAttributes.Directory) //Si es un directorio
                {
                    DirectoryInfo listaArch = new DirectoryInfo(_filePath);
                    FileInfo[] archivos = listaArch.GetFiles(); //se traen los archivos
                    DirectoryInfo[] carpetas = listaArch.GetDirectories(); //Se traen las carpetas
                    string fileExtension = "";
                    listView1.Items.Clear(); //Se limpia lo que estaba antes
                    for (int i = 0; i < archivos.Length; i++)
                    {
                        fileExtension = archivos[i].Extension.ToUpper();
                        switch(fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView1.Items.Add(archivos[i].Name, 5);
                                break;
                            case ".EXE":
                            case ".COM":
                                listView1.Items.Add(archivos[i].Name, 6);
                                break;

                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView1.Items.Add(archivos[i].Name, 4);
                                break;
                            case ".PDF":
                                listView1.Items.Add(archivos[i].Name, 2);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView1.Items.Add(archivos[i].Name, 3);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView1.Items.Add(archivos[i].Name, 8);
                                break;
                            case".RAR":
                                listView1.Items.Add(archivos[i].Name, 1);
                                break;
                            case".TXT":
                                listView1.Items.Add(archivos[i].Name, 9);
                                break;
                            default:
                                listView1.Items.Add(archivos[i].Name, 8);
                                break;
                        }
                    }
                    for (int i = 0; i < carpetas.Length; i++)
                    {
                        listView1.Items.Add(carpetas[i].Name,7);//Se agrega los files
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "hola");
            }
        }
        

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FileInfo nuevo = new FileInfo(nombre);
            Crear ventana = new Crear();
            ventana.ShowDialog();
        }

        private void directorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearDirectorio cd = new CrearDirectorio();
            cd.Show();
        }
        
        void treeView1_NodeMouseClick(object sender,
            TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            toolStripTextBox1.Text = newSelected.FullPath;
            Cargar();
            listView2.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                {new ListViewItem.ListViewSubItem(item, "Directory"),
                    new ListViewItem.ListViewSubItem(item,
                        dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView2.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                { new ListViewItem.ListViewSubItem(item, "File"),
                    new ListViewItem.ListViewSubItem(item,
                        file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView2.Items.Add(item);
            }

            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public string removeBackLash(string path)
        {
            char[] pathSplitted = path.ToCharArray(0,path.Length);
            string str = new string(pathSplitted);
            for (int i = 0;i<pathSplitted.Length;i++)
            {
                if (pathSplitted[i].ToString() == @"\")
                {
                    str = str.Remove(i,1);
                    break;
                }
                
            }

            return str;
        }
       
        private void getDrives()
        {
            string[] drives = Environment.GetLogicalDrives();
            foreach (var drive in drives)
            {
                PopulateTreeView((drive.ToString()));
                
            }
        }
        private void PopulateTreeView(string path)
        {
            TreeNode rootNode;
            DirectoryInfo info = new DirectoryInfo(path);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            try
            {
                TreeNode aNode;
                DirectoryInfo[] subSubDirs;
                foreach (DirectoryInfo subDir in subDirs)
                {
                    aNode = new TreeNode(subDir.Name, 1, 0);
                    aNode.Tag = subDir;
                    aNode.ImageKey = "folder";

                    subSubDirs = subDir.GetDirectories();
                    if (subSubDirs.Length != 0)
                    {
                        GetDirectories(subSubDirs, aNode);
                    }

                    nodeToAddTo.Nodes.Add(aNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
                //Vacio porque no encontre evitar que te salga una exception por acceso no autorizado. De todas formas, no muestra las carpetas no autorizadas
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void darkModeButton_Click(object sender, EventArgs e)
        {
            if (_darkModeFlag == false)
            {
                treeView1.BackColor = Color.FromArgb(64, 64, 64);
                listView1.BackColor = Color.FromArgb(64, 64, 64);
                listView2.BackColor = Color.FromArgb(64, 64, 64);
                listView1.ForeColor = Color.White; 
                listView2.ForeColor = Color.White;
                treeView1.ForeColor = Color.White;
                _darkModeFlag = true;
            } else{
                treeView1.BackColor = Color.White;
                listView1.BackColor = Color.White;
                listView2.BackColor = Color.White;
                listView1.ForeColor = Color.Black; 
                listView2.ForeColor = Color.Black;
                treeView1.ForeColor = Color.Black;
                _darkModeFlag = false;
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged_1(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _elemSeleccionado = e.Item.Text;
            FileAttributes caracArch = File.GetAttributes(_filePath +"/"+ _elemSeleccionado);
            if ((caracArch & FileAttributes.Directory) == FileAttributes.Directory)
            {
                _esArch = false;
                toolStripTextBox1.Text = _filePath + @"\" + _elemSeleccionado;
                
            }
            else
            {
                _esArch = true;

            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Cargar();
        }

        //Método que retorne el directorio actual
        public string getDirectory()
        {

            return "owo";
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
