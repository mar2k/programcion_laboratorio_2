using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
  public class Euro
  {
    private double cantida;
    private static double cotizRespectoDolar;
    static Euro()
    {
      Euro.cotizRespectoDolar = 1.16;
    }

    public Euro(double cantida)
    {
      this.cantida = cantida;
    }

    public Euro(double cantida, double cotizRespectoDolar) : this(cantida)
    {
      Euro.cotizRespectoDolar = cotizRespectoDolar;
    }

    public static explicit operator Dolar(Euro d)
    {
      return new Dolar(d.GetCantidad() * 1.16);
    }
    public static explicit operator Pesos(Euro d)
    {
      return new Pesos(d.GetCantidad() * (38.33*1.16));
    }
    public double GetCantidad()
    {
      return this.cantida;
    }
    public static double GetCotizacion()
    {
      return Euro.cotizRespectoDolar;
    }

    public static implicit operator Euro(double d)
    {
      return new Euro(d);
    }


    public static bool operator ==(Euro e, Dolar d)
    {
      bool retorno = false;
      if (d is null && e is null)
      {
        if (e == (Euro)d)
        {
          retorno = true;
        }
      }
      return retorno;
    }

    public static bool operator !=(Euro e, Dolar d)
    {
      return !(e == d);
    }

    public static bool operator ==(Euro e, Pesos p)
    {
      bool retorno = false;
      if (e is null && p is null)
      {
        if (p == (Pesos)e)
        {
          retorno = true;
        }
      }
      return retorno;
    }

    public static bool operator !=(Euro e, Pesos p)
    {
      return !(e == p);
    }

    public static bool operator ==(Euro e1, Euro e2)
    {
      bool retorno = false;
      if (e1 is null && e2 is null)
      {
        if (e1 == e2)
        {
          retorno = true;
        }
      }
      return retorno;
    }

    public static bool operator !=(Euro e1, Euro e2)
    {
      return !(e1 == e2);
    }

    public static Euro operator +(Euro e, Pesos p)
    {
      Euro euro = new Euro(e.GetCantidad() + ((Euro)p).GetCantidad());
      return euro;
    }
    public static Euro operator -(Euro e, Pesos p)
    {
      Euro euro = new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
      return euro;
    }
    public static Euro operator +(Euro e, Dolar d)
    {
      Euro euro = new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
      return euro;
    }
    public static Euro operator -(Euro e, Dolar d)
    {
      Euro euro = new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
      return euro;
    }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
