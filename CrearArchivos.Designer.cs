
namespace FileManagerProgIII
{
    partial class CrearArchivos
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
            this.labelDiscos = new System.Windows.Forms.Label();
            this.comboBoxDisco = new System.Windows.Forms.ComboBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNombreDelArchivo = new System.Windows.Forms.TextBox();
            this.labelNombreDelArchivo = new System.Windows.Forms.Label();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.labelExtension = new System.Windows.Forms.Label();
            this.buttonAceptarCrearArchivos = new System.Windows.Forms.Button();
            this.buttonCancelarCrearAchivos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDiscos
            // 
            this.labelDiscos.AutoSize = true;
            this.labelDiscos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelDiscos.Location = new System.Drawing.Point(33, 57);
            this.labelDiscos.Name = "labelDiscos";
            this.labelDiscos.Size = new System.Drawing.Size(61, 25);
            this.labelDiscos.TabIndex = 0;
            this.labelDiscos.Text = "Disco";
            // 
            // comboBoxDisco
            // 
            this.comboBoxDisco.FormattingEnabled = true;
            this.comboBoxDisco.Location = new System.Drawing.Point(151, 61);
            this.comboBoxDisco.Name = "comboBoxDisco";
            this.comboBoxDisco.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDisco.TabIndex = 1;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelDireccion.Location = new System.Drawing.Point(33, 104);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(93, 25);
            this.labelDireccion.TabIndex = 2;
            this.labelDireccion.Text = "Dirección";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(151, 109);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(141, 20);
            this.textBoxDireccion.TabIndex = 3;
            this.textBoxDireccion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNombreDelArchivo
            // 
            this.textBoxNombreDelArchivo.Location = new System.Drawing.Point(219, 162);
            this.textBoxNombreDelArchivo.Name = "textBoxNombreDelArchivo";
            this.textBoxNombreDelArchivo.Size = new System.Drawing.Size(141, 20);
            this.textBoxNombreDelArchivo.TabIndex = 5;
            this.textBoxNombreDelArchivo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelNombreDelArchivo
            // 
            this.labelNombreDelArchivo.AutoSize = true;
            this.labelNombreDelArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelNombreDelArchivo.Location = new System.Drawing.Point(33, 157);
            this.labelNombreDelArchivo.Name = "labelNombreDelArchivo";
            this.labelNombreDelArchivo.Size = new System.Drawing.Size(180, 25);
            this.labelNombreDelArchivo.TabIndex = 4;
            this.labelNombreDelArchivo.Text = "Nombre del archivo";
            this.labelNombreDelArchivo.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(151, 206);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(141, 20);
            this.textBoxExtension.TabIndex = 7;
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelExtension.Location = new System.Drawing.Point(33, 201);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(98, 25);
            this.labelExtension.TabIndex = 6;
            this.labelExtension.Text = "Extensión";
            // 
            // buttonAceptarCrearArchivos
            // 
            this.buttonAceptarCrearArchivos.Location = new System.Drawing.Point(72, 381);
            this.buttonAceptarCrearArchivos.Name = "buttonAceptarCrearArchivos";
            this.buttonAceptarCrearArchivos.Size = new System.Drawing.Size(92, 39);
            this.buttonAceptarCrearArchivos.TabIndex = 8;
            this.buttonAceptarCrearArchivos.Text = "Aceptar";
            this.buttonAceptarCrearArchivos.UseVisualStyleBackColor = true;
            this.buttonAceptarCrearArchivos.Click += new System.EventHandler(this.buttonAceptarCrearArchivos_Click);
            // 
            // buttonCancelarCrearAchivos
            // 
            this.buttonCancelarCrearAchivos.Location = new System.Drawing.Point(622, 381);
            this.buttonCancelarCrearAchivos.Name = "buttonCancelarCrearAchivos";
            this.buttonCancelarCrearAchivos.Size = new System.Drawing.Size(98, 39);
            this.buttonCancelarCrearAchivos.TabIndex = 9;
            this.buttonCancelarCrearAchivos.Text = "Cancelar";
            this.buttonCancelarCrearAchivos.UseVisualStyleBackColor = true;
            this.buttonCancelarCrearAchivos.Click += new System.EventHandler(this.buttonCancelarCrearAchivos_Click);
            // 
            // CrearArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelarCrearAchivos);
            this.Controls.Add(this.buttonAceptarCrearArchivos);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.labelExtension);
            this.Controls.Add(this.textBoxNombreDelArchivo);
            this.Controls.Add(this.labelNombreDelArchivo);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.comboBoxDisco);
            this.Controls.Add(this.labelDiscos);
            this.Name = "CrearArchivos";
            this.Text = "CrearArchivos";
            this.Load += new System.EventHandler(this.CrearArchivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDiscos;
        private System.Windows.Forms.ComboBox comboBoxDisco;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombreDelArchivo;
        private System.Windows.Forms.Label labelNombreDelArchivo;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.Button buttonAceptarCrearArchivos;
        private System.Windows.Forms.Button buttonCancelarCrearAchivos;
    }
}