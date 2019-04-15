using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Tempera;
namespace clase07
{
    public partial class Form1 : Form
    {
        private Paleta _miPaleta;

        public Paleta MiPaleta
        {
            get { return _miPaleta; }
            set { _miPaleta = value; }
        }

        public Form1()
        {
            InitializeComponent();
            this.MiPaleta = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTempera frm = new FormTempera();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.MiPaleta += frm.MiTempera;
                this.listBox1.Items.Clear();

                foreach (Tempera item in this.MiPaleta.MisTemperas)
                {
                    if (!Equals(item, null))
                    {
                        listBox1.Items.Add(item.Mostrar(item));
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //FormTempera frm = new FormTempera();
            string a;
            int i = 0;

            a = this.listBox1.SelectedItem.ToString();

            foreach (Tempera item in this.MiPaleta.MisTemperas)
            {
                if (item.Mostrar(item) == a)
                {
                    this.MiPaleta.MisTemperas.RemoveAt(i);
                    this.MiPaleta.MisTemperas.Insert(i,null);
                    break;
                }
                i++;
            }
            this.listBox1.Items.Clear();
            foreach (Tempera item in this.MiPaleta.MisTemperas)
            {
                if (!Equals(item, null))
                {
                    listBox1.Items.Add(item.Mostrar(item));
                }
            }

        }
    }
}
