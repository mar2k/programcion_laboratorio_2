using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05.Entidades
{
  public class Tinta
  {
    private ConsoleColor _color;
    private ETipoTinta _tipoTinta;

    public Tinta():this(ConsoleColor.Black,ETipoTinta.Comun){}

    public Tinta(ConsoleColor color):this(color, ETipoTinta.Comun){}

    public Tinta(ConsoleColor color, ETipoTinta tipoTinta)
    {
      this._color = color;
      this._tipoTinta = tipoTinta;
    }

    private string Mostrar()
    {
      return "COLOR: "+this._color.ToString()+" -- TIPO: "+this._tipoTinta.ToString();
    }
    public static string Mostrar(Tinta tinta)
    {
      return tinta.Mostrar();
    }

    public static bool operator ==(Tinta t1, Tinta t2)
    {
      bool retorno = (t1._color == t2._color && t1._tipoTinta == t2._tipoTinta);
      
      return retorno;
    }
    public static bool operator !=(Tinta t1, Tinta t2)
    {
      return !(t1==t2);
    }
  }
}
