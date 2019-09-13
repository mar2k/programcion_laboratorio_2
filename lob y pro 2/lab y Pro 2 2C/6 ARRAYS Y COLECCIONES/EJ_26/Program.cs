using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_26
{
  class Program
  {
    static void Main(string[] args)
    {
      NumerosRamdon numeros = new NumerosRamdon();

      numeros.generarListaRandom(5);
      foreach (int item in numeros.listaNumeros)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("- --> +");
      numeros.OrdenarLista(1);
      foreach (int item in numeros.listaNumeros)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("+ --> -");
      numeros.OrdenarLista(-1);
      foreach (int item in numeros.listaNumeros)
      {
        Console.WriteLine(item);
      }
      Console.ReadKey();
    }
  }
}
