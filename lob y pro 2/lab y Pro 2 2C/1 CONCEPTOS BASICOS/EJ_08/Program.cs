using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int horasTrabajadas;
            int antiguedad;
            string nombre;

            Console.Write("Ingrese Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese antiguedad: ");
            aux = Console.ReadLine();
            if (int.TryParse(aux, out antiguedad))
            {
                Console.Write("Ingrese horas Trabajadas: ");
                aux = Console.ReadLine();
                if (int.TryParse(aux, out horasTrabajadas))
                {

                }
            }
        }
    }
}
