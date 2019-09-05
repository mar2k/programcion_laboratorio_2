using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometría;

namespace PruebaGeometria
{
  class Program
  {
    static void Main(string[] args)
    {
      Punto punto1 = new Punto(2,10);
      Punto punto3 = new Punto(6,2);
      Rectangulo rectangulo1 = new Rectangulo(punto1,punto3);//4,8

      Console.WriteLine("Area: {0} Perimetro: {1}",rectangulo1.Area(),rectangulo1.Perimetro());

      Console.ReadKey();

    }
  }
}
