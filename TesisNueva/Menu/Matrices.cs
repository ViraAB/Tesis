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
        public SQLiteDataReader dr3;
        public SQLiteConnection cn;
        public SQLiteCommand cmb;
        public SQLiteCommand cmb2;
        public DataSet ds = new DataSet();
        public DataSet dsron = new DataSet();
        public SQLiteDataAdapter da;
        public SQLiteDataAdapter da2;
        public string ValNPD = ""; //numero de partidos que tiene l derby
        public string ValNGD = ""; //numero de gallos con los que se llebara acabo el derby
        public string ValNTD = ""; //numero de la tolerancia entre gallos del derby 
        public string ValNR = ""; //numero de rondas del derby        

        private void conectar()
        {
            cn = new SQLiteConnection(cadena);
        }

        public Matrices()
        {
            conectar();
        }

        Derby gallos = new Derby();

        public Boolean Consultar(string tabla, string tablaRon)
        {
            //obtenemos el total de partidos, el número de gallos, la tolerancia y el numero de rondas 
            //con que se realizara el derby
            conexion.Open();
            cmb = new SQLiteCommand("SELECT Id_Partido FROM Partido ORDER BY Id_Partido DESC  LIMIT 1;", conexion);
            dr = cmb.ExecuteReader();
            cmb = new SQLiteCommand("SELECT NumGallos FROM Derby ORDER BY NumGallos DESC LIMIT 1;", conexion);
            dr1 = cmb.ExecuteReader();
            cmb = new SQLiteCommand("SELECT ToleranciaGr FROM Derby ORDER BY ToleranciaGr DESC LIMIT 1;", conexion);
            dr2 = cmb.ExecuteReader();
            cmb = new SQLiteCommand("SELECT NumGallos FROM Derby ORDER BY NumGallos DESC LIMIT 1;", conexion);
            dr3 = cmb.ExecuteReader();

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

            while (dr3.Read())
            {
                ValNR = dr3.GetInt16(0) + " ";
            }
            int IntValNR = Int16.Parse(ValNR);//Convertimos el ValNR a entero (int) 

            //obtenemos los datos de la base de datos para armar las matrices matrizGallos
            string sql = "select Id_Partido, Peso from Gallos order by Id_Partido, Peso"; //Se ordenade menor a mayor los gallos de cada partido
            da = new SQLiteDataAdapter(sql, cn);
            cmb = new SQLiteCommand();
            cmb.CommandText = sql;
            da.Fill(ds, tabla);

            //obtenemos los datos de la base de datos para armar la matriz Rondas
            string sqlron = "SELECT Peso AS 'Peso del Gallo (Gr)', g.Id_Gallo AS 'ID Gallo', g.Id_Partido AS 'ID Partido' FROM Gallos as g JOIN Partido as p on g.Id_Partido = p.Id_Partido ORDER by g.Id_Partido, g.Peso;";
            da2 = new SQLiteDataAdapter(sqlron, cn);
            cmb2 = new SQLiteCommand();
            cmb2.CommandText = sqlron;
            da2.Fill(dsron, tablaRon);

            //Declaracion de matrices
            int[,] matrizGallos = { };
            int[,] matrizPesos = { };
            bool[,] peleaPeso = { };
            bool[,] peleaPartido = { };
            bool[,] yaPelearon = { };
            bool[,] puedenPelear = { };
            int[,,] rondas = { };

            int NG = (IntValNG * IntValNP); //Multiplicamos NGD*NPD para saber el total de gallos
            int arryRows = 0;
            int i = 0, j = 0;
            int x = 0, y = 0;
            int tolerancia = IntValNT;
            int NR = IntValNR;
            int rx = 0, ry = 0, rz = 0;

            if (dsron.Tables["Rondas"].Rows.Count > 0)
            {
                //Llenar las rondas
                rondas = new int[IntValNG, IntValNP, 3];
                int incre = 0;
                for (rx = 0; rx < IntValNG; rx++)
                {
                    incre = rx;
                    for (ry = 0; ry < IntValNP; ry++) 
                    {
                        for (rz = 0; rz < 3; rz++)
                        {
                            rondas[rx, ry, rz] = int.Parse(dsron.Tables["Rondas"].Rows[incre][rz].ToString());
                        }
                        incre = incre + IntValNG; 
                    }                    
                }
            }

            //aqui cuenta las columnas que hay en la tabla Gallos y se compara para que entre a manipular el arreglo
            if (ds.Tables["Gallos"].Rows.Count > 0)
            {
                arryRows = ds.Tables["Gallos"].Rows.Count;
                //se asigna a las matrices el numero de filas x numero de columnas de la Tabla Gallos [NG,NG]
                //Al crear una matriz booleana, esta se inicializa en falso automanticamente.
                matrizGallos = new int[arryRows, 2];
                matrizPesos = new int[arryRows, arryRows];
                peleaPeso = new bool[NG, NG];
                peleaPartido = new bool[NG, NG];
                yaPelearon = new bool[NG, NG];
                puedenPelear = new bool[NG, NG];

                //Aqui llenamos la matrizGallos
                for (i = 0; i < arryRows; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        matrizGallos[i, j] = int.Parse(ds.Tables["Gallos"].Rows[i][j].ToString());
                    }
                }

                //Aqui llenamos las matrices matrizPesos, PeleaPeso y PeleaPartido
                for (x = 0; x <= NG - 1; x++)
                {
                    for (y = 0; y <= NG - 1; y++)
                    {
                        matrizPesos[x, y] = matrizGallos[x, 1] - matrizGallos[y, 1];
                        if (Math.Abs(matrizPesos[x, y]) < tolerancia)
                        {
                            peleaPeso[x, y] = true;
                        }
                        else peleaPeso[x, y] = false;
                        if (matrizGallos[x, 0] == matrizGallos[y, 0])
                        {
                            peleaPartido[x, y] = false;
                        }
                        else peleaPartido[x, y] = true;
                    }
                }

                ////Actualizar matriz yaPelearon y PuedenPelear
                //int equipo1 = 0, equipo2 = 0;
                //int inicio1 = 0, inicio2 = 0;
                //int t = 0, a = 0, b = 0;
                //int ronda = 0; 

                //equipo1 = rondas[ronda, t, 2]; //0,0,0  1
                //equipo2 = rondas[ronda, t + 1, 2]; //2
                //inicio1 = (equipo1 - 1) * (NR); //0
                //inicio2 = (equipo2 - 1) * (NR);//4

                //for (a=inicio1; a<(inicio1+NR); a++)
                //{
                //    for (b = inicio2; b < (inicio2 + NR); b++)
                //    {
                //        yaPelearon[a,b] = true;
                //        yaPelearon[b,a] = true;
                //        puedenPelear[a,b] = false;
                //        puedenPelear[b,a] = false;
                //    }
                //}
            }

            if (string.IsNullOrEmpty(ValNGD))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //PROBLEMA CON LA MATRIZ YA QUE VUELVE A CORRER Y ME BORRA LOS VALORES
        public Boolean ActualizarPeleaPartido(int IntIdPartido1, int IntIdPartido2)
        {
            int inicio1 = 0, inicio2 = 0;
            int x = 0, y = 0;
            int NR = 4;
            inicio1 = (IntIdPartido1 - 1) * (NR); //0
            inicio2 = (IntIdPartido2 - 1) * (NR);//4

            for (x = inicio1; x < (inicio1 + NR); x++)//12 - 16
            {
                for (y = inicio2; y < (inicio2 + NR); y++) //44 - 48
                {
                    //peleaPartido[x, y] = false;
                    //peleaPartido[y, x] = false;
                }
            }

            if (string.IsNullOrEmpty(ValNGD))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
