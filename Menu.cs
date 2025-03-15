using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenUnidad2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void rEGISTRODEEMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mostrar = new Form1();
            mostrar.Show();
        }
    }
}
