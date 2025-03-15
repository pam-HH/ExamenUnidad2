using AccesoADatos;
using System.Data;

namespace ExamenUnidad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizar actualizar = new frmActualizar(
                        dgvAgenda[0, e.RowIndex].Value.ToString(),
                        dgvAgenda[1, e.RowIndex].Value.ToString(),
                        dgvAgenda[2, e.RowIndex].Value.ToString(),
                        dgvAgenda[3, e.RowIndex].Value.ToString(),
                        dgvAgenda[4, e.RowIndex].Value.ToString(),
                        dgvAgenda[5, e.RowIndex].Value.ToString());
            actualizar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInserta inserta = new frmInserta();
            inserta.Show();
        }
        private void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select * From usuarios");
            if (ds != null)
            {
                dgvAgenda.DataSource = ds.Tables[0];
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }
    }
}
