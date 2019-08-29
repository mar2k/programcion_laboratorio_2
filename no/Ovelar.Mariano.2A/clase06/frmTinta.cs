using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase06
{
    public partial class frmTinta : Form
    {
        public frmTinta()
        {
            InitializeComponent();
        }

        private void frmTinta_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            foreach(ConsoleColor color in Enum.GetValues(ConsoleColor))
            {
                this.comboBox1.SelectedItem = ConsoleColor.Blue; 
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
