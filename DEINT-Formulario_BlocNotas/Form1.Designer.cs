namespace DEINT_Formulario_BlocNotas
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
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdicionCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdicionCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdicionPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdicionBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdicionFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdicionColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImg = new System.Windows.Forms.ToolStrip();
            this.menuImgNuevo = new System.Windows.Forms.ToolStripButton();
            this.menuImgAbrir = new System.Windows.Forms.ToolStripButton();
            this.menuImgGuardar = new System.Windows.Forms.ToolStripButton();
            this.menuImgCortar = new System.Windows.Forms.ToolStripButton();
            this.menuImgCopiar = new System.Windows.Forms.ToolStripButton();
            this.menuImgPegar = new System.Windows.Forms.ToolStripButton();
            this.menuImgBuscar = new System.Windows.Forms.ToolStripButton();
            this.menuImgFuente = new System.Windows.Forms.ToolStripButton();
            this.menuImgColor = new System.Windows.Forms.ToolStripButton();
            this.txtNotas = new System.Windows.Forms.RichTextBox();
            this.statusMenu = new System.Windows.Forms.StatusStrip();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tsLblFila = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLblColumna = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu.SuspendLayout();
            this.menuImg.SuspendLayout();
            this.statusMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuEdicion});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivoNuevo,
            this.menuArchivoAbrir,
            this.menuArchivoGuardar,
            this.menuArchivoSalir});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "&Archivo";
            // 
            // menuArchivoNuevo
            // 
            this.menuArchivoNuevo.Name = "menuArchivoNuevo";
            this.menuArchivoNuevo.Size = new System.Drawing.Size(116, 22);
            this.menuArchivoNuevo.Text = "&Nuevo";
            this.menuArchivoNuevo.Click += new System.EventHandler(this.menuArchivoNuevo_Click);
            // 
            // menuArchivoAbrir
            // 
            this.menuArchivoAbrir.Name = "menuArchivoAbrir";
            this.menuArchivoAbrir.Size = new System.Drawing.Size(116, 22);
            this.menuArchivoAbrir.Text = "&Abrir";
            this.menuArchivoAbrir.Click += new System.EventHandler(this.menuArchivoAbrir_Click);
            // 
            // menuArchivoGuardar
            // 
            this.menuArchivoGuardar.Name = "menuArchivoGuardar";
            this.menuArchivoGuardar.Size = new System.Drawing.Size(116, 22);
            this.menuArchivoGuardar.Text = "&Guardar";
            this.menuArchivoGuardar.Click += new System.EventHandler(this.menuArchivoGuardar_Click);
            // 
            // menuArchivoSalir
            // 
            this.menuArchivoSalir.Name = "menuArchivoSalir";
            this.menuArchivoSalir.Size = new System.Drawing.Size(116, 22);
            this.menuArchivoSalir.Text = "&Salir";
            this.menuArchivoSalir.Click += new System.EventHandler(this.menuArchivoSalir_Click);
            // 
            // menuEdicion
            // 
            this.menuEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEdicionCortar,
            this.menuEdicionCopiar,
            this.menuEdicionPegar,
            this.menuEdicionBuscar,
            this.menuEdicionFuente,
            this.menuEdicionColor});
            this.menuEdicion.Name = "menuEdicion";
            this.menuEdicion.Size = new System.Drawing.Size(58, 20);
            this.menuEdicion.Text = "&Edición";
            // 
            // menuEdicionCortar
            // 
            this.menuEdicionCortar.Name = "menuEdicionCortar";
            this.menuEdicionCortar.Size = new System.Drawing.Size(180, 22);
            this.menuEdicionCortar.Text = "&Cortar";
            this.menuEdicionCortar.Click += new System.EventHandler(this.menuEdicionCortar_Click);
            // 
            // menuEdicionCopiar
            // 
            this.menuEdicionCopiar.Name = "menuEdicionCopiar";
            this.menuEdicionCopiar.Size = new System.Drawing.Size(180, 22);
            this.menuEdicionCopiar.Text = "&Copiar";
            this.menuEdicionCopiar.Click += new System.EventHandler(this.menuEdicionCopiar_Click);
            // 
            // menuEdicionPegar
            // 
            this.menuEdicionPegar.Name = "menuEdicionPegar";
            this.menuEdicionPegar.Size = new System.Drawing.Size(180, 22);
            this.menuEdicionPegar.Text = "&Pegar";
            this.menuEdicionPegar.Click += new System.EventHandler(this.menuEdicionPegar_Click);
            // 
            // menuEdicionBuscar
            // 
            this.menuEdicionBuscar.Name = "menuEdicionBuscar";
            this.menuEdicionBuscar.Size = new System.Drawing.Size(180, 22);
            this.menuEdicionBuscar.Text = "&Buscar";
            this.menuEdicionBuscar.Click += new System.EventHandler(this.menuEdicionBuscar_Click);
            // 
            // menuEdicionFuente
            // 
            this.menuEdicionFuente.Name = "menuEdicionFuente";
            this.menuEdicionFuente.Size = new System.Drawing.Size(180, 22);
            this.menuEdicionFuente.Text = "&Fuente";
            this.menuEdicionFuente.Click += new System.EventHandler(this.menuEdicionFuente_Click);
            // 
            // menuEdicionColor
            // 
            this.menuEdicionColor.Name = "menuEdicionColor";
            this.menuEdicionColor.Size = new System.Drawing.Size(180, 22);
            this.menuEdicionColor.Text = "&Color";
            this.menuEdicionColor.Click += new System.EventHandler(this.menuEdicionColor_Click);
            // 
            // menuImg
            // 
            this.menuImg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImgNuevo,
            this.menuImgAbrir,
            this.menuImgGuardar,
            this.menuImgCortar,
            this.menuImgCopiar,
            this.menuImgPegar,
            this.menuImgBuscar,
            this.menuImgFuente,
            this.menuImgColor});
            this.menuImg.Location = new System.Drawing.Point(0, 24);
            this.menuImg.Name = "menuImg";
            this.menuImg.Size = new System.Drawing.Size(800, 25);
            this.menuImg.TabIndex = 1;
            this.menuImg.Text = "toolStrip1";
            // 
            // menuImgNuevo
            // 
            this.menuImgNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuImgNuevo.Image = global::DEINT_Formulario_BlocNotas.Properties.Resources.guardar;
            this.menuImgNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuImgNuevo.Name = "menuImgNuevo";
            this.menuImgNuevo.Size = new System.Drawing.Size(23, 22);
            this.menuImgNuevo.Text = "Nuevo";
            this.menuImgNuevo.Click += new System.EventHandler(this.menuImgNuevo_Click);
            // 
            // menuImgAbrir
            // 
            this.menuImgAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuImgAbrir.Image = global::DEINT_Formulario_BlocNotas.Properties.Resources.abrir;
            this.menuImgAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuImgAbrir.Name = "menuImgAbrir";
            this.menuImgAbrir.Size = new System.Drawing.Size(23, 22);
            this.menuImgAbrir.Text = "Abrir";
            this.menuImgAbrir.Click += new System.EventHandler(this.menuImgAbrir_Click);
            // 
            // menuImgGuardar
            // 
            this.menuImgGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuImgGuardar.Image = global::DEINT_Formulario_BlocNotas.Properties.Resources.save;
            this.menuImgGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuImgGuardar.Name = "menuImgGuardar";
            this.menuImgGuardar.Size = new System.Drawing.Size(23, 22);
            this.menuImgGuardar.Text = "Guardar";
            this.menuImgGuardar.Click += new System.EventHandler(this.menuImgGuardar_Click);
            // 
            // menuImgCortar
            // 
            this.menuImgCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuImgCortar.Image = global::DEINT_Formulario_BlocNotas.Properties.Resources.cut;
            this.menuImgCortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuImgCortar.Name = "menuImgCortar";
            this.menuImgCortar.Size = new System.Drawing.Size(23, 22);
            this.menuImgCortar.Text = "Cortar";
            this.menuImgCortar.Click += new System.EventHandler(this.menuImgCortar_Click);
            // 
            // menuImgCopiar
            // 
            this.menuImgCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuImgCopiar.Image = global::DEINT_Formulario_BlocNotas.Properties.Resources.copy;
            this.menuImgCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuImgCopiar.Name = "menuImgCopiar";
            this.menuImgCopiar.Size = new System.Drawing.Size(23, 22);
            this.menuImgCopiar.Text = "Copiar";
            this.menuImgCopiar.Click += new System.EventHandler(this.menuImgCopiar_Click);
            // 
            // menuImgPegar
            // 
            this.menuImgPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuImgPegar.Image = global::DEINT_Formulario_BlocNotas.Properties.Resources.paste;
            this.menuImgPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuImgPegar.Name = "menuImgPegar";
            this.menuImgPegar.Size = new System.Drawing.Size(23, 22);
            this.menuImgPegar.Text = "Pegar";
            this.menuImgPegar.Click += new System.EventHandler(this.menuImgPegar_Click);
            // 
            // menuImgBuscar
            // 
            this.menuImgBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuImgBuscar.Image = global::DEINT_Formulario_BlocNotas.Properties.Resources.search;
            this.menuImgBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuImgBuscar.Name = "menuImgBuscar";
            this.menuImgBuscar.Size = new System.Drawing.Size(23, 22);
            this.menuImgBuscar.Text = "Buscar";
            this.menuImgBuscar.Click += new System.EventHandler(this.menuImgBuscar_Click);
            // 
            // menuImgFuente
            // 
            this.menuImgFuente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuImgFuente.Image = global::DEINT_Formulario_BlocNotas.Properties.Resources.font;
            this.menuImgFuente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuImgFuente.Name = "menuImgFuente";
            this.menuImgFuente.Size = new System.Drawing.Size(23, 22);
            this.menuImgFuente.Text = "Cambiar fuente";
            this.menuImgFuente.Click += new System.EventHandler(this.menuImgFuente_Click);
            // 
            // menuImgColor
            // 
            this.menuImgColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuImgColor.Image = global::DEINT_Formulario_BlocNotas.Properties.Resources.color;
            this.menuImgColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuImgColor.Name = "menuImgColor";
            this.menuImgColor.Size = new System.Drawing.Size(23, 22);
            this.menuImgColor.Text = "Cambiar color";
            this.menuImgColor.Click += new System.EventHandler(this.menuImgColor_Click);
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(0, 52);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(800, 373);
            this.txtNotas.TabIndex = 2;
            this.txtNotas.Text = "";
            this.txtNotas.Visible = false;
            this.txtNotas.TextChanged += new System.EventHandler(this.txtNotas_TextChanged);
            // 
            // statusMenu
            // 
            this.statusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblFila,
            this.tsLblColumna});
            this.statusMenu.Location = new System.Drawing.Point(0, 428);
            this.statusMenu.Name = "statusMenu";
            this.statusMenu.Size = new System.Drawing.Size(800, 22);
            this.statusMenu.TabIndex = 3;
            this.statusMenu.Text = "statusStrip1";
            // 
            // tsLblFila
            // 
            this.tsLblFila.Name = "tsLblFila";
            this.tsLblFila.Size = new System.Drawing.Size(37, 17);
            this.tsLblFila.Text = "Fila: 0";
            // 
            // tsLblColumna
            // 
            this.tsLblColumna.Name = "tsLblColumna";
            this.tsLblColumna.Size = new System.Drawing.Size(68, 17);
            this.tsLblColumna.Text = "Columna: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusMenu);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.menuImg);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Bloc de notas";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.menuImg.ResumeLayout(false);
            this.menuImg.PerformLayout();
            this.statusMenu.ResumeLayout(false);
            this.statusMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem menuArchivoNuevo;
        private System.Windows.Forms.ToolStripMenuItem menuArchivoAbrir;
        private System.Windows.Forms.ToolStripMenuItem menuArchivoGuardar;
        private System.Windows.Forms.ToolStripMenuItem menuArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem menuEdicion;
        private System.Windows.Forms.ToolStripMenuItem menuEdicionCortar;
        private System.Windows.Forms.ToolStripMenuItem menuEdicionCopiar;
        private System.Windows.Forms.ToolStripMenuItem menuEdicionPegar;
        private System.Windows.Forms.ToolStripMenuItem menuEdicionBuscar;
        private System.Windows.Forms.ToolStripMenuItem menuEdicionFuente;
        private System.Windows.Forms.ToolStripMenuItem menuEdicionColor;
        private System.Windows.Forms.ToolStrip menuImg;
        private System.Windows.Forms.RichTextBox txtNotas;
        private System.Windows.Forms.StatusStrip statusMenu;
        private System.Windows.Forms.ToolStripButton menuImgNuevo;
        private System.Windows.Forms.ToolStripButton menuImgAbrir;
        private System.Windows.Forms.ToolStripButton menuImgGuardar;
        private System.Windows.Forms.ToolStripButton menuImgCortar;
        private System.Windows.Forms.ToolStripButton menuImgCopiar;
        private System.Windows.Forms.ToolStripButton menuImgPegar;
        private System.Windows.Forms.ToolStripButton menuImgBuscar;
        private System.Windows.Forms.ToolStripButton menuImgFuente;
        private System.Windows.Forms.ToolStripButton menuImgColor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripStatusLabel tsLblFila;
        private System.Windows.Forms.ToolStripStatusLabel tsLblColumna;
    }
}

