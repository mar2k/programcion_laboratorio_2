using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ_60
{
    public partial class Form1 : Form
    {
        conexiónSQLServer baseDeDatos;
        string tabla;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder datos = new StringBuilder();
            datos.Append("Data Source=.\\SQLEXPRESS;");
            datos.Append("Initial Catalog = AdventureWorks2012;");
            datos.Append("Integrated Security = True");
            this.baseDeDatos = new conexiónSQLServer(datos.ToString());
            this.baseDeDatos.Leertabla(out tabla);
            this.richTextBox1.Text += tabla;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
