using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ultimaClase
{
    public class Manejadora
    {
        public static void Manejador(object sender, EventArgs e)
        {
            MessageBox.Show("Clase Manejadora Metodo Manejador");

        }
        public void Manejador2(object sender, EventArgs e)
        {
            string mensaje = "Clase Manejadora Metodo Manejador ";

            if (sender is Button)
            {
                mensaje += "Button";
            }
            else if (sender is Label)
            {
                mensaje += "Label";
            }
            else if (sender is TextBox)
            {
                mensaje += "TextBox";
            }
            MessageBox.Show(mensaje);
        }
    }
}
