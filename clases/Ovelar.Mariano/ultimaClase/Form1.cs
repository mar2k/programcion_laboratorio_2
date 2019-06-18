using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ultimaClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            Manejadora m = new Manejadora();
            /*this.btn1.Click += new EventHandler(Manejadora.Manejador);
            this.label1.Click += new System.EventHandler(Manejadora.Manejador);
            this.textBox1.TextChanged += new System.EventHandler(Manejadora.Manejador);*/
            this.btn1.Click += new EventHandler(m.Manejador2);
            this.label1.Click += new EventHandler(m.Manejador2);
            this.textBox1.TextChanged += new EventHandler(m.Manejador2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MostrarMensage(object sender, EventArgs e)
        {
            
            //MessageBox.Show("Evento Click");
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            //this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click label");
            //this.label1.Click -= new System.EventHandler(this.label1_Click);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Click textbox");
        }

    }
}
