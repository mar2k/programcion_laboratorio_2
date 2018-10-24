using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Interface
{
    public class Familiar : Auto
    {
        protected int _cantAsientos;

        public override string Patente { get { return this._patente; } }

        public Familiar(double precio, string patente,int cantidadAsientos) : base(precio,patente)
        {
            this._cantAsientos = cantidadAsientos;
        }
    }
}
