using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int valor;
            int valorAux = 0;
            int acumAux;
            bool flag = true;

            Console.Write("Ingrese Numero: ");
            aux = Console.ReadLine();

            if (int.TryParse(aux, out valor))
            {
                for (int i = valor; i > 1; i--)
                {
                    valorAux = valorAux + i;
                    acumAux = 0;
                    for (int j = 1; j < i - 1; j++)
                    {
                        acumAux = acumAux + j;

                        if (acumAux > valorAux)
                        {
                            break;
                        }
                    }
                    if (acumAux == valorAux)
                    {
                        Console.WriteLine("{0} es el centro numérico entre 1 y {1}", i - 1, valor);
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("no tiene un centro numérico");
                }
            }
            Console.ReadKey();
        }
    }
}
