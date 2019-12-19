using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiBaseDeDatos;

namespace PruebaWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBase baseDedatos = new DataBase("USER-PC\\MARIANOMSSQLSERV", "patentes-sp-2018");
            baseDedatos.Eliminar("[Patentes]","patente='AJ123DC'");
            baseDedatos.Actualizar("[Patentes]", "tipo='AAAAA'", "patente='AS123GH'");
           // DataTable aux= baseDedatos.consulta("[patentes-sp-2018].[dbo].[Patentes]");
            //MessageBox.Show(aux.ToString());
        }
    }
}
