using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librerias;

namespace proyecto03
{
  class Program
  {
    static void Main(string[] args)
    {
      Bolígrafo bolígrafo = new Bolígrafo(10,ConsoleColor.Red);
      string dibujo="";
      bolígrafo.Pintar(-11, out dibujo);
      Console.WriteLine(dibujo);
      bolígrafo.Recargar();
      Console.WriteLine(bolígrafo.GetTinta());
      bolígrafo.Pintar(-30, out dibujo);
      Console.WriteLine(dibujo);

      Console.ReadKey();
    }
  }
}
