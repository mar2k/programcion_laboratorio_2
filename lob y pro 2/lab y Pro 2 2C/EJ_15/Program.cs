using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            float numero1;
            float numero2;

            do
            {
                Console.Write("1)Ingrese Numero: ");
                aux = Console.ReadLine();
                if (!float.TryParse(aux, out numero1))
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("1)Reingrese Numero: ");
                        aux = Console.ReadLine();
                    } while (!float.TryParse(aux, out numero1));
                }

                Console.Write("2)Ingrese Numero: ");
                aux = Console.ReadLine();
                if (!float.TryParse(aux, out numero2))
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("2)Reingrese Numero: ");
                        aux = Console.ReadLine();
                    } while (!float.TryParse(aux, out numero1));
                }

                Console.Write("3)Ingrese Operador(+,-,*,/): ");
                aux = Console.ReadLine();

                if (aux != "+" && aux != "-" && aux != "*" && aux != "/")
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("3)Reingrese Operador(+,-,*,/): ");
                        aux = Console.ReadLine();
                    } while (aux != "+" && aux != "-" && aux != "*" && aux != "/");
                }

                Console.Clear();
                Console.Write("{0} {1} {2} = ", numero1, aux, numero2);
                Console.WriteLine(Calculadora.Calcular(numero1, numero2, aux));

                Console.Write("¿Continuar ? (S / N) ");
                aux = Console.ReadLine();

            } while (aux=="s"|| aux == "S");
            
        }
    }
}
