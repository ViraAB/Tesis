using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Menu
{
    public partial class Registro : Form
    {
        public string Valor1 = " ";
        public string ActuPeso = " ";
        public string ActuAnillo = " ";
        public string ActuPartido = " ";

        private string cadenaConexion = "Data Source=BD_Tesis.db; Version=3;Initial Catalog=Usuario;Intefrated Security=true;";
        SQLiteConnection conexion2;

        public Registro()
        {
            InitializeComponent();
            CargarDatos();
            grBoxEditRegis.Enabled = false;
        }        

        //Mostrar datos en el DataGrid
        public void CargarDatos()
        {
            conexion2 = new SQLiteConnection(cadenaConexion);
            conexion2.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT g.Id_Partido AS 'ID Partido', g.Id_Gallo AS 'ID Gallo', NomPartido AS 'Nombre del Partido', Peso AS 'Peso del Gallo (Gr)', Anillo AS 'Número de Anillo' FROM Gallos as g JOIN Partido as p on g.Id_Partido = p.Id_Partido ORDER by g.Id_Partido, g.Peso", conexion2);
            DataTable tabla = new DataTable("Datos");            
            adaptador.Fill(tabla);
            dgvGallos.DataSource = tabla;

            //Ocultamos la columna de id gallo, pero se agrega para poder eliminar los registros con el id del mismo
            this.dgvGallos.Columns["ID Gallo"].Visible = false;
        }      

        //Guardamos los partidos nuevos
        private void btnGuardarNomPartido_Click(object sender, EventArgs e)
        {
            BorrrarMnsjErrorPartido();
            if (ValidarCampoPartido() == true)
            {
                BaseDatos bd = new BaseDatos();
                Boolean res = bd.Registro(textNomPartido.Text);
                MessageBox.Show("Datos guardados correctamente");
                Registro_Load(sender,e);
            }
        }

        //Guardamos los gallos con el ID de sus respectivo partido
        private void btnGuardarGallos_Click(object sender, EventArgs e)
        {
            BorrrarMnsjErrorGallo();
            if(ValidarCampoGallo()== true)
            {
                BaseDatos bd = new BaseDatos();
                Boolean res = bd.registroGallo(textNomPartido2.Text, txtGallo1.Text, txtNumAnillo1.Text);
                CargarDatos();
            }            
        }

        //Autocompleta los campos de texto "Nombre Del Partido"
        private void Registro_Load(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            bd.autoCompletar(textNomPartido2);
            bd.autoCompletar2(txtMosNP2);
        }

        //Los siguientes dos metodos borrar los datos de los registros para poder ingresar otro 
        private void btnSigPartido_Click(object sender, EventArgs e)
        {
            textNomPartido.Clear();
        }

        private void btnSigGallo_Click(object sender, EventArgs e)
        {
            textNomPartido2.Clear();
            txtGallo1.Clear();
            txtNumAnillo1.Clear();
        }

        //Obtenermos el id del gallo que se quiere eliminar
        private void dgvGallos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }
            dgvGallos.CurrentCell.Selected = true;
            Valor1 = dgvGallos.Rows[e.RowIndex].Cells["ID Gallo"].FormattedValue.ToString();
            ActuPartido = dgvGallos.Rows[e.RowIndex].Cells["Nombre del Partido"].FormattedValue.ToString();
            ActuPeso = dgvGallos.Rows[e.RowIndex].Cells["Peso del Gallo (Gr)"].FormattedValue.ToString();
            ActuAnillo = dgvGallos.Rows[e.RowIndex].Cells["Número de Anillo"].FormattedValue.ToString();
        }

        //Eliminamos el gallo seleccionado de la base de datos
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Valor1 == " ")
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
            else
            {                
                if (MessageBox.Show("Estas seguro de que quieres eliminar el gallo?",
                "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int ValElim = int.Parse(Valor1.ToString());
                    BaseDatos bd = new BaseDatos();
                    Boolean res = bd.Borrar(ValElim);
                    CargarDatos();

                    BorrrarMnsjErrorEditarRegis();
                    txtMosNP2.Clear();
                    txtMosPG.Clear();
                    txtMosNA.Clear();
                    grBoxEditRegis.Enabled = false;
                }
            }            
        }

        //Para actualizar un registro muestrando los campos a actualizar en textbox
        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (Valor1 == " ")
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
            else
            {
                grBoxEditRegis.Enabled = true;
                if (txtMosNP2.Text != "")
                {
                    DialogResult res = MessageBox.Show("Tienes un registro o una actualizacion en curso." + Environment.NewLine +
                        "Primero guarde el registro actual", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtMosNP2.Text = ActuPartido.ToString(); //Nombre del partido
                    txtMosPG.Text = ActuPeso.ToString();    //Peso del gallo
                    txtMosNA.Text = ActuAnillo.ToString();  //Numero de anillo
                }
            }                     
        }

        //Boton Cancelar, deshabilita el grBoxEditRegis y borrra todos los datos que tengan los textbox
        private void Cancelar_Click(object sender, EventArgs e)
        {
            BorrrarMnsjErrorEditarRegis();
            txtMosNP2.Clear();
            txtMosPG.Clear();
            txtMosNA.Clear();
            grBoxEditRegis.Enabled = false;
        }

        //Editar el registro seleccionado
        private void btnGuardarActu_Click(object sender, EventArgs e)
        {
            BorrrarMnsjErrorEditarRegis();
            if (ValidarCampoEditarRegis() == true)
            {
                if (MessageBox.Show("Estas seguro de que quieres actualizar la informacion del gallo?", "Actualizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int ValActu = int.Parse(Valor1.ToString());
                    int PesoActu = int.Parse(txtMosPG.Text.ToString());
                    int AnilloActu = int.Parse(txtMosNA.Text.ToString());

                    BaseDatos bd = new BaseDatos();
                    Boolean res = bd.Actualizar(txtMosNP2.Text, ValActu, PesoActu, AnilloActu);
                    txtMosNP2.Clear();
                    txtMosPG.Clear();
                    txtMosNA.Clear();
                    CargarDatos();
                    grBoxEditRegis.Enabled = false;
                }
            }            
        }

        private void AgreRest_Click(object sender, EventArgs e)
        {
            //Matrices mat = new Matrices();
            //Boolean re = mat.Consultar();
            Restricciones rest = new Restricciones();
            rest.MdiParent = this.MdiParent;
            rest.Show();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////V A L I D A C I O N E S///////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Validar Campos vacíos del Partido
        private bool ValidarCampoPartido()
        {
            bool ok = true;

            if (textNomPartido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textNomPartido, "Ingresar Nombre del Partido");
            }
            return ok;
        }

        //Borrar los mensajes de errores cuando ya se ingresaron los datos correctos de la parte de partidos
        private void BorrrarMnsjErrorPartido()
        {
            errorProvider1.SetError(textNomPartido, "");
        }

        //Validar Campos vacíos del gallo
        private bool ValidarCampoGallo()
        {
            bool ok = true;

            if (textNomPartido2.Text == "")
            {
                ok = false;
                errorProvider2.SetError(textNomPartido2, "Ingresar Nombre del Partido");
            }
            if (txtGallo1.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtGallo1, "Ingresar Nombre del Gallo");
            }
            if(txtNumAnillo1.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtNumAnillo1, "Ingresar Número de Anillo");
            }
            return ok;
        }

        //Borrar los mensajes de errores cuando ya se ingresaron los datos correctos de la parte de gallos
        private void BorrrarMnsjErrorGallo()
        {
            errorProvider2.SetError(textNomPartido2, "");
            errorProvider2.SetError(txtGallo1, "");
            errorProvider2.SetError(txtNumAnillo1, "");
        }

        //Validar Campos vacíos de Editar registros
        private bool ValidarCampoEditarRegis()
        {
            bool ok = true;

            if (txtMosNP2.Text == "")
            {
                ok = false;
                errorProvider3.SetError(txtMosNP2, "Ingresar Nombre del Partido");
            }
            if (txtMosPG.Text == "")
            {
                ok = false;
                errorProvider3.SetError(txtMosPG, "Ingresar Nombre del Gallo");
            }
            if (txtMosNA.Text == "")
            {
                ok = false;
                errorProvider3.SetError(txtMosNA, "Ingresar Número de Anillo");
            }
            return ok;
        }

        //Borrar los mensajes de errores cuando ya se ingresaron los datos correctos de la parte de Editar registros
        private void BorrrarMnsjErrorEditarRegis()
        {
            errorProvider3.SetError(txtMosNP2, "");
            errorProvider3.SetError(txtMosPG, "");
            errorProvider3.SetError(txtMosNA, "");
        }

        //Validar que en peso y numero de anillo solo ingresen NUMEROS
        private void txtGallo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtNumAnillo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtMosPG_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtMosNA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
