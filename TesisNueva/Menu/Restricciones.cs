using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Restricciones : Form
    {
        public Restricciones()
        {
            InitializeComponent();
        }

        Matrices restr = new Matrices();

        private void Restricciones_Load(object sender, EventArgs e)
        {
            //restr.Consultar("SELECT Id_Partido, Peso, Anillo FROM Gallos Order by Id_Partido, Peso", "Gallos");
            //dataGridView1.DataSource = restr.ds.Tables["Gallos"];
            //dataGridView1.Refresh();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
