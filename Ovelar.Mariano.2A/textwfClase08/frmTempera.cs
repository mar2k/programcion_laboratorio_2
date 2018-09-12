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
    public partial class frmTempera : Form
    {
        private Tempera _miTempera;
        public Tempera MiTemera
        {
            get
            {
                return this._miTempera;
            }
        }
        public frmTempera()
        {
            InitializeComponent();
        }

        private void frmTempera_Load(object sender, EventArgs e)
        {
            foreach(ConsoleColor color in Enum.GetValues(typeof( ConsoleColor)))
            {
                this.comboBox1.SelectedItem = ConsoleColor.Blue; 
            }
            this.comboBox1.SelectedValue = ConsoleColor.Green;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._miTempera = new Tempera(this.textBox1.Text, (ConsoleColor)this.comboBox1.SelectedItem, sbyte.Parse(this.textBox2.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
