using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int valor;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese Numero: ");
                aux = Console.ReadLine();

                if (int.TryParse(aux, out valor))
                {
                    Console.WriteLine(Validacion.Validar(valor, -100, 100));
                }
            }
        }
    }
}
