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
    public partial class Derby : Form
    {
        public int numgallos = ' ';
        public int indice = ' ';

        public Derby()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;

            //MaterialSkinManager m = MaterialSkinManager.Instance;
            //m.AddFormToManage(this);
            //m.Theme = MaterialSkinManager.Themes.LIGHT;
            //m.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void NumGalloList_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = NumGalloList.SelectedIndex;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (indice == 0)
            {
                numgallos = 3;
                BorrrarMnsjError();
                if (ValidarCampo() == true)
                {
                    BaseDatos bd = new BaseDatos();
                    Boolean res = bd.Derby(tbNomDerby.Text, dtpFechaDerby.Text, tbToleranciaPeso.Text, numgallos, tbNomOrganizador.Text);
                    MessageBox.Show("Datos guardados correctamente");
                    this.Close();
                }                
            }
            else if (indice == 1)
            {
                numgallos = 4;
                BorrrarMnsjError();
                if (ValidarCampo() == true)
                {
                    BaseDatos bd = new BaseDatos();
                    Boolean res = bd.Derby(tbNomDerby.Text, dtpFechaDerby.Text, tbToleranciaPeso.Text, numgallos, tbNomOrganizador.Text);
                    MessageBox.Show("Datos guardados correctamente");
                    this.Close();
                }
            }
            else if (indice == 2)
            {
                numgallos = 5;
                BorrrarMnsjError();
                if (ValidarCampo() == true)
                {
                    BaseDatos bd = new BaseDatos();
                    Boolean res = bd.Derby(tbNomDerby.Text, dtpFechaDerby.Text, tbToleranciaPeso.Text, numgallos, tbNomOrganizador.Text);
                    MessageBox.Show("Datos guardados correctamente");
                    this.Close();
                }
            }
            else if (indice == 3)
            {
                numgallos = 6;
                BorrrarMnsjError();
                if (ValidarCampo() == true)
                {
                    BaseDatos bd = new BaseDatos();
                    Boolean res = bd.Derby(tbNomDerby.Text, dtpFechaDerby.Text, tbToleranciaPeso.Text, numgallos, tbNomOrganizador.Text);
                    MessageBox.Show("Datos guardados correctamente");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error, selecciona el número de gallos correspondiente");
            }
        }

        private void tbToleranciaPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        //Validar Campos vacíos
        private bool ValidarCampo()
        {
            bool ok = true;

            if(tbNomDerby.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tbNomDerby, "Ingresar Nombre del Derby");
            }
            if (tbToleranciaPeso.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tbToleranciaPeso, "Ingresar Tolerancia del peso");
            }
            if (tbNomOrganizador.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tbNomOrganizador, "Ingresar Nombre del Organizador");
            }
            return ok;
        }

        //Borrar los mensajes de errores cuando ya se ingresaron los datos correctos
        private void BorrrarMnsjError()
        {
            errorProvider1.SetError(tbNomDerby, "");
            errorProvider1.SetError(tbToleranciaPeso, "");
            errorProvider1.SetError(tbNomOrganizador, "");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
