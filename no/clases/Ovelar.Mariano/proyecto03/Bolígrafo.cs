using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto03
{
  class Bolígrafo
  {
    public static short cantidadTintaMaxima;
    private ConsoleColor color;
    private short tinta;

    public Bolígrafo(short tinta, ConsoleColor color)
    {
      this.SetTinta(tinta);
      this.color = color;
    }
    static Bolígrafo()
    {
      Bolígrafo.cantidadTintaMaxima = 100;
    }

    public ConsoleColor GetColor()
    {
      return this.color;
    }

    public short GetTinta()
    {
      return this.tinta;
    }

    public bool Pintar(int gastar, out string dibujo)
    {
      short tintaInicio = this.tinta;
      short tintaUsada;
      dibujo = "";

      this.SetTinta((short)gastar);

      tintaUsada = (short)(tintaInicio - this.tinta);
      
      for (short i = 0; i < tintaUsada; i++)
      {
        dibujo += "*";
      }

      return true;
    }

    public void Recargar()
    {
      SetTinta(cantidadTintaMaxima);
    }

    private void SetTinta(short tinta)
    {
      if (tinta < 0)
      {
        if (this.tinta + tinta >= 0)
        {
          this.tinta += tinta;
        }
        else
        {
          this.tinta = 0;
          Console.WriteLine("ERROR:FALTA TINTA!!!!");
        }
      }
      else
      {
        if (Bolígrafo.cantidadTintaMaxima > tinta + this.tinta)
        {
          this.tinta += tinta;
        }

        else if (Bolígrafo.cantidadTintaMaxima <= tinta)
        {
          this.tinta = Bolígrafo.cantidadTintaMaxima;
        }

        else
        {
          Console.WriteLine("YA TIENE TINTA / LA CANTIDAD DE TINTA QUE QUIERE INGRESAR NO ENTRA EN EL CARTUCHO");
        }
      }
    }

  }
}
