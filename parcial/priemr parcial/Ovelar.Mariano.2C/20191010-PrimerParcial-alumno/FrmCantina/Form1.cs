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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.nudCapacidad.Minimum = 1;
            this.nudContenido.Minimum = 1;
            this.nudCapacidad.Maximum = 5000;
            this.nudContenido.Maximum = 5000;
            this.nudCapacidad.Value = 1000;
            this.nudContenido.Value = 1000;
            this.rbtnCerveza.Checked = true;
            this.cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));

            this.barra = new Barra();
            this.barra.SetCantina = Cantina.GetCantina(10);
            this.barra.Height = 368;
            this.barra.Width = 551;
            this.barra.Location = new Point(0, 0);
            this.barra.Name = "controlBarra";


            this.panel1.Controls.Add(this.barra);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
            if (this.rbtnCerveza.Checked)
            {
                this.barra.AgregarBotella(new Cerveza((int)this.nudCapacidad.Value, this.txtMarca.Text, tipo,(int) this.nudContenido.Value));
            }
            else
            {
                this.barra.AgregarBotella(new Agua((int)this.nudCapacidad.Value, this.txtMarca.Text, (int)this.nudContenido.Value));
            }

        }
    }
}
