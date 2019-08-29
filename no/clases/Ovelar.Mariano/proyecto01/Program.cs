using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto01
{
  class Program
  {
    static void Main(string[] args)
    {
      String nombre="";

      Console.WriteLine("HOLA MUNDO C#");
      Console.ReadKey();

      Console.Write("INGRESE NOMBRE: ");
      nombre=Console.ReadLine();
      Console.Write("EL NOMBRE INGRESADO ES: {0}",nombre);

      Console.ReadKey();
    }
  }
}
