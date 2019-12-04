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
        private string cadena = "Data Source=BD_Tesis.db";
        public SQLiteConnection cn;
        public SQLiteCommand cmb;
        public DataSet ds = new DataSet();
        public SQLiteDataAdapter da;

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
//#pragma warning disable CS1690 // El acceso a un miembro en un campo de una clase de serialización por referencia puede causar una excepción en tiempo de ejecución.
      //      int gallos1 = Convert.ToInt32( gallos.indice.ToString());
//#pragma warning restore CS1690 // El acceso a un miembro en un campo de una clase de serialización por referencia puede causar una excepción en tiempo de ejecución.

            //  int gallos1; 
            // int NG = 16;
            int NG = 16;
            string sql = "select Id_Partido,Peso from Gallos order by Id_Partido, Peso";
            int[,] arreglo = { };
            int[,] matrizPesos = { };
            bool[,] peleaPeso = { };
            bool[,] peleaPartido = { };
            int[,,] rondas = { };
            da = new SQLiteDataAdapter(sql, cn);
            cmb = new SQLiteCommand();
            cmb.CommandText = sql;
            da.Fill(ds, tabla);

            int arryRows = 0;
            int arryColumns = 0;
            int i = 0, j = 0;
            int x = 0, y = 0;
            int tolerancia = 80;
           // gallos1 = gallos.indice.ToString

            //aqui cuenta las columnas que hay en la tabla Gallos y se compara para que entre a manipular el arreglo
            if (ds.Tables["Gallos"].Rows.Count > 0)
            {
                //  NG = matrizPesos.GetLength(0);
                arryRows = ds.Tables["Gallos"].Rows.Count;
                //se asigna a matrizPesos el numero de filas x numero de filas de la Tabla Gallos [NG,NG]
                matrizPesos = new int[arryRows, arryRows];
                peleaPeso = new bool[NG, NG];
                peleaPartido = new bool[NG, NG];
                //AQUI HICE UNA PRUEBA DE NUMERO DE FILAS POR NUMERO DE COLUMNAS DE LA TABLA GALLOS

                arryColumns = 2;
                arreglo = new int[arryRows, arryColumns];

                for (i = 0; i < arryRows; i++)
                {
                    for (j = 0; j < arryColumns; j++)
                    {
                        arreglo[i, j] = int.Parse(ds.Tables["Gallos"].Rows[i][j].ToString());

                    }
                }

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
