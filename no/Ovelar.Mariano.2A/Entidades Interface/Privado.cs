using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Interface
{
    public class Privado:Avion
    {
        protected int _valoracioServicioDeAbordo;

        public Privado(double precio, double velMax,int valoracion) : base(precio,velMax)
        {
            this._valoracioServicioDeAbordo = valoracion;
        }
    }
}
