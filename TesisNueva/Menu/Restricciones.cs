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
        public string totalRestr = " ";
        public string dataPrimPartido = " ";
        public string dataSegunPartido = " ";
        public string IdPartido1 = " ", IdPartido2 = " ";
        public string EliminarPartido1 = " ", EliminarPartido2 = " ";
        public int NR = Variables.IntValNR;  //HACERLO DINAMICO NUMERO DE RONDAS

        public int TOL = Variables.IntValNT;
        public int NumeroPartidosDerby = Variables.IntValNP;
        public int NumeroGallosDerby = Variables.IntValNG;


        public Restricciones()
        {
            InitializeComponent();
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
            Partido1 = textPart1.Text;
            Partido2 = textPart2.Text;

            dataGridView1.Rows.Add(numero, textPart1.Text, textPart2.Text);
            numero = numero + 1;

            //Comparamos el nombre del partido que se selecciono en la lista desplegable, para poder cambiarlo por el 
            //IdPartido
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

            for (x = inicio1; x <= (inicio1 + NR); x++)
            {
                for (y = inicio2; y <= (inicio2 + NR); y++)
                {
                    Matrices.peleaPartido[x, y] = false; //32
                    Matrices.peleaPartido[y, x] = false; //40
                }
            }
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
            totalRestr = dataGridView1.Rows[e.RowIndex].Cells["TotalRestricciones"].FormattedValue.ToString();
            dataPrimPartido = dataGridView1.Rows[e.RowIndex].Cells["PrimerPartido"].FormattedValue.ToString();
            dataSegunPartido = dataGridView1.Rows[e.RowIndex].Cells["SegundoPartido"].FormattedValue.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (totalRestr == " ")
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
            else
            {
                if (MessageBox.Show("Estas seguro de que quieres eliminar el gallo?",
                "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int ElimInicio1 = 0, ElimInicio2 = 0;
                    int ex = 0, ey = 0;

                    //Comparamos el nombre del partido que se selecciono en la lista desplegable, para poder cambiarlo por el 
                    //IdPartido
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

                    for (ex = ElimInicio1; ex <= (ElimInicio1 + NR); ex++)
                    {
                        for (ey = ElimInicio2; ey <= (ElimInicio2 + NR); ey++)
                        {
                            Matrices.peleaPartido[ex, ey] = true; //32
                            Matrices.peleaPartido[ey, ex] = true; //40
                        }
                    }
                }
            }
        }
    }
}
