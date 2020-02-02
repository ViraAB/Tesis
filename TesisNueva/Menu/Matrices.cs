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
    //Variables mas utilizadas en el programa
    static class Variables
    {
        public static int IntValNP = 0; //Numero de Partidos entero
        public static int IntValNG = 0; //Numero de Gallos entero
        public static int IntValNT = 0; //Numero de Tolerancia entero
        public static int IntValNR = 0; //Numero de Rondas entero
    }

    static class Matrices
    {
        static SQLiteConnection conexion = new SQLiteConnection("Data Source=BD_Tesis.db");
        public static SQLiteDataReader dr;
        public static SQLiteDataReader dr1;
        public static SQLiteDataReader dr2;
        public static SQLiteDataReader dr3;
        public static SQLiteCommand cmb;
        public static SQLiteCommand cmb2;
        public static DataSet ds = new DataSet();
        public static DataSet dsron = new DataSet();
        public static SQLiteDataAdapter da;
        public static SQLiteDataAdapter da2;

        //Declaracion de matrices
        public static int[,] matrizGallos = { };
        public static int[,] matrizPesos = { };
        public static bool[,] peleaPeso = { };
        public static bool[,] peleaPartido = { };
        public static bool[,] yaPelearon = { };
        public static bool[,] puedenPelear = { };
        //public static int[,,] rondas = { }; 
        public static int[,] rondas2 = { };

        public static void Consultar(string tabla, string tablaRon)
        {
            string ValNPD = ""; //numero de partidos que tiene el derby
            string ValNGD = ""; //numero de gallos con los que se llebara acabo el derby
            string ValNTD = ""; //numero de la tolerancia entre gallos del derby
            string ValNR = ""; //numero de rondas del derby

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
            Variables.IntValNP = Int16.Parse(ValNPD);//Convertimos el ValNP a entero (int)
        
            while (dr1.Read())
            {
                ValNGD = dr1.GetInt16(0) + " ";
            }
            Variables.IntValNG = Int16.Parse(ValNGD);//Convertimos el ValNG a entero (int)

            while (dr2.Read())
            {
                ValNTD = dr2.GetInt16(0) + " ";
            }
            Variables.IntValNT = Int16.Parse(ValNTD);//Convertimos el ValNTD a entero (int)

            while (dr3.Read())
            {
                ValNR = dr3.GetInt16(0) + " ";
            }
            Variables.IntValNR = Int16.Parse(ValNR);//Convertimos el ValNR a entero (int) 

            //obtenemos los datos de la base de datos para armar las matrices matrizGallos
            string sql = "select Id_Partido, Peso from Gallos order by Id_Partido, Peso"; //Se ordenade menor a mayor los gallos de cada partido
            da = new SQLiteDataAdapter(sql, conexion);
            cmb = new SQLiteCommand();
            cmb.CommandText = sql;
            da.Fill(ds, tabla);

            //obtenemos los datos de la base de datos para armar la matriz Rondas
            string sqlron = "SELECT Peso AS 'Peso del Gallo (Gr)', g.Id_Gallo AS 'ID Gallo', g.Id_Partido AS 'ID Partido' FROM Gallos as g JOIN Partido as p on g.Id_Partido = p.Id_Partido ORDER by g.Id_Partido, g.Peso;";
            da2 = new SQLiteDataAdapter(sqlron, conexion);
            cmb2 = new SQLiteCommand();
            cmb2.CommandText = sqlron;
            da2.Fill(dsron, tablaRon);

            int NG = (Variables.IntValNG * Variables.IntValNP); //Multiplicamos NGD*NPD para saber el total de gallos
            int arryRows = 0;
            int i = 0, j = 0;
            int x = 0, y = 0;
            int tolerancia = Variables.IntValNT;
            int NR = Variables.IntValNR;

            //Matriz de rondas bidimencional
            if (dsron.Tables["Rondas"].Rows.Count > 0)
            {
                rondas2 = new int[NG, 4]; //[48,(0,1,2,3)]
                int rx = 0, ry = 0;
                int incre = 0, numeroRonda = 0, continuar = 0;
                int continuar2 = Variables.IntValNP;

                for (numeroRonda = 0; numeroRonda < Variables.IntValNR; numeroRonda++)
                {
                    incre = numeroRonda;
                    for (rx = continuar; rx < continuar2; rx++)
                    {
                        for (ry = 0; ry < 4; ry++)
                        {
                            if (ry == 0)
                            {
                                rondas2[rx, ry] = numeroRonda;
                            }
                            else
                            {
                                rondas2[rx, ry] = int.Parse(dsron.Tables["Rondas"].Rows[incre][ry-1].ToString());
                            }
                        }
                        incre = incre + Variables.IntValNG;
                    }
                    continuar = rx;
                    continuar2 = rx + 12;
                }
            }

            //Matriz en tridimencional
            //if (dsron.Tables["Rondas"].Rows.Count > 0)
            //{
            //    int rx = 0, ry = 0, rz = 0;
            //    //Llenar las rondas
            //    rondas = new int[Variables.IntValNG, Variables.IntValNP, 3]; //[4,12,3]
            //    int incre = 0;
            //    for (rx = 0; rx < Variables.IntValNG; rx++) //0
            //    {
            //        incre = rx; //0
            //        for (ry = 0; ry < Variables.IntValNP; ry++) //0
            //        {
            //            for (rz = 0; rz < 3; rz++) //0
            //            { 
            //                rondas[rx, ry, rz] = int.Parse(dsron.Tables["Rondas"].Rows[incre][rz].ToString());
            //            }
            //            incre = incre + Variables.IntValNG; 
            //        }                    
            //    }
            //}

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
        }
    }
}
