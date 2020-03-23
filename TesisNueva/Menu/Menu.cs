using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
            Login log = new Login();
            log.MdiParent = this;
            log.Show();
        }

        private void nuevoDerbyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BaseDatos.TipoUsuario == "Admin")
            {
                Derby datderby = new Derby();
                datderby.MdiParent = this;
                datderby.Show();
            }
            else
            {
                MessageBox.Show("Para poder acceder debe iniciar\nsesión como un usuario Administrador");
            }
        }

        private void registrarPartidosYGallosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (BaseDatos.TipoUsuario == "Admin")
            {
                Registro datregistro = new Registro();
                datregistro.MdiParent = this;
                datregistro.Show();
            }
            else
            {
                MessageBox.Show("Para poder acceder debe iniciar\nsesión como un usuario Administrador");
            }
        }

        private void restricciones()
        {
            Restricciones rest = new Restricciones();
            rest.MdiParent = this;
            rest.Show();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.MdiParent = this;
            log.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Matrices.Consultar("Gallos", "Rondas");
            Matrices.Consultar("Gallos");
        }
    }
}
