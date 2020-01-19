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
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbnombreusuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbcontraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.btniniciarsesion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia Pro Cond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(98, 34);
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
            // tbnombreusuario
            // 
            this.tbnombreusuario.Depth = 0;
            this.tbnombreusuario.Hint = "Usuario";
            this.tbnombreusuario.Location = new System.Drawing.Point(220, 119);
            this.tbnombreusuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbnombreusuario.Name = "tbnombreusuario";
            this.tbnombreusuario.PasswordChar = '\0';
            this.tbnombreusuario.SelectedText = "";
            this.tbnombreusuario.SelectionLength = 0;
            this.tbnombreusuario.SelectionStart = 0;
            this.tbnombreusuario.Size = new System.Drawing.Size(213, 28);
            this.tbnombreusuario.TabIndex = 15;
            this.tbnombreusuario.UseSystemPasswordChar = false;
            // 
            // tbcontraseña
            // 
            this.tbcontraseña.Depth = 0;
            this.tbcontraseña.Hint = "Contraseña";
            this.tbcontraseña.Location = new System.Drawing.Point(220, 170);
            this.tbcontraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbcontraseña.Name = "tbcontraseña";
            this.tbcontraseña.PasswordChar = '*';
            this.tbcontraseña.SelectedText = "";
            this.tbcontraseña.SelectionLength = 0;
            this.tbcontraseña.SelectionStart = 0;
            this.tbcontraseña.Size = new System.Drawing.Size(213, 28);
            this.tbcontraseña.TabIndex = 16;
            this.tbcontraseña.UseSystemPasswordChar = false;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Adobe Arabic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCheckBox1.Location = new System.Drawing.Point(211, 213);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(185, 30);
            this.materialCheckBox1.TabIndex = 19;
            this.materialCheckBox1.Text = "Mostrar Contraseña";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // btniniciarsesion
            // 
            this.btniniciarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniniciarsesion.Depth = 0;
            this.btniniciarsesion.Location = new System.Drawing.Point(331, 279);
            this.btniniciarsesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btniniciarsesion.Name = "btniniciarsesion";
            this.btniniciarsesion.Primary = true;
            this.btniniciarsesion.Size = new System.Drawing.Size(141, 27);
            this.btniniciarsesion.TabIndex = 18;
            this.btniniciarsesion.Tag = "";
            this.btniniciarsesion.Text = "Iniciar Sesión";
            this.btniniciarsesion.UseVisualStyleBackColor = true;
            this.btniniciarsesion.Click += new System.EventHandler(this.btniniciarsesion_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Menu.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(30, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 156);
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
            this.ClientSize = new System.Drawing.Size(484, 328);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.btniniciarsesion);
            this.Controls.Add(this.tbcontraseña);
            this.Controls.Add(this.tbnombreusuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(484, 328);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(484, 328);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbnombreusuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbcontraseña;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btniniciarsesion;
    }
}