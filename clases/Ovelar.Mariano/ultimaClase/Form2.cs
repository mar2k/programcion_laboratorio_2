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
    public partial class Form2 : Form
    {
        Manejadora m = new Manejadora();
        
        public Form2()
        {
            InitializeComponent();
            
            this.Load += new EventHandler(this.inicializar);
        }

        private void inicializar(object sender, EventArgs e)
        {
            this.btn1.Click += new EventHandler(this.Mimajenador);
        }

        private void Mimajenador(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            MessageBox.Show(b.Name);

            if (this.btn1.Name == b.Name)
            {
                this.btn1.Click -= new EventHandler(this.Mimajenador);
                this.btn2.Click += new EventHandler(this.Mimajenador);
            }
            else if (this.btn2.Name == b.Name)
            {
                this.btn2.Click -= new EventHandler(this.Mimajenador);
                this.btn3.Click += new EventHandler(this.Mimajenador);
            }
            else if (this.btn3.Name == b.Name)
            {
                this.btn3.Click -= new EventHandler(this.Mimajenador);
                this.btn1.Click += new EventHandler(this.Mimajenador);
            }
        }
        public static void Suma(int a, int b)
        {
            MessageBox.Show((a+b).ToString());
        }
        public void Resta(int a, int b)
        {
            MessageBox.Show((a-b).ToString());
        }
        public static void Multiplicar(int a, int b)
        {
            MessageBox.Show((a * b).ToString());
        }
        public static void OtraSuma(MiDelegado del, int a, int b)
        {
            del.Invoke(a, b);
            //MessageBox.Show(().ToString());
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            MiDelegado del1 = new MiDelegado(Form2.Suma);
            
            del1.Invoke(3,2);

            MiDelegado del2 = new MiDelegado(this.Resta);

            del2.Invoke(3, 2);

            MiDelegado del3 = (MiDelegado)MiDelegado.Combine(del1, del2);

            del3.Invoke(6, 4);

            MessageBox.Show((del3.Method).ToString());
            MessageBox.Show((del3.Target).ToString());

            string aux = "";
            foreach (Delegate item in del3.GetInvocationList())
            {
                aux += (item.Method).ToString() + "\n";
            }

            MessageBox.Show(aux);


            MiDelegado del4 = (MiDelegado)MiDelegado.Combine(del3, new MiDelegado(Form2.Multiplicar));

            Form2.OtraSuma(del1, 10, 9);
           
        }
    }
}
