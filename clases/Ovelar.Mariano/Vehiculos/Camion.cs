using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
  public class Camion:Vehiculo
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


    public string MostrarCamion()
    {
      return base.MostrarVehiculo() + " - " + this.Tara;
    }

  }
}
