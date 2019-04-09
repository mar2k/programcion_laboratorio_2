using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Tempera;

namespace test
{
  class Program
  {
    static void Main(string[] args)
    {
      Tempera tem1 = new Tempera(ConsoleColor.Blue, "AAAA", 124);
      Console.WriteLine(tem1);
      Paleta paleta = 3;

      Console.WriteLine((string)paleta);
      
      Console.ReadKey();


    }
  }
}
