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
    public partial class frmActualizar : Form
    {
        public frmActualizar(string id = "",
    string apaterno = "",
    string amaterno = "",
    string nombre = "",
    string telefono = "",
    string correo = "")
        {
            InitializeComponent();
            textBox1.Text = id;
            textBox2.Text = apaterno;  
            textBox3.Text = amaterno;  
            textBox4.Text = nombre;    
            textBox5.Text = telefono;
            textBox6.Text = correo;
        }
        public frmActualizar(DataRow row) : this(
            row["id"].ToString(),
            row["Apaterno"].ToString(),
            row["Amaterno"].ToString(),
            row["nombre"].ToString(),
            row["telefono"].ToString(),
            row["correo"].ToString()

      )
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmActualizar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("update usuarios set " +
    "Apaterno='" + textBox2.Text +
    "', Amaterno='" + textBox3.Text +
    "', nombre='" + textBox4.Text +
    "', telefono='" + textBox5.Text +
    "', correo='" + textBox6.Text +
    "' where id=" + textBox1.Text);
            if (f == true)
            {
                MessageBox.Show("Datos Actualizados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al Actualizar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro de eliminar el registro?",
                       "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from usuarios where id=" + textBox1.Text);
                if (f == true)
                {
                    MessageBox.Show("Datos Eliminados", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
