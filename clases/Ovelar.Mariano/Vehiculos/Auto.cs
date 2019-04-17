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

    public Auto(string patente, sbyte canidadRueda, EMarca marca, int cantidadAsientos) : base(patente, canidadRueda, marca)
    {
      this.CantidadAsientos = cantidadAsientos;
    }

    public string MostrarAuto()
    {
      return base.MostrarVehiculo() + " - " + this.CantidadAsientos;
    }
    

  }
}
