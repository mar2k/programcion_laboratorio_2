using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_27
{
  class Program
  {
    static void Main(string[] args)
    {
      Listas listas = new Listas();
      Colas colas = new Colas();
      Pilas pilas = new Pilas();

      listas.generarListaRandom(5);
      colas.generarListaRandom(5);
      pilas.generarListaRandom(5);

      Console.WriteLine("listas");
      foreach (int item in listas.listaNumeros)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("- --> +");
      listas.OrdenarLista(1);
      foreach (int item in listas.listaNumeros)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("+ --> -");
      listas.OrdenarLista(-1);
      foreach (int item in listas.listaNumeros)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("-------------------------------------------------------------------");

      Console.WriteLine("colas");
      foreach (int item in colas.colasNumeros)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("- --> +");
      colas.OrdenarLista(1);
      foreach (int item in colas.colasNumeros)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("+ --> -");
      colas.OrdenarLista(-1);
      foreach (int item in colas.colasNumeros)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("-------------------------------------------------------------------");
      Console.WriteLine("pilas");
      foreach (int item in pilas.pilasNumeros)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("- --> +");
      pilas.OrdenarLista(1);
      foreach (int item in pilas.pilasNumeros)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("+ --> -");
      pilas.OrdenarLista(-1);
      foreach (int item in pilas.pilasNumeros)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("-------------------------------------------------------------------");
      Console.ReadKey();

    }
  }
}
