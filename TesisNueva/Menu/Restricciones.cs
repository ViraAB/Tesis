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
    public partial class Restricciones : Form
    {
        SQLiteConnection conexion = new SQLiteConnection("Data Source=BD_Tesis.db");
        public string Partido1 = " ";
        public string Partido2 = " ";
        public int numero = 1;
        public string idRestricciones = " ";
        public string dataPrimPartido = " ";
        public string dataSegunPartido = " ";
        public string IdPartido1 = " ", IdPartido2 = " ";
        public string EliminarPartido1 = " ", EliminarPartido2 = " ";
        public int NR = Variables.IntValNR;

        public Restricciones()
        {
            InitializeComponent();
            CargarDatosRestricciones();

            //Ocultamos la columna de id gallo, pero se agrega para poder eliminar los registros con el id del mismo
            this.dataGridView1.Columns["Id_Restricciones"].Visible = false;
        }

        //Mostrar datos en el DataGrid
        public void CargarDatosRestricciones()
        {
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT Id_Restricciones, Partido1 AS 'Primer Partido', Partido2 AS 'Segundo Partido' FROM Restricciones;", conexion);
            DataTable tabla = new DataTable("Datos");
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            dataGridView1.Columns[1].Width = 125; //tamaño
            dataGridView1.Columns[2].Width = 124;
        }

        //Autocompleta los campos de texto "Nombre Del Partido"
        private void Restricciones_Load(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            bd.autoCompletar3(textPart1);
            bd.autoCompletar4(textPart2);
            conexion.Open();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            BorrrarMnsjErrorRestricciones();
            if (ValidarCamposRestricciones() == true)
            {
                Partido1 = textPart1.Text;
                Partido2 = textPart2.Text;

                //Borrar los registros de la base de datos
                BaseDatos bd = new BaseDatos();
                Boolean res = bd.registroRestriccion(Partido1,Partido2);

                //Comparamos el nombre del partido que se selecciono en la lista desplegable, para poder cambiarlo por el 
                //IdPartido y actualizar la matriz PeleaPartido
                SQLiteParameter parNomPartido1 = new SQLiteParameter("@nompartido", Partido1);
                SQLiteCommand com = new SQLiteCommand("SELECT Id_Partido FROM Partido WHERE NomPartido = @nompartido", conexion);
                com.Parameters.Add(parNomPartido1);
                SQLiteDataReader lector1 = com.ExecuteReader();

                while (lector1.Read())
                {
                    IdPartido1 = lector1.GetInt16(0) + " ";
                }
                lector1.Close();
                int IntIdPartido1 = Int16.Parse(IdPartido1);//Convertimos el IdPartido1 a entero (int)

                SQLiteParameter parNomPartido2 = new SQLiteParameter("@nompartido", Partido2);
                SQLiteCommand com1 = new SQLiteCommand("SELECT Id_Partido FROM Partido WHERE NomPartido = @nompartido", conexion);
                com1.Parameters.Add(parNomPartido2);
                SQLiteDataReader lector2 = com1.ExecuteReader();

                while (lector2.Read())
                {
                    IdPartido2 = lector2.GetInt16(0) + " ";
                }
                lector2.Close();
                int IntIdPartido2 = Int16.Parse(IdPartido2);//Convertimos el IdPartido2 a entero (int)

                int x = 0, y = 0;
                int inicio1 = 0, inicio2 = 0;

                inicio1 = ((IntIdPartido1 - 1) * NR); //32
                inicio2 = ((IntIdPartido2 - 1) * NR); //40

                //Actualizar matriz
                for (x = inicio1; x < (inicio1 + NR); x++)
                {
                    for (y = inicio2; y < (inicio2 + NR); y++)
                    {
                        Matrices.peleaPartido[x, y] = false; //32
                        Matrices.peleaPartido[y, x] = false; //40
                    }
                }
            }
            CargarDatosRestricciones();
        }

        private void btnSigRest_Click(object sender, EventArgs e)
        {
            textPart1.Clear();
            textPart2.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }
            dataGridView1.CurrentCell.Selected = true;
            idRestricciones = dataGridView1.Rows[e.RowIndex].Cells["Id_Restricciones"].FormattedValue.ToString();
            dataPrimPartido = dataGridView1.Rows[e.RowIndex].Cells["Primer Partido"].FormattedValue.ToString();
            dataSegunPartido = dataGridView1.Rows[e.RowIndex].Cells["Segundo Partido"].FormattedValue.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idRestricciones == " ")
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
            else
            {
                if (MessageBox.Show("Estas seguro de que quieres eliminar la restricción?",
                "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int ElimInicio1 = 0, ElimInicio2 = 0;
                    int ex = 0, ey = 0;

                    //Borrar los registros de la base de datos
                    int ValElim = int.Parse(idRestricciones.ToString());
                    BaseDatos bd = new BaseDatos();
                    Boolean res = bd.BorrarRestricciones(ValElim);
                    CargarDatosRestricciones();

                    //Comparamos el nombre del partido que se selecciono en la lista desplegable, para poder cambiarlo por el 
                    //IdPartido y actualizar la matriz PeleaPartido
                    SQLiteParameter NomPartido1 = new SQLiteParameter("@nompartido", dataPrimPartido);
                    SQLiteCommand com = new SQLiteCommand("SELECT Id_Partido FROM Partido WHERE NomPartido = @nompartido", conexion);
                    com.Parameters.Add(NomPartido1);
                    SQLiteDataReader lector3 = com.ExecuteReader();

                    while (lector3.Read())
                    {
                        EliminarPartido1 = lector3.GetInt16(0) + " ";
                    }
                    lector3.Close();
                    int IntEliminarPartido1 = Int16.Parse(EliminarPartido1);//Convertimos el IdPartido1 a entero (int)

                    SQLiteParameter NomPartido2 = new SQLiteParameter("@nompartido", dataSegunPartido);
                    SQLiteCommand com1 = new SQLiteCommand("SELECT Id_Partido FROM Partido WHERE NomPartido = @nompartido", conexion);
                    com1.Parameters.Add(NomPartido2);
                    SQLiteDataReader lector4 = com1.ExecuteReader();

                    while (lector4.Read())
                    {
                        EliminarPartido2 = lector4.GetInt16(0) + " ";
                    }
                    lector4.Close();
                    int IntEliminarPartido2 = Int16.Parse(EliminarPartido2);//Convertimos el IdPartido2 a entero (int)

                    ElimInicio1 = ((IntEliminarPartido1 - 1) * NR); //32
                    ElimInicio2 = ((IntEliminarPartido2 - 1) * NR); //40

                    for (ex = ElimInicio1; ex < (ElimInicio1 + NR); ex++)
                    {
                        for (ey = ElimInicio2; ey < (ElimInicio2 + NR); ey++)
                        {
                            Matrices.peleaPartido[ex, ey] = true; //32
                            Matrices.peleaPartido[ey, ex] = true; //40
                        }
                    }
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }
            CargarDatosRestricciones();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////V A L I D A C I O N E S///////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        //Validar Campos vacíos del Partido
        private bool ValidarCamposRestricciones()
        {
            bool ok = true;
            if (textPart1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textPart1, "Ingresar Nombre del Partido");
            }
            if (textPart2.Text == "")
            {
                ok = false;
                errorProvider2.SetError(textPart2, "Ingresar Nombre del Partido");
            }
            return ok;
        }

        //Borrar los mensajes de errores cuando ya se ingresaron los datos correctos de la parte de Editar registros
        private void BorrrarMnsjErrorRestricciones()
        {
            errorProvider1.SetError(textPart1, "");
            errorProvider2.SetError(textPart2, "");
        }
    }
}
