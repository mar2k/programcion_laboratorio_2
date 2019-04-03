using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05.Entidades
{
  public class Pluma
  {
    private string _marca;
    private Tinta _tinta;
    private int _cantidad;

    public Pluma() : this(null,0,"sin marca") { }

    public Pluma(Tinta tinta) : this(tinta,0,"sin marca") { }

    public Pluma(Tinta tinta, int cantidad): this(tinta, cantidad, "sin marca") { }

      public Pluma(Tinta tinta, int cantidad,string marca)
    {
      this._tinta = tinta;
      this._cantidad = cantidad;
      this._marca = marca;
    }
    private string Mostrar()
    {
      return "TINTA\n" + Tinta.Mostrar(this._tinta) + " -- CANTIDAD: " + this._cantidad.ToString() + " -- MARCA: " + this._marca;
    }
    
    public static bool operator ==(Pluma pluma, Tinta tinta)
    {
      return pluma._tinta == tinta;
    }
    public static bool operator !=(Pluma pluma, Tinta tinta)
    {
      return !(pluma == tinta);
    }

    public static implicit operator string (Pluma pluma)
    {
      return pluma.Mostrar();
    }

    public static Pluma operator +(Pluma pluma,Tinta tinta)
    {
      if(pluma._tinta==tinta && pluma._cantidad+10 < 100)
      {
        pluma._cantidad += 10;
      }
      return pluma;
    }
  }
}
