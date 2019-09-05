using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_17
{
  public class Bolígrafo
  {
    public const short cantidadTintaMaxima = 100;
    private ConsoleColor color;
    private short tinta;

    public Bolígrafo(short tinta, ConsoleColor color)
    {
      this.color = color;
      this.SetTinta(tinta);

    }
    public ConsoleColor GetColor()
    {
      return this.color;
    }
    public short GetTinta()
    {
      return this.tinta;
    }
    public bool Pintar(short gasto, out string dibujo)
    {
      bool pudoPintar = false;
      int i;
      dibujo = "";

      if (this.tinta-gasto>=0)
      {
        this.SetTinta((short)(gasto*-1));
      }
      else
      {
        gasto = this.tinta;
      }

      for (i = 0; i < gasto; i++)
      {
        dibujo = dibujo + "*";
      }

      if (i!=0)
      {
        pudoPintar = true;
      }

      return pudoPintar;
    }
    public void Recargar()
    {
      this.SetTinta(Bolígrafo.cantidadTintaMaxima);
    }

    private void SetTinta(short tinta)
    {
      if (tinta <= 0)
      {
        if (this.tinta - tinta >= 0)
        {
          this.tinta -= tinta;
        }
        else
        {
          this.tinta = 0;
        }
      }
      else
      {
        if (this.tinta + tinta <= Bolígrafo.cantidadTintaMaxima)
        {
          this.tinta += tinta;
        }
        else
        {
          this.tinta = 100;
        }
      }
    }



  }
}
