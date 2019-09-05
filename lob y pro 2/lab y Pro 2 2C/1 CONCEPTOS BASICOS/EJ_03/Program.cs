using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int valor;

            Console.Write("Ingrese Numero: ");
            aux = Console.ReadLine();

            if (int.TryParse(aux, out valor))
            {
                int i = 0;
                // Analizo todos los números entre 2 y el número ingresado
                for (int j = 2; j <= valor; j++)
                {
                    // Verifico si J es primo
                    for (i = 2; i < j; i++)
                    {
                        // Si tiene un divisor con resto cero, salgo ya que NO ES PRIMO
                        if ((j % i) == 0)
                        {
                            break;
                        }
                    }

                    if (i == j)
                    {
                        Console.WriteLine("{0} es primo", j);
                    }
                    //else
                    //    Console.WriteLine("{0} NO es primo", j);
                }
            }

            Console.ReadKey();
        }
    }
}
