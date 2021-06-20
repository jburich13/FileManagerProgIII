using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD

=======
>>>>>>> a4a6efe2e8d51892c4b9935c11bad52483879939
namespace FileManagerProgIII
{
    public partial class CrearDir : Form
    {
<<<<<<< HEAD
=======
        private string direccion = "";
>>>>>>> a4a6efe2e8d51892c4b9935c11bad52483879939
        public CrearDir()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
=======
        public CrearDir(string dir)
        {
            direccion = dir;            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//crear
        {
            
            textBox_direccionDIR.Text = direccion;
            Directory.CreateDirectory(direccion+"/"+textBox1.Text);

            





            //***********************************************
        }
>>>>>>> a4a6efe2e8d51892c4b9935c11bad52483879939

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD
=======
               

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearDir_Load(object sender, EventArgs e)
        {
            textBox_direccionDIR.Text = direccion;
        }
>>>>>>> a4a6efe2e8d51892c4b9935c11bad52483879939
    }
}
