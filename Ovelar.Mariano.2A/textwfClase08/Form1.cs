using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidadesClase07;

namespace textwfClase08
{
    public partial class Form1 : Form
    {
        Paleta _miPaleta;
        public Form1()
        {
            InitializeComponent();

            this._miPaleta = new Paleta(5);

            this.groupBox1.Text = "Paleta decolores";
            this.textBox1.Multiline= true;
            this.button1.Text = "+";
            this.button2.Text = "-";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
          textBox1.SelectedText = "";
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.groupBox1.Visible = true;
            this.agregarPaletaToolStripMenuItem.Enabled=false;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTempera colores = new frmTempera();
            DialogResult dialogResult = colores.ShowDialog();
            
            if (dialogResult == DialogResult.OK)
            {
              this._miPaleta += colores.MiTempera;
              textBox1.Text += (string)this._miPaleta;
            }

        }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }
    }
}
