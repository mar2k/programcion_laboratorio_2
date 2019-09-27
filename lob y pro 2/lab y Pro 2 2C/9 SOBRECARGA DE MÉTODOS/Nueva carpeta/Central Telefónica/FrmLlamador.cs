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
        TextBox textBoxAux;
        public FrmLlamador()
        {
            InitializeComponent();
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            txtNroDestino.Text = "";
            //txtNroDestino.ReadOnly = true;
            txtNroOrigen.Text = "";
            //txtNroOrigen.ReadOnly = true;
            cmbFranja.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFranja.Text = "";
            cmbFranja.SelectedIndex = 0;
            textBoxAux = txtNroDestino;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "";
            txtNroOrigen.Text = "";

        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {

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
            if (textBoxAux.Text=="")
            {
                textBoxAux.Text += "#";

            }
        }

      
        private void txtNroDestino_Click(object sender, EventArgs e)
        {
            textBoxAux = txtNroDestino;
        }

        private void txtNroOrigen_Click(object sender, EventArgs e)
        {
            textBoxAux = txtNroOrigen;
        }
    }
}
