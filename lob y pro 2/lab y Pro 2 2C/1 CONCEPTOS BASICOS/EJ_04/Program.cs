using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 0;
            int max = 4;
            int numerosPerfectosEncontrados=0;
            for (int i = 1; ; i++)
            {
                aux = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        aux = aux + j;
                    }
                }
                if (i == aux)
                {
                    Console.WriteLine("{0} Es un numero perfecto", i);
                    numerosPerfectosEncontrados++;
                    if(numerosPerfectosEncontrados==max)
                    {
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
