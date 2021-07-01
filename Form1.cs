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
using System.Web;
using System.Xml;
using System.Reflection;

namespace FileManagerProgIII
{
    public partial class Form1 : Form
    {
        //VARIABLES
        private bool _darkModeFlag = false;
        FileAttributes archAttr ;
        private string _filePath=""; //el path de busqueda
        string tempPathArch="";
        private bool _esArch = false; //para saber si es carpeta o arch
        private string _elemSeleccionado = ""; //Guarda el nombre del elem seleccionado
        public static string pathF2 = "";
        public string guardar;        
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
        private void LoadArch_and_FilesListView1()
        {
            try
            {
                iniciarApp();
                loadDirandFiles();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }
        
        //DARK MODE HANDLER
        private void darkModeButton_Click(object sender, EventArgs e)
        {
            darkModeChanger(_darkModeFlag);
        }
        
        //Esta funcion: si es un archivo, lo abre.
        //Si es un dir guarda los attr para que en loadDirAndFiles() puedas comprobar si efectivamente es un Dir
        private void iniciarApp()
        {           
            if (_esArch)
            {
                tempPathArch = removeBackLash(_filePath) + @"\" + _elemSeleccionado; //Se toma la ruta completa
                archAttr = File.GetAttributes(tempPathArch); //Se guardan los atributos
                Process.Start(tempPathArch);
            }
            else
            {
                archAttr = File.GetAttributes(_filePath);
            }
        }
        //Funcion para comprobar si estamos parados en un dir, y si es asi te trae los files y dirs de adentro
        private void loadDirandFiles()
        {
            if((archAttr & FileAttributes.Directory) == FileAttributes.Directory) //Si es un directorio
            {
                    DirectoryInfo listaArch = new DirectoryInfo(_filePath);
                    FileInfo[] archivos = listaArch.GetFiles(); //se traen los archivos
                    DirectoryInfo[] carpetas = listaArch.GetDirectories(); //Se traen las carpetas
                    listView1.Items.Clear(); //Se limpia lo que estaba antes
                    loadFilesWithImg(archivos);
                    loadDirWithImg(carpetas);
            }
        }
        
        //Añade los dirs a ListView1, con su img
        private void loadDirWithImg(DirectoryInfo[] carpetas)
        {
            for (int i = 0; i < carpetas.Length; i++)
            {
                listView1.Items.Add(carpetas[i].Name,39);//Se agrega los files
            }
                
        } 
        
        //Añade los files a ListView1, con su img
        private void loadFilesWithImg(FileInfo[] archivos)
        {
            string fileExtension = "";
            for (int i = 0; i < archivos.Length; i++)
            {
                fileExtension = archivos[i].Extension.ToUpper();
                switch(fileExtension)
                {
                    case ".MXF":
                        listView1.Items.Add(archivos[i].Name, 0);
                        break;
                    case ".MDF":
                        listView1.Items.Add(archivos[i].Name, 1);
                        break;
                    case ".NRG":
                        listView1.Items.Add(archivos[i].Name, 2);
                        break;
                    case ".ARJ":
                        listView1.Items.Add(archivos[i].Name, 3);
                        break;
                    case ".MP2":
                        listView1.Items.Add(archivos[i].Name, 4);
                        break;
                    case ".FLA":
                        listView1.Items.Add(archivos[i].Name, 5);
                        break;
                    case".WMA":
                        listView1.Items.Add(archivos[i].Name, 6);
                        break;
                    case".RTF":
                        listView1.Items.Add(archivos[i].Name, 7);
                        break;
                    case".AAC":
                        listView1.Items.Add(archivos[i].Name, 8);
                        break;
                    case".FLAC":
                        listView1.Items.Add(archivos[i].Name, 9);
                        break;
                    case".SVG":
                        listView1.Items.Add(archivos[i].Name, 10);
                        break;
                    case".WAV":
                        listView1.Items.Add(archivos[i].Name, 11);
                        break;
                    case".AI":
                        listView1.Items.Add(archivos[i].Name, 12);
                        break;
                    case".AVI":
                        listView1.Items.Add(archivos[i].Name, 13);
                        break;
                    case".DBF":
                        listView1.Items.Add(archivos[i].Name, 14);
                        break;
                    case".DWG":
                        listView1.Items.Add(archivos[i].Name, 15);
                        break;
                    case".PSD":
                        listView1.Items.Add(archivos[i].Name, 16);
                        break;
                    case".ISO":
                        listView1.Items.Add(archivos[i].Name, 17);
                        break;
                    case".7Z":
                        listView1.Items.Add(archivos[i].Name, 18);
                        break;
                    case".JS":
                        listView1.Items.Add(archivos[i].Name, 19);
                        break;
                    case".GIF":
                        listView1.Items.Add(archivos[i].Name, 20);
                        break;
                    case".TIFF":
                        listView1.Items.Add(archivos[i].Name, 21);
                        break;
                    case".CSS":
                        listView1.Items.Add(archivos[i].Name, 22);
                        break;
                    case".EXE":
                        listView1.Items.Add(archivos[i].Name, 23);
                        break;
                    case".RAR":
                        listView1.Items.Add(archivos[i].Name, 24);
                        break;
                    case".MP4":
                        listView1.Items.Add(archivos[i].Name, 25);
                        break;
                    case".MP3":
                        listView1.Items.Add(archivos[i].Name, 26);
                        break;
                    case".PPT":
                        listView1.Items.Add(archivos[i].Name, 27);
                        break;
                    case".PNG":
                        listView1.Items.Add(archivos[i].Name, 28);
                        break;
                    case".TXT":
                        listView1.Items.Add(archivos[i].Name, 29);
                        break;
                    case".CSV":
                        listView1.Items.Add(archivos[i].Name, 30);
                        break;
                    case".ZIP":
                        listView1.Items.Add(archivos[i].Name, 31);
                        break;
                    case".XML":
                        listView1.Items.Add(archivos[i].Name, 32);
                        break;
                    case".HTML":
                        listView1.Items.Add(archivos[i].Name, 33);
                        break;
                    case".JPG":
                        listView1.Items.Add(archivos[i].Name, 34);
                        break;
                    case".JSON":
                        listView1.Items.Add(archivos[i].Name, 35);
                        break;
                    case".DOC":
                    case".DOCX":
                        listView1.Items.Add(archivos[i].Name, 36);
                        break;
                    case".XLS":
                        listView1.Items.Add(archivos[i].Name, 37);
                        break;
                    case".PDF":
                        listView1.Items.Add(archivos[i].Name, 38);
                        break;
                    default:
                        listView1.Items.Add(archivos[i].Name, 40);
                        break;
                }
            }
        }
        //Evento click de los nodos del TreeView.
        void treeView1_NodeMouseClick(object sender,
            TreeNodeMouseClickEventArgs e)
        {
            _esArch = false;
            _elemSeleccionado = ""; //Setea el elemSeleccionado a vacio. Esto porque tuvimos una falla
                                    //donde si seleccionabas un archivo y despues seleccionabas un nodo, se rompia
            TreeNode newSelected = e.Node; //Guardas el nodo que seleccionaste
            toolStripTextBox1.Text = newSelected.FullPath; //Seteas el path del nodo en la barra de busqueda
            _elemSeleccionado = e.Node.Text;//tomas el nombre del elemento
            Cargar(); //Cargas en el ListView1 los files y dirs del path que seteamos arriba
            listView2.Items.Clear(); //Borras lo que tenias en el ListView2. Esto para no acumular carpetas viejas
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag; //Traes la info del nodo que seleccionaste.
                                                                        //Como siempre vas a seleccionar Directorios, no hay control para hacer
            loadDirInListView2(nodeDirInfo); //Carga los dirs al ListView2
            loadFilesInListView2(nodeDirInfo); //Carga los files al ListView2
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); //Resize a las columnas del ListView2
        }

        private void loadFilesInListView2(DirectoryInfo nodeDirInfo)
        {
            ListViewItem item = null;
            ListViewItem.ListViewSubItem[] subItems;
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                { 
                    new ListViewItem.ListViewSubItem(item, "File"),
                    new ListViewItem.ListViewSubItem(item,  file.LastAccessTime.ToShortDateString()),
                    new ListViewItem.ListViewSubItem(item, file.Extension)
                };
                item.SubItems.AddRange(subItems);
                listView2.Items.Add(item);
            }
        }
        private void loadDirInListView2(DirectoryInfo nodeDirInfo)
        {
            ListViewItem item = null;
            ListViewItem.ListViewSubItem[] subItems;
            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "Directory"),
                    new ListViewItem.ListViewSubItem(item,  dir.LastAccessTime.ToShortDateString())
                };
                item.SubItems.AddRange(subItems);
                listView2.Items.Add(item);
            }
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
                loadFilesAndDirTreeView((drive.ToString()));
                
            }
        }
        private void loadFilesAndDirTreeView(string path)
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

       
        private void darkModeChanger(bool darkModeFlag)
        {
            if (darkModeFlag == false)
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
        private void archivoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pathF2 = toolStripTextBox1.Text;
            CrearArchivo ventana = new CrearArchivo();
            ventana.ShowDialog();
        }
        private void directorioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pathF2 = toolStripTextBox1.Text;
            CrearDirectorio cd = new CrearDirectorio();
            cd.Show();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmlExport("");
        }
        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            xmlImport(@"E:\archivo.xml");
        }
        
        public void xmlExport(string subDir)
        {            
            FolderBrowserDialog carpeta = new FolderBrowserDialog();
            if (carpeta.ShowDialog() == DialogResult.OK)
            {
                guardar = carpeta.SelectedPath;//carpeta elegida para guardar                
                MessageBox.Show("Se guardara en la siguiente Direccion: "+guardar);//muestra la direccion seleccionada para guardar el XML
            }

            XmlWriter xmlArchivo = XmlWriter.Create(guardar+@"\archivo.xml");
            xmlArchivo.WriteStartDocument();
            xmlArchivo.WriteStartElement(_elemSeleccionado);//Nombre del nodo Raiz
            foreach (ListViewItem item in listView2.Items)
            {
                string temp;
                
                if (item.SubItems[1].Text == "Directory")
                    {                    
                    xmlArchivo.WriteStartElement("Directories");
                    temp = string.Format("Nombre: {0}\nTipo: {1}\nModificacion: {2}", item.SubItems[0], item.SubItems[1], item.SubItems[2]);

                    xmlArchivo.WriteStartElement("Directory");
                    xmlArchivo.WriteAttributeString("name",item.SubItems[0].Text);
                    xmlArchivo.WriteAttributeString("type", item.SubItems[1].Text);
                    xmlArchivo.WriteAttributeString("change", item.SubItems[2].Text);
                    xmlArchivo.WriteString(item.SubItems[0].Text);//nombre
                    xmlArchivo.WriteEndElement();
                    xmlArchivo.WriteEndElement();
                    //forma recursiva
                    //xmlExport(subDir);
                    //******************
                    MessageBox.Show(temp);//ventana de testeo
                }
                

                
                if (item.SubItems[1].Text == "File")
                {                                        
                    temp = string.Format("Nombre: {0}\nTipo: {1}\nModificacion: {2}\nExtension: {3}", item.SubItems[0], item.SubItems[1], item.SubItems[2], item.SubItems[3]);

                    xmlArchivo.WriteStartElement("File");
                    xmlArchivo.WriteAttributeString("name", item.SubItems[0].Text);
                    xmlArchivo.WriteAttributeString("type", item.SubItems[1].Text);
                    xmlArchivo.WriteAttributeString("change", item.SubItems[2].Text);
                    xmlArchivo.WriteAttributeString("ext", item.SubItems[3].Text);
                    xmlArchivo.WriteString(item.SubItems[0].Text + item.SubItems[3].Text);//nombre
                    
                    xmlArchivo.WriteEndElement();
                    MessageBox.Show(temp);//ventana de testeo
                }
                
            }
            xmlArchivo.Close();
        }            
        public void xmlImport(string path)
        {
            ListViewItem item = null;
            ListViewItem.ListViewSubItem[] subItems;
            XmlReader xmlReader = XmlReader.Create(path);
            while (xmlReader.Read())//leer mientras existan nuevas etiquetas
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Directory"))
                {
                    MessageBox.Show(xmlReader.GetAttribute("name")+"\n"+ xmlReader.GetAttribute("type")+"\n"+ xmlReader.GetAttribute("change"));

                    item = new ListViewItem(xmlReader.GetAttribute("type"), 1);
                    subItems = new ListViewItem.ListViewSubItem[]
                    {
                    new ListViewItem.ListViewSubItem(item, xmlReader.GetAttribute("name")),
                    new ListViewItem.ListViewSubItem(item, xmlReader.GetAttribute("type")),
                    new ListViewItem.ListViewSubItem(item, xmlReader.GetAttribute("change"))
                    };
                    item.SubItems.AddRange(subItems);
                    listView2.Items.Add(item);
                }
                else if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "File"))
                {                    
                    MessageBox.Show(xmlReader.GetAttribute("name") + "\n" + xmlReader.GetAttribute("type") + "\n" + xmlReader.GetAttribute("change")+"\n"+ xmlReader.GetAttribute("ext"));
                    item = new ListViewItem(xmlReader.GetAttribute("type"), 1);
                    subItems = new ListViewItem.ListViewSubItem[]
                    {
                    new ListViewItem.ListViewSubItem(item, xmlReader.GetAttribute("name")),
                    new ListViewItem.ListViewSubItem(item, xmlReader.GetAttribute("type")),
                    new ListViewItem.ListViewSubItem(item, xmlReader.GetAttribute("change")),
                    new ListViewItem.ListViewSubItem(item, xmlReader.GetAttribute("ext"))
                    };
                    item.SubItems.AddRange(subItems);
                    listView2.Items.Add(item);
                }
            }
        }        
    }         
 }

