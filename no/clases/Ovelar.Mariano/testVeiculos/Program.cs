using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;

namespace testVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a = new Auto("AA", 4, EMarca.Ford, 4);
            Moto m = new Moto("BB", 2, EMarca.Honda, 12);
            Camion c = new Camion("CC", 6, EMarca.Iveco, 1500);
            Lavadero l = new Lavadero(200,400,150);



            Console.WriteLine(a);
            Console.WriteLine(m);
            Console.WriteLine(c);



            Console.ReadKey();

        }
    }
}
