using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Interface
{
    public class Comercial:Avion
    {
        protected int _cantidadPasjeros;

        public Comercial(double precio, double velMax, int pasjeros) : base(precio, velMax)
        {
            this._cantidadPasjeros = pasjeros;
        }
    }
}
