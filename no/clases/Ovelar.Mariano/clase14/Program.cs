using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.clase._14;

namespace clase14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("A)ingrese numero: ");
            if(!ParseadoraDeEnteros.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("valor invalido!!!!");
            }
            try
            {
                Console.WriteLine("B)ingrese numero: ");
                b = ParseadoraDeEnteros.Parse(Console.ReadLine());
            }
            catch (ErrorParserException e)
            {
                Console.WriteLine("Caught: {0}", e.Message);
                if (e.InnerException != null)
                {
                    Console.WriteLine("Inner exception: {0}", e.InnerException);
                }

            }
            Console.ReadKey();
        }
    }
}
