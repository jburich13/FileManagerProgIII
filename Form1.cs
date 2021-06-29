using System;
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
        private bool darkModeFlag = false;
        private string filePath = "D:/"; //el path de busqueda
        private bool esArch = false; //para saber si es carpeta o arch
        private string elemSeleccionado = ""; //Guarda el nombre del elem seleccionado
        public Form1()
        {
            InitializeComponent();
            this.treeView1.NodeMouseClick +=
                new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getDrives();
            
            pathBox.Text = filePath; //pone el texto del path en el TextBox
            cargarArchivosyCarpetas(); //Funcion que carga los archivos y las carpetas
            

        }
        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            TreeNode curNode = addInMe.Add(directoryInfo.Name);

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                curNode.Nodes.Add(file.FullName, file.Name);
            }
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                BuildTree(subdir, curNode.Nodes);
            }
        }

        public void cargar()
        {
            filePath = toolStripTextBox1.Text;
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
                    archAttr = File.GetAttributes(tempPathArch); //Se guardan los atributos
                    Process.Start(tempPathArch);
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
                else
                {
                    
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
            cargar();
        }
                

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String nombre = "";
            //FileInfo nuevo = new FileInfo(nombre);
            Crear ventana = new Crear();
            ventana.ShowDialog();
        }

        private void directorioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        void treeView1_NodeMouseClick(object sender,
            TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            toolStripTextBox1.Text = newSelected.FullPath;
            cargar();
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
            catch(Exception ex)
            {
                
            }
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void darkModeButton_Click(object sender, EventArgs e)
        {
            if (darkModeFlag == false)
            {
                treeView1.BackColor = Color.FromArgb(64, 64, 64);
                listView1.BackColor = Color.FromArgb(64, 64, 64);
                listView2.BackColor = Color.FromArgb(64, 64, 64);
                listView1.ForeColor = Color.White; 
                listView2.ForeColor = Color.White;
                treeView1.ForeColor = Color.White;
                darkModeButton.Image = Image.FromFile(@"C:\Users\Juan\Desktop\Programacion\FileManagerPorgIII\img\sun.png");
                darkModeFlag = true;
            } else{
                treeView1.BackColor = Color.White;
                listView1.BackColor = Color.White;
                listView2.BackColor = Color.White;
                listView1.ForeColor = Color.Black; 
                listView2.ForeColor = Color.Black;
                treeView1.ForeColor = Color.Black;
                darkModeButton.Image = Image.FromFile(@"C:\Users\Juan\Desktop\Programacion\FileManagerPorgIII\img\moon.png");
                darkModeFlag = false;
            }
            
        }
    }
}
