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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.peleasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDerbyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPartidosYGallosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derbysAterioresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Goudy Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peleasToolStripMenuItem,
            this.derbysAterioresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1348, 92);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peleasToolStripMenuItem
            // 
            this.peleasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDerbyToolStripMenuItem,
            this.registrarPartidosYGallosToolStripMenuItem});
            this.peleasToolStripMenuItem.Name = "peleasToolStripMenuItem";
            this.peleasToolStripMenuItem.Size = new System.Drawing.Size(113, 88);
            this.peleasToolStripMenuItem.Text = "Nuevo Derby";
            // 
            // nuevoDerbyToolStripMenuItem
            // 
            this.nuevoDerbyToolStripMenuItem.Name = "nuevoDerbyToolStripMenuItem";
            this.nuevoDerbyToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.nuevoDerbyToolStripMenuItem.Text = "Nuevo Derby";
            this.nuevoDerbyToolStripMenuItem.Click += new System.EventHandler(this.nuevoDerbyToolStripMenuItem_Click);
            // 
            // registrarPartidosYGallosToolStripMenuItem
            // 
            this.registrarPartidosYGallosToolStripMenuItem.Name = "registrarPartidosYGallosToolStripMenuItem";
            this.registrarPartidosYGallosToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.registrarPartidosYGallosToolStripMenuItem.Text = "Registrar Partidos y Gallos";
            this.registrarPartidosYGallosToolStripMenuItem.Click += new System.EventHandler(this.registrarPartidosYGallosToolStripMenuItem_Click_1);
            // 
            // derbysAterioresToolStripMenuItem
            // 
            this.derbysAterioresToolStripMenuItem.Name = "derbysAterioresToolStripMenuItem";
            this.derbysAterioresToolStripMenuItem.Size = new System.Drawing.Size(135, 88);
            this.derbysAterioresToolStripMenuItem.Text = "Derbys Ateriores";
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Location = new System.Drawing.Point(1223, 27);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnIniciarSesion.Size = new System.Drawing.Size(113, 33);
            this.BtnIniciarSesion.TabIndex = 4;
            this.BtnIniciarSesion.Text = "Iniciar Sesión";
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peleasToolStripMenuItem;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.ToolStripMenuItem derbysAterioresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoDerbyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPartidosYGallosToolStripMenuItem;
    }
}

