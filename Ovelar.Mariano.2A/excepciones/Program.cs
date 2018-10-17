using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        clase_excepciones2.MetodoExcepciones();
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
      Console.ReadKey();
    }
  }
}
