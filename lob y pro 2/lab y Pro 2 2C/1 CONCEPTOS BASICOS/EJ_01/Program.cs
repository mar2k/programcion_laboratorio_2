using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;

            int valor;
            int numeroAcum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            int vueltasDoWhile = 0;
            int vueltasMax=5;

            float promedio;

            do
            {
                Console.Write("{0}_Ingrese Numero: ", vueltasDoWhile+1);
                aux = Console.ReadLine();

                if (int.TryParse(aux, out valor))
                {
                    numeroAcum = +valor;
                    if (valor < min)
                    {
                        min = valor;
                    }
                    else if (valor > max)
                    {
                        max = valor;
                    }
                    vueltasDoWhile++;
                }
                
            } while (vueltasDoWhile != vueltasMax);

            promedio = (float)numeroAcum / (float)vueltasDoWhile;

            Console.WriteLine("\nMin:{0} \nMax:{1} \nPromedio:{2:0.00}", min, max, promedio);
            Console.ReadKey();
        }
    }
}
