using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clase04.Entidades;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("HOLA MUNDO");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cosa cosa1 = new Cosa(20, DateTime.Now, "Mariano");
            MessageBox.Show(cosa1.Mostrar());
            this.button1.Text = "CREAR UNA NUEVA COSA";
            this.button1.BackColor = Color.Yellow;
            this.Form1.BackColor = Color.Gold;
        }
    }
}

/*
             *constructor
             * load(1)
             * peint(n veces)
             * activate(n veces)
             * formclosing(n veces)
             * formclosed(1)
             * dispose(1)
             */
