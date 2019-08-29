using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoInicio;
            int anoFin;
            string aux;
            // bool esBisiesto;

            Console.Write("Ingrese año de Inicio: ");
            aux = Console.ReadLine();

            if (int.TryParse(aux, out anoInicio))
            {
                Console.Write("Ingrese año de Fin: ");
                aux = Console.ReadLine();

                if (int.TryParse(aux, out anoFin))
                {
                    for (int i = anoInicio; i <= anoFin; i++)
                    {
                        if (i % 4 == 0)
                        {
                            if (i % 100 == 0)
                            {
                                if (i % 400 == 0)
                                {
                                    Console.WriteLine("{0}", i);
                                }
                            }
                            else
                            {
                                Console.WriteLine("{0}", i);
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
