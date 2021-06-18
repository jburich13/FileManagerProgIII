
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
            this.comboBox_disco = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(72, 121);
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
            this.comboBox_extension.Location = new System.Drawing.Point(313, 120);
            this.comboBox_extension.Name = "comboBox_extension";
            this.comboBox_extension.Size = new System.Drawing.Size(54, 21);
            this.comboBox_extension.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de Archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Extensión";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(70, 223);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(142, 20);
            this.textBox_direccion.TabIndex = 6;
            this.textBox_direccion.TextChanged += new System.EventHandler(this.textBox_direccion_TextChanged);
            // 
            // comboBox_disco
            // 
            this.comboBox_disco.FormattingEnabled = true;
            this.comboBox_disco.Location = new System.Drawing.Point(313, 222);
            this.comboBox_disco.Name = "comboBox_disco";
            this.comboBox_disco.Size = new System.Drawing.Size(54, 21);
            this.comboBox_disco.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Disco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(430, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Crear un archivo en el directorio actual.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_disco);
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
        private System.Windows.Forms.ComboBox comboBox_disco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}