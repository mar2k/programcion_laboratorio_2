using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int valor;
            string puntos = "";

            Console.Write("Ingrese Numero: ");
            aux = Console.ReadLine();

            if (int.TryParse(aux, out valor))
            {
                if (valor > 0)
                {
                    puntos = "*";

                    for (int i = 0; i < valor; i++)
                    {
                        Console.WriteLine("{0}\n", puntos);
                        puntos = puntos + "**";
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
