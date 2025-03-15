using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoADatos;

namespace ExamenUnidad2
{
    public partial class frmInserta : Form
    {
        public frmInserta()
        {
            InitializeComponent();
        }

        private void frmInserta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("insert into usuarios (Apaterno, Amaterno, nombre, telefono, correo) values('" +
    textBox2.Text + "','" + textBox3.Text + "','" +
    textBox4.Text + "','" + textBox5.Text + "','" +
    textBox6.Text + "')");

            if (f == true)
            {
                MessageBox.Show("Datos insertados", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
