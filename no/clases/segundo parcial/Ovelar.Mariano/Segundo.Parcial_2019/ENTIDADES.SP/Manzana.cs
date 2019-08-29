using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
  public class Manzana : Fruta
  {
    protected string _provinciaOrigen;

    public string Nombre
    {
      get { return "Manzana"; }
    }

    public override bool TineneCarozo
    {
      get { return true; }
    }

    public Manzana(string color, double peso, string provinciaOrigen):base(color,peso)
    {
      this._provinciaOrigen = provinciaOrigen;
    }

    public override string ToString()
    {
      return base.FrutaToString() + " TineneCarozo:" + this.TineneCarozo.ToString();
    }



  }
}
