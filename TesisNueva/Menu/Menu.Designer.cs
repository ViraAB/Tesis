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
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.PowderBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peleasToolStripMenuItem,
            this.derbysAterioresToolStripMenuItem,
            this.iniciarSesiónToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // peleasToolStripMenuItem
            // 
            this.peleasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDerbyToolStripMenuItem,
            this.registrarPartidosYGallosToolStripMenuItem});
            this.peleasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.peleasToolStripMenuItem.Image = global::Menu.Properties.Resources.gallo_fw;
            this.peleasToolStripMenuItem.Name = "peleasToolStripMenuItem";
            resources.ApplyResources(this.peleasToolStripMenuItem, "peleasToolStripMenuItem");
            // 
            // nuevoDerbyToolStripMenuItem
            // 
            this.nuevoDerbyToolStripMenuItem.Image = global::Menu.Properties.Resources.file_new;
            this.nuevoDerbyToolStripMenuItem.Name = "nuevoDerbyToolStripMenuItem";
            resources.ApplyResources(this.nuevoDerbyToolStripMenuItem, "nuevoDerbyToolStripMenuItem");
            this.nuevoDerbyToolStripMenuItem.Click += new System.EventHandler(this.nuevoDerbyToolStripMenuItem_Click);
            // 
            // registrarPartidosYGallosToolStripMenuItem
            // 
            this.registrarPartidosYGallosToolStripMenuItem.Image = global::Menu.Properties.Resources.app_preferences;
            this.registrarPartidosYGallosToolStripMenuItem.Name = "registrarPartidosYGallosToolStripMenuItem";
            resources.ApplyResources(this.registrarPartidosYGallosToolStripMenuItem, "registrarPartidosYGallosToolStripMenuItem");
            this.registrarPartidosYGallosToolStripMenuItem.Click += new System.EventHandler(this.registrarPartidosYGallosToolStripMenuItem_Click_1);
            // 
            // derbysAterioresToolStripMenuItem
            // 
            this.derbysAterioresToolStripMenuItem.Image = global::Menu.Properties.Resources.kappfinder;
            this.derbysAterioresToolStripMenuItem.Name = "derbysAterioresToolStripMenuItem";
            resources.ApplyResources(this.derbysAterioresToolStripMenuItem, "derbysAterioresToolStripMenuItem");
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            this.iniciarSesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem,
            this.consultorToolStripMenuItem});
            this.iniciarSesiónToolStripMenuItem.Image = global::Menu.Properties.Resources.kdmconfig;
            this.iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            resources.ApplyResources(this.iniciarSesiónToolStripMenuItem, "iniciarSesiónToolStripMenuItem");
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Image = global::Menu.Properties.Resources.ball_green;
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            resources.ApplyResources(this.administradorToolStripMenuItem, "administradorToolStripMenuItem");
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // consultorToolStripMenuItem
            // 
            this.consultorToolStripMenuItem.Image = global::Menu.Properties.Resources.ball_yellow;
            this.consultorToolStripMenuItem.Name = "consultorToolStripMenuItem";
            resources.ApplyResources(this.consultorToolStripMenuItem, "consultorToolStripMenuItem");
            // 
            // skinEngine1
            // 
            this.skinEngine1.ResSysMenuClose = "Cerrar";
            this.skinEngine1.ResSysMenuMax = "Maximizar";
            this.skinEngine1.ResSysMenuMin = "Minimizar";
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinAllForm = false;
            this.skinEngine1.SkinDialogs = false;
            this.skinEngine1.SkinFile = "C:\\Tesis\\Tesis\\TesisNueva\\Menu\\bin\\Debug\\Componentes Graficos Vb2\\SKIN NET 2010 W" +
    "IN 7\\SkinVS.NET\\Carlmness\\Calmness.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

