using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
    private double cantida;
    private static double cotizRespectoDolar;
    static Pesos()
    {
      Pesos.cotizRespectoDolar = 38.33;
    }

    public Pesos(double cantida)
    {
      this.cantida = cantida;
    }

    public Pesos(double cantida, double cotizRespectoDolar) : this(cantida)
    {
      Pesos.cotizRespectoDolar = cotizRespectoDolar;
    }
    public static explicit operator Euro(Pesos p)
    {
      return new Euro(p.GetCantidad() / (38.33 * 1.16));
    }

    public static explicit operator Dolar(Pesos p)
    {
      return new Dolar(p.GetCantidad() / 38.33);
    }
    public double GetCantidad()
    {
      return this.cantida;
    }

    public static double GetCotizacion()
    {
      return Pesos.cotizRespectoDolar;
    }

    public static implicit operator Pesos(double d)
    {
      return new Pesos(d);
    }


    public static bool operator ==(Pesos e, Dolar d)
    {
      bool retorno = false;
      if (d is null && e is null)
      {
        if (e == (Pesos)d)
        {
          retorno = true;
        }
      }
      return retorno;
    }

    public static bool operator !=(Pesos e, Dolar d)
    {
      return !(e == d);
    }

    public static bool operator ==(Pesos p, Euro e)
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

    public static bool operator !=(Pesos p, Euro e)
    {
      return !(e == p);
    }

    public static bool operator ==(Pesos p1, Pesos p2)
    {
      bool retorno = false;
      if (p1 is null && p2 is null)
      {
        if (p1 == p2)
        {
          retorno = true;
        }
      }
      return retorno;
    }

    public static bool operator !=(Pesos p1, Pesos p2)
    {
      return !(p1 == p2);
    }

    public static Pesos operator +(Pesos p, Euro e)
    {
      Pesos pesos = new Pesos(e.GetCantidad() + ((Pesos)p).GetCantidad());
      return pesos;
    }
    public static Pesos operator -(Pesos p, Euro e)
    {
      Pesos pesos = new Pesos(e.GetCantidad() - ((Pesos)p).GetCantidad());
      return pesos;
    }
    public static Pesos operator +(Pesos e, Dolar d)
    {
      Pesos pesos = new Pesos(e.GetCantidad() - ((Pesos)d).GetCantidad());
      return pesos;
    }
    public static Pesos operator -(Pesos e, Dolar d)
    {
      Pesos pesos = new Pesos(e.GetCantidad() - ((Pesos)d).GetCantidad());
      return pesos;
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
