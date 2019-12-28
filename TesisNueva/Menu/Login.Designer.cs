namespace Menu
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.salir1 = new System.Windows.Forms.Button();
            this.btniniciarsesion = new System.Windows.Forms.Button();
            this.tbcontraseña = new System.Windows.Forms.TextBox();
            this.tbnombreusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // salir1
            // 
            this.salir1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir1.Location = new System.Drawing.Point(207, 242);
            this.salir1.Name = "salir1";
            this.salir1.Size = new System.Drawing.Size(115, 27);
            this.salir1.TabIndex = 12;
            this.salir1.Text = "Salir";
            this.salir1.UseVisualStyleBackColor = true;
            this.salir1.Click += new System.EventHandler(this.salir1_Click);
            // 
            // btniniciarsesion
            // 
            this.btniniciarsesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btniniciarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniniciarsesion.Location = new System.Drawing.Point(339, 242);
            this.btniniciarsesion.Name = "btniniciarsesion";
            this.btniniciarsesion.Size = new System.Drawing.Size(115, 27);
            this.btniniciarsesion.TabIndex = 11;
            this.btniniciarsesion.Text = "Iniciar Sesión";
            this.btniniciarsesion.UseVisualStyleBackColor = true;
            this.btniniciarsesion.Click += new System.EventHandler(this.btniniciarsesion_Click);
            // 
            // tbcontraseña
            // 
            this.tbcontraseña.Location = new System.Drawing.Point(214, 182);
            this.tbcontraseña.Name = "tbcontraseña";
            this.tbcontraseña.PasswordChar = '*';
            this.tbcontraseña.Size = new System.Drawing.Size(213, 22);
            this.tbcontraseña.TabIndex = 10;
            // 
            // tbnombreusuario
            // 
            this.tbnombreusuario.Location = new System.Drawing.Point(214, 105);
            this.tbnombreusuario.Name = "tbnombreusuario";
            this.tbnombreusuario.Size = new System.Drawing.Size(213, 22);
            this.tbnombreusuario.TabIndex = 9;
            this.tbnombreusuario.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia Pro Cond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(95, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bienvenido, por favor inicia sesión.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Menu.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(29, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(466, 281);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salir1);
            this.Controls.Add(this.btniniciarsesion);
            this.Controls.Add(this.tbcontraseña);
            this.Controls.Add(this.tbnombreusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(484, 328);
            this.MinimumSize = new System.Drawing.Size(484, 328);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir1;
        private System.Windows.Forms.Button btniniciarsesion;
        private System.Windows.Forms.TextBox tbcontraseña;
        private System.Windows.Forms.TextBox tbnombreusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}