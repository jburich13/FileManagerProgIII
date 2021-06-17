
namespace FileManagerProgIII
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.goButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.Label();
            this.fileType = new System.Windows.Forms.Label();
            this.buttonCrearArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(1050, 56);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Go";
            this.goButton.UseMnemonic = false;
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 55);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(93, 58);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(951, 20);
            this.pathBox.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.IconList;
            this.listView1.Location = new System.Drawing.Point(12, 103);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1113, 462);
            this.listView1.SmallImageList = this.IconList;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "unknown-folder.png");
            this.IconList.Images.SetKeyName(1, "rar-file-format.png");
            this.IconList.Images.SetKeyName(2, "pdf-file.png");
            this.IconList.Images.SetKeyName(3, "docx-file.png");
            this.IconList.Images.SetKeyName(4, "video.png");
            this.IconList.Images.SetKeyName(5, "mp3.png");
            this.IconList.Images.SetKeyName(6, "exe-file.png");
            this.IconList.Images.SetKeyName(7, "folder.png");
            this.IconList.Images.SetKeyName(8, "image.png");
            this.IconList.Images.SetKeyName(9, "txt-file.png");
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(27, 598);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(60, 13);
            this.fileNameLabel.TabIndex = 4;
            this.fileNameLabel.Text = "File Name: ";
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(1047, 598);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.fileTypeLabel.TabIndex = 5;
            this.fileTypeLabel.Text = "File Type: ";
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(93, 598);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(13, 13);
            this.fileName.TabIndex = 6;
            this.fileName.Text = "--";
            // 
            // fileType
            // 
            this.fileType.AutoSize = true;
            this.fileType.Location = new System.Drawing.Point(1109, 598);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(13, 13);
            this.fileType.TabIndex = 7;
            this.fileType.Text = "--";
            // 
            // buttonCrearArchivo
            // 
            this.buttonCrearArchivo.Location = new System.Drawing.Point(13, 24);
            this.buttonCrearArchivo.Name = "buttonCrearArchivo";
            this.buttonCrearArchivo.Size = new System.Drawing.Size(107, 23);
            this.buttonCrearArchivo.TabIndex = 8;
            this.buttonCrearArchivo.Text = "Crear Archivo";
            this.buttonCrearArchivo.UseVisualStyleBackColor = true;
            this.buttonCrearArchivo.Click += new System.EventHandler(this.buttonCrearArchivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 620);
            this.Controls.Add(this.buttonCrearArchivo);
            this.Controls.Add(this.fileType);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.goButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label fileType;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.Button buttonCrearArchivo;
    }
}

