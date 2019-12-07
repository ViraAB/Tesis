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
            this.grBoxPartidos.Controls.Add(this.btnSigPartido);
            this.grBoxPartidos.Controls.Add(this.btnGuardarNomPartido);
            this.grBoxPartidos.Controls.Add(this.textNomPartido);
            this.grBoxPartidos.Controls.Add(this.label1);
            this.grBoxPartidos.Location = new System.Drawing.Point(38, 43);
            this.grBoxPartidos.Name = "grBoxPartidos";
            this.grBoxPartidos.Size = new System.Drawing.Size(444, 167);
            this.grBoxPartidos.TabIndex = 0;
            this.grBoxPartidos.TabStop = false;
            this.grBoxPartidos.Text = "Agregar Partido";
            // 
            // btnSigPartido
            // 
            this.btnSigPartido.Location = new System.Drawing.Point(134, 118);
            this.btnSigPartido.Name = "btnSigPartido";
            this.btnSigPartido.Size = new System.Drawing.Size(143, 31);
            this.btnSigPartido.TabIndex = 16;
            this.btnSigPartido.Text = "Siguiente Partido";
            this.btnSigPartido.UseVisualStyleBackColor = true;
            this.btnSigPartido.Click += new System.EventHandler(this.btnSigPartido_Click);
            // 
            // btnGuardarNomPartido
            // 
            this.btnGuardarNomPartido.Location = new System.Drawing.Point(291, 118);
            this.btnGuardarNomPartido.Name = "btnGuardarNomPartido";
            this.btnGuardarNomPartido.Size = new System.Drawing.Size(126, 31);
            this.btnGuardarNomPartido.TabIndex = 15;
            this.btnGuardarNomPartido.Text = "Guardar Partido";
            this.btnGuardarNomPartido.UseVisualStyleBackColor = true;
            this.btnGuardarNomPartido.Click += new System.EventHandler(this.btnGuardarNomPartido_Click);
            // 
            // textNomPartido
            // 
            this.textNomPartido.Location = new System.Drawing.Point(154, 51);
            this.textNomPartido.Name = "textNomPartido";
            this.textNomPartido.Size = new System.Drawing.Size(263, 22);
            this.textNomPartido.TabIndex = 14;
            this.textNomPartido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Partido";
            // 
            // grBoxGallos
            // 
            this.grBoxGallos.Controls.Add(this.label7);
            this.grBoxGallos.Controls.Add(this.btnSigGallo);
            this.grBoxGallos.Controls.Add(this.label3);
            this.grBoxGallos.Controls.Add(this.textNomPartido2);
            this.grBoxGallos.Controls.Add(this.btnGuardarGallos);
            this.grBoxGallos.Controls.Add(this.txtNumAnillo1);
            this.grBoxGallos.Controls.Add(this.txtGallo1);
            this.grBoxGallos.Controls.Add(this.label5);
            this.grBoxGallos.Controls.Add(this.label4);
            this.grBoxGallos.Location = new System.Drawing.Point(38, 226);
            this.grBoxGallos.Name = "grBoxGallos";
            this.grBoxGallos.Size = new System.Drawing.Size(444, 246);
            this.grBoxGallos.TabIndex = 1;
            this.grBoxGallos.TabStop = false;
            this.grBoxGallos.Text = "Agregar Gallo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Peso (Gr)";
            // 
            // btnSigGallo
            // 
            this.btnSigGallo.Location = new System.Drawing.Point(134, 196);
            this.btnSigGallo.Name = "btnSigGallo";
            this.btnSigGallo.Size = new System.Drawing.Size(143, 29);
            this.btnSigGallo.TabIndex = 17;
            this.btnSigGallo.Text = "Siguiente Gallo";
            this.btnSigGallo.UseVisualStyleBackColor = true;
            this.btnSigGallo.Click += new System.EventHandler(this.btnSigGallo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre del Partido";
            // 
            // textNomPartido2
            // 
            this.textNomPartido2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textNomPartido2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textNomPartido2.Location = new System.Drawing.Point(154, 44);
            this.textNomPartido2.Name = "textNomPartido2";
            this.textNomPartido2.Size = new System.Drawing.Size(263, 22);
            this.textNomPartido2.TabIndex = 15;
            // 
            // btnGuardarGallos
            // 
            this.btnGuardarGallos.Location = new System.Drawing.Point(294, 196);
            this.btnGuardarGallos.Name = "btnGuardarGallos";
            this.btnGuardarGallos.Size = new System.Drawing.Size(121, 29);
            this.btnGuardarGallos.TabIndex = 14;
            this.btnGuardarGallos.Text = "Guardar Gallo";
            this.btnGuardarGallos.UseVisualStyleBackColor = true;
            this.btnGuardarGallos.Click += new System.EventHandler(this.btnGuardarGallos_Click);
            // 
            // txtNumAnillo1
            // 
            this.txtNumAnillo1.Location = new System.Drawing.Point(266, 133);
            this.txtNumAnillo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumAnillo1.Name = "txtNumAnillo1";
            this.txtNumAnillo1.Size = new System.Drawing.Size(151, 22);
            this.txtNumAnillo1.TabIndex = 11;
            this.txtNumAnillo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAnillo1_KeyPress);
            // 
            // txtGallo1
            // 
            this.txtGallo1.Location = new System.Drawing.Point(84, 133);
            this.txtGallo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGallo1.Name = "txtGallo1";
            this.txtGallo1.Size = new System.Drawing.Size(151, 22);
            this.txtGallo1.TabIndex = 10;
            this.txtGallo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGallo1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Número de anillo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gallo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(718, 774);
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
            this.grBoxEditRegis.Controls.Add(this.Cancelar);
            this.grBoxEditRegis.Controls.Add(this.btnGuardarActu);
            this.grBoxEditRegis.Controls.Add(this.label11);
            this.grBoxEditRegis.Controls.Add(this.label10);
            this.grBoxEditRegis.Controls.Add(this.label);
            this.grBoxEditRegis.Controls.Add(this.txtMosNA);
            this.grBoxEditRegis.Controls.Add(this.txtMosNP2);
            this.grBoxEditRegis.Controls.Add(this.txtMosPG);
            this.grBoxEditRegis.Location = new System.Drawing.Point(38, 492);
            this.grBoxEditRegis.Name = "grBoxEditRegis";
            this.grBoxEditRegis.Size = new System.Drawing.Size(444, 262);
            this.grBoxEditRegis.TabIndex = 23;
            this.grBoxEditRegis.TabStop = false;
            this.grBoxEditRegis.Text = "Editar Registros";
            // 
            // Cancelar
            // 
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.Location = new System.Drawing.Point(355, 190);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(62, 51);
            this.Cancelar.TabIndex = 30;
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btnGuardarActu
            // 
            this.btnGuardarActu.BackColor = System.Drawing.Color.Snow;
            this.btnGuardarActu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarActu.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarActu.Image")));
            this.btnGuardarActu.Location = new System.Drawing.Point(266, 190);
            this.btnGuardarActu.Name = "btnGuardarActu";
            this.btnGuardarActu.Size = new System.Drawing.Size(62, 51);
            this.btnGuardarActu.TabIndex = 29;
            this.btnGuardarActu.UseVisualStyleBackColor = false;
            this.btnGuardarActu.Click += new System.EventHandler(this.btnGuardarActu_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Número de Anillo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Peso del Gallo";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(40, 40);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(130, 17);
            this.label.TabIndex = 26;
            this.label.Text = "Nombre del Partido";
            // 
            // txtMosNA
            // 
            this.txtMosNA.Location = new System.Drawing.Point(248, 136);
            this.txtMosNA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMosNA.Name = "txtMosNA";
            this.txtMosNA.Size = new System.Drawing.Size(151, 22);
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
            this.txtMosNP2.Size = new System.Drawing.Size(151, 22);
            this.txtMosNP2.TabIndex = 25;
            // 
            // txtMosPG
            // 
            this.txtMosPG.Location = new System.Drawing.Point(248, 84);
            this.txtMosPG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMosPG.Name = "txtMosPG";
            this.txtMosPG.Size = new System.Drawing.Size(151, 22);
            this.txtMosPG.TabIndex = 24;
            this.txtMosPG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMosPG_KeyPress);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(505, 774);
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
            this.AgreRest.Location = new System.Drawing.Point(930, 774);
            this.AgreRest.Name = "AgreRest";
            this.AgreRest.Size = new System.Drawing.Size(162, 27);
            this.AgreRest.TabIndex = 30;
            this.AgreRest.Text = "Agregar Restricciones";
            this.AgreRest.UseVisualStyleBackColor = true;
            this.AgreRest.Click += new System.EventHandler(this.AgreRest_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1111, 811);
            this.Controls.Add(this.AgreRest);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.grBoxEditRegis);
            this.Controls.Add(this.dgvGallos);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.grBoxGallos);
            this.Controls.Add(this.grBoxPartidos);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
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
        private System.Windows.Forms.Button btnGuardarNomPartido;
        private System.Windows.Forms.Button btnGuardarGallos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNomPartido2;
        private System.Windows.Forms.Button btnSigPartido;
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
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button AgreRest;
    }
}