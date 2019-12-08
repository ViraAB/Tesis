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

        private void Restricciones_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Estoy en restricciones");
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
