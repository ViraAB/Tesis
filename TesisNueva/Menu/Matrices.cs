using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

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
        public static SQLiteDataReader drIdPartido;
        public static SQLiteDataReader drName;
        public static SQLiteDataReader drTablaPartido;
        public static SQLiteDataReader drDiccionarioAnillos;
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

        //Declaracion de matrices y diccionarios
        public static Dictionary<int, string> diccionarioPartidos = new Dictionary<int, string>();
        public static Dictionary<int, int> diccionarioAnillos = new Dictionary<int, int>();
        public static int[,] matrizGallos = { };
        public static int[,] matrizPesos = { };
        public static bool[,] peleaPeso = { };
        public static bool[,] peleaPartido = { };
        public static bool[,] yaPelearon = { };
        public static bool[,] puedenPelear = { };
        public static int[,] rondas2 = { };

        public static void Consultar(string tabla)
        {
            string IdPartidoDerby = " "; //id del derby
            string NomDerby = " "; //Nombre del derby
            string ValNPD = " "; //numero de partidos que tiene el derby
            string ValNGD = " "; //numero de gallos con los que se llebara acabo el derby
            string ValNTD = " "; //numero de la tolerancia entre gallos del derby
            string ValNR = " "; //numero de rondas del derby

            //Restricciones
            string totalRestricciones = " "; //Numero de restricciones
            string partido1 = " ";
            string partido2 = " ";
            string IdPartido1 = " ", IdPartido2 = " ";

            //Obtenemos el nombre del Derby
            conexion.Open();
            cmb = new SQLiteCommand("SELECT ID_Partido_Derby FROM Partido LIMIT 1;", conexion);
            drIdPartido = cmb.ExecuteReader();
            while (drIdPartido.Read())
            {
                IdPartidoDerby = drIdPartido.GetInt16(0) + " ";
            }

            SQLiteParameter p0 = new SQLiteParameter("@IdPartidoDerby", IdPartidoDerby);
            SQLiteCommand SQLcom = new SQLiteCommand("SELECT NomDerby FROM Derby WHERE ID_Derby = @IdPartidoDerby", conexion);
            SQLcom.Parameters.Add(p0);
            drName = SQLcom.ExecuteReader();
            while (drName.Read())
            {
                NomDerby = drName.GetString(0);
            }

            //Creamos el diccionario diccionarioPartidos para obtener el nombre de los partidos
            cmb = new SQLiteCommand("SELECT NomPartido FROM Partido ORDER BY Id_Partido;", conexion);
            drTablaPartido = cmb.ExecuteReader();
            int keyDiccionarioPartidos = 1;
            while (drTablaPartido.Read())
            {
                string partido = drTablaPartido.GetString(0);
                diccionarioPartidos.Add(keyDiccionarioPartidos, partido);
                keyDiccionarioPartidos++;
            }

            //Creamos el diccionario diccionarioAnillo para obtener el anillo de cada gallo
            cmb = new SQLiteCommand("SELECT Anillo FROM Gallos ORDER BY Id_Gallo;", conexion);
            drDiccionarioAnillos = cmb.ExecuteReader();
            int keyDiccionarioAnillos = 0;
            while (drDiccionarioAnillos.Read())
            {
                int anillo = drDiccionarioAnillos.GetInt16(0);
                diccionarioAnillos.Add(keyDiccionarioAnillos, anillo);
                keyDiccionarioAnillos++;
            }


            //obtenemos el total de partidos, el número de gallos, la tolerancia y el numero de rondas 
            //con que se realizara el derby
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
            int ronda = 0, gallo1 = 0, gallo2 = 0, noPartidoGallo1 = 0, noPartidoGallo2 = 0, noPartidoGallo3 = 0, gallo3 = 0, gallo4 = 0;

            int xRestri = 0, l = 0, m = 0;
            bool exit = false;

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
                conexion.Close();

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
                            incre += Variables.IntValNG;
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

                //AQUI VA WHILEEEEEE
                while ((ronda < NR) && (ronda >= 0))
                {
                    if (f < NP - 1)
                    {
                        gallo1 = rondas2[NP * ronda + f, 2];
                        gallo2 = rondas2[NP * ronda + f + 1, 2];

                        if (puedenPelear[gallo1, gallo2] == true)
                        {
                            ActualizarYapeleraonPuedenpelear(NP, ronda, NR, f);
                            f += 2;
                        }
                        //comienza etiqueta |C|
                        else if (peleaPeso[gallo1, gallo2] == false) //No pueden pelaer por diferencia de pesos
                        {
                            if (ronda == 0 && f == 0) //SI
                            {
                                if (peleaPartido[gallo1, gallo2] == false) //los partidos no pueden pelear
                                {
                                    MessageBox.Show("si es SI,\nEtiqueta |H|");
                                }
                                else
                                {
                                    MessageBox.Show("si es NO,\nEtiqueta |G|");
                                }
                            }
                            //Verifica el gallo del mismo partido que se encuentre en la sig ronda
                            //para ver si da el peso con el gallo2, si es true, los intercambia
                            else //NO
                            {
                                noPartidoGallo1 = rondas2[NP * ronda + f, 3]; //equipo del gallo1
                                noPartidoGallo2 = rondas2[NP * ronda + f + 1, 3]; //equipo del gallo2
                                k = 0;

                                //buscar en la sig. ronda al gallo del mismo partido q' el gallo1
                                while (noPartidoGallo1 != rondas2[NP * (ronda + 1) + k, 3])
                                {
                                    k += 1;
                                    if (noPartidoGallo1 == rondas2[NP * (ronda + 1) + k, 3])
                                    {
                                        gallo3 = rondas2[NP * (ronda + 1) + k, 2]; //id_gallo
                                    }
                                }
                                if (peleaPeso[gallo3, gallo2] == true) //aqui es TRUE
                                {
                                    // MessageBox.Show("etiqueta |I|");
                                    //Empieza etiqueta I
                                    //g = rondas2[NP * (ronda + 1) + k, 1];

                                    IntercambiarGallos(ronda, NP, k, a, b, c, f, l);
                                    ActualizarYapeleraonPuedenpelear2(NP, ronda, NR);
                                    ReordenarMetBurbuja(ronda, NP, cambio, ory, orx, a, b, c);
                                    f = 0;
                                }
                                else //no
                                {
                                    //MessageBox.Show("Etiqueta |E|");
                                    //Conflicto con el peleaPeso = F
                                    while (k > 0 && exit == false)
                                    {
                                        k--;
                                        noPartidoGallo3 = rondas2[NP * (ronda + 1) + k, 3];
                                        if ((noPartidoGallo2 != noPartidoGallo3))
                                        {
                                            gallo3 = rondas2[NP * (ronda + 1) + k, 2]; //id_gallo
                                            if (peleaPeso[gallo3, gallo2] == true)
                                            {
                                                if (puedenPelear[gallo3, gallo2] == true) //revisar si es true o falso
                                                {
                                                    exit = true;
                                                }
                                            }
                                        }
                                    }
                                    while (noPartidoGallo1 != noPartidoGallo3)
                                    {
                                        noPartidoGallo1 = rondas2[(NP * ronda) + l, 3];
                                        l++;
                                    }

                                    IntercambiarGallos(ronda, NP, k, a, b, c, f, l);

                                    //MessageBox.Show("Etiqueta |F|");
                                    //Actualizar yaPelearon y PuedenPelear
                                    ActualizarYapeleraonPuedenpelear2(NP, ronda, NR);
                                    ReordenarMetBurbuja(ronda, NP, cambio, ory, orx, a, b, c);
                                    f = 0;
                                }
                            }
                        }
                        else // NO
                        {
                            gallo1 = rondas2[NP * ronda + f, 2];
                            gallo2 = rondas2[NP * ronda + f + 1, 2];
                            m = f - 2;

                            int[,] cambio3 = { };
                            cambio3 = new int[1, 3];

                            // Conflicto entre los equipos (peleaPeso=No y YaPelearon=Si)
                            // MessageBox.Show("conflicto con los equpos\nEtiqueta |H|");
                            if (m >= 0) //m >= 0   //f >= 0
                            {
                                gallo3 = rondas2[NP * ronda + m, 2];
                                gallo4 = rondas2[NP * ronda + m + 1, 2];
                                if ((peleaPeso[gallo1, gallo3] == true) && (peleaPeso[gallo2, gallo4] == true))
                                {
                                    if ((puedenPelear[gallo1, gallo3] == true) && (puedenPelear[gallo2, gallo4] == true))
                                    {
                                        if (m < f)
                                        {
                                            // Actualizar ya pelearon y pueden pelear antes de hacer un cambio
                                            ActualizarYapeleraonPuedenpelear2(NP, ronda, NR);

                                            // intercambiar gallo1 y gallo4
                                            for (a = 0; a < 3; a++)
                                                cambio3[0, a] = rondas2[(NP * ronda) + f - 1, a + 1];
                                            for (b = 0; b < 3; b++)
                                                rondas2[(NP * ronda) + k - 1, b + 1] = rondas2[(NP * ronda) + f, b + 1];
                                            for (c = 0; c < 3; c++)
                                                rondas2[NP * ronda + f, c + 1] = cambio3[0, c];
                                        }
                                        else
                                        {
                                            // Actualizar ya pelearon y pueden pelear antes de hacer un cambio
                                            ActualizarYapeleraonPuedenpelear2(NP, ronda, NR);

                                            //intercambiar gallo2 y gallo3
                                            for (a = 0; a < 3; a++)
                                                cambio3[0, a] = rondas2[(NP * ronda) + f - 2, a + 1];
                                            for (b = 0; b < 3; b++)
                                                rondas2[(NP * ronda) + k - 2, b + 1] = rondas2[(NP * ronda) + f + 1, b + 1];
                                            for (c = 0; c < 3; c++)
                                                rondas2[NP * ronda + f + 1, c + 1] = cambio3[0, c];
                                        }

                                    }
                                    else // No
                                    // Buscamos atras
                                    {
                                        if (m < f)
                                        {
                                            f -= 2;
                                        }
                                        else
                                        // Buscamos adelante
                                        {
                                            MessageBox.Show("Buscamos adelante\nEtiqueta |K|");
                                        }
                                    }
                                }
                                else //NO
                                // Buscamos adelante
                                {
                                    if (m < f)
                                    {
                                        m = f + 2;
                                        if (m < NP - 1)
                                        {

                                        }
                                        else
                                        {
                                            MessageBox.Show("No hay posible cambio en la ronda\nEtiqueta |J|");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("No hay posible cambio en la ronda\nEtiqueta |J|");
                                    }
                                }
                            }
                            // Conflicto entre los equipos(peleaPeso= No y YaPelearon = Si)
                            // No me puedo ir para atras, ya que son los primeros de la ronda
                            else //NO
                            {
                                m = f + 2;
                                //MessageBox.Show("No hay posible cambio en la ronda\nEtiqueta |K|");
                                if (m < NP - 1)
                                {
                                    gallo3 = rondas2[NP * ronda + m, 2];
                                    gallo4 = rondas2[NP * ronda + m + 1, 2];

                                    if ((peleaPeso[gallo1, gallo3] == true) && (peleaPeso[gallo2, gallo4] == true))
                                    {
                                        if ((puedenPelear[gallo1, gallo3] == true) && (puedenPelear[gallo2, gallo4] == true))
                                        {
                                            if (m > f)
                                            {
                                                // Actualizar ya pelearon y pueden pelear antes de hacer un cambio
                                                ActualizarYapeleraonPuedenpelear2(NP, ronda, NR);

                                                f += 2;
                                                // intercambiar gallo2 y gallo3
                                                for (a = 0; a < 3; a++)
                                                    cambio3[0, a] = rondas2[(NP * ronda) + f - 1, a + 1];
                                                for (b = 0; b < 3; b++)
                                                    rondas2[(NP * ronda) + k - 1, b + 1] = rondas2[(NP * ronda) + f, b + 1];
                                                for (c = 0; c < 3; c++)
                                                    rondas2[NP * ronda + f, c + 1] = cambio3[0, c];

                                                gallo2 = gallo3;
                                            }
                                            else
                                            {
                                                // Actualizar ya pelearon y pueden pelear antes de hacer un cambio
                                                ActualizarYapeleraonPuedenpelear2(NP, ronda, NR);

                                                //intercambiar gallo1 y gallo4
                                                for (a = 0; a < 3; a++)
                                                    cambio3[0, a] = rondas2[(NP * ronda) + f - 2, a + 1];
                                                for (b = 0; b < 3; b++)
                                                    rondas2[(NP * ronda) + k - 2, b + 1] = rondas2[(NP * ronda) + f + 1, b + 1];
                                                for (c = 0; c < 3; c++)
                                                    rondas2[NP * ronda + f + 1, c + 1] = cambio3[0, c];

                                                gallo1 = gallo4;
                                            }

                                        }
                                        else // No
                                             // Buscamos atras
                                        {
                                            if (m < f)
                                            {
                                                f -= 2;
                                            }
                                            else
                                            // Buscamos adelante
                                            {
                                                MessageBox.Show("Buscamos adelante\nEtiqueta |K|");
                                            }
                                        }
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("No hay posible cambio, ultimos 4 gallos ");
                                }

                            }
                        }
                    }
                    else
                    {
                        ronda++;
                        //MessageBox.Show("Termina ronda: " + ronda);
                        f = 0;
                    }
                } //fin while 

            }

            String message = "Cotejo finalizado de manera exitosa\n¿Quieres descargar el archivo PDF?";
            String title = "Cotejo finalizado";
            String plantillaHTML = Properties.Resources.plantilla.ToString();
            plantillaHTML = plantillaHTML.Replace("@nomDerby", NomDerby);

            String fila = String.Empty;
            for (int cont = 0; cont < 4; cont++)
            {
                fila += "<td>";
                fila += "<table border='1' style='border-collapse: collapse; width: 100%; text-align:center;'>";
                fila += "<tr style='background-color: lightgrey;'>";

                fila += "<td style='width: 17%; height: 50px;'><strong> Color </strong></td>";
                fila += "<td style='width: 49%; height: 50px;'><strong> Partido </strong></td>";
                fila += "<td style='width: 17%; height: 50px;'><strong> Peso </strong></td>";
                fila += "<td style='width: 17%; height: 50px;'><strong> Anillo </strong></td>";

                fila += "</tr>";
                fila += "</table>";
                fila += "</td>";
            }
            plantillaHTML = plantillaHTML.Replace("@FILA", fila);
            
            String fila2 = String.Empty;
            int showInfo = 0;
            int color = 0;

            for (int contador = 1; contador < NP + 1; contador++)
            {
                if (color == 0)
                    color++;
                else
                    color = 0;
                
                fila2 += "<tr>";
                for (showInfo = showInfo; showInfo < (NR * NP); showInfo += NP)
                {
                    int numPartido = rondas2[showInfo, 3];
                    string nomPartido = diccionarioPartidos[numPartido].ToString();

                    int numGallo = rondas2[showInfo, 2];
                    int numAnillo = diccionarioAnillos[numGallo];

                    fila2 += "<td>";
                    fila2 += "<table border='1' style='border-collapse: collapse; width: 100%; text-align:center'>";
                    fila2 += "<tr>";

                    fila2 += "<td style='font-size: 14px; width: 17%; height: 50px;'>"
                        + (color == 0 ? "Rojo" : "Verde") + "</td>";
                    fila2 += "<td style='font-size: 14px; width: 49%; height: 50px;'>"
                        + nomPartido + "</td>";
                    fila2 += "<td style='font-size: 14px; width: 17%; height: 50px;'>"
                        + rondas2[showInfo, 1] + "</td>";
                    fila2 += "<td style='font-size: 14px; width: 17%; height: 50px;'>"
                        + (numAnillo) + " </td>";

                    fila2 += "</tr>";
                    fila2 += "</table>";
                    fila2 += "</td>";
                }
                showInfo = contador;
                fila2 += "</tr>";
            }
            plantillaHTML = plantillaHTML.Replace("@CONTENIDO", fila2);

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                SaveFileDialog guardarCotejo = new SaveFileDialog();
                guardarCotejo.FileName = NomDerby + DateTime.Now.ToString("dd-MM-yyy") + ".pdf";
                guardarCotejo.ShowDialog();

                using(FileStream stream = new FileStream(guardarCotejo.FileName, FileMode.Create))
                {
                    
                    Document pdfCotejo = new Document(PageSize.A4.Rotate(), 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfCotejo, stream);

                    pdfCotejo.Open();
                    using (StringReader sr = new StringReader(plantillaHTML))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfCotejo, sr);
                    }
                    pdfCotejo.Close();
                    stream.Close();
                }
                

            }
        }

        // FUNCIONES
        public static void ReordenarMetBurbuja(int ronda, int NP, int[,] cambio, int ory, int orx, int a, int b, int c)
        {
            //Reordenar las rondas modificadas por el peso 
            //Metodo de la burbuja (matriz [RENGLON][COLUMNA])
            int numRonda1, count = 0;

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
        }

        public static void ActualizarYapeleraonPuedenpelear(int NP, int ronda, int NR, int f)
        {
            //Actualizar matriz yaPelearon y PuedenPelear
            // yaPelearon = true | puedenPelear = false
            int equipo1, equipo2, inicio1, inicio2, actA, actB;

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
        }

        public static void ActualizarYapeleraonPuedenpelear2(int NP, int ronda, int NR)
        {
            //Actualizar matriz yaPelearon y PuedenPelear
            // yaPelearon = false | puedenPelear = true
            int h, actX, actY, iniA, iniB, equipoA, equipoB;

            for (h = 10; h >= 0; h -= 2)
            {
                equipoA = rondas2[NP * ronda + h, 3];
                equipoB = rondas2[NP * ronda + h + 1, 3];
                iniA = (equipoA - 1) * (NR);
                iniB = (equipoB - 1) * (NR);

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
        }

        public static void IntercambiarGallos(int ronda, int NP, int k, int a, int b, int c, int f, int l)
        {
            int[,] cambio2 = { };
            cambio2 = new int[1, 2];

            if (l == 0)
            {
                for (a = 0; a < 2; a++)
                    cambio2[0, a] = rondas2[NP * (ronda + 1) + k, a + 1];
                for (b = 0; b < 2; b++)
                    rondas2[NP * (ronda + 1) + k, b + 1] = rondas2[NP * ronda + f, b + 1];
                for (c = 0; c < 2; c++)
                    rondas2[NP * ronda + f, c + 1] = cambio2[0, c];
            }
            else
            {
                l--;
                for (a = 0; a < 2; a++)
                    cambio2[0, a] = rondas2[NP * (ronda + 1) + k, a + 1];
                for (b = 0; b < 2; b++)
                    rondas2[NP * (ronda + 1) + k, b + 1] = rondas2[NP * ronda + l, b + 1];
                for (c = 0; c < 2; c++)
                    rondas2[NP * ronda + l, c + 1] = cambio2[0, c];
            }
        }
    }
}
