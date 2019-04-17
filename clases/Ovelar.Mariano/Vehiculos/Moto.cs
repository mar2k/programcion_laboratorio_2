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

    Moto(string patente, sbyte canidadRueda, EMarca marca, double cilindrada) : base(patente, canidadRueda, marca)
    {
      this.Cilindrada = cilindrada;
    }
    public string MostrarMoto()
    {
      return base.MostrarVehiculo() + " - " + this._cilindrada;
    }



  }
}
