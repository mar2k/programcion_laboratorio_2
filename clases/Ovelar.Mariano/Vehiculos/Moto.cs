using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Moto : Vehiculo
    {
        private double _cilindrada;

        public double Cilindrada
        {
            get { return _cilindrada; }
            set { _cilindrada = value; }
        }

        public Moto(string patente, sbyte canidadRueda, EMarca marca, double cilindrada) : base(patente, canidadRueda, marca)
        {
            this.Cilindrada = cilindrada;
        }
        public string MostrarMoto()
        {
            return base.MostrarVehiculo() + " - " + "Cilindrada: " + this._cilindrada;
        }

        public override double Precio { get { return base._precio; } set { base._precio = value; } }

        public override double CalcularPrecioConIVA()
        {
            return base._precio + (base._precio * 0.21);
        }

        public override string ToString()
        {
            return this.MostrarMoto();
        }

    }
}
