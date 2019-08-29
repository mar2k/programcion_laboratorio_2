using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa newCosa = new Cosa();

            Console.WriteLine(Cosa.mostrar(newCosa));

            Console.ReadKey();
        }
    }
}
