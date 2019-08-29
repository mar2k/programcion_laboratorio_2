using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Interface
{
    public abstract class Veiculo
    {
        protected double _precio;

        public Veiculo(double precio)
        {
            this._precio = precio;
        }

        public void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }
    }
}
