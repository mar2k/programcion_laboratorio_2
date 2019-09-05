using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //string aux;
            //int valor;
            string puntos = "*";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}\n", puntos);
                puntos = puntos + "**";
            }

            Console.ReadKey();
        }
    }
}
