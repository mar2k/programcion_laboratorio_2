using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1 Euro equivale a 1,16 dólares 
//1 dólar equivale a 38,33 pesos

namespace Billetes
{
  public class Dolar
  {
    private double cantida;
    private static double cotizRespectoDolar;

    static Dolar()
    {
      Dolar.cotizRespectoDolar = 1;
    }

    public Dolar(double cantida)
    {
      this.cantida = cantida;
    }

    public Dolar(double cantida, double cotizRespectoDolar) : this(cantida)
    {
      Dolar.cotizRespectoDolar = cotizRespectoDolar;
    }

    public static explicit operator Euro(Dolar d)
    {
      return new Euro(d.GetCantidad() / 1.16);
    }
    public static explicit operator Pesos(Dolar d)
    {
      return new Pesos(d.GetCantidad() * 38.33);
    }
    public double GetCantidad()
    {
      return this.cantida;
    }
    public static double GetCotizacion()
    {
      return Dolar.cotizRespectoDolar;
    }

    public static implicit operator Dolar(double d)
    {
      return new Dolar(d);
    }

    public static bool operator ==(Dolar d, Euro e)
    {
      bool retorno=false;
      if (d is null && e is null)
      {
        if (e == (Euro)d)
        {
          retorno = true;
        }
      }
      return retorno;
    }

    public static bool operator !=(Dolar d, Euro e)
    {
      return !(d == e);
    }

    public static bool operator ==(Dolar d, Pesos p)
    {
      bool retorno = false;
      if (d is null && p is null)
      {
        if (p == (Pesos)d)
        {
          retorno = true;
        }
      }
      return retorno;
    }

    public static bool operator !=(Dolar d, Pesos p)
    {
      return !(d == p);
    }

    public static bool operator ==(Dolar d1, Dolar d2)
    {
      bool retorno = false;
      if (d1 is null && d2 is null)
      {
        if (d1 == d2)
        {
          retorno = true;
        }
      }
      return retorno;
    }

    public static bool operator !=(Dolar d1, Dolar d2)
    {
      return !(d1 == d2);
    }

    public static Dolar operator +(Dolar d, Pesos p)
    {
      Dolar dolar = new Dolar(d.GetCantidad()+((Dolar)p).GetCantidad());
      return dolar;
    }
    public static Dolar operator -(Dolar d, Pesos p)
    {
      Dolar dolar = new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());
      return dolar;
    }
    public static Dolar operator +(Dolar d, Euro e)
    {
      Dolar dolar = new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
      return dolar;
    }
    public static Dolar operator -(Dolar d, Euro e)
    {
      Dolar dolar = new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
      return dolar;
    }

  }
}
