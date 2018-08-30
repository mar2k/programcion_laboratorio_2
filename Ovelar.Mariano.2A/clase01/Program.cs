using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase01
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.imprimirEnColor();
            //Sello.borrar();
            Console.WriteLine(Sello.imprimir());

            Console.ReadKey();
        }
    }
}
