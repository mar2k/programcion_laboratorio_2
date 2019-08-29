using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            string auxChar;
            int valor;
            int acum=0;

            for (; ;)
            {
                Console.Write("Ingrese Numero: ");
                aux = Console.ReadLine();

                while (aux == "")
                {
                    Console.Clear();

                    Console.Write("Ingrese un numero: ");
                    aux = Console.ReadLine();
                }

                 
                if (int.TryParse(aux, out valor))
                {
                    acum = acum + valor;
                    Console.Write("¿Continuar ? (S / N) ");
                    auxChar = Console.ReadLine();
                    while (auxChar.Length > 1)
                    {
                        Console.Clear();
                        Console.Write("¿Continuar ? (S / N) ");
                        auxChar = Console.ReadLine();

                    }
                    if (!ValidarRespuesta.ValidaS_N(auxChar))
                    {
                        Console.WriteLine(auxChar);
                        break;
                    }


                }
            }
            Console.ReadKey();
        }
    }
}
