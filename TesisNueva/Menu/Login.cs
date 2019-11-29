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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbnombreusuario.Text) && !string.IsNullOrEmpty(tbcontraseña.Text))
            {
                try
                {
                    //NOS VAMOS A CLASE BASEDATOS DONDE GUARDAMOS LA CADENA DE DIRECCION DE LA MISMA
                    BaseDatos bd = new BaseDatos();
                    //POSTERIORMENTE ESTAMOS DICIENDO QUE EN LA MISMA CLASE BASEDATOS NOS IREMOS AL PUBLIC
                    //INICIARSESION DONDE SE REALIZA LA VALIDACION DE USUARIO Y CONTRASENA
                    Boolean res = bd.iniciarSesion(tbnombreusuario.Text, tbcontraseña.Text);

                    if (res)
                    {
                        MessageBox.Show("Bienvenido\n\n" + BaseDatos.Nombre);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos");
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Complete los datos");
            }
        }

        private void salir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
