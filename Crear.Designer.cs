
namespace FileManagerProgIII
{
    partial class Crear
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.comboBox_extension = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(12, 33);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(142, 20);
            this.textBox_nombre.TabIndex = 0;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox_nombre_TextChanged);
            // 
            // comboBox_extension
            // 
            this.comboBox_extension.FormattingEnabled = true;
            this.comboBox_extension.Items.AddRange(new object[] {
            ".txt",
            ".jpg",
            ".png",
            ".mp4",
            ".pm3",
            ".pss",
            ".exe",
            ".dll",
            ".avi",
            ".accdr",
            ".aac",
            ".aspx",
            ".bin",
            ".bat",
            ".dif",
            ".doc",
            ".docx",
            ".flv",
            ".gif",
            ".ini",
            ".mov",
            ".psd",
            ".rar",
            ".wmv",
            ".xll",
            ".zip",
            ".tmp",
            ".sys",
            ".mpeg"});
            this.comboBox_extension.Location = new System.Drawing.Point(148, 32);
            this.comboBox_extension.Name = "comboBox_extension";
            this.comboBox_extension.Size = new System.Drawing.Size(54, 21);
            this.comboBox_extension.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de Archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Extensión";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(12, 80);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(190, 20);
            this.textBox_direccion.TabIndex = 6;
            this.textBox_direccion.TextChanged += new System.EventHandler(this.textBox_direccion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dirección";
            // 
            // Crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 173);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_extension);
            this.Controls.Add(this.textBox_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Crear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Archivo";
            this.Load += new System.EventHandler(this.Crear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.ComboBox comboBox_extension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_direccion;
        public string getTextbox_direccion()
        {
            return this.textBox_direccion.Text;
        }
        public void setTextbox_direccion(string texto)
        {
            this.textBox_direccion.Text = texto;
        }


        private System.Windows.Forms.Label label3;
    }
}