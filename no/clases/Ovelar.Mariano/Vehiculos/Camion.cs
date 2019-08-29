using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Camion : Vehiculo
    {
        private double _tara;

        public double Tara
        {
            get { return _tara; }
            set { _tara = value; }
        }

        public Camion(string patente, sbyte canidadRueda, EMarca marca, double tara) : base(patente, canidadRueda, marca)
        {
            this.Tara = tara;
        }
        public override double Precio { get { return base._precio; } set { base._precio = value; } }

        public override double CalcularPrecioConIVA()
        {
            return base._precio + (base._precio * 0.21);
        }

        public string MostrarCamion()
        {
            return base.MostrarVehiculo() + " - " + "Tara: " + this.Tara;
        }

        public override string ToString()
        {
            return this.MostrarCamion();
        }

    }
}
