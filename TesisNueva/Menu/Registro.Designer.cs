namespace Menu
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.grBoxPartidos = new System.Windows.Forms.GroupBox();
            this.btnSigPartido = new System.Windows.Forms.Button();
            this.btnGuardarNomPartido = new System.Windows.Forms.Button();
            this.textNomPartido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grBoxGallos = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSigGallo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textNomPartido2 = new System.Windows.Forms.TextBox();
            this.btnGuardarGallos = new System.Windows.Forms.Button();
            this.txtNumAnillo1 = new System.Windows.Forms.TextBox();
            this.txtGallo1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvGallos = new System.Windows.Forms.DataGridView();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grBoxEditRegis = new System.Windows.Forms.GroupBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.btnGuardarActu = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtMosNA = new System.Windows.Forms.TextBox();
            this.txtMosNP2 = new System.Windows.Forms.TextBox();
            this.txtMosPG = new System.Windows.Forms.TextBox();
            this.Actualizar = new System.Windows.Forms.Button();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.AgreRest = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.btnCotejar = new System.Windows.Forms.Button();
            this.grBoxPartidos.SuspendLayout();
            this.grBoxGallos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGallos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.grBoxEditRegis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxPartidos
            // 
            this.grBoxPartidos.BackColor = System.Drawing.Color.White;
            this.grBoxPartidos.Controls.Add(this.btnSigPartido);
            this.grBoxPartidos.Controls.Add(this.btnGuardarNomPartido);
            this.grBoxPartidos.Controls.Add(this.textNomPartido);
            this.grBoxPartidos.Controls.Add(this.label1);
            this.grBoxPartidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxPartidos.Location = new System.Drawing.Point(38, 43);
            this.grBoxPartidos.Name = "grBoxPartidos";
            this.grBoxPartidos.Size = new System.Drawing.Size(431, 167);
            this.grBoxPartidos.TabIndex = 0;
            this.grBoxPartidos.TabStop = false;
            this.grBoxPartidos.Text = "Agregar Partido";
            // 
            // btnSigPartido
            // 
            this.btnSigPartido.BackColor = System.Drawing.Color.White;
            this.btnSigPartido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSigPartido.Location = new System.Drawing.Point(130, 98);
            this.btnSigPartido.Name = "btnSigPartido";
            this.btnSigPartido.Size = new System.Drawing.Size(146, 51);
            this.btnSigPartido.TabIndex = 23;
            this.btnSigPartido.Text = "Siguiente Partido";
            this.btnSigPartido.UseVisualStyleBackColor = false;
            this.btnSigPartido.Click += new System.EventHandler(this.btnSigPartido_Click);
            // 
            // btnGuardarNomPartido
            // 
            this.btnGuardarNomPartido.BackColor = System.Drawing.Color.White;
            this.btnGuardarNomPartido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarNomPartido.Image = global::Menu.Properties.Resources._3floppy3_unmount;
            this.btnGuardarNomPartido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarNomPartido.Location = new System.Drawing.Point(287, 98);
            this.btnGuardarNomPartido.Name = "btnGuardarNomPartido";
            this.btnGuardarNomPartido.Size = new System.Drawing.Size(130, 51);
            this.btnGuardarNomPartido.TabIndex = 31;
            this.btnGuardarNomPartido.Text = "Guardar";
            this.btnGuardarNomPartido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarNomPartido.UseVisualStyleBackColor = false;
            this.btnGuardarNomPartido.Click += new System.EventHandler(this.btnGuardarNomPartido_Click);
            // 
            // textNomPartido
            // 
            this.textNomPartido.Location = new System.Drawing.Point(183, 51);
            this.textNomPartido.Name = "textNomPartido";
            this.textNomPartido.Size = new System.Drawing.Size(216, 24);
            this.textNomPartido.TabIndex = 14;
            this.textNomPartido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Partido";
            // 
            // grBoxGallos
            // 
            this.grBoxGallos.BackColor = System.Drawing.Color.White;
            this.grBoxGallos.Controls.Add(this.label7);
            this.grBoxGallos.Controls.Add(this.btnSigGallo);
            this.grBoxGallos.Controls.Add(this.label3);
            this.grBoxGallos.Controls.Add(this.textNomPartido2);
            this.grBoxGallos.Controls.Add(this.btnGuardarGallos);
            this.grBoxGallos.Controls.Add(this.txtNumAnillo1);
            this.grBoxGallos.Controls.Add(this.txtGallo1);
            this.grBoxGallos.Controls.Add(this.label5);
            this.grBoxGallos.Controls.Add(this.label4);
            this.grBoxGallos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxGallos.Location = new System.Drawing.Point(38, 226);
            this.grBoxGallos.Name = "grBoxGallos";
            this.grBoxGallos.Size = new System.Drawing.Size(431, 246);
            this.grBoxGallos.TabIndex = 1;
            this.grBoxGallos.TabStop = false;
            this.grBoxGallos.Text = "Agregar Gallo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Peso (Gr)";
            // 
            // btnSigGallo
            // 
            this.btnSigGallo.BackColor = System.Drawing.Color.White;
            this.btnSigGallo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSigGallo.Location = new System.Drawing.Point(130, 174);
            this.btnSigGallo.Name = "btnSigGallo";
            this.btnSigGallo.Size = new System.Drawing.Size(146, 51);
            this.btnSigGallo.TabIndex = 17;
            this.btnSigGallo.Text = "Siguiente Gallo";
            this.btnSigGallo.UseVisualStyleBackColor = false;
            this.btnSigGallo.Click += new System.EventHandler(this.btnSigGallo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre del Partido";
            // 
            // textNomPartido2
            // 
            this.textNomPartido2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textNomPartido2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textNomPartido2.Location = new System.Drawing.Point(183, 44);
            this.textNomPartido2.Name = "textNomPartido2";
            this.textNomPartido2.Size = new System.Drawing.Size(217, 24);
            this.textNomPartido2.TabIndex = 15;
            // 
            // btnGuardarGallos
            // 
            this.btnGuardarGallos.BackColor = System.Drawing.Color.White;
            this.btnGuardarGallos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarGallos.Image = global::Menu.Properties.Resources._3floppy3_unmount;
            this.btnGuardarGallos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarGallos.Location = new System.Drawing.Point(287, 174);
            this.btnGuardarGallos.Name = "btnGuardarGallos";
            this.btnGuardarGallos.Size = new System.Drawing.Size(130, 51);
            this.btnGuardarGallos.TabIndex = 14;
            this.btnGuardarGallos.Text = "Guardar";
            this.btnGuardarGallos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarGallos.UseVisualStyleBackColor = false;
            this.btnGuardarGallos.Click += new System.EventHandler(this.btnGuardarGallos_Click);
            // 
            // txtNumAnillo1
            // 
            this.txtNumAnillo1.Location = new System.Drawing.Point(266, 133);
            this.txtNumAnillo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumAnillo1.Name = "txtNumAnillo1";
            this.txtNumAnillo1.Size = new System.Drawing.Size(133, 24);
            this.txtNumAnillo1.TabIndex = 11;
            this.txtNumAnillo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAnillo1_KeyPress);
            // 
            // txtGallo1
            // 
            this.txtGallo1.Location = new System.Drawing.Point(93, 130);
            this.txtGallo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGallo1.Name = "txtGallo1";
            this.txtGallo1.Size = new System.Drawing.Size(133, 24);
            this.txtGallo1.TabIndex = 10;
            this.txtGallo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGallo1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Número de anillo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gallo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(716, 770);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 27);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar Gallo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvGallos
            // 
            this.dgvGallos.AllowUserToAddRows = false;
            this.dgvGallos.AllowUserToDeleteRows = false;
            this.dgvGallos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGallos.Location = new System.Drawing.Point(505, 43);
            this.dgvGallos.Name = "dgvGallos";
            this.dgvGallos.ReadOnly = true;
            this.dgvGallos.RowHeadersWidth = 51;
            this.dgvGallos.RowTemplate.Height = 24;
            this.dgvGallos.Size = new System.Drawing.Size(591, 711);
            this.dgvGallos.TabIndex = 2;
            this.dgvGallos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGallos_CellClick);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // grBoxEditRegis
            // 
            this.grBoxEditRegis.BackColor = System.Drawing.Color.White;
            this.grBoxEditRegis.Controls.Add(this.Cancelar);
            this.grBoxEditRegis.Controls.Add(this.btnGuardarActu);
            this.grBoxEditRegis.Controls.Add(this.label11);
            this.grBoxEditRegis.Controls.Add(this.label10);
            this.grBoxEditRegis.Controls.Add(this.label);
            this.grBoxEditRegis.Controls.Add(this.txtMosNA);
            this.grBoxEditRegis.Controls.Add(this.txtMosNP2);
            this.grBoxEditRegis.Controls.Add(this.txtMosPG);
            this.grBoxEditRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxEditRegis.Location = new System.Drawing.Point(38, 492);
            this.grBoxEditRegis.Name = "grBoxEditRegis";
            this.grBoxEditRegis.Size = new System.Drawing.Size(431, 262);
            this.grBoxEditRegis.TabIndex = 23;
            this.grBoxEditRegis.TabStop = false;
            this.grBoxEditRegis.Text = "Editar Registros";
            // 
            // Cancelar
            // 
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelar.ForeColor = System.Drawing.Color.Black;
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelar.Location = new System.Drawing.Point(282, 190);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(130, 51);
            this.Cancelar.TabIndex = 30;
            this.Cancelar.Tag = "";
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btnGuardarActu
            // 
            this.btnGuardarActu.BackColor = System.Drawing.Color.White;
            this.btnGuardarActu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarActu.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarActu.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarActu.Image")));
            this.btnGuardarActu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarActu.Location = new System.Drawing.Point(130, 190);
            this.btnGuardarActu.Name = "btnGuardarActu";
            this.btnGuardarActu.Size = new System.Drawing.Size(130, 51);
            this.btnGuardarActu.TabIndex = 29;
            this.btnGuardarActu.Text = "Guardar";
            this.btnGuardarActu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarActu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardarActu.UseVisualStyleBackColor = false;
            this.btnGuardarActu.Click += new System.EventHandler(this.btnGuardarActu_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "Número de Anillo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "Peso del Gallo (Gr)";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(40, 40);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(154, 18);
            this.label.TabIndex = 26;
            this.label.Text = "Nombre del Partido";
            // 
            // txtMosNA
            // 
            this.txtMosNA.Location = new System.Drawing.Point(248, 136);
            this.txtMosNA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMosNA.Name = "txtMosNA";
            this.txtMosNA.Size = new System.Drawing.Size(151, 24);
            this.txtMosNA.TabIndex = 23;
            this.txtMosNA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMosNA_KeyPress);
            // 
            // txtMosNP2
            // 
            this.txtMosNP2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMosNP2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMosNP2.Location = new System.Drawing.Point(248, 40);
            this.txtMosNP2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMosNP2.Name = "txtMosNP2";
            this.txtMosNP2.Size = new System.Drawing.Size(151, 24);
            this.txtMosNP2.TabIndex = 25;
            // 
            // txtMosPG
            // 
            this.txtMosPG.Location = new System.Drawing.Point(248, 84);
            this.txtMosPG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMosPG.Name = "txtMosPG";
            this.txtMosPG.Size = new System.Drawing.Size(151, 24);
            this.txtMosPG.TabIndex = 24;
            this.txtMosPG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMosPG_KeyPress);
            // 
            // Actualizar
            // 
            this.Actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Actualizar.Location = new System.Drawing.Point(505, 770);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(162, 27);
            this.Actualizar.TabIndex = 29;
            this.Actualizar.Text = "Editar Gallo";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // AgreRest
            // 
            this.AgreRest.Location = new System.Drawing.Point(934, 770);
            this.AgreRest.Name = "AgreRest";
            this.AgreRest.Size = new System.Drawing.Size(162, 27);
            this.AgreRest.TabIndex = 30;
            this.AgreRest.Text = "Agregar Restricciones";
            this.AgreRest.UseVisualStyleBackColor = true;
            this.AgreRest.Click += new System.EventHandler(this.AgreRest_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinAllForm = false;
            this.skinEngine1.SkinDialogs = false;
            this.skinEngine1.SkinFile = null;
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // btnCotejar
            // 
            this.btnCotejar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCotejar.Location = new System.Drawing.Point(744, 814);
            this.btnCotejar.Name = "btnCotejar";
            this.btnCotejar.Size = new System.Drawing.Size(106, 27);
            this.btnCotejar.TabIndex = 32;
            this.btnCotejar.Text = "Cotejar";
            this.btnCotejar.UseVisualStyleBackColor = true;
            this.btnCotejar.Click += new System.EventHandler(this.btnCotejar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 853);
            this.Controls.Add(this.btnCotejar);
            this.Controls.Add(this.AgreRest);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.grBoxEditRegis);
            this.Controls.Add(this.dgvGallos);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.grBoxGallos);
            this.Controls.Add(this.grBoxPartidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1129, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1129, 900);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Partidos y Gallos";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.grBoxPartidos.ResumeLayout(false);
            this.grBoxPartidos.PerformLayout();
            this.grBoxGallos.ResumeLayout(false);
            this.grBoxGallos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGallos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.grBoxEditRegis.ResumeLayout(false);
            this.grBoxEditRegis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxPartidos;
        private System.Windows.Forms.GroupBox grBoxGallos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNomPartido;
        private System.Windows.Forms.TextBox txtNumAnillo1;
        private System.Windows.Forms.TextBox txtGallo1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardarGallos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNomPartido2;
        private System.Windows.Forms.Button btnSigGallo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvGallos;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        public System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox grBoxEditRegis;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtMosNA;
        private System.Windows.Forms.TextBox txtMosPG;
        private System.Windows.Forms.TextBox txtMosNP2;
        private System.Windows.Forms.Button btnGuardarActu;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button AgreRest;
        private System.Windows.Forms.Button Cancelar;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button btnSigPartido;
        private System.Windows.Forms.Button btnGuardarNomPartido;
        private System.Windows.Forms.Button btnCotejar;
    }
}