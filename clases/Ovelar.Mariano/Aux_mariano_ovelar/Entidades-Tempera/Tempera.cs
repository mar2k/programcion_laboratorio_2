using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Tempera
{
  public class Tempera
  { 
    private ConsoleColor _color;
    private string _marca;
    private sbyte _cantidad;

    public ConsoleColor Color { get { return this._color; } set { this._color =value; } }
    public string Marca { get { return this._marca; } set { this._marca = value; } }

    public Tempera(ConsoleColor color, string marca, sbyte cantidad)
    {
      _color = color;
      _marca = marca;
      _cantidad = cantidad;
    }

    private string Mostrar()
    {
      return "COLOR: "+this._color.ToString() + " MARCA: " + this._marca + " CANTIDAD: " + this._cantidad.ToString();
    }
    public static string Mostrar(Tempera tempera)
    {
      string retorno = "";
      if(!Equals(tempera,null))
      {
        retorno = tempera.Mostrar();
      }
      
      return retorno;
    }

    public static bool operator ==(Tempera tempera1, Tempera tempera2)
    {
      bool retorno = false;
      if(Equals(tempera1, null) && Equals(tempera2, null))
      {
        retorno = true;
      }
      else if(!Equals(tempera1, null) && !Equals(tempera2, null))
      {
        if (tempera1._color == tempera2._color && tempera1._marca == tempera2._marca)
        {
          retorno = true;
        }
      }
      return retorno;
    }
    public static bool operator !=(Tempera tempera1, Tempera tempera2)
    {
      return !(tempera1 == tempera2);
    }

    public static Tempera operator +(Tempera tempera1, Tempera tempera2)
    {
      if (tempera1==tempera2)
      {
          tempera1._cantidad += tempera2._cantidad;
      }
      return tempera1;
    }
    public static Tempera operator +(Tempera tempera, sbyte cantidad)
    {
      tempera._cantidad += cantidad;
      return tempera;
    }

    public static implicit operator sbyte(Tempera tempera)
    {
      return tempera._cantidad;
    }
  }
}
