using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Menu
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();

            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btniniciarsesion_Click_1(object sender, EventArgs e)
        {
            BorrrarMnsjErrorUsuario();
            if (ValidarCamposUsuario() == true)
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
                        string x = "";
                        x = ("Bienvenido(a)\n\n" + BaseDatos.Nombre);
                        MessageBox.Show(x);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Intenta de nuevo.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Error", "Error al comprar los datos\n\nproblema en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////V A L I D A C I O N E S///////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Validar Campos vacíos del login
        private bool ValidarCamposUsuario()
        {
            bool ok = true;

            if (tbnombreusuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tbnombreusuario, "Ingresar Nombre del Usuario");
            }
            if (tbcontraseña.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tbcontraseña, "Ingresar Contraseña");
            }
            return ok;
        }

        //Borrar los mensajes de errores cuando ya se ingresaron los datos correctos de la parte de partidos
        private void BorrrarMnsjErrorUsuario()
        {
            errorProvider1.SetError(tbnombreusuario, "");
            errorProvider1.SetError(tbcontraseña, "");
        }

        //Mostrar u ocultar la contraseña
        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox1.Checked == true)
            {
                if(tbcontraseña.PasswordChar == '*')
                {
                    tbcontraseña.PasswordChar = '\0';
                }
            }
            else
            {
                tbcontraseña.PasswordChar = '*';
            }
        }
    }
}
