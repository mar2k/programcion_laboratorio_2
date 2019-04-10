using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Tempera
{
  public class Paleta
  {
    private int _cantidadMaxima;

    // cambiar array por lista de Temperas (List<Tempera>)

    private Tempera[] _temperas;

    public Tempera[] MisTemperas
    {
      get { return this._temperas; }
    }


    private Paleta():this(5)
    {
    }

    private Paleta(int cantidad)
    {
      this._cantidadMaxima = cantidad;
      this._temperas = new Tempera[cantidad];
    }

    public static implicit operator Paleta(int cantidad)
    {
      return new Paleta(cantidad);
    }
    private string Mostrar()
    {
      string retorno = "TEMPERAS MAXIMA:"+this._cantidadMaxima.ToString()+"\n";
      foreach(Tempera tempera in this._temperas)
      {
        if(tempera!=null)
        {
          retorno += tempera.Mostrar(tempera);
        }
      }
        return retorno;
    }
    public static explicit operator string(Paleta paleta)
    {
      return paleta.Mostrar();
    }

    public static bool operator ==(Paleta paleta, Tempera tempera)
    {
      bool retorno=false;
      for(int i=0;i<paleta._cantidadMaxima;i++)
      {
        if(paleta._temperas[i] == tempera)
        {
          retorno = true;
          break;
        }
      }
      return retorno;
    }
    public static bool operator !=(Paleta paleta, Tempera tempera)
    {
      return !(paleta == tempera);
    }

    public static Paleta operator +(Paleta paleta, Tempera tempera)
    {
        for (int i = 0; i < paleta._cantidadMaxima;i++)
        {
          if(paleta!=tempera)
          {
          paleta._temperas[paleta.ObtenerIndice()] += tempera;
          }
        }
        
      return paleta;
    }
    private int ObtenerIndice()
    {
      int retornar = -1;
      for(int i=0;i<this._cantidadMaxima;i++)
      {
        if(Equals(this._temperas[i],null))
        {
          retornar = i;
          break;
        }
      }
      return retornar;
    }

  }
}
