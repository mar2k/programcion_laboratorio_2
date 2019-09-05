using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_19
{
  class Program
  {
    static void Main(string[] args)
    {
      Sumador sumador1 = new Sumador(0);
      Sumador sumador2 = new Sumador(10);
      Sumador sumador3 = new Sumador(0);

      Console.WriteLine(sumador1.Sumar(10, 10));
      Console.WriteLine(sumador1.Sumar("Hola ", "Mundo"));
      Console.WriteLine("\n--------------------------------\n");
      Console.WriteLine(sumador1|sumador2);
      Console.WriteLine(sumador1 + sumador2);
      Console.ReadKey();
    }
  }
}
