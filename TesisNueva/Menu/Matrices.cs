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
        public static DataSet ds = new DataSet();
        public static SQLiteDataAdapter da;

        //Declaracion de matrices
        public static int[,] matrizGallos = { };
        public static int[,] matrizPesos = { };
        public static bool[,] peleaPeso = { };
        public static bool[,] peleaPartido = { };
        public static bool[,] yaPelearon = { };
        public static bool[,] puedenPelear = { };
        public static int[,] rondas2 = { };

        public static void Consultar(string tabla)
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

            //obtenemos los datos de la base de datos para armar la matrizGallos
            string sql = "select Id_Partido, Peso from GallosPrueba order by Id_Partido, Peso"; //Se ordenade menor a mayor los gallos de cada partido
            da = new SQLiteDataAdapter(sql, conexion);
            cmb = new SQLiteCommand();
            cmb.CommandText = sql;
            da.Fill(ds, tabla);

            int NG = (Variables.IntValNG * Variables.IntValNP); //Multiplicamos NGD*NPD para saber el total de gallos
            int arryRows = 0;
            int i = 0, j = 0, id = 0;
            int x = 0, y = 0;
            int tolerancia = Variables.IntValNT;
            int NR = Variables.IntValNR;
            int NP = Variables.IntValNP;

            //aqui cuenta las columnas que hay en la tabla Gallos y se compara para que entre a manipular el arreglo
            if (ds.Tables["Gallos"].Rows.Count > 0)
            {
                arryRows = ds.Tables["Gallos"].Rows.Count;
                //se asigna a las matrices el numero de filas x numero de columnas de la Tabla Gallos [NG,NG]
                //Al crear una matriz booleana, esta se inicializa en falso automanticamente.
                matrizGallos = new int[arryRows, 3];
                matrizPesos = new int[arryRows, arryRows];
                peleaPeso = new bool[NG, NG];
                peleaPartido = new bool[NG, NG];
                yaPelearon = new bool[NG, NG];
                puedenPelear = new bool[NG, NG];

                //Aqui llenamos la matrizGallos
                for (i = 0; i < arryRows; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        if (j==0 || j==1)
                            matrizGallos[i, j] = int.Parse(ds.Tables["Gallos"].Rows[i][j].ToString());
                        else
                            matrizGallos[i, j] = id++;
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

                //Matriz de rondas bidimencional
                if (ds.Tables["Gallos"].Rows.Count > 0)
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
                                    rondas2[rx, ry] = numeroRonda;
                                else if (ry == 1 || ry == 2)
                                    rondas2[rx, ry] = matrizGallos[incre, ry];
                                else if (ry == 3)
                                    rondas2[rx, ry] = matrizGallos[incre, ry - 3];
                            }
                            incre = incre + Variables.IntValNG;
                        }
                        continuar = rx;
                        continuar2 = rx + NP;
                    }
                }

                //Ordenar matriz Rondas2 por pesos
                //Metodo de la burbuja
                //una matriz [RENGLON][COLUMNA]
                int ordenarRonda = 0, orx = 0, ory = 0;
                int[,] cambio = { };
                cambio = new int[1, 4];
                int a = 0, b = 0, c = 0;

                for (ordenarRonda = 0; ordenarRonda <= (NR - 1); ordenarRonda++)
                {
                    for (orx = ((NP * ordenarRonda) + NP - 1); orx >= (NP * ordenarRonda); orx--)
                    {
                        for (ory = (NP * ordenarRonda) + 1; ory <= orx; ory++)
                        {
                            if (rondas2[ory - 1, 1] > rondas2[ory, 1])
                            {
                                for (a = 0; a < 4; a++)
                                    cambio[0, a] = rondas2[ory, a];
                                for (b = 0; b < 4; b++)
                                    rondas2[ory, b] = rondas2[ory - 1, b];
                                for (c = 0; c < 4; c++)
                                    rondas2[ory - 1, c] = cambio[0, c];
                            }
                        }
                    }
                }

                //Matriz pueden pelear
                for (i = 0; i < NG; i++)
                {
                    for (j = 0; j < NG; j++)
                    {
                        if ((peleaPeso[i, j] && peleaPartido[i, j] && (!(yaPelearon[i, j]))) == true)
                            puedenPelear[i, j] = true;
                    }
                }

                int ronda = 0, gallo1 = 0, gallo2 = 0;
                i = 0;
                while ((ronda < NR) && (ronda >= 0))
                {
                    if (i < NP - 1)
                    {
                        gallo1 = rondas2[NP * ronda + i, 2];
                        gallo2 = rondas2[NP * ronda + i + 1, 2];

                        if (puedenPelear[gallo1, gallo2] == true)
                        {
                            //Actualizar matriz yaPelearon y PuedenPelear
                            int equipo1 = 0, equipo2 = 0;
                            int inicio1 = 0, inicio2 = 0;
                            int actA = 0, actB = 0;

                            equipo1 = rondas2[NP * ronda + i, 3];
                            equipo2 = rondas2[NP * ronda + i + 1, 3];
                            inicio1 = (equipo1 - 1) * (NR);
                            inicio2 = (equipo2 - 1) * (NR);

                            for (actA = inicio1; actA < (inicio1 + NR); actA++)
                            {
                                for (actB = inicio2; actB < (inicio2 + NR); actB++)
                                {
                                    yaPelearon[actA, actB] = true;
                                    yaPelearon[actB, actA] = true;
                                    puedenPelear[actA, actB] = false;
                                    puedenPelear[actB, actA] = false;
                                }
                            }
                            i = i + 2;
                        }
                        //comienza etiqueta |C|
                        else if (peleaPeso[gallo1, gallo2] == false) //No pueden pelaer por diferencia de pesos
                        {
                            if (ronda == 0 && i == 0)
                            {
                                if (peleaPartido[gallo1, gallo2] == false) //los partidos no pueden pelear
                                {
                                    MessageBox.Show("si es SI,\nEtiqueta |H|");
                                }
                                else //NO
                                {
                                    MessageBox.Show("si es NO,\nEtiqueta |G|");
                                }
                            }
                            else //NO
                            {
                                int noPartido = 0;
                                int k = 0;
                                int gallo3 = 0;
                                noPartido = rondas2[NP * ronda + i, 3]; //equipo del gallo3

                                //buscar en la sig. ronda al gallo del mismo partido q' el gallo1
                                while (noPartido != rondas2[NP * (ronda + 1) + k, 3])
                                {
                                    k = k + 1;
                                    if (noPartido == rondas2[NP * (ronda + 1) + k, 3])
                                    {
                                        gallo3 = rondas2[NP * (ronda + 1) + k, 2];
                                    }
                                }

                                if (peleaPeso[gallo3, gallo2] == true)
                                {
                                    MessageBox.Show("etiqueta |I|");
                                }
                                else //no
                                {
                                    MessageBox.Show("Etiqueta |E|");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("conflicto con los equpos\nEtiqueta |H|");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Termina ronda");
                        ronda++;
                        i = 0;
                    }
                    i = i + 2;
                } //fin while
            }
        }
    }
}
