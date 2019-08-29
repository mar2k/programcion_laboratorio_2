using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
  public abstract class Fruta
  {
    protected string _color;
    protected double _peso;
   
    public abstract bool TineneCarozo { get; }

    protected Fruta(string color, double peso)
    {
      this._color = color;
      this._peso = peso;
    }

    protected virtual string FrutaToString()
    {
      return "color: " + this._color + " peso: " + this._peso.ToString(); 
    }


  }
}
