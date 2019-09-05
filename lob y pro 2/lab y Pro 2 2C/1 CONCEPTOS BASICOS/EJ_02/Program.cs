using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int valor;
            double cuadrado = 0;
            double cubo = 0;
            bool flag = true;




            do
            {
                Console.Write("Ingrese Numero: ");
                aux = Console.ReadLine();
                if (int.TryParse(aux, out valor))
                {
                    if (valor <= 0)
                    {
                        Console.WriteLine("\nERROR. ¡Reingresar número!\n");
                    }
                    else
                    {
                        flag = false;
                    }
                }

            } while (flag);


            cuadrado = Math.Pow(valor, 2);
            cubo = Math.Pow(valor, 3);



            Console.WriteLine("\nCuadrado:{0} \nCubo:{1}", cuadrado, cubo);

            Console.ReadKey();
        }
    }
}
