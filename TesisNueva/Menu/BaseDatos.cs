using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Menu
{
    class BaseDatos
    {
        SQLiteConnection conexion = new SQLiteConnection("Data Source=BD_Tesis.db");
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public static string Nombre = " ";
        public static string TipoUsuario = " ";
        public static string NomDerby = " ";
        public static string FechaDerby = " ";
        public static string NumGallos = " ";
        public static string ID_Datos_NuevaPartida = " ";
        public static string Numero = " ";
        public static int Eliminar = ' ';
        public static string IdPartido = " ";
        public static string ValIdPartido = " ";

        public Boolean iniciarSesion(string nomus, string con)
        {
            Nombre = "";
            TipoUsuario = "";

            //Aqui abrmos la base de datos con la cadenaConexion que dimos arriba
            conexion.Open();

            SQLiteParameter parnomus = new SQLiteParameter("@nomus", nomus);
            SQLiteParameter parcon = new SQLiteParameter("@con", con);

            SQLiteCommand comando = new SQLiteCommand("SELECT Nombre, APaterno, AMaterno, TipoUsuario FROM Usuario WHERE NomUsuario = @nomus AND Contrasena = @con;", conexion);
            comando.Parameters.Add(parnomus);
            comando.Parameters.Add(parcon);

            SQLiteDataReader lector = comando.ExecuteReader(); //ejecutamos la sentencia anterior

            while (lector.Read())
            {
                Nombre = lector.GetString(0) + "  " + lector.GetString(1) + "  " + lector.GetString(2);
                TipoUsuario = lector.GetString(3);
            }

            lector.Close();
            conexion.Close();

            if (string.IsNullOrEmpty(TipoUsuario))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean Derby(string nomderby, string fechaderby, string ToleranciaGr, int numgallos, string Organizador)
        {
            conexion.Open();

            SQLiteParameter parnomderby = new SQLiteParameter("@nomderby", nomderby);
            SQLiteParameter parfechaderby = new SQLiteParameter("@fechaderby", fechaderby);
            SQLiteParameter partoleranciagr = new SQLiteParameter("@toleraPeso", ToleranciaGr);
            SQLiteParameter parnumgallos = new SQLiteParameter("@numGallo", numgallos);
            SQLiteParameter parorganizador = new SQLiteParameter("@organizador", Organizador);

            SQLiteCommand comando = new SQLiteCommand("INSERT INTO Derby(NomDerby, FechaDerby, ToleranciaGr, NumGallos, Organizador) VALUES(@nomderby, @fechaderby, @toleraPeso, @numGallo, @organizador);", conexion);
            comando.Parameters.Add(parnomderby);
            comando.Parameters.Add(parfechaderby);
            comando.Parameters.Add(partoleranciagr);
            comando.Parameters.Add(parnumgallos);
            comando.Parameters.Add(parorganizador);

            SQLiteDataReader lector = comando.ExecuteReader();
            lector.Close();

            if (string.IsNullOrEmpty(NumGallos))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean Registro(string nompartido)
        {
            conexion.Open();

            //Aqui guardamos en la variable NUMERO, el numero del partido en el que vamos, logicamente tomamos el numero de la ultima partida
            //de derby creada, para posteriormente poder mostrar el numero del partido en la ventana de RegistroGallos
            SQLiteCommand comando3 = new SQLiteCommand("SELECT ID_Derby FROM Derby ORDER BY ID_Derby DESC LIMIT 1;", conexion);
            SQLiteDataReader lector2 = comando3.ExecuteReader();

            while (lector2.Read())
            {
                Numero = lector2.GetInt16(0) + " ";
            }

            //Registrar los datos del partido
            SQLiteParameter parnompartido = new SQLiteParameter("@nomderby", nompartido);
            SQLiteParameter parnumero = new SQLiteParameter("@numID", Numero);

            SQLiteCommand comando = new SQLiteCommand("INSERT INTO Partido(NomPartido,ID_Partido_Derby) VALUES(@nomderby, @numID);", conexion);
            comando.Parameters.Add(parnompartido);
            comando.Parameters.Add(parnumero);

            SQLiteDataReader lector = comando.ExecuteReader();

            lector.Close();
            lector2.Close();

            if (string.IsNullOrEmpty(NumGallos))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean registroGallo(string NomPartido, string PesoGallo, string NumAnillo)
        {
            conexion.Open();

            //Comparamos el nombre del partido que se selecciono en la lista desplegable, para poder cambiarlo por el 
            //IdPartido
            SQLiteParameter parNomPartido = new SQLiteParameter("@nompartido", NomPartido);
            SQLiteCommand com = new SQLiteCommand("SELECT Id_Partido FROM Partido WHERE NomPartido = @nompartido", conexion);
            com.Parameters.Add(parNomPartido);
            SQLiteDataReader lector1 = com.ExecuteReader();

            while (lector1.Read())
            {
                IdPartido = lector1.GetInt16(0) + " ";
            }
            lector1.Close();
            int IntIdPartido = Int16.Parse(IdPartido);//Convertimos el IdPartido a entero (int)

            //Validar si son 4 gallos para que ya no los guarde y muestre mensaje
            SQLiteParameter valNomPartido = new SQLiteParameter("@idpartido", IdPartido);
            SQLiteCommand val = new SQLiteCommand("SELECT count (Id_Partido) FROM Gallos WHERE Id_Partido = @idpartido;", conexion);
            val.Parameters.Add(valNomPartido);
            SQLiteDataReader lector = val.ExecuteReader();

            while (lector.Read())
            {
                ValIdPartido = lector.GetInt16(0) + " ";
            }
            lector.Close();
            int validar = Int16.Parse(ValIdPartido);

            if (validar < 4)
            {
                //Guarda los datos en la tabla gallos
                SQLiteParameter parIdPartido = new SQLiteParameter("@idpartido", IdPartido);
                SQLiteParameter parPesoGallo = new SQLiteParameter("@pesogallo", PesoGallo);
                SQLiteParameter parNumAnillo = new SQLiteParameter("@numanillo", NumAnillo);
                SQLiteCommand comando = new SQLiteCommand("INSERT INTO Gallos(Id_Partido, Peso, Anillo) VALUES(@idpartido, @pesogallo, @numanillo);", conexion);
                comando.Parameters.Add(parIdPartido);
                comando.Parameters.Add(parPesoGallo);
                comando.Parameters.Add(parNumAnillo);
                SQLiteDataReader lector2 = comando.ExecuteReader();
                lector2.Close();
                MessageBox.Show("Datos guardados correctamente");
            }
            else
            {
                DialogResult res = MessageBox.Show("No se pueden guardar datos" + Environment.NewLine +
                        "este equipo ya tiene 4 gallos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (string.IsNullOrEmpty(NomPartido))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Borrar datos en la base de datos
        public bool Borrar(int valorElim)
        {
            conexion.Open();
            SQLiteParameter parIdPartido = new SQLiteParameter("@Valor", valorElim);
            SQLiteCommand adaptador = new SQLiteCommand("DELETE FROM Gallos WHERE Id_Gallo = @Valor", conexion);
            adaptador.Parameters.Add(parIdPartido);
            SQLiteDataReader lector = adaptador.ExecuteReader();
            lector.Close();
            MessageBox.Show("Registro Eliminado");

            if (string.IsNullOrEmpty(NumGallos))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Actualizar datos de la base de datos
        public Boolean Actualizar(string valorPartido, int valorActu, int valorPeso, int valorAnillo)
        {
            conexion.Open();
            //Comparamos el nombre del partido que se selecciono en la lista desplegable, para poder cambiarlo por el 
            //IdPartido
            SQLiteParameter parNomPartido = new SQLiteParameter("@nompartido", valorPartido);
            SQLiteCommand com = new SQLiteCommand("SELECT Id_Partido FROM Partido WHERE NomPartido = @nompartido", conexion);
            com.Parameters.Add(parNomPartido);
            SQLiteDataReader lector1 = com.ExecuteReader();

            while (lector1.Read())
            {
                IdPartido = lector1.GetInt16(0) + " ";
            }
            lector1.Close();
            int IntIdPartido = Int16.Parse(IdPartido);//Convertimos el IdPartido a entero (int)

            SQLiteParameter idValor = new SQLiteParameter("@ValorActu", valorActu); //Id_Gallo
            SQLiteParameter partidoValor = new SQLiteParameter("@ValorPartido", IntIdPartido); //Id_Partido
            SQLiteParameter pesoValor = new SQLiteParameter("@ValorPeso", valorPeso); //Peso
            SQLiteParameter anilloValor = new SQLiteParameter("@ValorAnillo", valorAnillo); //Anillo

            SQLiteCommand adaptador = new SQLiteCommand("UPDATE Gallos SET Id_Partido=@ValorPartido, Peso=@ValorPeso, Anillo=@ValorAnillo WHERE Id_Gallo = @ValorActu", conexion);
            adaptador.Parameters.Add(idValor);
            adaptador.Parameters.Add(partidoValor);
            adaptador.Parameters.Add(pesoValor);
            adaptador.Parameters.Add(anilloValor);
            SQLiteDataReader lector = adaptador.ExecuteReader();
            lector.Close();
            MessageBox.Show("Registro Actualizado");

            if (string.IsNullOrEmpty(NumGallos))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean registroRestriccion(string NomPartido1, string NomPartido2)
        {
            conexion.Open();
            //Registrar los datos del partido
            SQLiteParameter nompartido1 = new SQLiteParameter("@nomPart1", NomPartido1);
            SQLiteParameter nompartido2 = new SQLiteParameter("@nomPart2", NomPartido2);

            SQLiteCommand comando = new SQLiteCommand("INSERT INTO Restricciones(Partido1,Partido2) VALUES(@nomPart1, @nomPart2);", conexion);
            comando.Parameters.Add(nompartido1);
            comando.Parameters.Add(nompartido2);

            SQLiteDataReader lector = comando.ExecuteReader();

            lector.Close();

            if (string.IsNullOrEmpty(NumGallos))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Borrar datos en la base de datos de la tabla restricciones
        public bool BorrarRestricciones(int valorElim)
        {
            conexion.Open();
            SQLiteParameter parIdPartido = new SQLiteParameter("@Valor", valorElim);
            SQLiteCommand adaptador = new SQLiteCommand("DELETE FROM Restricciones WHERE Id_Restricciones = @Valor", conexion);
            adaptador.Parameters.Add(parIdPartido);
            SQLiteDataReader lector = adaptador.ExecuteReader();
            lector.Close();
            MessageBox.Show("Registro Eliminado");

            if (string.IsNullOrEmpty(NumGallos))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Autocompleta el campo de texto "Nombre Del Partido" dentro de registro
        public void autoCompletar(TextBox cajaTexto)
        {
            conexion.Open();            
            try
            {
                cmd = new SQLiteCommand("SELECT NomPartido FROM Partido", conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cajaTexto.AutoCompleteCustomSource.Add(dr["NomPartido"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede autocompletar el TextBox:" +ex.ToString());
            }
        }

        //Autocompleta el campo de texto "txtMosNP2" dentro de registro
        public void autoCompletar2(TextBox cajaTexto2)
        {
            try
            {
                cmd = new SQLiteCommand("SELECT NomPartido FROM Partido", conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cajaTexto2.AutoCompleteCustomSource.Add(dr["NomPartido"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede autocompletar el TextBox:" + ex.ToString());
            }
        }

        //Autocompletar el campo de texto textPart1 dentro de restricciones
        public void autoCompletar3(TextBox cajaTexto3)
        {
            try
            {
                conexion.Open();
                cmd = new SQLiteCommand("SELECT NomPartido FROM Partido", conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cajaTexto3.AutoCompleteCustomSource.Add(dr["NomPartido"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede autocompletar el TextBox:" + ex.ToString());
            }
        }

        //Autocompletar el campo de texto textPart2 dentro de restricciones
        public void autoCompletar4(TextBox cajaTexto4)
        {            
            try
            {
                cmd = new SQLiteCommand("SELECT NomPartido FROM Partido", conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cajaTexto4.AutoCompleteCustomSource.Add(dr["NomPartido"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede autocompletar el TextBox:" + ex.ToString());
            }
        }
    }
}