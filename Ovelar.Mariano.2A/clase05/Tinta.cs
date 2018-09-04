using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase05
{
  class Tinta
  {
    #region ATRIBUTOS

    private ConsoleColor _color;
    private ETipoTinta _tipo;

    #endregion

    #region COSTRUCTOR

    public Tinta()
    {
      this._color = ConsoleColor.Blue;
      this._tipo = ETipoTinta.conBrillito;
    }
    public Tinta(ConsoleColor color) : this()
    {
      this._color = color;
    }
    public Tinta(ETipoTinta tipo) : this()
    {
      this._tipo = tipo;
    }
    public Tinta(ETipoTinta tipo, ConsoleColor color) : this(color)
    {
      this._tipo = tipo;
    }

    #endregion

    #region METODOS

    public String Mostrar(Tinta)
    {

    }

    private String Mostrar()
    {

    }
    #endregion


    #region

    //static public bool ==()
    //{
    //  return true
    //}
    #endregion


  }
}
