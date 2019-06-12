using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDeDatos;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FrmListado : Form
    {
        List<Persona> personas;
        DataTable table;

        public FrmListado()
        {
            InitializeComponent();
            SelectionMode selectionMode = new SelectionMode();
            AccesoDatos accesoDatos = new AccesoDatos();
            table = accesoDatos.TraerTablaPersonas();
            personas = accesoDatos.TraerTodos();
            dataGridView1.DataSource = table;
            //MessageBox(personas);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            


        }
    }
}
