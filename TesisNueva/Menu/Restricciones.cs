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
            string IdPartido1 = " ", IdPartido2 = " ";   

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

            //Actualizar matriz PeleaPartido
            Matrices mat = new Matrices();
            Boolean res = mat.ActualizarPeleaPartido(IntIdPartido1, IntIdPartido2);
        }
    }
}
