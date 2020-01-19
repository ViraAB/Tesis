namespace Menu
{
    partial class Derby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Derby));
            this.dtpFechaDerby = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelFechaDerby = new System.Windows.Forms.Label();
            this.labelNomDerby = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomOrganizador = new System.Windows.Forms.TextBox();
            this.tbToleranciaPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumGalloList = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.tbNomDerby = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaDerby
            // 
            this.dtpFechaDerby.Location = new System.Drawing.Point(368, 136);
            this.dtpFechaDerby.Name = "dtpFechaDerby";
            this.dtpFechaDerby.Size = new System.Drawing.Size(242, 22);
            this.dtpFechaDerby.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(520, 353);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 27);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelFechaDerby
            // 
            this.labelFechaDerby.AutoSize = true;
            this.labelFechaDerby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaDerby.Location = new System.Drawing.Point(42, 137);
            this.labelFechaDerby.Name = "labelFechaDerby";
            this.labelFechaDerby.Size = new System.Drawing.Size(147, 20);
            this.labelFechaDerby.TabIndex = 13;
            this.labelFechaDerby.Text = "Fecha del Derby";
            // 
            // labelNomDerby
            // 
            this.labelNomDerby.AutoSize = true;
            this.labelNomDerby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomDerby.Location = new System.Drawing.Point(42, 91);
            this.labelNomDerby.Name = "labelNomDerby";
            this.labelNomDerby.Size = new System.Drawing.Size(161, 20);
            this.labelNomDerby.TabIndex = 10;
            this.labelNomDerby.Text = "Nombre del Derby";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(42, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre del organizador";
            // 
            // tbNomOrganizador
            // 
            this.tbNomOrganizador.Location = new System.Drawing.Point(368, 275);
            this.tbNomOrganizador.Name = "tbNomOrganizador";
            this.tbNomOrganizador.Size = new System.Drawing.Size(242, 22);
            this.tbNomOrganizador.TabIndex = 18;
            // 
            // tbToleranciaPeso
            // 
            this.tbToleranciaPeso.Location = new System.Drawing.Point(368, 228);
            this.tbToleranciaPeso.Multiline = true;
            this.tbToleranciaPeso.Name = "tbToleranciaPeso";
            this.tbToleranciaPeso.Size = new System.Drawing.Size(242, 24);
            this.tbToleranciaPeso.TabIndex = 21;
            this.tbToleranciaPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbToleranciaPeso_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(42, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tolerancia del peso (Kg)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(42, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Seleccion el numero de gallos ";
            // 
            // NumGalloList
            // 
            this.NumGalloList.BackColor = System.Drawing.Color.White;
            this.NumGalloList.Cursor = System.Windows.Forms.Cursors.Default;
            this.NumGalloList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumGalloList.ForeColor = System.Drawing.Color.Black;
            this.NumGalloList.FormattingEnabled = true;
            this.NumGalloList.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6"});
            this.NumGalloList.Location = new System.Drawing.Point(368, 181);
            this.NumGalloList.Name = "NumGalloList";
            this.NumGalloList.Size = new System.Drawing.Size(242, 24);
            this.NumGalloList.TabIndex = 22;
            this.NumGalloList.SelectedIndexChanged += new System.EventHandler(this.NumGalloList_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(378, 353);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 27);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar Datos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Menu.Properties.Resources.gallo2_fw;
            this.pictureBox1.Location = new System.Drawing.Point(25, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinAllForm = false;
            this.skinEngine1.SkinFile = "C:\\Tesis\\Tesis\\TesisNueva\\Menu\\bin\\Debug\\Componentes Graficos Vb2\\SKIN NET 2010 W" +
    "IN 7\\SkinVS.NET\\Diamond\\DiamondBlue.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // tbNomDerby
            // 
            this.tbNomDerby.Location = new System.Drawing.Point(368, 91);
            this.tbNomDerby.Name = "tbNomDerby";
            this.tbNomDerby.Size = new System.Drawing.Size(242, 22);
            this.tbNomDerby.TabIndex = 12;
            // 
            // Derby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(622, 401);
            this.Controls.Add(this.NumGalloList);
            this.Controls.Add(this.tbToleranciaPeso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNomOrganizador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaDerby);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelFechaDerby);
            this.Controls.Add(this.tbNomDerby);
            this.Controls.Add(this.labelNomDerby);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 448);
            this.MinimumSize = new System.Drawing.Size(640, 448);
            this.Name = "Derby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva partida de Derby";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtpFechaDerby;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelFechaDerby;
        private System.Windows.Forms.Label labelNomDerby;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbNomOrganizador;
        private System.Windows.Forms.TextBox tbToleranciaPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NumGalloList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        public System.Windows.Forms.TextBox tbNomDerby;
    }
}