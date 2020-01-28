namespace Menu
{
    partial class Restricciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restricciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSigRest = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textPart2 = new System.Windows.Forms.TextBox();
            this.textPart1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TotalRestricciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerPartido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoPartido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalRestricciones,
            this.PrimerPartido,
            this.SegundoPartido});
            this.dataGridView1.Location = new System.Drawing.Point(486, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(518, 397);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(929, 437);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 26);
            this.salir.TabIndex = 1;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSigRest);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.textPart2);
            this.groupBox1.Controls.Add(this.textPart1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restricciones";
            // 
            // btnSigRest
            // 
            this.btnSigRest.BackColor = System.Drawing.Color.White;
            this.btnSigRest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSigRest.Location = new System.Drawing.Point(110, 116);
            this.btnSigRest.Name = "btnSigRest";
            this.btnSigRest.Size = new System.Drawing.Size(146, 51);
            this.btnSigRest.TabIndex = 24;
            this.btnSigRest.Text = "Nueva Restricción";
            this.btnSigRest.UseVisualStyleBackColor = false;
            this.btnSigRest.Click += new System.EventHandler(this.btnSigRest_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = global::Menu.Properties.Resources._3floppy3_unmount;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(273, 116);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 51);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // textPart2
            // 
            this.textPart2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textPart2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textPart2.Location = new System.Drawing.Point(233, 76);
            this.textPart2.Name = "textPart2";
            this.textPart2.Size = new System.Drawing.Size(170, 22);
            this.textPart2.TabIndex = 3;
            // 
            // textPart1
            // 
            this.textPart1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textPart1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textPart1.Location = new System.Drawing.Point(33, 76);
            this.textPart1.Name = "textPart1";
            this.textPart1.Size = new System.Drawing.Size(170, 22);
            this.textPart1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Partido 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Partido 1";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinAllForm = false;
            this.skinEngine1.SkinDialogs = false;
            this.skinEngine1.SkinFile = "C:\\Tesis\\Tesis\\TesisNueva\\Menu\\bin\\Debug\\Componentes Graficos Vb2\\SKIN NET 2010 W" +
    "IN 7\\SkinVS.NET\\Diamond\\DiamondBlue.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(762, 437);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 26);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar Restricción";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // TotalRestricciones
            // 
            this.TotalRestricciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.NullValue = null;
            this.TotalRestricciones.DefaultCellStyle = dataGridViewCellStyle1;
            this.TotalRestricciones.HeaderText = "Restricciones";
            this.TotalRestricciones.Name = "TotalRestricciones";
            this.TotalRestricciones.ReadOnly = true;
            // 
            // PrimerPartido
            // 
            this.PrimerPartido.HeaderText = "Primer_Partido";
            this.PrimerPartido.Name = "PrimerPartido";
            this.PrimerPartido.ReadOnly = true;
            this.PrimerPartido.Width = 120;
            // 
            // SegundoPartido
            // 
            this.SegundoPartido.HeaderText = "Segundo_Partido";
            this.SegundoPartido.Name = "SegundoPartido";
            this.SegundoPartido.ReadOnly = true;
            this.SegundoPartido.Width = 130;
            // 
            // Restricciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1029, 478);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Restricciones";
            this.Text = "Restricciones";
            this.Load += new System.EventHandler(this.Restricciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textPart2;
        private System.Windows.Forms.TextBox textPart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSigRest;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRestricciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerPartido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoPartido;
    }
}