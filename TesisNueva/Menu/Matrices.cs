using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Menu
{
    class Matrices
    {
        SQLiteConnection conexion = new SQLiteConnection("Data Source=BD_Tesis.db");
        private string cadena = "Data Source=BD_Tesis.db";
        public SQLiteDataReader dr;
        public SQLiteDataReader dr1;
        public SQLiteDataReader dr2;
        public SQLiteConnection cn;
        public SQLiteCommand cmb;
        public DataSet ds = new DataSet();
        public SQLiteDataAdapter da;
        public string ValNPD = ""; //numero de partidos que tiene l derby
        public string ValNGD = ""; //numero de gallos con los que se llebara acabo el derby
        public string ValNTD = ""; //numero de la tolerancia entre gallos del derby 

        private void conectar()
        {
            cn = new SQLiteConnection(cadena);
        }

        public Matrices()
        {
            conectar();
        }

        Derby gallos = new Derby();

        public void consultar(string sql2, string tabla)
        {
            //obtenemos el total de partidos, el numero de gallos y la tolerancia con que se realizara el derby
            conexion.Open();
            cmb = new SQLiteCommand("SELECT Id_Partido FROM Partido ORDER BY Id_Partido DESC  LIMIT 1;", conexion);
            dr = cmb.ExecuteReader();
            cmb = new SQLiteCommand("SELECT NumGallos FROM Derby ORDER BY NumGallos DESC LIMIT 1;", conexion);
            dr1 = cmb.ExecuteReader();
            cmb = new SQLiteCommand("SELECT ToleranciaGr FROM Derby ORDER BY ToleranciaGr DESC LIMIT 1;", conexion);
            dr2 = cmb.ExecuteReader();

            while (dr.Read())
            {
                ValNPD = dr.GetInt16(0) + " ";
            }
            int IntValNP = Int16.Parse(ValNPD);//Convertimos el ValNP a entero (int)

            while (dr1.Read())
            {
                ValNGD = dr1.GetInt16(0) + " ";
            }
            int IntValNG = Int16.Parse(ValNGD);//Convertimos el ValNG a entero (int)

            while (dr2.Read())
            {
                ValNTD = dr2.GetInt16(0) + " ";
            }
            int IntValNT = Int16.Parse(ValNTD);//Convertimos el ValNTD a entero (int)

            int NG = (IntValNG * IntValNP); //Multiplicamos NGD*NPD para saber el total de gallos
            string sql = "select Id_Partido,Peso from Gallos order by Id_Partido, Peso"; //Se ordenade menor a mayor los gallos de cada partido
            int[,] arreglo = { };
            int[,] matrizPesos = { };
            bool[,] peleaPeso = { };
            bool[,] peleaPartido = { };
            bool[,] yaPelearon = { };
            bool[,] puedenPelear = { };
            int[,,] rondas = { };
            da = new SQLiteDataAdapter(sql, cn);
            cmb = new SQLiteCommand();
            cmb.CommandText = sql;
            da.Fill(ds, tabla);

            int arryRows = 0;
            int arryColumns = 0;
            int i = 0, j = 0;
            int x = 0, y = 0;
            int tolerancia = IntValNT;

            //aqui cuenta las columnas que hay en la tabla Gallos y se compara para que entre a manipular el arreglo
            if (ds.Tables["Gallos"].Rows.Count > 0)
            {
                //  NG = matrizPesos.GetLength(0);
                arryRows = ds.Tables["Gallos"].Rows.Count;
                //se asigna a matrizPesos el numero de filas x numero de filas de la Tabla Gallos [NG,NG]
                //Al crear una matriz booleana, esta se inicializa en falso automanticamente.
                matrizPesos = new int[arryRows, arryRows];
                peleaPeso = new bool[NG, NG];
                peleaPartido = new bool[NG, NG];
                yaPelearon = new bool[NG, NG];
                puedenPelear = new bool[NG, NG];

                //AQUI HICE UNA PRUEBA DE NUMERO DE FILAS POR NUMERO DE COLUMNAS DE LA TABLA GALLOS
                arryColumns = 2;
                arreglo = new int[arryRows, arryColumns];

                //Aqui llenamos la MatrizPesos
                for (i = 0; i < arryRows; i++)
                {
                    for (j = 0; j < arryColumns; j++)
                    {
                        arreglo[i, j] = int.Parse(ds.Tables["Gallos"].Rows[i][j].ToString());
                    }
                }

                //Aqui llenamos las matrices matrizPesos, PeleaPeso y PeleaPartido
                for (x = 0; x <= NG - 1; x++)
                {
                    for (y = 0; y <= NG - 1; y++)
                    {
                        matrizPesos[x, y] = arreglo[x, 1] - arreglo[y, 1];
                        if (Math.Abs(matrizPesos[x, y]) < tolerancia)
                        {
                            peleaPeso[x, y] = true;
                        }
                        else peleaPeso[x, y] = false;
                        if (arreglo[x, 0] == arreglo[y, 0])
                        {
                            peleaPartido[x, y] = false;
                        }
                        else peleaPartido[x, y] = true;
                    }
                }
                //aqui simplemente puse un mensaje para que me de el total de gallos o bien el total de filas
                MessageBox.Show("Total de Gallos:" + NG.ToString());
            }
        }
    }
}
