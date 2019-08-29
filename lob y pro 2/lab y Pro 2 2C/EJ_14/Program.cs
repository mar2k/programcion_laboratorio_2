using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculoDeArea.CalcularCuadrado(2));
            Console.WriteLine(CalculoDeArea.CalcularTriangulo(2, 5));
            Console.WriteLine(CalculoDeArea.CalcularCirculo(3));

            Console.ReadKey();
        }
    }
}
