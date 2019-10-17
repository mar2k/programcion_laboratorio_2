using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace Central_Telefónica
{
    public partial class FrmLlamador : Form
    {
        Centralita centralita;
        TextBox textBoxAux;

        public FrmLlamador()
        {
            InitializeComponent();
        }

        public FrmLlamador(Centralita centralita):this()
        {
            this.centralita = centralita;
        }
        
        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.txtNroDestino.Text = "";
            //txtNroDestino.ReadOnly = true;
            this.txtNroOrigen.Text = "";
            //txtNroOrigen.ReadOnly = true;
            this.cmbFranja.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbFranja.Text = "";
            this.cmbFranja.SelectedIndex = 0;
            this.textBoxAux = txtNroDestino;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "";
            txtNroOrigen.Text = "";

        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            string numOrigen;
            string numDestino;
            float costo;
            Random tiempoRandom = new Random();
            Provincial.Franja franja;
            costo = (float)(tiempoRandom.Next(5, 56)/10f); //0,5 y 5,6
            float tiempo = tiempoRandom.Next(1, 50);
            numOrigen = this.txtNroOrigen.Text;
            numDestino= this.txtNroDestino.Text;
            Enum.TryParse<Provincial.Franja>(this.cmbFranja.SelectedValue.ToString(), out franja);

            if (numDestino.ToList()[0]=='#')
            {
                this.centralita = this.centralita + new Provincial(numOrigen, franja, tiempo, numDestino);
            }
            else
            {
                this.centralita = this.centralita + new Local(numOrigen, tiempo, numDestino,costo);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBoxAux.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBoxAux.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBoxAux.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBoxAux.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBoxAux.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBoxAux.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBoxAux.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBoxAux.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBoxAux.Text += "9";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            textBoxAux.Text += "*";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBoxAux.Text += "0";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            if (this.textBoxAux.Text=="")
            {
                this.textBoxAux.Text += "#";
            }
        }

      
        private void txtNroDestino_Click(object sender, EventArgs e)
        {
            this.textBoxAux = txtNroDestino;
        }

        private void txtNroOrigen_Click(object sender, EventArgs e)
        {
            this.textBoxAux = txtNroOrigen;
        }
    }
}
