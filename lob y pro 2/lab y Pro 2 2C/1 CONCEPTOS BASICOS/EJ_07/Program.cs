using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 0;
            int mhoth = 0;
            int year = 0;
            string aux;

            DateTime fechaDeNacimiento = new DateTime();

            Console.Write("Ingrese dia: ");
            aux = Console.ReadLine();

            if (int.TryParse(aux, out day))
            {
                Console.Write("Ingrese mes: ");
                aux = Console.ReadLine();

                if (int.TryParse(aux, out mhoth))
                {
                    Console.Write("Ingrese año: ");
                    aux = Console.ReadLine();

                    if (int.TryParse(aux, out year))
                    {
                        fechaDeNacimiento = new DateTime(year, mhoth, day);
                    }
                }
            }
            Console.WriteLine("{0}-{1}-{2}", fechaDeNacimiento.Day,fechaDeNacimiento.Month,fechaDeNacimiento.Year);
            Console.ReadKey();
        }
    }
}
