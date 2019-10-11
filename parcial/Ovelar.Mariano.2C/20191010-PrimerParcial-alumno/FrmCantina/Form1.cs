using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCantina;
using Entidades;

namespace FrmCantina
{
    public partial class Form1 : Form
    {
        Barra barra;
        //Botella.Tipo tipo;

        public Form1()
        {
            InitializeComponent();
            this.barra = new Barra();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.nudCapacidad.Minimum = 1;
            this.nudContenido.Minimum = 1;
            this.nudCapacidad.Maximum = 5000;
            this.nudContenido.Maximum = 5000;
            this.nudCapacidad.Value = 1000;
            this.nudContenido.Value = 1000;
            this.cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
            this.panel1.Controls.Add(this.barra);
            this.barra.SetCantina = Cantina.GetCantina(10);
             
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
