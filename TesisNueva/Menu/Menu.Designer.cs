namespace Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.peleasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDerbyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPartidosYGallosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derbysAterioresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.PowderBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peleasToolStripMenuItem,
            this.derbysAterioresToolStripMenuItem,
            this.iniciarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1348, 75);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peleasToolStripMenuItem
            // 
            this.peleasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDerbyToolStripMenuItem,
            this.registrarPartidosYGallosToolStripMenuItem});
            this.peleasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.peleasToolStripMenuItem.Image = global::Menu.Properties.Resources.gallo_fw;
            this.peleasToolStripMenuItem.Name = "peleasToolStripMenuItem";
            this.peleasToolStripMenuItem.Size = new System.Drawing.Size(172, 71);
            this.peleasToolStripMenuItem.Text = "Nuevo Derby";
            // 
            // nuevoDerbyToolStripMenuItem
            // 
            this.nuevoDerbyToolStripMenuItem.Image = global::Menu.Properties.Resources.file_new;
            this.nuevoDerbyToolStripMenuItem.Name = "nuevoDerbyToolStripMenuItem";
            this.nuevoDerbyToolStripMenuItem.Size = new System.Drawing.Size(342, 28);
            this.nuevoDerbyToolStripMenuItem.Text = "Nuevo Derby";
            this.nuevoDerbyToolStripMenuItem.Click += new System.EventHandler(this.nuevoDerbyToolStripMenuItem_Click);
            // 
            // registrarPartidosYGallosToolStripMenuItem
            // 
            this.registrarPartidosYGallosToolStripMenuItem.Image = global::Menu.Properties.Resources.app_preferences;
            this.registrarPartidosYGallosToolStripMenuItem.Name = "registrarPartidosYGallosToolStripMenuItem";
            this.registrarPartidosYGallosToolStripMenuItem.Size = new System.Drawing.Size(342, 28);
            this.registrarPartidosYGallosToolStripMenuItem.Text = "Registrar Partidos y Gallos";
            this.registrarPartidosYGallosToolStripMenuItem.Click += new System.EventHandler(this.registrarPartidosYGallosToolStripMenuItem_Click_1);
            // 
            // derbysAterioresToolStripMenuItem
            // 
            this.derbysAterioresToolStripMenuItem.Image = global::Menu.Properties.Resources.kappfinder;
            this.derbysAterioresToolStripMenuItem.Name = "derbysAterioresToolStripMenuItem";
            this.derbysAterioresToolStripMenuItem.Size = new System.Drawing.Size(202, 71);
            this.derbysAterioresToolStripMenuItem.Text = "Derbys Ateriores";
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            this.iniciarSesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem,
            this.consultorToolStripMenuItem});
            this.iniciarSesiónToolStripMenuItem.Image = global::Menu.Properties.Resources.kdmconfig;
            this.iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            this.iniciarSesiónToolStripMenuItem.Size = new System.Drawing.Size(168, 71);
            this.iniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Image = global::Menu.Properties.Resources.ball_green;
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(305, 28);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // consultorToolStripMenuItem
            // 
            this.consultorToolStripMenuItem.Image = global::Menu.Properties.Resources.ball_yellow;
            this.consultorToolStripMenuItem.Name = "consultorToolStripMenuItem";
            this.consultorToolStripMenuItem.Size = new System.Drawing.Size(305, 28);
            this.consultorToolStripMenuItem.Text = "Agregar Administrador";
            // 
            // labelUsuario
            // 
            this.labelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUsuario.Location = new System.Drawing.Point(1158, 25);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(178, 23);
            this.labelUsuario.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem derbysAterioresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoDerbyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPartidosYGallosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem peleasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultorToolStripMenuItem;
        public System.Windows.Forms.Label labelUsuario;
    }
}

