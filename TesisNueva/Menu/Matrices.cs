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
        public static int IntTtotalRestricciones = 0; //Numero de restricciones
    }

    static class Matrices
    {
        static SQLiteConnection conexion = new SQLiteConnection("Data Source=BD_Tesis.db");
        public static SQLiteDataReader dr;
        public static SQLiteDataReader dr1;
        public static SQLiteDataReader dr2;
        public static SQLiteDataReader dr3;
        public static SQLiteDataReader restricciones;
        public static SQLiteDataReader rest1;
        public static SQLiteDataReader rest2;
        public static SQLiteDataReader rest3;
        public static SQLiteDataReader lector2;

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
            string ValNPD = " "; //numero de partidos que tiene el derby
            string ValNGD = " "; //numero de gallos con los que se llebara acabo el derby
            string ValNTD = " "; //numero de la tolerancia entre gallos del derby
            string ValNR = " "; //numero de rondas del derby

            //Restricciones
            string totalRestricciones = " "; //Numero de restricciones
            string partido1 = " ";
            string partido2 = " ";
            string IdPartido1 = " ", IdPartido2 = " ";

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

            while (dr.Read()) {
                ValNPD = dr.GetInt16(0) + " ";
            }
            Variables.IntValNP = Int16.Parse(ValNPD);//Convertimos el ValNP a entero (int)

            while (dr1.Read()) {
                ValNGD = dr1.GetInt16(0) + " ";
            }
            Variables.IntValNG = Int16.Parse(ValNGD);//Convertimos el ValNG a entero (int)

            while (dr2.Read()) {
                ValNTD = dr2.GetInt16(0) + " ";
            }
            Variables.IntValNT = Int16.Parse(ValNTD);//Convertimos el ValNTD a entero (int)

            while (dr3.Read()) {
                ValNR = dr3.GetInt16(0) + " ";
            }
            Variables.IntValNR = Int16.Parse(ValNR);//Convertimos el ValNR a entero (int) 

            //obtenemos los datos de la base de datos para armar la matrizGallos
            string sql = "select Id_Partido, Peso from GallosPrueba order by Id_Partido, Peso"; //Se ordenade menor a mayor los gallos de cada partido
            da = new SQLiteDataAdapter(sql, conexion);
            cmb = new SQLiteCommand();
            cmb.CommandText = sql;
            da.Fill(ds, tabla);

            //DECLARACION DE VARIABLES
            int NG = (Variables.IntValNG * Variables.IntValNP); //Multiplicamos NGD*NPD para saber el total de gallos
            int tolerancia = Variables.IntValNT, NR = Variables.IntValNR, NP = Variables.IntValNP, continuar2 = Variables.IntValNP;
            int arryRows = 0;
            int i = 0, j = 0, id = 0, x = 0, y = 0, rx = 0, ry = 0, incre = 0, numeroRonda = 0, continuar = 0;
            int ordenarRonda = 0, orx = 0, ory = 0, a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, k = 0;
            int ronda = 0, gallo1 = 0, gallo2 = 0, noPartido = 0, gallo3 = 0;
            int g = 0, h = 0, actX = 0, actY = 0, iniA = 0, iniB = 0, equipoA = 0, equipoB = 0;
            int xRestri = 0;
            
            //aqui cuenta las columnas que hay en la tabla Gallos y se compara para que entre a manipular el arreglo
            if (ds.Tables["Gallos"].Rows.Count > 0)
            {
                arryRows = ds.Tables["Gallos"].Rows.Count;
                //se asigna a las matrices el numero de filas x numero de columnas de la Tabla Gallos [NG,NG]
                //Al crear una matriz booleana, esta se inicializa en FALSO automanticamente.
                matrizGallos = new int[arryRows, 3];
                matrizPesos = new int[arryRows, arryRows];
                peleaPeso = new bool[NG, NG];
                peleaPartido = new bool[NG, NG];
                yaPelearon = new bool[NG, NG];
                puedenPelear = new bool[NG, NG];
                rondas2 = new int[NG, 4];

                //Aqui llenamos la matrizGallos
                for (i = 0; i < arryRows; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        if (j == 0 || j == 1)
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
                            //Se llena la diagonal en falso, donde no se pueden enfrentar entre ellos mismos
                            peleaPartido[x, y] = false; 
                        }
                        else peleaPartido[x, y] = true;
                    }
                }

                //Se agregan a la matriz PeleaPartido las restricciones
                //Obtenermos el numero maximo de restricciones para comenzar a recorrer la tabla
                cmb = new SQLiteCommand("SELECT Id_Restricciones FROM Restricciones ORDER BY Id_Restricciones DESC LIMIT 1;", conexion);
                restricciones = cmb.ExecuteReader();

                while (restricciones.Read())
                {
                    totalRestricciones = restricciones.GetInt16(0) + " ";
                }
                Variables.IntTtotalRestricciones = Int16.Parse(totalRestricciones);//Convertimos el totalRestricciones a entero (int)

                //Recorremos la tabla RESTRICCIONES de la BD
                while (xRestri <= Variables.IntTtotalRestricciones)
                {
                    //Obtenemos el nombre del partido 1 y del 2
                    SQLiteParameter p1 = new SQLiteParameter("@xRestri1", xRestri);
                    cmb = new SQLiteCommand("SELECT Partido1 FROM Restricciones WHERE Id_Restricciones = @xRestri1;", conexion);
                    cmb.Parameters.Add(p1);
                    rest1 = cmb.ExecuteReader();

                    while (rest1.Read())
                    {
                        partido1 = rest1.GetString(0);
                    }

                    //Validamos si el partido1 contiene algun dato
                    //sino contiene revisamos el siguiente renglon, 
                    //caso contrario obtenemos el segundo partido
                    if (partido1 != " ")
                    {
                        SQLiteParameter p2 = new SQLiteParameter("@xRestri2", xRestri);
                        cmb = new SQLiteCommand("SELECT Partido2 FROM Restricciones WHERE Id_Restricciones = @xRestri2; ", conexion);
                        cmb.Parameters.Add(p2);
                        rest2 = cmb.ExecuteReader();

                        while (rest2.Read())
                        {
                            partido2 = rest2.GetString(0);
                        }

                        ////Comparamos el nombre del partido que se selecciono en la lista desplegable, para poder cambiarlo por el 
                        ////IdPartido y actualizar la matriz PeleaPartido
                        SQLiteParameter parNomPartido1 = new SQLiteParameter("@partido1", partido1);
                        SQLiteCommand com = new SQLiteCommand("SELECT Id_Partido FROM Partido WHERE NomPartido = @partido1", conexion);
                        com.Parameters.Add(parNomPartido1);
                        rest3 = com.ExecuteReader();

                        while (rest3.Read())
                        {
                            IdPartido1 = rest3.GetInt16(0) + " ";
                        }
                        rest3.Close();
                        int IntIdPartido1 = Int16.Parse(IdPartido1);//Convertimos el IdPartido1 a entero (int)

                        SQLiteParameter parNomPartido2 = new SQLiteParameter("@partido2", partido2);
                        SQLiteCommand com1 = new SQLiteCommand("SELECT Id_Partido FROM Partido WHERE NomPartido = @partido2", conexion);
                        com1.Parameters.Add(parNomPartido2);
                        lector2 = com1.ExecuteReader();

                        while (lector2.Read())
                        {
                            IdPartido2 = lector2.GetInt16(0) + " ";
                        }
                        lector2.Close();
                        int IntIdPartido2 = Int16.Parse(IdPartido2);//Convertimos el IdPartido2 a entero (int)

                        //int x = 0, y = 0;
                        int inicioRest1 = 0, inicioRest2 = 0;

                        inicioRest1 = ((IntIdPartido1 - 1) * NR); //32
                        inicioRest2 = ((IntIdPartido2 - 1) * NR); //40

                        //Actualizar matriz
                        for (x = inicioRest1; x < (inicioRest1 + NR); x++)
                        {
                            for (y = inicioRest2; y < (inicioRest2 + NR); y++)
                            {
                                Matrices.peleaPartido[x, y] = false; //32
                                Matrices.peleaPartido[y, x] = false; //40
                            }
                        }

                        xRestri++;
                        partido1 = " ";
                        partido2 = " ";
                    }
                    else
                    {
                        xRestri++;
                    }
                }

                //Matriz de rondas bidimencional
                if (ds.Tables["Gallos"].Rows.Count > 0)
                {
                    for (numeroRonda = 0; numeroRonda < Variables.IntValNR; numeroRonda++)
                    {
                        incre = numeroRonda;
                        for (rx = continuar; rx < continuar2; rx++)
                        {
                            for (ry = 0; ry < 4; ry++)
                            {
                                if (ry == 0)
                                    rondas2[rx, ry] = numeroRonda; //No.Ronda
                                else if (ry == 1 || ry == 2)
                                    rondas2[rx, ry] = matrizGallos[incre, ry]; //Pesos y id_gallo
                                else if (ry == 3)
                                    rondas2[rx, ry] = matrizGallos[incre, ry - 3]; //id_partido
                            }
                            incre = incre + Variables.IntValNG;
                        }
                        continuar = rx;
                        continuar2 = rx + NP;
                    }
                }

                //Ordenar matriz Rondas2 por pesos
                //Metodo de la burbuja (matriz [RENGLON][COLUMNA])
                int[,] cambio = { };
                cambio = new int[1, 4];

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
                //NOTA: necesita que la matriz PELEAPARTIDO ya tenga las restricciones agregadas.
                for (d = 0; d < NG; d++)
                {
                    for (e = 0; e < NG; e++)
                    {
                        if ((peleaPeso[d, e] && peleaPartido[d, e] && (!(yaPelearon[d, e]))) == true)
                            puedenPelear[d, e] = true;
                    }
                }

                while ((ronda < NR) && (ronda >= 0))
                {
                    if (f < NP - 1)
                    {
                        gallo1 = rondas2[NP * ronda + f, 2];
                        gallo2 = rondas2[NP * ronda + f + 1, 2];

                        if (puedenPelear[gallo1, gallo2] == true)
                        {
                            //Actualizar matriz yaPelearon y PuedenPelear
                            int equipo1 = 0, equipo2 = 0, inicio1 = 0, inicio2 = 0, actA = 0, actB = 0;

                            equipo1 = rondas2[NP * ronda + f, 3];
                            equipo2 = rondas2[NP * ronda + f + 1, 3];
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
                            f = f + 2;
                        }
                        //comienza etiqueta |C|
                        else if (peleaPeso[gallo1, gallo2] == false) //No pueden pelaer por diferencia de pesos
                        {
                            if (ronda == 0 && f == 0)//SI
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
                                noPartido = rondas2[NP * ronda + f, 3]; //equipo del gallo3

                                //buscar en la sig. ronda al gallo del mismo partido q' el gallo1
                                while (noPartido != rondas2[NP * (ronda + 1) + k, 3])
                                {
                                    k = k + 1;
                                    if (noPartido == rondas2[NP * (ronda + 1) + k, 3])
                                    {
                                        gallo3 = rondas2[NP * (ronda + 1) + k, 2]; //id_gallo
                                    }
                                }
                                
                                if (peleaPeso[gallo3, gallo2] == true) //aqui es TRUE
                                {
                                    //MessageBox.Show("etiqueta |I|");
                                    //Empieza etiqueta I
                                    g = rondas2[NP * (ronda + 1) + k, 1];
                                    int[,] cambio2 = { };
                                    cambio2 = new int[1, 2];

                                    for (a = 0; a < 2; a++)
                                        cambio2[0, a] = rondas2[NP * (ronda + 1) + k, a + 1];
                                    for (b = 0; b < 2; b++)
                                        rondas2[NP * (ronda + 1) + k, b + 1] = rondas2[NP * ronda + f, b + 1];
                                    for (c = 0; c < 2; c++)
                                        rondas2[NP * ronda + f, c + 1] = cambio2[0, c];

                                    for (h = f - 2; h >= 0; h = h - 2)
                                    {
                                        equipoA = rondas2[NP * ronda + h, 3]; equipoB = rondas2[NP * ronda + h + 1, 3];
                                        iniA = (equipoA - 1) * (NR); iniB = (equipoB - 1) * (NR);

                                        for (actX = iniA; actX < (iniA + NR); actX++)
                                        {
                                            for (actY = iniB; actY < (iniB + NR); actY++)
                                            {
                                                yaPelearon[actX, actY] = false;
                                                yaPelearon[actY, actX] = false;
                                                puedenPelear[actX, actY] = true;
                                                puedenPelear[actY, actX] = true;
                                            }
                                        }
                                    }

                                    //Reordenar las rondas modificadas por el peso 
                                    //Metodo de la burbuja (matriz [RENGLON][COLUMNA])
                                    //int[,] cambio = { };
                                    //cambio = new int[1, 4];
                                    int numRonda1 = 0;
                                    int count = 0;
                                    //numRonda1 = rondas2[NP * ronda + h, 0]; //1

                                    for (numRonda1 = ronda; count < 2; numRonda1++)
                                    {
                                        for (orx = ((NP * numRonda1) + NP - 1); orx >= (NP * numRonda1); orx--)
                                        {
                                            for (ory = (NP * numRonda1) + 1; ory <= orx; ory++)
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
                                        count++;
                                    }
                                    f = 0;
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
                        f = 0;
                    }
                    //f = f + 2;
                } //fin while
            }
        }
    }
}
