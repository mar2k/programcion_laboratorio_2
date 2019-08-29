using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Auto : Vehiculo
    {
        private int _cantidadAsientos;

        public int CantidadAsientos
        {
            get { return _cantidadAsientos; }
            set { _cantidadAsientos = value; }
        }

        public override double Precio { get { return base._precio; } set { base._precio = value; } }

        public override double CalcularPrecioConIVA()
        {
            return base._precio + (base._precio * 0.21);
        }

        public Auto(string patente, sbyte canidadRueda, EMarca marca, int cantidadAsientos) : base(patente, canidadRueda, marca)
        {
            this.CantidadAsientos = cantidadAsientos;
        }

        public string MostrarAuto()
        {
            return base.MostrarVehiculo() + " - " + "Asientos: " + this.CantidadAsientos;
        }
        public override string ToString()
        {
            return this.MostrarAuto();
        }

    }
}
